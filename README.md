# Minimal Web API のサンプルコード

Build 2021 のセッション
.NET 6 deep dive; what's new and what's coming | OD485
　  
https://www.youtube.com/watch?v=GJ_PaRNDe9E
　  
などで紹介された Minimal Web API について、セッション内でコードの一部は画面で見ることができましたが、公式のサンプルコードの紹介はありませんでした。
　  
　  
具体的などのようなコードになるかを確認するために、.NET6 RC1 でサンプルコードを作成しました。 
　  
　  
## プロジェクト
- MinimalWebAPISample
Minimal Web API のサンプルです。
　  
- MVCWebAPISample
従来からある ASP.NET Core Web API のサンプルです。
　  
　  
両者は同じ結果を返す API になっていますので、MVCWebAPISample と比べて Minimal Web API でどれだけコードが少なくなるかを確認できます。
　  
　  
## 注意点
- Minimal Web API のコードは、セッションの内容と .NET6 RC1 SDK を調査した結果から独自に作成したコードですので、正式リリースの .NET6 では動作しなかったり、違うコードになる可能性があります。
　  
　  
## System Requirements
以下の Windows, に対応した Visual Studio 2022 Preview 最新版と .NET 6 SDK RC1 をインストールしてください。Visual Studio 2019 では動作しません。
なお、Windows では Visual Studio 2022 Preview と Visual Studio 2019 はサイドバイサイドで動作し、共存可能です。
　  
　  
### Windows
- Visual Studio 2022 Preview
　  
[https://visualstudio.microsoft.com/ja/vs/preview/#download-preview](https://visualstudio.microsoft.com/ja/vs/preview/#download-preview?WT.mc_id=DT-MVP-5002467)
　  
- SDK 6.0.100-rc.1
　  
[https://dotnet.microsoft.com/download/dotnet/6.0](https://dotnet.microsoft.com/download/dotnet/6.0?WT.mc_id=DT-MVP-5002467)
　  
　  
## 特長
Minimal Web API のコードは Program.cs ファイルにすべてが記述できており、特に行数が少なくなるようなことはしておりませんが、30行以内に収まっています。
　  
　  
ASP.NET Core Web API のコードと比較すると直感的にわかりやすく、簡単な Mock API やシンプルな API を作成するシナリオに利用できそうです。
　  
　  
### APIのエンドポイント（Minimal Web API, ASP.NET Core Web API 共通）
| エンドポイント | メソッド | レスポンス |
|:---|:---|:---|
| / | Get | "Hello World!"文字列を固定で返却 |
| /plant | Get | レスポンス：植物名（サボテン）のオブジェクト（JSON）を固定で返却 |
| /weatherforecast | Get | ランダムな天候を表すオブジェクトのリスト（JSON）を返却 |