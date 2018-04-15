using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLBanHangSieuThi.Layout
{
    public partial class FormKhachHang : UserControl
    {
        public FormKhachHang()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=SieuThi;Integrated Security=True");
        SqlDataAdapter adapt;

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            this.vIEW_KHACHHANGTableAdapter.Fill(this.qLBHSieuThiDataSet_KHACHHANG.VIEW_KHACHHANG);
        }
    }
}
