namespace PickList
{
    partial class fUPSResend
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
            this.txtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prgBanner.SuspendLayout();
            this.prgMain.SuspendLayout();
            this.prgFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // prgBanner
            // 
            this.prgBanner.Size = new System.Drawing.Size(478, 56);
            // 
            // prgMain
            // 
            this.prgMain.Controls.Add(this.txtBox);
            this.prgMain.Controls.Add(this.label1);
            this.prgMain.Size = new System.Drawing.Size(478, 198);
            // 
            // prgTitle
            // 
            this.prgTitle.Size = new System.Drawing.Size(478, 56);
            this.prgTitle.Text = "UPS ShipExec Resend";
            // 
            // prgFooter
            // 
            this.prgFooter.Location = new System.Drawing.Point(0, 254);
            this.prgFooter.Size = new System.Drawing.Size(478, 52);
            // 
            // prgMSG
            // 
            this.prgMSG.Size = new System.Drawing.Size(478, 52);
            // 
            // txtBox
            // 
            this.txtBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBox.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBox.Location = new System.Drawing.Point(110, 72);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(238, 26);
            this.txtBox.TabIndex = 70;
            this.txtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(107, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 16);
            this.label1.TabIndex = 69;
            this.label1.Text = "CSN/CARTONNO/PICKPALLETNO:";
            // 
            // fUPSResend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 306);
            this.Name = "fUPSResend";
            this.Text = "fUPSResend";
            this.prgBanner.ResumeLayout(false);
            this.prgMain.ResumeLayout(false);
            this.prgMain.PerformLayout();
            this.prgFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Label label1;
    }
}