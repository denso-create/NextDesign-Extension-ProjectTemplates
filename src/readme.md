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

* ターゲットフレームワークは `.NET 10` が既定で、`.NET 8` も選択できます。

```
> dotnet new ndext -n MyExt1 --Framework net8.0
```

* また、よりシンプルにエクステンションの開発が可能な、[NextDesign.Desktop.ExtensionPoints](https://www.nuget.org/packages/NextDesign.Desktop.ExtensionPoints/)を利用したエクステンションのプロジェクトも作成可能です。

```
> dotnet new ndextp -n MyExt2
```

```
> dotnet new ndextp -n MyExt2 --Framework net8.0
```

* また、Visual Studioの新規プロジェクト作成のダイアログでも作成可能です。


## 4. パッケージのアンインストール方法
次のコマンドを実行して下さい。

```
> dotnet new uninstall NextDesign.Extension.ProjectTemplates
```

## 5. ライセンス　/　免責事項
本拡張機能は、Next Designの使用許諾契約書におけるサンプルとして提供されています。サンプルに関する取り扱い、および免責事項については、Next Designの使用許諾契約書（[使用許諾契約 | システム・ソフトウェア設計ツール Next Design](https://www.nextdesign.app/support/agreements/)）に準拠します。ご利用にあたっては、当該使用許諾契約書の内容をご確認ください。

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

* `.NET 10` is the default target framework, and you can also choose `.NET 8`.

```
> dotnet new ndext -n MyExt1 --Framework net8.0
```

* You can also create an extension project using [NextDesign.Desktop.ExtensionPoints](https://www.nuget.org/packages/NextDesign.Desktop.ExtensionPoints/), which allows you to develop extensions more simply.

```
> dotnet new ndextp -n MyExt2
```

```
> dotnet new ndextp -n MyExt2 --Framework net8.0
```

* You can also create it in the Visual Studio new project creation dialog.

## 4. How to uninstall the package
Execute the following command.

```
> dotnet new uninstall NextDesign.Extension.ProjectTemplates
```

## 5. License / Disclaimer
This extension is provided as a sample under the Next Design License Agreement. The handling of samples and the disclaimer are governed by the Next Design License Agreement ([License Agreement | Next Design, System and Software Design Tool](https://www.nextdesign.app/support/agreements/)). Before using this extension, please review the contents of the applicable license agreement.