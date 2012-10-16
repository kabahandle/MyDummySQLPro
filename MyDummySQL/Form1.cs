using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MyDummySQL.MySQLDAO;
using MyDummySQL.Columns;
using MyDummySQL.CustomData;
using MyDummySQL.HelperNS;
using MyDummySQL.Helper;
using MySql.Data.MySqlClient;
using MyDummySQL.GeneratorNS;
using MyDummySQL.Classes;
using System.Diagnostics;

namespace MyDummySQL
{
    public partial class Form1 : Form
    {
        //private List<CustomDataMySQLTable> columns = new List<CustomDataMySQLTable>();
        public BindingSource dataSource = new BindingSource();
        //TraceSourceの作成
        //private static System.Diagnostics.TraceSource appTrace =
        //    new System.Diagnostics.TraceSource("MainTraceSource");
        //public MyTraceSource appTrace = null;

        public Form1()
        {
            InitializeComponent();
        }

        private MySQLDAO.MySQLConString getObjConstring()
        {
            int port = 0;
            int.TryParse(tbxPortNo.Text, out port);

            MySQLDAO.MySQLConString objConString = new MySQLDAO.MySQLConString(
                 tbxServername.Text,
                 tbxUserName.Text,
                 tbxPassword.Text,
                 tbxDbName.Text,
                 port,
                 false);

            return objConString;
        }

        private void btnTest1_Click(object sender, EventArgs e)
        {
            MySQLDAO.MySQLConString objConString = this.getObjConstring();

            try
            {
                using (MySQLDAO.MySQLDAOContext con = new MySQLDAO.MySQLDAOContext(objConString.ConString))
                {
                    con.OpenConnection();
                    con.CloseConnection();
                    MessageBox.Show("success");
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException excep)
            {
                MessageBox.Show("error");
            }
        }

        private void btnSqlTest_Click(object sender, EventArgs e)
        {
            MySQLDAO.MySQLConString objConString = this.getObjConstring();

            using (MySQLDAO.MySQLDAOContext con = new MySQLDAO.MySQLDAOContext(objConString.ConString))
            {
                con.OpenConnection();
                t_table1Dao dao = new t_table1Dao(con);

                //insert
                dao.insert("test1");

                int id = 1;

                //select
                DataTable tbl = dao.selectAll();
                if (tbl.Rows.Count > 0)
                {
                    MessageBox.Show(tbl.Rows[0]["name"].ToString() + "がInsertされました。");
                    id = (int)tbl.Rows[0]["id"];
                }
                else
                {
                    MessageBox.Show("insert失敗");
                }

                //update
                dao.update(id, "test2");

                //select
                DataTable tbl2 = dao.select(id);
                if (tbl2.Rows.Count > 0)
                {
                    string name = tbl2.Rows[0]["name"].ToString();
                    if ("test2".Equals(name))
                    {
                        MessageBox.Show(name + "にupdateされました。");
                    }
                    else
                    {
                        MessageBox.Show("updateに失敗しました。");
                    }
                }

                //delete
                dao.delete(id);

                //select
                DataTable tbl3 = dao.select(id);
                if (tbl3.Rows.Count > 0)
                {
                    MessageBox.Show("deleteに失敗しました。");
                }
                else
                {
                    MessageBox.Show("deleteに成功しました。");
                }

                con.CloseConnection();
                MessageBox.Show("success");
            }
        }

        private void btnParse1_Click(object sender, EventArgs e)
        {
            string columnName = "col1";
            string param = tbxScript1.Text;

            MySQLDAO.MySQLConString objConString = this.getObjConstring();

            Dictionary<string, string> paramsByColumn = new Dictionary<string, string>();
            Dictionary<string, string> nullratiosByColumn = new Dictionary<string, string>();
            paramsByColumn.Add(columnName, param);
            nullratiosByColumn.Add(columnName, "");

            ColumnData cold = new ColumnData(paramsByColumn, nullratiosByColumn);

            //1
            Dictionary<string, string> genedCols = cold.GenerateNext();
            MessageBox.Show(genedCols[columnName]);

            MySQLTableHelper.SetNext();

            //2
            Dictionary<string, string> genedCols2 = cold.GenerateNext();
            MessageBox.Show(genedCols2[columnName]);

            MySQLTableHelper.SetNext();
        }

        

        private void btnSeqNumMakeScript_Click(object sender, EventArgs e)
        {
            tbxSeqNumScript.Text += "|seqint:" + tbxSeqNumStarInt.Text + "," + tbxSeqNumEndInt.Text;
        }

        private void btnSeqNumCopy_Click(object sender, EventArgs e)
        {
            tbxScript1.Text += tbxSeqNumScript.Text;
        }

        private void tbxSeqNumStarInt_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxSeqNumStarInt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar + "") == Microsoft.VisualBasic.Constants.vbBack))
            {
                if (e.KeyChar < '0' || e.KeyChar > '9')
                {
                    e.KeyChar = (char)0;
                }
            }
        }

        private void tbxSeqNumEndInt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar + "") == Microsoft.VisualBasic.Constants.vbBack))
            {
                if (e.KeyChar < '0' || e.KeyChar > '9')
                {
                    e.KeyChar = (char)0;
                }
            }

        }

        private void btnRndNumMakeScript_Click(object sender, EventArgs e)
        {
            tbxRndIntScript.Text += "|rndint:" + tbxRndIntStartInt.Text + "," + tbxRndIntEndInt.Text;
        }

        private void tbxRndIntStartInt_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbxRndIntStartInt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar + "") == Microsoft.VisualBasic.Constants.vbBack))
            {
                if (e.KeyChar < '0' || e.KeyChar > '9')
                {
                    e.KeyChar = (char)0;
                }
            }


        }

        private void tbxRndIntEndInt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar + "") == Microsoft.VisualBasic.Constants.vbBack))
            {
                if (e.KeyChar < '0' || e.KeyChar > '9')
                {
                    e.KeyChar = (char)0;
                }
            }

        }

        private void btnRndIntCopyScript_Click(object sender, EventArgs e)
        {
            tbxScript1.Text += tbxRndIntScript.Text;
        }

        private void btnReadColumn_Click(object sender, EventArgs e)
        {
            try
            {
                MySQLDAO.MySQLConString objConString = this.getObjConstring();

                DataTable schema = null;

                using (MySQLDAO.MySQLDAOContext con = new MySQLDAO.MySQLDAOContext(objConString.ConString))
                {
                    con.OpenConnection();

                    MySQLSchemaDAO dao = new MySQLSchemaDAO(con);
                    schema = dao.selectTableColumns(tbxDbName.Text, tbxTableName.Text);

                    con.CloseConnection();
                }

                if (schema != null)
                {
                    this.dataSource.Clear();
                    this.cmbColumns.Items.Clear();
                    foreach (DataRow row in schema.Rows)
                    {
                        this.dataSource.Add(new CustomDataMySQLTable(row["COLUMN_NAME"].ToString(), row["DATA_TYPE"].ToString(), "",""));
                        this.cmbColumns.Items.Add(row["COLUMN_NAME"].ToString());
                        this.cmbNullColumns.Items.Add(row["COLUMN_NAME"].ToString());
                    }
                }

                this.grid.DataSource = this.dataSource;
                if (this.cmbColumns.Items.Count > 0)
                {
                    this.cmbColumns.SelectedIndex = 0;
                }
                if (this.cmbNullColumns.Items.Count > 0)
                {
                    this.cmbNullColumns.SelectedIndex = 0;
                }
            }
            catch (Exception excp)
            {
                MessageBox.Show("エラーが発生しました。MySQLが起動しているかご確認下さい。");
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            // カラム情報を自動で作成しないように
            grid.AutoGenerateColumns = false;

            DataGridViewColumn c = new DataGridViewTextBoxColumn();
            c.DataPropertyName = "ColName";
            c.HeaderText = "名前";
            c.ReadOnly = true;

            grid.Columns.Add(c);

            c = new DataGridViewTextBoxColumn();
            c.DataPropertyName = "ColType";
            c.HeaderText = "型";
            c.ReadOnly = true;

            grid.Columns.Add(c);

            c = new DataGridViewTextBoxColumn();
            c.DataPropertyName = "Val";
            c.HeaderText = "設定";
            c.Width = 600;

            grid.Columns.Add(c);

            c = new DataGridViewTextBoxColumn();
            c.DataPropertyName = "NullRatio";
            c.HeaderText = "Null挿入率";
            c.Width = 100;

            grid.Columns.Add(c);


            //Resize
            this.Form1_Resize(sender, e);


            //トレースログ出力オブジェクトにログファイル名を渡して、起動
            //appTrace = new MyTraceSource("MainTraceSource", Application.StartupPath + @"\App_Data\Log\Log_"+DateTime.Today.ToString("yyyyMMdd")+".txt");
            MyLogSingleton.getIncetance().DoLogWithDate(TraceEventType.Critical, 1,"Access読み込みに失敗しました。モードを変えて試してください");
            //ログレベルコンボ初期値設定
            this.cmbLogLevel.SelectedIndex = 0;


        }

        private void btnClearScript_Click(object sender, EventArgs e)
        {
            tbxScript1.Text = "";
        }

        private void btnAddScript_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.grid.Rows)
            {
                CustomDataMySQLTable c = row.DataBoundItem as CustomDataMySQLTable;
                if (c != null)
                {
                    if (c.ColName == this.cmbColumns.Text)
                    {
                        c.Val = tbxScript1.Text;
                        break;
                    }
                }
            }
            this.grid.Refresh();

            tbxScript1.Text = "";
        }

        private void btnMakeConstStringScript_Click(object sender, EventArgs e)
        {
            tbxConstStringScript.Text += "|const:" + tbxConstString.Text;
        }

        private void btnConstStringCopyScript_Click(object sender, EventArgs e)
        {
            tbxScript1.Text += tbxConstStringScript.Text;

        }

        private void cmbMySQLTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            IList<string> cols = MySQLTableHelperForForm.getTableColumnNames(this.tbxDbName.Text, cmbSeqMySQLTables.Text);

            cmbSeqMySQLColumns.Items.Clear();
            cmbSeqMySQLColumns.Items.AddRange(cols.ToArray());
            if (cmbSeqMySQLColumns.Items.Count > 0)
            {
                cmbSeqMySQLColumns.SelectedIndex = 0;
            }
        }

        private void btnReadTable_Click(object sender, EventArgs e)
        {
            MySQLDAO.MySQLConString objConString = this.getObjConstring();

            IList<string> tables = MySQLTableHelperForForm.getTableNames(this.tbxDbName.Text);

            cmbSeqMySQLTables.Items.Clear();
            cmbSeqMySQLTables.Items.AddRange(tables.ToArray());
            if (cmbSeqMySQLTables.Items.Count > 0)
            {
                cmbSeqMySQLTables.SelectedIndex = 0;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbxRndIntScript_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMakeSeqMySQLColScript_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbSeqMySQLTables.Text))
            {
                MessageBox.Show("MySQLのテーブルを選択して下さい。");
                return;
            }
            if (string.IsNullOrEmpty(cmbSeqMySQLColumns.Text))
            {
                MessageBox.Show("MySQLの列を選択して下さい。");
                return;
            }

            tbxSeqMySQLColScript.Text += "|seqmstbl:" + cmbSeqMySQLTables.Text + "," + cmbSeqMySQLColumns.Text;
        }

        private void btnCopySeqMySQLColScript_Click(object sender, EventArgs e)
        {
            tbxScript1.Text += tbxSeqMySQLColScript.Text;
        }

        private void btnClearSeqMySQLColScript_Click(object sender, EventArgs e)
        {
            tbxSeqMySQLColScript.Text = "";
        }

        private void btnConstStringClearScript_Click(object sender, EventArgs e)
        {
            tbxConstStringScript.Text = "";
        }

        private void btnRndIntClearScript_Click(object sender, EventArgs e)
        {
            tbxRndIntScript.Text = "";
        }

        private void btnSeqNumClearScript_Click(object sender, EventArgs e)
        {
            tbxSeqNumScript.Text = "";
        }

        private void cmbRndMySQLTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            IList<string> cols = MySQLTableHelperForForm.getTableColumnNames(this.tbxDbName.Text, cmbRndMySQLTables.Text);

            cmbRndMySQLTablesCol.Items.Clear();
            cmbRndMySQLTablesCol.Items.AddRange(cols.ToArray());
            if (cmbRndMySQLTablesCol.Items.Count > 0)
            {
                cmbRndMySQLTablesCol.SelectedIndex = 0;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MySQLDAO.MySQLConString objConString = this.getObjConstring();

            IList<string> tables = MySQLTableHelperForForm.getTableNames(this.tbxDbName.Text);

            cmbRndMySQLTables.Items.Clear();
            cmbRndMySQLTables.Items.AddRange(tables.ToArray());
            if (cmbRndMySQLTables.Items.Count > 0)
            {
                cmbRndMySQLTables.SelectedIndex = 0;
            }

        }

        private void btnReadSeqAccessTable_Click(object sender, EventArgs e)
        {
            IList<string> tables = AccessTableHelperForForm.getTableNames();

            cmbSeqAcTable.Items.Clear();
            cmbSeqAcTable.Items.AddRange(tables.ToArray());
            if (cmbSeqAcTable.Items.Count > 0)
            {
                cmbSeqAcTable.SelectedIndex = 0;
            }
        }

        private void btnMakeSeqAccessTableScript_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbSeqAcTable.Text))
            {
                MessageBox.Show("Accessのテーブルを選択して下さい。");
                return;
            }
            tbxSeqAccessTableScript.Text += "|seqactbl:" + cmbSeqAcTable.Text;
        }

        private void btnCopySeqAccessTableScript_Click(object sender, EventArgs e)
        {
            tbxScript1.Text += tbxSeqAccessTableScript.Text;
        }

        private void btnClearSeqAccessTableScript_Click(object sender, EventArgs e)
        {
            tbxSeqAccessTableScript.Text = "";
        }

        private void btnReadRndAccessTable_Click(object sender, EventArgs e)
        {
            IList<string> tables = AccessTableHelperForForm.getTableNames();

            cmbRndAcTable.Items.Clear();
            cmbRndAcTable.Items.AddRange(tables.ToArray());
            if (cmbRndAcTable.Items.Count > 0)
            {
                cmbRndAcTable.SelectedIndex = 0;

            }

        }

        private void btnMakeRndAccessTableColScript_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbRndAcTable.Text))
            {
                MessageBox.Show("Accessのテーブルを選択して下さい。");
                return;
            }
            tbxRndAcessTableColScript.Text += "|rndactbl:" + cmbRndAcTable.Text;
        }

        private void btnCopyRndAccessTableColScript_Click(object sender, EventArgs e)
        {
            tbxScript1.Text += tbxRndAcessTableColScript.Text;
        }

        private void btnClearRndAccessTableColScript_Click(object sender, EventArgs e)
        {
            tbxRndAcessTableColScript.Text = "";
        }

        private void cmbRndAcTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRndAcTable.Text != "")
            {
                IList<string> colvalues = AccessTableHelperForForm.getTop5TableVal(cmbRndAcTable.Text);

                lstPreviewRndAccesTable.Items.Clear();
                foreach (string val in colvalues)
                {
                    lstPreviewRndAccesTable.Items.Add(val);
                }
            }


        }

        private void cmbSeqAcTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSeqAcTable.Text != "")
            {
                IList<string> colvalues = AccessTableHelperForForm.getTop5TableVal(cmbSeqAcTable.Text);

                lstPreviewSeqAccesTable.Items.Clear();
                foreach (string val in colvalues)
                {
                    lstPreviewSeqAccesTable.Items.Add(val);
                }
            }

        }

        private void cmbRndMySQLTablesCol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRndMySQLTables.Text != "" && cmbRndMySQLTablesCol.Text != "")
            {
                IList<string> colvalues = MySQLTableHelperForForm.getTop5TableCol(cmbRndMySQLTables.Text, cmbRndMySQLTablesCol.Text);

                lstPreviewRndMySQLTable.Items.Clear();
                foreach (string val in colvalues)
                {
                    lstPreviewRndMySQLTable.Items.Add(val);
                }

            }
        }

        private void cmbSeqMySQLColumns_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSeqMySQLTables.Text != "" && cmbSeqMySQLColumns.Text != "")
            {
                IList<string> colvalues = MySQLTableHelperForForm.getTop5TableCol(cmbSeqMySQLTables.Text, cmbSeqMySQLColumns.Text);

                lstPreviewSeqMySQLTable.Items.Clear();
                foreach (string val in colvalues)
                {
                    lstPreviewSeqMySQLTable.Items.Add(val);
                }

            }

        }

        private void tbxRndAcessTableColScript_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void btnTestInsert_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(cmbKensu.Text))
            {
                MessageBox.Show("挿入件数を指定して下さい。");
                return;
            }

            if (MessageBox.Show("ダミーデータを挿入しますか？", "確認", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("キャンセルしました。");
                return;
            }

            lblTotalNum.Text = cmbKensu.Text;
            lblInsertedNum.Text = "0";

            long insertednum = 0;
            long kensu = 0;
            long.TryParse(cmbKensu.Text, out kensu);

            MySQLDAO.MySQLConString objConString = this.getObjConstring();

            List<string> colNames = new List<string>();
            Dictionary<string, string> colTypes = new Dictionary<string, string>();
            Dictionary<string, string> colVales = new Dictionary<string, string>();

            Dictionary<string, string> paramsByColumn = new Dictionary<string, string>();
            Dictionary<string, string> nullratiosByColumn = new Dictionary<string, string>();
            foreach (DataGridViewRow row in this.grid.Rows)
            {
                CustomDataMySQLTable c = row.DataBoundItem as CustomDataMySQLTable;
                if (c != null)
                {
                    string columnName = c.ColName;
                    string param = c.Val;
                    string nullratio = c.NullRatio;

                    paramsByColumn.Add(columnName, param);
                    nullratiosByColumn.Add(columnName, nullratio);

                }
            }


            ColumnData cold = new ColumnData(paramsByColumn, nullratiosByColumn);

            try
            {
                using (MySQLDAOContext con = new MySQLDAOContext(MySQLConString.getStaticConstring()))
                {
                    con.OpenConnection();
                    //con.BeginTransaction(IsolationLevel.RepeatableRead);
                    InsertDAO dao = new InsertDAO(con);

                    for (int l = 0; l < kensu; l++)
                    {

                        Dictionary<string, string> genedCols = cold.GenerateNext();

                        colNames.Clear();
                        colTypes.Clear();
                        colVales.Clear();
                        foreach (DataGridViewRow row in this.grid.Rows)
                        {
                            CustomDataMySQLTable c = row.DataBoundItem as CustomDataMySQLTable;
                            if (c != null)
                            {
                                string columnName = c.ColName;
                                string colVal = genedCols[columnName];
                                string colType = c.ColType;

                                colNames.Add(columnName);
                                colTypes.Add(columnName, colType);
                                colVales.Add(columnName, colVal);
                            }
                        }

                        try
                        {
                            dao.Insert(tbxTableName.Text, colNames, colTypes, colVales);
                            //con.CommitTransaction();
                        }
                        catch (Exception excp)
                        {
                            /*
                            MessageBox.Show(excp.Message);
                            MessageBox.Show("ロールバックします。");
                            con.RollbackTransaction();
                            con.CloseConnection();
                            return;
                             */
                            MySQLTableHelper.SetNext();
                            continue;
                        }

                        MySQLTableHelper.SetNext();
                        insertednum++;
                        lblInsertedNum.Text = insertednum.ToString();
                        System.Windows.Forms.Application.DoEvents();
                    }


                    con.CloseConnection();
                }

                MessageBox.Show(insertednum + "の挿入に成功しました。");
            }
            catch (Exception excp)
            {
                MessageBox.Show("エラーが発生しました。MySQLが起動しているかご確認下さい。");
                return;
            }
        }

        private void grid_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void grid_Click(object sender, EventArgs e)
        {
            if (this.grid.SelectedRows.Count > 0)
            {
                CustomDataMySQLTable c = this.grid.SelectedRows[0].DataBoundItem as CustomDataMySQLTable;
                if (c != null)
                {
                    if (cmbColumns.Items.Contains(c.ColName))
                    {
                        cmbColumns.SelectedItem = c.ColName;
                    }
                    if (cmbNullColumns.Items.Contains(c.ColName))
                    {
                        cmbNullColumns.SelectedItem = c.ColName;
                    }
                }
            }

        }

        private void btnMakeRndMySQLTableScript_Click(object sender, EventArgs e)
        {
            if( string.IsNullOrEmpty(cmbRndMySQLTables.Text))
            {
                MessageBox.Show("MySQLテーブル名を指定してください。");
                return;
            }
            if( string.IsNullOrEmpty(cmbRndMySQLTablesCol.Text))
            {
                MessageBox.Show("MySQL列名を指定してください。");
                return;
            }
            tbxRndMySQLTableColScript.Text += "|rndmstbl:" + cmbRndMySQLTables.Text + "," + cmbRndMySQLTablesCol.Text;
        }

        private void btnCopyRndMySQLTableScript_Click(object sender, EventArgs e)
        {
            tbxScript1.Text += tbxRndMySQLTableColScript.Text;
        }

        private void btnClearRndMySQLTableScript_Click(object sender, EventArgs e)
        {
            tbxRndMySQLTableColScript.Text = "";
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            int xbias = 32;
            int ybias = 48;

            this.tabCtrlScripts.Top = this.pnlSetting.Top + this.pnlSetting.Height;
            this.tabCtrlScripts.Width = this.Width - xbias;

            this.pnlLine.Top = this.tabCtrlScripts.Top + this.tabCtrlScripts.Height;
            this.pnlLine.Width = this.Width - xbias;

            this.grid.Top = this.pnlLine.Top + this.pnlLine.Height;
            this.grid.Width = this.Width - xbias;
            this.grid.Height = this.Height - this.pnlSetting.Height - this.tabCtrlScripts.Height - this.pnlLine.Height - ybias;

        }

        private void btnShowSaveDialog_Click(object sender, EventArgs e)
        {
            frmSaveDialog frm = new frmSaveDialog(this);
            frm.ShowDialog();
        }

        private void btnMakeSeqDateScript_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbSeqDateIncrementType.Text))
            {
                MessageBox.Show("間隔を指定して下さい。");
                return;
            }
            
            tbxSeqDateScript.Text += "|seqdate:" + DatePicSeqStartDate.Text.Replace("/", "") + "," + DatePicSeqEndDate.Text.Replace("/", "") + "," + cmbSeqDateIncrementType.Text;
        }

        private void btnCopySeqDateScript_Click(object sender, EventArgs e)
        {
            tbxScript1.Text += tbxSeqDateScript.Text;
        }

        private void btnClearSeqDateScript_Click(object sender, EventArgs e)
        {
            tbxSeqDateScript.Text = "";
        }

        private void btnMakeRndDateScript_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbRndDateIncrementType.Text))
            {
                MessageBox.Show("間隔を指定して下さい。");
                return;
            }

            tbxRndDateScript.Text += "|rnddate:" + DatePicRndStartDate.Text.Replace("/", "") + "," + DatePicRndEndDate.Text.Replace("/", "") + "," + cmbRndDateIncrementType.Text;
        }

        private void btnCopyRndDateScript_Click(object sender, EventArgs e)
        {
            tbxScript1.Text += tbxRndDateScript.Text;
        }

        private void btnClearRndDateScript_Click(object sender, EventArgs e)
        {
            tbxRndDateScript.Text = "";
        }

        private void btnMakeSeqDateTimeScript_Click(object sender, EventArgs e)
        {
            if( string.IsNullOrEmpty(cmbSeqDateTimeIncrementType.Text ))
            {
                MessageBox.Show("間隔を指定して下さい。");
                return;
            }

            tbxSeqDateTmeScript.Text += "|seqdatetime:" + DatePicSeqStartDateTime.Text.Replace("/", "").Replace(" ", "").Replace(":", "")
                + "," + DatePicSeqEndDateTime.Text.Replace("/", "").Replace(" ", "").Replace(":", "")
                + "," + cmbSeqDateTimeIncrementType.Text;
        }

        private void btnCopySeqDateTimeScript_Click(object sender, EventArgs e)
        {
            tbxScript1.Text += tbxSeqDateTmeScript.Text;
        }

        private void btnClearSeqDateTimeScript_Click(object sender, EventArgs e)
        {
            tbxSeqDateTmeScript.Text = "";
        }

        private void btnMakeRndDateTimeScript_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbRndDateTimeIncrementType.Text))
            {
                MessageBox.Show("間隔を指定して下さい。");
                return;
            }

            tbxRndDateTimeScript.Text += "|rnddatetime:" + DatePicRndStartDateTime.Text.Replace("/", "").Replace(" ", "").Replace(":", "")
                + "," + DatePicRndEndDateTime.Text.Replace("/", "").Replace(" ", "").Replace(":", "")
                + "," + cmbRndDateTimeIncrementType.Text;
        }

        private void btnCopyRndDateTimeScript_Click(object sender, EventArgs e)
        {
            tbxScript1.Text += tbxRndDateTimeScript.Text;
        }

        private void btnClearRndDateTimeScript_Click(object sender, EventArgs e)
        {
            tbxRndDateTimeScript.Text = "";
        }

        private void btnSetNullRatio_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.grid.Rows)
            {
                CustomDataMySQLTable c = row.DataBoundItem as CustomDataMySQLTable;
                if (c != null)
                {
                    if (c.ColName == this.cmbNullColumns.Text)
                    {
                        int ratio = 0;
                        int.TryParse(tbxNullRatio.Text, out ratio);

                        c.NullRatio = "|null:" + ratio.ToString();
                        break;
                    }
                }
            }
            this.grid.Refresh();

        }

        private void tbxNullRatio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar + "") == Microsoft.VisualBasic.Constants.vbBack))
            {
                if (e.KeyChar < '0' || e.KeyChar > '9')
                {
                    e.KeyChar = (char)0;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContextMaxFunctionDataGenerator cc = new ContextMaxFunctionDataGenerator("aa",tbx1.Text);
            string colData = cc.BuildColumnData();
            MessageBox.Show(colData);
            MyLogSingleton.getIncetance().DoLogWithDate(TraceEventType.Verbose, 1, "Col:" + colData);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FunctionsDataBase objFunc = new EmbeddedFuncs();
            Dictionary<string, FuncData> funcs = objFunc.getFuncsData();

            foreach( var key in funcs.Keys )
            {
                FuncData fd = funcs[key];
                MessageBox.Show(fd.StringFuncName);
            }
        }

        private void cmbLogLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLogLevel.SelectedItem != null)
            {
                MyLogSingleton.getIncetance().StrgSwitchLevel = cmbLogLevel.SelectedItem.ToString();
            }

        }




    }
}
