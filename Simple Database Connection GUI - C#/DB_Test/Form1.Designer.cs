namespace DB_Test
{
    partial class Form1
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
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.ProductIDLabel = new System.Windows.Forms.Label();
            this.ItemNameLabel = new System.Windows.Forms.Label();
            this.DesignLabel = new System.Windows.Forms.Label();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.ProductIDButton = new System.Windows.Forms.TextBox();
            this.ItemNameButton = new System.Windows.Forms.TextBox();
            this.DesignButton = new System.Windows.Forms.TextBox();
            this.ColorButton = new System.Windows.Forms.TextBox();
            this.InsertButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.Location = new System.Drawing.Point(209, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(107, 29);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "DB Test";
            this.HeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductIDLabel
            // 
            this.ProductIDLabel.AutoSize = true;
            this.ProductIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIDLabel.Location = new System.Drawing.Point(48, 66);
            this.ProductIDLabel.Name = "ProductIDLabel";
            this.ProductIDLabel.Size = new System.Drawing.Size(95, 20);
            this.ProductIDLabel.TabIndex = 1;
            this.ProductIDLabel.Text = "Product ID";
            // 
            // ItemNameLabel
            // 
            this.ItemNameLabel.AutoSize = true;
            this.ItemNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemNameLabel.Location = new System.Drawing.Point(48, 111);
            this.ItemNameLabel.Name = "ItemNameLabel";
            this.ItemNameLabel.Size = new System.Drawing.Size(96, 20);
            this.ItemNameLabel.TabIndex = 2;
            this.ItemNameLabel.Text = "Item Name";
            // 
            // DesignLabel
            // 
            this.DesignLabel.AutoSize = true;
            this.DesignLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesignLabel.Location = new System.Drawing.Point(48, 153);
            this.DesignLabel.Name = "DesignLabel";
            this.DesignLabel.Size = new System.Drawing.Size(65, 20);
            this.DesignLabel.TabIndex = 3;
            this.DesignLabel.Text = "Design";
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorLabel.Location = new System.Drawing.Point(52, 195);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(51, 20);
            this.ColorLabel.TabIndex = 4;
            this.ColorLabel.Text = "Color";
            // 
            // ProductIDButton
            // 
            this.ProductIDButton.Location = new System.Drawing.Point(149, 66);
            this.ProductIDButton.Name = "ProductIDButton";
            this.ProductIDButton.Size = new System.Drawing.Size(299, 20);
            this.ProductIDButton.TabIndex = 5;
            // 
            // ItemNameButton
            // 
            this.ItemNameButton.Location = new System.Drawing.Point(149, 111);
            this.ItemNameButton.Name = "ItemNameButton";
            this.ItemNameButton.Size = new System.Drawing.Size(299, 20);
            this.ItemNameButton.TabIndex = 6;
            // 
            // DesignButton
            // 
            this.DesignButton.Location = new System.Drawing.Point(149, 153);
            this.DesignButton.Name = "DesignButton";
            this.DesignButton.Size = new System.Drawing.Size(299, 20);
            this.DesignButton.TabIndex = 7;
            // 
            // ColorButton
            // 
            this.ColorButton.Location = new System.Drawing.Point(149, 195);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(299, 20);
            this.ColorButton.TabIndex = 8;
            // 
            // InsertButton
            // 
            this.InsertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertButton.Location = new System.Drawing.Point(214, 236);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(109, 40);
            this.InsertButton.TabIndex = 9;
            this.InsertButton.Text = "Insert";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 311);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(525, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 473);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.ColorButton);
            this.Controls.Add(this.DesignButton);
            this.Controls.Add(this.ItemNameButton);
            this.Controls.Add(this.ProductIDButton);
            this.Controls.Add(this.ColorLabel);
            this.Controls.Add(this.DesignLabel);
            this.Controls.Add(this.ItemNameLabel);
            this.Controls.Add(this.ProductIDLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label ProductIDLabel;
        private System.Windows.Forms.Label ItemNameLabel;
        private System.Windows.Forms.Label DesignLabel;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.TextBox ProductIDButton;
        private System.Windows.Forms.TextBox ItemNameButton;
        private System.Windows.Forms.TextBox DesignButton;
        private System.Windows.Forms.TextBox ColorButton;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

