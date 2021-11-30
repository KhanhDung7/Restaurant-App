
namespace CleanArchQLNH
{
    partial class fLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        // <summary>
        //  Required method for Designer support - do not modify
        //  the contents of this method with the code editor.
        // </summary>
        private void InitializeComponent()
        {
            this.pnLogin = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnPassWord = new System.Windows.Forms.Panel();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.lbPassWord = new System.Windows.Forms.Label();
            this.pnUserName = new System.Windows.Forms.Panel();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lbUserName = new System.Windows.Forms.Label();
            this.pnLogin.SuspendLayout();
            this.pnPassWord.SuspendLayout();
            this.pnUserName.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnLogin
            // 
            this.pnLogin.Controls.Add(this.btnExit);
            this.pnLogin.Controls.Add(this.btnLogin);
            this.pnLogin.Controls.Add(this.pnPassWord);
            this.pnLogin.Controls.Add(this.pnUserName);
            this.pnLogin.Location = new System.Drawing.Point(1, 1);
            this.pnLogin.Size = new System.Drawing.Size(400, 137);
            this.pnLogin.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(314, 104);
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(218, 104);
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnLogin_KeyDown);

            // 
            // pnPassWord
            // 
            this.pnPassWord.Controls.Add(this.txtPassWord);
            this.pnPassWord.Controls.Add(this.lbPassWord);
            this.pnPassWord.Location = new System.Drawing.Point(0, 54);
            this.pnPassWord.Size = new System.Drawing.Size(400, 38);
            this.pnPassWord.TabIndex = 1;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(172, 6);
            this.txtPassWord.Size = new System.Drawing.Size(217, 23);
            this.txtPassWord.TabIndex = 1;
            this.txtPassWord.UseSystemPasswordChar = true;
            this.txtPassWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassWord_KeyDown);
            // 
            // lbPassWord
            // 
            this.lbPassWord.AutoSize = true;
            this.lbPassWord.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPassWord.Location = new System.Drawing.Point(11, 8);
            this.lbPassWord.Size = new System.Drawing.Size(95, 22);
            this.lbPassWord.TabIndex = 0;
            this.lbPassWord.Text = "Mật khẩu:";
            // 
            // pnUserName
            // 
            this.pnUserName.Controls.Add(this.txtUserName);
            this.pnUserName.Controls.Add(this.lbUserName);
            this.pnUserName.Location = new System.Drawing.Point(0, 14);
            this.pnUserName.Size = new System.Drawing.Size(400, 38);
            this.pnUserName.TabIndex = 0;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(172, 6);
            this.txtUserName.Size = new System.Drawing.Size(217, 23);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyDown);

            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbUserName.Location = new System.Drawing.Point(11, 8);
            this.lbUserName.Size = new System.Drawing.Size(137, 22);
            this.lbUserName.TabIndex = 0;
            this.lbUserName.Text = "Tên đăng nhập:";
            // 
            // fLogin
            // 
            //this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(402, 139);
            this.Controls.Add(this.pnLogin);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fLogin_FormClosing);
            this.pnLogin.ResumeLayout(false);
            this.pnPassWord.ResumeLayout(false);
            this.pnPassWord.PerformLayout();
            this.pnUserName.ResumeLayout(false);
            this.pnUserName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLogin, pnUserName, pnPassWord;
        private System.Windows.Forms.Label lbUserName, lbPassWord;
        private System.Windows.Forms.TextBox txtUserName, txtPassWord;
        private System.Windows.Forms.Button btnLogin, btnExit;
    }
}

