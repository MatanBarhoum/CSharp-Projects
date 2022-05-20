namespace LibraryManagementSystem
{
    partial class WorkerDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkerDashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentedBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.availableBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biographiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horrorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kidsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mystriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scienceMathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sciFiFantasyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.romanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBookToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newRenterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newRentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remvoeRenterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeRenterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.booksBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.librarySystemDataSet = new LibraryManagementSystem.LibrarySystemDataSet();
            this.booksTableAdapter = new LibraryManagementSystem.LibrarySystemDataSetTableAdapters.BooksTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarySystemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.manageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(986, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem,
            this.byCategoryToolStripMenuItem,
            this.customersToolStripMenuItem});
            this.viewToolStripMenuItem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(50, 22);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rentedBooksToolStripMenuItem,
            this.availableBooksToolStripMenuItem});
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.booksToolStripMenuItem.Text = "Books";
            // 
            // rentedBooksToolStripMenuItem
            // 
            this.rentedBooksToolStripMenuItem.Name = "rentedBooksToolStripMenuItem";
            this.rentedBooksToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.rentedBooksToolStripMenuItem.Text = "Rented Books";
            this.rentedBooksToolStripMenuItem.Click += new System.EventHandler(this.rentedBooksToolStripMenuItem_Click);
            // 
            // availableBooksToolStripMenuItem
            // 
            this.availableBooksToolStripMenuItem.Name = "availableBooksToolStripMenuItem";
            this.availableBooksToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.availableBooksToolStripMenuItem.Text = "Available Books";
            this.availableBooksToolStripMenuItem.Click += new System.EventHandler(this.availableBooksToolStripMenuItem_Click);
            // 
            // byCategoryToolStripMenuItem
            // 
            this.byCategoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.biographiesToolStripMenuItem,
            this.comicsToolStripMenuItem,
            this.historyToolStripMenuItem,
            this.horrorToolStripMenuItem,
            this.kidsToolStripMenuItem,
            this.mystriesToolStripMenuItem,
            this.scienceMathToolStripMenuItem,
            this.sciFiFantasyToolStripMenuItem,
            this.romanceToolStripMenuItem});
            this.byCategoryToolStripMenuItem.Name = "byCategoryToolStripMenuItem";
            this.byCategoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.byCategoryToolStripMenuItem.Text = "By Category";
            // 
            // biographiesToolStripMenuItem
            // 
            this.biographiesToolStripMenuItem.Name = "biographiesToolStripMenuItem";
            this.biographiesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.biographiesToolStripMenuItem.Text = "Biographies";
            // 
            // comicsToolStripMenuItem
            // 
            this.comicsToolStripMenuItem.Name = "comicsToolStripMenuItem";
            this.comicsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.comicsToolStripMenuItem.Text = "Comics";
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.historyToolStripMenuItem.Text = "History";
            // 
            // horrorToolStripMenuItem
            // 
            this.horrorToolStripMenuItem.Name = "horrorToolStripMenuItem";
            this.horrorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.horrorToolStripMenuItem.Text = "Horror";
            // 
            // kidsToolStripMenuItem
            // 
            this.kidsToolStripMenuItem.Name = "kidsToolStripMenuItem";
            this.kidsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kidsToolStripMenuItem.Text = "Kids";
            // 
            // mystriesToolStripMenuItem
            // 
            this.mystriesToolStripMenuItem.Name = "mystriesToolStripMenuItem";
            this.mystriesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mystriesToolStripMenuItem.Text = "Mysteries";
            // 
            // scienceMathToolStripMenuItem
            // 
            this.scienceMathToolStripMenuItem.Name = "scienceMathToolStripMenuItem";
            this.scienceMathToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.scienceMathToolStripMenuItem.Text = "Science / Math";
            // 
            // sciFiFantasyToolStripMenuItem
            // 
            this.sciFiFantasyToolStripMenuItem.Name = "sciFiFantasyToolStripMenuItem";
            this.sciFiFantasyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sciFiFantasyToolStripMenuItem.Text = "Sci-Fi / Fanstay";
            // 
            // romanceToolStripMenuItem
            // 
            this.romanceToolStripMenuItem.Name = "romanceToolStripMenuItem";
            this.romanceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.romanceToolStripMenuItem.Text = "Romance";
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.customersToolStripMenuItem.Text = "Customers";
            this.customersToolStripMenuItem.Click += new System.EventHandler(this.customersToolStripMenuItem_Click);
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBookToolStripMenuItem,
            this.newRentToolStripMenuItem});
            this.manageToolStripMenuItem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(69, 22);
            this.manageToolStripMenuItem.Text = "Manage";
            // 
            // newBookToolStripMenuItem
            // 
            this.newBookToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBookToolStripMenuItem1,
            this.newRenterToolStripMenuItem,
            this.newUserToolStripMenuItem});
            this.newBookToolStripMenuItem.Name = "newBookToolStripMenuItem";
            this.newBookToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newBookToolStripMenuItem.Text = "New";
            // 
            // newBookToolStripMenuItem1
            // 
            this.newBookToolStripMenuItem1.Name = "newBookToolStripMenuItem1";
            this.newBookToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.newBookToolStripMenuItem1.Text = "New Book";
            this.newBookToolStripMenuItem1.Click += new System.EventHandler(this.newBookToolStripMenuItem1_Click);
            // 
            // newRenterToolStripMenuItem
            // 
            this.newRenterToolStripMenuItem.Name = "newRenterToolStripMenuItem";
            this.newRenterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newRenterToolStripMenuItem.Text = "New Book Rent";
            this.newRenterToolStripMenuItem.Click += new System.EventHandler(this.newRenterToolStripMenuItem_Click);
            // 
            // newUserToolStripMenuItem
            // 
            this.newUserToolStripMenuItem.Name = "newUserToolStripMenuItem";
            this.newUserToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newUserToolStripMenuItem.Text = "New User";
            // 
            // newRentToolStripMenuItem
            // 
            this.newRentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.remvoeRenterToolStripMenuItem,
            this.removeRenterToolStripMenuItem1});
            this.newRentToolStripMenuItem.Name = "newRentToolStripMenuItem";
            this.newRentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newRentToolStripMenuItem.Text = "Remove";
            // 
            // remvoeRenterToolStripMenuItem
            // 
            this.remvoeRenterToolStripMenuItem.Name = "remvoeRenterToolStripMenuItem";
            this.remvoeRenterToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.remvoeRenterToolStripMenuItem.Text = "Remove Book";
            this.remvoeRenterToolStripMenuItem.Click += new System.EventHandler(this.remvoeRenterToolStripMenuItem_Click);
            // 
            // removeRenterToolStripMenuItem1
            // 
            this.removeRenterToolStripMenuItem1.Name = "removeRenterToolStripMenuItem1";
            this.removeRenterToolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.removeRenterToolStripMenuItem1.Text = "Remove Book Rent";
            this.removeRenterToolStripMenuItem1.Click += new System.EventHandler(this.removeRenterToolStripMenuItem1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox1.Location = new System.Drawing.Point(410, 44);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(477, 35);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Search Book Name";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(891, 44);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 35);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 79);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(257, 38);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 53);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "17/05/2022 10:19:53";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.quantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.booksBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(11, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(963, 372);
            this.dataGridView1.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.Location = new System.Drawing.Point(862, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 22);
            this.button2.TabIndex = 16;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // booksBindingSource2
            // 
            this.booksBindingSource2.DataMember = "Books";
            this.booksBindingSource2.DataSource = this.librarySystemDataSet;
            // 
            // librarySystemDataSet
            // 
            this.librarySystemDataSet.DataSetName = "LibrarySystemDataSet";
            this.librarySystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Book ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Book ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Book Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Book Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Available";
            this.dataGridViewTextBoxColumn3.HeaderText = "Available";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // WorkerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(986, 533);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WorkerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library System Management - By Matan Barhoum";
            this.Load += new System.EventHandler(this.WorkerDashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarySystemDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentedBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem availableBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newRentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newBookToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newRenterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remvoeRenterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeRenterToolStripMenuItem1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private System.Windows.Forms.ToolStripMenuItem newUserToolStripMenuItem;
        private System.Windows.Forms.BindingSource booksBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LibrarySystemDataSet librarySystemDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource2;
        private LibrarySystemDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem byCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biographiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comicsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horrorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kidsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mystriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scienceMathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sciFiFantasyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem romanceToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}