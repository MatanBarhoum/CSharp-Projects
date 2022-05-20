namespace LibraryManagementSystem.Manage
{
    partial class RemoveBookRentUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveBookRentUI));
            this.button1 = new System.Windows.Forms.Button();
            this.UserHasvalue = new System.Windows.Forms.TextBox();
            this.BooknameValue = new System.Windows.Forms.TextBox();
            this.BookIDValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchBookButton = new System.Windows.Forms.Button();
            this.SearchUserButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SearchBookValue = new System.Windows.Forms.TextBox();
            this.SearchUserValue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(195, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 52);
            this.button1.TabIndex = 47;
            this.button1.Text = "Remove Book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserHasvalue
            // 
            this.UserHasvalue.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.UserHasvalue.Location = new System.Drawing.Point(328, 317);
            this.UserHasvalue.Name = "UserHasvalue";
            this.UserHasvalue.Size = new System.Drawing.Size(259, 31);
            this.UserHasvalue.TabIndex = 46;
            // 
            // BooknameValue
            // 
            this.BooknameValue.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.BooknameValue.Location = new System.Drawing.Point(252, 236);
            this.BooknameValue.Name = "BooknameValue";
            this.BooknameValue.Size = new System.Drawing.Size(374, 31);
            this.BooknameValue.TabIndex = 45;
            // 
            // BookIDValue
            // 
            this.BookIDValue.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.BookIDValue.Location = new System.Drawing.Point(195, 151);
            this.BookIDValue.Name = "BookIDValue";
            this.BookIDValue.Size = new System.Drawing.Size(127, 31);
            this.BookIDValue.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(30, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 37);
            this.label3.TabIndex = 43;
            this.label3.Text = "Borrower Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(30, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 37);
            this.label2.TabIndex = 42;
            this.label2.Text = "Book Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(30, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 37);
            this.label1.TabIndex = 41;
            this.label1.Text = "Book ID";
            // 
            // SearchBookButton
            // 
            this.SearchBookButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SearchBookButton.Location = new System.Drawing.Point(527, 57);
            this.SearchBookButton.Name = "SearchBookButton";
            this.SearchBookButton.Size = new System.Drawing.Size(116, 26);
            this.SearchBookButton.TabIndex = 40;
            this.SearchBookButton.Text = "Search Book";
            this.SearchBookButton.UseVisualStyleBackColor = true;
            this.SearchBookButton.Click += new System.EventHandler(this.SearchBookButton_Click);
            // 
            // SearchUserButton
            // 
            this.SearchUserButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SearchUserButton.Location = new System.Drawing.Point(527, 11);
            this.SearchUserButton.Name = "SearchUserButton";
            this.SearchUserButton.Size = new System.Drawing.Size(116, 26);
            this.SearchUserButton.TabIndex = 39;
            this.SearchUserButton.Text = "Search User";
            this.SearchUserButton.UseVisualStyleBackColor = true;
            this.SearchUserButton.Click += new System.EventHandler(this.SearchUserButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // SearchBookValue
            // 
            this.SearchBookValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SearchBookValue.Location = new System.Drawing.Point(297, 60);
            this.SearchBookValue.Name = "SearchBookValue";
            this.SearchBookValue.Size = new System.Drawing.Size(224, 23);
            this.SearchBookValue.TabIndex = 37;
            // 
            // SearchUserValue
            // 
            this.SearchUserValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SearchUserValue.Location = new System.Drawing.Point(297, 14);
            this.SearchUserValue.Name = "SearchUserValue";
            this.SearchUserValue.Size = new System.Drawing.Size(224, 23);
            this.SearchUserValue.TabIndex = 36;
            // 
            // RemoveBookRentUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(671, 457);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UserHasvalue);
            this.Controls.Add(this.BooknameValue);
            this.Controls.Add(this.BookIDValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchBookButton);
            this.Controls.Add(this.SearchUserButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SearchBookValue);
            this.Controls.Add(this.SearchUserValue);
            this.Name = "RemoveBookRentUI";
            this.Text = "RemoveBookRentUI";
            this.Load += new System.EventHandler(this.RemoveBookRentUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox UserHasvalue;
        private System.Windows.Forms.TextBox BooknameValue;
        private System.Windows.Forms.TextBox BookIDValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchBookButton;
        private System.Windows.Forms.Button SearchUserButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox SearchBookValue;
        private System.Windows.Forms.TextBox SearchUserValue;
    }
}