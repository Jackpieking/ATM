namespace Client.View
{
    partial class UserMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMenuForm));
            withdrawMoneyBtn = new System.Windows.Forms.Button();
            viewBalanceBtn = new System.Windows.Forms.Button();
            userMenuHeader = new System.Windows.Forms.Label();
            atmLogo = new System.Windows.Forms.PictureBox();
            logOutBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)atmLogo).BeginInit();
            SuspendLayout();
            // 
            // withdrawMoneyBtn
            // 
            withdrawMoneyBtn.BackColor = System.Drawing.Color.Green;
            withdrawMoneyBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            withdrawMoneyBtn.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            withdrawMoneyBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            withdrawMoneyBtn.Location = new System.Drawing.Point(954, 631);
            withdrawMoneyBtn.Name = "withdrawMoneyBtn";
            withdrawMoneyBtn.Size = new System.Drawing.Size(628, 126);
            withdrawMoneyBtn.TabIndex = 4;
            withdrawMoneyBtn.Text = "Rút tiền";
            withdrawMoneyBtn.UseVisualStyleBackColor = false;
            withdrawMoneyBtn.Click += withdrawMoneyBtn_Click;
            // 
            // viewBalanceBtn
            // 
            viewBalanceBtn.BackColor = System.Drawing.Color.Green;
            viewBalanceBtn.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            viewBalanceBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            viewBalanceBtn.Location = new System.Drawing.Point(954, 815);
            viewBalanceBtn.Name = "viewBalanceBtn";
            viewBalanceBtn.Size = new System.Drawing.Size(628, 126);
            viewBalanceBtn.TabIndex = 5;
            viewBalanceBtn.Text = "Xem số dư";
            viewBalanceBtn.UseVisualStyleBackColor = false;
            viewBalanceBtn.Click += viewBalanceBtn_Click;
            // 
            // userMenuHeader
            // 
            userMenuHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            userMenuHeader.BackColor = System.Drawing.Color.Coral;
            userMenuHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            userMenuHeader.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            userMenuHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            userMenuHeader.Location = new System.Drawing.Point(372, 336);
            userMenuHeader.Name = "userMenuHeader";
            userMenuHeader.Size = new System.Drawing.Size(851, 93);
            userMenuHeader.TabIndex = 7;
            userMenuHeader.Text = "Xin vui lòng lựa chọn giao dịch\r\n";
            userMenuHeader.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            userMenuHeader.Click += userMenuHeader_Click;
            // 
            // atmLogo
            // 
            atmLogo.BackgroundImage = (System.Drawing.Image)resources.GetObject("atmLogo.BackgroundImage");
            atmLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            atmLogo.Location = new System.Drawing.Point(12, 12);
            atmLogo.Name = "atmLogo";
            atmLogo.Size = new System.Drawing.Size(350, 250);
            atmLogo.TabIndex = 8;
            atmLogo.TabStop = false;
            atmLogo.Click += atmLogo_Click;
            // 
            // logOutBtn
            // 
            logOutBtn.BackColor = System.Drawing.Color.Green;
            logOutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            logOutBtn.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            logOutBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            logOutBtn.Location = new System.Drawing.Point(26, 718);
            logOutBtn.Name = "logOutBtn";
            logOutBtn.Size = new System.Drawing.Size(628, 126);
            logOutBtn.TabIndex = 9;
            logOutBtn.Text = "Kết thúc";
            logOutBtn.UseVisualStyleBackColor = false;
            logOutBtn.Click += logOutBtn_Click;
            // 
            // UserMenuForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1594, 1063);
            Controls.Add(logOutBtn);
            Controls.Add(atmLogo);
            Controls.Add(userMenuHeader);
            Controls.Add(viewBalanceBtn);
            Controls.Add(withdrawMoneyBtn);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Name = "UserMenuForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "User Menu";
            ((System.ComponentModel.ISupportInitialize)atmLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button withdrawMoneyBtn;
        private System.Windows.Forms.Button viewBalanceBtn;
        private System.Windows.Forms.Label userMenuHeader;
        private System.Windows.Forms.PictureBox atmLogo;
        private System.Windows.Forms.Button logOutBtn;
    }
}