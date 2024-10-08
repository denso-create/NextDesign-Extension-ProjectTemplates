## 概要
* Next Designのエクステンション開発のためのプロジェクトテンプレートです。
* dotnetのCLIおよび、Visual Studioで利用できます。

> **Notice:**
> 本ライブラリはNext Design V2以降が対象のプロジェクトテンプレートです。Next Design V1.Xでは利用できません。

## インストール方法
* コマンドプロンプトより次のように実行して下さい。

```
> dotnet new install NextDesign.Extension.ProjectTemplates
```

正常にインストールが完了している場合は次のコマンドを実行すると

```
> dotnet new 
```

このように表示されます。

```
テンプレート名                                 短い名前  言語  タグ
---------------------------------------------  --------  ----  -----------
...
Next Design V3.1 Extension                     nd31ext   [C#]  Next Design
Next Design V3.1 Extension (Extension Points)  nd31extp  [C#]  Next Design
Next Design V4.0 Extension                     nd4ext    [C#]  Next Design
Next Design V4.0 Extension (Extension Points)  nd4extp   [C#]  Next Design
...

```

## 利用方法

* 次のように実行するとNext Design V4.0向けのエクステンションのプロジェクトを作成できます。（V3.1向けのプロジェクトを作成する際は「nd4ext」を「nd31ext」に変更してください）

```
> dotnet new nd4ext -n MyExt1
```

* また、よりシンプルにエクステンションの開発が可能な、[NextDesign.Desktop.ExtensionPoints](https://www.nuget.org/packages/NextDesign.Desktop.ExtensionPoints/)を利用したエクステンションのプロジェクトも作成可能です。（V3.1向けのプロジェクトを作成する際は「nd4extp」を「nd31extp」に変更してください）

```
> dotnet new nd4extp -n MyExt2
```

* また、Visual Studioの新規プロジェクト作成のダイアログでも作成可能です。


## パッケージのアンインストール方法
次のコマンドを実行して下さい。

```
> dotnet new uninstall NextDesign.Extension.ProjectTemplates
```

## ライセンス
本ライブラリはMITライセンスです。詳細は[LICENSE](https://github.com/denso-create/NextDesign-Extension-ProjectTemplates/blob/main/LICENSE) を確認してください。

