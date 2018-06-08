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
using System.Text.RegularExpressions;

namespace QLBanHangSieuThi.Layout
{
    public partial class FormDonHang : UserControl
    {
        public FormDonHang()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SSCJKUR;Initial Catalog=SieuThi;Integrated Security=True");
        SqlDataAdapter adapt;
        SqlCommand cmdDH;

        private void FormDonHang_Load(object sender, EventArgs e)
        {
            dataDonHang.Columns[2].Visible = false;
            DisplayData();
            //add Delete Icon
            DataGridViewImageColumn delbut2 = new DataGridViewImageColumn();
            delbut2.Image = Image.FromFile(Environment.CurrentDirectory + @"\icons\delicon.png");
            delbut2.Width = 40;
            delbut2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataDonHang.Columns.Add(delbut2);
            ddSearch.selectedIndex = 0;


        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from dbo.VIEW_DONHANG ", con);
            adapt.Fill(dt);
            dataDonHang.DataSource = dt;
            con.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string inp = ddSearch.selectedValue.ToString();
            if (inp == "Mã đơn hàng")
            {
                inp = "MADONHANG";
            }
            else if (inp == "Mã sản phẩm")
            {
                inp = "TENSANPHAM";
            }
            else if (inp == "UserName")
            {
                inp = "USERNAME";
            }
            else if (inp == "Tên đơn hàng")
            {
                inp = "TENDONHANG";
            }
            else if (inp == "Mã khuyến mại")
            {
                inp = "MAKHUYENMAI";
            }
            else if (inp == "Ngày đặt")
            {
                inp = "NGAYDAT";
            }
            else if (inp == "Ngày giao hàng")
            {
                inp = "NGAYGIAOHANG";
            }
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from dbo.VIEW_DONHANG where [" + inp + "] like N'%" + inputSearch.Text + "%'", con);
            adapt.Fill(dt);
            dataDonHang.DataSource = dt;
            con.Close();
        }
        
        private void Reload_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void dataDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string maDH = dataDonHang.Rows[e.RowIndex].Cells[0].Value.ToString();
            string maSP = dataDonHang.Rows[e.RowIndex].Cells[2].Value.ToString();
            if (MessageBox.Show("Xác nhận XOÁ đơn hàng "+maDH, "Xác nhận XOÁ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                con.Open();
                cmdDH = new SqlCommand("EXECUTE UID_DONHANG '"+maDH+"','"+maSP+"','','','','','','','Delete'",con);
                cmdDH.ExecuteNonQuery();
                con.Close();
                DisplayData();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            sub_formDonHang themdonhang = new sub_formDonHang();
            themdonhang.ShowDialog();
            DisplayData();
        }
    }
}
