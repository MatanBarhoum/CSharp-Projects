namespace LibraryManagementSystem.Manage
{
    partial class RemoveBookUI
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
            this.button1 = new System.Windows.Forms.Button();
            this.BookNameValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BookIDValue = new System.Windows.Forms.TextBox();
            this.BookIDLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(138, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 52);
            this.button1.TabIndex = 49;
            this.button1.Text = "Remove Book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BookNameValue
            // 
            this.BookNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.BookNameValue.Location = new System.Drawing.Point(174, 73);
            this.BookNameValue.Name = "BookNameValue";
            this.BookNameValue.Size = new System.Drawing.Size(284, 26);
            this.BookNameValue.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(19, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "Book Name";
            // 
            // BookIDValue
            // 
            this.BookIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.BookIDValue.Location = new System.Drawing.Point(174, 20);
            this.BookIDValue.Name = "BookIDValue";
            this.BookIDValue.Size = new System.Drawing.Size(284, 26);
            this.BookIDValue.TabIndex = 36;
            // 
            // BookIDLabel
            // 
            this.BookIDLabel.AutoSize = true;
            this.BookIDLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.BookIDLabel.Location = new System.Drawing.Point(19, 18);
            this.BookIDLabel.Name = "BookIDLabel";
            this.BookIDLabel.Size = new System.Drawing.Size(84, 25);
            this.BookIDLabel.TabIndex = 35;
            this.BookIDLabel.Text = "Book ID";
            // 
            // RemoveBookUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(525, 218);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BookNameValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BookIDValue);
            this.Controls.Add(this.BookIDLabel);
            this.Name = "RemoveBookUI";
            this.Text = "RemoveBookUI";
            this.Load += new System.EventHandler(this.RemoveBookUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox BookNameValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BookIDValue;
        private System.Windows.Forms.Label BookIDLabel;
    }
}