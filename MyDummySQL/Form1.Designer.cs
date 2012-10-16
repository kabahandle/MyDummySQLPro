namespace MyDummySQL
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tbxServername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxDbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxPortNo = new System.Windows.Forms.TextBox();
            this.btnTest1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxScript1 = new System.Windows.Forms.TextBox();
            this.btnParse1 = new System.Windows.Forms.Button();
            this.tabCtrlScripts = new System.Windows.Forms.TabControl();
            this.seqNumberPage = new System.Windows.Forms.TabPage();
            this.btnSeqNumClearScript = new System.Windows.Forms.Button();
            this.btnSeqNumCopyScript = new System.Windows.Forms.Button();
            this.tbxSeqNumScript = new System.Windows.Forms.TextBox();
            this.btnSeqNumMakeScript = new System.Windows.Forms.Button();
            this.tbxSeqNumEndInt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxSeqNumStarInt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRndIntClearScript = new System.Windows.Forms.Button();
            this.btnRndIntCopyScript = new System.Windows.Forms.Button();
            this.tbxRndIntScript = new System.Windows.Forms.TextBox();
            this.btnRndNumMakeScript = new System.Windows.Forms.Button();
            this.tbxRndIntEndInt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxRndIntStartInt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ConstTabPage = new System.Windows.Forms.TabPage();
            this.btnConstStringClearScript = new System.Windows.Forms.Button();
            this.btnConstStringCopyScript = new System.Windows.Forms.Button();
            this.tbxConstStringScript = new System.Windows.Forms.TextBox();
            this.btnMakeConstStringScript = new System.Windows.Forms.Button();
            this.tbxConstString = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SeqMySQLTableColsTabPage = new System.Windows.Forms.TabPage();
            this.label24 = new System.Windows.Forms.Label();
            this.lstPreviewSeqMySQLTable = new System.Windows.Forms.ListBox();
            this.btnClearSeqMySQLColScript = new System.Windows.Forms.Button();
            this.btnCopySeqMySQLColScript = new System.Windows.Forms.Button();
            this.tbxSeqMySQLColScript = new System.Windows.Forms.TextBox();
            this.btnMakeSeqMySQLColScript = new System.Windows.Forms.Button();
            this.cmbSeqMySQLColumns = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbSeqMySQLTables = new System.Windows.Forms.ComboBox();
            this.btnReadTable = new System.Windows.Forms.Button();
            this.RndMySQLTableColsTabPage = new System.Windows.Forms.TabPage();
            this.label23 = new System.Windows.Forms.Label();
            this.lstPreviewRndMySQLTable = new System.Windows.Forms.ListBox();
            this.btnClearRndMySQLTableScript = new System.Windows.Forms.Button();
            this.btnCopyRndMySQLTableScript = new System.Windows.Forms.Button();
            this.tbxRndMySQLTableColScript = new System.Windows.Forms.TextBox();
            this.btnMakeRndMySQLTableScript = new System.Windows.Forms.Button();
            this.cmbRndMySQLTablesCol = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbRndMySQLTables = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.SeqAccessTableColsTabPage = new System.Windows.Forms.TabPage();
            this.label22 = new System.Windows.Forms.Label();
            this.lstPreviewSeqAccesTable = new System.Windows.Forms.ListBox();
            this.btnClearSeqAccessTableScript = new System.Windows.Forms.Button();
            this.btnCopySeqAccessTableScript = new System.Windows.Forms.Button();
            this.tbxSeqAccessTableScript = new System.Windows.Forms.TextBox();
            this.btnMakeSeqAccessTableScript = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.cmbSeqAcTable = new System.Windows.Forms.ComboBox();
            this.btnReadSeqAccessTable = new System.Windows.Forms.Button();
            this.RndAccessTableColsTabPage = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
            this.lstPreviewRndAccesTable = new System.Windows.Forms.ListBox();
            this.btnClearRndAccessTableColScript = new System.Windows.Forms.Button();
            this.btnCopyRndAccessTableColScript = new System.Windows.Forms.Button();
            this.tbxRndAcessTableColScript = new System.Windows.Forms.TextBox();
            this.btnMakeRndAccessTableColScript = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbRndAcTable = new System.Windows.Forms.ComboBox();
            this.btnReadRndAccessTable = new System.Windows.Forms.Button();
            this.SeqDateTabPage = new System.Windows.Forms.TabPage();
            this.cmbSeqDateIncrementType = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.btnClearSeqDateScript = new System.Windows.Forms.Button();
            this.btnCopySeqDateScript = new System.Windows.Forms.Button();
            this.tbxSeqDateScript = new System.Windows.Forms.TextBox();
            this.btnMakeSeqDateScript = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.DatePicSeqEndDate = new System.Windows.Forms.DateTimePicker();
            this.label28 = new System.Windows.Forms.Label();
            this.DatePicSeqStartDate = new System.Windows.Forms.DateTimePicker();
            this.RndDateTabPage = new System.Windows.Forms.TabPage();
            this.cmbRndDateIncrementType = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.btnClearRndDateScript = new System.Windows.Forms.Button();
            this.btnCopyRndDateScript = new System.Windows.Forms.Button();
            this.tbxRndDateScript = new System.Windows.Forms.TextBox();
            this.btnMakeRndDateScript = new System.Windows.Forms.Button();
            this.label32 = new System.Windows.Forms.Label();
            this.DatePicRndEndDate = new System.Windows.Forms.DateTimePicker();
            this.label33 = new System.Windows.Forms.Label();
            this.DatePicRndStartDate = new System.Windows.Forms.DateTimePicker();
            this.SeqDateTimeTabPage = new System.Windows.Forms.TabPage();
            this.cmbSeqDateTimeIncrementType = new System.Windows.Forms.ComboBox();
            this.label34 = new System.Windows.Forms.Label();
            this.btnClearSeqDateTimeScript = new System.Windows.Forms.Button();
            this.btnCopySeqDateTimeScript = new System.Windows.Forms.Button();
            this.tbxSeqDateTmeScript = new System.Windows.Forms.TextBox();
            this.btnMakeSeqDateTimeScript = new System.Windows.Forms.Button();
            this.label35 = new System.Windows.Forms.Label();
            this.DatePicSeqEndDateTime = new System.Windows.Forms.DateTimePicker();
            this.label36 = new System.Windows.Forms.Label();
            this.DatePicSeqStartDateTime = new System.Windows.Forms.DateTimePicker();
            this.RndDateTimeTabPage = new System.Windows.Forms.TabPage();
            this.cmbRndDateTimeIncrementType = new System.Windows.Forms.ComboBox();
            this.label37 = new System.Windows.Forms.Label();
            this.btnClearRndDateTimeScript = new System.Windows.Forms.Button();
            this.btnCopyRndDateTimeScript = new System.Windows.Forms.Button();
            this.tbxRndDateTimeScript = new System.Windows.Forms.TextBox();
            this.btnMakeRndDateTimeScript = new System.Windows.Forms.Button();
            this.label38 = new System.Windows.Forms.Label();
            this.DatePicRndEndDateTime = new System.Windows.Forms.DateTimePicker();
            this.label39 = new System.Windows.Forms.Label();
            this.DatePicRndStartDateTime = new System.Windows.Forms.DateTimePicker();
            this.grid = new System.Windows.Forms.DataGridView();
            this.btnReadColumn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tbxTableName = new System.Windows.Forms.TextBox();
            this.cmbColumns = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnAddScript = new System.Windows.Forms.Button();
            this.btnClearScript = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnTestInsert = new System.Windows.Forms.Button();
            this.cmbKensu = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.pnlSetting = new System.Windows.Forms.Panel();
            this.label43 = new System.Windows.Forms.Label();
            this.cmbLogLevel = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tbx1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.lblTotalNum = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lblInsertedNum = new System.Windows.Forms.Label();
            this.btnShowSaveDialog = new System.Windows.Forms.Button();
            this.pnlLine = new System.Windows.Forms.Panel();
            this.btnSetNullRatio = new System.Windows.Forms.Button();
            this.label42 = new System.Windows.Forms.Label();
            this.tbxNullRatio = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.cmbNullColumns = new System.Windows.Forms.ComboBox();
            this.label40 = new System.Windows.Forms.Label();
            this.tabCtrlScripts.SuspendLayout();
            this.seqNumberPage.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.ConstTabPage.SuspendLayout();
            this.SeqMySQLTableColsTabPage.SuspendLayout();
            this.RndMySQLTableColsTabPage.SuspendLayout();
            this.SeqAccessTableColsTabPage.SuspendLayout();
            this.RndAccessTableColsTabPage.SuspendLayout();
            this.SeqDateTabPage.SuspendLayout();
            this.RndDateTabPage.SuspendLayout();
            this.SeqDateTimeTabPage.SuspendLayout();
            this.RndDateTimeTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.pnlSetting.SuspendLayout();
            this.pnlLine.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "サーバー名：";
            // 
            // tbxServername
            // 
            this.tbxServername.Location = new System.Drawing.Point(81, 7);
            this.tbxServername.Name = "tbxServername";
            this.tbxServername.Size = new System.Drawing.Size(100, 19);
            this.tbxServername.TabIndex = 1;
            this.tbxServername.Text = "localhost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "DB名：";
            // 
            // tbxDbName
            // 
            this.tbxDbName.Location = new System.Drawing.Point(262, 7);
            this.tbxDbName.Name = "tbxDbName";
            this.tbxDbName.Size = new System.Drawing.Size(100, 19);
            this.tbxDbName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "ユーザー名：";
            // 
            // tbxUserName
            // 
            this.tbxUserName.Location = new System.Drawing.Point(81, 34);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Size = new System.Drawing.Size(100, 19);
            this.tbxUserName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "パスワード：";
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(262, 34);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(100, 19);
            this.tbxPassword.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "ポート番号：";
            // 
            // tbxPortNo
            // 
            this.tbxPortNo.Location = new System.Drawing.Point(437, 7);
            this.tbxPortNo.Name = "tbxPortNo";
            this.tbxPortNo.Size = new System.Drawing.Size(100, 19);
            this.tbxPortNo.TabIndex = 3;
            this.tbxPortNo.Text = "3306";
            // 
            // btnTest1
            // 
            this.btnTest1.Location = new System.Drawing.Point(563, 3);
            this.btnTest1.Name = "btnTest1";
            this.btnTest1.Size = new System.Drawing.Size(75, 23);
            this.btnTest1.TabIndex = 7;
            this.btnTest1.Text = "接続テスト";
            this.btnTest1.UseVisualStyleBackColor = true;
            this.btnTest1.Click += new System.EventHandler(this.btnTest1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "評価：";
            // 
            // tbxScript1
            // 
            this.tbxScript1.Location = new System.Drawing.Point(48, 17);
            this.tbxScript1.Name = "tbxScript1";
            this.tbxScript1.Size = new System.Drawing.Size(328, 19);
            this.tbxScript1.TabIndex = 72;
            // 
            // btnParse1
            // 
            this.btnParse1.Location = new System.Drawing.Point(380, 15);
            this.btnParse1.Name = "btnParse1";
            this.btnParse1.Size = new System.Drawing.Size(64, 23);
            this.btnParse1.TabIndex = 73;
            this.btnParse1.Text = "テスト";
            this.btnParse1.UseVisualStyleBackColor = true;
            this.btnParse1.Click += new System.EventHandler(this.btnParse1_Click);
            // 
            // tabCtrlScripts
            // 
            this.tabCtrlScripts.Controls.Add(this.seqNumberPage);
            this.tabCtrlScripts.Controls.Add(this.tabPage2);
            this.tabCtrlScripts.Controls.Add(this.ConstTabPage);
            this.tabCtrlScripts.Controls.Add(this.SeqMySQLTableColsTabPage);
            this.tabCtrlScripts.Controls.Add(this.RndMySQLTableColsTabPage);
            this.tabCtrlScripts.Controls.Add(this.SeqAccessTableColsTabPage);
            this.tabCtrlScripts.Controls.Add(this.RndAccessTableColsTabPage);
            this.tabCtrlScripts.Controls.Add(this.SeqDateTabPage);
            this.tabCtrlScripts.Controls.Add(this.RndDateTabPage);
            this.tabCtrlScripts.Controls.Add(this.SeqDateTimeTabPage);
            this.tabCtrlScripts.Controls.Add(this.RndDateTimeTabPage);
            this.tabCtrlScripts.Location = new System.Drawing.Point(6, 109);
            this.tabCtrlScripts.Multiline = true;
            this.tabCtrlScripts.Name = "tabCtrlScripts";
            this.tabCtrlScripts.SelectedIndex = 0;
            this.tabCtrlScripts.Size = new System.Drawing.Size(821, 195);
            this.tabCtrlScripts.TabIndex = 16;
            this.tabCtrlScripts.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // seqNumberPage
            // 
            this.seqNumberPage.Controls.Add(this.btnSeqNumClearScript);
            this.seqNumberPage.Controls.Add(this.btnSeqNumCopyScript);
            this.seqNumberPage.Controls.Add(this.tbxSeqNumScript);
            this.seqNumberPage.Controls.Add(this.btnSeqNumMakeScript);
            this.seqNumberPage.Controls.Add(this.tbxSeqNumEndInt);
            this.seqNumberPage.Controls.Add(this.label8);
            this.seqNumberPage.Controls.Add(this.tbxSeqNumStarInt);
            this.seqNumberPage.Controls.Add(this.label7);
            this.seqNumberPage.Location = new System.Drawing.Point(4, 40);
            this.seqNumberPage.Name = "seqNumberPage";
            this.seqNumberPage.Padding = new System.Windows.Forms.Padding(3);
            this.seqNumberPage.Size = new System.Drawing.Size(813, 151);
            this.seqNumberPage.TabIndex = 0;
            this.seqNumberPage.Text = "順序番号";
            this.seqNumberPage.UseVisualStyleBackColor = true;
            // 
            // btnSeqNumClearScript
            // 
            this.btnSeqNumClearScript.Location = new System.Drawing.Point(223, 120);
            this.btnSeqNumClearScript.Name = "btnSeqNumClearScript";
            this.btnSeqNumClearScript.Size = new System.Drawing.Size(75, 23);
            this.btnSeqNumClearScript.TabIndex = 6;
            this.btnSeqNumClearScript.Text = "クリア";
            this.btnSeqNumClearScript.UseVisualStyleBackColor = true;
            this.btnSeqNumClearScript.Click += new System.EventHandler(this.btnSeqNumClearScript_Click);
            // 
            // btnSeqNumCopyScript
            // 
            this.btnSeqNumCopyScript.Location = new System.Drawing.Point(10, 120);
            this.btnSeqNumCopyScript.Name = "btnSeqNumCopyScript";
            this.btnSeqNumCopyScript.Size = new System.Drawing.Size(75, 23);
            this.btnSeqNumCopyScript.TabIndex = 5;
            this.btnSeqNumCopyScript.Text = "挿入";
            this.btnSeqNumCopyScript.UseVisualStyleBackColor = true;
            this.btnSeqNumCopyScript.Click += new System.EventHandler(this.btnSeqNumCopy_Click);
            // 
            // tbxSeqNumScript
            // 
            this.tbxSeqNumScript.Location = new System.Drawing.Point(10, 95);
            this.tbxSeqNumScript.Name = "tbxSeqNumScript";
            this.tbxSeqNumScript.Size = new System.Drawing.Size(288, 19);
            this.tbxSeqNumScript.TabIndex = 4;
            // 
            // btnSeqNumMakeScript
            // 
            this.btnSeqNumMakeScript.Location = new System.Drawing.Point(10, 66);
            this.btnSeqNumMakeScript.Name = "btnSeqNumMakeScript";
            this.btnSeqNumMakeScript.Size = new System.Drawing.Size(75, 23);
            this.btnSeqNumMakeScript.TabIndex = 3;
            this.btnSeqNumMakeScript.Text = "作成";
            this.btnSeqNumMakeScript.UseVisualStyleBackColor = true;
            this.btnSeqNumMakeScript.Click += new System.EventHandler(this.btnSeqNumMakeScript_Click);
            // 
            // tbxSeqNumEndInt
            // 
            this.tbxSeqNumEndInt.Location = new System.Drawing.Point(73, 41);
            this.tbxSeqNumEndInt.Name = "tbxSeqNumEndInt";
            this.tbxSeqNumEndInt.Size = new System.Drawing.Size(147, 19);
            this.tbxSeqNumEndInt.TabIndex = 2;
            this.tbxSeqNumEndInt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSeqNumEndInt_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "終了番号：";
            // 
            // tbxSeqNumStarInt
            // 
            this.tbxSeqNumStarInt.Location = new System.Drawing.Point(73, 12);
            this.tbxSeqNumStarInt.Name = "tbxSeqNumStarInt";
            this.tbxSeqNumStarInt.Size = new System.Drawing.Size(147, 19);
            this.tbxSeqNumStarInt.TabIndex = 1;
            this.tbxSeqNumStarInt.TextChanged += new System.EventHandler(this.tbxSeqNumStarInt_TextChanged);
            this.tbxSeqNumStarInt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSeqNumStarInt_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "開始番号：";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnRndIntClearScript);
            this.tabPage2.Controls.Add(this.btnRndIntCopyScript);
            this.tabPage2.Controls.Add(this.tbxRndIntScript);
            this.tabPage2.Controls.Add(this.btnRndNumMakeScript);
            this.tabPage2.Controls.Add(this.tbxRndIntEndInt);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.tbxRndIntStartInt);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(813, 151);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ランダム番号";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnRndIntClearScript
            // 
            this.btnRndIntClearScript.Location = new System.Drawing.Point(223, 120);
            this.btnRndIntClearScript.Name = "btnRndIntClearScript";
            this.btnRndIntClearScript.Size = new System.Drawing.Size(75, 23);
            this.btnRndIntClearScript.TabIndex = 12;
            this.btnRndIntClearScript.Text = "クリア";
            this.btnRndIntClearScript.UseVisualStyleBackColor = true;
            this.btnRndIntClearScript.Click += new System.EventHandler(this.btnRndIntClearScript_Click);
            // 
            // btnRndIntCopyScript
            // 
            this.btnRndIntCopyScript.Location = new System.Drawing.Point(10, 120);
            this.btnRndIntCopyScript.Name = "btnRndIntCopyScript";
            this.btnRndIntCopyScript.Size = new System.Drawing.Size(75, 23);
            this.btnRndIntCopyScript.TabIndex = 11;
            this.btnRndIntCopyScript.Text = "挿入";
            this.btnRndIntCopyScript.UseVisualStyleBackColor = true;
            this.btnRndIntCopyScript.Click += new System.EventHandler(this.btnRndIntCopyScript_Click);
            // 
            // tbxRndIntScript
            // 
            this.tbxRndIntScript.Location = new System.Drawing.Point(10, 95);
            this.tbxRndIntScript.Name = "tbxRndIntScript";
            this.tbxRndIntScript.Size = new System.Drawing.Size(288, 19);
            this.tbxRndIntScript.TabIndex = 10;
            this.tbxRndIntScript.TextChanged += new System.EventHandler(this.tbxRndIntScript_TextChanged);
            // 
            // btnRndNumMakeScript
            // 
            this.btnRndNumMakeScript.Location = new System.Drawing.Point(10, 66);
            this.btnRndNumMakeScript.Name = "btnRndNumMakeScript";
            this.btnRndNumMakeScript.Size = new System.Drawing.Size(75, 23);
            this.btnRndNumMakeScript.TabIndex = 9;
            this.btnRndNumMakeScript.Text = "作成";
            this.btnRndNumMakeScript.UseVisualStyleBackColor = true;
            this.btnRndNumMakeScript.Click += new System.EventHandler(this.btnRndNumMakeScript_Click);
            // 
            // tbxRndIntEndInt
            // 
            this.tbxRndIntEndInt.Location = new System.Drawing.Point(73, 41);
            this.tbxRndIntEndInt.Name = "tbxRndIntEndInt";
            this.tbxRndIntEndInt.Size = new System.Drawing.Size(147, 19);
            this.tbxRndIntEndInt.TabIndex = 8;
            this.tbxRndIntEndInt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxRndIntEndInt_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 9;
            this.label9.Text = "終了番号：";
            // 
            // tbxRndIntStartInt
            // 
            this.tbxRndIntStartInt.Location = new System.Drawing.Point(73, 12);
            this.tbxRndIntStartInt.Name = "tbxRndIntStartInt";
            this.tbxRndIntStartInt.Size = new System.Drawing.Size(147, 19);
            this.tbxRndIntStartInt.TabIndex = 7;
            this.tbxRndIntStartInt.TextChanged += new System.EventHandler(this.tbxRndIntStartInt_TextChanged);
            this.tbxRndIntStartInt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxRndIntStartInt_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 7;
            this.label10.Text = "開始番号：";
            // 
            // ConstTabPage
            // 
            this.ConstTabPage.Controls.Add(this.btnConstStringClearScript);
            this.ConstTabPage.Controls.Add(this.btnConstStringCopyScript);
            this.ConstTabPage.Controls.Add(this.tbxConstStringScript);
            this.ConstTabPage.Controls.Add(this.btnMakeConstStringScript);
            this.ConstTabPage.Controls.Add(this.tbxConstString);
            this.ConstTabPage.Controls.Add(this.label14);
            this.ConstTabPage.Location = new System.Drawing.Point(4, 40);
            this.ConstTabPage.Name = "ConstTabPage";
            this.ConstTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ConstTabPage.Size = new System.Drawing.Size(813, 151);
            this.ConstTabPage.TabIndex = 2;
            this.ConstTabPage.Text = "文字定数";
            this.ConstTabPage.UseVisualStyleBackColor = true;
            // 
            // btnConstStringClearScript
            // 
            this.btnConstStringClearScript.Location = new System.Drawing.Point(219, 95);
            this.btnConstStringClearScript.Name = "btnConstStringClearScript";
            this.btnConstStringClearScript.Size = new System.Drawing.Size(75, 23);
            this.btnConstStringClearScript.TabIndex = 17;
            this.btnConstStringClearScript.Text = "クリア";
            this.btnConstStringClearScript.UseVisualStyleBackColor = true;
            this.btnConstStringClearScript.Click += new System.EventHandler(this.btnConstStringClearScript_Click);
            // 
            // btnConstStringCopyScript
            // 
            this.btnConstStringCopyScript.Location = new System.Drawing.Point(6, 95);
            this.btnConstStringCopyScript.Name = "btnConstStringCopyScript";
            this.btnConstStringCopyScript.Size = new System.Drawing.Size(75, 23);
            this.btnConstStringCopyScript.TabIndex = 16;
            this.btnConstStringCopyScript.Text = "挿入";
            this.btnConstStringCopyScript.UseVisualStyleBackColor = true;
            this.btnConstStringCopyScript.Click += new System.EventHandler(this.btnConstStringCopyScript_Click);
            // 
            // tbxConstStringScript
            // 
            this.tbxConstStringScript.Location = new System.Drawing.Point(6, 70);
            this.tbxConstStringScript.Name = "tbxConstStringScript";
            this.tbxConstStringScript.Size = new System.Drawing.Size(288, 19);
            this.tbxConstStringScript.TabIndex = 15;
            // 
            // btnMakeConstStringScript
            // 
            this.btnMakeConstStringScript.Location = new System.Drawing.Point(6, 41);
            this.btnMakeConstStringScript.Name = "btnMakeConstStringScript";
            this.btnMakeConstStringScript.Size = new System.Drawing.Size(75, 23);
            this.btnMakeConstStringScript.TabIndex = 14;
            this.btnMakeConstStringScript.Text = "作成";
            this.btnMakeConstStringScript.UseVisualStyleBackColor = true;
            this.btnMakeConstStringScript.Click += new System.EventHandler(this.btnMakeConstStringScript_Click);
            // 
            // tbxConstString
            // 
            this.tbxConstString.Location = new System.Drawing.Point(81, 13);
            this.tbxConstString.Name = "tbxConstString";
            this.tbxConstString.Size = new System.Drawing.Size(225, 19);
            this.tbxConstString.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 12);
            this.label14.TabIndex = 9;
            this.label14.Text = "文字定数値：";
            // 
            // SeqMySQLTableColsTabPage
            // 
            this.SeqMySQLTableColsTabPage.Controls.Add(this.label24);
            this.SeqMySQLTableColsTabPage.Controls.Add(this.lstPreviewSeqMySQLTable);
            this.SeqMySQLTableColsTabPage.Controls.Add(this.btnClearSeqMySQLColScript);
            this.SeqMySQLTableColsTabPage.Controls.Add(this.btnCopySeqMySQLColScript);
            this.SeqMySQLTableColsTabPage.Controls.Add(this.tbxSeqMySQLColScript);
            this.SeqMySQLTableColsTabPage.Controls.Add(this.btnMakeSeqMySQLColScript);
            this.SeqMySQLTableColsTabPage.Controls.Add(this.cmbSeqMySQLColumns);
            this.SeqMySQLTableColsTabPage.Controls.Add(this.label16);
            this.SeqMySQLTableColsTabPage.Controls.Add(this.label15);
            this.SeqMySQLTableColsTabPage.Controls.Add(this.cmbSeqMySQLTables);
            this.SeqMySQLTableColsTabPage.Controls.Add(this.btnReadTable);
            this.SeqMySQLTableColsTabPage.Location = new System.Drawing.Point(4, 40);
            this.SeqMySQLTableColsTabPage.Name = "SeqMySQLTableColsTabPage";
            this.SeqMySQLTableColsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SeqMySQLTableColsTabPage.Size = new System.Drawing.Size(813, 151);
            this.SeqMySQLTableColsTabPage.TabIndex = 3;
            this.SeqMySQLTableColsTabPage.Text = "順序MySQLテーブル列";
            this.SeqMySQLTableColsTabPage.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(385, 14);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(55, 12);
            this.label24.TabIndex = 52;
            this.label24.Text = "プレビュー：";
            // 
            // lstPreviewSeqMySQLTable
            // 
            this.lstPreviewSeqMySQLTable.FormattingEnabled = true;
            this.lstPreviewSeqMySQLTable.ItemHeight = 12;
            this.lstPreviewSeqMySQLTable.Location = new System.Drawing.Point(387, 29);
            this.lstPreviewSeqMySQLTable.Name = "lstPreviewSeqMySQLTable";
            this.lstPreviewSeqMySQLTable.Size = new System.Drawing.Size(120, 88);
            this.lstPreviewSeqMySQLTable.TabIndex = 51;
            // 
            // btnClearSeqMySQLColScript
            // 
            this.btnClearSeqMySQLColScript.Location = new System.Drawing.Point(227, 123);
            this.btnClearSeqMySQLColScript.Name = "btnClearSeqMySQLColScript";
            this.btnClearSeqMySQLColScript.Size = new System.Drawing.Size(75, 23);
            this.btnClearSeqMySQLColScript.TabIndex = 24;
            this.btnClearSeqMySQLColScript.Text = "クリア";
            this.btnClearSeqMySQLColScript.UseVisualStyleBackColor = true;
            this.btnClearSeqMySQLColScript.Click += new System.EventHandler(this.btnClearSeqMySQLColScript_Click);
            // 
            // btnCopySeqMySQLColScript
            // 
            this.btnCopySeqMySQLColScript.Location = new System.Drawing.Point(14, 123);
            this.btnCopySeqMySQLColScript.Name = "btnCopySeqMySQLColScript";
            this.btnCopySeqMySQLColScript.Size = new System.Drawing.Size(75, 23);
            this.btnCopySeqMySQLColScript.TabIndex = 23;
            this.btnCopySeqMySQLColScript.Text = "挿入";
            this.btnCopySeqMySQLColScript.UseVisualStyleBackColor = true;
            this.btnCopySeqMySQLColScript.Click += new System.EventHandler(this.btnCopySeqMySQLColScript_Click);
            // 
            // tbxSeqMySQLColScript
            // 
            this.tbxSeqMySQLColScript.Location = new System.Drawing.Point(14, 98);
            this.tbxSeqMySQLColScript.Name = "tbxSeqMySQLColScript";
            this.tbxSeqMySQLColScript.Size = new System.Drawing.Size(288, 19);
            this.tbxSeqMySQLColScript.TabIndex = 22;
            // 
            // btnMakeSeqMySQLColScript
            // 
            this.btnMakeSeqMySQLColScript.Location = new System.Drawing.Point(14, 69);
            this.btnMakeSeqMySQLColScript.Name = "btnMakeSeqMySQLColScript";
            this.btnMakeSeqMySQLColScript.Size = new System.Drawing.Size(75, 23);
            this.btnMakeSeqMySQLColScript.TabIndex = 21;
            this.btnMakeSeqMySQLColScript.Text = "作成";
            this.btnMakeSeqMySQLColScript.UseVisualStyleBackColor = true;
            this.btnMakeSeqMySQLColScript.Click += new System.EventHandler(this.btnMakeSeqMySQLColScript_Click);
            // 
            // cmbSeqMySQLColumns
            // 
            this.cmbSeqMySQLColumns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeqMySQLColumns.FormattingEnabled = true;
            this.cmbSeqMySQLColumns.Location = new System.Drawing.Point(79, 43);
            this.cmbSeqMySQLColumns.Name = "cmbSeqMySQLColumns";
            this.cmbSeqMySQLColumns.Size = new System.Drawing.Size(181, 20);
            this.cmbSeqMySQLColumns.TabIndex = 19;
            this.cmbSeqMySQLColumns.SelectedIndexChanged += new System.EventHandler(this.cmbSeqMySQLColumns_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 46);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 12);
            this.label16.TabIndex = 11;
            this.label16.Text = "列名：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 12);
            this.label15.TabIndex = 10;
            this.label15.Text = "テーブル名：";
            // 
            // cmbSeqMySQLTables
            // 
            this.cmbSeqMySQLTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeqMySQLTables.FormattingEnabled = true;
            this.cmbSeqMySQLTables.Location = new System.Drawing.Point(79, 11);
            this.cmbSeqMySQLTables.Name = "cmbSeqMySQLTables";
            this.cmbSeqMySQLTables.Size = new System.Drawing.Size(181, 20);
            this.cmbSeqMySQLTables.TabIndex = 18;
            this.cmbSeqMySQLTables.SelectedIndexChanged += new System.EventHandler(this.cmbMySQLTables_SelectedIndexChanged);
            // 
            // btnReadTable
            // 
            this.btnReadTable.Location = new System.Drawing.Point(271, 11);
            this.btnReadTable.Name = "btnReadTable";
            this.btnReadTable.Size = new System.Drawing.Size(75, 23);
            this.btnReadTable.TabIndex = 20;
            this.btnReadTable.Text = "テーブル読込";
            this.btnReadTable.UseVisualStyleBackColor = true;
            this.btnReadTable.Click += new System.EventHandler(this.btnReadTable_Click);
            // 
            // RndMySQLTableColsTabPage
            // 
            this.RndMySQLTableColsTabPage.Controls.Add(this.label23);
            this.RndMySQLTableColsTabPage.Controls.Add(this.lstPreviewRndMySQLTable);
            this.RndMySQLTableColsTabPage.Controls.Add(this.btnClearRndMySQLTableScript);
            this.RndMySQLTableColsTabPage.Controls.Add(this.btnCopyRndMySQLTableScript);
            this.RndMySQLTableColsTabPage.Controls.Add(this.tbxRndMySQLTableColScript);
            this.RndMySQLTableColsTabPage.Controls.Add(this.btnMakeRndMySQLTableScript);
            this.RndMySQLTableColsTabPage.Controls.Add(this.cmbRndMySQLTablesCol);
            this.RndMySQLTableColsTabPage.Controls.Add(this.label17);
            this.RndMySQLTableColsTabPage.Controls.Add(this.label18);
            this.RndMySQLTableColsTabPage.Controls.Add(this.cmbRndMySQLTables);
            this.RndMySQLTableColsTabPage.Controls.Add(this.button4);
            this.RndMySQLTableColsTabPage.Location = new System.Drawing.Point(4, 40);
            this.RndMySQLTableColsTabPage.Name = "RndMySQLTableColsTabPage";
            this.RndMySQLTableColsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.RndMySQLTableColsTabPage.Size = new System.Drawing.Size(813, 151);
            this.RndMySQLTableColsTabPage.TabIndex = 4;
            this.RndMySQLTableColsTabPage.Text = "ランダムMySQLテーブル列";
            this.RndMySQLTableColsTabPage.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(385, 14);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(55, 12);
            this.label23.TabIndex = 50;
            this.label23.Text = "プレビュー：";
            // 
            // lstPreviewRndMySQLTable
            // 
            this.lstPreviewRndMySQLTable.FormattingEnabled = true;
            this.lstPreviewRndMySQLTable.ItemHeight = 12;
            this.lstPreviewRndMySQLTable.Location = new System.Drawing.Point(387, 29);
            this.lstPreviewRndMySQLTable.Name = "lstPreviewRndMySQLTable";
            this.lstPreviewRndMySQLTable.Size = new System.Drawing.Size(120, 88);
            this.lstPreviewRndMySQLTable.TabIndex = 49;
            // 
            // btnClearRndMySQLTableScript
            // 
            this.btnClearRndMySQLTableScript.Location = new System.Drawing.Point(227, 123);
            this.btnClearRndMySQLTableScript.Name = "btnClearRndMySQLTableScript";
            this.btnClearRndMySQLTableScript.Size = new System.Drawing.Size(75, 23);
            this.btnClearRndMySQLTableScript.TabIndex = 31;
            this.btnClearRndMySQLTableScript.Text = "クリア";
            this.btnClearRndMySQLTableScript.UseVisualStyleBackColor = true;
            this.btnClearRndMySQLTableScript.Click += new System.EventHandler(this.btnClearRndMySQLTableScript_Click);
            // 
            // btnCopyRndMySQLTableScript
            // 
            this.btnCopyRndMySQLTableScript.Location = new System.Drawing.Point(14, 123);
            this.btnCopyRndMySQLTableScript.Name = "btnCopyRndMySQLTableScript";
            this.btnCopyRndMySQLTableScript.Size = new System.Drawing.Size(75, 23);
            this.btnCopyRndMySQLTableScript.TabIndex = 30;
            this.btnCopyRndMySQLTableScript.Text = "挿入";
            this.btnCopyRndMySQLTableScript.UseVisualStyleBackColor = true;
            this.btnCopyRndMySQLTableScript.Click += new System.EventHandler(this.btnCopyRndMySQLTableScript_Click);
            // 
            // tbxRndMySQLTableColScript
            // 
            this.tbxRndMySQLTableColScript.Location = new System.Drawing.Point(14, 98);
            this.tbxRndMySQLTableColScript.Name = "tbxRndMySQLTableColScript";
            this.tbxRndMySQLTableColScript.Size = new System.Drawing.Size(288, 19);
            this.tbxRndMySQLTableColScript.TabIndex = 29;
            // 
            // btnMakeRndMySQLTableScript
            // 
            this.btnMakeRndMySQLTableScript.Location = new System.Drawing.Point(14, 69);
            this.btnMakeRndMySQLTableScript.Name = "btnMakeRndMySQLTableScript";
            this.btnMakeRndMySQLTableScript.Size = new System.Drawing.Size(75, 23);
            this.btnMakeRndMySQLTableScript.TabIndex = 28;
            this.btnMakeRndMySQLTableScript.Text = "作成";
            this.btnMakeRndMySQLTableScript.UseVisualStyleBackColor = true;
            this.btnMakeRndMySQLTableScript.Click += new System.EventHandler(this.btnMakeRndMySQLTableScript_Click);
            // 
            // cmbRndMySQLTablesCol
            // 
            this.cmbRndMySQLTablesCol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRndMySQLTablesCol.FormattingEnabled = true;
            this.cmbRndMySQLTablesCol.Location = new System.Drawing.Point(79, 43);
            this.cmbRndMySQLTablesCol.Name = "cmbRndMySQLTablesCol";
            this.cmbRndMySQLTablesCol.Size = new System.Drawing.Size(181, 20);
            this.cmbRndMySQLTablesCol.TabIndex = 26;
            this.cmbRndMySQLTablesCol.SelectedIndexChanged += new System.EventHandler(this.cmbRndMySQLTablesCol_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 46);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 12);
            this.label17.TabIndex = 24;
            this.label17.Text = "列名：";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 14);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 12);
            this.label18.TabIndex = 23;
            this.label18.Text = "テーブル名：";
            // 
            // cmbRndMySQLTables
            // 
            this.cmbRndMySQLTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRndMySQLTables.FormattingEnabled = true;
            this.cmbRndMySQLTables.Location = new System.Drawing.Point(79, 11);
            this.cmbRndMySQLTables.Name = "cmbRndMySQLTables";
            this.cmbRndMySQLTables.Size = new System.Drawing.Size(181, 20);
            this.cmbRndMySQLTables.TabIndex = 25;
            this.cmbRndMySQLTables.SelectedIndexChanged += new System.EventHandler(this.cmbRndMySQLTables_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(271, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 27;
            this.button4.Text = "テーブル読込";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // SeqAccessTableColsTabPage
            // 
            this.SeqAccessTableColsTabPage.Controls.Add(this.label22);
            this.SeqAccessTableColsTabPage.Controls.Add(this.lstPreviewSeqAccesTable);
            this.SeqAccessTableColsTabPage.Controls.Add(this.btnClearSeqAccessTableScript);
            this.SeqAccessTableColsTabPage.Controls.Add(this.btnCopySeqAccessTableScript);
            this.SeqAccessTableColsTabPage.Controls.Add(this.tbxSeqAccessTableScript);
            this.SeqAccessTableColsTabPage.Controls.Add(this.btnMakeSeqAccessTableScript);
            this.SeqAccessTableColsTabPage.Controls.Add(this.label20);
            this.SeqAccessTableColsTabPage.Controls.Add(this.cmbSeqAcTable);
            this.SeqAccessTableColsTabPage.Controls.Add(this.btnReadSeqAccessTable);
            this.SeqAccessTableColsTabPage.Location = new System.Drawing.Point(4, 40);
            this.SeqAccessTableColsTabPage.Name = "SeqAccessTableColsTabPage";
            this.SeqAccessTableColsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SeqAccessTableColsTabPage.Size = new System.Drawing.Size(813, 151);
            this.SeqAccessTableColsTabPage.TabIndex = 5;
            this.SeqAccessTableColsTabPage.Text = "順序Accessテーブル列";
            this.SeqAccessTableColsTabPage.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(385, 15);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(55, 12);
            this.label22.TabIndex = 48;
            this.label22.Text = "プレビュー：";
            // 
            // lstPreviewSeqAccesTable
            // 
            this.lstPreviewSeqAccesTable.FormattingEnabled = true;
            this.lstPreviewSeqAccesTable.ItemHeight = 12;
            this.lstPreviewSeqAccesTable.Location = new System.Drawing.Point(387, 30);
            this.lstPreviewSeqAccesTable.Name = "lstPreviewSeqAccesTable";
            this.lstPreviewSeqAccesTable.Size = new System.Drawing.Size(120, 88);
            this.lstPreviewSeqAccesTable.TabIndex = 47;
            // 
            // btnClearSeqAccessTableScript
            // 
            this.btnClearSeqAccessTableScript.Location = new System.Drawing.Point(226, 95);
            this.btnClearSeqAccessTableScript.Name = "btnClearSeqAccessTableScript";
            this.btnClearSeqAccessTableScript.Size = new System.Drawing.Size(75, 23);
            this.btnClearSeqAccessTableScript.TabIndex = 37;
            this.btnClearSeqAccessTableScript.Text = "クリア";
            this.btnClearSeqAccessTableScript.UseVisualStyleBackColor = true;
            this.btnClearSeqAccessTableScript.Click += new System.EventHandler(this.btnClearSeqAccessTableScript_Click);
            // 
            // btnCopySeqAccessTableScript
            // 
            this.btnCopySeqAccessTableScript.Location = new System.Drawing.Point(13, 95);
            this.btnCopySeqAccessTableScript.Name = "btnCopySeqAccessTableScript";
            this.btnCopySeqAccessTableScript.Size = new System.Drawing.Size(75, 23);
            this.btnCopySeqAccessTableScript.TabIndex = 36;
            this.btnCopySeqAccessTableScript.Text = "挿入";
            this.btnCopySeqAccessTableScript.UseVisualStyleBackColor = true;
            this.btnCopySeqAccessTableScript.Click += new System.EventHandler(this.btnCopySeqAccessTableScript_Click);
            // 
            // tbxSeqAccessTableScript
            // 
            this.tbxSeqAccessTableScript.Location = new System.Drawing.Point(13, 70);
            this.tbxSeqAccessTableScript.Name = "tbxSeqAccessTableScript";
            this.tbxSeqAccessTableScript.Size = new System.Drawing.Size(288, 19);
            this.tbxSeqAccessTableScript.TabIndex = 35;
            // 
            // btnMakeSeqAccessTableScript
            // 
            this.btnMakeSeqAccessTableScript.Location = new System.Drawing.Point(13, 41);
            this.btnMakeSeqAccessTableScript.Name = "btnMakeSeqAccessTableScript";
            this.btnMakeSeqAccessTableScript.Size = new System.Drawing.Size(75, 23);
            this.btnMakeSeqAccessTableScript.TabIndex = 34;
            this.btnMakeSeqAccessTableScript.Text = "作成";
            this.btnMakeSeqAccessTableScript.UseVisualStyleBackColor = true;
            this.btnMakeSeqAccessTableScript.Click += new System.EventHandler(this.btnMakeSeqAccessTableScript_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(13, 14);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 12);
            this.label20.TabIndex = 32;
            this.label20.Text = "テーブル名：";
            // 
            // cmbSeqAcTable
            // 
            this.cmbSeqAcTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeqAcTable.FormattingEnabled = true;
            this.cmbSeqAcTable.Location = new System.Drawing.Point(80, 11);
            this.cmbSeqAcTable.Name = "cmbSeqAcTable";
            this.cmbSeqAcTable.Size = new System.Drawing.Size(181, 20);
            this.cmbSeqAcTable.TabIndex = 32;
            this.cmbSeqAcTable.SelectedIndexChanged += new System.EventHandler(this.cmbSeqAcTable_SelectedIndexChanged);
            // 
            // btnReadSeqAccessTable
            // 
            this.btnReadSeqAccessTable.Location = new System.Drawing.Point(272, 11);
            this.btnReadSeqAccessTable.Name = "btnReadSeqAccessTable";
            this.btnReadSeqAccessTable.Size = new System.Drawing.Size(75, 23);
            this.btnReadSeqAccessTable.TabIndex = 33;
            this.btnReadSeqAccessTable.Text = "テーブル読込";
            this.btnReadSeqAccessTable.UseVisualStyleBackColor = true;
            this.btnReadSeqAccessTable.Click += new System.EventHandler(this.btnReadSeqAccessTable_Click);
            // 
            // RndAccessTableColsTabPage
            // 
            this.RndAccessTableColsTabPage.Controls.Add(this.label21);
            this.RndAccessTableColsTabPage.Controls.Add(this.lstPreviewRndAccesTable);
            this.RndAccessTableColsTabPage.Controls.Add(this.btnClearRndAccessTableColScript);
            this.RndAccessTableColsTabPage.Controls.Add(this.btnCopyRndAccessTableColScript);
            this.RndAccessTableColsTabPage.Controls.Add(this.tbxRndAcessTableColScript);
            this.RndAccessTableColsTabPage.Controls.Add(this.btnMakeRndAccessTableColScript);
            this.RndAccessTableColsTabPage.Controls.Add(this.label19);
            this.RndAccessTableColsTabPage.Controls.Add(this.cmbRndAcTable);
            this.RndAccessTableColsTabPage.Controls.Add(this.btnReadRndAccessTable);
            this.RndAccessTableColsTabPage.Location = new System.Drawing.Point(4, 40);
            this.RndAccessTableColsTabPage.Name = "RndAccessTableColsTabPage";
            this.RndAccessTableColsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.RndAccessTableColsTabPage.Size = new System.Drawing.Size(813, 151);
            this.RndAccessTableColsTabPage.TabIndex = 6;
            this.RndAccessTableColsTabPage.Text = "ランダムAccessテーブル列";
            this.RndAccessTableColsTabPage.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(385, 13);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(55, 12);
            this.label21.TabIndex = 46;
            this.label21.Text = "プレビュー：";
            // 
            // lstPreviewRndAccesTable
            // 
            this.lstPreviewRndAccesTable.FormattingEnabled = true;
            this.lstPreviewRndAccesTable.ItemHeight = 12;
            this.lstPreviewRndAccesTable.Location = new System.Drawing.Point(387, 28);
            this.lstPreviewRndAccesTable.Name = "lstPreviewRndAccesTable";
            this.lstPreviewRndAccesTable.Size = new System.Drawing.Size(120, 88);
            this.lstPreviewRndAccesTable.TabIndex = 26;
            // 
            // btnClearRndAccessTableColScript
            // 
            this.btnClearRndAccessTableColScript.Location = new System.Drawing.Point(224, 94);
            this.btnClearRndAccessTableColScript.Name = "btnClearRndAccessTableColScript";
            this.btnClearRndAccessTableColScript.Size = new System.Drawing.Size(75, 23);
            this.btnClearRndAccessTableColScript.TabIndex = 43;
            this.btnClearRndAccessTableColScript.Text = "クリア";
            this.btnClearRndAccessTableColScript.UseVisualStyleBackColor = true;
            this.btnClearRndAccessTableColScript.Click += new System.EventHandler(this.btnClearRndAccessTableColScript_Click);
            // 
            // btnCopyRndAccessTableColScript
            // 
            this.btnCopyRndAccessTableColScript.Location = new System.Drawing.Point(11, 94);
            this.btnCopyRndAccessTableColScript.Name = "btnCopyRndAccessTableColScript";
            this.btnCopyRndAccessTableColScript.Size = new System.Drawing.Size(75, 23);
            this.btnCopyRndAccessTableColScript.TabIndex = 42;
            this.btnCopyRndAccessTableColScript.Text = "挿入";
            this.btnCopyRndAccessTableColScript.UseVisualStyleBackColor = true;
            this.btnCopyRndAccessTableColScript.Click += new System.EventHandler(this.btnCopyRndAccessTableColScript_Click);
            // 
            // tbxRndAcessTableColScript
            // 
            this.tbxRndAcessTableColScript.Location = new System.Drawing.Point(11, 69);
            this.tbxRndAcessTableColScript.Name = "tbxRndAcessTableColScript";
            this.tbxRndAcessTableColScript.Size = new System.Drawing.Size(288, 19);
            this.tbxRndAcessTableColScript.TabIndex = 41;
            this.tbxRndAcessTableColScript.TextChanged += new System.EventHandler(this.tbxRndAcessTableColScript_TextChanged);
            // 
            // btnMakeRndAccessTableColScript
            // 
            this.btnMakeRndAccessTableColScript.Location = new System.Drawing.Point(11, 40);
            this.btnMakeRndAccessTableColScript.Name = "btnMakeRndAccessTableColScript";
            this.btnMakeRndAccessTableColScript.Size = new System.Drawing.Size(75, 23);
            this.btnMakeRndAccessTableColScript.TabIndex = 40;
            this.btnMakeRndAccessTableColScript.Text = "作成";
            this.btnMakeRndAccessTableColScript.UseVisualStyleBackColor = true;
            this.btnMakeRndAccessTableColScript.Click += new System.EventHandler(this.btnMakeRndAccessTableColScript_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(11, 13);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 12);
            this.label19.TabIndex = 41;
            this.label19.Text = "テーブル名：";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // cmbRndAcTable
            // 
            this.cmbRndAcTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRndAcTable.FormattingEnabled = true;
            this.cmbRndAcTable.Location = new System.Drawing.Point(78, 10);
            this.cmbRndAcTable.Name = "cmbRndAcTable";
            this.cmbRndAcTable.Size = new System.Drawing.Size(181, 20);
            this.cmbRndAcTable.TabIndex = 38;
            this.cmbRndAcTable.SelectedIndexChanged += new System.EventHandler(this.cmbRndAcTable_SelectedIndexChanged);
            // 
            // btnReadRndAccessTable
            // 
            this.btnReadRndAccessTable.Location = new System.Drawing.Point(270, 10);
            this.btnReadRndAccessTable.Name = "btnReadRndAccessTable";
            this.btnReadRndAccessTable.Size = new System.Drawing.Size(75, 23);
            this.btnReadRndAccessTable.TabIndex = 39;
            this.btnReadRndAccessTable.Text = "テーブル読込";
            this.btnReadRndAccessTable.UseVisualStyleBackColor = true;
            this.btnReadRndAccessTable.Click += new System.EventHandler(this.btnReadRndAccessTable_Click);
            // 
            // SeqDateTabPage
            // 
            this.SeqDateTabPage.Controls.Add(this.cmbSeqDateIncrementType);
            this.SeqDateTabPage.Controls.Add(this.label30);
            this.SeqDateTabPage.Controls.Add(this.btnClearSeqDateScript);
            this.SeqDateTabPage.Controls.Add(this.btnCopySeqDateScript);
            this.SeqDateTabPage.Controls.Add(this.tbxSeqDateScript);
            this.SeqDateTabPage.Controls.Add(this.btnMakeSeqDateScript);
            this.SeqDateTabPage.Controls.Add(this.label29);
            this.SeqDateTabPage.Controls.Add(this.DatePicSeqEndDate);
            this.SeqDateTabPage.Controls.Add(this.label28);
            this.SeqDateTabPage.Controls.Add(this.DatePicSeqStartDate);
            this.SeqDateTabPage.Location = new System.Drawing.Point(4, 40);
            this.SeqDateTabPage.Name = "SeqDateTabPage";
            this.SeqDateTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SeqDateTabPage.Size = new System.Drawing.Size(813, 151);
            this.SeqDateTabPage.TabIndex = 7;
            this.SeqDateTabPage.Text = "順序日付";
            this.SeqDateTabPage.UseVisualStyleBackColor = true;
            // 
            // cmbSeqDateIncrementType
            // 
            this.cmbSeqDateIncrementType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeqDateIncrementType.FormattingEnabled = true;
            this.cmbSeqDateIncrementType.Items.AddRange(new object[] {
            "日",
            "月",
            "年"});
            this.cmbSeqDateIncrementType.Location = new System.Drawing.Point(206, 10);
            this.cmbSeqDateIncrementType.Name = "cmbSeqDateIncrementType";
            this.cmbSeqDateIncrementType.Size = new System.Drawing.Size(90, 20);
            this.cmbSeqDateIncrementType.TabIndex = 46;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(165, 13);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(35, 12);
            this.label30.TabIndex = 50;
            this.label30.Text = "間隔：";
            // 
            // btnClearSeqDateScript
            // 
            this.btnClearSeqDateScript.Location = new System.Drawing.Point(221, 112);
            this.btnClearSeqDateScript.Name = "btnClearSeqDateScript";
            this.btnClearSeqDateScript.Size = new System.Drawing.Size(75, 23);
            this.btnClearSeqDateScript.TabIndex = 50;
            this.btnClearSeqDateScript.Text = "クリア";
            this.btnClearSeqDateScript.UseVisualStyleBackColor = true;
            this.btnClearSeqDateScript.Click += new System.EventHandler(this.btnClearSeqDateScript_Click);
            // 
            // btnCopySeqDateScript
            // 
            this.btnCopySeqDateScript.Location = new System.Drawing.Point(8, 112);
            this.btnCopySeqDateScript.Name = "btnCopySeqDateScript";
            this.btnCopySeqDateScript.Size = new System.Drawing.Size(75, 23);
            this.btnCopySeqDateScript.TabIndex = 49;
            this.btnCopySeqDateScript.Text = "挿入";
            this.btnCopySeqDateScript.UseVisualStyleBackColor = true;
            this.btnCopySeqDateScript.Click += new System.EventHandler(this.btnCopySeqDateScript_Click);
            // 
            // tbxSeqDateScript
            // 
            this.tbxSeqDateScript.Location = new System.Drawing.Point(8, 87);
            this.tbxSeqDateScript.Name = "tbxSeqDateScript";
            this.tbxSeqDateScript.Size = new System.Drawing.Size(288, 19);
            this.tbxSeqDateScript.TabIndex = 48;
            // 
            // btnMakeSeqDateScript
            // 
            this.btnMakeSeqDateScript.Location = new System.Drawing.Point(8, 58);
            this.btnMakeSeqDateScript.Name = "btnMakeSeqDateScript";
            this.btnMakeSeqDateScript.Size = new System.Drawing.Size(75, 23);
            this.btnMakeSeqDateScript.TabIndex = 47;
            this.btnMakeSeqDateScript.Text = "作成";
            this.btnMakeSeqDateScript.UseVisualStyleBackColor = true;
            this.btnMakeSeqDateScript.Click += new System.EventHandler(this.btnMakeSeqDateScript_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(6, 38);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(47, 12);
            this.label29.TabIndex = 3;
            this.label29.Text = "終了日：";
            // 
            // DatePicSeqEndDate
            // 
            this.DatePicSeqEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePicSeqEndDate.Location = new System.Drawing.Point(59, 33);
            this.DatePicSeqEndDate.Name = "DatePicSeqEndDate";
            this.DatePicSeqEndDate.Size = new System.Drawing.Size(89, 19);
            this.DatePicSeqEndDate.TabIndex = 45;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 13);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(47, 12);
            this.label28.TabIndex = 1;
            this.label28.Text = "開始日：";
            // 
            // DatePicSeqStartDate
            // 
            this.DatePicSeqStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePicSeqStartDate.Location = new System.Drawing.Point(59, 8);
            this.DatePicSeqStartDate.Name = "DatePicSeqStartDate";
            this.DatePicSeqStartDate.Size = new System.Drawing.Size(89, 19);
            this.DatePicSeqStartDate.TabIndex = 44;
            // 
            // RndDateTabPage
            // 
            this.RndDateTabPage.Controls.Add(this.cmbRndDateIncrementType);
            this.RndDateTabPage.Controls.Add(this.label31);
            this.RndDateTabPage.Controls.Add(this.btnClearRndDateScript);
            this.RndDateTabPage.Controls.Add(this.btnCopyRndDateScript);
            this.RndDateTabPage.Controls.Add(this.tbxRndDateScript);
            this.RndDateTabPage.Controls.Add(this.btnMakeRndDateScript);
            this.RndDateTabPage.Controls.Add(this.label32);
            this.RndDateTabPage.Controls.Add(this.DatePicRndEndDate);
            this.RndDateTabPage.Controls.Add(this.label33);
            this.RndDateTabPage.Controls.Add(this.DatePicRndStartDate);
            this.RndDateTabPage.Location = new System.Drawing.Point(4, 40);
            this.RndDateTabPage.Name = "RndDateTabPage";
            this.RndDateTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.RndDateTabPage.Size = new System.Drawing.Size(813, 151);
            this.RndDateTabPage.TabIndex = 8;
            this.RndDateTabPage.Text = "ランダム日付";
            this.RndDateTabPage.UseVisualStyleBackColor = true;
            // 
            // cmbRndDateIncrementType
            // 
            this.cmbRndDateIncrementType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRndDateIncrementType.FormattingEnabled = true;
            this.cmbRndDateIncrementType.Items.AddRange(new object[] {
            "日",
            "月",
            "年"});
            this.cmbRndDateIncrementType.Location = new System.Drawing.Point(207, 15);
            this.cmbRndDateIncrementType.Name = "cmbRndDateIncrementType";
            this.cmbRndDateIncrementType.Size = new System.Drawing.Size(90, 20);
            this.cmbRndDateIncrementType.TabIndex = 53;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(166, 18);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(35, 12);
            this.label31.TabIndex = 60;
            this.label31.Text = "間隔：";
            // 
            // btnClearRndDateScript
            // 
            this.btnClearRndDateScript.Location = new System.Drawing.Point(222, 117);
            this.btnClearRndDateScript.Name = "btnClearRndDateScript";
            this.btnClearRndDateScript.Size = new System.Drawing.Size(75, 23);
            this.btnClearRndDateScript.TabIndex = 57;
            this.btnClearRndDateScript.Text = "クリア";
            this.btnClearRndDateScript.UseVisualStyleBackColor = true;
            this.btnClearRndDateScript.Click += new System.EventHandler(this.btnClearRndDateScript_Click);
            // 
            // btnCopyRndDateScript
            // 
            this.btnCopyRndDateScript.Location = new System.Drawing.Point(9, 117);
            this.btnCopyRndDateScript.Name = "btnCopyRndDateScript";
            this.btnCopyRndDateScript.Size = new System.Drawing.Size(75, 23);
            this.btnCopyRndDateScript.TabIndex = 56;
            this.btnCopyRndDateScript.Text = "挿入";
            this.btnCopyRndDateScript.UseVisualStyleBackColor = true;
            this.btnCopyRndDateScript.Click += new System.EventHandler(this.btnCopyRndDateScript_Click);
            // 
            // tbxRndDateScript
            // 
            this.tbxRndDateScript.Location = new System.Drawing.Point(9, 92);
            this.tbxRndDateScript.Name = "tbxRndDateScript";
            this.tbxRndDateScript.Size = new System.Drawing.Size(288, 19);
            this.tbxRndDateScript.TabIndex = 55;
            // 
            // btnMakeRndDateScript
            // 
            this.btnMakeRndDateScript.Location = new System.Drawing.Point(9, 63);
            this.btnMakeRndDateScript.Name = "btnMakeRndDateScript";
            this.btnMakeRndDateScript.Size = new System.Drawing.Size(75, 23);
            this.btnMakeRndDateScript.TabIndex = 54;
            this.btnMakeRndDateScript.Text = "作成";
            this.btnMakeRndDateScript.UseVisualStyleBackColor = true;
            this.btnMakeRndDateScript.Click += new System.EventHandler(this.btnMakeRndDateScript_Click);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(7, 43);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(47, 12);
            this.label32.TabIndex = 55;
            this.label32.Text = "終了日：";
            // 
            // DatePicRndEndDate
            // 
            this.DatePicRndEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePicRndEndDate.Location = new System.Drawing.Point(60, 38);
            this.DatePicRndEndDate.Name = "DatePicRndEndDate";
            this.DatePicRndEndDate.Size = new System.Drawing.Size(89, 19);
            this.DatePicRndEndDate.TabIndex = 52;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(7, 18);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(47, 12);
            this.label33.TabIndex = 53;
            this.label33.Text = "開始日：";
            // 
            // DatePicRndStartDate
            // 
            this.DatePicRndStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePicRndStartDate.Location = new System.Drawing.Point(60, 13);
            this.DatePicRndStartDate.Name = "DatePicRndStartDate";
            this.DatePicRndStartDate.Size = new System.Drawing.Size(89, 19);
            this.DatePicRndStartDate.TabIndex = 51;
            // 
            // SeqDateTimeTabPage
            // 
            this.SeqDateTimeTabPage.Controls.Add(this.cmbSeqDateTimeIncrementType);
            this.SeqDateTimeTabPage.Controls.Add(this.label34);
            this.SeqDateTimeTabPage.Controls.Add(this.btnClearSeqDateTimeScript);
            this.SeqDateTimeTabPage.Controls.Add(this.btnCopySeqDateTimeScript);
            this.SeqDateTimeTabPage.Controls.Add(this.tbxSeqDateTmeScript);
            this.SeqDateTimeTabPage.Controls.Add(this.btnMakeSeqDateTimeScript);
            this.SeqDateTimeTabPage.Controls.Add(this.label35);
            this.SeqDateTimeTabPage.Controls.Add(this.DatePicSeqEndDateTime);
            this.SeqDateTimeTabPage.Controls.Add(this.label36);
            this.SeqDateTimeTabPage.Controls.Add(this.DatePicSeqStartDateTime);
            this.SeqDateTimeTabPage.Location = new System.Drawing.Point(4, 40);
            this.SeqDateTimeTabPage.Name = "SeqDateTimeTabPage";
            this.SeqDateTimeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SeqDateTimeTabPage.Size = new System.Drawing.Size(813, 151);
            this.SeqDateTimeTabPage.TabIndex = 9;
            this.SeqDateTimeTabPage.Text = "順序日時";
            this.SeqDateTimeTabPage.UseVisualStyleBackColor = true;
            // 
            // cmbSeqDateTimeIncrementType
            // 
            this.cmbSeqDateTimeIncrementType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeqDateTimeIncrementType.FormattingEnabled = true;
            this.cmbSeqDateTimeIncrementType.Items.AddRange(new object[] {
            "秒",
            "分",
            "時",
            "日",
            "月",
            "年"});
            this.cmbSeqDateTimeIncrementType.Location = new System.Drawing.Point(252, 8);
            this.cmbSeqDateTimeIncrementType.Name = "cmbSeqDateTimeIncrementType";
            this.cmbSeqDateTimeIncrementType.Size = new System.Drawing.Size(90, 20);
            this.cmbSeqDateTimeIncrementType.TabIndex = 60;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(211, 11);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(35, 12);
            this.label34.TabIndex = 60;
            this.label34.Text = "間隔：";
            // 
            // btnClearSeqDateTimeScript
            // 
            this.btnClearSeqDateTimeScript.Location = new System.Drawing.Point(222, 110);
            this.btnClearSeqDateTimeScript.Name = "btnClearSeqDateTimeScript";
            this.btnClearSeqDateTimeScript.Size = new System.Drawing.Size(75, 23);
            this.btnClearSeqDateTimeScript.TabIndex = 64;
            this.btnClearSeqDateTimeScript.Text = "クリア";
            this.btnClearSeqDateTimeScript.UseVisualStyleBackColor = true;
            this.btnClearSeqDateTimeScript.Click += new System.EventHandler(this.btnClearSeqDateTimeScript_Click);
            // 
            // btnCopySeqDateTimeScript
            // 
            this.btnCopySeqDateTimeScript.Location = new System.Drawing.Point(9, 110);
            this.btnCopySeqDateTimeScript.Name = "btnCopySeqDateTimeScript";
            this.btnCopySeqDateTimeScript.Size = new System.Drawing.Size(75, 23);
            this.btnCopySeqDateTimeScript.TabIndex = 63;
            this.btnCopySeqDateTimeScript.Text = "挿入";
            this.btnCopySeqDateTimeScript.UseVisualStyleBackColor = true;
            this.btnCopySeqDateTimeScript.Click += new System.EventHandler(this.btnCopySeqDateTimeScript_Click);
            // 
            // tbxSeqDateTmeScript
            // 
            this.tbxSeqDateTmeScript.Location = new System.Drawing.Point(9, 85);
            this.tbxSeqDateTmeScript.Name = "tbxSeqDateTmeScript";
            this.tbxSeqDateTmeScript.Size = new System.Drawing.Size(288, 19);
            this.tbxSeqDateTmeScript.TabIndex = 62;
            // 
            // btnMakeSeqDateTimeScript
            // 
            this.btnMakeSeqDateTimeScript.Location = new System.Drawing.Point(9, 56);
            this.btnMakeSeqDateTimeScript.Name = "btnMakeSeqDateTimeScript";
            this.btnMakeSeqDateTimeScript.Size = new System.Drawing.Size(75, 23);
            this.btnMakeSeqDateTimeScript.TabIndex = 61;
            this.btnMakeSeqDateTimeScript.Text = "作成";
            this.btnMakeSeqDateTimeScript.UseVisualStyleBackColor = true;
            this.btnMakeSeqDateTimeScript.Click += new System.EventHandler(this.btnMakeSeqDateTimeScript_Click);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(7, 36);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(47, 12);
            this.label35.TabIndex = 55;
            this.label35.Text = "終了日：";
            // 
            // DatePicSeqEndDateTime
            // 
            this.DatePicSeqEndDateTime.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.DatePicSeqEndDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePicSeqEndDateTime.Location = new System.Drawing.Point(60, 31);
            this.DatePicSeqEndDateTime.Name = "DatePicSeqEndDateTime";
            this.DatePicSeqEndDateTime.Size = new System.Drawing.Size(145, 19);
            this.DatePicSeqEndDateTime.TabIndex = 59;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(7, 11);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(47, 12);
            this.label36.TabIndex = 53;
            this.label36.Text = "開始日：";
            // 
            // DatePicSeqStartDateTime
            // 
            this.DatePicSeqStartDateTime.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.DatePicSeqStartDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePicSeqStartDateTime.Location = new System.Drawing.Point(60, 6);
            this.DatePicSeqStartDateTime.Name = "DatePicSeqStartDateTime";
            this.DatePicSeqStartDateTime.Size = new System.Drawing.Size(145, 19);
            this.DatePicSeqStartDateTime.TabIndex = 58;
            // 
            // RndDateTimeTabPage
            // 
            this.RndDateTimeTabPage.Controls.Add(this.cmbRndDateTimeIncrementType);
            this.RndDateTimeTabPage.Controls.Add(this.label37);
            this.RndDateTimeTabPage.Controls.Add(this.btnClearRndDateTimeScript);
            this.RndDateTimeTabPage.Controls.Add(this.btnCopyRndDateTimeScript);
            this.RndDateTimeTabPage.Controls.Add(this.tbxRndDateTimeScript);
            this.RndDateTimeTabPage.Controls.Add(this.btnMakeRndDateTimeScript);
            this.RndDateTimeTabPage.Controls.Add(this.label38);
            this.RndDateTimeTabPage.Controls.Add(this.DatePicRndEndDateTime);
            this.RndDateTimeTabPage.Controls.Add(this.label39);
            this.RndDateTimeTabPage.Controls.Add(this.DatePicRndStartDateTime);
            this.RndDateTimeTabPage.Location = new System.Drawing.Point(4, 40);
            this.RndDateTimeTabPage.Name = "RndDateTimeTabPage";
            this.RndDateTimeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.RndDateTimeTabPage.Size = new System.Drawing.Size(813, 151);
            this.RndDateTimeTabPage.TabIndex = 10;
            this.RndDateTimeTabPage.Text = "ランダム日時";
            this.RndDateTimeTabPage.UseVisualStyleBackColor = true;
            // 
            // cmbRndDateTimeIncrementType
            // 
            this.cmbRndDateTimeIncrementType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRndDateTimeIncrementType.FormattingEnabled = true;
            this.cmbRndDateTimeIncrementType.Items.AddRange(new object[] {
            "秒",
            "分",
            "時",
            "日",
            "月",
            "年"});
            this.cmbRndDateTimeIncrementType.Location = new System.Drawing.Point(254, 8);
            this.cmbRndDateTimeIncrementType.Name = "cmbRndDateTimeIncrementType";
            this.cmbRndDateTimeIncrementType.Size = new System.Drawing.Size(90, 20);
            this.cmbRndDateTimeIncrementType.TabIndex = 67;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(213, 11);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(35, 12);
            this.label37.TabIndex = 70;
            this.label37.Text = "間隔：";
            // 
            // btnClearRndDateTimeScript
            // 
            this.btnClearRndDateTimeScript.Location = new System.Drawing.Point(224, 110);
            this.btnClearRndDateTimeScript.Name = "btnClearRndDateTimeScript";
            this.btnClearRndDateTimeScript.Size = new System.Drawing.Size(75, 23);
            this.btnClearRndDateTimeScript.TabIndex = 71;
            this.btnClearRndDateTimeScript.Text = "クリア";
            this.btnClearRndDateTimeScript.UseVisualStyleBackColor = true;
            this.btnClearRndDateTimeScript.Click += new System.EventHandler(this.btnClearRndDateTimeScript_Click);
            // 
            // btnCopyRndDateTimeScript
            // 
            this.btnCopyRndDateTimeScript.Location = new System.Drawing.Point(11, 110);
            this.btnCopyRndDateTimeScript.Name = "btnCopyRndDateTimeScript";
            this.btnCopyRndDateTimeScript.Size = new System.Drawing.Size(75, 23);
            this.btnCopyRndDateTimeScript.TabIndex = 70;
            this.btnCopyRndDateTimeScript.Text = "挿入";
            this.btnCopyRndDateTimeScript.UseVisualStyleBackColor = true;
            this.btnCopyRndDateTimeScript.Click += new System.EventHandler(this.btnCopyRndDateTimeScript_Click);
            // 
            // tbxRndDateTimeScript
            // 
            this.tbxRndDateTimeScript.Location = new System.Drawing.Point(11, 85);
            this.tbxRndDateTimeScript.Name = "tbxRndDateTimeScript";
            this.tbxRndDateTimeScript.Size = new System.Drawing.Size(288, 19);
            this.tbxRndDateTimeScript.TabIndex = 69;
            // 
            // btnMakeRndDateTimeScript
            // 
            this.btnMakeRndDateTimeScript.Location = new System.Drawing.Point(11, 56);
            this.btnMakeRndDateTimeScript.Name = "btnMakeRndDateTimeScript";
            this.btnMakeRndDateTimeScript.Size = new System.Drawing.Size(75, 23);
            this.btnMakeRndDateTimeScript.TabIndex = 68;
            this.btnMakeRndDateTimeScript.Text = "作成";
            this.btnMakeRndDateTimeScript.UseVisualStyleBackColor = true;
            this.btnMakeRndDateTimeScript.Click += new System.EventHandler(this.btnMakeRndDateTimeScript_Click);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(9, 36);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(47, 12);
            this.label38.TabIndex = 65;
            this.label38.Text = "終了日：";
            // 
            // DatePicRndEndDateTime
            // 
            this.DatePicRndEndDateTime.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.DatePicRndEndDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePicRndEndDateTime.Location = new System.Drawing.Point(62, 31);
            this.DatePicRndEndDateTime.Name = "DatePicRndEndDateTime";
            this.DatePicRndEndDateTime.Size = new System.Drawing.Size(145, 19);
            this.DatePicRndEndDateTime.TabIndex = 66;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(9, 11);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(47, 12);
            this.label39.TabIndex = 63;
            this.label39.Text = "開始日：";
            // 
            // DatePicRndStartDateTime
            // 
            this.DatePicRndStartDateTime.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.DatePicRndStartDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePicRndStartDateTime.Location = new System.Drawing.Point(62, 6);
            this.DatePicRndStartDateTime.Name = "DatePicRndStartDateTime";
            this.DatePicRndStartDateTime.Size = new System.Drawing.Size(145, 19);
            this.DatePicRndStartDateTime.TabIndex = 65;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(6, 398);
            this.grid.Name = "grid";
            this.grid.RowTemplate.Height = 21;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(813, 142);
            this.grid.TabIndex = 80;
            this.grid.SelectionChanged += new System.EventHandler(this.grid_SelectionChanged);
            this.grid.Click += new System.EventHandler(this.grid_Click);
            // 
            // btnReadColumn
            // 
            this.btnReadColumn.Location = new System.Drawing.Point(644, 3);
            this.btnReadColumn.Name = "btnReadColumn";
            this.btnReadColumn.Size = new System.Drawing.Size(98, 23);
            this.btnReadColumn.TabIndex = 8;
            this.btnReadColumn.Text = "テーブル読み込み";
            this.btnReadColumn.UseVisualStyleBackColor = true;
            this.btnReadColumn.Click += new System.EventHandler(this.btnReadColumn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(368, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 12);
            this.label11.TabIndex = 19;
            this.label11.Text = "テーブル名：";
            // 
            // tbxTableName
            // 
            this.tbxTableName.Location = new System.Drawing.Point(435, 34);
            this.tbxTableName.Name = "tbxTableName";
            this.tbxTableName.Size = new System.Drawing.Size(150, 19);
            this.tbxTableName.TabIndex = 6;
            // 
            // cmbColumns
            // 
            this.cmbColumns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColumns.FormattingEnabled = true;
            this.cmbColumns.Location = new System.Drawing.Point(503, 18);
            this.cmbColumns.Name = "cmbColumns";
            this.cmbColumns.Size = new System.Drawing.Size(141, 20);
            this.cmbColumns.TabIndex = 74;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(463, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 12);
            this.label12.TabIndex = 22;
            this.label12.Text = "を　列";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(650, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 12);
            this.label13.TabIndex = 23;
            this.label13.Text = "に";
            // 
            // btnAddScript
            // 
            this.btnAddScript.Location = new System.Drawing.Point(670, 15);
            this.btnAddScript.Name = "btnAddScript";
            this.btnAddScript.Size = new System.Drawing.Size(58, 23);
            this.btnAddScript.TabIndex = 75;
            this.btnAddScript.Text = "追加";
            this.btnAddScript.UseVisualStyleBackColor = true;
            this.btnAddScript.Click += new System.EventHandler(this.btnAddScript_Click);
            // 
            // btnClearScript
            // 
            this.btnClearScript.Location = new System.Drawing.Point(750, 15);
            this.btnClearScript.Name = "btnClearScript";
            this.btnClearScript.Size = new System.Drawing.Size(58, 23);
            this.btnClearScript.TabIndex = 76;
            this.btnClearScript.Text = "クリア";
            this.btnClearScript.UseVisualStyleBackColor = true;
            this.btnClearScript.Click += new System.EventHandler(this.btnClearScript_Click);
            // 
            // btnTestInsert
            // 
            this.btnTestInsert.Location = new System.Drawing.Point(840, 3);
            this.btnTestInsert.Name = "btnTestInsert";
            this.btnTestInsert.Size = new System.Drawing.Size(119, 23);
            this.btnTestInsert.TabIndex = 11;
            this.btnTestInsert.Text = "Insert";
            this.btnTestInsert.UseVisualStyleBackColor = true;
            this.btnTestInsert.Click += new System.EventHandler(this.btnTestInsert_Click);
            // 
            // cmbKensu
            // 
            this.cmbKensu.FormattingEnabled = true;
            this.cmbKensu.Items.AddRange(new object[] {
            "10",
            "25",
            "50",
            "100",
            "500",
            "1000",
            "5000",
            "10000"});
            this.cmbKensu.Location = new System.Drawing.Point(644, 34);
            this.cmbKensu.Name = "cmbKensu";
            this.cmbKensu.Size = new System.Drawing.Size(98, 20);
            this.cmbKensu.TabIndex = 10;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(603, 37);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(35, 12);
            this.label25.TabIndex = 28;
            this.label25.Text = "件数：";
            // 
            // pnlSetting
            // 
            this.pnlSetting.Controls.Add(this.label43);
            this.pnlSetting.Controls.Add(this.cmbLogLevel);
            this.pnlSetting.Controls.Add(this.button2);
            this.pnlSetting.Controls.Add(this.tbx1);
            this.pnlSetting.Controls.Add(this.button1);
            this.pnlSetting.Controls.Add(this.label27);
            this.pnlSetting.Controls.Add(this.lblTotalNum);
            this.pnlSetting.Controls.Add(this.label26);
            this.pnlSetting.Controls.Add(this.lblInsertedNum);
            this.pnlSetting.Controls.Add(this.btnShowSaveDialog);
            this.pnlSetting.Controls.Add(this.btnReadColumn);
            this.pnlSetting.Controls.Add(this.label25);
            this.pnlSetting.Controls.Add(this.label1);
            this.pnlSetting.Controls.Add(this.cmbKensu);
            this.pnlSetting.Controls.Add(this.tbxServername);
            this.pnlSetting.Controls.Add(this.btnTestInsert);
            this.pnlSetting.Controls.Add(this.label2);
            this.pnlSetting.Controls.Add(this.tbxDbName);
            this.pnlSetting.Controls.Add(this.label3);
            this.pnlSetting.Controls.Add(this.tbxUserName);
            this.pnlSetting.Controls.Add(this.label4);
            this.pnlSetting.Controls.Add(this.tbxPassword);
            this.pnlSetting.Controls.Add(this.tbxTableName);
            this.pnlSetting.Controls.Add(this.label5);
            this.pnlSetting.Controls.Add(this.label11);
            this.pnlSetting.Controls.Add(this.tbxPortNo);
            this.pnlSetting.Controls.Add(this.btnTest1);
            this.pnlSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSetting.Location = new System.Drawing.Point(0, 0);
            this.pnlSetting.Name = "pnlSetting";
            this.pnlSetting.Size = new System.Drawing.Size(1012, 97);
            this.pnlSetting.TabIndex = 29;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(778, 65);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(52, 12);
            this.label43.TabIndex = 81;
            this.label43.Text = "LogLevel:";
            // 
            // cmbLogLevel
            // 
            this.cmbLogLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLogLevel.FormattingEnabled = true;
            this.cmbLogLevel.Items.AddRange(new object[] {
            "Off",
            "All",
            "Critical",
            "Error",
            "Warning",
            "Infomation",
            "Verbose"});
            this.cmbLogLevel.Location = new System.Drawing.Point(840, 62);
            this.cmbLogLevel.Name = "cmbLogLevel";
            this.cmbLogLevel.Size = new System.Drawing.Size(119, 20);
            this.cmbLogLevel.TabIndex = 81;
            this.cmbLogLevel.SelectedIndexChanged += new System.EventHandler(this.cmbLogLevel_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(307, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 81;
            this.button2.Text = "functest";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbx1
            // 
            this.tbx1.Location = new System.Drawing.Point(19, 59);
            this.tbx1.Name = "tbx1";
            this.tbx1.Size = new System.Drawing.Size(176, 19);
            this.tbx1.TabIndex = 82;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 81;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(918, 37);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(41, 12);
            this.label27.TabIndex = 33;
            this.label27.Text = "件終了";
            // 
            // lblTotalNum
            // 
            this.lblTotalNum.Location = new System.Drawing.Point(754, 35);
            this.lblTotalNum.Name = "lblTotalNum";
            this.lblTotalNum.Size = new System.Drawing.Size(66, 16);
            this.lblTotalNum.TabIndex = 32;
            this.lblTotalNum.Text = "0";
            this.lblTotalNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(820, 37);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(29, 12);
            this.label26.TabIndex = 31;
            this.label26.Text = "件中";
            // 
            // lblInsertedNum
            // 
            this.lblInsertedNum.Location = new System.Drawing.Point(845, 34);
            this.lblInsertedNum.Name = "lblInsertedNum";
            this.lblInsertedNum.Size = new System.Drawing.Size(75, 18);
            this.lblInsertedNum.TabIndex = 30;
            this.lblInsertedNum.Text = "0";
            this.lblInsertedNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnShowSaveDialog
            // 
            this.btnShowSaveDialog.Location = new System.Drawing.Point(748, 3);
            this.btnShowSaveDialog.Name = "btnShowSaveDialog";
            this.btnShowSaveDialog.Size = new System.Drawing.Size(86, 23);
            this.btnShowSaveDialog.TabIndex = 9;
            this.btnShowSaveDialog.Text = "保存/読込";
            this.btnShowSaveDialog.UseVisualStyleBackColor = true;
            this.btnShowSaveDialog.Click += new System.EventHandler(this.btnShowSaveDialog_Click);
            // 
            // pnlLine
            // 
            this.pnlLine.Controls.Add(this.btnSetNullRatio);
            this.pnlLine.Controls.Add(this.label42);
            this.pnlLine.Controls.Add(this.tbxNullRatio);
            this.pnlLine.Controls.Add(this.label41);
            this.pnlLine.Controls.Add(this.cmbNullColumns);
            this.pnlLine.Controls.Add(this.label40);
            this.pnlLine.Controls.Add(this.cmbColumns);
            this.pnlLine.Controls.Add(this.label6);
            this.pnlLine.Controls.Add(this.btnClearScript);
            this.pnlLine.Controls.Add(this.tbxScript1);
            this.pnlLine.Controls.Add(this.btnAddScript);
            this.pnlLine.Controls.Add(this.btnParse1);
            this.pnlLine.Controls.Add(this.label13);
            this.pnlLine.Controls.Add(this.label12);
            this.pnlLine.Location = new System.Drawing.Point(6, 306);
            this.pnlLine.Name = "pnlLine";
            this.pnlLine.Size = new System.Drawing.Size(817, 74);
            this.pnlLine.TabIndex = 30;
            // 
            // btnSetNullRatio
            // 
            this.btnSetNullRatio.Location = new System.Drawing.Point(361, 40);
            this.btnSetNullRatio.Name = "btnSetNullRatio";
            this.btnSetNullRatio.Size = new System.Drawing.Size(54, 23);
            this.btnSetNullRatio.TabIndex = 79;
            this.btnSetNullRatio.Text = "に設定";
            this.btnSetNullRatio.UseVisualStyleBackColor = true;
            this.btnSetNullRatio.Click += new System.EventHandler(this.btnSetNullRatio_Click);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(338, 45);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(17, 12);
            this.label42.TabIndex = 30;
            this.label42.Text = "％";
            // 
            // tbxNullRatio
            // 
            this.tbxNullRatio.Location = new System.Drawing.Point(267, 42);
            this.tbxNullRatio.Name = "tbxNullRatio";
            this.tbxNullRatio.Size = new System.Drawing.Size(65, 19);
            this.tbxNullRatio.TabIndex = 78;
            this.tbxNullRatio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNullRatio_KeyPress);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(181, 45);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(80, 12);
            this.label41.TabIndex = 28;
            this.label41.Text = "のNull挿入率を";
            // 
            // cmbNullColumns
            // 
            this.cmbNullColumns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNullColumns.FormattingEnabled = true;
            this.cmbNullColumns.Location = new System.Drawing.Point(34, 42);
            this.cmbNullColumns.Name = "cmbNullColumns";
            this.cmbNullColumns.Size = new System.Drawing.Size(141, 20);
            this.cmbNullColumns.TabIndex = 77;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(11, 45);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(17, 12);
            this.label40.TabIndex = 27;
            this.label40.Text = "列";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 554);
            this.Controls.Add(this.pnlLine);
            this.Controls.Add(this.pnlSetting);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.tabCtrlScripts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MyDummySQLPro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tabCtrlScripts.ResumeLayout(false);
            this.seqNumberPage.ResumeLayout(false);
            this.seqNumberPage.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ConstTabPage.ResumeLayout(false);
            this.ConstTabPage.PerformLayout();
            this.SeqMySQLTableColsTabPage.ResumeLayout(false);
            this.SeqMySQLTableColsTabPage.PerformLayout();
            this.RndMySQLTableColsTabPage.ResumeLayout(false);
            this.RndMySQLTableColsTabPage.PerformLayout();
            this.SeqAccessTableColsTabPage.ResumeLayout(false);
            this.SeqAccessTableColsTabPage.PerformLayout();
            this.RndAccessTableColsTabPage.ResumeLayout(false);
            this.RndAccessTableColsTabPage.PerformLayout();
            this.SeqDateTabPage.ResumeLayout(false);
            this.SeqDateTabPage.PerformLayout();
            this.RndDateTabPage.ResumeLayout(false);
            this.RndDateTabPage.PerformLayout();
            this.SeqDateTimeTabPage.ResumeLayout(false);
            this.SeqDateTimeTabPage.PerformLayout();
            this.RndDateTimeTabPage.ResumeLayout(false);
            this.RndDateTimeTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.pnlSetting.ResumeLayout(false);
            this.pnlSetting.PerformLayout();
            this.pnlLine.ResumeLayout(false);
            this.pnlLine.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbxServername;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbxDbName;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbxUserName;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tbxPortNo;
        private System.Windows.Forms.Button btnTest1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox tbxScript1;
        private System.Windows.Forms.Button btnParse1;
        private System.Windows.Forms.TabControl tabCtrlScripts;
        private System.Windows.Forms.TabPage seqNumberPage;
        public System.Windows.Forms.TextBox tbxSeqNumEndInt;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox tbxSeqNumStarInt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSeqNumMakeScript;
        private System.Windows.Forms.Button btnSeqNumCopyScript;
        public System.Windows.Forms.TextBox tbxSeqNumScript;
        private System.Windows.Forms.Button btnRndIntCopyScript;
        public System.Windows.Forms.TextBox tbxRndIntScript;
        private System.Windows.Forms.Button btnRndNumMakeScript;
        public System.Windows.Forms.TextBox tbxRndIntEndInt;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox tbxRndIntStartInt;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.DataGridView grid;
        public System.Windows.Forms.Button btnReadColumn;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox tbxTableName;
        public System.Windows.Forms.ComboBox cmbColumns;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnAddScript;
        private System.Windows.Forms.Button btnClearScript;
        private System.Windows.Forms.TabPage ConstTabPage;
        private System.Windows.Forms.Button btnConstStringCopyScript;
        public System.Windows.Forms.TextBox tbxConstStringScript;
        private System.Windows.Forms.Button btnMakeConstStringScript;
        public System.Windows.Forms.TextBox tbxConstString;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage SeqMySQLTableColsTabPage;
        public System.Windows.Forms.ComboBox cmbSeqMySQLColumns;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.ComboBox cmbSeqMySQLTables;
        private System.Windows.Forms.Button btnReadTable;
        private System.Windows.Forms.Button btnCopySeqMySQLColScript;
        public System.Windows.Forms.TextBox tbxSeqMySQLColScript;
        private System.Windows.Forms.Button btnMakeSeqMySQLColScript;
        private System.Windows.Forms.Button btnClearSeqMySQLColScript;
        private System.Windows.Forms.Button btnConstStringClearScript;
        private System.Windows.Forms.Button btnRndIntClearScript;
        private System.Windows.Forms.Button btnSeqNumClearScript;
        private System.Windows.Forms.TabPage RndMySQLTableColsTabPage;
        private System.Windows.Forms.Button btnClearRndMySQLTableScript;
        private System.Windows.Forms.Button btnCopyRndMySQLTableScript;
        public System.Windows.Forms.TextBox tbxRndMySQLTableColScript;
        private System.Windows.Forms.Button btnMakeRndMySQLTableScript;
        public System.Windows.Forms.ComboBox cmbRndMySQLTablesCol;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.ComboBox cmbRndMySQLTables;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabPage SeqAccessTableColsTabPage;
        private System.Windows.Forms.Button btnClearSeqAccessTableScript;
        private System.Windows.Forms.Button btnCopySeqAccessTableScript;
        public System.Windows.Forms.TextBox tbxSeqAccessTableScript;
        private System.Windows.Forms.Button btnMakeSeqAccessTableScript;
        private System.Windows.Forms.Label label20;
        public System.Windows.Forms.ComboBox cmbSeqAcTable;
        private System.Windows.Forms.Button btnReadSeqAccessTable;
        private System.Windows.Forms.TabPage RndAccessTableColsTabPage;
        private System.Windows.Forms.Button btnClearRndAccessTableColScript;
        private System.Windows.Forms.Button btnCopyRndAccessTableColScript;
        public System.Windows.Forms.TextBox tbxRndAcessTableColScript;
        private System.Windows.Forms.Button btnMakeRndAccessTableColScript;
        private System.Windows.Forms.Label label19;
        public System.Windows.Forms.ComboBox cmbRndAcTable;
        private System.Windows.Forms.Button btnReadRndAccessTable;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label21;
        public System.Windows.Forms.ListBox lstPreviewRndAccesTable;
        private System.Windows.Forms.Label label22;
        public System.Windows.Forms.ListBox lstPreviewSeqAccesTable;
        private System.Windows.Forms.Label label23;
        public System.Windows.Forms.ListBox lstPreviewRndMySQLTable;
        private System.Windows.Forms.Label label24;
        public System.Windows.Forms.ListBox lstPreviewSeqMySQLTable;
        private System.Windows.Forms.Button btnTestInsert;
        public System.Windows.Forms.ComboBox cmbKensu;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Panel pnlSetting;
        private System.Windows.Forms.Panel pnlLine;
        private System.Windows.Forms.Button btnShowSaveDialog;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lblTotalNum;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lblInsertedNum;
        private System.Windows.Forms.TabPage SeqDateTabPage;
        private System.Windows.Forms.Button btnClearSeqDateScript;
        private System.Windows.Forms.Button btnCopySeqDateScript;
        public System.Windows.Forms.TextBox tbxSeqDateScript;
        private System.Windows.Forms.Button btnMakeSeqDateScript;
        private System.Windows.Forms.Label label29;
        public System.Windows.Forms.DateTimePicker DatePicSeqEndDate;
        private System.Windows.Forms.Label label28;
        public System.Windows.Forms.DateTimePicker DatePicSeqStartDate;
        public System.Windows.Forms.ComboBox cmbSeqDateIncrementType;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TabPage RndDateTabPage;
        public System.Windows.Forms.ComboBox cmbRndDateIncrementType;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Button btnClearRndDateScript;
        private System.Windows.Forms.Button btnCopyRndDateScript;
        public System.Windows.Forms.TextBox tbxRndDateScript;
        private System.Windows.Forms.Button btnMakeRndDateScript;
        private System.Windows.Forms.Label label32;
        public System.Windows.Forms.DateTimePicker DatePicRndEndDate;
        private System.Windows.Forms.Label label33;
        public System.Windows.Forms.DateTimePicker DatePicRndStartDate;
        private System.Windows.Forms.TabPage SeqDateTimeTabPage;
        public System.Windows.Forms.ComboBox cmbSeqDateTimeIncrementType;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Button btnClearSeqDateTimeScript;
        private System.Windows.Forms.Button btnCopySeqDateTimeScript;
        public System.Windows.Forms.TextBox tbxSeqDateTmeScript;
        private System.Windows.Forms.Button btnMakeSeqDateTimeScript;
        private System.Windows.Forms.Label label35;
        public System.Windows.Forms.DateTimePicker DatePicSeqEndDateTime;
        private System.Windows.Forms.Label label36;
        public System.Windows.Forms.DateTimePicker DatePicSeqStartDateTime;
        public System.Windows.Forms.TabPage RndDateTimeTabPage;
        public System.Windows.Forms.ComboBox cmbRndDateTimeIncrementType;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Button btnClearRndDateTimeScript;
        private System.Windows.Forms.Button btnCopyRndDateTimeScript;
        public System.Windows.Forms.TextBox tbxRndDateTimeScript;
        private System.Windows.Forms.Button btnMakeRndDateTimeScript;
        private System.Windows.Forms.Label label38;
        public System.Windows.Forms.DateTimePicker DatePicRndEndDateTime;
        private System.Windows.Forms.Label label39;
        public System.Windows.Forms.DateTimePicker DatePicRndStartDateTime;
        private System.Windows.Forms.Label label41;
        public System.Windows.Forms.ComboBox cmbNullColumns;
        private System.Windows.Forms.Label label40;
        public System.Windows.Forms.Button btnSetNullRatio;
        private System.Windows.Forms.Label label42;
        public System.Windows.Forms.TextBox tbxNullRatio;
        private System.Windows.Forms.TextBox tbx1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbLogLevel;
        private System.Windows.Forms.Label label43;
    }
}

