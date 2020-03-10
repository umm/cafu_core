# What

* **C**lean **A**rchitecture **F**or **U**nity

# Requirement

* Unity 2019.2

# Install

### With Unity Package Manager

```bash
upm add package dev.upm-packages.cafu-core
```

Note: `upm` command is provided by [this repository](https://github.com/upm-packages/upm-cli).

You can also edit `Packages/manifest.json` directly.

```jsonc
{
  "dependencies": {
    // (snip)
    "dev.upm-packages.cafu-core": "[latest version]",
    // (snip)
  },
  "scopedRegistries": [
    {
      "name": "Unofficial Unity Package Manager Registry",
      "url": "https://upm-packages.dev",
      "scopes": [
        "dev.upm-packages"
      ]
    }
  ]
}
```

### Any other else (classical umm style)

```shell
yarn add "umm/cafu_core#^3.0.0"
```

# Usage

* See [Wiki](https://github.com/umm/cafu_core/wiki)

# Sample

* See [this repository](https://github.com/monry/cafu_sample)

# License

Copyright (c) 2017-2018 Tetsuya Mori

Released under the MIT license, see [LICENSE.txt](LICENSE.txt)
