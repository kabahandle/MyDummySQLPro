using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace MyDummySQL.DAOs
{
    class MyDummySQLSettingsDAO : MyDAOBase
    {
        public MyDummySQLSettingsDAO(DAOContext con) : base(con) { }

        #region //SELECT
        public void selectSetting(string headerText, string strgKey, out int intValue)
        {
            string sql = @"select *
                            from settings
                            where
                                SETTINGKEY like @pkey
                            and HEADERTEXT like @pheader";

            this.ClearParameters();
            this.AddParameter("pkey", DbType.String, strgKey);
            this.AddParameter("pheader", DbType.String, headerText);

            DataTable tbl = base.GetTable(sql);

            if (tbl.Rows.Count > 0)
            {
                int ret = 0;
                int.TryParse(tbl.Rows[0]["INTVALUE"].ToString(), out ret);
                intValue = ret;
            }
            else
            {
                intValue = 0;
            }
        }

        public DataRow selectSetting1Row(string headerText, string strgKey)
        {
            string sql = @"select *
                            from settings
                            where
                                SETTINGKEY like @pkey
                            and HEADERTEXT like @pheader";

            this.ClearParameters();
            this.AddParameter("pkey", DbType.String, strgKey);
            this.AddParameter("pheader", DbType.String, headerText);

            DataTable tbl = base.GetTable(sql);

            if (tbl.Rows.Count > 0)
            {
                return tbl.Rows[0];
            }
            else
            {
                return null;
            }
        }
        public DataTable selectSettingRows(string headeText, string strgKey)
        {
            string sql = @"select *
                            from settings
                            where
                                SETTINGKEY like @pkey
                            and HEADERTEXT like @pheader
                            order by NO1
                            ";

            this.ClearParameters();
            this.AddParameter("pkey", DbType.String, strgKey);
            this.AddParameter("pheader", DbType.String, headeText);

            return  base.GetTable(sql);

        }

        public void selectSetting(string headerText, string strgKey, out string strgValue)
        {
            string sql = @"select *
                            from settings
                            where
                                SETTINGKEY like @pkey
                            and HEADERTEXT like @pheader";

            this.ClearParameters();
            this.AddParameter("pkey", DbType.String, strgKey);
            this.AddParameter("pheader", DbType.String, headerText);

            DataTable tbl = base.GetTable(sql);

            if (tbl.Rows.Count > 0)
            {
                strgValue = tbl.Rows[0]["TEXTVALUE"].ToString();
            }
            else
            {
                strgValue = "";
            }
        }
        public DataTable selectHeaders()
        {
            string sql = @"select *
                            from header
                            order by HEADERTEXT
                            ";

            this.ClearParameters();

            return base.GetTable(sql);

        }

        public bool isExistSetting(string headerText, string strgKey)
        {
            string sql = @"select *
                            from settings
                            where
                                SETTINGKEY like @pkey
                            and HEADERTEXT = @pheader";

            this.ClearParameters();
            this.AddParameter("pkey", DbType.String, strgKey);
            this.AddParameter("pheader", DbType.String, headerText);

            DataTable tbl = base.GetTable(sql);

            if (tbl.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region //ヘッダーマージ

        public bool isExistsHeader(string headerText)
        {
            string sql = @"select * 
                            from header
                            where
                                HEADERTEXT like @pheader
                                ";

            this.ClearParameters();
            this.AddParameter("pheader", DbType.String, headerText);

            DataTable tbl =  base.GetTable(sql);

            if (tbl.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int insertNewHeader(string headerText)
        {
            string sql = @"insert into
                            header(
                                HEADERTEXT
                            )
                            values(
                                @pheader
                            )";

            this.ClearParameters();
            this.AddParameter("pheader", DbType.String, headerText);

            return base.ExecuteNonQuery(sql);
        }

        public int mergeHeader(string headerText)
        {
            if (this.isExistsHeader(headerText))
            {
                return 0;
            }
            else
            {
                return this.insertNewHeader(headerText);
            }
        }

        #endregion


        #region //数値設定

        public int updateDate(string headerText, string strgKey, int intValue)
        {
            string sql = @"update settings
                            set
                                INTVALUE = @pintvalue
                            where
                                SETTINGKEY like @pkey
                            and HEADERTEXT like @pheader";

            this.ClearParameters();
            this.AddParameter("pintvalue", DbType.Int32, intValue);
            this.AddParameter("pkey", DbType.String, strgKey);
            this.AddParameter("pheader", DbType.String, headerText);

            return base.ExecuteNonQuery(sql);
        }

        public int insertNew(string headerText, string strgKey, int intValue)
        {
            string sql = @"insert into
                            settings(
                                HEADERTEXT
                                ,NO1
                                ,SETTINGKEY
                                ,INTVALUE
                            )
                            values(
                                @pheader
                                ,0
                                ,@pkey
                                ,@pintvalue
                            )";

            this.ClearParameters();
            this.AddParameter("pheader", DbType.String, headerText);
            this.AddParameter("pkey", DbType.String, strgKey);
            this.AddParameter("pintvalue", DbType.Int32, intValue);

            return base.ExecuteNonQuery(sql);
        }

        public int mergeSettings(string headerText, string strgKey, int intValue)
        {
            if (this.isExistSetting(headerText, strgKey))
            {
                return this.updateDate(headerText, strgKey, intValue);
            }
            else
            {
                return this.insertNew(headerText, strgKey, intValue);
            }
        }

        #endregion


        #region //数値設定（複数行）

        public int insertNew(string headerText, string strgKey, int no, int intValue)
        {
            string sql = @"insert into
                            settings(
                                HEADERTEXT
                                ,NO1
                                ,SETTINGKEY
                                ,INTVALUE
                            )
                            values(
                                @pheader
                                ,@pno
                                ,@pkey
                                ,@pintvalue
                            )";

            this.ClearParameters();
            this.AddParameter("pheader", DbType.String, headerText);
            this.AddParameter("pno", DbType.Int32, no);
            this.AddParameter("pkey", DbType.String, strgKey);
            this.AddParameter("pintvalue", DbType.Int32, intValue);

            return base.ExecuteNonQuery(sql);
        }

        #endregion


        #region //文字設定

        public int updateDate(string headerText, string strgKey, string strgValue)
        {
            string sql = @"update settings
                            set
                                TEXTVALUE = @ptextvalue
                            where
                                SETTINGKEY like @pkey
                            and HEADERTEXT like @pheader";

            this.ClearParameters();
            this.AddParameter("ptextvalue", DbType.String, strgValue);
            this.AddParameter("pkey", DbType.String, strgKey);
            this.AddParameter("pheader", DbType.String, headerText);

            return base.ExecuteNonQuery(sql);
        }

        public int insertNew(string headerText, string strgKey, string strgValue)
        {
            string sql = @"
insert into
settings(
HEADERTEXT
,NO1
,SETTINGKEY
,TEXTVALUE
)
values(
@pheader1
,0
,@pkey1
,@ptextvalue1
)";

            this.ClearParameters();
            this.AddParameter("pheader1", DbType.String, headerText);
            this.AddParameter("pkey1", DbType.String, strgKey);
            this.AddParameter("ptextvalue1", DbType.String, strgValue);

            return base.ExecuteNonQuery(sql);
        }

        public int mergeSettings(string headerText, string strgKey, string strgValue)
        {
            if (this.isExistSetting(headerText, strgKey))
            {
                return this.updateDate(headerText, strgKey, strgValue);
            }
            else
            {
                return this.insertNew(headerText, strgKey, strgValue);
            }
        }

        #endregion

        #region //文字設定（複数行）

        public int insertNew(string headerText, string strgKey, int no, string strgValue)
        {
            string sql = @"insert into
                            settings(
                                HEADERTEXT
                                ,NO1
                                ,SETTINGKEY
                                ,TEXTVALUE
                            )
                            values(
                                @pheader
                                ,@pno
                                ,@pkey
                                ,@ptextvalue
                            )";

            this.ClearParameters();
            this.AddParameter("pheader", DbType.String, headerText);
            this.AddParameter("pno", DbType.Int32, no);
            this.AddParameter("pkey", DbType.String, strgKey);
            this.AddParameter("ptextvalue", DbType.String, strgValue);

            return base.ExecuteNonQuery(sql);
        }


        #endregion

        #region //設定削除（複数行用）

        public int deleteSettings(string headerText, string strgKey)
        {
            string sql = @"delete from settings
                            where
                                SETTINGKEY like @pkey
                            and HEADERTEXT like @pheader";

            this.ClearParameters();
            this.AddParameter("pkey", DbType.String, strgKey);
            this.AddParameter("pheader", DbType.String, headerText);

            return base.ExecuteNonQuery(sql);
        }
        public int deleteSettings(string headerText)
        {
            string sql = @"delete from settings
                            where
                                HEADERTEXT like @pheader";

            this.ClearParameters();
            this.AddParameter("pheader", DbType.String, headerText);

            return base.ExecuteNonQuery(sql);
        }
        public int deleteHeader(string headerText)
        {
            string sql = @"delete from header
                            where
                                HEADERTEXT like @pheader";

            this.ClearParameters();
            this.AddParameter("pheader", DbType.String, headerText);

            return base.ExecuteNonQuery(sql);
        }
        
        #endregion

    }
}
