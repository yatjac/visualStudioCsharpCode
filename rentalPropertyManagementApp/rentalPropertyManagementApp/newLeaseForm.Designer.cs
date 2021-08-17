namespace rentalPropertyManagementApp
{
    partial class newLeaseForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.leaseNumberTextBox = new System.Windows.Forms.TextBox();
            this.aptNumberTextBox = new System.Windows.Forms.TextBox();
            this.monthsTextBox = new System.Windows.Forms.TextBox();
            this.tenantIdTextBox = new System.Windows.Forms.TextBox();
            this.aptNameTextBox = new System.Windows.Forms.TextBox();
            this.monthlyRentTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lease Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apartment Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Months";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tenant ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(435, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Apartment Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(435, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Monthly Rent";
            // 
            // leaseNumberTextBox
            // 
            this.leaseNumberTextBox.Location = new System.Drawing.Point(183, 90);
            this.leaseNumberTextBox.Name = "leaseNumberTextBox";
            this.leaseNumberTextBox.Size = new System.Drawing.Size(100, 26);
            this.leaseNumberTextBox.TabIndex = 6;
            // 
            // aptNumberTextBox
            // 
            this.aptNumberTextBox.Location = new System.Drawing.Point(211, 167);
            this.aptNumberTextBox.Name = "aptNumberTextBox";
            this.aptNumberTextBox.Size = new System.Drawing.Size(100, 26);
            this.aptNumberTextBox.TabIndex = 7;
            // 
            // monthsTextBox
            // 
            this.monthsTextBox.Location = new System.Drawing.Point(135, 237);
            this.monthsTextBox.Name = "monthsTextBox";
            this.monthsTextBox.Size = new System.Drawing.Size(100, 26);
            this.monthsTextBox.TabIndex = 8;
            // 
            // tenantIdTextBox
            // 
            this.tenantIdTextBox.Location = new System.Drawing.Point(135, 308);
            this.tenantIdTextBox.Name = "tenantIdTextBox";
            this.tenantIdTextBox.Size = new System.Drawing.Size(100, 26);
            this.tenantIdTextBox.TabIndex = 9;
            // 
            // aptNameTextBox
            // 
            this.aptNameTextBox.Location = new System.Drawing.Point(588, 90);
            this.aptNameTextBox.Name = "aptNameTextBox";
            this.aptNameTextBox.Size = new System.Drawing.Size(100, 26);
            this.aptNameTextBox.TabIndex = 10;
            // 
            // monthlyRentTextBox
            // 
            this.monthlyRentTextBox.Location = new System.Drawing.Point(565, 167);
            this.monthlyRentTextBox.Name = "monthlyRentTextBox";
            this.monthlyRentTextBox.Size = new System.Drawing.Size(100, 26);
            this.monthlyRentTextBox.TabIndex = 11;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(117, 376);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(106, 38);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // newLeaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.monthlyRentTextBox);
            this.Controls.Add(this.aptNameTextBox);
            this.Controls.Add(this.tenantIdTextBox);
            this.Controls.Add(this.monthsTextBox);
            this.Controls.Add(this.aptNumberTextBox);
            this.Controls.Add(this.leaseNumberTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "newLeaseForm";
            this.Text = "newLeaseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox leaseNumberTextBox;
        private System.Windows.Forms.TextBox aptNumberTextBox;
        private System.Windows.Forms.TextBox monthsTextBox;
        private System.Windows.Forms.TextBox tenantIdTextBox;
        private System.Windows.Forms.TextBox aptNameTextBox;
        private System.Windows.Forms.TextBox monthlyRentTextBox;
        private System.Windows.Forms.Button saveButton;
    }
}