var mkdirp = require('mkdirp');
var path = require('path');
var package = require('../../package.json');
var ncp = require('ncp').ncp;

var script_directory = __dirname;
// パッケージ名が @ で始まるならスコープ有りと見なす
var has_scope = /^@/.test(package.name);

if ('node_modules' != path.basename(path.resolve(script_directory, (has_scope ? '../' : '') + '../../../'))) {
  // 開発インストールの場合無視する
  return;
}

// パッケージ名を決定
//   (ネームスペースを持つ場合、そのまま namespace + @ をプレフィックスにする)
var package_name = '';
if (/^@/.test(package.name)) {
  package_name = package.name.replace(
    /^@([^\/]+)\/(.*)$/,
    function(match, namespace, name) {
      return namespace + '@' + name;
    }
  );
} else {
  package_name = package.name;
}

// スクリプトの存在するディレクトリから見たパス
var source = path.resolve(script_directory, '../../Assets');
var destination = path.resolve(script_directory, (has_scope ? '../' : '') + '../../../../Assets/Modules/' + package_name);

// 宛先ディレクトリを作る (mkdir -p)
mkdirp(destination, function(err) {
  if (err) {
    console.error(err);
    process.exit(1);
  }

  ncp(
    source,
    destination,
    function(err) {
      if (err) {
        console.error(err);
        process.exit(1);
      }
    }
  );
});
