var execSync = require('child_process').execSync;

var project_config_path = '../../umm_project.json';

// 配置先ディレクトリを全削除
fs.access(
  project_config_path,
  fs.constants.R_OK | fs.constants.W_OK,
  function(err) {
    //
    if (!err) {
      var project_config = require(project_config_path);
      if (project_config && project_config.projects) {
        var projects = project_config.projects;

        Object.keys(projects).forEach(
          (key) => {
            var project_directory = `projects/${projects[key].name}`;
            execSync(`rm -Rf ${project_directory}/node_modules`);
            execSync(`rm -Rf ${project_directory}/Assets/Modules`);
          }
        );
        execSync(`rm -Rf Assets/Projects`);
      }
    }
    execSync(`rm -Rf node_modules`);
    execSync(`rm -Rf Assets/Modules`);
  }
);
