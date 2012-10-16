using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace MyDummySQL.MySQLDAO
{
    class MySQLDAOContext : IDisposable
    {
        //コネクション
        private MySqlConnection con_ = null;
        //private mysqlProviderFactory fac_ = null;
        //トランザクション
        private MySqlTransaction tran_ = null;
        //コネクション
        public MySqlConnection Connection
        {
            get
            {
                return this.con_;
            }
            private set
            {
                this.con_ = value;
            }
        }
        /*//DBファクトリは使わない
        public DbProviderFactory Factory
        {
            get
            {
                return this.fac_;
            }
            private set
            {
                this.fac_ = value;
            }
        }
        */
        //トランザクション
        public MySqlTransaction Transaction
        {
            get
            {
                return this.tran_;
            }
            set
            {
                this.tran_ = value;
            }
        }

        //デフォルトコンストラクタ
        //これはAccess用の接続文字列で他のコンストラクタを入れている->NGになる
        public MySQLDAOContext()
            : this("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|abc.mdb")
        {
        }

        //接続文字列を受け取るコンストラクタ
        public MySQLDAOContext(/*string providerName, */string connectionString)
        {
            //if (providerName == null) throw new ArgumentNullException("providerName");
            if (connectionString == null) throw new ArgumentNullException("connectionString");

            //this.Factory = DbProviderFactories.GetFactory(providerName);
            //this.Connection = this.Factory.CreateConnection();
            this.Connection = new MySqlConnection(connectionString);
            this.Connection.ConnectionString = connectionString;
        }

        //コネクションオープン
        public void OpenConnection()
        {
            if (this.Connection == null)
                throw new InvalidOperationException("Object is diposed.");

            if (this.Connection.State == System.Data.ConnectionState.Closed)
            {
                this.Connection.Open();
                this.Connection.GetSchema();
            }
        }

        //コネクションクローズ
        public void CloseConnection()
        {
            if (this.Connection == null)
                throw new InvalidOperationException("Object is diposed.");

            if (this.Connection.State == System.Data.ConnectionState.Open)
                this.Connection.Close();
        }

        //データベース変更
        public void changeDatabase(string dbName)
        {
            this.Connection.ChangeDatabase(dbName);
        }

        //トランザクション開始（トランザクション分離レベルを指定）
        public void BeginTransaction(System.Data.IsolationLevel isolationLevel)
        {
            if (this.Transaction != null)
                throw new InvalidOperationException("There is already a transaction.");

            this.OpenConnection();
            this.Transaction = this.Connection.BeginTransaction(isolationLevel);
        }

        //トランザクションコミット
        public void CommitTransaction()
        {
            if (this.Transaction == null)
                throw new InvalidOperationException("There is no transaction.");

            this.Transaction.Commit();
            this.Transaction = null;
        }

        //トランザクションロールバック
        public void RollbackTransaction()
        {
            if (this.Transaction == null)
                throw new InvalidOperationException("There is no transaction.");

            this.Transaction.Rollback();
            this.Transaction = null;
        }

        //アンマネージドリソース解放
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);  //ガベージコレクタファイナライズ処理
        }

        //Dispose
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)  //Dispose中？
            {
                try
                {
                    if (this.Transaction != null)
                    {
                        this.RollbackTransaction(); //トランザクションをロールバック
                        this.Transaction = null;
                    }
                }
                finally //最終的に必ず行われる処理
                {
                    if (this.Connection != null)
                    {
                        this.Connection.Dispose();  //コネクション（アンマネージドリソース）解放
                        this.Connection = null;
                    }
                }
            }
        }
    }
}
