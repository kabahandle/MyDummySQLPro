using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace MyDummySQL.Classes
{
    //ログを作成するクラス　TraceSource を継承し、カスタマイズ
    //コンストラクタで与えられるログファイル名のファイルに、
    //ログを出力する。
    //
    //ログファイルにログメッセージを書き込みたい場合は、
    //　・DoLogWithDate()メソッド
    //をメッセージつきで呼び出すこと。
    //ログ日時は自動的に付加される。
    //
    //参考URL：http://dobon.net/vb/dotnet/programing/tracesource.html
    public class MyTraceSource : TraceSource
    {
        //TraceSourceのリスナー名（固定する）
        public readonly string ListenerName = "LogFile";

        public string StrgSwitchLevel
        {
            get
            {
                return this.Switch.Level.ToString();
            }
            set
            {
                switch (value)
                {
                    case "All":
                        this.Switch.Level = System.Diagnostics.SourceLevels.All;
                        break;
                    case "Critical":
                        this.Switch.Level = System.Diagnostics.SourceLevels.Critical;
                        break;
                    case "Error":
                        this.Switch.Level = System.Diagnostics.SourceLevels.Error;
                        break;
                    case "Warning":
                        this.Switch.Level = System.Diagnostics.SourceLevels.Warning;
                        break;
                    case "Infomation":
                        this.Switch.Level = System.Diagnostics.SourceLevels.Information;
                        break;
                    case "Verbose":
                        this.Switch.Level = System.Diagnostics.SourceLevels.Verbose;
                        break;
                    case "Off":
                        this.Switch.Level = System.Diagnostics.SourceLevels.Off;
                        break;
                }
            }
        }

        //コンストラクタ
        //nameはログオブジェクト名：任意の名前
        //logFileNameなログファイル名：出力したいファイル名を与えること
        //
        public MyTraceSource(string name, string logFileName)
            : base(name)
        {
            //DefaultTraceListenerが必要なければ削除する
            //デフォルトのログリスナーを削除する
            this.Listeners.Remove("Default");

            //ファイル形式のログリスナーを作成する
            //出力先ファイルを C:\test.txt、名前を LogFile として
            //TextWriterTraceListenerオブジェクトを作成
            System.Diagnostics.TextWriterTraceListener twtl =
                new System.Diagnostics.TextWriterTraceListener(
                    logFileName,ListenerName);
            //リスナコレクションに追加する
            this.Listeners.Add(twtl);
            this.Listeners[ListenerName].Filter =
                new System.Diagnostics.EventTypeFilter(
                    System.Diagnostics.SourceLevels.All);

            //ログに出力するログレベルはALL（すべてのログを出力する）
            this.Switch.Level = System.Diagnostics.SourceLevels.All;


            //ログ出力のテスト
            //this.TraceEvent(System.Diagnostics.TraceEventType.Critical, 1,
            //    "テスト");
            //DoLogWithDate(TraceEventType.Critical, 0, "テスト");

        }

        //ログメッセージを出力する
        //・日時を自動付加する
        //・１メッセージごとファイルにFlushする。（読み出し元でのFlushは不要）
        public void DoLogWithDate(TraceEventType evType, int level, string logMessage)
        {
            //ログ出力
            this.TraceEvent(evType, level,
                System.DateTime.Now + ": " + logMessage);
            //フラッシュする
            this.Flush();
        }

    }
}
