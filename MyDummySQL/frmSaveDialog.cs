using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyDummySQL.DAOs;
using MyDummySQL.CustomData;
using MyDummySQL.Helper;

namespace MyDummySQL
{
    public partial class frmSaveDialog : Form
    {
        private Form1 frm1 = null;
        public frmSaveDialog(Form1 frm1_)
        {
            InitializeComponent();

            this.frm1 = frm1_;
        }

        private void frmSaveDialog_Load(object sender, EventArgs e)
        {
            this.refleshCmbSaveName();
        }

        private void refleshCmbSaveName()
        {
            this.cmbSaveName.Items.Clear();
            IList<string> headerTexts = MyDummySQLSettingsSingleton.getHeaderTexts();
            foreach (string header in headerTexts)
            {
                this.cmbSaveName.Items.Add(header);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbSaveName.Text))
            {
                MessageBox.Show("保存名を入力して下さい。");
                return;
            }

            if (MessageBox.Show(cmbSaveName.Text + "へ保存しますか？", "確認", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("キャンセルしました。");
                return;
            }

            string header = cmbSaveName.Text;

            if (MyDummySQLSettingsSingleton.isExistsHeader(header))
            {
                DialogResult ret = MessageBox.Show("同じ保存名がすでに存在します。上書きしますか？","確認",MessageBoxButtons.OKCancel);
                if (ret != DialogResult.OK)
                {
                    MessageBox.Show("キャンセルしました。");
                    return;
                }

                MyDummySQLSettingsSingleton.deleteSettings(header, MyDummySQLSettingsSingleton.KeycmbKensu);
                MyDummySQLSettingsSingleton.deleteSettings(header, MyDummySQLSettingsSingleton.KeycmbRndAcTable);
                MyDummySQLSettingsSingleton.deleteSettings(header, MyDummySQLSettingsSingleton.KeycmbRndMySQLTables);
                MyDummySQLSettingsSingleton.deleteSettings(header, MyDummySQLSettingsSingleton.KeycmbRndMySQLTablesCol);
                MyDummySQLSettingsSingleton.deleteSettings(header, MyDummySQLSettingsSingleton.KeycmbSeqAcTable);
                MyDummySQLSettingsSingleton.deleteSettings(header, MyDummySQLSettingsSingleton.KeycmbSeqMySQLColumns);
                MyDummySQLSettingsSingleton.deleteSettings(header, MyDummySQLSettingsSingleton.KeycmbSeqMySQLTables);

                MyDummySQLSettingsSingleton.deleteSettings(header, MyDummySQLSettingsSingleton.KeycmbSeqMySQLTables);
                MyDummySQLSettingsSingleton.deleteSettings(header, MyDummySQLSettingsSingleton.KeycmbSeqMySQLTables);
                MyDummySQLSettingsSingleton.deleteSettings(header, MyDummySQLSettingsSingleton.KeycmbSeqMySQLTables);
                MyDummySQLSettingsSingleton.deleteSettings(header, MyDummySQLSettingsSingleton.KeycmbSeqMySQLTables);
                MyDummySQLSettingsSingleton.deleteSettings(header, MyDummySQLSettingsSingleton.KeycmbNullColumns);

            }

            MyDummySQLSettingsSingleton.MergeHeader(header);

            MyDummySQLSettingsSingleton.setValue(header, MyDummySQLSettingsSingleton.KeytbxConstString, frm1.tbxConstString.Text);
            MyDummySQLSettingsSingleton.setValue(header, MyDummySQLSettingsSingleton.KeytbxConstStringScript, frm1.tbxConstStringScript.Text);
            MyDummySQLSettingsSingleton.setValue(header, MyDummySQLSettingsSingleton.KeytbxDbName, frm1.tbxDbName.Text);
            MyDummySQLSettingsSingleton.setValue(header, MyDummySQLSettingsSingleton.KeytbxPassword, CryptHelper.EncryptString(frm1.tbxPassword.Text,CryptHelper.cryptseed));
            MyDummySQLSettingsSingleton.setValue(header, MyDummySQLSettingsSingleton.KeytbxPortNo, frm1.tbxPortNo.Text);
            MyDummySQLSettingsSingleton.setValue(header, MyDummySQLSettingsSingleton.KeytbxRndAcessTableColScript, frm1.tbxRndAcessTableColScript.Text);
            MyDummySQLSettingsSingleton.setValue(header, MyDummySQLSettingsSingleton.KeytbxRndIntEndInt, frm1.tbxRndIntEndInt.Text);
            MyDummySQLSettingsSingleton.setValue(header, MyDummySQLSettingsSingleton.KeytbxRndIntScript, frm1.tbxRndIntScript.Text);
            MyDummySQLSettingsSingleton.setValue(header, MyDummySQLSettingsSingleton.KeytbxRndIntStartInt, frm1.tbxRndIntStartInt.Text);
            MyDummySQLSettingsSingleton.setValue(header, MyDummySQLSettingsSingleton.KeytbxRndMySQLTableColScript, frm1.tbxRndMySQLTableColScript.Text);
            MyDummySQLSettingsSingleton.setValue(header, MyDummySQLSettingsSingleton.KeytbxScript1, frm1.tbxScript1.Text);
            MyDummySQLSettingsSingleton.setValue(header, MyDummySQLSettingsSingleton.KeytbxSeqAccessTableScript, frm1.tbxSeqAccessTableScript.Text);
            MyDummySQLSettingsSingleton.setValue(header, MyDummySQLSettingsSingleton.KeytbxSeqMySQLColScript, frm1.tbxSeqMySQLColScript.Text);
            MyDummySQLSettingsSingleton.setValue(header, MyDummySQLSettingsSingleton.KeytbxSeqNumEndInt, frm1.tbxSeqNumEndInt.Text);
            MyDummySQLSettingsSingleton.setValue(header, MyDummySQLSettingsSingleton.KeytbxSeqNumScript, frm1.tbxSeqNumScript.Text);
            MyDummySQLSettingsSingleton.setValue(header, MyDummySQLSettingsSingleton.KeytbxSeqNumStarInt, frm1.tbxSeqNumStarInt.Text);
            MyDummySQLSettingsSingleton.setValue(header, MyDummySQLSettingsSingleton.KeytbxServername, frm1.tbxServername.Text);
            MyDummySQLSettingsSingleton.setValue(header, MyDummySQLSettingsSingleton.KeytbxTableName, frm1.tbxTableName.Text);
            MyDummySQLSettingsSingleton.setValue(header, MyDummySQLSettingsSingleton.KeytbxUserName, frm1.tbxUserName.Text);
            MyDummySQLSettingsSingleton.setValue(header, MyDummySQLSettingsSingleton.KeytbxSeqDateScript, frm1.tbxSeqDateScript.Text);
            MyDummySQLSettingsSingleton.setValue(header, MyDummySQLSettingsSingleton.KeyDatePicSeqEndDate, frm1.DatePicSeqEndDate.Text);
            MyDummySQLSettingsSingleton.setValue(header, MyDummySQLSettingsSingleton.KeyDatePicSeqStartDate, frm1.DatePicSeqStartDate.Text);
            MyDummySQLSettingsSingleton.setValue(header, MyDummySQLSettingsSingleton.KeycmbSeqDateIncrementType, frm1.cmbSeqDateIncrementType.Text);
            MyDummySQLSettingsSingleton.setValue(header, MyDummySQLSettingsSingleton.KeycmbRndDateIncrementType, frm1.cmbRndDateIncrementType.Text);
            MyDummySQLSettingsSingleton.setValue(header, MyDummySQLSettingsSingleton.KeytbxRndDateScript, frm1.tbxRndDateScript.Text);
            MyDummySQLSettingsSingleton.setValue(header, MyDummySQLSettingsSingleton.KeyDatePicRndEndDate, frm1.DatePicRndEndDate.Text);
            MyDummySQLSettingsSingleton.setValue(header, MyDummySQLSettingsSingleton.KeyDatePicRndStartDate, frm1.DatePicRndStartDate.Text);
            MyDummySQLSettingsSingleton.setValue(header, MyDummySQLSettingsSingleton.KeycmbSeqDateTimeIncrementType, frm1.cmbSeqDateTimeIncrementType.Text);
            MyDummySQLSettingsSingleton.setValue(header, MyDummySQLSettingsSingleton.KeytbxSeqDateTmeScript, frm1.tbxSeqDateTmeScript.Text);
            MyDummySQLSettingsSingleton.setValue(header, MyDummySQLSettingsSingleton.KeyDatePicSeqEndDateTime, frm1.DatePicSeqEndDateTime.Text);
            MyDummySQLSettingsSingleton.setValue(header, MyDummySQLSettingsSingleton.KeyDatePicSeqStartDateTime, frm1.DatePicSeqStartDateTime.Text);
            MyDummySQLSettingsSingleton.setValue(header, MyDummySQLSettingsSingleton.KeycmbRndDateTimeIncrementType, frm1.cmbRndDateTimeIncrementType.Text);
            MyDummySQLSettingsSingleton.setValue(header, MyDummySQLSettingsSingleton.KeytbxRndDateTimeScript, frm1.tbxRndDateTimeScript.Text);
            MyDummySQLSettingsSingleton.setValue(header, MyDummySQLSettingsSingleton.KeyDatePicRndEndDateTime, frm1.DatePicRndEndDateTime.Text);
            MyDummySQLSettingsSingleton.setValue(header, MyDummySQLSettingsSingleton.KeyDatePicRndStartDateTime, frm1.DatePicRndStartDateTime.Text);
            MyDummySQLSettingsSingleton.setValue(header, MyDummySQLSettingsSingleton.KeytbxNullRatio, frm1.tbxNullRatio.Text);


            List<string> strs = new List<string>();
            strs.Clear();
            foreach( object o in frm1.cmbColumns.Items )
            {
                strs.Add(o.ToString());
            }
            MyDummySQLSettingsSingleton.setStringValus(header, MyDummySQLSettingsSingleton.KeycmbColumns, strs);

            strs.Clear();
            foreach( object o in frm1.cmbKensu.Items )
            {
                strs.Add(o.ToString());
            }
            MyDummySQLSettingsSingleton.setStringValus(header, MyDummySQLSettingsSingleton.KeycmbKensu, strs);

            strs.Clear();
            foreach( object o in frm1.cmbRndAcTable.Items )
            {
                strs.Add(o.ToString());
            }
            MyDummySQLSettingsSingleton.setStringValus(header, MyDummySQLSettingsSingleton.KeycmbRndAcTable, strs);


            strs.Clear();
            foreach( object o in frm1.cmbRndMySQLTables.Items )
            {
                strs.Add(o.ToString());
            }
            MyDummySQLSettingsSingleton.setStringValus(header, MyDummySQLSettingsSingleton.KeycmbRndMySQLTables, strs);


            strs.Clear();
            foreach( object o in frm1.cmbRndMySQLTablesCol.Items )
            {
                strs.Add(o.ToString());
            }
            MyDummySQLSettingsSingleton.setStringValus(header, MyDummySQLSettingsSingleton.KeycmbRndMySQLTablesCol, strs);


            strs.Clear();
            foreach( object o in frm1.cmbSeqAcTable.Items )
            {
                strs.Add(o.ToString());
            }
            MyDummySQLSettingsSingleton.setStringValus(header, MyDummySQLSettingsSingleton.KeycmbSeqAcTable, strs);


            strs.Clear();
            foreach (object o in frm1.cmbSeqMySQLColumns.Items)
            {
                strs.Add(o.ToString());
            }
            MyDummySQLSettingsSingleton.setStringValus(header, MyDummySQLSettingsSingleton.KeycmbSeqMySQLColumns, strs);

            strs.Clear();
            foreach (object o in frm1.cmbSeqMySQLTables.Items)
            {
                strs.Add(o.ToString());
            }
            MyDummySQLSettingsSingleton.setStringValus(header, MyDummySQLSettingsSingleton.KeycmbSeqMySQLTables, strs);

            //
            strs.Clear();
            foreach( object o in frm1.lstPreviewRndAccesTable.Items )
            {
                strs.Add(o.ToString());
            }
            MyDummySQLSettingsSingleton.setStringValus(header, MyDummySQLSettingsSingleton.KeylstPreviewRndAccesTable, strs);

            strs.Clear();
            foreach( object o in frm1.lstPreviewRndMySQLTable.Items )
            {
                strs.Add(o.ToString());
            }
            MyDummySQLSettingsSingleton.setStringValus(header, MyDummySQLSettingsSingleton.KeylstPreviewRndMySQLTable, strs);

            strs.Clear();
            foreach( object o in frm1.lstPreviewSeqAccesTable.Items )
            {
                strs.Add(o.ToString());
            }
            MyDummySQLSettingsSingleton.setStringValus(header, MyDummySQLSettingsSingleton.KeylstPreviewSeqAccesTable, strs);

            strs.Clear();
            foreach( object o in frm1.lstPreviewSeqMySQLTable.Items )
            {
                strs.Add(o.ToString());
            }
            MyDummySQLSettingsSingleton.setStringValus(header, MyDummySQLSettingsSingleton.KeylstPreviewSeqMySQLTable, strs);

            strs.Clear();
            foreach (object o in frm1.cmbNullColumns.Items)
            {
                strs.Add(o.ToString());
            }
            MyDummySQLSettingsSingleton.setStringValus(header, MyDummySQLSettingsSingleton.KeycmbNullColumns, strs);



            List<string> cols = new List<string>();
            List<string> colvals = new List<string>();
            List<string> coltypes = new List<string>();
            List<string> colnulls = new List<string>();
            foreach (DataGridViewRow row in this.frm1.grid.Rows)
            {
                CustomDataMySQLTable c = row.DataBoundItem as CustomDataMySQLTable;
                if (c != null)
                {
                    cols.Add(c.ColName);
                    colvals.Add(c.Val);
                    coltypes.Add(c.ColType);
                    colnulls.Add(c.NullRatio);
                }
            }
            MyDummySQLSettingsSingleton.setStringValus(header, MyDummySQLSettingsSingleton.KeygridColNames, cols);
            MyDummySQLSettingsSingleton.setStringValus(header, MyDummySQLSettingsSingleton.KeygridColVals, colvals);
            MyDummySQLSettingsSingleton.setStringValus(header, MyDummySQLSettingsSingleton.KeygridColTypes, coltypes);
            MyDummySQLSettingsSingleton.setStringValus(header, MyDummySQLSettingsSingleton.KeygridColNulls, colnulls);

            this.refleshCmbSaveName();

            MessageBox.Show("保存しました。");

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddDBname_Click(object sender, EventArgs e)
        {
            cmbSaveName.Text += this.frm1.tbxDbName.Text;
        }

        private void btnAddTablename_Click(object sender, EventArgs e)
        {
            cmbSaveName.Text += this.frm1.tbxTableName.Text;

        }

        private void btnAddDBAndTableName_Click(object sender, EventArgs e)
        {
            cmbSaveName.Text += this.frm1.tbxDbName.Text + ":" + this.frm1.tbxTableName.Text;

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbSaveName.Text))
            {
                MessageBox.Show("保存名を選択して下さい。");
                return;
            }

            string header = cmbSaveName.Text;

            if (!MyDummySQLSettingsSingleton.isExistsHeader(header))
            {
                MessageBox.Show("保存名が記録に存在しません。");
                return;
            }

            if (MessageBox.Show(cmbSaveName.Text + "を読み込みますか？", "確認", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("キャンセルしました。");
                return;
            }

            this.frm1.tbxConstString.Text = MyDummySQLSettingsSingleton.getStringValue(header, MyDummySQLSettingsSingleton.KeytbxConstString);
            this.frm1.tbxConstStringScript.Text = MyDummySQLSettingsSingleton.getStringValue(header, MyDummySQLSettingsSingleton.KeytbxConstStringScript);
            this.frm1.tbxDbName.Text = MyDummySQLSettingsSingleton.getStringValue(header, MyDummySQLSettingsSingleton.KeytbxDbName);
            this.frm1.tbxPassword.Text = CryptHelper.DecryptString(MyDummySQLSettingsSingleton.getStringValue(header, MyDummySQLSettingsSingleton.KeytbxPassword), CryptHelper.cryptseed);
            this.frm1.tbxPortNo.Text = MyDummySQLSettingsSingleton.getStringValue(header, MyDummySQLSettingsSingleton.KeytbxPortNo);
            this.frm1.tbxRndAcessTableColScript.Text = MyDummySQLSettingsSingleton.getStringValue(header, MyDummySQLSettingsSingleton.KeytbxRndAcessTableColScript);
            this.frm1.tbxRndIntEndInt.Text = MyDummySQLSettingsSingleton.getStringValue(header, MyDummySQLSettingsSingleton.KeytbxRndIntEndInt);
            this.frm1.tbxRndIntScript.Text = MyDummySQLSettingsSingleton.getStringValue(header, MyDummySQLSettingsSingleton.KeytbxRndIntScript);
            this.frm1.tbxRndIntStartInt.Text = MyDummySQLSettingsSingleton.getStringValue(header, MyDummySQLSettingsSingleton.KeytbxRndIntStartInt);
            this.frm1.tbxRndMySQLTableColScript.Text = MyDummySQLSettingsSingleton.getStringValue(header, MyDummySQLSettingsSingleton.KeytbxRndMySQLTableColScript);
            this.frm1.tbxScript1.Text = MyDummySQLSettingsSingleton.getStringValue(header, MyDummySQLSettingsSingleton.KeytbxScript1);
            this.frm1.tbxSeqAccessTableScript.Text = MyDummySQLSettingsSingleton.getStringValue(header, MyDummySQLSettingsSingleton.KeytbxSeqAccessTableScript);
            this.frm1.tbxSeqMySQLColScript.Text = MyDummySQLSettingsSingleton.getStringValue(header, MyDummySQLSettingsSingleton.KeytbxSeqMySQLColScript);
            this.frm1.tbxSeqNumEndInt.Text = MyDummySQLSettingsSingleton.getStringValue(header, MyDummySQLSettingsSingleton.KeytbxSeqNumEndInt);
            this.frm1.tbxSeqNumScript.Text = MyDummySQLSettingsSingleton.getStringValue(header, MyDummySQLSettingsSingleton.KeytbxSeqNumScript);
            this.frm1.tbxSeqNumStarInt.Text = MyDummySQLSettingsSingleton.getStringValue(header, MyDummySQLSettingsSingleton.KeytbxSeqNumStarInt);
            this.frm1.tbxServername.Text = MyDummySQLSettingsSingleton.getStringValue(header, MyDummySQLSettingsSingleton.KeytbxServername);
            this.frm1.tbxTableName.Text = MyDummySQLSettingsSingleton.getStringValue(header, MyDummySQLSettingsSingleton.KeytbxTableName);
            this.frm1.tbxUserName.Text = MyDummySQLSettingsSingleton.getStringValue(header, MyDummySQLSettingsSingleton.KeytbxUserName);
            this.frm1.tbxSeqDateScript.Text = MyDummySQLSettingsSingleton.getStringValue(header, MyDummySQLSettingsSingleton.KeytbxSeqDateScript);
            this.frm1.DatePicSeqEndDate.Text = MyDummySQLSettingsSingleton.getStringValue(header, MyDummySQLSettingsSingleton.KeyDatePicSeqEndDate);
            this.frm1.DatePicSeqStartDate.Text = MyDummySQLSettingsSingleton.getStringValue(header, MyDummySQLSettingsSingleton.KeyDatePicSeqStartDate);
            this.frm1.cmbSeqDateIncrementType.Text = MyDummySQLSettingsSingleton.getStringValue(header, MyDummySQLSettingsSingleton.KeycmbSeqDateIncrementType);
            this.frm1.cmbRndDateIncrementType.Text = MyDummySQLSettingsSingleton.getStringValue(header, MyDummySQLSettingsSingleton.KeycmbRndDateIncrementType);
            this.frm1.tbxRndDateScript.Text = MyDummySQLSettingsSingleton.getStringValue(header, MyDummySQLSettingsSingleton.KeytbxRndDateScript);
            this.frm1.DatePicRndEndDate.Text = MyDummySQLSettingsSingleton.getStringValue(header, MyDummySQLSettingsSingleton.KeyDatePicRndEndDate);
            this.frm1.DatePicRndStartDate.Text = MyDummySQLSettingsSingleton.getStringValue(header, MyDummySQLSettingsSingleton.KeyDatePicRndStartDate);
            this.frm1.cmbSeqDateTimeIncrementType.Text = MyDummySQLSettingsSingleton.getStringValue(header, MyDummySQLSettingsSingleton.KeycmbSeqDateTimeIncrementType);
            this.frm1.tbxSeqDateTmeScript.Text = MyDummySQLSettingsSingleton.getStringValue(header, MyDummySQLSettingsSingleton.KeytbxSeqDateTmeScript);
            this.frm1.DatePicSeqEndDateTime.Text = MyDummySQLSettingsSingleton.getStringValue(header, MyDummySQLSettingsSingleton.KeyDatePicSeqEndDateTime);
            this.frm1.DatePicSeqStartDateTime.Text = MyDummySQLSettingsSingleton.getStringValue(header, MyDummySQLSettingsSingleton.KeyDatePicSeqStartDateTime);
            this.frm1.cmbRndDateTimeIncrementType.Text = MyDummySQLSettingsSingleton.getStringValue(header, MyDummySQLSettingsSingleton.KeycmbRndDateTimeIncrementType);
            this.frm1.tbxRndDateTimeScript.Text = MyDummySQLSettingsSingleton.getStringValue(header, MyDummySQLSettingsSingleton.KeytbxRndDateTimeScript);
            this.frm1.DatePicRndEndDateTime.Text = MyDummySQLSettingsSingleton.getStringValue(header, MyDummySQLSettingsSingleton.KeyDatePicRndEndDateTime);
            this.frm1.DatePicRndStartDateTime.Text = MyDummySQLSettingsSingleton.getStringValue(header, MyDummySQLSettingsSingleton.KeyDatePicRndStartDateTime);
            this.frm1.tbxNullRatio.Text = MyDummySQLSettingsSingleton.getStringValue(header, MyDummySQLSettingsSingleton.KeytbxNullRatio);


            //this.frm1.grid.Text = MyDummySQLSettingsSingleton.getStringValue(header, MyDummySQLSettingsSingleton.Keygrid);

            this.frm1.lstPreviewRndAccesTable.Items.Clear();
            this.frm1.lstPreviewRndMySQLTable.Items.Clear();
            this.frm1.lstPreviewSeqAccesTable.Items.Clear();
            this.frm1.lstPreviewSeqMySQLTable.Items.Clear();
            this.frm1.cmbColumns.Items.Clear();
            this.frm1.cmbKensu.Items.Clear();
            this.frm1.cmbRndAcTable.Items.Clear();
            this.frm1.cmbRndMySQLTables.Items.Clear();
            this.frm1.cmbRndMySQLTablesCol.Items.Clear();
            this.frm1.cmbSeqAcTable.Items.Clear();
            this.frm1.cmbSeqMySQLColumns.Items.Clear();
            this.frm1.cmbSeqMySQLTables.Items.Clear();
            this.frm1.cmbNullColumns.Items.Clear();


            //this.frm1.cmbColumns.Items.AddRange(MyDummySQLSettingsSingleton.getStringValues(header, MyDummySQLSettingsSingleton.KeycmbColumns).ToArray());
            this.frm1.lstPreviewRndAccesTable.Items.AddRange(MyDummySQLSettingsSingleton.getStringValues(header, MyDummySQLSettingsSingleton.KeylstPreviewRndAccesTable).ToArray());
            this.frm1.lstPreviewRndMySQLTable.Items.AddRange(MyDummySQLSettingsSingleton.getStringValues(header, MyDummySQLSettingsSingleton.KeylstPreviewRndMySQLTable).ToArray());
            this.frm1.lstPreviewSeqAccesTable.Items.AddRange(MyDummySQLSettingsSingleton.getStringValues(header, MyDummySQLSettingsSingleton.KeylstPreviewSeqAccesTable).ToArray());
            this.frm1.lstPreviewSeqMySQLTable.Items.AddRange(MyDummySQLSettingsSingleton.getStringValues(header, MyDummySQLSettingsSingleton.KeylstPreviewSeqMySQLTable).ToArray());
            this.frm1.cmbColumns.Items.AddRange(MyDummySQLSettingsSingleton.getStringValues(header, MyDummySQLSettingsSingleton.KeycmbColumns).ToArray());
            this.frm1.cmbKensu.Items.AddRange(MyDummySQLSettingsSingleton.getStringValues(header, MyDummySQLSettingsSingleton.KeycmbKensu).ToArray());
            this.frm1.cmbRndAcTable.Items.AddRange(MyDummySQLSettingsSingleton.getStringValues(header, MyDummySQLSettingsSingleton.KeycmbRndAcTable).ToArray());
            this.frm1.cmbRndMySQLTables.Items.AddRange(MyDummySQLSettingsSingleton.getStringValues(header, MyDummySQLSettingsSingleton.KeycmbRndMySQLTables).ToArray());
            this.frm1.cmbRndMySQLTablesCol.Items.AddRange(MyDummySQLSettingsSingleton.getStringValues(header, MyDummySQLSettingsSingleton.KeycmbRndMySQLTablesCol).ToArray());
            this.frm1.cmbSeqAcTable.Items.AddRange(MyDummySQLSettingsSingleton.getStringValues(header, MyDummySQLSettingsSingleton.KeycmbSeqAcTable).ToArray());
            this.frm1.cmbSeqMySQLColumns.Items.AddRange(MyDummySQLSettingsSingleton.getStringValues(header, MyDummySQLSettingsSingleton.KeycmbSeqMySQLColumns).ToArray());
            this.frm1.cmbSeqMySQLTables.Items.AddRange(MyDummySQLSettingsSingleton.getStringValues(header, MyDummySQLSettingsSingleton.KeycmbSeqMySQLTables).ToArray());
            this.frm1.cmbNullColumns.Items.AddRange(MyDummySQLSettingsSingleton.getStringValues(header, MyDummySQLSettingsSingleton.KeycmbNullColumns).ToArray());


            IList<string> cols = MyDummySQLSettingsSingleton.getStringValues(header, MyDummySQLSettingsSingleton.KeygridColNames);
            IList<string> colvals = MyDummySQLSettingsSingleton.getStringValues(header, MyDummySQLSettingsSingleton.KeygridColVals);
            IList<string> coltypes = MyDummySQLSettingsSingleton.getStringValues(header, MyDummySQLSettingsSingleton.KeygridColTypes);
            IList<string> colnulls = MyDummySQLSettingsSingleton.getStringValues(header, MyDummySQLSettingsSingleton.KeygridColNulls);
            int max = cols.Count;
            if (max > colvals.Count)
            {
                max = colvals.Count;
            }
            if (max > coltypes.Count)
            {
                max = coltypes.Count;
            }
            if (max > colnulls.Count)
            {
                max = colnulls.Count;
            }
            this.frm1.dataSource.Clear();
            for( int i = 0; i < max; i++ )
            {
                CustomDataMySQLTable c = new CustomDataMySQLTable(cols[i], coltypes[i], colvals[i], colnulls[i]);
                this.frm1.dataSource.Add(c);
                //this.frm1.grid.Rows.Add(c);
            }
            this.frm1.grid.DataSource = this.frm1.dataSource;
            this.frm1.grid.Refresh();

            MessageBox.Show("読み込みました。");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show(cmbSaveName.Text + " を削除しますか？", "確認", MessageBoxButtons.OKCancel);
            if (ret != System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("キャンセルしました。");
                return;
            }

            MyDummySQLSettingsSingleton.deleteSettings(cmbSaveName.Text);

            MessageBox.Show(cmbSaveName.Text + " を削除しました。");

            this.refleshCmbSaveName();
            cmbSaveName.Text = "";

        }
    }
}
