namespace PickList
{
    partial class fUPSShipExecCheck
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnResend = new System.Windows.Forms.Button();
            this.dtResult = new System.Windows.Forms.DataGridView();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.prgBanner.SuspendLayout();
            this.prgMain.SuspendLayout();
            this.prgFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtResult)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // prgBanner
            // 
            this.prgBanner.Size = new System.Drawing.Size(850, 56);
            // 
            // prgMain
            // 
            this.prgMain.Controls.Add(this.panel3);
            this.prgMain.Controls.Add(this.panel1);
            this.prgMain.Size = new System.Drawing.Size(850, 400);
            // 
            // prgTitle
            // 
            this.prgTitle.Size = new System.Drawing.Size(850, 56);
            // 
            // prgFooter
            // 
            this.prgFooter.Location = new System.Drawing.Point(0, 456);
            this.prgFooter.Size = new System.Drawing.Size(850, 52);
            // 
            // prgMSG
            // 
            this.prgMSG.Size = new System.Drawing.Size(850, 52);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(353, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(121, 42);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnResend
            // 
            this.btnResend.Location = new System.Drawing.Point(531, 40);
            this.btnResend.Name = "btnResend";
            this.btnResend.Size = new System.Drawing.Size(105, 42);
            this.btnResend.TabIndex = 2;
            this.btnResend.Text = "Resend";
            this.btnResend.UseVisualStyleBackColor = true;
            this.btnResend.Click += new System.EventHandler(this.btnResend_Click);
            // 
            // dtResult
            // 
            this.dtResult.AllowUserToAddRows = false;
            this.dtResult.AllowUserToDeleteRows = false;
            this.dtResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtResult.Location = new System.Drawing.Point(0, 0);
            this.dtResult.Name = "dtResult";
            this.dtResult.ReadOnly = true;
            this.dtResult.Size = new System.Drawing.Size(846, 280);
            this.dtResult.TabIndex = 3;
            this.dtResult.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtResult_CellFormatting);
            // 
            // txtBox
            // 
            this.txtBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBox.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBox.Location = new System.Drawing.Point(27, 56);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(238, 26);
            this.txtBox.TabIndex = 72;
            this.txtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(24, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 16);
            this.label2.TabIndex = 71;
            this.label2.Text = "CSN/CARTONNO/PICKPALLETNO:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnResend);
            this.panel1.Controls.Add(this.txtBox);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 103);
            this.panel1.TabIndex = 73;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtResult);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(2, 118);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(846, 280);
            this.panel3.TabIndex = 74;
            // 
            // fUPSShipExecCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 508);
            this.Name = "fUPSShipExecCheck";
            this.Text = "fUPSShipExecCheck";
            this.Shown += new System.EventHandler(this.fUPSShipExecCheck_Shown);
            this.prgBanner.ResumeLayout(false);
            this.prgMain.ResumeLayout(false);
            this.prgFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtResult)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnResend;
        private System.Windows.Forms.DataGridView dtResult;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
    }
}