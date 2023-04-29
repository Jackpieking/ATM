namespace Client
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            lblCardID = new System.Windows.Forms.Label();
            lblPIN = new System.Windows.Forms.Label();
            iptCardID = new System.Windows.Forms.TextBox();
            iptPIN = new System.Windows.Forms.TextBox();
            loginBtn = new System.Windows.Forms.Button();
            loginHeader = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            cancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblCardID
            // 
            lblCardID.BackColor = System.Drawing.SystemColors.ActiveCaption;
            lblCardID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblCardID.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblCardID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            lblCardID.Location = new System.Drawing.Point(445, 636);
            lblCardID.Name = "lblCardID";
            lblCardID.Size = new System.Drawing.Size(179, 66);
            lblCardID.TabIndex = 1;
            lblCardID.Text = "Mã thẻ";
            lblCardID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblCardID.Click += lblCardID_Click;
            // 
            // lblPIN
            // 
            lblPIN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            lblPIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblPIN.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblPIN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            lblPIN.Location = new System.Drawing.Point(445, 728);
            lblPIN.Name = "lblPIN";
            lblPIN.Size = new System.Drawing.Size(179, 66);
            lblPIN.TabIndex = 3;
            lblPIN.Text = "Mã PIN";
            lblPIN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblPIN.Click += lblPIN_Click;
            // 
            // iptCardID
            // 
            iptCardID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            iptCardID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            iptCardID.Location = new System.Drawing.Point(693, 643);
            iptCardID.MaxLength = 19;
            iptCardID.Name = "iptCardID";
            iptCardID.PlaceholderText = "Nhập mã thẻ ở đây";
            iptCardID.Size = new System.Drawing.Size(481, 50);
            iptCardID.TabIndex = 2;
            iptCardID.TextChanged += iptCardID_TextChanged;
            // 
            // iptPIN
            // 
            iptPIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            iptPIN.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            iptPIN.Location = new System.Drawing.Point(693, 735);
            iptPIN.MaxLength = 6;
            iptPIN.Name = "iptPIN";
            iptPIN.PasswordChar = '*';
            iptPIN.PlaceholderText = "Nhập mã PIN ở đây";
            iptPIN.Size = new System.Drawing.Size(481, 50);
            iptPIN.TabIndex = 4;
            iptPIN.TextChanged += iptPIN_TextChanged;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = System.Drawing.Color.ForestGreen;
            loginBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            loginBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            loginBtn.Location = new System.Drawing.Point(445, 838);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new System.Drawing.Size(729, 87);
            loginBtn.TabIndex = 5;
            loginBtn.Text = "Đồng ý";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // loginHeader
            // 
            loginHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            loginHeader.BackColor = System.Drawing.Color.Coral;
            loginHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            loginHeader.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            loginHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            loginHeader.Location = new System.Drawing.Point(445, 445);
            loginHeader.Name = "loginHeader";
            loginHeader.Size = new System.Drawing.Size(729, 166);
            loginHeader.TabIndex = 0;
            loginHeader.Text = "(Xin vui lòng nhập số pin)\r\n(Nhấn Enter để đồng ý, Nhấn Esc để huỷ bỏ)\r\n\r\n\r\n\r\n";
            loginHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            loginHeader.Click += loginHeader_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Location = new System.Drawing.Point(445, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(729, 396);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = System.Drawing.Color.Red;
            cancelBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            cancelBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            cancelBtn.Location = new System.Drawing.Point(445, 943);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new System.Drawing.Size(729, 87);
            cancelBtn.TabIndex = 12;
            cancelBtn.Text = "Huỷ bỏ";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // LoginForm
            // 
            AcceptButton = loginBtn;
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            CancelButton = cancelBtn;
            ClientSize = new System.Drawing.Size(1590, 1059);
            Controls.Add(cancelBtn);
            Controls.Add(pictureBox1);
            Controls.Add(loginHeader);
            Controls.Add(loginBtn);
            Controls.Add(iptPIN);
            Controls.Add(iptCardID);
            Controls.Add(lblPIN);
            Controls.Add(lblCardID);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "LoginForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "ATM APP";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lblCardID;
        private System.Windows.Forms.Label lblPIN;
        private System.Windows.Forms.TextBox iptCardID;
        private System.Windows.Forms.TextBox iptPIN;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label loginHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cancelBtn;
    }
}