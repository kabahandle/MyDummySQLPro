using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDummySQL.MySQLDAO
{
    class MySQLConString
    {
        private string conString_ = "";
        private static string staticConString = "";
        public MySQLConString(string serverName, string userId, string password, string dbName, int port, bool isPooling)
        {
            string strgPooling = "";
            if (isPooling)
            {
                strgPooling = "true";
            }
            else
            {
                strgPooling = "false";
            }

            this.conString_ = String.Format("server={0};user id={1}; password={2}; database={3}; port={4};pooling={5}; Charset=sjis; ", serverName, userId, password, dbName, port.ToString(), strgPooling);
            MySQLConString.staticConString = this.conString_;
        }
        public string ConString
        {
            get
            {
                return this.conString_;
            }
        }
        public static string getStaticConstring()
        {
            return MySQLConString.staticConString;
        }
    }
}
