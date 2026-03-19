# AINewsFetcher

AI に関する最新ニュースを自動で取得し、翻訳・要約してメールで送信する C# コンソールアプリです。  
毎朝自動で実行することで、AI関連の情報収集を効率化できます。

---

## 📌 主な機能

- Google News RSS から AI 関連ニュースを取得
- RSS を解析してタイトル・本文を抽出
- Azure OpenAI / Copilot API を使った翻訳・要約（予定）
- Outlook / Graph API を使ったメール送信（予定）
- Windows タスクスケジューラで毎朝自動実行（予定）

---

## 🚀 使い方

1. このリポジトリをクローン  
2. Visual Studio で `AiNewsFetcher.sln` を開く  
3. `appsettings.json` に API キーなどを設定（実装後）  
4. 実行ボタンを押すだけでニュースを取得できます

---

## 🛠 技術構成

- C# / .NET
- HttpClient による RSS 取得
- LINQ to XML による RSS パース
- Azure OpenAI / Copilot API（翻訳・要約）
- Outlook / Graph API（メール送信）

---

## 📅 今後のアップデート予定

- [ ] ニュースタイトルの抽出  
- [ ] AI による翻訳・要約  
- [ ] メール本文の自動生成  
- [ ] 毎朝自動実行の設定ガイド  
- [ ] GUI 版（WPF / WinUI）も検討中  

---

## 📄 ライセンス

MIT License
