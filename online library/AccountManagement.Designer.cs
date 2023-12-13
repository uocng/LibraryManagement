namespace online_library
{
    partial class AccountManagement
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
            this.components = new System.ComponentModel.Container();
            this.dgv_account = new System.Windows.Forms.DataGridView();
            this.accountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.onlinelibraryDataSet = new online_library.onlinelibraryDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_accountID = new System.Windows.Forms.TextBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_UserRole = new System.Windows.Forms.TextBox();
            this.txt_UserPassword = new System.Windows.Forms.TextBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.bnt_Logout = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.accountTableAdapter = new online_library.onlinelibraryDataSetTableAdapters.accountTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_account)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlinelibraryDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_account
            // 
            this.dgv_account.AutoGenerateColumns = false;
            this.dgv_account.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgv_account.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_account.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountID,
            this.UserName,
            this.UserPassword,
            this.UserRole});
            this.dgv_account.DataSource = this.accountBindingSource;
            this.dgv_account.Location = new System.Drawing.Point(1, 197);
            this.dgv_account.Name = "dgv_account";
            this.dgv_account.RowHeadersWidth = 51;
            this.dgv_account.RowTemplate.Height = 24;
            this.dgv_account.Size = new System.Drawing.Size(773, 253);
            this.dgv_account.TabIndex = 0;
            this.dgv_account.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_account_CellContentClick);
            // 
            // accountID
            // 
            this.accountID.DataPropertyName = "accountID";
            this.accountID.HeaderText = "accountID";
            this.accountID.MinimumWidth = 6;
            this.accountID.Name = "accountID";
            this.accountID.Width = 125;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "UserName";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.Width = 125;
            // 
            // UserPassword
            // 
            this.UserPassword.DataPropertyName = "UserPassword";
            this.UserPassword.HeaderText = "UserPassword";
            this.UserPassword.MinimumWidth = 6;
            this.UserPassword.Name = "UserPassword";
            this.UserPassword.Width = 125;
            // 
            // UserRole
            // 
            this.UserRole.DataPropertyName = "UserRole";
            this.UserRole.HeaderText = "UserRole";
            this.UserRole.MinimumWidth = 6;
            this.UserRole.Name = "UserRole";
            this.UserRole.Width = 125;
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataMember = "account";
            this.accountBindingSource.DataSource = this.onlinelibraryDataSet;
            // 
            // onlinelibraryDataSet
            // 
            this.onlinelibraryDataSet.DataSetName = "onlinelibraryDataSet";
            this.onlinelibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "accountID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "UserRole";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "UserName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "UserPassword";
            // 
            // txt_accountID
            // 
            this.txt_accountID.Location = new System.Drawing.Point(113, 38);
            this.txt_accountID.Name = "txt_accountID";
            this.txt_accountID.Size = new System.Drawing.Size(178, 22);
            this.txt_accountID.TabIndex = 5;
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(113, 101);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(178, 22);
            this.txt_UserName.TabIndex = 6;
            // 
            // txt_UserRole
            // 
            this.txt_UserRole.Location = new System.Drawing.Point(450, 98);
            this.txt_UserRole.Name = "txt_UserRole";
            this.txt_UserRole.Size = new System.Drawing.Size(178, 22);
            this.txt_UserRole.TabIndex = 7;
            // 
            // txt_UserPassword
            // 
            this.txt_UserPassword.Location = new System.Drawing.Point(450, 35);
            this.txt_UserPassword.Name = "txt_UserPassword";
            this.txt_UserPassword.Size = new System.Drawing.Size(178, 22);
            this.txt_UserPassword.TabIndex = 8;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Delete.Location = new System.Drawing.Point(666, 120);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 27);
            this.btn_Delete.TabIndex = 24;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Fuchsia;
            this.btn_Update.Location = new System.Drawing.Point(666, 82);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 32);
            this.btn_Update.TabIndex = 23;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // bnt_Logout
            // 
            this.bnt_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bnt_Logout.Location = new System.Drawing.Point(666, 16);
            this.bnt_Logout.Name = "bnt_Logout";
            this.bnt_Logout.Size = new System.Drawing.Size(75, 23);
            this.bnt_Logout.TabIndex = 22;
            this.bnt_Logout.Text = "Logout";
            this.bnt_Logout.UseVisualStyleBackColor = false;
            this.bnt_Logout.Click += new System.EventHandler(this.bnt_Logout_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Insert.Location = new System.Drawing.Point(666, 48);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(75, 23);
            this.btn_Insert.TabIndex = 21;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Insert.UseVisualStyleBackColor = false;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.Fuchsia;
            this.btn_refresh.Location = new System.Drawing.Point(544, 148);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 39);
            this.btn_refresh.TabIndex = 27;
            this.btn_refresh.Text = "refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Purple;
            this.btn_search.Location = new System.Drawing.Point(450, 149);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 38);
            this.btn_search.TabIndex = 26;
            this.btn_search.Text = "search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(31, 157);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(413, 22);
            this.txt_search.TabIndex = 25;
            // 
            // accountTableAdapter
            // 
            this.accountTableAdapter.ClearBeforeFill = true;
            // 
            // AccountManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(775, 450);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.bnt_Logout);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.txt_UserPassword);
            this.Controls.Add(this.txt_UserRole);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.txt_accountID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_account);
            this.Name = "AccountManagement";
            this.Text = "AccountManagement";
            this.Load += new System.EventHandler(this.AccountManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_account)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlinelibraryDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_account;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_accountID;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_UserRole;
        private System.Windows.Forms.TextBox txt_UserPassword;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button bnt_Logout;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private onlinelibraryDataSet onlinelibraryDataSet;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private onlinelibraryDataSetTableAdapters.accountTableAdapter accountTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserRole;
    }
}