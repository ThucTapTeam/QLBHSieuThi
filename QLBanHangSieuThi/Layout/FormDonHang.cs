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
            SuggestID();
        }

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=SieuThi;Integrated Security=True");
        SqlDataAdapter adapt;
        SqlCommand cmdDH;
        string SugID;

        private void FormDonHang_Load(object sender, EventArgs e)
        {
            DisplayData();
            //add Delete Icon
            DataGridViewImageColumn delbut2 = new DataGridViewImageColumn();
            delbut2.Image = Image.FromFile(Environment.CurrentDirectory + @"\icons\delicon.png");
            delbut2.Width = 40;
            delbut2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataDonHang.Columns.Add(delbut2);
            //Load values for combobox [Mã đơn hàng]
            LoadMaDH();
            //Load values for combobox [Mã sản phẩm]
            con.Open();
            DataTable dt1 = new DataTable();
            adapt = new SqlDataAdapter("select [TENSANPHAM] from dbo.[HANGHOA]", con);
            adapt.Fill(dt1);
            foreach (DataRow row in dt1.Rows)
            {
                cmbMaSp.Items.Add((string)row["TENSANPHAM"]);
            }
            con.Close();
            //Load values for combobox [USERNAME]
            con.Open();
            DataTable dt2 = new DataTable();
            adapt = new SqlDataAdapter("select [USERNAME] from dbo.[USERS]", con);
            adapt.Fill(dt2);
            foreach (DataRow row in dt2.Rows)
            {
                cmbUserName.Items.Add((string)row["USERNAME"]);
            }
            con.Close();
            //Load values for combobox [Mã khuyến mại]
            con.Open();
            DataTable dt3 = new DataTable();
            adapt = new SqlDataAdapter("select [MAKHUYENMAI] from dbo.[KHUYENMAI]", con);
            adapt.Fill(dt3);
            foreach (DataRow row in dt3.Rows)
            {
                cmbMaKhuyenMai.Items.Add((string)row["MAKHUYENMAI"]);
            }
            con.Close();
            //Add items XacNhan
            txtXacNhan.Items.Add("1");
            txtXacNhan.Items.Add("0");
            txtXacNhan.SelectedIndex = 0;
            ddSearch.selectedIndex = 0;

            btnSave.Enabled = false;
            txtPanel.Visible = false;
            label10.Visible = false;
            txtMaDon.Items.Add(SugID);
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
        //Gợi ý mã tiếp theo
        private void SuggestID()
        {
            label10.ForeColor = SystemColors.GrayText;
            int len, j, num;
            string MaDonHang= string.Empty, str;
            con.Close();
            con.Open();
            cmdDH = new SqlCommand("SELECT MAX(MADONHANG) as max FROM dbo.DONHANG",con);
            SqlDataReader dta = cmdDH.ExecuteReader();
            if (dta.Read()== true)
            {
                MaDonHang = dta["max"].ToString();
                len = MaDonHang.Length;
                for (j = 0; j < len; j++)
                {
                    MaDonHang = (dta["max"].ToString()).Substring(j);
                    if (Regex.IsMatch(MaDonHang, @"^\d+$"))
                    {
                        break;
                    }
                }
                str = (dta["max"].ToString()).Substring(0, j);
                num = Convert.ToInt32(MaDonHang);
                num++;
                SugID = str + num;
                label10.Text = "Gợi ý mã tiếp theo: " +SugID;
            }
            con.Close();
        }
        //
        private void LoadMaDH()
        {
            txtMaDon.Items.Clear();
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select [MADONHANG] from dbo.[VIEW_DONHANG]", con);
            adapt.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                txtMaDon.Items.Add((string)row["MADONHANG"]);
            }
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
            else if (inp == "Xác nhận")
            {
                inp = "XACNHAN";
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
        //button tải lại danh sách sau khi tìm kiếm
        private void Reload_Click(object sender, EventArgs e)
        {
            DisplayData();
        }
        // Nút thêm
        private void btnInsert_Click(object sender, EventArgs e)
        {
            txtPanel.Visible = true;
            btnSave.Enabled = true;
            btnInsert.Enabled = false;
            label10.Visible = true;
        }
        //Kiểm tra các thông tin nhập vào có tồn tại trong DB không
        private bool isExist(string inp1, string inp2, string inp3)
        {
            con.Open();
            cmdDH = new SqlCommand("SELECT * FROM dbo.HANGHOA WHERE TENSANPHAM='"+inp1+"'", con);
            SqlDataReader dta = cmdDH.ExecuteReader();
            if (dta.Read() == false)
            {
                con.Close();
                MessageBox.Show("Không tồn tại sản phẩm này.");
                return false;
            }
            else
            {
                con.Close();
                con.Open();
                cmdDH = new SqlCommand("SELECT USERNAME FROM USERS WHERE USERNAME='" + inp2 + "'", con);
                SqlDataReader dta2 = cmdDH.ExecuteReader();
                if (dta2.Read() == false)
                {
                    con.Close();
                    MessageBox.Show("Người dùng này không tồn tại.");
                    return false;
                }
                else
                {
                    con.Close();
                    con.Open();
                    cmdDH = new SqlCommand("SELECT MAKHUYENMAI FROM KHUYENMAI WHERE MAKHUYENMAI ='" + inp3 + "'", con);
                    SqlDataReader dta3 = cmdDH.ExecuteReader();
                    if (dta3.Read() == false)
                    {
                        MessageBox.Show("Mã khuyến mại không tồn tại.");
                        con.Close();
                        return false;
                    }
                    else return true;
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string masanpham;
            if (isExist(cmbMaSp.Text,cmbUserName.Text,cmbMaKhuyenMai.Text) && txtMaDon.Text!=string.Empty)
            {
                if (MessageBox.Show("Xác nhận thêm hoá đơn.", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Close();
                    con.Open();
                    cmdDH = new SqlCommand("SELECT MASANPHAM FROM HANGHOA WHERE TENSANPHAM ='" + cmbMaSp.Text + "'",con);
                    SqlDataReader dta = cmdDH.ExecuteReader();
                    if (dta.Read())
                    {
                        masanpham = dta["MASANPHAM"].ToString();
                        con.Close();
                        con.Open();
                        cmdDH = new SqlCommand("INSERT INTO dbo.DONHANG VALUES('"+txtMaDon.Text+"','" + masanpham + "','"+cmbUserName.Text+ "',N'" + txtTenDonHang.Text + "','" 
                            + cmbMaKhuyenMai.Text + "','" + txtXacNhan.Text + "','" +dateDat.Text + "','" + dateGiao.Text+"')", con);
                        cmdDH.ExecuteNonQuery();
                        con.Close();
                        DisplayData();
                    }
                    txtMaDon.ResetText();
                    cmbMaSp.ResetText();
                    cmbUserName.ResetText();
                    txtTenDonHang.ResetText();
                    txtXacNhan.ResetText();
                    cmbMaKhuyenMai.ResetText();
                    //gợi ý mã mới và thêm
                    SuggestID();
                    txtMaDon.Items.Add(SugID);
                    if (MessageBox.Show("Thêm nữa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        btnInsert.Enabled = true;
                        btnSave.Enabled = false;
                        txtPanel.Visible = false;
                        label10.Visible = false;
                    }
                }
            }
        }
        //click icon thùng rác
        private void dataDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataDonHang.CurrentCell.ColumnIndex.Equals(8) && e.RowIndex != -1)
            {
                if (dataDonHang.CurrentCell != null && dataDonHang.CurrentCell.Value != null)
                {
                    string del = dataDonHang.Rows[e.RowIndex].Cells[0].Value.ToString();
                    if ((MessageBox.Show("Xác nhận XOÁ ", "Xác nhận XOÁ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        con.Open();
                        cmdDH = new SqlCommand("DELETE FROM dbo.DONHANG WHERE [MADONHANG]='" + del + "'", con);
                        cmdDH.ExecuteNonQuery();
                        con.Close();
                        LoadMaDH();
                        SuggestID();
                    }
                }
            }
            con.Close();
            DisplayData();
        }
    }
}
