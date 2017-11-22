var fs = require('fs');
var readline = require('readline');
var path = require('path');

var post_merge_path = path.join(process.cwd(), '.git', 'hooks', 'post-merge');
var umm_config_path = process.env[process.platform == "win32" ? "USERPROFILE" : "HOME"] + '/.umm-config.json';

var command_detect_changed_files = "changed_files=\"$(git diff-tree -r --name-only --no-commit-id ORIG_HEAD HEAD)\"";

var comment_begin   = "# umm: automatic updator: BEGIN";
var comment_end     = "# umm: automatic updator: END";
var comment_command = "# umm: automatic updator:   for ";

var umm_config = {};
var package_info = {};

var loadUMMConfig = (callback) => {
  if (process.argv.length <= 2) {
    console.error('Please specify the package_name as the first argument.');
    return;
  }
  if (!process.argv[2].match(/@/)) {
    console.warn('Recommend you to create as scoped package');
  }

  fs.access(
    path.resolve(umm_config_path),
    fs.constants.R_OK,
    (err) => {
      if (err) {
        callback();
        return;
      }
      fs.readFile(
        path.resolve(umm_config_path),
        'utf8',
        (err, data) => {
          umm_config = JSON.parse(data);

          package_info.package_name = process.argv.length > 2 ? process.argv[2] : "";
          package_info.description = process.argv.length > 3 ? process.argv[3] : "";
          package_info.scope = '';
          package_info.module_name = package_info.package_name;
          package_info.repository = {
            'type': '',
            'host': '',
            'group': '',
            'user': ''
          };
          package_info.license = '';
          package_info.author = {
            'name': '',
            'email': '',
            'url': ''
          };
          package_info.copyright = {
            'name': '',
            'year': new Date().getFullYear()
          };
          if (package_info.package_name.match(/^(@[^\/]+)\/(.+)$/)) {
            package_info.scope = RegExp.$1;
            package_info.module_name = RegExp.$2;
            if (umm_config['scopes'][package_info.scope]) {
              package_info.repository = umm_config['scopes'][package_info.scope]['repository'];
              package_info.author = umm_config['scopes'][package_info.scope]['author'];
              package_info.license = umm_config['scopes'][package_info.scope]['license'];
            }
          }
          package_info.repository.name = package_info.module_name;
          package_info.copyright.name = package_info.author.name;

          callback();
        }
      )
    }
  );
};

var replacePlaceholder = (file_path) => {
  fs.access(
    file_path,
    fs.constants.R_OK | fs.constants.W_OK,
    (err) => {
      if (err) {
        console.error(err);
        return;
      }
      fs.readFile(
        file_path,
        'utf8',
        (err, data) => {
          if (err) {
            console.error(err);
            return;
          }
          data = data.replace(/__PACKAGE_NAME__/g, package_info.package_name);
          data = data.replace(/__DESCRIPTION__/g, package_info.description);
          data = data.replace(/__REPOSITORY_TYPE__/g, package_info.repository.type);
          data = data.replace(/__REPOSITORY_HOST__/g, package_info.repository.host);
          data = data.replace(/__REPOSITORY_GROUP__/g, package_info.repository.group);
          data = data.replace(/__REPOSITORY_NAME__/g, package_info.repository.name);
          data = data.replace(/__REPOSITORY_USER__/g, package_info.repository.user);
          data = data.replace(/__REPOSITORY_SITE__/g, package_info.repository.host.replace(/^([^.]+)\..*$/, '$1'));
          data = data.replace(/__AUTHOR_NAME__/g, package_info.author.name);
          data = data.replace(/__AUTHOR_EMAIL__/g, package_info.author.email);
          data = data.replace(/__AUTHOR_URL__/g, package_info.author.url);
          data = data.replace(/__LICENSE__/g, package_info.license);
          data = data.replace(/__COPYRIGHT_NAME__/g, package_info.copyright.name);
          data = data.replace(/__COPYRIGHT_YEAR__/g, package_info.copyright.year);

          fs.writeFile(
            file_path,
            data,
            'utf8',
            (err) => {
              if (err) {
                console.error(err);
                return;
              }
            }
          );
        }
      );
    }
  );
};

var installUpdator = (target_file, command) => {
  fs.access(
    post_merge_path,
    fs.constants.R_OK | fs.constants.W_OK,
    (err) => {
      if (err) {
        return;
      }
      var stream = fs.createReadStream(post_merge_path, 'utf8');
      var reader = readline.createInterface({ input: stream });
      var lines = [];
      var exists_block = false;
      var inside_block = false;
      var skip_insert_line = 0;
      var generateCommandLine = (target_file, command) => {
        return "echo \"\$changed_files\" | grep --quiet \"" + target_file + "\" && eval \"" + command + "\"";
      };
      var generateCommentLine = (target_file) => {
        return comment_command + target_file;
      };
      reader
      .on(
        'line',
        (line) => {
          if (new RegExp("^" + comment_begin).test(line)) {
            /* アップデータの開始行を検知した場合 */
            lines.push(line);
            lines.push(command_detect_changed_files);
            exists_block = true;
            skip_insert_line = 2;
          } else if (new RegExp("^" + comment_end).test(line)) {
            /* アップデータの終了行を検知した場合 */
            // 対象のファイルに関する監視を追加
            lines.push(generateCommentLine(target_file));
            lines.push(generateCommandLine(target_file));
            lines.push(line);
            skip_insert_line = 1;
          } else if (new RegExp("^" + comment_command + target_file).test(line)) {
            /* 対象のコマンド行を検知した場合 */
            // 行の追加スキップを予約
            skip_insert_line = 2;
          }
          if (skip_insert_line > 0) {
            skip_insert_line--;
            return;
          }
          lines.push(line);
        }
      )
      .on(
        'close',
        () => {
          if (!exists_block) {
            /* 未追加の場合にはブロックごと新規追加 */
            lines.push('');
            lines.push(comment_begin);
            lines.push(command_detect_changed_files);
            lines.push(generateCommentLine(target_file));
            lines.push(generateCommandLine(target_file, command));
            lines.push(comment_end);
          }

          // ファイル書き込み
          fs.writeFileSync(post_merge_path, lines.join("\n"), { mode: 0o755 });

          console.log('Install umm updator');
        }
      );
    }
  );
}

loadUMMConfig(
  () => {
    replacePlaceholder('package.json');
    replacePlaceholder('README.md');
    installUpdator('package-lock.json', 'npm run umm:clean && npm install');
  }
);

// vim:set ft=javascript et sw=2 sts=2:
