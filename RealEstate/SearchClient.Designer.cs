namespace RealEstate
{
    partial class SearchClient
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
            this.searchResults = new System.Windows.Forms.ListBox();
            this.statusConstraint = new System.Windows.Forms.TextBox();
            this.bankAccConstraint = new System.Windows.Forms.TextBox();
            this.phoneConstraint = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.Label();
            this.bankAcc = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.lastNameConstraint = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nameConstraint = new System.Windows.Forms.TextBox();
            this.priceConstraint2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.priceConstraint2)).BeginInit();
            this.SuspendLayout();
            // 
            // searchResults
            // 
            this.searchResults.FormattingEnabled = true;
            this.searchResults.ItemHeight = 16;
            this.searchResults.Location = new System.Drawing.Point(102, 258);
            this.searchResults.Margin = new System.Windows.Forms.Padding(4);
            this.searchResults.Name = "searchResults";
            this.searchResults.Size = new System.Drawing.Size(607, 164);
            this.searchResults.TabIndex = 29;
            // 
            // statusConstraint
            // 
            this.statusConstraint.Location = new System.Drawing.Point(504, 119);
            this.statusConstraint.Margin = new System.Windows.Forms.Padding(4);
            this.statusConstraint.Name = "statusConstraint";
            this.statusConstraint.Size = new System.Drawing.Size(165, 22);
            this.statusConstraint.TabIndex = 59;
            // 
            // bankAccConstraint
            // 
            this.bankAccConstraint.Location = new System.Drawing.Point(315, 119);
            this.bankAccConstraint.Margin = new System.Windows.Forms.Padding(4);
            this.bankAccConstraint.Name = "bankAccConstraint";
            this.bankAccConstraint.Size = new System.Drawing.Size(165, 22);
            this.bankAccConstraint.TabIndex = 58;
            // 
            // phoneConstraint
            // 
            this.phoneConstraint.Location = new System.Drawing.Point(134, 119);
            this.phoneConstraint.Margin = new System.Windows.Forms.Padding(4);
            this.phoneConstraint.Name = "phoneConstraint";
            this.phoneConstraint.Size = new System.Drawing.Size(165, 22);
            this.phoneConstraint.TabIndex = 57;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(517, 86);
            this.status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(117, 17);
            this.status.TabIndex = 56;
            this.status.Text = "Search By Status";
            // 
            // bankAcc
            // 
            this.bankAcc.AutoSize = true;
            this.bankAcc.Location = new System.Drawing.Point(329, 86);
            this.bankAcc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bankAcc.Name = "bankAcc";
            this.bankAcc.Size = new System.Drawing.Size(140, 17);
            this.bankAcc.TabIndex = 55;
            this.bankAcc.Text = "Search By Bank_Acc";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(154, 86);
            this.phone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(118, 17);
            this.phone.TabIndex = 54;
            this.phone.Text = "Search By Phone";
            // 
            // lastNameConstraint
            // 
            this.lastNameConstraint.Location = new System.Drawing.Point(315, 38);
            this.lastNameConstraint.Margin = new System.Windows.Forms.Padding(4);
            this.lastNameConstraint.Name = "lastNameConstraint";
            this.lastNameConstraint.Size = new System.Drawing.Size(165, 22);
            this.lastNameConstraint.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 17);
            this.label6.TabIndex = 52;
            this.label6.Text = "Search By LastName";
            // 
            // nameConstraint
            // 
            this.nameConstraint.Location = new System.Drawing.Point(134, 38);
            this.nameConstraint.Margin = new System.Windows.Forms.Padding(4);
            this.nameConstraint.Name = "nameConstraint";
            this.nameConstraint.Size = new System.Drawing.Size(165, 22);
            this.nameConstraint.TabIndex = 51;
            // 
            // priceConstraint2
            // 
            this.priceConstraint2.DecimalPlaces = 2;
            this.priceConstraint2.Increment = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.priceConstraint2.Location = new System.Drawing.Point(502, 38);
            this.priceConstraint2.Margin = new System.Windows.Forms.Padding(4);
            this.priceConstraint2.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.priceConstraint2.Name = "priceConstraint2";
            this.priceConstraint2.Size = new System.Drawing.Size(167, 22);
            this.priceConstraint2.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(498, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 17);
            this.label4.TabIndex = 49;
            this.label4.Text = "Search By Max Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 48;
            this.label5.Text = "Search By Name";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(374, 175);
            this.search.Margin = new System.Windows.Forms.Padding(4);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(84, 54);
            this.search.TabIndex = 47;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // SearchClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusConstraint);
            this.Controls.Add(this.bankAccConstraint);
            this.Controls.Add(this.phoneConstraint);
            this.Controls.Add(this.status);
            this.Controls.Add(this.bankAcc);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.lastNameConstraint);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nameConstraint);
            this.Controls.Add(this.priceConstraint2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.search);
            this.Controls.Add(this.searchResults);
            this.Name = "SearchClient";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.SearchClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.priceConstraint2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox searchResults;
        private System.Windows.Forms.TextBox statusConstraint;
        private System.Windows.Forms.TextBox bankAccConstraint;
        private System.Windows.Forms.TextBox phoneConstraint;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label bankAcc;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.TextBox lastNameConstraint;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameConstraint;
        private System.Windows.Forms.NumericUpDown priceConstraint2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button search;
    }
}