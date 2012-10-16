using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace MyDummySQL.DAOs
{
    public class DAOContext : IDisposable
    {
        private DbConnection con_ = null;
        private DbProviderFactory fac_ = null;
        private DbTransaction tran_ = null;
        public DbConnection Connection {
            get
            {
                return this.con_;
            }
            private set
            {
                this.con_ = value;
            }
        }
        public DbProviderFactory Factory {
            get
            {
                return this.fac_;
            }
            private set
            {
                this.fac_ = value;
            }
        }
        public DbTransaction Transaction { 
            get
            {
                return this.tran_;
            }
            private set
            {
                this.tran_ = value;
            }
        }

        public DAOContext()
            : this("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|abc.mdb")
        {
        }

        public DAOContext(string connectionString)
            : this("System.Data.OleDb", connectionString)
        {
        }

        public DAOContext(string providerName, string connectionString)
        {
            if (providerName == null) throw new ArgumentNullException("providerName");
            if (connectionString == null) throw new ArgumentNullException("connectionString");

            this.Factory = DbProviderFactories.GetFactory(providerName);
            this.Connection = this.Factory.CreateConnection();
            this.Connection.ConnectionString = connectionString;

        }

        public void OpenConnection()
        {
            if (this.Connection == null)
                throw new InvalidOperationException("Object is diposed.");

            if (this.Connection.State == ConnectionState.Closed)
                this.Connection.Open();
        }

        public void CloseConnection()
        {
            if (this.Connection == null)
                throw new InvalidOperationException("Object is diposed.");

            if (this.Connection.State == ConnectionState.Open)
                this.Connection.Close();
        }

        public void BeginTransaction(IsolationLevel isolationLevel)
        {
            if (this.Transaction != null)
                throw new InvalidOperationException("There is already a transaction.");

            this.OpenConnection();
            this.Transaction = this.Connection.BeginTransaction(isolationLevel);
        }

        public void CommitTransaction()
        {
            if (this.Transaction == null)
                throw new InvalidOperationException("There is no transaction.");

            this.Transaction.Commit();
            this.Transaction = null;
        }

        public void RollbackTransaction()
        {
            if (this.Transaction == null)
                throw new InvalidOperationException("There is no transaction.");

            this.Transaction.Rollback();
            this.Transaction = null;
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                try
                {
                    if (this.Transaction != null)
                    {
                        this.RollbackTransaction();
                        this.Transaction = null;
                    }
                }
                finally
                {
                    if (this.Connection != null)
                    {
                        this.Connection.Dispose();
                        this.Connection = null;
                    }
                }
            }
        }
    }

    public class MyDAOBase
    {
        private readonly List<DbParameter> parameters = new List<DbParameter>();

        private DAOContext context_ = null;

        public DAOContext Context {
            get
            {
                return this.context_;
            }
            private set
            {
                this.context_ = value;
            }
        }

        public IList<DbParameter> Parameters
        {
            get { return this.parameters; }
        }

        public MyDAOBase(DAOContext context)
        {
            if (context == null) throw new ArgumentNullException("context");
            this.Context = context;
        
        }

        public void AddParameter(string parameterName, DbType dbType, object value)
        {
            DbParameter p = this.Context.Factory.CreateParameter();
            p.ParameterName = parameterName;
            p.DbType = dbType;
            p.Value = value;
            this.parameters.Add(p);
        }

        public void ClearParameters()
        {
            this.parameters.Clear();
        }

        protected void ExecuteCommand(string commandText, IEnumerable<DbParameter> parameters,
            Action<DbCommand> action)
        {
            DbCommand command = this.Context.Factory.CreateCommand();
            command.CommandText = commandText;
            command.Connection = this.Context.Connection;
            command.Transaction = this.Context.Transaction;
            foreach (DbParameter parameter in parameters)
                command.Parameters.Add(parameter);
            action(command);
        }

        protected int ExecuteNonQuery(string commandText, IEnumerable<DbParameter> parameters)
        {
            int count = 0;
            this.ExecuteCommand(commandText, parameters, delegate(DbCommand command){
                count = command.ExecuteNonQuery();
            });
            return count;
        }

        protected int ExecuteNonQuery(string commandText)
        {
            return this.ExecuteNonQuery(commandText, this.parameters);
        }

        protected DataTable GetTable(string commandText, IEnumerable<DbParameter> parameters)
        {
            DataTable table = new DataTable();
            this.ExecuteCommand(commandText, parameters, delegate(DbCommand command)
            {
                using (DbDataReader reader = command.ExecuteReader())
                {
                    table.Load(reader);
                }
            });
            return table;
        }

        protected DataTable GetTable(string commandText)
        {
            return this.GetTable(commandText, this.Parameters);
        }
    }
}
