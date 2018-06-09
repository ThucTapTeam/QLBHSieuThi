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
    public partial class FormKhuyenMai : UserControl
    {
        public FormKhuyenMai()
        {
            InitializeComponent();
        }
        bool UpdateModeOn = false;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SSCJKUR;Initial Catalog=SieuThi;Integrated Security=True");
        SqlDataAdapter adapt;
        SqlCommand cmdKG;

        private void FomKhuyenMai_Load(object sender, EventArgs e)
        {
            DisplayData();
            //Add Modified Icon
            DataGridViewImageColumn delbut = new DataGridViewImageColumn();
            delbut.Image = Image.FromFile(Environment.CurrentDirectory + @"\icons\modified.png");
            delbut.Width = 35;
            delbut.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataKM.Columns.Add(delbut);
            //add Delete Icon
            DataGridViewImageColumn delbut2 = new DataGridViewImageColumn();
            delbut2.Image = Image.FromFile(Environment.CurrentDirectory + @"\icons\delicon.png");
            delbut2.Width = 35;
            delbut2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataKM.Columns.Add(delbut2);

            btnSave.Enabled = false;
            txtPanel.Visible = false;
            txtMaKM.Enabled = false;
            btnCancel.Visible = false;
            btnUpdate.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string inp = ddSearch.selectedValue.ToString();
            if (inp == "Mã KM")
            {
                inp = "MAKHUYENMAI";
            }
            else if (inp == "Tên KM")
            {
                inp = "TENKHUYENMAI";
            }
            else if (inp == "Phần trăm")
            {
                inp = "PHANTRAM";
            }
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from dbo.KHUYENMAI where [" + inp + "] like N'%" + inputSearch.Text + "%'", con);
            adapt.Fill(dt);
            dataKM.DataSource = dt;
            con.Close();
        }

        private void DisplayData()
        {
            con.Close();
            con.Open();
            DataTable dt = new DataTable();
            if (UserInfo.Quyen == "2")
            {
                adapt = new SqlDataAdapter("select * from dbo.KHUYENMAI", con);
            }
            else
            {
                adapt = new SqlDataAdapter("select * from dbo.KHUYENMAI where Del=0", con);
            }
            adapt.Fill(dt);
            dataKM.DataSource = dt;
            con.Close();
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void SuggestID()
        {
            int len, j, num;
            string MaKM = string.Empty, str, SugID;
            con.Close();
            con.Open();
            cmdKG = new SqlCommand("SELECT MAX(MAKHUYENMAI) as max FROM dbo.KHUYENMAI", con);
            SqlDataReader dta = cmdKG.ExecuteReader();
            if (dta.Read() == true)
            {
                MaKM = dta["max"].ToString();
                len = MaKM.Length;
                for (j = 0; j < len; j++)
                {
                    MaKM = (dta["max"].ToString()).Substring(j);
                    if (Regex.IsMatch(MaKM, @"^\d+$"))
                    {
                        break;
                    }
                }
                str = (dta["max"].ToString()).Substring(0, j);
                num = Convert.ToInt32(MaKM);
                num++;
                SugID = str + num;
            }
            else
            {
                SugID = "KM151500";
            }
            con.Close();
            txtMaKM.Text = SugID;
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
            if (txtMaKM.Text != "" && txtTenKM.Text != "" && txtPhanTram.Text != "")
            {
                if (MessageBox.Show("Xác nhận thêm khuyến mại.", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmdKG = new SqlCommand("EXECUTE dbo.UID_KHUYENMAI '" + txtMaKM.Text + "',N'" + txtTenKM.Text + 
                        "','" + txtPhanTram.Text +"','" + DPngayBDKM.Text + "','" + DPngayKTKM.Text + "',N'Insert'", con);
                    cmdKG.ExecuteNonQuery();
                    DisplayData();

                    txtMaKM.Text = "";
                    txtPhanTram.Text = "";
                    txtTenKM.Text = "";
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
            else MessageBox.Show("Nhập thiếu");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtMaKM.Text = "";
            txtTenKM.Text = "";
            txtPhanTram.Text = "";
            
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
            if (dataKM.CurrentCell.ColumnIndex.Equals(7) && e.RowIndex != -1)
            {
                if (dataKM.CurrentCell != null && dataKM.CurrentCell.Value != null)
                {
                    string maKM = dataKM.Rows[e.RowIndex].Cells[0].Value.ToString();
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
                                cmdKG = new SqlCommand("EXECUTE dbo.UID_KHUYENMAI '" + maKM + "',N'','','','',N'Delete'", con);
                            }
                            else if (UserInfo.Quyen == "1")
                            {
                                cmdKG = new SqlCommand("EXECUTE dbo.UID_KHUYENMAI '" + maKM + "',N'','','','',N'Hide'", con);
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
            if (dataKM.CurrentCell.ColumnIndex.Equals(6) && e.RowIndex != -1)
            {
                if (dataKM.CurrentCell != null && dataKM.CurrentCell.Value != null)
                {
                    txtPanel.Visible = true;
                    btnCancel.Visible = true;
                    btnSave.Visible = false;
                    btnUpdate.Visible = true;
                    btnInsert.Visible = false;
                    UpdateModeOn = true;

                    txtMaKM.Text = dataKM.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtTenKM.Text = dataKM.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtPhanTram.Text = dataKM.Rows[e.RowIndex].Cells[2].Value.ToString();
                    DPngayBDKM.Text = dataKM.Rows[e.RowIndex].Cells[3].Value.ToString();
                    DPngayKTKM.Text = dataKM.Rows[e.RowIndex].Cells[4].Value.ToString();
                }
            }
            if (dataKM.CurrentCell.ColumnIndex.Equals(5) && e.RowIndex != -1)
            {
                if (dataKM.CurrentCell != null && dataKM.CurrentCell.Value != null)
                {
                    string maKM = dataKM.Rows[e.RowIndex].Cells[0].Value.ToString();
                    if ((MessageBox.Show("Phục hồi hiển thự dữ liệu", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        con.Open();
                        if (UserInfo.Quyen == "2")
                        {
                            cmdKG = new SqlCommand("EXECUTE dbo.UID_KHUYENMAI '" + maKM + "',N'','','','',N'Show'", con);
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
            if (txtTenKM.Text != "" && txtPhanTram.Text != "" && UpdateModeOn == true)
            {
                if ((MessageBox.Show("Xác nhận SỬA ", "Xác nhận SỬA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    con.Open();
                    cmdKG = new SqlCommand("EXECUTE dbo.UID_KHUYENMAI '" + txtMaKM.Text + "',N'" + txtTenKM.Text + "','" + txtPhanTram.Text +
                        "','" + DPngayBDKM.Text + "','" + DPngayKTKM.Text + "',N'Update'", con);
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
