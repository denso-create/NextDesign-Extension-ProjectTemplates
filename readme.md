# Next Design Extension Project Templates

- [概要](#概要)
- [リリースノート](#リリースノート)
- [利用方法](#利用方法)
- [テンプレートの開発](#テンプレートの開発)
- [パッケージの作成方法](#パッケージの作成方法) 
- [nuget.orgへのパッケージの公開方法](#nugetorgへのパッケージの公開方法)
  - [ローカルから公開する方法](#ローカルから公開する方法)
  - [Github Actionsによる公開](#github-actionsによる公開)
- [ライセンス](#ライセンス)

## 概要
* Next Designのエクステンション開発のためのプロジェクトテンプレートです。
* dotnetのCLIおよび、Visual Studioで利用できます。
* [Nuget.orgで公開](https://www.nuget.org/packages/NextDesign.Extension.ProjectTemplates/)しています。
* コマンドラインツール [NDExt](https://www.nuget.org/packages/NDExt/)を利用すると便利です。

> **Notice:**
> 本ライブラリはNext Design V2以降が対象のプロジェクトテンプレートです。Next Design V1.Xでは利用できません。

## リリースノート
* バージョンごとの変更点については、[リリースノート](releasenotes.md)を参照して下さい。

## 利用方法
インストールすると、Visual Studioで次のようにプロジェクトテンプレートを選択できるようになります。

![](images/vs2022-new-project-dialog.png)

インストール方法はこちらの[readme](src/readme.md)を参照して下さい。

また、[エクステンション開発者向けのドキュメントでも公開](https://docs.nextdesign.app/extension/docs/libs/ProjectTemplates/intro)しています。

> **Notice:**
> Visual Studio 2019と2022の両方の環境をインストールした場合は、Visual Studio 2022でのみプロジェクトテンプレートが表示されるようになります。

## テンプレートの開発
プロジェクトテンプレートについては次の記事を参考にして下さい。
* [dotnet new のカスタム テンプレート](https://docs.microsoft.com/ja-jp/dotnet/core/tools/custom-templates)
* [.NET CLI Templates in Visual Studio](https://devblogs.microsoft.com/dotnet/net-cli-templates-in-visual-studio/)
* [how to create templates that work in dotnet new and Visual Studio/Visual Studio for Mac](https://github.com/sayedihashimi/template-sample)
* [How do I ship multiple `dotnet new` templates inside a single NuGet package?](https://stackoverflow.com/questions/58325232/how-do-i-ship-multiple-dotnet-new-templates-inside-a-single-nuget-package)

## パッケージの作成方法

[こちら](https://github.com/miles-team/NextDesign/wiki/エクステンション開発プロジェクトテンプレート-パッケージ作成手順)を参照してください。

## nuget.orgへのパッケージの公開方法

> 原則、Github Actinsによる公開をして下さい。

### ローカルから公開する方法

1. 事前準備
   * nuget.orgで `densocreate`の組織に所属するアカウントを登録して下さい。
   * nuget.orgの管理ページからApiキーを取得し、環境変数 `NUGET_APIKEY` をセットして下さい。
2. 公開
   * `publish.cmd`を実行して下さい。

上記方法で公開できない場合は以下手順で公開します。
1. [nuget.org](https://www.nuget.org/)にアクセスし、サインインする
2. [Upload]タブを開く
3. [Browse...]ボタンを押下し、アップロードするnugetパッケージを選択し、アップロードする

### Github Actionsによる公開
* `publish`ブランチにマージすると自動的に https://www.nuget.org/packages/NextDesign.Extension.ProjectTemplates に公開されます。
  * `main`ブランチから`publish`ブランチにマージするためのプルリクを作成し、管理者にApproveしてもらったのちにマージする。
* [publish to nugetアクション](https://github.com/denso-create/NextDesign-Extension-ProjectTemplates/actions/workflows/publish.yml)で実行しています。

## ライセンス
本ライブラリはMITライセンスです。詳細は[LICENSE](./LICENSE) を確認してください。
