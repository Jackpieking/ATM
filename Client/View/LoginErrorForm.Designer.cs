namespace Client
{
    partial class LoginErrorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginErrorForm));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            errorMessage = new System.Windows.Forms.Label();
            quitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(122, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(100, 100);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // errorMessage
            // 
            errorMessage.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            errorMessage.Location = new System.Drawing.Point(264, 96);
            errorMessage.Name = "errorMessage";
            errorMessage.Size = new System.Drawing.Size(650, 64);
            errorMessage.TabIndex = 1;
            errorMessage.Text = "Mã thẻ hay mã PIN không hợp lệ !!";
            errorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            errorMessage.Click += errorMessage_Click;
            // 
            // quitBtn
            // 
            quitBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            quitBtn.Location = new System.Drawing.Point(431, 209);
            quitBtn.Name = "quitBtn";
            quitBtn.Size = new System.Drawing.Size(150, 46);
            quitBtn.TabIndex = 2;
            quitBtn.Text = "OK";
            quitBtn.UseVisualStyleBackColor = true;
            quitBtn.Click += quitBtn_Click;
            // 
            // LoginErrorForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = quitBtn;
            ClientSize = new System.Drawing.Size(997, 292);
            Controls.Add(quitBtn);
            Controls.Add(errorMessage);
            Controls.Add(pictureBox1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "LoginErrorForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Login Error";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label errorMessage;
        private System.Windows.Forms.Button quitBtn;
    }
}