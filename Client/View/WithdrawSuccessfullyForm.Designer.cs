namespace Client.View
{
    partial class WithdrawSuccessfullyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WithdrawSuccessfullyForm));
            withdrawFormHeader = new System.Windows.Forms.Label();
            atmLogo = new System.Windows.Forms.PictureBox();
            logOutBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)atmLogo).BeginInit();
            SuspendLayout();
            // 
            // withdrawFormHeader
            // 
            withdrawFormHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            withdrawFormHeader.BackColor = System.Drawing.Color.Coral;
            withdrawFormHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            withdrawFormHeader.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            withdrawFormHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            withdrawFormHeader.Location = new System.Drawing.Point(338, 308);
            withdrawFormHeader.Name = "withdrawFormHeader";
            withdrawFormHeader.Size = new System.Drawing.Size(919, 186);
            withdrawFormHeader.TabIndex = 16;
            withdrawFormHeader.Text = "Giao dịch thành công\r\nXin cảm ơn\r\n";
            withdrawFormHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // atmLogo
            // 
            atmLogo.BackgroundImage = (System.Drawing.Image)resources.GetObject("atmLogo.BackgroundImage");
            atmLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            atmLogo.Location = new System.Drawing.Point(12, 12);
            atmLogo.Name = "atmLogo";
            atmLogo.Size = new System.Drawing.Size(350, 250);
            atmLogo.TabIndex = 17;
            atmLogo.TabStop = false;
            // 
            // logOutBtn
            // 
            logOutBtn.BackColor = System.Drawing.Color.Green;
            logOutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            logOutBtn.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            logOutBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            logOutBtn.Location = new System.Drawing.Point(338, 610);
            logOutBtn.Name = "logOutBtn";
            logOutBtn.Size = new System.Drawing.Size(919, 126);
            logOutBtn.TabIndex = 18;
            logOutBtn.Text = "Kết thúc";
            logOutBtn.UseVisualStyleBackColor = false;
            logOutBtn.Click += logOutBtn_Click;
            // 
            // WithdrawSuccessfullyForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1594, 1063);
            Controls.Add(logOutBtn);
            Controls.Add(atmLogo);
            Controls.Add(withdrawFormHeader);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Name = "WithdrawSuccessfullyForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Withdraw Successfully";
            ((System.ComponentModel.ISupportInitialize)atmLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label withdrawFormHeader;
        private System.Windows.Forms.PictureBox atmLogo;
        private System.Windows.Forms.Button logOutBtn;
    }
}