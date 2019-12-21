﻿namespace RealEstate
{
    partial class AddNewClient
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clientSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.TextBox();
            this.bankAccount = new System.Windows.Forms.TextBox();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.clientName = new System.Windows.Forms.TextBox();
            this.saveEntry = new System.Windows.Forms.Button();
            this.closeForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 122);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Bank Account";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "LastName";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Phone";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // clientSurname
            // 
            this.clientSurname.Location = new System.Drawing.Point(16, 94);
            this.clientSurname.Margin = new System.Windows.Forms.Padding(4);
            this.clientSurname.Name = "clientSurname";
            this.clientSurname.Size = new System.Drawing.Size(220, 22);
            this.clientSurname.TabIndex = 22;
            this.clientSurname.TextChanged += new System.EventHandler(this.clientSurname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Client Name";
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(249, 142);
            this.price.Margin = new System.Windows.Forms.Padding(4);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(220, 22);
            this.price.TabIndex = 20;
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(16, 142);
            this.status.Margin = new System.Windows.Forms.Padding(4);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(220, 22);
            this.status.TabIndex = 19;
            this.status.TextChanged += new System.EventHandler(this.status_TextChanged);
            // 
            // bankAccount
            // 
            this.bankAccount.Location = new System.Drawing.Point(249, 94);
            this.bankAccount.Margin = new System.Windows.Forms.Padding(4);
            this.bankAccount.Name = "bankAccount";
            this.bankAccount.Size = new System.Drawing.Size(220, 22);
            this.bankAccount.TabIndex = 18;
            this.bankAccount.TextChanged += new System.EventHandler(this.bankAccount_TextChanged);
            // 
            // phoneNumber
            // 
            this.phoneNumber.Location = new System.Drawing.Point(249, 46);
            this.phoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(220, 22);
            this.phoneNumber.TabIndex = 17;
            this.phoneNumber.TextChanged += new System.EventHandler(this.phoneNumber_TextChanged);
            // 
            // clientName
            // 
            this.clientName.Location = new System.Drawing.Point(16, 46);
            this.clientName.Margin = new System.Windows.Forms.Padding(4);
            this.clientName.Name = "clientName";
            this.clientName.Size = new System.Drawing.Size(220, 22);
            this.clientName.TabIndex = 16;
            this.clientName.TextChanged += new System.EventHandler(this.clientName_TextChanged);
            // 
            // saveEntry
            // 
            this.saveEntry.Location = new System.Drawing.Point(249, 174);
            this.saveEntry.Margin = new System.Windows.Forms.Padding(4);
            this.saveEntry.Name = "saveEntry";
            this.saveEntry.Size = new System.Drawing.Size(221, 28);
            this.saveEntry.TabIndex = 15;
            this.saveEntry.Text = "Save";
            this.saveEntry.UseVisualStyleBackColor = true;
            this.saveEntry.Click += new System.EventHandler(this.saveEntry_Click);
            // 
            // closeForm
            // 
            this.closeForm.Location = new System.Drawing.Point(16, 174);
            this.closeForm.Margin = new System.Windows.Forms.Padding(4);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(221, 28);
            this.closeForm.TabIndex = 14;
            this.closeForm.Text = "Close";
            this.closeForm.UseVisualStyleBackColor = true;
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click_1);
            // 
            // AddNewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 216);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clientSurname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.price);
            this.Controls.Add(this.status);
            this.Controls.Add(this.bankAccount);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.clientName);
            this.Controls.Add(this.saveEntry);
            this.Controls.Add(this.closeForm);
            this.Name = "AddNewClient";
            this.Text = "AddNewClient";
            this.Load += new System.EventHandler(this.AddNewClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox clientSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox bankAccount;
        private System.Windows.Forms.TextBox phoneNumber;
        private System.Windows.Forms.TextBox clientName;
        private System.Windows.Forms.Button saveEntry;
        private System.Windows.Forms.Button closeForm;
        private System.Windows.Forms.TextBox status;
    }
}