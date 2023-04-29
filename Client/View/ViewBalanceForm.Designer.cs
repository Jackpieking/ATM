namespace Client.View
{
    partial class ViewBalanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBalanceForm));
            balanceOutput = new System.Windows.Forms.Label();
            backBtn = new System.Windows.Forms.Button();
            balanceFormHeader = new System.Windows.Forms.Label();
            atmLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)atmLogo).BeginInit();
            SuspendLayout();
            // 
            // balanceOutput
            // 
            balanceOutput.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            balanceOutput.BackColor = System.Drawing.Color.Coral;
            balanceOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            balanceOutput.Font = new System.Drawing.Font("Segoe UI", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            balanceOutput.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            balanceOutput.Location = new System.Drawing.Point(433, 340);
            balanceOutput.Name = "balanceOutput";
            balanceOutput.Size = new System.Drawing.Size(729, 248);
            balanceOutput.TabIndex = 8;
            balanceOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            balanceOutput.Click += balanceOutput_Click;
            // 
            // backBtn
            // 
            backBtn.BackColor = System.Drawing.Color.Green;
            backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            backBtn.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            backBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            backBtn.Location = new System.Drawing.Point(433, 708);
            backBtn.Name = "backBtn";
            backBtn.Size = new System.Drawing.Size(729, 126);
            backBtn.TabIndex = 10;
            backBtn.Text = "Quay lại";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // balanceFormHeader
            // 
            balanceFormHeader.AutoSize = true;
            balanceFormHeader.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            balanceFormHeader.Font = new System.Drawing.Font("Segoe UI", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            balanceFormHeader.ForeColor = System.Drawing.SystemColors.ControlText;
            balanceFormHeader.Location = new System.Drawing.Point(653, 189);
            balanceFormHeader.Name = "balanceFormHeader";
            balanceFormHeader.Size = new System.Drawing.Size(276, 100);
            balanceFormHeader.TabIndex = 11;
            balanceFormHeader.Text = "SỐ DƯ";
            // 
            // atmLogo
            // 
            atmLogo.BackgroundImage = (System.Drawing.Image)resources.GetObject("atmLogo.BackgroundImage");
            atmLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            atmLogo.Location = new System.Drawing.Point(12, 12);
            atmLogo.Name = "atmLogo";
            atmLogo.Size = new System.Drawing.Size(350, 250);
            atmLogo.TabIndex = 13;
            atmLogo.TabStop = false;
            // 
            // ViewBalanceForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1594, 1063);
            Controls.Add(atmLogo);
            Controls.Add(balanceFormHeader);
            Controls.Add(backBtn);
            Controls.Add(balanceOutput);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "ViewBalanceForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "ViewBalanceForm";
            Load += ViewBalanceForm_Load;
            ((System.ComponentModel.ISupportInitialize)atmLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label balanceOutput;
        private System.Windows.Forms.TextBox balanceResultBoxHeader;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label balanceFormHeader;
        private System.Windows.Forms.PictureBox atmLogo;
    }
}