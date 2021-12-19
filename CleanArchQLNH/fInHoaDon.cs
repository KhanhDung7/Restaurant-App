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
        private string makm;
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
            List<MENU> listCTHD = MenuInfras.Instance.GetListMenuByTable(_maB);
            decimal totalPrice = 0;
            int ptKM = Convert.ToInt32(_loadKM);
            string tongtien = txtTotalPrice.Text;
            string tienmat = txtCustomerGive.Text;
            string tienthua = txtExcessCash.Text;
            xuatHoaDonPDF(_loadSoHD, _loadTenNV, ptKM, listCTHD, tongtien, tienmat, tienthua);

            this.Close();
        }

        private void txtCustomerGive_LostFocus(object sender, EventArgs e)
        {
            //nothing
        }
        public void xuatHoaDonPDF(string mahd,string tennv,int ptKM,List<MENU> menu,string tongtien,string tienmat,string tienthua)
        {
            string htmlString = "<!DOCTYPE html><html lang='en'><head><meta charset='UTF-8'><meta name='viewport' content='width=device-width, initial-scale=1.0'><title>HOADON</title></head><body><div align = 'center' >";
            htmlString = "<div><h1>DIAMOND RESTAURANT</h1></div><div><p>273 AN DƯƠNG VƯƠNG, PHƯỜNG 3,QUẬN 5</p></div><div><h1>HÓA ĐƠN THANH TOÁN</h1></div><div><p>Mã hóa đơn : ";
            htmlString += mahd;
            htmlString += "</p><p>Ngày : ";
            htmlString += DateTime.Now.ToString("yyyy/MM/dd HH:mm");
            htmlString += "</p><p>Tên Nhân Viên : ";
            htmlString += tennv;
            htmlString += "</p></div><div><table style='width:500px;border: 1px solid black;border-collapse: collapse;'><tr style='border: 1px solid black;border-collapse: collapse;'><td style='border: 1px solid black;border-collapse: collapse;'>Tên món</td><td style='border: 1px solid black;border-collapse: collapse;'>Số lượng</td><td style='border: 1px solid black;border-collapse: collapse;'>Đơn giá</td><td style='border: 1px solid black;border-collapse: collapse;'>% KM</td><td style='border: 1px solid black;border-collapse: collapse;'>Thành Tiền</td></tr>";
            foreach (MENU item in menu)
            {
                decimal tt = item.TongTien - item.TongTien * ptKM / 100;
                htmlString += "<tr style='border: 1px solid black;border-collapse: collapse;'><td  style='border: 1px solid black;border-collapse: collapse;'>";
                htmlString += item.TenMon.ToString();
                htmlString += "</td'><td  style='border: 1px solid black;border-collapse: collapse;'>";
                htmlString += item.SLMon.ToString();
                htmlString += "</td><td  style='border: 1px solid black;border-collapse: collapse;'>";
                htmlString += item.DonGia.ToString("c", culture);
                htmlString += "</td><td  style='border: 1px solid black;border-collapse: collapse;'>";
                htmlString += ptKM;
                htmlString += "</td><td style='border: 1px solid black;border-collapse: collapse;'>";
                htmlString += tt.ToString("c", culture);
                htmlString += "</td></tr>";
            }
            htmlString += "</table></div><div><p>Tổng thanh toán : ";
            htmlString += tongtien;
            htmlString += "</p><p>Tiền mặt : ";
            htmlString += float.Parse(tienmat).ToString("c", new CultureInfo("vi-VN"));
            htmlString += "</p><p>Tiền thừa : ";
            htmlString += tienthua;
            htmlString += "</p></div></div></body></html>";
            var Renderer = new IronPdf.ChromePdfRenderer();
            Renderer.RenderHtmlAsPdf(htmlString).SaveAs("HOADON_" + mahd + "_" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".pdf");
        }

        private void txtCustomerGive_TextChanged(object sender, EventArgs e)
        {
            List<MENU> listCTHD = MenuInfras.Instance.GetListMenuByTable(_maB);
            decimal totalPrice = 0;
            int ptKM = Convert.ToInt32(_loadKM);
            foreach (MENU item in listCTHD)
            {
                totalPrice += item.TongTien;
            }
            totalPrice = totalPrice - (totalPrice * ptKM / 100);
            decimal tienmat = decimal.Parse(txtCustomerGive.Text);
            decimal tienthua = tienmat - (totalPrice - (totalPrice * ptKM / 100));
            string mahd = txtBillID.Text;
            HoaDonInfras.Instance.SuaTienThanhToanHoaDon(mahd, tienmat, tienthua);
            txtExcessCash.Text = tienthua.ToString("c", culture);
            if(tienthua < 0 || tienmat<totalPrice) this.btnPrintBill.Enabled = false;
            else this.btnPrintBill.Enabled = true;
        }
    }
}
