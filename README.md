# Minimal Web API のサンプルコード

Build 2021 のセッション
.NET 6 deep dive; what's new and what's coming | OD485
　  
https://www.youtube.com/watch?v=GJ_PaRNDe9E
　  
などで紹介された Minimal Web API について、セッション内でコードの一部は画面で見ることができましたが、公式のサンプルコードの紹介はありませんでした。
　  
具体的などのようなコードになるかを確認するために、.NET Preview 4 で実現できる範囲でサンプルコードを作成しました。 
　  
　  
## プロジェクト ##
- MinimalWebAPISample
Minimal Web API のサンプルです。
　  
- MVCWebAPISample
従来からある ASP.NET Core Web API のサンプルです。
　  
　  
両者は同じ結果を返すAPIになっていますので、Minimal Web API でどれだけコードが少なくなるかを確認できます。
　  
　  
## 注意点 ##
Minimal Web API のコードは、セッションの内容と.NET6 Preview4 SDK を調査した結果から独自に作成したコードですので、正式リリースの .NET6 では動作しなかったり、コードが変更になる可能性があります。
　  
SDKを調査した結果、セッションで紹介されたものと全く同じコードではビルドできませんでしたので、実際に動作するコードの範囲で最もセッションで紹介されたコードに近くなるようなコードになっています。
　  
　  
## System Requirements ##
以下の Visual Studio 2019 Preview と .NET 6 SDK プレビューをインストールしてください。
なお、Windows では Visual Studio 2019 Preview と Visual Studio 2019 はサイドバイサイドで動作し、共存可能です。
　  
- Microsoft Visual Studio 2019 Preview Version 16.11.0 Preview 1.0
　  
[https://docs.microsoft.com/ja-jp/visualstudio/releases/2019/release-notes-preview](https://docs.microsoft.com/ja-jp/visualstudio/releases/2019/release-notes-preview?WT.mc_id=DT-MVP-5002467)
　  
- SDK 6.0.100-preview.4 Full version 6.0.100-preview.4.21255.9
　  
[https://dotnet.microsoft.com/download/dotnet/6.0](https://dotnet.microsoft.com/download/dotnet/6.0?WT.mc_id=DT-MVP-5002467)
　  
　  
## 特長 ##
Minimal Web API のコードはProgram.csファイルにすべてが記述できており、特に行数が少なくなるようなことはしておりませんが、30行以内に収まっています。
　  
ASP.NET Core Web API のコードと比較すると直感的にわかりやすく、簡単な Mock API やシンプルなAPIを作成するシナリオには最適です。
　  
### APIのエンドポイント（Minimal Web API, ASP.NET Core Web API）共通 ###
- エンドポイント：/　メソッド：Get　レスポンス："Hello World!"文字列を固定で返却
- エンドポイント：/plant　メソッド：Get　レスポンス：植物名（サボテン）のオブジェクト（JSON）を固定で返却
- エンドポイント：/weatherforecast　メソッド：Get　レスポンス：ランダムな天候を表すオブジェクトのリスト（JSON）を返却

