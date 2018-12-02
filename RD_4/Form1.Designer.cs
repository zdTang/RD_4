namespace RD_4
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
            this.Grid = new System.Windows.Forms.DataGridView();
            this.btnDisplayCustomer = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.btnResetCustomer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(46, 21);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.Size = new System.Drawing.Size(442, 136);
            this.Grid.TabIndex = 0;
            // 
            // btnDisplayCustomer
            // 
            this.btnDisplayCustomer.Location = new System.Drawing.Point(128, 177);
            this.btnDisplayCustomer.Name = "btnDisplayCustomer";
            this.btnDisplayCustomer.Size = new System.Drawing.Size(182, 23);
            this.btnDisplayCustomer.TabIndex = 1;
            this.btnDisplayCustomer.Text = "Display Customers";
            this.btnDisplayCustomer.UseVisualStyleBackColor = true;
            this.btnDisplayCustomer.Click += new System.EventHandler(this.btnDisplayCustomer_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(721, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(721, 22);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(721, 57);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(598, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(598, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(598, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telephone Number:";
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Location = new System.Drawing.Point(601, 156);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(94, 21);
            this.btnNewCustomer.TabIndex = 1;
            this.btnNewCustomer.Text = "Add customer";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnDisplayCustomer_Click);
            // 
            // btnResetCustomer
            // 
            this.btnResetCustomer.Location = new System.Drawing.Point(721, 156);
            this.btnResetCustomer.Name = "btnResetCustomer";
            this.btnResetCustomer.Size = new System.Drawing.Size(58, 21);
            this.btnResetCustomer.TabIndex = 1;
            this.btnResetCustomer.Text = "Reset";
            this.btnResetCustomer.UseVisualStyleBackColor = true;
            this.btnResetCustomer.Click += new System.EventHandler(this.btnDisplayCustomer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnResetCustomer);
            this.Controls.Add(this.btnNewCustomer);
            this.Controls.Add(this.btnDisplayCustomer);
            this.Controls.Add(this.Grid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Button btnDisplayCustomer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNewCustomer;
        private System.Windows.Forms.Button btnResetCustomer;
    }
}

