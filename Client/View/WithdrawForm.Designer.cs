namespace Client.View
{
    partial class WithdrawForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WithdrawForm));
            atmLogo = new System.Windows.Forms.PictureBox();
            backBtn = new System.Windows.Forms.Button();
            withdrawFormHeader = new System.Windows.Forms.Label();
            withdraw100Btn = new System.Windows.Forms.Button();
            withdraw200Btn = new System.Windows.Forms.Button();
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
            atmLogo.TabIndex = 9;
            atmLogo.TabStop = false;
            // 
            // backBtn
            // 
            backBtn.BackColor = System.Drawing.Color.Green;
            backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            backBtn.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            backBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            backBtn.Location = new System.Drawing.Point(954, 778);
            backBtn.Name = "backBtn";
            backBtn.Size = new System.Drawing.Size(628, 126);
            backBtn.TabIndex = 11;
            backBtn.Text = "Quay lại";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // withdrawFormHeader
            // 
            withdrawFormHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            withdrawFormHeader.BackColor = System.Drawing.Color.Coral;
            withdrawFormHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            withdrawFormHeader.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            withdrawFormHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            withdrawFormHeader.Location = new System.Drawing.Point(338, 340);
            withdrawFormHeader.Name = "withdrawFormHeader";
            withdrawFormHeader.Size = new System.Drawing.Size(919, 102);
            withdrawFormHeader.TabIndex = 15;
            withdrawFormHeader.Text = "Xin vui lòng lựa chọn số tiền\r\n";
            withdrawFormHeader.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // withdraw100Btn
            // 
            withdraw100Btn.BackColor = System.Drawing.Color.Green;
            withdraw100Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            withdraw100Btn.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            withdraw100Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            withdraw100Btn.Location = new System.Drawing.Point(12, 566);
            withdraw100Btn.Name = "withdraw100Btn";
            withdraw100Btn.Size = new System.Drawing.Size(628, 126);
            withdraw100Btn.TabIndex = 16;
            withdraw100Btn.Text = "100.000";
            withdraw100Btn.UseVisualStyleBackColor = false;
            withdraw100Btn.Click += withdraw100Btn_Click;
            // 
            // withdraw200Btn
            // 
            withdraw200Btn.BackColor = System.Drawing.Color.Green;
            withdraw200Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            withdraw200Btn.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            withdraw200Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            withdraw200Btn.Location = new System.Drawing.Point(954, 566);
            withdraw200Btn.Name = "withdraw200Btn";
            withdraw200Btn.Size = new System.Drawing.Size(628, 126);
            withdraw200Btn.TabIndex = 17;
            withdraw200Btn.Text = "200.000";
            withdraw200Btn.UseVisualStyleBackColor = false;
            withdraw200Btn.Click += withdraw200Btn_Click_1;
            // 
            // WithdrawForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1594, 1063);
            Controls.Add(withdraw200Btn);
            Controls.Add(withdraw100Btn);
            Controls.Add(withdrawFormHeader);
            Controls.Add(backBtn);
            Controls.Add(atmLogo);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "WithdrawForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Withdraw";
            ((System.ComponentModel.ISupportInitialize)atmLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox atmLogo;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label withdrawFormHeader;
        private System.Windows.Forms.Button withdraw100Btn;
        private System.Windows.Forms.Button withdraw200Btn;
    }
}