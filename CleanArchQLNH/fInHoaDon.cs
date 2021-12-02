using Domain.Entities;
using Infrastructure.Persistence;
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

namespace CleanArchQLNH
{
    public partial class fInHoaDon : Form
    {
        private string _loadSoHD;
        private DateTime _ngayHD = DateTime.Now;
        private string _loadTenNV;
        private ListView _loadLVBill;
        private int _maB;
        private string _loadKM;
        private int _disablePrint;

        private BANAN _banan;

        public fInHoaDon()
        {
            InitializeComponent();
        }

        public string LoadSoHD { get => _loadSoHD; set => _loadSoHD = value; }
        public DateTime NgayHD { get => _ngayHD; set => _ngayHD = value; }
        public string LoadTenNV { get => _loadTenNV; set => _loadTenNV = value; }
        public ListView LoadLVBill { get => _loadLVBill; set => _loadLVBill = value; }
        public int MaB { get => _maB; set => _maB = value; }
        public string LoadKM { get => _loadKM; set => _loadKM = value; }
        public int DisablePrint { get => _disablePrint; set => _disablePrint = value; }
        public BANAN Banan { get => _banan; set => _banan = value; }

        CultureInfo culture = new CultureInfo("vi-VN");
        private void fInHoaDon_Load(object sender, EventArgs e)
        {

            lvPrintBill.Items.Clear();
            txtBillID.Text = _loadSoHD;
            txtBillDate.Text = _ngayHD.ToString();
            txtStaffName.Text = _loadTenNV;
            int ptKM = Convert.ToInt32(_loadKM);

            List<MENU> listCTHD = MenuInfras.Instance.GetListMenuByTable(_maB);
            decimal totalPrice = 0;
            foreach (MENU item in listCTHD)
            {
                decimal tt = item.TongTien - item.TongTien * ptKM / 100;
                ListViewItem lsvItem = new ListViewItem(item.TenMon.ToString());
                lsvItem.SubItems.Add(item.SLMon.ToString());
                lsvItem.SubItems.Add(item.DonGia.ToString("c", culture));
                lsvItem.SubItems.Add(_loadKM);
                lsvItem.SubItems.Add(tt.ToString("c", culture));

                totalPrice += item.TongTien;
                lvPrintBill.Items.Add(lsvItem);
            }
            txtTotalPrice.Text = (totalPrice - totalPrice * ptKM / 100).ToString("c", culture);
            txtCustomerGive.Text = (Convert.ToInt32(totalPrice - totalPrice * ptKM / 100)).ToString();
            txtExcessCash.Text = 0.ToString("c", culture);
        }

        private void btnPrintBill_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void txtCustomerGive_LostFocus(object sender, EventArgs e)
        {

            List<MENU> listCTHD = MenuInfras.Instance.GetListMenuByTable(_maB);
            decimal totalPrice = 0;
            int ptKM = Convert.ToInt32(_loadKM);
            foreach (MENU item in listCTHD)
            {
                totalPrice += item.TongTien;
            }
            txtExcessCash.Text = (Convert.ToDecimal(txtCustomerGive.Text) - (totalPrice - totalPrice * ptKM / 100)).ToString("c", culture);
        }
    }
}
