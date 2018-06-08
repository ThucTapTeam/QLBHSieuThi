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
    public partial class FormKhachHang : UserControl
    {
        public FormKhachHang()
        {
            InitializeComponent();
        }

        bool UpdateModeOn = false;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SSCJKUR;Initial Catalog=SieuThi;Integrated Security=True");
        SqlDataAdapter adapt;
        SqlCommand cmdKG;

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            DisplayData();
            //Add Modified Icon
            DataGridViewImageColumn delbut = new DataGridViewImageColumn();
            delbut.Image = Image.FromFile(Environment.CurrentDirectory + @"\icons\modified.png");
            delbut.Width = 35;
            delbut.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataKhachHang.Columns.Add(delbut);
            //add Delete Icon
            DataGridViewImageColumn delbut2 = new DataGridViewImageColumn();
            delbut2.Image = Image.FromFile(Environment.CurrentDirectory + @"\icons\delicon.png");
            delbut2.Width = 35;
            delbut2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataKhachHang.Columns.Add(delbut2);

            btnSave.Enabled = false;
            txtPanel.Visible = false;
            txtMaKhach.Enabled = false;
            btnCancel.Visible = false;
            btnUpdate.Visible = false;
        }

        private void DisplayData()
        {
            con.Close();
            con.Open();
            DataTable dt = new DataTable();
            if (UserInfo.Quyen == "2")
            {
                adapt = new SqlDataAdapter("select * from dbo.KHACHHANG", con);
            }
            else
            {
                adapt = new SqlDataAdapter("select * from dbo.KHACHHANG where Del=0", con);
            }
            adapt.Fill(dt);
            dataKhachHang.DataSource = dt;
            con.Close();
        }

        private void SuggestID()
        {
            int len, j, num;
            string MaDonHang = string.Empty, str, SugID;
            con.Close();
            con.Open();
            cmdKG = new SqlCommand("SELECT MAX(MAKHACH) as max FROM dbo.KHACHHANG", con);
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
                SugID = "KH151600";
            }
            con.Close();
            txtMaKhach.Text = SugID;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string inp = ddSearch.selectedValue.ToString();
            if (inp == "USERNAME")
            {
                inp = "USERNAME";
            }
            else if (inp == "Họ Tên")
            {
                inp = "HOTEN";
            }
            else if (inp == "Email")
            {
                inp = "EMAIL";
            }
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from dbo.USERS where [" + inp + "] like N'%" + inputSearch.Text + "%'", con);
            adapt.Fill(dt);
            dataKhachHang.DataSource = dt;
            con.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtMaKhach.Text = "";
            txtHoTen.Text = "";
            txtGT.ResetText();
            txtSDT.Text = "";
            btnCancel.Visible = false;
            btnInsert.Visible = true;
            btnSave.Visible = true;
            btnSave.Enabled = false;
            txtPanel.Visible = false;
            UpdateModeOn = false;
            btnUpdate.Visible = false;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            txtPanel.Visible = true;
            btnSave.Enabled = true;
            btnInsert.Visible = false;
            btnCancel.Visible = true;
            SuggestID();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMaKhach.Text == "" || txtHoTen.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show("Nhập thiếu");
            }
            else if (!Regex.IsMatch(txtSDT.Text,@"^\d+$")||txtSDT.Text.Length<10)
            {
                MessageBox.Show("Số điện thoại không hợp lệ");
            }
            else
            {
                if (MessageBox.Show("Xác nhận thêm khách hàng.", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmdKG = new SqlCommand("EXECUTE dbo.UID_KHACHHANG" + "'" + txtMaKhach.Text + "',N'" + txtHoTen.Text + "',N'" + txtGT.Text +
                        "','" + DPNS.Text + "','" + txtSDT.Text + "',N'" + txtDiaChi.Text + "',N'Insert'", con);
                    cmdKG.ExecuteNonQuery();
                    DisplayData();

                    txtMaKhach.Text = "";
                    txtHoTen.Text = "";
                    txtSDT.Text = "";
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtMaKhach.Text != "" && txtHoTen.Text != "" && txtSDT.Text != "" && UpdateModeOn == true)
            {
                if ((MessageBox.Show("Xác nhận SỬA ", "Xác nhận SỬA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    con.Open();
                    cmdKG = new SqlCommand("EXECUTE dbo.UID_KHACHHANG" +"'" + txtMaKhach.Text + "','" + txtHoTen + "',N'" + txtGT.Text + "','" + DPNS.Text +
                        "','" + txtSDT.Text + "','" + txtDiaChi.Text + "',N'Update'", con);
                    cmdKG.ExecuteNonQuery();
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

        private void dataUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataKhachHang.CurrentCell.ColumnIndex.Equals(8) && e.RowIndex != -1)
            {
                if (dataKhachHang.CurrentCell != null && dataKhachHang.CurrentCell.Value != null)
                {
                    if (dataKhachHang.CurrentCell != null && dataKhachHang.CurrentCell.Value != null)
                    {
                        string makhach = dataKhachHang.Rows[e.RowIndex].Cells[0].Value.ToString();
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
                                    cmdKG = new SqlCommand("EXECUTE dbo.UID_KHACHHANG '" + makhach + "',N'','','','','',N'Delete'", con);
                                }
                                else if (UserInfo.Quyen == "1")
                                {
                                    cmdKG = new SqlCommand("EXECUTE dbo.UID_KHACHHANG '" + makhach + "',N'','','','','',N'Hide'", con);
                                }
                                cmdKG.ExecuteNonQuery();
                                SuggestID();
                                con.Close();
                                DisplayData();
                            }
                            con.Close();
                        }
                    }
                }
            }
            if (dataKhachHang.CurrentCell.ColumnIndex.Equals(7) && e.RowIndex != -1)
            {
                if (dataKhachHang.CurrentCell != null && dataKhachHang.CurrentCell.Value != null)
                {
                    if (dataKhachHang.CurrentCell != null && dataKhachHang.CurrentCell.Value != null)
                    {
                        txtPanel.Visible = true;
                        btnCancel.Visible = true;
                        btnSave.Visible = false;
                        btnUpdate.Visible = true;
                        btnInsert.Visible = false;
                        UpdateModeOn = true;
                        txtMaKhach.Text = dataKhachHang.Rows[e.RowIndex].Cells[0].Value.ToString();
                        txtHoTen.Text = dataKhachHang.Rows[e.RowIndex].Cells[1].Value.ToString();
                        txtGT.Text = dataKhachHang.Rows[e.RowIndex].Cells[2].Value.ToString();
                        DPNS.Text = dataKhachHang.Rows[e.RowIndex].Cells[3].Value.ToString();
                        txtSDT.Text = dataKhachHang.Rows[e.RowIndex].Cells[4].Value.ToString();
                        txtDiaChi.Text = dataKhachHang.Rows[e.RowIndex].Cells[5].Value.ToString();
                    }
                }
            }
            if (dataKhachHang.CurrentCell.ColumnIndex.Equals(6) && e.RowIndex != -1)
            {
                if (dataKhachHang.CurrentCell != null && dataKhachHang.CurrentCell.Value != null)
                {
                    if (dataKhachHang.CurrentCell != null && dataKhachHang.CurrentCell.Value != null)
                    {
                        string mahanghoa = dataKhachHang.Rows[e.RowIndex].Cells[0].Value.ToString();
                        string check = dataKhachHang.Rows[e.RowIndex].Cells[6].Value.ToString();
                        if (check == "true")
                        {
                            if ((MessageBox.Show("Phục hồi hiển thự dữ liệu", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                            {
                                con.Open();
                                cmdKG = new SqlCommand("EXECUTE dbo.UID_KHACHHANG '" + mahanghoa + "',N'','','','','',N'Show'", con);
                                cmdKG.ExecuteNonQuery();
                                DisplayData();
                                con.Close();
                            }
                        }
                        
                    }
                }
            }
        }
    }
}
