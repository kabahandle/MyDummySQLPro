using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace MyDummySQL.MySQLDAO
{
    class MySQLDAOBase
    {
        //SQL文中のバインド変数
        private readonly List<MySqlParameter> parameters = new List<MySqlParameter>();

        //コネクションなど
        private MySQLDAOContext context_ = null;

        //コネクションなど
        public MySQLDAOContext Context
        {
            get
            {
                return this.context_;
            }
            private set
            {
                this.context_ = value;
            }
        }

        //バインド変数（IListに変換）
        public IList<MySqlParameter> Parameters
        {
            get { return this.parameters; }
        }

        //コンストラクタ
        public MySQLDAOBase(MySQLDAOContext context)
        {
            if (context == null) throw new ArgumentNullException("context");
            this.Context = context;

            string sql = "SET NAMES SJIS";
            this.ExecuteNonQuery(sql);

        }

        //バインド変数追加
        public void AddParameter(string parameterName, DbType dbType, object value)
        {
            MySqlParameter p = new MySqlParameter();
            p.ParameterName = parameterName;
            p.DbType = dbType;
            p.Value = value;
            this.parameters.Add(p);
        }

        //バインド変数クリア
        public void ClearParameters()
        {
            this.parameters.Clear();
        }

        //SQL実行。実行ロジック自体は、actionデリゲートで行う。
        protected void ExecuteCommand(string commandText, IEnumerable<MySqlParameter> parameters,
            Action<MySqlCommand> action)
        {
            MySqlCommand command = new MySqlCommand(commandText, this.Context.Connection);
            command.Connection = this.Context.Connection;
            command.Transaction = this.Context.Transaction;
            foreach (MySqlParameter parameter in parameters)
                command.Parameters.Add(parameter);
            action(command);
        }

        //DML（SELECT以外）実行。（独自のパラメータを指定してよい）
        protected int ExecuteNonQuery(string commandText, IEnumerable<MySqlParameter> parameters)
        {
            int count = 0;
            this.ExecuteCommand(commandText, parameters, delegate(MySqlCommand command)
            {
                count = command.ExecuteNonQuery();
            });
            return count;
        }

        //DML（SELECT以外）実行。（パラメータはこのDAOのプロパティ）
        protected int ExecuteNonQuery(string commandText)
        {
            return this.ExecuteNonQuery(commandText, this.parameters);
        }

        //SELECT。DataTableで受け取る。（独自のパラメータを指定してよい）
        protected DataTable GetTable(string commandText, IEnumerable<MySqlParameter> parameters)
        {
            DataTable table = new DataTable();
            this.ExecuteCommand(commandText, parameters, delegate(MySqlCommand command)
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    table.Load(reader);
                }
            });
            return table;
        }

        //SELECT。DataTableで受け取る。（パラメータはこのDAOのプロパティ）
        protected DataTable GetTable(string commandText)
        {
            return this.GetTable(commandText, this.Parameters);
        }
    }
}
