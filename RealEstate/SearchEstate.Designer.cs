namespace RealEstate
{
    partial class SearchEstate
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
            this.DateC = new System.Windows.Forms.TextBox();
            this.addressC = new System.Windows.Forms.TextBox();
            this.typeConstraint = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.priceConstraint = new System.Windows.Forms.NumericUpDown();
            this.areaConstraint = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.regionConstraint = new System.Windows.Forms.TextBox();
            this.searchResults = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.priceConstraint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaConstraint)).BeginInit();
            this.SuspendLayout();
            // 
            // DateC
            // 
            this.DateC.Location = new System.Drawing.Point(462, 112);
            this.DateC.Margin = new System.Windows.Forms.Padding(4);
            this.DateC.Name = "DateC";
            this.DateC.Size = new System.Drawing.Size(118, 22);
            this.DateC.TabIndex = 53;
            // 
            // addressC
            // 
            this.addressC.Location = new System.Drawing.Point(333, 112);
            this.addressC.Margin = new System.Windows.Forms.Padding(4);
            this.addressC.Name = "addressC";
            this.addressC.Size = new System.Drawing.Size(118, 22);
            this.addressC.TabIndex = 52;
            // 
            // typeConstraint
            // 
            this.typeConstraint.Location = new System.Drawing.Point(201, 112);
            this.typeConstraint.Margin = new System.Windows.Forms.Padding(4);
            this.typeConstraint.Name = "typeConstraint";
            this.typeConstraint.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.typeConstraint.Size = new System.Drawing.Size(118, 22);
            this.typeConstraint.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(459, 91);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 17);
            this.label9.TabIndex = 50;
            this.label9.Text = "Search By ConstrDate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(322, 91);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 17);
            this.label8.TabIndex = 49;
            this.label8.Text = "Search By Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(198, 91);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 17);
            this.label7.TabIndex = 48;
            this.label7.Text = "Search By Type";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(345, 142);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 54);
            this.button3.TabIndex = 47;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // priceConstraint
            // 
            this.priceConstraint.DecimalPlaces = 2;
            this.priceConstraint.Increment = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.priceConstraint.Location = new System.Drawing.Point(473, 45);
            this.priceConstraint.Margin = new System.Windows.Forms.Padding(4);
            this.priceConstraint.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.priceConstraint.Name = "priceConstraint";
            this.priceConstraint.Size = new System.Drawing.Size(107, 22);
            this.priceConstraint.TabIndex = 46;
            // 
            // areaConstraint
            // 
            this.areaConstraint.DecimalPlaces = 2;
            this.areaConstraint.Increment = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.areaConstraint.Location = new System.Drawing.Point(333, 45);
            this.areaConstraint.Margin = new System.Windows.Forms.Padding(4);
            this.areaConstraint.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.areaConstraint.Name = "areaConstraint";
            this.areaConstraint.Size = new System.Drawing.Size(116, 22);
            this.areaConstraint.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 17);
            this.label3.TabIndex = 44;
            this.label3.Text = "Search By Max Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 43;
            this.label2.Text = "Search By Area";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "Search By Region";
            // 
            // regionConstraint
            // 
            this.regionConstraint.Location = new System.Drawing.Point(201, 45);
            this.regionConstraint.Margin = new System.Windows.Forms.Padding(4);
            this.regionConstraint.Name = "regionConstraint";
            this.regionConstraint.Size = new System.Drawing.Size(118, 22);
            this.regionConstraint.TabIndex = 41;
            // 
            // searchResults
            // 
            this.searchResults.FormattingEnabled = true;
            this.searchResults.ItemHeight = 16;
            this.searchResults.Location = new System.Drawing.Point(91, 234);
            this.searchResults.Margin = new System.Windows.Forms.Padding(4);
            this.searchResults.Name = "searchResults";
            this.searchResults.Size = new System.Drawing.Size(607, 164);
            this.searchResults.TabIndex = 54;
            // 
            // SearchEstate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchResults);
            this.Controls.Add(this.DateC);
            this.Controls.Add(this.addressC);
            this.Controls.Add(this.typeConstraint);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.priceConstraint);
            this.Controls.Add(this.areaConstraint);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.regionConstraint);
            this.Name = "SearchEstate";
            this.Text = "SearchEstate";
            this.Load += new System.EventHandler(this.SearchEstate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.priceConstraint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaConstraint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DateC;
        private System.Windows.Forms.TextBox addressC;
        private System.Windows.Forms.TextBox typeConstraint;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown priceConstraint;
        private System.Windows.Forms.NumericUpDown areaConstraint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox regionConstraint;
        private System.Windows.Forms.ListBox searchResults;
    }
}