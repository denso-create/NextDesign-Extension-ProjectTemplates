# Next Design Extension Project Templates

- [概要](#概要)
- [リリースノート](#リリースノート)
- [利用方法](#利用方法)
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
> 本ライブラリはNext Design V2が対象のプロジェクトテンプレートです。Next Design V1.Xでは利用できません。

## リリースノート
* バージョンごとの変更点については、[リリースノート](releasenotes.md)を参照して下さい。

## 利用方法
こちらの[readme](src/readme.md)を参照して下さい。
## nuget.orgへのパッケージの公開方法

### ローカルから公開する方法
1. 事前準備
   * nuget.orgで `densocreate`の組織に所属するアカウントを登録して下さい。
   * nuget.orgの管理ページからApiキーを取得し、環境変数 `NUGET_APIKEY` をセットして下さい。
2. 公開
   * `publish.cmd`を実行して下さい。

### Github Actionsによる公開
* [publish to nugetアクション](https://github.com/denso-create/NextDesign-Extension-ProjectTemplates/actions/workflows/publish.yml)を用いて下さい。


## ライセンス
本ライブラリはMITライセンスです。詳細は[LICENSE](./LICENSE) を確認してください。
