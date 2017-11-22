var fs = require('fs');
var mkdirp = require('mkdirp');
var path = require('path');
var rimraf = require('rimraf');
var package = require('../../package.json');

var script_directory = __dirname;
// パッケージ名が @ で始まる場合はスコープ有りと見なす
var has_scope = /^@/.test(package.name);

if ('node_modules' != path.basename(path.resolve(script_directory, (has_scope ? '../' : '') + '../../../'))) {
  // 開発インストールの場合無視する
  return;
}

// スクリプトの存在するディレクトリから見たパス
var destination = path.resolve(script_directory, (has_scope ? '../' : '') + '../../../../Assets/Modules');
// パッケージ名を PascalCase にして付与
//   (ネームスペースを持つ場合、そのまま namespace + @ をプレフィックスにする)
if (/^@/.test(package.name)) {
  destination += '/' + package.name.replace(
    /^@([^\/]+)\/(.*)$/,
    function(match, namespace, package_name) {
      return namespace + '@' + package_name;
    }
  );
} else {
  destination += '/' + package.name;
}

// 配置先ディレクトリを全削除
fs.access(
  destination,
  fs.constants.R_OK | fs.constants.W_OK,
  function(err) {
    if (err && err.code == 'ENOENT') {
      return;
    }
    rimraf(
      destination,
      function(_) {
        // Do nothing.
      }
    );
  }
);
