namespace online_library
{
    partial class Admin
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
            this.btn_Insert = new System.Windows.Forms.Button();
            this.dgv_Books = new System.Windows.Forms.DataGridView();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookDesdription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.onlinelibraryDataSet2 = new online_library.onlinelibraryDataSet2();
            this.onlinelibraryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.onlinelibraryDataSet = new online_library.onlinelibraryDataSet();
            this.lbl_User = new System.Windows.Forms.Label();
            this.bnt_Logout = new System.Windows.Forms.Button();
            this.booksTableAdapter = new online_library.onlinelibraryDataSet2TableAdapters.BooksTableAdapter();
            this.txt_BookID = new System.Windows.Forms.TextBox();
            this.txt_EventID = new System.Windows.Forms.TextBox();
            this.txt_BookDesdription = new System.Windows.Forms.TextBox();
            this.txt_Author = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_BookName = new System.Windows.Forms.TextBox();
            this.txt_AvailableQuantity = new System.Windows.Forms.TextBox();
            this.lbl_BookID = new System.Windows.Forms.Label();
            this.lbl_BookName = new System.Windows.Forms.Label();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.bnt_Update = new System.Windows.Forms.Button();
            this.bnt_Delete = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libraryEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowedBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readingListsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookReviewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.accountManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Books)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlinelibraryDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlinelibraryDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlinelibraryDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Insert
            // 
            this.btn_Insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Insert.Location = new System.Drawing.Point(689, 104);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(75, 23);
            this.btn_Insert.TabIndex = 0;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Insert.UseVisualStyleBackColor = false;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // dgv_Books
            // 
            this.dgv_Books.AutoGenerateColumns = false;
            this.dgv_Books.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Books.BackgroundColor = System.Drawing.Color.Fuchsia;
            this.dgv_Books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Books.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookID,
            this.BookName,
            this.Author,
            this.BookDesdription,
            this.AvailableQuantity,
            this.EventID});
            this.dgv_Books.DataSource = this.booksBindingSource;
            this.dgv_Books.Location = new System.Drawing.Point(0, 266);
            this.dgv_Books.Name = "dgv_Books";
            this.dgv_Books.RowHeadersWidth = 51;
            this.dgv_Books.RowTemplate.Height = 24;
            this.dgv_Books.Size = new System.Drawing.Size(860, 305);
            this.dgv_Books.TabIndex = 1;
            this.dgv_Books.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BookID
            // 
            this.BookID.DataPropertyName = "BookID";
            this.BookID.HeaderText = "BookID";
            this.BookID.MinimumWidth = 6;
            this.BookID.Name = "BookID";
            // 
            // BookName
            // 
            this.BookName.DataPropertyName = "BookName";
            this.BookName.HeaderText = "BookName";
            this.BookName.MinimumWidth = 6;
            this.BookName.Name = "BookName";
            // 
            // Author
            // 
            this.Author.DataPropertyName = "Author";
            this.Author.HeaderText = "Author";
            this.Author.MinimumWidth = 6;
            this.Author.Name = "Author";
            // 
            // BookDesdription
            // 
            this.BookDesdription.DataPropertyName = "BookDescription";
            this.BookDesdription.HeaderText = "BookDescription";
            this.BookDesdription.MinimumWidth = 6;
            this.BookDesdription.Name = "BookDesdription";
            // 
            // AvailableQuantity
            // 
            this.AvailableQuantity.DataPropertyName = "AvailableQuantity";
            this.AvailableQuantity.HeaderText = "AvailableQuantity";
            this.AvailableQuantity.MinimumWidth = 6;
            this.AvailableQuantity.Name = "AvailableQuantity";
            // 
            // EventID
            // 
            this.EventID.DataPropertyName = "EventID";
            this.EventID.HeaderText = "EventID";
            this.EventID.MinimumWidth = 6;
            this.EventID.Name = "EventID";
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.onlinelibraryDataSet2;
            // 
            // onlinelibraryDataSet2
            // 
            this.onlinelibraryDataSet2.DataSetName = "onlinelibraryDataSet2";
            this.onlinelibraryDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // onlinelibraryDataSetBindingSource
            // 
            this.onlinelibraryDataSetBindingSource.DataSource = this.onlinelibraryDataSet;
            this.onlinelibraryDataSetBindingSource.Position = 0;
            // 
            // onlinelibraryDataSet
            // 
            this.onlinelibraryDataSet.DataSetName = "onlinelibraryDataSet";
            this.onlinelibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_User
            // 
            this.lbl_User.Location = new System.Drawing.Point(758, 37);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(104, 32);
            this.lbl_User.TabIndex = 2;
            this.lbl_User.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_User.Click += new System.EventHandler(this.label1_Click);
            // 
            // bnt_Logout
            // 
            this.bnt_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bnt_Logout.Location = new System.Drawing.Point(689, 72);
            this.bnt_Logout.Name = "bnt_Logout";
            this.bnt_Logout.Size = new System.Drawing.Size(75, 23);
            this.bnt_Logout.TabIndex = 3;
            this.bnt_Logout.Text = "Logout";
            this.bnt_Logout.UseVisualStyleBackColor = false;
            this.bnt_Logout.Click += new System.EventHandler(this.bnt_Logout_Click);
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // txt_BookID
            // 
            this.txt_BookID.Location = new System.Drawing.Point(120, 38);
            this.txt_BookID.Name = "txt_BookID";
            this.txt_BookID.Size = new System.Drawing.Size(185, 22);
            this.txt_BookID.TabIndex = 4;
            // 
            // txt_EventID
            // 
            this.txt_EventID.Location = new System.Drawing.Point(470, 161);
            this.txt_EventID.Name = "txt_EventID";
            this.txt_EventID.Size = new System.Drawing.Size(185, 22);
            this.txt_EventID.TabIndex = 5;
            // 
            // txt_BookDesdription
            // 
            this.txt_BookDesdription.Location = new System.Drawing.Point(470, 38);
            this.txt_BookDesdription.Name = "txt_BookDesdription";
            this.txt_BookDesdription.Size = new System.Drawing.Size(185, 22);
            this.txt_BookDesdription.TabIndex = 6;
            // 
            // txt_Author
            // 
            this.txt_Author.Location = new System.Drawing.Point(120, 161);
            this.txt_Author.Name = "txt_Author";
            this.txt_Author.Size = new System.Drawing.Size(185, 22);
            this.txt_Author.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "BookID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "BookDescription";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "AvailableQuantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "BookName";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "EventID";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txt_BookName
            // 
            this.txt_BookName.Location = new System.Drawing.Point(120, 101);
            this.txt_BookName.Name = "txt_BookName";
            this.txt_BookName.Size = new System.Drawing.Size(185, 22);
            this.txt_BookName.TabIndex = 14;
            // 
            // txt_AvailableQuantity
            // 
            this.txt_AvailableQuantity.Location = new System.Drawing.Point(470, 101);
            this.txt_AvailableQuantity.Name = "txt_AvailableQuantity";
            this.txt_AvailableQuantity.Size = new System.Drawing.Size(185, 22);
            this.txt_AvailableQuantity.TabIndex = 15;
            // 
            // lbl_BookID
            // 
            this.lbl_BookID.AutoSize = true;
            this.lbl_BookID.Location = new System.Drawing.Point(117, 56);
            this.lbl_BookID.Name = "lbl_BookID";
            this.lbl_BookID.Size = new System.Drawing.Size(0, 16);
            this.lbl_BookID.TabIndex = 16;
            // 
            // lbl_BookName
            // 
            this.lbl_BookName.AutoSize = true;
            this.lbl_BookName.Location = new System.Drawing.Point(117, 126);
            this.lbl_BookName.Name = "lbl_BookName";
            this.lbl_BookName.Size = new System.Drawing.Size(0, 16);
            this.lbl_BookName.TabIndex = 17;
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Location = new System.Drawing.Point(120, 79);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(0, 16);
            this.lbl_Error.TabIndex = 18;
            // 
            // bnt_Update
            // 
            this.bnt_Update.BackColor = System.Drawing.Color.Fuchsia;
            this.bnt_Update.Location = new System.Drawing.Point(689, 138);
            this.bnt_Update.Name = "bnt_Update";
            this.bnt_Update.Size = new System.Drawing.Size(75, 32);
            this.bnt_Update.TabIndex = 19;
            this.bnt_Update.Text = "Update";
            this.bnt_Update.UseVisualStyleBackColor = false;
            this.bnt_Update.Click += new System.EventHandler(this.bnt_Update_Click);
            // 
            // bnt_Delete
            // 
            this.bnt_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bnt_Delete.Location = new System.Drawing.Point(689, 176);
            this.bnt_Delete.Name = "bnt_Delete";
            this.bnt_Delete.Size = new System.Drawing.Size(75, 27);
            this.bnt_Delete.TabIndex = 20;
            this.bnt_Delete.Text = "Delete";
            this.bnt_Delete.UseVisualStyleBackColor = false;
            this.bnt_Delete.Click += new System.EventHandler(this.bnt_Delete_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Purple;
            this.btn_search.Location = new System.Drawing.Point(595, 222);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 38);
            this.btn_search.TabIndex = 22;
            this.btn_search.Text = "search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(176, 230);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(413, 22);
            this.txt_search.TabIndex = 21;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Fuchsia;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(860, 28);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.libraryEventsToolStripMenuItem,
            this.borrowedBooksToolStripMenuItem,
            this.readingListsToolStripMenuItem,
            this.bookReviewsToolStripMenuItem,
            this.accountManagementToolStripMenuItem});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.systemToolStripMenuItem.Text = "system";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // libraryEventsToolStripMenuItem
            // 
            this.libraryEventsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.libraryEventsToolStripMenuItem.Name = "libraryEventsToolStripMenuItem";
            this.libraryEventsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.libraryEventsToolStripMenuItem.Text = "LibraryEvents";
            // 
            // borrowedBooksToolStripMenuItem
            // 
            this.borrowedBooksToolStripMenuItem.BackColor = System.Drawing.Color.Fuchsia;
            this.borrowedBooksToolStripMenuItem.Name = "borrowedBooksToolStripMenuItem";
            this.borrowedBooksToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.borrowedBooksToolStripMenuItem.Text = "BorrowedBooks";
            // 
            // readingListsToolStripMenuItem
            // 
            this.readingListsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.readingListsToolStripMenuItem.Name = "readingListsToolStripMenuItem";
            this.readingListsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.readingListsToolStripMenuItem.Text = "ReadingLists";
            // 
            // bookReviewsToolStripMenuItem
            // 
            this.bookReviewsToolStripMenuItem.BackColor = System.Drawing.Color.Purple;
            this.bookReviewsToolStripMenuItem.Name = "bookReviewsToolStripMenuItem";
            this.bookReviewsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bookReviewsToolStripMenuItem.Text = "BookReviews";
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.Fuchsia;
            this.btn_refresh.Location = new System.Drawing.Point(689, 221);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 39);
            this.btn_refresh.TabIndex = 24;
            this.btn_refresh.Text = "refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // accountManagementToolStripMenuItem
            // 
            this.accountManagementToolStripMenuItem.BackColor = System.Drawing.Color.Fuchsia;
            this.accountManagementToolStripMenuItem.Name = "accountManagementToolStripMenuItem";
            this.accountManagementToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.accountManagementToolStripMenuItem.Text = "Account management";
            this.accountManagementToolStripMenuItem.Click += new System.EventHandler(this.accountManagementToolStripMenuItem_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(860, 569);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.bnt_Delete);
            this.Controls.Add(this.bnt_Update);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.lbl_BookName);
            this.Controls.Add(this.lbl_BookID);
            this.Controls.Add(this.txt_AvailableQuantity);
            this.Controls.Add(this.txt_BookName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Author);
            this.Controls.Add(this.txt_BookDesdription);
            this.Controls.Add(this.txt_EventID);
            this.Controls.Add(this.txt_BookID);
            this.Controls.Add(this.bnt_Logout);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.dgv_Books);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Books)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlinelibraryDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlinelibraryDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlinelibraryDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.DataGridView dgv_Books;
        private System.Windows.Forms.BindingSource onlinelibraryDataSetBindingSource;
        private onlinelibraryDataSet onlinelibraryDataSet;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Button bnt_Logout;
        private onlinelibraryDataSet2 onlinelibraryDataSet2;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private onlinelibraryDataSet2TableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.TextBox txt_BookID;
        private System.Windows.Forms.TextBox txt_EventID;
        private System.Windows.Forms.TextBox txt_BookDesdription;
        private System.Windows.Forms.TextBox txt_Author;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_BookName;
        private System.Windows.Forms.TextBox txt_AvailableQuantity;
        private System.Windows.Forms.Label lbl_BookID;
        private System.Windows.Forms.Label lbl_BookName;
        private System.Windows.Forms.Label lbl_Error;
        private System.Windows.Forms.Button bnt_Update;
        private System.Windows.Forms.Button bnt_Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookDesdription;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailableQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventID;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem libraryEventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowedBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readingListsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookReviewsToolStripMenuItem;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.ToolStripMenuItem accountManagementToolStripMenuItem;
    }
}