using SuDungLinQ.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuDungLinQ
{

    public partial class FormSuaKhachHang : Form
    {
        BanHangDataContext _db = new BanHangDataContext();
        public FormSuaKhachHang()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                Customer khDb = _db.Customers.FirstOrDefault(kh => kh.CustomerID == txtMa.Text);
                khDb.CustomerID = txtMa.Text;
                khDb.CompanyName = txtTenCty.Text;
                khDb.City = txtThanhPho.Text;
                khDb.ContactName = txtTenLienHe.Text;
                khDb.ContactTitle = txtChucDanh.Text;
                khDb.Address = txtDiaChi.Text;
                khDb.Country = txtQuocGia.Text;
                khDb.Fax = txtFax.Text;
                khDb.Phone = txtSdt.Text;
                khDb.Region = txtKhuVuc.Text;
                khDb.PostalCode = txtMaBuuChinh.Text;
                _db.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormSuaKhachHang_Load(object sender, EventArgs e)
        {
            Customer kh = DataBG.customerEdit;
            txtMa.Text = kh.CustomerID;
            txtTenCty.Text = kh.CompanyName;
            txtThanhPho.Text = kh.City;
            txtTenLienHe.Text = kh.ContactName;
            txtChucDanh.Text = kh.ContactTitle;
            txtDiaChi.Text = kh.Address;
            txtQuocGia.Text = kh.Country;
            txtFax.Text = kh.Fax;
            txtSdt.Text = kh.Phone;
            txtKhuVuc.Text = kh.Country;
            txtMaBuuChinh.Text = kh.PostalCode;
        }
    }
}
