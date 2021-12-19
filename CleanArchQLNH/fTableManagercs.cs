using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Infrastructure.Persistence;
using Usecase;
using System.IO;
using System.Collections;

namespace CleanArchQLNH
{
    public partial class fTableManager : Form
    {
        private NHANVIEN loginAccount;
        private decimal total = 0;
        public NHANVIEN LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangedAccount(loginAccount.MaChucVu); }
        }
        

        
        public fTableManager(NHANVIEN acc)
        {
            InitializeComponent();
            LoadData();
            LoadTable();
            this.LoginAccount = acc;
        }
        
        public fTableManager()
        {
            InitializeComponent();
            LoadData();
            LoadTable();
            this.LoginAccount = loginAccount;
        }


        #region Methods

        //Nếu chức vụ bằng 1 thì hiện Form Admin
        void ChangedAccount(int chucvu)
        {
            AdminMenuItem.Enabled = chucvu == 1;
            ManageAccMenuItem.Text += " (" + LoginAccount.HoTenNV + ")";
        }


        #endregion


        private void AdminMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.ShowDialog();
        }

        private void AccInfoMenuDrop_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile(LoginAccount);
            f.EventUpdateAccount += F_EventUpdateAccount; ;
            f.ShowDialog();
        }

        private void F_EventUpdateAccount(object sender, AccountEvent e)
        {
            ManageAccMenuItem.Text = "Quản lý tài khoản (" + e.Acc.HoTenNV + ")";
        }

        private void LogoutMenuDrop_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void ChooseFloorComboBox_IndexChanged(object sender, EventArgs e)
        {
            if (this.ChooseFloorComboBox.SelectedIndex == 0)
            {
                this.flpnTable.Visible = true;
                this.flpnTable2.Hide();
            }
            if (this.ChooseFloorComboBox.SelectedIndex == 1)
            {
                this.flpnTable2.Visible = true;
                this.flpnTable.Hide();
            }
        }

        void LoadData()
        {

            //Table
            BindingSource table = new BindingSource();
            table.DataSource = BanAnInfras.Instance.LoadTableList();

            BindingSource tableall = new BindingSource();
            tableall.DataSource = BanAnInfras.Instance.LoadTableListI();

            cmbGopBan.DataSource = table.DataSource;
            cmbGopBan.DisplayMember = "MaB";
            cmbGopBan.ValueMember = "MaB";
            cbSwitchTable.DataSource = table.DataSource;
            cbSwitchTable.DisplayMember = "MaB";
            cbSwitchTable.ValueMember = "MaB";
            //Promotion
            BindingSource promotion = new BindingSource();
            promotion.DataSource = KhuyenMaiInfras.Instance.LoadPromotionList();
            cbDisscount.DataSource = promotion.DataSource;
            cbDisscount.DisplayMember = "TenKM";
            cbDisscount.ValueMember = "MaKM";
            cbDisscount.SelectedIndex = 0;
            //Food
            BindingSource food = new BindingSource();
            food.DataSource = MonAnInfras.Instance.LoadFoodList();
            cbFood.DataSource = food.DataSource;
            cbFood.DisplayMember = "TenM";
            cbFood.ValueMember = "MaM";

        }
        private void LoadTable()
        {

            if (this.ChooseFloorComboBox.SelectedIndex == 0)
            {
                this.flpnTable.Visible = true;
                this.flpnTable2.Hide();
            }
            if (this.ChooseFloorComboBox.SelectedIndex == 1)
            {
                this.flpnTable2.Visible = true;
                this.flpnTable.Hide();
            }
            string query = "SELECT * FROM BANAN";

            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);
            foreach (DataRow dtr in data.Rows)
            {
                BANAN ban = new BANAN(dtr);
                if (ban.TinhTrang == 1)
                {
                    if (ban.MaB == 1)
                    {
                        this.btnBan1.BackColor = System.Drawing.Color.DarkGray;
                        this.tbKhachBan1.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan1.Click += BtnBan1_Click;
                        this.btnBan1.Tag = ban;
                    }
                    if (ban.MaB == 2)
                    {
                        this.btnBan2.BackColor = System.Drawing.Color.DarkGray;
                        this.tbKhachBan2.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan2.Click += BtnBan2_Click;
                        this.btnBan2.Tag = ban;
                    }
                    if (ban.MaB == 3)
                    {
                        this.btnBan3.BackColor = System.Drawing.Color.DarkGray;
                        this.tbKhachBan3.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan3.Click += BtnBan3_Click;
                        this.btnBan3.Tag = ban;
                    }
                    if (ban.MaB == 4)
                    {
                        this.btnBan4.BackColor = System.Drawing.Color.DarkGray;
                        this.tbKhachBan4.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan4.Click += BtnBan4_Click;
                        this.btnBan4.Tag = ban;
                    }
                    if (ban.MaB == 5)
                    {
                        this.btnBan5.BackColor = System.Drawing.Color.DarkGray;
                        this.tbKhachBan5.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan5.Click += BtnBan5_Click;
                        this.btnBan5.Tag = ban;
                    }
                    if (ban.MaB == 6)
                    {
                        this.btnBan6.BackColor = System.Drawing.Color.DarkGray;
                        this.tbKhachBan6.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan6.Click += BtnBan6_Click;
                        this.btnBan6.Tag = ban;
                    }
                    if (ban.MaB == 7)
                    {
                        this.btnBan7.BackColor = System.Drawing.Color.DarkGray;
                        this.tbKhachBan7.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan7.Click += BtnBan7_Click;
                        this.btnBan7.Tag = ban;
                    }
                    if (ban.MaB == 8)
                    {
                        this.btnBan8.BackColor = System.Drawing.Color.DarkGray;
                        this.tbKhachBan8.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan8.Click += BtnBan8_Click;
                        this.btnBan8.Tag = ban;
                    }
                    if (ban.MaB == 9)
                    {
                        this.btnBan9.BackColor = System.Drawing.Color.DarkGray;
                        this.tbKhachBan9.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan9.Click += BtnBan9_Click;
                        this.btnBan9.Tag = ban;
                    }
                    if (ban.MaB == 10)
                    {
                        this.btnBan10.BackColor = System.Drawing.Color.DarkGray;
                        this.tbKhachBan10.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan10.Click += BtnBan10_Click;
                        this.btnBan10.Tag = ban;
                    }
                    if (ban.MaB == 11)
                    {
                        this.btnBan11.BackColor = System.Drawing.Color.DarkGray;
                        this.tbKhachBan11.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan11.Click += BtnBan11_Click;
                        this.btnBan11.Tag = ban;
                    }
                    if (ban.MaB == 12)
                    {
                        this.btnBan12.BackColor = System.Drawing.Color.DarkGray;
                        this.tbKhachBan12.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan12.Click += BtnBan12_Click;
                        this.btnBan12.Tag = ban;
                    }
                    if (ban.MaB == 13)
                    {
                        this.btnBan13.BackColor = System.Drawing.Color.DarkGray;
                        this.tbKhachBan13.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan13.Click += BtnBan13_Click;
                        this.btnBan13.Tag = ban;
                    }
                    if (ban.MaB == 14)
                    {
                        this.btnBan14.BackColor = System.Drawing.Color.DarkGray;
                        this.tbKhachBan14.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan14.Click += BtnBan14_Click;
                        this.btnBan14.Tag = ban;
                    }
                    if (ban.MaB == 15)
                    {
                        this.btnBan15.BackColor = System.Drawing.Color.DarkGray;
                        this.tbKhachBan15.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan15.Click += BtnBan15_Click;
                        this.btnBan15.Tag = ban;
                    }
                    if (ban.MaB == 16)
                    {
                        this.btnBan16.BackColor = System.Drawing.Color.DarkGray;
                        this.tbKhachBan16.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan16.Click += BtnBan16_Click;
                        this.btnBan16.Tag = ban;
                    }
                    if (ban.MaB == 17)
                    {
                        this.btnBan1Tang2.BackColor = System.Drawing.Color.DarkGray;
                        this.tbKhachBan1Tang2.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan1Tang2.Click += BtnBan17_Click;
                        this.btnBan1Tang2.Tag = ban;
                    }
                    if (ban.MaB == 18)
                    {
                        this.btnBan2Tang2.BackColor = System.Drawing.Color.DarkGray;
                        this.tbKhachBan2Tang2.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan2Tang2.Click += BtnBan18_Click;
                        this.btnBan2Tang2.Tag = ban;
                    }
                    if (ban.MaB == 19)
                    {
                        this.btnBan3Tang2.BackColor = System.Drawing.Color.DarkGray;
                        this.tbKhachBan3Tang2.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan3Tang2.Click += BtnBan19_Click;
                        this.btnBan3Tang2.Tag = ban;
                    }
                    if (ban.MaB == 20)
                    {
                        this.btnBan4Tang2.BackColor = System.Drawing.Color.DarkGray;
                        this.tbKhachBan4Tang2.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan4Tang2.Click += BtnBan20_Click;
                        this.btnBan4Tang2.Tag = ban;
                    }
                    if (ban.MaB == 21)
                    {
                        this.btnBan5Tang2.BackColor = System.Drawing.Color.DarkGray;
                        this.tbKhachBan5Tang2.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan5Tang2.Click += BtnBan21_Click;
                        this.btnBan5Tang2.Tag = ban;
                    }
                    if (ban.MaB == 22)
                    {
                        this.btnBan6Tang2.BackColor = System.Drawing.Color.DarkGray;
                        this.tbKhachBan6Tang2.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan6Tang2.Click += BtnBan22_Click;
                        this.btnBan6Tang2.Tag = ban;
                    }
                    if (ban.MaB == 23)
                    {
                        this.btnBan7Tang2.BackColor = System.Drawing.Color.DarkGray;
                        this.tbKhachBan7Tang2.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan7Tang2.Click += BtnBan23_Click;
                        this.btnBan7Tang2.Tag = ban;
                    }
                    if (ban.MaB == 24)
                    {
                        this.btnBan8Tang2.BackColor = System.Drawing.Color.DarkGray;
                        this.tbKhachBan8Tang2.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan8Tang2.Click += BtnBan24_Click;
                        this.btnBan8Tang2.Tag = ban;
                    }
                    if (ban.MaB == 25)
                    {
                        this.btnBan9Tang2.BackColor = System.Drawing.Color.DarkGray;
                        this.tbKhachBan9Tang2.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan9Tang2.Click += BtnBan25_Click;
                        this.btnBan9Tang2.Tag = ban;
                    }
                    if (ban.MaB == 26)
                    {
                        this.btnBan10Tang2.BackColor = System.Drawing.Color.DarkGray;
                        this.tbKhachBan10Tang2.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan10Tang2.Click += BtnBan26_Click;
                        this.btnBan10Tang2.Tag = ban;
                    }
                    if (ban.MaB == 27)
                    {
                        this.btnBan11Tang2.BackColor = System.Drawing.Color.DarkGray;
                        this.tbKhachBan11Tang2.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan11Tang2.Click += BtnBan27_Click;
                        this.btnBan11Tang2.Tag = ban;
                    }
                    if (ban.MaB == 28)
                    {
                        this.btnBan12Tang2.BackColor = System.Drawing.Color.DarkGray;
                        this.tbKhachBan12Tang2.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan12Tang2.Click += BtnBan28_Click;
                        this.btnBan12Tang2.Tag = ban;
                    }
                }
                if (ban.TinhTrang == 2)
                {
                    if (ban.MaB == 1)
                    {
                        string query2 = "SELECT * FROM hoadon where tinhtrang = 'false' and mab=" + ban.MaB;
                        DataTable data2 = provider.ExecuteQuery(query2);
                        foreach (DataRow dtr2 in data2.Rows)
                        {
                            HOADON hd = new HOADON(dtr2);
                            this.btnBan1.BackColor = System.Drawing.Color.Lime;
                            this.tbKhachBan1.Text = Convert.ToString(ban.SoKhach_ToiDa - hd.SLKhach);
                            this.btnBan1.Click += BtnBan1_Click;
                            this.btnBan1.Tag = ban;
                        }
                    }
                    if (ban.MaB == 2)
                    {
                        string query2 = "SELECT * FROM hoadon where tinhtrang = 'false' and mab=" + ban.MaB;
                        DataTable data2 = provider.ExecuteQuery(query2);
                        foreach (DataRow dtr2 in data2.Rows)
                        {
                            HOADON hd = new HOADON(dtr2);
                            this.btnBan2.BackColor = System.Drawing.Color.Lime;
                            this.tbKhachBan2.Text = Convert.ToString(ban.SoKhach_ToiDa - hd.SLKhach);
                            this.btnBan2.Click += BtnBan2_Click;
                            this.btnBan2.Tag = ban;
                        }
                    }
                    if (ban.MaB == 3)
                    {
                        string query2 = "SELECT * FROM hoadon where tinhtrang = 'false' and mab=" + ban.MaB;
                        DataTable data2 = provider.ExecuteQuery(query2);
                        foreach (DataRow dtr2 in data2.Rows)
                        {
                            HOADON hd = new HOADON(dtr2);
                            this.btnBan3.BackColor = System.Drawing.Color.Lime;
                            this.tbKhachBan3.Text = Convert.ToString(ban.SoKhach_ToiDa - hd.SLKhach);
                            this.btnBan3.Click += BtnBan3_Click;
                            this.btnBan3.Tag = ban;
                        }
                    }
                    if (ban.MaB == 4)
                    {
                        string query2 = "SELECT * FROM hoadon where tinhtrang = 'false' and mab=" + ban.MaB;
                        DataTable data2 = provider.ExecuteQuery(query2);
                        foreach (DataRow dtr2 in data2.Rows)
                        {
                            HOADON hd = new HOADON(dtr2);
                            this.btnBan4.BackColor = System.Drawing.Color.Lime;
                            this.tbKhachBan4.Text = Convert.ToString(ban.SoKhach_ToiDa - hd.SLKhach);
                            this.btnBan4.Click += BtnBan4_Click;
                            this.btnBan4.Tag = ban;
                        }
                    }
                    if (ban.MaB == 5)
                    {
                        string query2 = "SELECT * FROM hoadon where tinhtrang = 'false' and mab=" + ban.MaB;
                        DataTable data2 = provider.ExecuteQuery(query2);
                        foreach (DataRow dtr2 in data2.Rows)
                        {
                            HOADON hd = new HOADON(dtr2);
                            this.btnBan5.BackColor = System.Drawing.Color.Lime;
                            this.tbKhachBan5.Text = Convert.ToString(ban.SoKhach_ToiDa - hd.SLKhach);
                            this.btnBan5.Click += BtnBan5_Click;
                            this.btnBan5.Tag = ban;
                        }
                    }
                    if (ban.MaB == 6)
                    {
                        string query2 = "SELECT * FROM hoadon where tinhtrang = 'false' and mab=" + ban.MaB;
                        DataTable data2 = provider.ExecuteQuery(query2);
                        foreach (DataRow dtr2 in data2.Rows)
                        {
                            HOADON hd = new HOADON(dtr2);
                            this.btnBan6.BackColor = System.Drawing.Color.Lime;
                            this.tbKhachBan6.Text = Convert.ToString(ban.SoKhach_ToiDa - hd.SLKhach);
                            this.btnBan6.Click += BtnBan6_Click;
                            this.btnBan6.Tag = ban;
                        }
                    }
                    if (ban.MaB == 7)
                    {
                        string query2 = "SELECT * FROM hoadon where tinhtrang = 'false' and mab=" + ban.MaB;
                        DataTable data2 = provider.ExecuteQuery(query2);
                        foreach (DataRow dtr2 in data2.Rows)
                        {
                            HOADON hd = new HOADON(dtr2);
                            this.btnBan7.BackColor = System.Drawing.Color.Lime;
                            this.tbKhachBan7.Text = Convert.ToString(ban.SoKhach_ToiDa - hd.SLKhach);
                            this.btnBan7.Click += BtnBan7_Click;
                            this.btnBan7.Tag = ban;
                        }
                    }
                    if (ban.MaB == 8)
                    {
                        string query2 = "SELECT * FROM hoadon where tinhtrang = 'false' and mab=" + ban.MaB;
                        DataTable data2 = provider.ExecuteQuery(query2);
                        foreach (DataRow dtr2 in data2.Rows)
                        {
                            HOADON hd = new HOADON(dtr2);
                            this.btnBan8.BackColor = System.Drawing.Color.Lime;
                            this.tbKhachBan8.Text = Convert.ToString(ban.SoKhach_ToiDa - hd.SLKhach);
                            this.btnBan8.Click += BtnBan8_Click;
                            this.btnBan8.Tag = ban;
                        }
                    }
                    if (ban.MaB == 9)
                    {
                        string query2 = "SELECT * FROM hoadon where tinhtrang = 'false' and mab=" + ban.MaB;
                        DataTable data2 = provider.ExecuteQuery(query2);
                        foreach (DataRow dtr2 in data2.Rows)
                        {
                            HOADON hd = new HOADON(dtr2);
                            this.btnBan9.BackColor = System.Drawing.Color.Lime;
                            this.tbKhachBan9.Text = Convert.ToString(ban.SoKhach_ToiDa - hd.SLKhach);
                            this.btnBan9.Click += BtnBan9_Click;
                            this.btnBan9.Tag = ban;
                        }
                    }
                    if (ban.MaB == 10)
                    {
                        string query2 = "SELECT * FROM hoadon where tinhtrang = 'false' and mab=" + ban.MaB;
                        DataTable data2 = provider.ExecuteQuery(query2);
                        foreach (DataRow dtr2 in data2.Rows)
                        {
                            HOADON hd = new HOADON(dtr2);
                            this.btnBan10.BackColor = System.Drawing.Color.Lime;
                            this.tbKhachBan10.Text = Convert.ToString(ban.SoKhach_ToiDa - hd.SLKhach);
                            this.btnBan10.Click += BtnBan10_Click;
                            this.btnBan10.Tag = ban;
                        }
                    }
                    if (ban.MaB == 11)
                    {
                        string query2 = "SELECT * FROM hoadon where tinhtrang = 'false' and mab=" + ban.MaB;
                        DataTable data2 = provider.ExecuteQuery(query2);
                        foreach (DataRow dtr2 in data2.Rows)
                        {
                            HOADON hd = new HOADON(dtr2);
                            this.btnBan11.BackColor = System.Drawing.Color.Lime;
                            this.tbKhachBan11.Text = Convert.ToString(ban.SoKhach_ToiDa - hd.SLKhach);
                            this.btnBan11.Click += BtnBan11_Click;
                            this.btnBan11.Tag = ban;
                        }
                    }
                    if (ban.MaB == 12)
                    {
                        string query2 = "SELECT * FROM hoadon where tinhtrang = 'false' and mab=" + ban.MaB;
                        DataTable data2 = provider.ExecuteQuery(query2);
                        foreach (DataRow dtr2 in data2.Rows)
                        {
                            HOADON hd = new HOADON(dtr2);
                            this.btnBan12.BackColor = System.Drawing.Color.Lime;
                            this.tbKhachBan12.Text = Convert.ToString(ban.SoKhach_ToiDa - hd.SLKhach);
                            this.btnBan12.Click += BtnBan12_Click;
                            this.btnBan12.Tag = ban;
                        }
                    }
                    if (ban.MaB == 13)
                    {
                        string query2 = "SELECT * FROM hoadon where tinhtrang = 'false' and mab=" + ban.MaB;
                        DataTable data2 = provider.ExecuteQuery(query2);
                        foreach (DataRow dtr2 in data2.Rows)
                        {
                            HOADON hd = new HOADON(dtr2);
                            this.btnBan13.BackColor = System.Drawing.Color.Lime;
                            this.tbKhachBan13.Text = Convert.ToString(ban.SoKhach_ToiDa - hd.SLKhach);
                            this.btnBan13.Click += BtnBan13_Click;
                            this.btnBan13.Tag = ban;
                        }
                    }
                    if (ban.MaB == 14)
                    {
                        string query2 = "SELECT * FROM hoadon where tinhtrang = 'false' and mab=" + ban.MaB;
                        DataTable data2 = provider.ExecuteQuery(query2);
                        foreach (DataRow dtr2 in data2.Rows)
                        {
                            HOADON hd = new HOADON(dtr2);
                            this.btnBan14.BackColor = System.Drawing.Color.Lime;
                            this.tbKhachBan14.Text = Convert.ToString(ban.SoKhach_ToiDa - hd.SLKhach);
                            this.btnBan14.Click += BtnBan14_Click;
                            this.btnBan14.Tag = ban;
                        }
                    }
                    if (ban.MaB == 15)
                    {
                        string query2 = "SELECT * FROM hoadon where tinhtrang = 'false' and mab=" + ban.MaB;
                        DataTable data2 = provider.ExecuteQuery(query2);
                        foreach (DataRow dtr2 in data2.Rows)
                        {
                            HOADON hd = new HOADON(dtr2);
                            this.btnBan15.BackColor = System.Drawing.Color.Lime;
                            this.tbKhachBan15.Text = Convert.ToString(ban.SoKhach_ToiDa - hd.SLKhach);
                            this.btnBan15.Click += BtnBan15_Click;
                            this.btnBan15.Tag = ban;
                        }
                    }
                    if (ban.MaB == 16)
                    {
                        string query2 = "SELECT * FROM hoadon where tinhtrang = 'false' and mab=" + ban.MaB;
                        DataTable data2 = provider.ExecuteQuery(query2);
                        foreach (DataRow dtr2 in data2.Rows)
                        {
                            HOADON hd = new HOADON(dtr2);
                            this.btnBan16.BackColor = System.Drawing.Color.Lime;
                            this.tbKhachBan16.Text = Convert.ToString(ban.SoKhach_ToiDa - hd.SLKhach);
                            this.btnBan16.Click += BtnBan16_Click;
                            this.btnBan16.Tag = ban;
                        }
                    }
                    if (ban.MaB == 17)
                    {
                        string query2 = "SELECT * FROM hoadon where tinhtrang = 'false' and mab=" + ban.MaB;
                        DataTable data2 = provider.ExecuteQuery(query2);
                        foreach (DataRow dtr2 in data2.Rows)
                        {
                            HOADON hd = new HOADON(dtr2);
                            this.btnBan1Tang2.BackColor = System.Drawing.Color.Lime;
                            this.tbKhachBan1Tang2.Text = Convert.ToString(ban.SoKhach_ToiDa - hd.SLKhach);
                            this.btnBan1Tang2.Click += BtnBan17_Click;
                            this.btnBan1Tang2.Tag = ban;
                        }
                    }
                    if (ban.MaB == 18)
                    {
                        string query2 = "SELECT * FROM hoadon where tinhtrang = 'false' and mab=" + ban.MaB;
                        DataTable data2 = provider.ExecuteQuery(query2);
                        foreach (DataRow dtr2 in data2.Rows)
                        {
                            HOADON hd = new HOADON(dtr2);
                            this.btnBan2Tang2.BackColor = System.Drawing.Color.Lime;
                            this.tbKhachBan2Tang2.Text = Convert.ToString(ban.SoKhach_ToiDa - hd.SLKhach);
                            this.btnBan2Tang2.Click += BtnBan18_Click;
                            this.btnBan2Tang2.Tag = ban;
                        }
                    }
                    if (ban.MaB == 19)
                    {
                        string query2 = "SELECT * FROM hoadon where tinhtrang = 'false' and mab=" + ban.MaB;
                        DataTable data2 = provider.ExecuteQuery(query2);
                        foreach (DataRow dtr2 in data2.Rows)
                        {
                            HOADON hd = new HOADON(dtr2);
                            this.btnBan3Tang2.BackColor = System.Drawing.Color.Lime;
                            this.tbKhachBan3Tang2.Text = Convert.ToString(ban.SoKhach_ToiDa - hd.SLKhach);
                            this.btnBan3Tang2.Click += BtnBan19_Click;
                            this.btnBan3Tang2.Tag = ban;
                        }
                    }
                    if (ban.MaB == 20)
                    {
                        string query2 = "SELECT * FROM hoadon where tinhtrang = 'false' and mab=" + ban.MaB;
                        DataTable data2 = provider.ExecuteQuery(query2);
                        foreach (DataRow dtr2 in data2.Rows)
                        {
                            HOADON hd = new HOADON(dtr2);
                            this.btnBan4Tang2.BackColor = System.Drawing.Color.Lime;
                            this.tbKhachBan4Tang2.Text = Convert.ToString(ban.SoKhach_ToiDa - hd.SLKhach);
                            this.btnBan4Tang2.Click += BtnBan20_Click;
                            this.btnBan4Tang2.Tag = ban;
                        }
                    }
                    if (ban.MaB == 21)
                    {
                        string query2 = "SELECT * FROM hoadon where tinhtrang = 'false' and mab=" + ban.MaB;
                        DataTable data2 = provider.ExecuteQuery(query2);
                        foreach (DataRow dtr2 in data2.Rows)
                        {
                            HOADON hd = new HOADON(dtr2);
                            this.btnBan5Tang2.BackColor = System.Drawing.Color.Lime;
                            this.tbKhachBan5Tang2.Text = Convert.ToString(ban.SoKhach_ToiDa - hd.SLKhach);
                            this.btnBan5Tang2.Click += BtnBan21_Click;
                            this.btnBan5Tang2.Tag = ban;
                        }
                    }
                    if (ban.MaB == 22)
                    {
                        string query2 = "SELECT * FROM hoadon where tinhtrang = 'false' and mab=" + ban.MaB;
                        DataTable data2 = provider.ExecuteQuery(query2);
                        foreach (DataRow dtr2 in data2.Rows)
                        {
                            HOADON hd = new HOADON(dtr2);
                            this.btnBan6Tang2.BackColor = System.Drawing.Color.Lime;
                            this.tbKhachBan6Tang2.Text = Convert.ToString(ban.SoKhach_ToiDa - hd.SLKhach);
                            this.btnBan6Tang2.Click += BtnBan22_Click;
                            this.btnBan6Tang2.Tag = ban;
                        }
                    }
                    if (ban.MaB == 23)
                    {
                        string query2 = "SELECT * FROM hoadon where tinhtrang = 'false' and mab=" + ban.MaB;
                        DataTable data2 = provider.ExecuteQuery(query2);
                        foreach (DataRow dtr2 in data2.Rows)
                        {
                            HOADON hd = new HOADON(dtr2);
                            this.btnBan7Tang2.BackColor = System.Drawing.Color.Lime;
                            this.tbKhachBan7Tang2.Text = Convert.ToString(ban.SoKhach_ToiDa - hd.SLKhach);
                            this.btnBan7Tang2.Click += BtnBan23_Click;
                            this.btnBan7Tang2.Tag = ban;
                        }
                    }
                    if (ban.MaB == 24)
                    {
                        string query2 = "SELECT * FROM hoadon where tinhtrang = 'false' and mab=" + ban.MaB;
                        DataTable data2 = provider.ExecuteQuery(query2);
                        foreach (DataRow dtr2 in data2.Rows)
                        {
                            HOADON hd = new HOADON(dtr2);
                            this.btnBan8Tang2.BackColor = System.Drawing.Color.Lime;
                            this.tbKhachBan8Tang2.Text = Convert.ToString(ban.SoKhach_ToiDa - hd.SLKhach);
                            this.btnBan8Tang2.Click += BtnBan24_Click;
                            this.btnBan8Tang2.Tag = ban;
                        }
                    }
                    if (ban.MaB == 25)
                    {
                        string query2 = "SELECT * FROM hoadon where tinhtrang = 'false' and mab=" + ban.MaB;
                        DataTable data2 = provider.ExecuteQuery(query2);
                        foreach (DataRow dtr2 in data2.Rows)
                        {
                            HOADON hd = new HOADON(dtr2);
                            this.btnBan9Tang2.BackColor = System.Drawing.Color.Lime;
                            this.tbKhachBan9Tang2.Text = Convert.ToString(ban.SoKhach_ToiDa - hd.SLKhach);
                            this.btnBan9Tang2.Click += BtnBan25_Click;
                            this.btnBan9Tang2.Tag = ban;
                        }
                    }
                    if (ban.MaB == 26)
                    {
                        string query2 = "SELECT * FROM hoadon where tinhtrang = 'false' and mab=" + ban.MaB;
                        DataTable data2 = provider.ExecuteQuery(query2);
                        foreach (DataRow dtr2 in data2.Rows)
                        {
                            HOADON hd = new HOADON(dtr2);
                            this.btnBan10Tang2.BackColor = System.Drawing.Color.Lime;
                            this.tbKhachBan10Tang2.Text = Convert.ToString(ban.SoKhach_ToiDa - hd.SLKhach);
                            this.btnBan10Tang2.Click += BtnBan26_Click;
                            this.btnBan10Tang2.Tag = ban;
                        }
                    }
                    if (ban.MaB == 27)
                    {
                        string query2 = "SELECT * FROM hoadon where tinhtrang = 'false' and mab=" + ban.MaB;
                        DataTable data2 = provider.ExecuteQuery(query2);
                        foreach (DataRow dtr2 in data2.Rows)
                        {
                            HOADON hd = new HOADON(dtr2);
                            this.btnBan11Tang2.BackColor = System.Drawing.Color.Lime;
                            this.tbKhachBan11Tang2.Text = Convert.ToString(ban.SoKhach_ToiDa - hd.SLKhach);
                            this.btnBan11Tang2.Click += BtnBan27_Click;
                            this.btnBan11Tang2.Tag = ban;
                        }
                    }
                    if (ban.MaB == 28)
                    {
                        string query2 = "SELECT * FROM hoadon where tinhtrang = 'false' and mab=" + ban.MaB;
                        DataTable data2 = provider.ExecuteQuery(query2);
                        foreach (DataRow dtr2 in data2.Rows)
                        {
                            HOADON hd = new HOADON(dtr2);
                            this.btnBan12Tang2.BackColor = System.Drawing.Color.Lime;
                            this.tbKhachBan12Tang2.Text = Convert.ToString(ban.SoKhach_ToiDa - hd.SLKhach);
                            this.btnBan12Tang2.Click += BtnBan28_Click;
                            this.btnBan12Tang2.Tag = ban;
                        }
                    }
                }
                if (ban.TinhTrang == 3)
                {
                    if (ban.MaB == 1)
                    {
                        this.btnBan1.BackColor = System.Drawing.Color.Red;
                        this.tbKhachBan1.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan1.Click += BtnBan1_Click;
                        this.btnBan1.Tag = ban;
                    }
                    if (ban.MaB == 2)
                    {
                        this.btnBan2.BackColor = System.Drawing.Color.Red;
                        this.tbKhachBan2.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan2.Click += BtnBan2_Click;
                        this.btnBan2.Tag = ban;
                    }
                    if (ban.MaB == 3)
                    {
                        this.btnBan3.BackColor = System.Drawing.Color.Red;
                        this.tbKhachBan3.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan3.Click += BtnBan3_Click;
                        this.btnBan3.Tag = ban;
                    }
                    if (ban.MaB == 4)
                    {
                        this.btnBan4.BackColor = System.Drawing.Color.Red;
                        this.tbKhachBan4.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan4.Click += BtnBan4_Click;
                        this.btnBan4.Tag = ban;
                    }
                    if (ban.MaB == 5)
                    {
                        this.btnBan5.BackColor = System.Drawing.Color.Red;
                        this.tbKhachBan5.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan5.Click += BtnBan5_Click;
                        this.btnBan5.Tag = ban;
                    }
                    if (ban.MaB == 6)
                    {
                        this.btnBan6.BackColor = System.Drawing.Color.Red;
                        this.tbKhachBan6.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan6.Click += BtnBan6_Click;
                        this.btnBan6.Tag = ban;
                    }
                    if (ban.MaB == 7)
                    {
                        this.btnBan7.BackColor = System.Drawing.Color.Red;
                        this.tbKhachBan7.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan7.Click += BtnBan7_Click;
                        this.btnBan7.Tag = ban;
                    }
                    if (ban.MaB == 8)
                    {
                        this.btnBan8.BackColor = System.Drawing.Color.Red;
                        this.tbKhachBan8.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan8.Click += BtnBan8_Click;
                        this.btnBan8.Tag = ban;
                    }
                    if (ban.MaB == 9)
                    {
                        this.btnBan9.BackColor = System.Drawing.Color.Red;
                        this.tbKhachBan9.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan9.Click += BtnBan9_Click;
                        this.btnBan9.Tag = ban;
                    }
                    if (ban.MaB == 10)
                    {
                        this.btnBan10.BackColor = System.Drawing.Color.Red;
                        this.tbKhachBan10.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan10.Click += BtnBan10_Click;
                        this.btnBan10.Tag = ban;
                    }
                    if (ban.MaB == 11)
                    {
                        this.btnBan11.BackColor = System.Drawing.Color.Red;
                        this.tbKhachBan11.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan11.Click += BtnBan11_Click;
                        this.btnBan11.Tag = ban;
                    }
                    if (ban.MaB == 12)
                    {
                        this.btnBan12.BackColor = System.Drawing.Color.Red;
                        this.tbKhachBan12.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan12.Click += BtnBan12_Click;
                        this.btnBan12.Tag = ban;
                    }
                    if (ban.MaB == 13)
                    {
                        this.btnBan13.BackColor = System.Drawing.Color.Red;
                        this.tbKhachBan13.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan13.Click += BtnBan13_Click;
                        this.btnBan13.Tag = ban;
                    }
                    if (ban.MaB == 14)
                    {
                        this.btnBan14.BackColor = System.Drawing.Color.Red;
                        this.tbKhachBan14.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan14.Click += BtnBan14_Click;
                        this.btnBan14.Tag = ban;
                    }
                    if (ban.MaB == 15)
                    {
                        this.btnBan15.BackColor = System.Drawing.Color.Red;
                        this.tbKhachBan15.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan15.Click += BtnBan15_Click;
                        this.btnBan15.Tag = ban;
                    }
                    if (ban.MaB == 16)
                    {
                        this.btnBan16.BackColor = System.Drawing.Color.Red;
                        this.tbKhachBan16.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan16.Click += BtnBan16_Click;
                        this.btnBan16.Tag = ban;
                        this.tbKhachBan16.Tag = ban;
                    }
                    if (ban.MaB == 17)
                    {
                        this.btnBan1Tang2.BackColor = System.Drawing.Color.Red;
                        this.tbKhachBan1Tang2.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan1Tang2.Click += BtnBan17_Click;
                        this.btnBan1Tang2.Tag = ban;
                        this.tbKhachBan1Tang2.Tag = ban;
                    }
                    if (ban.MaB == 18)
                    {
                        this.btnBan2Tang2.BackColor = System.Drawing.Color.Red;
                        this.tbKhachBan2Tang2.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan2Tang2.Click += BtnBan18_Click;
                        this.btnBan2Tang2.Tag = ban;
                        this.tbKhachBan2Tang2.Tag = ban;
                    }
                    if (ban.MaB == 19)
                    {
                        this.btnBan3Tang2.BackColor = System.Drawing.Color.Red;
                        this.tbKhachBan3Tang2.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan3Tang2.Click += BtnBan19_Click;
                        this.btnBan3Tang2.Tag = ban;
                        this.tbKhachBan3Tang2.Tag = ban;
                    }
                    if (ban.MaB == 20)
                    {
                        this.btnBan4Tang2.BackColor = System.Drawing.Color.Red;
                        this.tbKhachBan4Tang2.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan4Tang2.Click += BtnBan20_Click;
                        this.btnBan4Tang2.Tag = ban;
                        this.tbKhachBan4Tang2.Tag = ban;
                    }
                    if (ban.MaB == 21)
                    {
                        this.btnBan5Tang2.BackColor = System.Drawing.Color.Red;
                        this.tbKhachBan5Tang2.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan5Tang2.Click += BtnBan21_Click;
                        this.btnBan5Tang2.Tag = ban;
                        this.tbKhachBan5Tang2.Tag = ban;
                    }
                    if (ban.MaB == 22)
                    {
                        this.btnBan6Tang2.BackColor = System.Drawing.Color.Red;
                        this.tbKhachBan6Tang2.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan6Tang2.Click += BtnBan22_Click;
                        this.btnBan6Tang2.Tag = ban;
                        this.tbKhachBan6Tang2.Tag = ban;
                    }
                    if (ban.MaB == 23)
                    {
                        this.btnBan7Tang2.BackColor = System.Drawing.Color.Red;
                        this.tbKhachBan7Tang2.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan7Tang2.Click += BtnBan23_Click;
                        this.btnBan7Tang2.Tag = ban;
                        this.tbKhachBan7Tang2.Tag = ban;
                    }
                    if (ban.MaB == 24)
                    {
                        this.btnBan8Tang2.BackColor = System.Drawing.Color.Red;
                        this.tbKhachBan8Tang2.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan8Tang2.Click += BtnBan24_Click;
                        this.btnBan8Tang2.Tag = ban;
                        this.tbKhachBan8Tang2.Tag = ban;
                    }
                    if (ban.MaB == 25)
                    {
                        this.btnBan9Tang2.BackColor = System.Drawing.Color.Red;
                        this.tbKhachBan9Tang2.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan9Tang2.Click += BtnBan25_Click;
                        this.btnBan9Tang2.Tag = ban;
                        this.tbKhachBan9Tang2.Tag = ban;
                    }
                    if (ban.MaB == 26)
                    {
                        this.btnBan10Tang2.BackColor = System.Drawing.Color.Red;
                        this.tbKhachBan10Tang2.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan10Tang2.Click += BtnBan26_Click;
                        this.btnBan10Tang2.Tag = ban;
                        this.tbKhachBan10Tang2.Tag = ban;
                    }
                    if (ban.MaB == 27)
                    {
                        this.btnBan11Tang2.BackColor = System.Drawing.Color.Red;
                        this.tbKhachBan11Tang2.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan11Tang2.Click += BtnBan27_Click;
                        this.btnBan11Tang2.Tag = ban;
                        this.tbKhachBan11Tang2.Tag = ban;
                    }
                    if (ban.MaB == 28)
                    {
                        this.btnBan12Tang2.BackColor = System.Drawing.Color.Red;
                        this.tbKhachBan12Tang2.Text = Convert.ToString(ban.SoKhach_ToiDa);
                        this.btnBan12Tang2.Click += BtnBan28_Click;
                        this.btnBan12Tang2.Tag = ban;
                        this.tbKhachBan12Tang2.Tag = ban;
                    }
                }
            }

        }

        private void BtnBan28_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as BANAN).MaB;
            this.lvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }
        private void BtnBan27_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as BANAN).MaB;
            this.lvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }
        private void BtnBan26_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as BANAN).MaB;
            this.lvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }
        private void BtnBan25_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as BANAN).MaB;
            this.lvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }
        private void BtnBan24_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as BANAN).MaB;
            this.lvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }
        private void BtnBan23_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as BANAN).MaB;
            this.lvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }
        private void BtnBan22_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as BANAN).MaB;
            this.lvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }
        private void BtnBan21_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as BANAN).MaB;
            this.lvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }
        private void BtnBan20_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as BANAN).MaB;
            this.lvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }
        private void BtnBan19_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as BANAN).MaB;
            this.lvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }
        private void BtnBan18_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as BANAN).MaB;
            this.lvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }
        private void BtnBan17_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as BANAN).MaB;
            this.lvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }
        private void BtnBan16_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as BANAN).MaB;
            this.lvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }

        private void BtnBan15_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as BANAN).MaB;
            this.lvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }

        private void BtnBan14_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as BANAN).MaB;
            this.lvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }

        private void BtnBan13_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as BANAN).MaB;
            this.lvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }

        private void BtnBan12_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as BANAN).MaB;
            this.lvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }

        private void BtnBan11_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as BANAN).MaB;
            this.lvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }

        private void BtnBan10_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as BANAN).MaB;
            this.lvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }

        private void BtnBan9_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as BANAN).MaB;
            this.lvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }

        private void BtnBan8_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as BANAN).MaB;
            this.lvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }

        private void BtnBan7_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as BANAN).MaB;
            this.lvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }

        private void BtnBan6_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as BANAN).MaB;
            this.lvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }

        private void BtnBan5_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as BANAN).MaB;
            this.lvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }

        private void BtnBan4_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as BANAN).MaB;
            this.lvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }

        private void BtnBan3_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as BANAN).MaB;
            this.lvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }

        private void BtnBan2_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as BANAN).MaB;
            this.lvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }

        private void BtnBan1_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as BANAN).MaB;
            this.lvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }

        void ShowBill(int id)
        {

            lvBill.Items.Clear();
            CultureInfo culture = new CultureInfo("vi-VN");
            List<MENU> listCTHD = MenuInfras.Instance.GetListMenuByTable(id);
            decimal totalPrice = 0;
            foreach (MENU item in listCTHD)
            {
                ListViewItem lsvItem = new ListViewItem(item.TenMon.ToString());
                lsvItem.SubItems.Add(item.DonGia.ToString("c", culture));
                lsvItem.SubItems.Add(item.SLMon.ToString());
                lsvItem.SubItems.Add(item.TongTien.ToString("c", culture));
                totalPrice += item.TongTien;
                lvBill.Items.Add(lsvItem);
            }
            total = totalPrice;
            txtTotalPrice.Text = totalPrice.ToString("c", culture);

        }


        private void btnAddFood_Click(object sender, EventArgs e)
        {

            BANAN banan = lvBill.Tag as BANAN;

            string manv = this.loginAccount.MaNV;
            int mab = banan.MaB;
            string makm = this.cbDisscount.SelectedValue.ToString();
            int slkhach = (int)this.nudAddSoKhach.Value;

            string mamon = (this.cbFood.SelectedItem as MONAN).MaM;
            int slmon = (int)this.nrCountFood.Value;
            decimal dongia = (this.cbFood.SelectedItem as MONAN).Gia;
            decimal tongtien = slmon * dongia;

            string maHD = HoaDonInfras.Instance.GetUncheckBillIdByTableId(banan.MaB);

            if (maHD == "-1")
            {
                if (slkhach > banan.SoKhach_ToiDa)
                {

                    MessageBox.Show("Số khách không được lớn hơn " + banan.SoKhach_ToiDa, "Thông báo", MessageBoxButtons.OK);
                }
                else if (slmon <= 0)
                {
                    MessageBox.Show("Số lượng món phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    HoaDonInfras.Instance.InsertHoaDon(manv, mab, makm, slkhach,DateTime.Now);
                    CTHDInfras.Instance.InsertCTHD(HoaDonInfras.Instance.getMaxIdHD(),banan.MaB, mamon, slmon, tongtien);
                    BanAnInfras.Instance.SuaBanAn(mab, banan.SoKhach_ToiDa, 2);
                    LoadData();
                    LoadTable();
                    ShowBill(mab);
                }
            }
            else
            {
                List<CTHD> dscthd = CTHDInfras.Instance.GetListCTHD(maHD);
                int flag = 0;
                int slmonTemp = 0;
                if (dscthd.Count == 0 && slmon <= 0)
                {
                    MessageBox.Show("Số lượng món phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    foreach (CTHD cthd in dscthd)
                    {
                        if (cthd.MaM == mamon)
                        {
                            flag = 1;
                            slmonTemp = cthd.SLMon + slmon;
                            if (slmonTemp < 0)
                            {
                                flag = -1;
                                MessageBox.Show("Số lượng món không được nhỏ hơn 0", "Thông báo", MessageBoxButtons.OK);
                            }
                            if (slmonTemp == 0)
                            {
                                flag = -1;
                                CTHDInfras.Instance.DeleteCTHD(maHD, mamon,banan.MaB);
                            }
                        }
                        else if (slmon <= 0)
                        {
                            flag = -1;
                            MessageBox.Show("Số lượng món phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK);
                        }
                    }
                    if (flag == 1)
                    {
                        CTHDInfras.Instance.UpdateSLMonCTHD(maHD,banan.MaB, mamon, slmonTemp, tongtien);
                    }
                    if (flag == 0)
                    {
                        CTHDInfras.Instance.InsertCTHD(maHD,banan.MaB, mamon, slmon, tongtien);
                    }
                    if (flag == -1) { }
                    LoadData();
                    LoadTable();
                    ShowBill(mab);
                }

            }

        }

        private void btnAddSoKhach_Click(object sender, EventArgs e)
        {

            BANAN banan = lvBill.Tag as BANAN;
            string manv = this.loginAccount.MaNV;
            int mab = banan.MaB;
            string makm = this.cbDisscount.SelectedItem.ToString();
            int slkhach = (int)this.nudAddSoKhach.Value;

            string maHD = HoaDonInfras.Instance.GetUncheckBillIdByTableId(banan.MaB);

            if (maHD == "-1")
            {
                BanAnInfras.Instance.SuaBanAn(banan.MaB, banan.SoKhach_ToiDa, 2);
            }
            else
            {
                if (slkhach > banan.SoKhach_ToiDa)
                {

                    MessageBox.Show("Số khách không được lớn hơn " + banan.SoKhach_ToiDa, "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    HoaDonInfras.Instance.SuaSLKhachHoaDon(maHD,mab, slkhach);
                }
            }
            LoadData();
            LoadTable();
            ShowBill(banan.MaB);

        }


        public void btnReLoad_Click(object sender, EventArgs e)
        {
            LoadTable();
            LoadData();
        }

        private void btnSwitchTable_Click(object sender, EventArgs e)
        {

            BANAN banan = lvBill.Tag as BANAN;
            int maBanMoi = Convert.ToInt32(this.cbSwitchTable.SelectedValue.ToString());
            string maHD = HoaDonInfras.Instance.GetUncheckBillIdByTableId(banan.MaB);
            List<MENU> listCTHD = MenuInfras.Instance.GetListMenuByTable(banan.MaB);
            int SoKhachBanHienTai = HoaDonInfras.Instance.LaySoKhachHD(banan.MaB);
            int SoKhachToiDaBanMoi = BanAnInfras.Instance.LaySoKhachToiDa(maBanMoi);
            if (listCTHD.Count == 0)
            {
                MessageBox.Show("Hãy chọn bàn cần chuyển", "Thông báo", MessageBoxButtons.OK);
            }
            else if (SoKhachBanHienTai > SoKhachToiDaBanMoi)
            {
                MessageBox.Show("Số khách(" + SoKhachBanHienTai + ") không phù hợp với bàn này(" + SoKhachToiDaBanMoi + ")", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                BanAnInfras.Instance.SuaBanAn(banan.MaB, banan.SoKhach_ToiDa, 1);
                BanAnInfras.Instance.SwitchTable(maBanMoi, 2);
                string manv = this.loginAccount.MaNV;
                string makm = this.cbDisscount.SelectedValue.ToString(); 
                HoaDonInfras.Instance.SwitchTable(maHD,manv,banan.MaB, maBanMoi,1,makm);
                lvBill.Items.Clear();
                LoadData();
                LoadTable();
            }

        }

        private void btnGopBan_Click(object sender, EventArgs e)
        {

            BANAN banan = lvBill.Tag as BANAN;
            if (banan != null)
            {
                string maHD = HoaDonInfras.Instance.GetUncheckBillIdByTableId(banan.MaB);

                int maBanGop = Convert.ToInt32(this.cmbGopBan.SelectedValue.ToString());
                string maHDBanGop = HoaDonInfras.Instance.GetUncheckBillIdByTableId(maBanGop);

                if (maHD != "-1")
                {
                    List<MENU> listCTHD = MenuInfras.Instance.GetListMenuByTable(banan.MaB);

                    if (maHDBanGop != "-1")
                    {
                        // List<MENU> listCTHDBanGop = MenuInfras.Instance.GetListMenuByTable(maBanGop);
                        MessageBox.Show("Cả hai bàn đều đang mở", "Thông báo");
                    }
                    else
                    {
                        if (banan.MaB == maBanGop)
                        {
                            MessageBox.Show("Bàn cần gộp trùng với bàn hiện tại", "Thông báo");
                        }
                        else if ((banan.MaB <= 16 && maBanGop > 16) || (banan.MaB > 16 && maBanGop <= 16))
                        {
                            MessageBox.Show("Bàn cần gộp phải chung tầng", "Thông báo");
                        }
                        else
                        {
                            string manv = this.loginAccount.MaNV;
                            string makm = this.cbDisscount.SelectedValue.ToString();
                            int slkhach = (int)this.nudAddSoKhach.Value;

                            HoaDonInfras.Instance.InsertHoaDonGop(maHD, manv, maBanGop, makm, slkhach);
                            BanAnInfras.Instance.SwitchTable(maBanGop, 2);

                            LoadData();
                            LoadTable();
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Ban " + banan.MaB + " chưa mở", "Thông báo");
                }
            }
            else MessageBox.Show("Chọn chưa chọn bàn ăn chính", "Thông báo");

        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {

            BANAN banan = lvBill.Tag as BANAN;
            string maHD = HoaDonInfras.Instance.GetUncheckBillIdByTableId(banan.MaB);

            lvBill.Items.Clear();
            List<MENU> listCTHD = MenuInfras.Instance.GetListMenuByTable(banan.MaB);
            decimal totalPrice = 0;
            foreach (MENU item in listCTHD)
            {
                totalPrice += item.TongTien;
            }
            cbDisscount.ValueMember = "PhanTramKM";
            decimal discount = Convert.ToDecimal(this.cbDisscount.SelectedValue.ToString());
            totalPrice = (totalPrice / 100) * (100 - discount);
            cbDisscount.ValueMember = "MAKM";
            decimal tongthanhtoan = Convert.ToDecimal(totalPrice.ToString());

            if (maHD != "-1")
            {
                if (banan.MaB <= 16)
                {
                    if (MessageBox.Show("Bạn có chắc thanh toán cho bàn " + banan.MaB, "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        string makm = this.cbDisscount.SelectedValue.ToString();
                        HoaDonInfras.Instance.CheckOut(maHD, tongthanhtoan,makm);
                        ShowBill(banan.MaB);
                        LoadData();
                        LoadTable();
                    }
                }
                if (banan.MaB > 16)
                {
                    int maBanTemp = banan.MaB - 16;
                    if (MessageBox.Show("Bạn có chắc thanh toán cho bàn " + maBanTemp, "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        string makm = this.cbDisscount.SelectedValue.ToString();
                        HoaDonInfras.Instance.CheckOut(maHD, tongthanhtoan,makm);
                        ShowBill(banan.MaB);
                        LoadData();
                        LoadTable();
                    }
                }
            }

        }

        private void bnProvisional_Click(object sender, EventArgs e)
        {

            BANAN banan = lvBill.Tag as BANAN;
            if (banan != null)
            {
                string maHD = HoaDonInfras.Instance.GetUncheckBillIdByTableId(banan.MaB);
                if (maHD != "-1")
                {
                    fInHoaDon f = new fInHoaDon();
                    f.LoadSoHD = maHD;
                    f.LoadTenNV = loginAccount.HoTenNV;
                    f.LoadLVBill = this.lvBill;
                    f.MaB = banan.MaB;
                    cbDisscount.ValueMember = "PhanTramKM";
                    f.LoadKM = this.cbDisscount.SelectedValue.ToString();
                    f.ShowDialog();
                    this.Show();
                    cbDisscount.ValueMember = "MAKM";
                }
                else MessageBox.Show("Bàn ăn chưa có bill", "Thông báo");
            }
            else MessageBox.Show("Chưa chọn bàn ăn", "Thông báo");
        }

        private void cbDisscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDisscount.ValueMember = "PhanTramKM";
            decimal discount = Convert.ToDecimal(this.cbDisscount.SelectedValue.ToString());
            total = (total / 100) * (100 - discount);
            txtTotalPrice.Text = total.ToString("c", new CultureInfo("vi-VN"));
            cbDisscount.ValueMember = "MAKM";
        }
    }
}