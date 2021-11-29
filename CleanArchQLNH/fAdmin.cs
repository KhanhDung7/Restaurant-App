using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// using Domain.Entities;
// using Infrastructure.Persistence;

namespace CleanArchQLNH
{
    public partial class fAdmin : Form
    {
        // BindingSource staffList = new BindingSource();
        // BindingSource orderList = new BindingSource();
        // BindingSource tableList = new BindingSource();
         BindingSource foodList = new BindingSource();
        // BindingSource promotionList = new BindingSource();
        // //BindingSource positionList = new BindingSource();
        public fAdmin()
        {
            InitializeComponent();
            // LoadStaff();
            // LoadChuVu();
            // LoadOrder();
            // LoadTable();
            // LoadFood();
            // LoadPromotion();
        }
        //
        //LoadDatabase
        //
        // void LoadStaff()
        // {
        //     dtgvStaff.DataSource = staffList;
        //     LoadStaffListF();
        //     AddStaffBindingF();
        // }

        // void LoadChuVu()
        // {
        //     cmbStaffIdentity.DataSource = ChucVuInfras.Instance.LoadDSChucVu();
        //     cmbStaffIdentity.DisplayMember = "TenCV";
        //     cmbStaffIdentity.ValueMember = "MaCV";
        // }
        // void LoadOrder()
        // {
        //     dtgvOrderTable.DataSource = orderList;
        //     LoadOrderListF();
        //     AddOrderBindingF();
        // }
        // void LoadTable()
        // {
        //     dtgvTable.DataSource = tableList;
        //     LoadTableListF();
        //     AddTableBindingF();
        // }
        // void LoadFood()
        // {
        //     dtgvFood.DataSource = foodList;
        //     LoadFoodListF();
        //     AddFoodBindingF();
        // }
        // void LoadPromotion()
        // {
        //     dtgvPromotion.DataSource = promotionList;
        //     LoadPromotionListF();
        //     AddPromotionBindingF();
        // }
        //
        //Bill
        //
        // private void btnViewBill_Click(object sender, EventArgs e)
        // {
        //     string ngay = cmbDaysInViewBill.Text;
        //     string thang = cmbMonthsInViewBill.Text;
        //     string nam = cmbYearsInViewBill.Text;

        //     if(ngay.Replace(" ", "") != "")
        //     {
        //         if (Int32.Parse(ngay.ToString().Replace(" ", "")) < 10)
        //         {
        //             ngay = "0" + ngay;
        //         }
        //     }
            
        //     if(thang.Replace(" ", "") != "")
        //     {
        //         if (Int32.Parse(thang.ToString().Replace(" ", "")) < 10)
        //         {
        //             thang = "0" + thang;
        //         }
        //     }

        //     if (ngay.Replace(" ","") == "" && thang.Replace(" ", "") == "" && nam.Replace(" ", "") == "")
        //     {
        //         MessageBox.Show("Hãy chọn ngày cần thống kê", "Thông báo");
        //     }
        //     else if (ngay.Replace(" ", "") == "" && thang.Replace(" ", "") == "" && nam.Replace(" ", "") != "")
        //     {
        //         dtgvBill.DataSource = ThongKeInfras.Instance.LoadThongKeNam(nam);
        //         dtgvBill.Columns[0].HeaderText = "Thời gian";
        //         dtgvBill.Columns[0].Width = 100;
        //         dtgvBill.Columns[1].HeaderText = "Tổng doanh thu";
        //         dtgvBill.Columns[1].Width = 70;
        //         dtgvBill.Columns[2].HeaderText = "Món bán chạy";
        //         dtgvBill.Columns[2].Width = 150;
        //         dtgvBill.Columns[3].HeaderText = "Tổng số order";
        //         dtgvBill.Columns[3].Width = 70;
        //         dtgvBill.Columns[4].HeaderText = "Chương trình khuyến mãi";
        //         dtgvBill.Columns[4].Width = 150;
        //         dtgvBill.Columns[5].HeaderText = "Số lần áp dụng";
        //         dtgvBill.Columns[5].Width = 70;
        //         dtgvBill.Columns[6].HeaderText = "Tổng lương nhân viên";
        //         dtgvBill.Columns[6].Width = 70;
        //     }
        //     else if (ngay.Replace(" ", "") == "" && thang.Replace(" ", "") != "" && nam.Replace(" ", "") != "")
        //     {
        //         dtgvBill.DataSource = ThongKeInfras.Instance.LoadThongKeThang(thang, nam);
        //         dtgvBill.Columns[0].HeaderText = "Thời gian";
        //         dtgvBill.Columns[0].Width = 100;
        //         dtgvBill.Columns[1].HeaderText = "Tổng doanh thu";
        //         dtgvBill.Columns[1].Width = 70;
        //         dtgvBill.Columns[2].HeaderText = "Món bán chạy";
        //         dtgvBill.Columns[2].Width = 150;
        //         dtgvBill.Columns[3].HeaderText = "Tổng số order";
        //         dtgvBill.Columns[3].Width = 70;
        //         dtgvBill.Columns[4].HeaderText = "Chương trình khuyến mãi";
        //         dtgvBill.Columns[4].Width = 150;
        //         dtgvBill.Columns[5].HeaderText = "Số lần áp dụng";
        //         dtgvBill.Columns[5].Width = 70;
        //         dtgvBill.Columns[6].HeaderText = "Tổng lương nhân viên";
        //         dtgvBill.Columns[6].Width = 70;
        //     }
        //     else if (ngay.Replace(" ", "") != "" && thang.Replace(" ", "") == "" && nam.Replace(" ", "") != "")
        //     {
        //         MessageBox.Show("Hãy chọn tháng cần thống kê", "Thông báo");
        //     }
        //     else if (ngay.Replace(" ", "") != "" && thang.Replace(" ", "") != "" && nam.Replace(" ", "") == "")
        //     {
        //         MessageBox.Show("Hãy chọn năm cần thống kê", "Thông báo");
        //     }
        //     else if (ngay.Replace(" ", "") == "" && thang.Replace(" ", "") != "" && nam.Replace(" ", "") == "")
        //     {
        //         MessageBox.Show("Hãy chọn ngày và năm cần thống kê", "Thông báo");
        //     }
        //     else if (ngay.Replace(" ", "") != "" && thang.Replace(" ", "") == "" && nam.Replace(" ", "") == "")
        //     {
        //         MessageBox.Show("Hãy chọn tháng và năm cần thống kê", "Thông báo");
        //     }
        //     else if (ngay.Replace(" ", "") != "" && thang.Replace(" ", "") != "" && nam.Replace(" ", "") != "")
        //     {
        //         dtgvBill.DataSource = ThongKeInfras.Instance.LoadThongKeNgay(ngay, thang, nam);
        //         dtgvBill.Columns[0].HeaderText = "Thời gian";
        //         dtgvBill.Columns[0].Width = 100;
        //         dtgvBill.Columns[1].HeaderText = "Tổng doanh thu";
        //         dtgvBill.Columns[1].Width = 70;
        //         dtgvBill.Columns[2].HeaderText = "Món bán chạy";
        //         dtgvBill.Columns[2].Width = 150;
        //         dtgvBill.Columns[3].HeaderText = "Tổng số order";
        //         dtgvBill.Columns[3].Width = 70;
        //         dtgvBill.Columns[4].HeaderText = "Chương trình khuyến mãi";
        //         dtgvBill.Columns[4].Width = 150;
        //         dtgvBill.Columns[5].HeaderText = "Số lần áp dụng";
        //         dtgvBill.Columns[5].Width = 70;
        //         dtgvBill.Columns[6].HeaderText = "Tổng lương nhân viên";
        //         dtgvBill.Columns[6].Width = 70;
        //     }
            
        // }
        // //
        // //Food
        // //
        //void LoadFoodListF()
        // {
        //    foodList.DataSource = MonAnInfras.Instance.LoadFoodList();
        // }
         void AddFoodBindingF()
         {
             txtIDFood.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "mam", true, DataSourceUpdateMode.Never));
             txtFoodName.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "tenm", true, DataSourceUpdateMode.Never));
             txtFoodPrice.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "gia", true, DataSourceUpdateMode.Never));
             dtgvFood.Columns[0].HeaderText = "Mã món ăn";
             dtgvFood.Columns[0].Width = 100;
             dtgvFood.Columns[1].HeaderText = "Tên món ăn";
             dtgvFood.Columns[1].Width = 150;
             dtgvFood.Columns[2].HeaderText = "Giá";
             dtgvFood.Columns[2].Width = 100;
             dtgvFood.Columns[3].Visible = false;
          }
        // //
        // //EventFood
        // //
         private void txtFoodName_KeyDown(object sender, KeyEventArgs e)
         {
             if (e.KeyCode == Keys.Enter) txtFoodPrice.Focus();
             if (e.KeyCode == Keys.Down) txtFoodPrice.Focus();
         }
         private void txtFoodPrice_KeyDown(object sender, KeyEventArgs e)
         {
             if (e.KeyCode == Keys.Up) txtFoodName.Focus();
         }
        // //
        // //ActionFood
        // //
         private void btnAddFood_Click(object sender, EventArgs e)
         {

            // List<MONAN> dsmonan = MonAnInfras.Instance.LoadFoodList();
             string mam = txtIDFood.Text;
             string tenm = txtFoodName.Text;
            // decimal gia;
             //int n = 0;
            // int flag = 0;
             //foreach (MONAN monan in dsmonan)
             //{
              //   if (monan.TenM == tenm)
               // {
               //     flag = 1;
             //    }
            // }
            // if (this.txtFoodName.Text.ToString().Replace(" ", "") != "")
             //{
             //   if (flag == 1)
             //   {
             //        MessageBox.Show("Món ăn này đã tồn tại", "Thông báo");
            // }
            //     else
            //     {
            //         if (this.txtFoodPrice.Text.ToString().Replace(" ", "") != "")
            //         {
            //             if (int.TryParse(this.txtFoodPrice.Text, out n))
            //             {
             //               gia = decimal.Parse(txtFoodPrice.Text);
            //                 if (MonAnInfras.Instance.ThemMonAn(mam, tenm, gia) == 1)
            //                {
            //                    MessageBox.Show("Thêm món ăn thành công");
            //                     LoadFoodListF();
            //                 }
            //                else
             //                {
             //                    MessageBox.Show("Thêm món ăn thất bại");
           //                  }
        //                 }
        //                 else
        //                 {
        //                     MessageBox.Show("Giá của món ăn phải là số", "Thông báo");
        //                 }
        //             }
        //             else MessageBox.Show("Giá của món ăn phải là số", "Thông báo");
        //         }
        //     }
        //     else MessageBox.Show("Tên món ăn không được để trống", "Thông báo");
        // }
         //private void btnEditFood_Click(object sender, EventArgs e)
         //{
        //     List<MONAN> dsmonan = MonAnInfras.Instance.LoadFoodList();
        //     string mam = txtIDFood.Text;
        //     string tenm = txtFoodName.Text;
        //     decimal gia;
        //     int n = 0;
        //     foreach(MONAN monan in dsmonan)
        //     {
        //         if (monan.MaM == mam)
        //         {
        //             if(monan.TenM != tenm)
        //             {
        //                 MessageBox.Show("Tên món ăn không được thay đổi", "Thông báo");
        //             }
        //             else
        //             {
        //                 if (this.txtFoodPrice.Text.ToString().Replace(" ", "") != "")
        //                 {
        //                     if (int.TryParse(this.txtFoodPrice.Text, out n))
        //                     {
        //                         gia = decimal.Parse(txtFoodPrice.Text);
        //                         if (MonAnInfras.Instance.SuaMonAn(mam, tenm, gia) == 1)
        //                         {
        //                             MessageBox.Show("Sửa món ăn thành công");
        //                             LoadFoodListF();
        //                         }
        //                         else
        //                         {
        //                             MessageBox.Show("Sửa món ăn thất bại");
        //                         }
        //                     }
        //                     else
        //                     {
        //                         MessageBox.Show("Giá của món ăn phải là số", "Thông báo");
        //                     }
        //                 }
        //                 else MessageBox.Show("Giá của món ăn phải là số", "Thông báo");
        //             }
        //         }
        //     }
         }
        // private void btnDeleteFood_Click(object sender, EventArgs e)
        // {
        //     string mam = txtIDFood.Text;
        //     if (MonAnInfras.Instance.XoaMonAn(mam) == 1)
        //     {
        //         MessageBox.Show("Xóa món ăn thành công", "Thông báo");
        //         LoadFoodListF();
        //     }
        //     else
        //     {
        //         MessageBox.Show("Xóa thất bại", "Thông báo");
        //     }
        // }
        // private void btnSearchFood_Click(object sender, EventArgs e)
        // {
        //     string noidung = txtSearchFood.Text;
        //     dtgvFood.DataSource = foodList;
        //     foodList.DataSource = MonAnInfras.Instance.TimMonAn(noidung);
        // }
        // //
        // //Table
        // //
        // private void cbTableStatus1_Click(object sender, EventArgs e)
        // {
        //     cbTableStatus1.Checked = true;
        //     cbTableStatus2.Checked = false;
        //     cbTableStatus3.Checked = false;
        // }
        // private void cbTableStatus2_Click(object sender, EventArgs e)
        // {
        //     cbTableStatus1.Checked = false;
        //     cbTableStatus2.Checked = true;
        //     cbTableStatus3.Checked = false;
        // }
        // private void cbTableStatus3_Click(object sender, EventArgs e)
        // {
        //     cbTableStatus1.Checked = false;
        //     cbTableStatus2.Checked = false;
        //     cbTableStatus3.Checked = true;
        // }
        // void LoadTableListF()
        // {
        //     tableList.DataSource = BanAnInfras.Instance.LoadTableListI();
        // }
        // void AddTableBindingF()
        // {
        //     txtTableID.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "mab", true, DataSourceUpdateMode.Never));
        //     cmbMaxPeopleOnTable.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "sokhach_toida", true, DataSourceUpdateMode.Never));
        //     dtgvTable.SelectionChanged += new EventHandler(this.dtgvTable_SelectionChanged);
        //     dtgvTable.Columns[0].HeaderText = "Mã bàn";
        //     dtgvTable.Columns[0].Width = 200;
        //     dtgvTable.Columns[1].HeaderText = "Số khách tối đa";
        //     dtgvTable.Columns[1].Width = 200;
        //     dtgvTable.Columns[2].Visible = false;
        // }
        // //
        // //EventTable
        // //
        // private void dtgvTable_SelectionChanged(object sender, EventArgs e)
        // {
        //     int viTri = dtgvTable.CurrentCell.RowIndex;
        //     int tinhTrang = int.Parse(dtgvTable.Rows[viTri].Cells[2].Value.ToString());
        //     switch (tinhTrang)
        //     {
        //         case 1:
        //             {
        //                 cbTableStatus1.Checked = true;
        //                 cbTableStatus2.Checked = false;
        //                 cbTableStatus3.Checked = false;

        //                 break;
        //             }
        //         case 2:
        //             {
        //                 cbTableStatus1.Checked = false;
        //                 cbTableStatus2.Checked = true;
        //                 cbTableStatus3.Checked = false;
        //                 break;
        //             }
        //         case 3:
        //             {
        //                 cbTableStatus1.Checked = false;
        //                 cbTableStatus2.Checked = false;
        //                 cbTableStatus3.Checked = true;
        //                 break;
        //             }
        //     }
        // }
        // //
        // //ActionTable
        // //
        // private void btnEditTable_Click(object sender, EventArgs e)
        // {
        //     string mab = txtTableID.Text;
        //     int tinhTrang;
        //     if (cbTableStatus1.Checked) tinhTrang = 1;
        //     else if (cbTableStatus2.Checked) tinhTrang = 2;
        //     else tinhTrang = 3;
        //     int n = 0;
        //     if (this.cmbMaxPeopleOnTable.Text.ToString().Replace(" ", "") != "")
        //     {
        //         if (int.TryParse(this.cmbMaxPeopleOnTable.Text, out n)) {
        //             string sokhach_toida = cmbMaxPeopleOnTable.Text;

        //             if (BanAnInfras.Instance.SuaBanAn(int.Parse(mab), int.Parse(sokhach_toida), tinhTrang) == 1)
        //             {
        //                 MessageBox.Show("Cập nhật bàn ăn thành công", "Thông báo");
        //                 LoadTableListF();
        //             }
        //             else
        //             {
        //                 MessageBox.Show("Cập nhật thất bại", "Thông báo");
        //             }
        //         }
        //         else MessageBox.Show("Số khách phải là ký tự số", "Thông báo");
        //     }
        //     else MessageBox.Show("Hãy nhập trường còn trống", "Thông báo");
        // }
        // private void btnSearchTable_Click(object sender, EventArgs e)
        // {
        //     string noidung = txtSearchTable.Text;
        //     dtgvTable.DataSource = tableList;
        //     tableList.DataSource = BanAnInfras.Instance.TimBanAn(noidung);
        // }
        // //
        // //LoadPromotion
        // //
        // void LoadPromotionListF()
        // {
        //     promotionList.DataSource = KhuyenMaiInfras.Instance.LoadPromotionList();
        // }
        // void AddPromotionBindingF()
        // {
        //     txtPromotionID.DataBindings.Add(new Binding("Text", dtgvPromotion.DataSource, "makm", true, DataSourceUpdateMode.Never));
        //     txtPromotionName.DataBindings.Add(new Binding("Text", dtgvPromotion.DataSource, "tenkm", true, DataSourceUpdateMode.Never));
        //     mtxtPromotionFromDate.DataBindings.Add(new Binding("Text", dtgvPromotion.DataSource, "ngaybd", true, DataSourceUpdateMode.Never));
        //     mtxtPromotionToDate.DataBindings.Add(new Binding("Text", dtgvPromotion.DataSource, "ngaykt", true, DataSourceUpdateMode.Never));
        //     txtPromotionPercent.DataBindings.Add(new Binding("Text", dtgvPromotion.DataSource, "phantramkm", true, DataSourceUpdateMode.Never));
        //     dtgvPromotion.Columns[0].HeaderText = "Mã khuyến mãi";
        //     dtgvPromotion.Columns[0].Width = 50;
        //     dtgvPromotion.Columns[1].HeaderText = "Tên khuyến mãi";
        //     dtgvPromotion.Columns[1].Width = 100;
        //     dtgvPromotion.Columns[2].HeaderText = "Ngày BĐ";
        //     dtgvPromotion.Columns[2].Width = 70;
        //     dtgvPromotion.Columns[3].HeaderText = "Ngày KT";
        //     dtgvPromotion.Columns[3].Width = 70;
        //     dtgvPromotion.Columns[4].HeaderText = "Phần trăm KM";
        //     dtgvPromotion.Columns[4].Width = 50;
        // }
        //
        //EventPromotion
        //
        private void txtPromotionName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) mtxtPromotionFromDate.Focus();
            if (e.KeyCode == Keys.Down) mtxtPromotionFromDate.Focus();
            if (e.KeyCode == Keys.Right) mtxtPromotionFromDate.Focus();
        }
        private void mtxtPromotionFromDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) mtxtPromotionToDate.Focus();
            if (e.KeyCode == Keys.Up) txtPromotionName.Focus();
            if (e.KeyCode == Keys.Down) mtxtPromotionToDate.Focus();
            if (e.KeyCode == Keys.Left) txtPromotionName.Focus();
            if (e.KeyCode == Keys.Right) mtxtPromotionToDate.Focus();
        }
        private void mtxtPromotionToDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) txtPromotionPercent.Focus();
            if (e.KeyCode == Keys.Up) mtxtPromotionFromDate.Focus();
            if (e.KeyCode == Keys.Down) txtPromotionPercent.Focus();
            if (e.KeyCode == Keys.Left) mtxtPromotionFromDate.Focus();
            if (e.KeyCode == Keys.Right) txtPromotionPercent.Focus();
        }
        private void txtPromotionPercent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) mtxtPromotionToDate.Focus();
            if (e.KeyCode == Keys.Left) mtxtPromotionToDate.Focus();
        }
        //
        // //ActionPromotion
        // //
        // private void btnAddPromotion_Click(object sender, EventArgs e)
        // {
        //     string makm = txtPromotionID.Text;
        //     string tenkm = txtPromotionName.Text;
        //     string ngaybd = mtxtPromotionFromDate.Text;
        //     string ngaykt = mtxtPromotionToDate.Text;
        //     string phantramkm;
        //     int n = 0;

        //     if (this.txtPromotionName.Text.ToString().Replace(" ", "") != "" && this.mtxtPromotionFromDate.Text.ToString().Replace(" ", "") != "" && this.mtxtPromotionToDate.Text.ToString().Replace(" ", "") != "")
        //     {
        //         if (this.txtPromotionPercent.Text.ToString().Replace(" ", "") != "")
        //         {
        //             if (int.TryParse(this.txtPromotionPercent.Text, out n))
        //             {
        //                 phantramkm = txtPromotionPercent.Text;
        //                 if (KhuyenMaiInfras.Instance.ThemKhuyenMai(makm, tenkm, ngaybd, ngaykt, phantramkm) == 1)
        //                 {
        //                     MessageBox.Show("Thêm chương trình khuyến mãi thành công", "Thông báo");
        //                     LoadPromotionListF();
        //                 }
        //                 else
        //                 {
        //                     MessageBox.Show("Thêm chương trình khuyến mãi thất bại", "Thông báo");
        //                 }
        //             }
        //             else
        //             {
        //                 MessageBox.Show("Phần trăm khuyến mãi phải là số", "Thông báo");
        //             }
        //         }
        //         else MessageBox.Show("Phần trăm khuyến mãi không được để trống", "Thông báo");
        //     }
        //     else MessageBox.Show("Hãy điền vào trường còn trống", "Thông báo");
        // }
        // private void btnEditPromotion_Click(object sender, EventArgs e)
        // {
        //     string makm = txtPromotionID.Text;
        //     string tenkm = txtPromotionName.Text;
        //     string ngaybd = mtxtPromotionFromDate.Text;
        //     string ngaykt = mtxtPromotionToDate.Text;
        //     string phantramkm;
        //     int n = 0;
        //     if (this.txtPromotionName.Text.ToString().Replace(" ", "") != "" && this.mtxtPromotionFromDate.Text.ToString().Replace(" ", "") != "" && this.mtxtPromotionToDate.Text.ToString().Replace(" ", "") != "")
        //     {
        //         if (this.txtPromotionPercent.Text.ToString().Replace(" ", "") != "")
        //         {
        //             if (int.TryParse(this.txtPromotionPercent.Text, out n))
        //             {
        //                 phantramkm = txtPromotionPercent.Text;
        //                 if (KhuyenMaiInfras.Instance.SuaKhuyenMai(makm, tenkm, ngaybd, ngaykt, phantramkm) == 1)
        //                 {
        //                     MessageBox.Show("Sửa chương trình khuyến mãi thành công", "Thông báo");
        //                     LoadPromotionListF();
        //                 }
        //                 else
        //                 {
        //                     MessageBox.Show("Sửa chương trình khuyến mãi thất bại", "Thông báo");
        //                 }
        //             }
        //             else
        //             {
        //                 MessageBox.Show("Phần trăm khuyến mãi phải là số", "Thông báo");
        //             }
        //         }
        //         else MessageBox.Show("Phần trăm khuyến mãi không được để trống", "Thông báo");
        //     }
        //     else MessageBox.Show("Hãy điền vào trường còn trống", "Thông báo");
        // }
        // private void btnDeletePromotion_Click(object sender, EventArgs e)
        // {
        //     string makm = txtPromotionID.Text;

        //     if (KhuyenMaiInfras.Instance.XoaKhuyenMai(makm) == 1)
        //     {
        //         MessageBox.Show("Xóa chương trình khuyến mãi thành công", "Thông báo");
        //         LoadPromotionListF();
        //     }
        //     else
        //     {
        //         MessageBox.Show("Xóa thất bại", "Thông báo");
        //     }
        // }
        // private void btnSearchPromotion_Click(object sender, EventArgs e)
        // {
        //     string noidung = txtSearchPromotion.Text;
        //     dtgvPromotion.DataSource = promotionList;
        //     promotionList.DataSource = KhuyenMaiInfras.Instance.TimKhuyenMai(noidung);
        // }
        // //
        // //LoadStaff
        // //
        // #region
        // void LoadStaffListF()
        // {
        //     staffList.DataSource = NhanVienInfras.Instance.LoadStaffList();
        // }
        // void AddStaffBindingF()
        // {
        //     txtStaffID.DataBindings.Add(new Binding("Text", dtgvStaff.DataSource, "manv", true, DataSourceUpdateMode.Never));
        //     txtStaffName.DataBindings.Add(new Binding("Text", dtgvStaff.DataSource, "hotennv", true, DataSourceUpdateMode.Never));
        //     txtStaffIdentity.DataBindings.Add(new Binding("Text", dtgvStaff.DataSource, "cmnd_nv", true, DataSourceUpdateMode.Never));
        //     txtStaffPhoneNumber.DataBindings.Add(new Binding("Text", dtgvStaff.DataSource, "sdt_nv", true, DataSourceUpdateMode.Never));
        //     txtStaffMail.DataBindings.Add(new Binding("Text", dtgvStaff.DataSource, "mail_nv", true, DataSourceUpdateMode.Never));
        //     mtxtStaffDateOfBirth.DataBindings.Add(new Binding("Text", dtgvStaff.DataSource, "ngaysinh", true, DataSourceUpdateMode.Never));
        //     txtStaffAddress.DataBindings.Add(new Binding("Text", dtgvStaff.DataSource, "diachi", true, DataSourceUpdateMode.Never));
        //     txtStaffContactName.DataBindings.Add(new Binding("Text", dtgvStaff.DataSource, "hoten_nguoilh", true, DataSourceUpdateMode.Never));
        //     txtStaffContactPhoneNumber.DataBindings.Add(new Binding("Text", dtgvStaff.DataSource, "sdt_nguoilh", true, DataSourceUpdateMode.Never));
        //     cmbStaffIdentity.DataBindings.Add(new Binding("Text", dtgvStaff.DataSource, "machucvu", true, DataSourceUpdateMode.Never));
        //     txtStaffPassWord.DataBindings.Add(new Binding("Text", dtgvStaff.DataSource, "matkhau", true, DataSourceUpdateMode.Never));
        //     dtgvStaff.Columns[0].HeaderText = "Mã nhân viên";
        //     dtgvStaff.Columns[0].Width = 45;
        //     dtgvStaff.Columns[1].HeaderText = "Họ tên";
        //     dtgvStaff.Columns[1].Width = 100;
        //     dtgvStaff.Columns[2].HeaderText = "CMND";
        //     dtgvStaff.Columns[2].Width = 70;
        //     dtgvStaff.Columns[3].HeaderText = "SĐT";
        //     dtgvStaff.Columns[3].Width = 70;
        //     dtgvStaff.Columns[4].HeaderText = "Mail";
        //     dtgvStaff.Columns[4].Width = 100;
        //     dtgvStaff.Columns[5].HeaderText = "Ngày sinh";
        //     dtgvStaff.Columns[5].Width = 70;
        //     dtgvStaff.Columns[6].HeaderText = "Địa chỉ";
        //     dtgvStaff.Columns[6].Width = 100;
        //     dtgvStaff.Columns[7].HeaderText = "Họ tên NLH";
        //     dtgvStaff.Columns[7].Width = 100;
        //     dtgvStaff.Columns[8].HeaderText = "SĐT NLH";
        //     dtgvStaff.Columns[8].Width = 70;
        //     dtgvStaff.Columns[9].HeaderText = "Mã Chức vụ";
        //     dtgvStaff.Columns[9].Width = 50;
        //     dtgvStaff.Columns[10].HeaderText = "Mật khẩu";
        //     dtgvStaff.Columns[10].Width = 50;
        // }
        // #endregion
        // //
        // //EventStaff
        // //
        // private void txtStaffName_KeyDown(object sender, KeyEventArgs e)
        // {
        //     if (e.KeyCode == Keys.Enter) mtxtStaffDateOfBirth.Focus();
        //     if (e.KeyCode == Keys.Down) mtxtStaffDateOfBirth.Focus();
        // }
        // private void mtxtStaffDateOfBirth_KeyDown(object sender, KeyEventArgs e)
        // {
        //     if (e.KeyCode == Keys.Enter) txtStaffPhoneNumber.Focus();
        //     if (e.KeyCode == Keys.Up) txtStaffName.Focus();
        //     if (e.KeyCode == Keys.Down) txtStaffPhoneNumber.Focus();
        // }
        // private void txtStaffPhoneNumber_KeyDown(object sender, KeyEventArgs e)
        // {
        //     if (e.KeyCode == Keys.Enter) txtStaffPassWord.Focus();
        //     if (e.KeyCode == Keys.Up) mtxtStaffDateOfBirth.Focus();
        //     if (e.KeyCode == Keys.Down) txtStaffPassWord.Focus();
        // }
        // private void txtStaffPassWord_KeyDown(object sender, KeyEventArgs e)
        // {
        //     if (e.KeyCode == Keys.Enter) txtStaffAddress.Focus();
        //     if (e.KeyCode == Keys.Up) txtStaffPhoneNumber.Focus();
        //     if (e.KeyCode == Keys.Down) txtStaffAddress.Focus();
        // }
        // private void txtStaffAddress_KeyDown(object sender, KeyEventArgs e)
        // {
        //     if (e.KeyCode == Keys.Enter) txtStaffIdentity.Focus();
        //     if (e.KeyCode == Keys.Up) txtStaffPassWord.Focus();
        //     if (e.KeyCode == Keys.Down) txtStaffIdentity.Focus();
        // }
        // private void txtStaffIdentity_KeyDown(object sender, KeyEventArgs e)
        // {
        //     if (e.KeyCode == Keys.Enter) txtStaffMail.Focus();
        //     if (e.KeyCode == Keys.Up) txtStaffAddress.Focus();
        //     if (e.KeyCode == Keys.Down) txtStaffMail.Focus();
        // }
        // private void txtStaffMail_KeyDown(object sender, KeyEventArgs e)
        // {
        //     if (e.KeyCode == Keys.Enter) txtStaffContactName.Focus();
        //     if (e.KeyCode == Keys.Up) txtStaffIdentity.Focus();
        //     if (e.KeyCode == Keys.Down) txtStaffContactName.Focus();
        // }
        // private void txtStaffContactName_KeyDown(object sender, KeyEventArgs e)
        // {
        //     if (e.KeyCode == Keys.Enter) txtStaffContactPhoneNumber.Focus();
        //     if (e.KeyCode == Keys.Up) txtStaffMail.Focus();
        //     if (e.KeyCode == Keys.Down) txtStaffContactPhoneNumber.Focus();
        // }
        // private void txtStaffContactPhoneNumber_KeyDown(object sender, KeyEventArgs e)
        // {
        //     if (e.KeyCode == Keys.Up) txtStaffContactName.Focus();
        // }
        // //
        // //Action Staff
        // //
        // private void btnAddStaff_Click(object sender, EventArgs e)
        // {
        //     string manv = txtStaffID.Text;
        //     string hotennv = txtStaffName.Text;
        //     string ngaysinh = mtxtStaffDateOfBirth.Text;
        //     string diachi = txtStaffAddress.Text;
        //     string hoten_nguoilienhe = txtStaffContactName.Text;
        //     int machucvu = int.Parse(cmbStaffIdentity.SelectedValue.ToString());
        //     string matkhau = txtStaffPassWord.Text;
        //     int n = 0;
        //     string formatMail = "@gmail.com";
        //     if (this.txtStaffName.Text.Length != 0 && this.mtxtStaffDateOfBirth.Text.Length != 0 && this.txtStaffAddress.Text.Length != 0
        //         && this.txtStaffContactName.Text.Length != 0 && this.txtStaffPassWord.Text.Length != 0)
        //     {
        //         if (this.txtStaffMail.Text.Contains(formatMail))
        //         {
        //             string mail = txtStaffMail.Text;
        //             if (int.TryParse(this.txtStaffIdentity.Text, out n))
        //             {
        //                 if (this.txtStaffIdentity.Text.Length == 9)
        //                 {
        //                     string cmnd = txtStaffIdentity.Text;
        //                     n = 0;
        //                     if (int.TryParse(this.txtStaffPhoneNumber.Text, out n))
        //                     {
        //                         if (this.txtStaffPhoneNumber.Text.Length == 10)
        //                         {
        //                             string sdtnv = txtStaffPhoneNumber.Text;
        //                             n = 0;
        //                             if (int.TryParse(this.txtStaffContactPhoneNumber.Text, out n))
        //                             {
        //                                 if (this.txtStaffContactPhoneNumber.Text.Length == 10)
        //                                 {
        //                                     string sdt_nguoilienhe = txtStaffContactPhoneNumber.Text;
        //                                     if (NhanVienInfras.Instance.ThemNhanVien(manv, hotennv, cmnd, sdtnv, mail, ngaysinh, diachi, hoten_nguoilienhe, sdt_nguoilienhe, machucvu, matkhau) == 1)
        //                                     {
        //                                         MessageBox.Show("Thêm nhân viên thành công", "Thông báo");
        //                                         LoadStaffListF();
        //                                     }
        //                                     else
        //                                     {
        //                                         MessageBox.Show("Thêm thất bại", "Thông báo");
        //                                     }
        //                                 }
        //                                 else MessageBox.Show("Số điện thoại phải có đúng 10 ký tự", "Thông báo");
        //                             }
        //                             else MessageBox.Show("Số điện thoại chỉ được chứa ký tự số", "Thông báo");
        //                         }
        //                         else MessageBox.Show("Số điện thoại phải có đúng 10 ký tự", "Thông báo");
        //                     }
        //                     else MessageBox.Show("Số điện thoại chỉ được chứa ký tự số", "Thông báo");
        //                 }
        //                 else MessageBox.Show("Chứng minh nhân dân phải có đúng 9 ký tự", "Thông báo");
        //             }
        //             else MessageBox.Show("Chứng minh nhân dân chỉ được chứa ký tự số", "Thông báo");
        //         }
        //         else MessageBox.Show("Mail phải theo định dạng 'example@gmail.com'", "Thông báo");
        //     }
        //     else MessageBox.Show("Không được để trống bất kỳ trường nào", "Thông báo");
        // }
        // private void btnEditStaff_Click(object sender, EventArgs e)
        // {
        //     string manv = txtStaffID.Text;
        //     string hotennv = txtStaffName.Text;
        //     string ngaysinh = mtxtStaffDateOfBirth.Text;
        //     string diachi = txtStaffAddress.Text;
        //     string hoten_nguoilienhe = txtStaffContactName.Text;
        //     int machucvu = int.Parse(cmbStaffIdentity.SelectedValue.ToString());
        //     string matkhau = txtStaffPassWord.Text;
        //     int n = 0;
            
        //     string formatMail = "@gmail.com";
        //     if (this.txtStaffName.Text.Length != 0 && this.mtxtStaffDateOfBirth.Text.Length != 0 && this.txtStaffAddress.Text.Length != 0
        //         && this.txtStaffContactName.Text.Length != 0 && this.txtStaffPassWord.Text.Length != 0)
        //     {
        //         if (this.txtStaffMail.Text.Contains(formatMail))
        //         {
        //             string mail = txtStaffMail.Text;
        //             if (int.TryParse(this.txtStaffIdentity.Text, out n))
        //             {
        //                 if (this.txtStaffIdentity.Text.Length == 9)
        //                 {
        //                     string cmnd = txtStaffIdentity.Text;
        //                     n = 0;
        //                     if (int.TryParse(this.txtStaffPhoneNumber.Text, out n))
        //                     {
        //                         if (this.txtStaffPhoneNumber.Text.Length == 10)
        //                         {
        //                             string sdtnv = txtStaffPhoneNumber.Text;
        //                             n = 0;
        //                             if (int.TryParse(this.txtStaffContactPhoneNumber.Text, out n))
        //                             {
        //                                 if (this.txtStaffContactPhoneNumber.Text.Length == 10)
        //                                 {
        //                                     string sdt_nguoilienhe = txtStaffContactPhoneNumber.Text;
        //                                     n = 0;
        //                                     if (NhanVienInfras.Instance.SuaNhanVien(manv, hotennv, cmnd, sdtnv, mail, ngaysinh, diachi, hoten_nguoilienhe, sdt_nguoilienhe, machucvu, matkhau) == 1)
        //                                     {
        //                                         MessageBox.Show("Sửa nhân viên thành công", "Thông báo");
        //                                         LoadStaffListF();
        //                                     }
        //                                     else
        //                                     {
        //                                         MessageBox.Show("Sửa thất bại", "Thông báo");
        //                                     }
        //                                 }
        //                                 else MessageBox.Show("Số điện thoại phải có đúng 10 ký tự", "Thông báo");
        //                             }
        //                             else MessageBox.Show("Số điện thoại chỉ được chứa ký tự số", "Thông báo");
        //                         }
        //                         else MessageBox.Show("Số điện thoại phải có đúng 10 ký tự", "Thông báo");
        //                     }
        //                     else MessageBox.Show("Số điện thoại chỉ được chứa ký tự số", "Thông báo");
        //                 }
        //                 else MessageBox.Show("Chứng minh nhân dân phải có đúng 9 ký tự", "Thông báo");
        //             }
        //             else MessageBox.Show("Chứng minh nhân dân chỉ được chứa ký tự số", "Thông báo");
        //         }
        //         else MessageBox.Show("Mail phải theo định dạng 'example@gmail.com'", "Thông báo");
        //     }
        //     else MessageBox.Show("Không được để trống bất kỳ trường nào", "Thông báo");
        // }
        // private void btnDeleteStaff_Click(object sender, EventArgs e)
        // {
        //     string manv = txtStaffID.Text;

        //     if (NhanVienInfras.Instance.XoaNhanVien(manv) == 1)
        //     {
        //         MessageBox.Show("Xóa nhân viên thành công", "Thông báo");
        //         LoadStaffListF();
        //     }
        //     else
        //     {
        //         MessageBox.Show("Xóa thất bại", "Thông báo");
        //     }
        // }
        // private void btnSearchStaff_Click(object sender, EventArgs e)
        // {
        //     string noidung = txtSearchStaff.Text;
        //     dtgvStaff.DataSource = staffList;
        //     staffList.DataSource = NhanVienInfras.Instance.TimNhanVien(noidung);
        // }

        // //
        // //
        // //
        // //LoadOrder
        // //
        // void LoadOrderListF()
        // {
        //     orderList.DataSource = PhieuDatBanInfras.Instance.LoadOrderListI();
        //     BindingSource orderTable = new BindingSource();
        //     orderTable.DataSource = BanAnInfras.Instance.LoadTableListI();
        //     cmbOrderTable.DataSource = orderTable.DataSource;
        //     cmbOrderTable.DisplayMember = "MaB";
        // }
        // void AddOrderBindingF()
        // {
        //     txtOrderID.DataBindings.Add(new Binding("Text", dtgvOrderTable.DataSource, "mapdb", true, DataSourceUpdateMode.Never));
        //     cmbOrderTable.DataBindings.Add(new Binding("Text", dtgvOrderTable.DataSource, "mab", true, DataSourceUpdateMode.Never));
        //     txtOrderCustomer.DataBindings.Add(new Binding("Text", dtgvOrderTable.DataSource, "makh", true, DataSourceUpdateMode.Never));
        //     txtOrderCustomerPhoneNumber.DataBindings.Add(new Binding("Text", dtgvOrderTable.DataSource, "SDT_KH", true, DataSourceUpdateMode.Never));
        //     mtxtOrderDate.DataBindings.Add(new Binding("Text", dtgvOrderTable.DataSource, "ngaydat", true, DataSourceUpdateMode.Never));
        //     mtxtOrderTime.DataBindings.Add(new Binding("Text", dtgvOrderTable.DataSource, "giodat", true, DataSourceUpdateMode.Never));
        //     cbOrderStatus1.Checked = true;
        //     dtgvOrderTable.Columns[0].HeaderText = "Mã phiếu đặt bàn";
        //     dtgvOrderTable.Columns[0].Width = 65;
        //     dtgvOrderTable.Columns[1].HeaderText = "Mã bàn";
        //     dtgvOrderTable.Columns[1].Width = 40;
        //     dtgvOrderTable.Columns[2].HeaderText = "Mã khách hàng";
        //     dtgvOrderTable.Columns[2].Width = 45;
        //     dtgvOrderTable.Columns[3].HeaderText = "SĐT khách hàng";
        //     dtgvOrderTable.Columns[3].Width = 70;
        //     dtgvOrderTable.Columns[4].HeaderText = "Ngày đặt";
        //     dtgvOrderTable.Columns[4].Width = 70;
        //     dtgvOrderTable.Columns[5].HeaderText = "Giờ đặt";
        //     dtgvOrderTable.Columns[5].Width = 70;
        // }
        // //
        // //EventOrder
        // //
        void cbOrderStatus1_Click(object sender, EventArgs e)
        {
            cbOrderStatus1.Checked = true;
            cbOrderStatus2.Checked = false;
        }
        void cbOrderStatus2_Click(object sender, EventArgs e)
        {
            cbOrderStatus1.Checked = false;
            cbOrderStatus2.Checked = true;
        }
        private void txtOrderCustomerPhoneNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) mtxtOrderDate.Focus();
            if (e.KeyCode == Keys.Down) mtxtOrderDate.Focus();
        }
        private void mtxtOrderDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) mtxtOrderTime.Focus();
            if (e.KeyCode == Keys.Up) txtOrderCustomerPhoneNumber.Focus();
            if (e.KeyCode == Keys.Down) mtxtOrderTime.Focus();
        }
        private void mtxtOrderTime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) mtxtOrderDate.Focus();
        }
        //
        //ActionOrder
        //
        // private void btnEditOrder_Click(object sender, EventArgs e)
        // {
        //     string mapdb = txtOrderID.Text;
        //     string mab = cmbOrderTable.Text;
        //     string makh = txtOrderCustomer.Text;
        //     string sdt;
        //     string ngaydat = mtxtOrderDate.Text;
        //     string giodat = mtxtOrderTime.Text;
        //     string tinhtrang;
        //     if (cbOrderStatus1.Checked) tinhtrang = "false";
        //     else tinhtrang = "true";
        //     int n = 0;
        //     if (int.TryParse(txtOrderCustomerPhoneNumber.Text, out n))
        //     {
        //         sdt = txtOrderCustomerPhoneNumber.Text;
        //         if (PhieuDatBanInfras.Instance.SuaPhieuDatBan(mapdb, mab, makh, sdt, ngaydat, giodat, tinhtrang) == 1)
        //         {
        //             MessageBox.Show("Sửa phiếu đặt bàn thành công", "Thông báo");
        //             LoadOrderListF();
        //             PhieuDatBanInfras.Instance.LoadOrderListI();
        //         }
        //         else
        //         {
        //             MessageBox.Show("Sửa thất bại", "Thông báo");
        //         }
        //     }
        //     else MessageBox.Show("Số điện thoại chỉ được chứa ký tự số", "Thông báo");
        // }
        // private void btnDeleteOrder_Click(object sender, EventArgs e)
        // {
        //     string mapdb = txtOrderID.Text;
        //     if (PhieuDatBanInfras.Instance.XoaPhieuDatBan(mapdb) == 1)
        //     {
        //         MessageBox.Show("Xóa phiếu đặt bàn thành công", "Thông báo");
        //         LoadOrderListF();
        //     }
        //     else
        //     {
        //         MessageBox.Show("Xóa thất bại", "Thông báo");
        //     }
        // }
        // private void btnSearchOrder_Click(object sender, EventArgs e)
        // {
        //     string noidung = txtSearchOrder.Text;
        //     dtgvOrderTable.DataSource = orderList;
        //     orderList.DataSource = PhieuDatBanInfras.Instance.TimPhieuDatBan(noidung);
        // }
    }
}
