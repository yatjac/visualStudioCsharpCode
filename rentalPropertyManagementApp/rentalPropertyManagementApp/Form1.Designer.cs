namespace rentalPropertyManagementApp
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
            this.addButton = new System.Windows.Forms.Button();
            this.cbxTenantId = new System.Windows.Forms.ComboBox();
            this.dgvAptLeases = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAptLeases)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(57, 526);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(116, 59);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cbxTenantId
            // 
            this.cbxTenantId.FormattingEnabled = true;
            this.cbxTenantId.Items.AddRange(new object[] {
            "jpl77",
            "sl20"});
            this.cbxTenantId.Location = new System.Drawing.Point(897, 92);
            this.cbxTenantId.Name = "cbxTenantId";
            this.cbxTenantId.Size = new System.Drawing.Size(121, 28);
            this.cbxTenantId.TabIndex = 1;
            this.cbxTenantId.SelectedIndexChanged += new System.EventHandler(this.cbxTenantId_SelectedIndexChanged);
            // 
            // dgvAptLeases
            // 
            this.dgvAptLeases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAptLeases.Location = new System.Drawing.Point(24, 92);
            this.dgvAptLeases.Name = "dgvAptLeases";
            this.dgvAptLeases.RowTemplate.Height = 28;
            this.dgvAptLeases.Size = new System.Drawing.Size(780, 373);
            this.dgvAptLeases.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "net id: jpl77";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(893, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tenant ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 620);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAptLeases);
            this.Controls.Add(this.cbxTenantId);
            this.Controls.Add(this.addButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAptLeases)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox cbxTenantId;
        private System.Windows.Forms.DataGridView dgvAptLeases;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

