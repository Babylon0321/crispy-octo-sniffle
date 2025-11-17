# CalcAdd（計算アプリケーション）

## 概要

CalcAddは、簡単な計算を行うC#コンソールアプリケーションです。現在、整数の加算機能を提供しています。

## 必要環境

- .NET 8.0 以上
- Windows、macOS、またはLinux

## 使用方法

### プロジェクトのビルド

プロジェクトをビルドするには、以下のコマンドを実行してください：

```bash
cd CalcAdd
dotnet build
```

### プログラムの実行

アプリケーションを実行するには、以下のコマンドを実行してください：

```bash
cd CalcAdd
dotnet run
```

実行すると、2と3の加算結果が表示されます：

```
Hello, World!
2 + 3 = 5
```

### テストの実行

単体テストを実行するには、以下のコマンドを実行してください：

```bash
cd CalcAdd.Tests
dotnet test
```

## プロジェクト構成

```
crispy-octo-sniffle/
├── CalcAdd/                    # メインアプリケーション
│   ├── Program.cs              # エントリーポイント
│   ├── Calculator.cs           # 計算機能を提供するクラス
│   ├── CalcAdd.csproj          # プロジェクトファイル
│   └── CalcAdd.sln             # ソリューションファイル
└── CalcAdd.Tests/              # 単体テスト
    ├── CalculatorTest.cs       # Calculatorクラスのテスト
    └── CalcAdd.Tests.csproj    # テストプロジェクトファイル
```

### 主要なファイルの説明

- **Program.cs**: アプリケーションのメインエントリーポイント。Calculatorクラスを使用して加算を実行します。
- **Calculator.cs**: `Add`メソッドを提供するCalculatorクラス。2つの整数を受け取り、その合計を返します。
- **CalculatorTest.cs**: Calculatorクラスの動作を検証する単体テスト。様々なケース（正の数、負の数、ゼロ、オーバーフロー等）をテストします。

## 機能

- **加算機能**: 2つの整数を加算する`Add`メソッドを提供
- **包括的なテスト**: 正常系、異常系、境界値テストを含む単体テスト

## 作成者情報

このプロジェクトは学習目的で作成されたC#コンソールアプリケーションです。
