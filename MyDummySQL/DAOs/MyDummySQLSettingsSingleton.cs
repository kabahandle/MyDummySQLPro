using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace MyDummySQL.DAOs
{
    class MyDummySQLSettingsSingleton
    {
        #region //設定のキー
        public const string KeycmbColumns = "cmbColumns";
        public const string KeycmbKensu = "cmbKensu";
        public const string KeycmbRndAcTable = "cmbRndAcTable";
        public const string KeycmbRndMySQLTables = "cmbRndMySQLTables";
        public const string KeycmbRndMySQLTablesCol = "cmbRndMySQLTablesCol";
        public const string KeycmbSeqAcTable = "cmbSeqAcTable";
        public const string KeycmbSeqMySQLColumns = "cmbSeqMySQLColumns";
        public const string KeycmbSeqMySQLTables = "cmbSeqMySQLTables";
        public const string KeygridColNames = "gridColNames";
        public const string KeygridColVals = "gridColVals";
        public const string KeygridColTypes = "gridColTypes";
        public const string KeygridColNulls = "gridColNulls";
        public const string KeylstPreviewRndAccesTable = "lstPreviewRndAccesTable";
        public const string KeylstPreviewRndMySQLTable = "lstPreviewRndMySQLTable";
        public const string KeylstPreviewSeqAccesTable = "lstPreviewSeqAccesTable";
        public const string KeylstPreviewSeqMySQLTable = "lstPreviewSeqMySQLTable";
        public const string KeytbxConstString = "tbxConstString";
        public const string KeytbxConstStringScript = "tbxConstStringScript";
        public const string KeytbxDbName = "tbxDbName";
        public const string KeytbxPassword = "tbxPassword";
        public const string KeytbxPortNo = "tbxPortNo";
        public const string KeytbxRndAcessTableColScript = "tbxRndAcessTableColScript";
        public const string KeytbxRndIntEndInt = "tbxRndIntEndInt";
        public const string KeytbxRndIntScript = "tbxRndIntScript";
        public const string KeytbxRndIntStartInt = "tbxRndIntStartInt";
        public const string KeytbxRndMySQLTableColScript = "tbxRndMySQLTableColScript";
        public const string KeytbxScript1 = "tbxScript1";
        public const string KeytbxSeqAccessTableScript = "tbxSeqAccessTableScript";
        public const string KeytbxSeqMySQLColScript = "tbxSeqMySQLColScript";
        public const string KeytbxSeqNumEndInt = "tbxSeqNumEndInt";
        public const string KeytbxSeqNumScript = "tbxSeqNumScript";
        public const string KeytbxSeqNumStarInt = "tbxSeqNumStarInt";
        public const string KeytbxServername = "tbxServername";
        public const string KeytbxTableName = "tbxTableName";
        public const string KeytbxUserName = "tbxUserName";
        public const string KeytbxSeqDateScript = "tbxSeqDateScript";
        public const string KeyDatePicSeqEndDate = "DatePicSeqEndDate";
        public const string KeyDatePicSeqStartDate = "DatePicSeqStartDate";
        public const string KeycmbSeqDateIncrementType = "cmbSeqDateIncrementType";
        public const string KeycmbRndDateIncrementType = "cmbRndDateIncrementType";
        public const string KeytbxRndDateScript = "tbxRndDateScript";
        public const string KeyDatePicRndEndDate = "DatePicRndEndDate";
        public const string KeyDatePicRndStartDate = "DatePicRndStartDate";
        public const string KeycmbSeqDateTimeIncrementType = "cmbSeqDateTimeIncrementType";
        public const string KeytbxSeqDateTmeScript = "tbxSeqDateTmeScript";
        public const string KeyDatePicSeqEndDateTime = "DatePicSeqEndDateTime";
        public const string KeyDatePicSeqStartDateTime = "DatePicSeqStartDateTime";
        public const string KeycmbRndDateTimeIncrementType = "cmbRndDateTimeIncrementType";
        public const string KeytbxRndDateTimeScript = "tbxRndDateTimeScript";
        public const string KeyDatePicRndEndDateTime = "DatePicRndEndDateTime";
        public const string KeyDatePicRndStartDateTime = "DatePicRndStartDateTime";
        public const string KeytbxNullRatio = "tbxNullRatio";
        public const string KeycmbNullColumns = "cmbNullColumns";

        #endregion

        #region //定数
        public static string TRUE = "true";
        public static string FALSE = "false";
        #endregion

        public class values
        {
            public int intValue = 0;
            public string strgValue = "";
            public values(int intvalue, string strgvalue)
            {
                this.intValue = intvalue;
                this.strgValue = strgvalue;
            }
        }

        private static MyDummySQLSettingsSingleton sigleton_ = new MyDummySQLSettingsSingleton();

        MyDummySQLSettingsSingleton()
        {
        }

        public MyDummySQLSettingsSingleton getInstance()
        {
            return MyDummySQLSettingsSingleton.sigleton_;
        }



        public static IList<string> getHeaderTexts()
        {
            List<string> headertexts = new List<string>();
            DataTable tbl = null;
            //DBから読み込む
            using (DAOContext con = new DAOContext(AccessConstring.SettingConString))
            {
                con.OpenConnection();
                MyDummySQLSettingsDAO dao = new MyDummySQLSettingsDAO(con);

                tbl = dao.selectHeaders();

                con.CloseConnection();
            }

            if (tbl != null)
            {
                foreach (DataRow row in tbl.Rows)
                {
                    headertexts.Add(row["HEADERTEXT"].ToString());
                }
            }
            return headertexts;
        }

        public static void deleteSettings(string headerText)
        {

            //DBから読み込む
            using (DAOContext con = new DAOContext(AccessConstring.SettingConString))
            {
                con.OpenConnection();
                MyDummySQLSettingsDAO dao = new MyDummySQLSettingsDAO(con);

                dao.deleteSettings(headerText);
                dao.deleteHeader(headerText);

                con.CloseConnection();


            }
        }
        public static void getValue(string headerText, string strgKey, out int intValue)
        {
            intValue = 0;

            //DBから読み込む
            using (DAOContext con = new DAOContext(AccessConstring.SettingConString))
            {
                con.OpenConnection();
                MyDummySQLSettingsDAO dao = new MyDummySQLSettingsDAO(con);

                dao.selectSetting(headerText, strgKey, out intValue);

                con.CloseConnection();


            }
        }
        public static string getStringValue(string headerText, string strgKey)
        {
            string strgValue = "";

            //DBから読み込む
            using (DAOContext con = new DAOContext(AccessConstring.SettingConString))
            {
                con.OpenConnection();
                MyDummySQLSettingsDAO dao = new MyDummySQLSettingsDAO(con);

                dao.selectSetting(headerText, strgKey, out strgValue);

                con.CloseConnection();

            }
            return strgValue;
        }
        public static IList<string> getStringValues(string headerText, string strgKey)
        {
            List<string> ret = new List<string>();
            DataTable tbl = null;

            //DBから読み込む
            using (DAOContext con = new DAOContext(AccessConstring.SettingConString))
            {
                con.OpenConnection();
                MyDummySQLSettingsDAO dao = new MyDummySQLSettingsDAO(con);

                tbl = dao.selectSettingRows(headerText, strgKey);

                con.CloseConnection();

            }

            if (tbl != null)
            {
                foreach (DataRow row in tbl.Rows)
                {
                    ret.Add(row["TEXTVALUE"].ToString());
                }
            }

            return ret;
        }

        public static void setStringValus(string headerText, string strgKey, IList<string> strgs)
        {
            int no = 1;
            using (DAOContext con = new DAOContext(AccessConstring.SettingConString))
            {
                con.OpenConnection();
                MyDummySQLSettingsDAO dao = new MyDummySQLSettingsDAO(con);

                dao.deleteSettings(headerText, strgKey);

                foreach (string strg in strgs)
                {
                    dao.insertNew(headerText, strgKey, no, strg);
                    no++;
                }

                con.CloseConnection();
            }

        }

        public static void setValue(string headerText, string strgKey, int intValue)
        {
            using (DAOContext con = new DAOContext(AccessConstring.SettingConString))
            {
                con.OpenConnection();
                MyDummySQLSettingsDAO dao = new MyDummySQLSettingsDAO(con);
                dao.mergeSettings(headerText,strgKey, intValue);
                con.CloseConnection();
            }

        }
        public static void setValue(string headerText, string strgKey, string strgValue)
        {
            using (DAOContext con = new DAOContext(AccessConstring.SettingConString))
            {
                con.OpenConnection();
                MyDummySQLSettingsDAO dao = new MyDummySQLSettingsDAO(con);
                dao.mergeSettings(headerText, strgKey, strgValue);
                con.CloseConnection();
            }
        }

        public static bool isExistsHeader(string headerText)
        {
            bool ret = false;
            using (DAOContext con = new DAOContext(AccessConstring.SettingConString))
            {
                con.OpenConnection();
                MyDummySQLSettingsDAO dao = new MyDummySQLSettingsDAO(con);
                ret = dao.isExistsHeader(headerText);
                con.CloseConnection();
            }
            return ret;
        }
        public static void MergeHeader(string headerText)
        {
            using (DAOContext con = new DAOContext(AccessConstring.SettingConString))
            {
                con.OpenConnection();
                MyDummySQLSettingsDAO dao = new MyDummySQLSettingsDAO(con);
                dao.mergeHeader(headerText);
                con.CloseConnection();
            }
        }
        public static void deleteSettings(string headerText, string strgKey)
        {
            using (DAOContext con = new DAOContext(AccessConstring.SettingConString))
            {
                con.OpenConnection();
                MyDummySQLSettingsDAO dao = new MyDummySQLSettingsDAO(con);
                dao.deleteSettings(headerText, strgKey);
                con.CloseConnection();
            }
        }
    }
}
