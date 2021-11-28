using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Domain.Entities;
//using Infrastructure.Persistence;
//using Usecase;

namespace CleanArchQLNH
{
    public partial class fAccountProfile : Form
    {
        //private NHANVIEN loginAccount;

        //public NHANVIEN LoginAccount
        //{
         //   get { return loginAccount; }
         //   set { loginAccount = value; ChangedAccount(loginAccount); }
        //}
       // public fAccountProfile(NHANVIEN acc)
        //{
          //  InitializeComponent();

          //  LoginAccount = acc;
        //}
            public fAccountProfile()
        {
           InitializeComponent();

        //    LoginAccount = acc;
        }

        private void txtPassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) txtFullName.Focus();
            if (e.KeyCode == Keys.Down) txtFullName.Focus();
        }
        private void txtFullName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) txtPhoneNumber.Focus();
            if (e.KeyCode == Keys.Up) txtPassWord.Focus();
            if (e.KeyCode == Keys.Down) txtPhoneNumber.Focus();
        }
        private void txtPhoneNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) txtAddress.Focus();
            if (e.KeyCode == Keys.Up) txtFullName.Focus();
            if (e.KeyCode == Keys.Down) txtAddress.Focus();
        }
        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) txtIdentity.Focus();
            if (e.KeyCode == Keys.Up) txtPhoneNumber.Focus();
            if (e.KeyCode == Keys.Down) txtIdentity.Focus();
        }
        private void txtIdentity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnEdit.Focus();
            if (e.KeyCode == Keys.Up) txtAddress.Focus();
        }
        //void ChangedAccount(NHANVIEN acc)
        //{
         //   txtUserName.Text = LoginAccount.MaNV;
         //   txtPassWord.Text = LoginAccount.MatKhau;
          //  txtFullName.Text = LoginAccount.HoTenNV;
         //   txtPosition.Text = LoginAccount.MaChucVu.ToString();
          //  txtPhoneNumber.Text = LoginAccount.SDT_NV;
          //  txtAddress.Text = LoginAccount.DiaChi;
          //  txtIdentity.Text = LoginAccount.CMND_NV;
        //}

        void UpdateAccount()
        {
            string manv = txtUserName.Text;
            string hotennv = txtFullName.Text;
            string cmnd;
            string sdtnv;
            string diachi = txtAddress.Text;
            string chucvu = txtPosition.Text.ToString();
            string matkhau = txtPassWord.Text;
            int n = 0;
            if (this.txtFullName.Text.Replace(" ","").Length != 0 && this.txtAddress.Text.Replace(" ", "").Length != 0 && this.txtPassWord.Text.Replace(" ", "").Length != 0)
            {
                if (int.TryParse(this.txtIdentity.Text, out n))
                {
                    if (this.txtIdentity.Text.Replace(" ", "").Length == 9)
                    {
                        cmnd = txtIdentity.Text;
                        n = 0;
                        if (int.TryParse(this.txtPhoneNumber.Text, out n))
                        {
                            if (this.txtPhoneNumber.Text.Replace(" ", "").Length == 10)
                            {
                                sdtnv = txtPhoneNumber.Text;
    //                            UpdateAccountProfileInfras.Instance.UpdateAccountProfile(manv, hotennv, cmnd, sdtnv, diachi, chucvu, matkhau);
    //                            if (UpdateAccountProfileInfras.Instance.UpdateAccountProfile(manv, hotennv, cmnd, sdtnv, diachi, chucvu, matkhau) == 1)
                                {
                                    MessageBox.Show("Cập nhật thông tin thành công", "Thông báo");
                                }
                                if (eventUpdateAccount != null)
                                {
    //                                eventUpdateAccount(this, new AccountEvent(CheckLoginInfras.Instance.GetNhanVienByMaNV(manv)));
                                }
                                else MessageBox.Show("Cập nhật thông tin thất bại", "Thông báo");
                            }
                            else MessageBox.Show("Số điện thoại phải có đúng 10 ký tự", "Thông báo");
                        }
                        else MessageBox.Show("Số điện thoại chỉ được chứa ký tự số", "Thông báo");
                    }
                    else MessageBox.Show("CMND phải có đúng 9 ký tự", "Thông báo");
                }
                else MessageBox.Show("CMND chỉ được chứa ký tự số", "Thông báo");
            }
            else MessageBox.Show("Không được để trống bất kỳ trường nào", "Thông báo");
        }

        private event EventHandler<AccountEvent> eventUpdateAccount;
        public event EventHandler<AccountEvent> EventUpdateAccount
        {
            add { eventUpdateAccount += value; }
            remove { eventUpdateAccount -= value; }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UpdateAccount();
        }
    }
    public class AccountEvent : EventArgs
    {
       // private NHANVIEN acc;
        //public NHANVIEN Acc
       // {
        //    get { return acc; }
        //    set { acc = value; }
       // }
        //public AccountEvent(NHANVIEN acc)
        //{
         //   this.Acc = acc;
       // }
    }

}
