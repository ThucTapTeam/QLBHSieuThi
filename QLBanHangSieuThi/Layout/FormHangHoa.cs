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
    public partial class FormHangHoa : UserControl
    {
        public FormHangHoa()
        {
            InitializeComponent();
        }
        bool UpdateModeOn = false;
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=SieuThi;Integrated Security=True");
        SqlDataAdapter adapt;
        SqlCommand cmdKG;

        private void FomHangHoa_Load(object sender, EventArgs e)
        {
            DisplayData();
            //Add Modified Icon
            DataGridViewImageColumn delbut = new DataGridViewImageColumn();
            delbut.Image = Image.FromFile(Environment.CurrentDirectory + @"\icons\modified.png");
            delbut.Width = 35;
            delbut.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataHangHoa.Columns.Add(delbut);
            //add Delete Icon
            DataGridViewImageColumn delbut2 = new DataGridViewImageColumn();
            delbut2.Image = Image.FromFile(Environment.CurrentDirectory + @"\icons\delicon.png");
            delbut2.Width = 35;
            delbut2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataHangHoa.Columns.Add(delbut2);
            
            btnSave.Enabled = false;
            txtPanel.Visible = false;
            txtMaSP.Enabled = false;
            btnCancel.Visible = false;
            btnUpdate.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string inp = ddSearch.selectedValue.ToString();
            if(inp== "Mã đơn hàng")
            {
                inp = "MASANPHAM";
            }
            else if (inp == "Tên hàng hoá")
            {
                inp = "TENSANPHAM";
            }
            else if (inp == "Số lượng")
            {
                inp = "SOLUONG";
            }
            else if (inp == "Giá nhập")
            {
                inp = "GIANHAPVAO";
            }
            else if (inp == "Giá bán")
            {
                inp = "GIABANRA";
            }
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from dbo.HANGHOA where ["+inp+"] like N'%"+inputSearch.Text+"%'", con);
            adapt.Fill(dt);
            dataHangHoa.DataSource = dt;
            con.Close();
        }
        
        private void DisplayData()
        {
            con.Close();
            con.Open();
            DataTable dt = new DataTable();
            if (UserInfo.Quyen == "2")
            {
                adapt = new SqlDataAdapter("select * from dbo.HANGHOA", con);
            }
            else
            {
                adapt = new SqlDataAdapter("select * from dbo.HANGHOA where IsDel=0", con);
            }
            adapt.Fill(dt);
            dataHangHoa.DataSource = dt;
            con.Close();
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void SuggestID()
        {
            int len, j, num;
            string MaDonHang = string.Empty, str, SugID;
            con.Close();
            con.Open();
            cmdKG = new SqlCommand("SELECT MAX(MASANPHAM) as max FROM dbo.HANGHOA", con);
            SqlDataReader dta = cmdKG.ExecuteReader();
            if (dta.Read() == true)
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
            }
            else
            {
                SugID = "SP151400";
            }
            con.Close();
            txtMaSP.Text = SugID;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SuggestID();
            txtPanel.Visible = true;
            btnSave.Enabled = true;
            btnInsert.Visible = false;
            btnCancel.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTenSP.Text != "" && txtSL.Text != "" && txtGiaBan.Text != "" && txtGiaNhap.Text != "")
            {
                if (MessageBox.Show("Xác nhận thêm mặt hàng.", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmdKG = new SqlCommand("EXECUTE dbo.UID_HANGHOA '" + txtMaSP.Text + "',N'" + txtTenSP.Text + "','" + txtSL.Text + "','" + txtGiaNhap.Text +
                            "','" + txtGiaBan.Text + "','" + DPngNhap.Text + "',N'Select'", con);
                    SqlDataReader dta2 = cmdKG.ExecuteReader();
                    if (dta2.Read())
                    {
                        MessageBox.Show("Đã tồn tại mã hàng hóa này");
                    }
                    else
                    {
                        con.Open();
                        cmdKG = new SqlCommand("EXECUTE dbo.UID_HANGHOA '" + txtMaSP.Text + "',N'" + txtTenSP.Text + "','" + txtSL.Text + "','" + txtGiaNhap.Text +
                            "','" + txtGiaBan.Text + "','" + DPngNhap.Text + "',N'Insert'", con);
                        cmdKG.ExecuteNonQuery();
                        DisplayData();

                        txtGiaBan.Text = "";
                        txtGiaNhap.Text = "";
                        txtSL.Text = "";
                        txtTenSP.Text = "";
                        SuggestID();
                        if (MessageBox.Show("Thêm thành công. Bạn có muốn thêm nữa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        {
                            btnInsert.Visible = true;
                            btnSave.Enabled = false;
                            txtPanel.Visible = false;
                            btnCancel.Visible = false;
                        }
                    }
                }
            }
            else MessageBox.Show("Nhập thiếu");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtGiaBan.Text = "";
            txtGiaNhap.Text = "";
            txtSL.Text = "";
            txtTenSP.Text = "";
            SuggestID();
            btnCancel.Visible = false;
            btnInsert.Visible = true;
            btnSave.Visible = true;
            btnSave.Enabled = false;
            txtPanel.Visible = false;
            UpdateModeOn = false;
            btnUpdate.Visible = false;
        }

        private void dataHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataHangHoa.CurrentCell.ColumnIndex.Equals(8) && e.RowIndex != -1)
            {
                if (dataHangHoa.CurrentCell != null && dataHangHoa.CurrentCell.Value != null)
                {
                    string mahanghoa = dataHangHoa.Rows[e.RowIndex].Cells[0].Value.ToString();
                    con.Open();
                    if (UpdateModeOn == true)
                    {
                        MessageBox.Show("Không thể xóa khi đang sửa");
                        con.Close();
                    }
                    else
                    {
                        if (MessageBox.Show("Xác nhận XOÁ ", "Xác nhận XOÁ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (UserInfo.Quyen == "2")
                            {
                                cmdKG = new SqlCommand("EXECUTE dbo.UID_HANGHOA '" + mahanghoa + "',N'','','','','',N'Delete'", con);
                            }
                            else if (UserInfo.Quyen == "1")
                            {
                                cmdKG = new SqlCommand("EXECUTE dbo.UID_HANGHOA '" + mahanghoa + "',N'','','','','',N'Hide'", con);
                            }
                            cmdKG.ExecuteNonQuery();
                            SuggestID();
                            con.Close();
                            DisplayData();
                        }
                    }
                }
            }
            if (dataHangHoa.CurrentCell.ColumnIndex.Equals(7) && e.RowIndex != -1)
            {
                if (dataHangHoa.CurrentCell != null && dataHangHoa.CurrentCell.Value != null)
                {
                    txtPanel.Visible = true;
                    btnCancel.Visible = true;
                    btnSave.Visible = false;
                    btnUpdate.Visible = true;
                    btnInsert.Visible = false;
                    UpdateModeOn = true;
                    txtMaSP.Text = dataHangHoa.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtTenSP.Text = dataHangHoa.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtSL.Text = dataHangHoa.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtGiaBan.Text = dataHangHoa.Rows[e.RowIndex].Cells[4].Value.ToString();
                    txtGiaNhap.Text = dataHangHoa.Rows[e.RowIndex].Cells[3].Value.ToString();
                    DPngNhap.Text = dataHangHoa.Rows[e.RowIndex].Cells[5].Value.ToString();
                }
            }
            if (dataHangHoa.CurrentCell.ColumnIndex.Equals(6) && e.RowIndex != -1)
            {
                if (dataHangHoa.CurrentCell != null && dataHangHoa.CurrentCell.Value != null)
                {
                    string mahanghoa = dataHangHoa.Rows[e.RowIndex].Cells[0].Value.ToString();
                    if ((MessageBox.Show("Phục hồi hiển thự dữ liệu", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        con.Open();
                        if (UserInfo.Quyen == "2")
                        {
                            cmdKG = new SqlCommand("EXECUTE dbo.UID_HANGHOA '" + mahanghoa + "',N'','','','','',N'Show'", con);
                        }
                        cmdKG.ExecuteNonQuery();
                        DisplayData();
                        con.Close();
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtTenSP.Text != "" && txtSL.Text != "" && txtGiaBan.Text != "" && txtGiaNhap.Text != "" && UpdateModeOn == true)
            {
                if ((MessageBox.Show("Xác nhận SỬA ", "Xác nhận SỬA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    con.Open();
                    cmdKG = new SqlCommand("EXECUTE dbo.UID_HANGHOA '" + txtMaSP.Text + "',N'" + txtTenSP.Text + "','" + txtSL.Text + "','" + txtGiaNhap.Text +
                        "','" + txtGiaBan.Text + "','" + DPngNhap.Text + "',N'Update'", con);
                    cmdKG.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công");
                    txtPanel.Visible = false;
                    btnCancel.Visible = false;
                    btnSave.Visible = true;
                    btnUpdate.Visible = false;
                    btnInsert.Visible = true;
                    UpdateModeOn = false;
                    DisplayData();
                    con.Close();
                }
            }
            
        }
    }
}