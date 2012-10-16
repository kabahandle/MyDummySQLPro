namespace MyDummySQL
{
    partial class frmSaveDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbSaveName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddTablename = new System.Windows.Forms.Button();
            this.btnAddDBname = new System.Windows.Forms.Button();
            this.btnAddDBAndTableName = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbSaveName
            // 
            this.cmbSaveName.FormattingEnabled = true;
            this.cmbSaveName.Location = new System.Drawing.Point(65, 21);
            this.cmbSaveName.Name = "cmbSaveName";
            this.cmbSaveName.Size = new System.Drawing.Size(397, 20);
            this.cmbSaveName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "保存名：";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(557, 18);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddTablename
            // 
            this.btnAddTablename.Location = new System.Drawing.Point(95, 57);
            this.btnAddTablename.Name = "btnAddTablename";
            this.btnAddTablename.Size = new System.Drawing.Size(114, 23);
            this.btnAddTablename.TabIndex = 3;
            this.btnAddTablename.Text = "テーブル名を挿入";
            this.btnAddTablename.UseVisualStyleBackColor = true;
            this.btnAddTablename.Click += new System.EventHandler(this.btnAddTablename_Click);
            // 
            // btnAddDBname
            // 
            this.btnAddDBname.Location = new System.Drawing.Point(14, 57);
            this.btnAddDBname.Name = "btnAddDBname";
            this.btnAddDBname.Size = new System.Drawing.Size(75, 23);
            this.btnAddDBname.TabIndex = 4;
            this.btnAddDBname.Text = "DB名を挿入";
            this.btnAddDBname.UseVisualStyleBackColor = true;
            this.btnAddDBname.Click += new System.EventHandler(this.btnAddDBname_Click);
            // 
            // btnAddDBAndTableName
            // 
            this.btnAddDBAndTableName.Location = new System.Drawing.Point(215, 57);
            this.btnAddDBAndTableName.Name = "btnAddDBAndTableName";
            this.btnAddDBAndTableName.Size = new System.Drawing.Size(152, 23);
            this.btnAddDBAndTableName.TabIndex = 5;
            this.btnAddDBAndTableName.Text = "DB名とテーブル名を挿入";
            this.btnAddDBAndTableName.UseVisualStyleBackColor = true;
            this.btnAddDBAndTableName.Click += new System.EventHandler(this.btnAddDBAndTableName_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(557, 57);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(468, 18);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "読み込み";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(468, 57);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "削除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmSaveDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 109);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddDBAndTableName);
            this.Controls.Add(this.btnAddDBname);
            this.Controls.Add(this.btnAddTablename);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSaveName);
            this.Name = "frmSaveDialog";
            this.Text = "保存";
            this.Load += new System.EventHandler(this.frmSaveDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSaveName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddTablename;
        private System.Windows.Forms.Button btnAddDBname;
        private System.Windows.Forms.Button btnAddDBAndTableName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnDelete;
    }
}