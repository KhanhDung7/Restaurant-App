
namespace CleanArchQLNH
{
    partial class fInHoaDon
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
            this.pnPrintBill = new System.Windows.Forms.Panel();
            this.txtExcessCash = new System.Windows.Forms.TextBox();
            this.txtCustomerGive = new System.Windows.Forms.TextBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lvPrintBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBillDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBillID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrintBill = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnPrintBill.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnPrintBill
            // 
            this.pnPrintBill.Controls.Add(this.txtExcessCash);
            this.pnPrintBill.Controls.Add(this.txtCustomerGive);
            this.pnPrintBill.Controls.Add(this.txtTotalPrice);
            this.pnPrintBill.Controls.Add(this.label9);
            this.pnPrintBill.Controls.Add(this.label8);
            this.pnPrintBill.Controls.Add(this.label7);
            this.pnPrintBill.Controls.Add(this.lvPrintBill);
            this.pnPrintBill.Controls.Add(this.txtStaffName);
            this.pnPrintBill.Controls.Add(this.label6);
            this.pnPrintBill.Controls.Add(this.txtBillDate);
            this.pnPrintBill.Controls.Add(this.label5);
            this.pnPrintBill.Controls.Add(this.txtBillID);
            this.pnPrintBill.Controls.Add(this.label4);
            this.pnPrintBill.Controls.Add(this.label3);
            this.pnPrintBill.Controls.Add(this.btnPrintBill);
            this.pnPrintBill.Controls.Add(this.label2);
            this.pnPrintBill.Controls.Add(this.label1);
            this.pnPrintBill.Location = new System.Drawing.Point(12, 12);
            this.pnPrintBill.Name = "pnPrintBill";
            this.pnPrintBill.Size = new System.Drawing.Size(296, 426);
            this.pnPrintBill.TabIndex = 0;
            // 
            // txtExcessCash
            // 
            this.txtExcessCash.Location = new System.Drawing.Point(176, 354);
            this.txtExcessCash.Name = "txtExcessCash";
            this.txtExcessCash.ReadOnly = true;
            this.txtExcessCash.Size = new System.Drawing.Size(120, 23);
            this.txtExcessCash.TabIndex = 16;
            this.txtExcessCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCustomerGive
            // 
            this.txtCustomerGive.Location = new System.Drawing.Point(176, 325);
            this.txtCustomerGive.Name = "txtCustomerGive";
            this.txtCustomerGive.Size = new System.Drawing.Size(120, 23);
            this.txtCustomerGive.TabIndex = 15;
            this.txtCustomerGive.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCustomerGive.LostFocus += new System.EventHandler(this.txtCustomerGive_LostFocus);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(176, 297);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(120, 23);
            this.txtTotalPrice.TabIndex = 14;
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(3, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Trả lại khách";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(3, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Tiền mặt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(3, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tổng thanh toán";
            // 
            // lvPrintBill
            // 
            this.lvPrintBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvPrintBill.HideSelection = false;
            this.lvPrintBill.Location = new System.Drawing.Point(3, 170);
            this.lvPrintBill.Name = "lvPrintBill";
            this.lvPrintBill.Size = new System.Drawing.Size(293, 124);
            this.lvPrintBill.TabIndex = 10;
            this.lvPrintBill.UseCompatibleStateImageBehavior = false;
            this.lvPrintBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Name = "columnHeader1";
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Name = "columnHeader2";
            this.columnHeader2.Text = "SL";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 35;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Name = "columnHeader3";
            this.columnHeader3.Text = "ĐG";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Name = "columnHeader4";
            this.columnHeader4.Text = "% KM";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 50;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Name = "columnHeader5";
            this.columnHeader5.Text = "TT";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 73;
            // 
            // txtStaffName
            // 
            this.txtStaffName.Location = new System.Drawing.Point(74, 141);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.ReadOnly = true;
            this.txtStaffName.Size = new System.Drawing.Size(222, 23);
            this.txtStaffName.TabIndex = 9;
            this.txtStaffName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nhân viên:";
            // 
            // txtBillDate
            // 
            this.txtBillDate.Location = new System.Drawing.Point(176, 109);
            this.txtBillDate.Name = "txtBillDate";
            this.txtBillDate.ReadOnly = true;
            this.txtBillDate.Size = new System.Drawing.Size(120, 23);
            this.txtBillDate.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(133, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ngày:";
            // 
            // txtBillID
            // 
            this.txtBillID.Location = new System.Drawing.Point(34, 109);
            this.txtBillID.Name = "txtBillID";
            this.txtBillID.ReadOnly = true;
            this.txtBillID.Size = new System.Drawing.Size(78, 23);
            this.txtBillID.TabIndex = 5;
            this.txtBillID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(30, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "HÓA ĐƠN THANH TOÁN";
            // 
            // btnPrintBill
            // 
            this.btnPrintBill.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrintBill.Location = new System.Drawing.Point(206, 391);
            this.btnPrintBill.Name = "btnPrintBill";
            this.btnPrintBill.Size = new System.Drawing.Size(90, 35);
            this.btnPrintBill.TabIndex = 2;
            this.btnPrintBill.Text = "QUAY LẠI";
            this.btnPrintBill.UseVisualStyleBackColor = true;
            this.btnPrintBill.Click += new System.EventHandler(this.btnPrintBill_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "273 AN DƯƠNG VƯƠNG, PHƯỜNG 3, QUẬN 5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "DIAMOND RESTAURANT";
            // 
            // fInHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 450);
            this.Controls.Add(this.pnPrintBill);
            this.Name = "fInHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In hóa đơn";
            this.Load += new System.EventHandler(this.fInHoaDon_Load);
            this.pnPrintBill.ResumeLayout(false);
            this.pnPrintBill.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnPrintBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExcessCash;
        private System.Windows.Forms.TextBox txtCustomerGive;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lvPrintBill;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBillDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBillID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrintBill;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}