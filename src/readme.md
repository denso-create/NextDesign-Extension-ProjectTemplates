## 1. 概要
* Next Designのエクステンション開発のためのプロジェクトテンプレートです。
* dotnetのCLIおよび、Visual Studioで利用できます。

> **Notice:**
> 本ライブラリはNext Design V2以降が対象のプロジェクトテンプレートです。Next Design V1.Xでは利用できません。

- [1. 概要](#1-概要)
- [2. インストール方法](#2-インストール方法)
- [3. 利用方法](#3-利用方法)
- [4. パッケージのアンインストール方法](#4-パッケージのアンインストール方法)
- [5. ライセンス](#5-ライセンス)

## 2. インストール方法
* コマンドプロンプトより次のように実行して下さい。

```
> dotnet new install NextDesign.Extension.ProjectTemplates
```

正常にインストールが完了している場合は次のコマンドを実行すると

```
> dotnet new list
```

このように表示されます。

```
テンプレート名                            短い名前  言語  タグ
----------------------------------------  --------  ----  -----------
...
Next Design Extension                     ndext     [C#]  Next Design
Next Design Extension (Extension Points)  ndextp    [C#]  Next Design
...

```

## 3. 利用方法
* 次のように実行するとエクステンションのプロジェクトを作成できます。

```
> dotnet new ndext -n MyExt1
```

* また、よりシンプルにエクステンションの開発が可能な、[NextDesign.Desktop.ExtensionPoints](https://www.nuget.org/packages/NextDesign.Desktop.ExtensionPoints/)を利用したエクステンションのプロジェクトも作成可能です。

```
> dotnet new ndextp -n MyExt2
```

* また、Visual Studioの新規プロジェクト作成のダイアログでも作成可能です。


## 4. パッケージのアンインストール方法
次のコマンドを実行して下さい。

```
> dotnet new uninstall NextDesign.Extension.ProjectTemplates
```

## 5. ライセンス
本ライブラリはMITライセンスです。詳細は[LICENSE](https://github.com/denso-create/NextDesign-Extension-ProjectTemplates/blob/main/LICENSE) を確認してください。

---

## 1. Overview
* This is a project template for developing extensions for Next Design.
* It can be used with dotnet CLI and Visual Studio.

> **Notice:**
> This library is a project template for Next Design V2 and later. It cannot be used with Next Design V1.X.

- [1. Overview](#1-overview)
- [2. Installation method](#2-installation-method)
- [3. How to use](#3-how-to-use)
- [4. How to uninstall the package](#4-how-to-uninstall-the-package)
- [5. License](#5-license)

## 2. Installation method
* Run the following from the command prompt.

```
> dotnet new install NextDesign.Extension.ProjectTemplates
```

If the installation has been completed successfully, run the following command

```
> dotnet new list
```

The following will be displayed.

```
Template name                             Short name  Language Tag
----------------------------------------  ----------  ----     -----------
...
Next Design Extension                     ndext       [C#]     Next Design
Next Design Extension (Extension Points)  ndextp      [C#]     Next Design
...
```

## 3. How to use
* You can create an extension project by executing the following.

```
> dotnet new ndext -n MyExt1
```

* You can also create an extension project using [NextDesign.Desktop.ExtensionPoints](https://www.nuget.org/packages/NextDesign.Desktop.ExtensionPoints/), which allows you to develop extensions more simply.

```
> dotnet new ndextp -n MyExt2
```

* You can also create it in the Visual Studio new project creation dialog.

## 4. How to uninstall the package
Execute the following command.

```
> dotnet new uninstall NextDesign.Extension.ProjectTemplates
```

## 5. License
This library is licensed under the MIT License. Please see [LICENSE](https://github.com/denso-create/NextDesign-Extension-ProjectTemplates/blob/main/LICENSE) for details.