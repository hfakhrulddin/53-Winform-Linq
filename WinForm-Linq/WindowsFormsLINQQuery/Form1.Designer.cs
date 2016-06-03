namespace WindowsFormsLINQQuery
{
    partial class frmLINQQuery
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
            this.lstResults = new System.Windows.Forms.ListBox();
            this.cmbFireQuery = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstResults
            // 
            this.lstResults.FormattingEnabled = true;
            this.lstResults.ItemHeight = 25;
            this.lstResults.Location = new System.Drawing.Point(24, 106);
            this.lstResults.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(454, 704);
            this.lstResults.TabIndex = 2;
            // 
            // cmbFireQuery
            // 
            this.cmbFireQuery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbFireQuery.FormattingEnabled = true;
            this.cmbFireQuery.Items.AddRange(new object[] {
            "Simple Query",
            "Query With Where clause",
            "Join  Query",
            "Group By",
            "Order By"});
            this.cmbFireQuery.Location = new System.Drawing.Point(492, 23);
            this.cmbFireQuery.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbFireQuery.Name = "cmbFireQuery";
            this.cmbFireQuery.Size = new System.Drawing.Size(302, 285);
            this.cmbFireQuery.TabIndex = 3;
            this.cmbFireQuery.SelectedIndexChanged += new System.EventHandler(this.cmbFireQuery_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Customer Code No.";
            // 
            // txtCustomerCode
            // 
            this.txtCustomerCode.Location = new System.Drawing.Point(250, 23);
            this.txtCustomerCode.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCustomerCode.Name = "txtCustomerCode";
            this.txtCustomerCode.Size = new System.Drawing.Size(196, 31);
            this.txtCustomerCode.TabIndex = 5;
            // 
            // frmLINQQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 837);
            this.Controls.Add(this.txtCustomerCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFireQuery);
            this.Controls.Add(this.lstResults);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmLINQQuery";
            this.Text = "Let\'s Learn LINQ Query";
            this.Load += new System.EventHandler(this.frmLINQQuery_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.ComboBox cmbFireQuery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerCode;
    }
}

