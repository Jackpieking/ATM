namespace Client.View
{
    partial class ConfirmWithdrawForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmWithdrawForm));
            atmLogo = new System.Windows.Forms.PictureBox();
            backBtn = new System.Windows.Forms.Button();
            confirmBtn = new System.Windows.Forms.Button();
            withdrawMoneyOutput = new System.Windows.Forms.Label();
            balanceFormHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)atmLogo).BeginInit();
            SuspendLayout();
            // 
            // atmLogo
            // 
            atmLogo.BackgroundImage = (System.Drawing.Image)resources.GetObject("atmLogo.BackgroundImage");
            atmLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            atmLogo.Location = new System.Drawing.Point(12, 12);
            atmLogo.Name = "atmLogo";
            atmLogo.Size = new System.Drawing.Size(350, 250);
            atmLogo.TabIndex = 14;
            atmLogo.TabStop = false;
            // 
            // backBtn
            // 
            backBtn.BackColor = System.Drawing.Color.Green;
            backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            backBtn.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            backBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            backBtn.Location = new System.Drawing.Point(954, 835);
            backBtn.Name = "backBtn";
            backBtn.Size = new System.Drawing.Size(628, 126);
            backBtn.TabIndex = 15;
            backBtn.Text = "Quay lại";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // confirmBtn
            // 
            confirmBtn.BackColor = System.Drawing.Color.Green;
            confirmBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            confirmBtn.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            confirmBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            confirmBtn.Location = new System.Drawing.Point(12, 835);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new System.Drawing.Size(628, 126);
            confirmBtn.TabIndex = 16;
            confirmBtn.Text = "Xác nhận";
            confirmBtn.UseVisualStyleBackColor = false;
            confirmBtn.Click += confirmBtn_Click;
            // 
            // withdrawMoneyOutput
            // 
            withdrawMoneyOutput.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            withdrawMoneyOutput.BackColor = System.Drawing.Color.Coral;
            withdrawMoneyOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            withdrawMoneyOutput.Font = new System.Drawing.Font("Segoe UI", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            withdrawMoneyOutput.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            withdrawMoneyOutput.Location = new System.Drawing.Point(433, 447);
            withdrawMoneyOutput.Name = "withdrawMoneyOutput";
            withdrawMoneyOutput.Size = new System.Drawing.Size(729, 248);
            withdrawMoneyOutput.TabIndex = 17;
            withdrawMoneyOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            withdrawMoneyOutput.Click += withdrawMoneyOutput_Click;
            // 
            // balanceFormHeader
            // 
            balanceFormHeader.AutoSize = true;
            balanceFormHeader.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            balanceFormHeader.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            balanceFormHeader.ForeColor = System.Drawing.SystemColors.ControlText;
            balanceFormHeader.Location = new System.Drawing.Point(69, 288);
            balanceFormHeader.Name = "balanceFormHeader";
            balanceFormHeader.Size = new System.Drawing.Size(1456, 86);
            balanceFormHeader.TabIndex = 18;
            balanceFormHeader.Text = "Bạn có chắc chắn muốn rút số tiền này không ?";
            // 
            // ConfirmWithdrawForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1594, 1063);
            Controls.Add(balanceFormHeader);
            Controls.Add(withdrawMoneyOutput);
            Controls.Add(confirmBtn);
            Controls.Add(backBtn);
            Controls.Add(atmLogo);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "ConfirmWithdrawForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Confirm Withdraw";
            Load += ConfirmWithdrawForm_Load;
            ((System.ComponentModel.ISupportInitialize)atmLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox atmLogo;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Label withdrawMoneyOutput;
        private System.Windows.Forms.Label balanceFormHeader;
    }
}