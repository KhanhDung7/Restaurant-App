using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Infrastructure.Persistence;
using Domain.Entities;
using Usecase;

namespace CleanArchQLNH
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassWord.Text;
             if (CheckLoginInfras.Instance.Login(username, password) == 1)
             {
                 NHANVIEN nhanvienLogin = CheckLoginInfras.Instance.GetNhanVienByMaNV(username);
                 fTableManager f = new fTableManager(nhanvienLogin);
                 this.Hide();
                 f.ShowDialog();
                 this.Show();
             }
             else
             {
                 MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Thông báo");
             }    
        }

       

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát khỏi phần mềm?","Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnLogin_KeyDown (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnLogin_Click(sender, e);
            if (e.KeyData == Keys.Right) btnExit.Focus();
        }

        private void txtPassWord_KeyDown (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnLogin.Focus();
            if (e.KeyCode == Keys.Up) txtUserName.Focus();
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) txtPassWord.Focus();
        }
        }
}
