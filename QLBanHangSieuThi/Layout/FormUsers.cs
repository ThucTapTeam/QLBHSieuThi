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
    public partial class FormUsers : UserControl
    {
        public FormUsers()
        {
            InitializeComponent();
        }

        bool UpdateModeOn = false;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SSCJKUR;Initial Catalog=SieuThi;Integrated Security=True");
        SqlDataAdapter adapt;
        SqlCommand cmdKG;

        private void FormUsers_Load(object sender, EventArgs e)
        {
            DisplayData();
            //Add Modified Icon
            DataGridViewImageColumn delbut = new DataGridViewImageColumn();
            delbut.Image = Image.FromFile(Environment.CurrentDirectory + @"\icons\modified.png");
            delbut.Width = 35;
            delbut.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataUsers.Columns.Add(delbut);
            //add Delete Icon
            DataGridViewImageColumn delbut2 = new DataGridViewImageColumn();
            delbut2.Image = Image.FromFile(Environment.CurrentDirectory + @"\icons\delicon.png");
            delbut2.Width = 35;
            delbut2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataUsers.Columns.Add(delbut2);

            btnSave.Enabled = false;
            txtPanel.Visible = false;
            txtQuyen.Text = "1";
            txtQuyen.Enabled = false;
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
                adapt = new SqlDataAdapter("select * from dbo.USERS", con);
            }
            else
            {
                adapt = new SqlDataAdapter("select * from dbo.USERS where Del=0", con);
            }
            adapt.Fill(dt);
            dataUsers.DataSource = dt;
            con.Close();
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
            dataUsers.DataSource = dt;
            con.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtHoTen.Text = "";
            txtGT.ResetText();
            txtEmail.Text = "";
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
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text != "" && txtHoTen.Text != "" && txtEmail.Text != "")
            {
                if (MessageBox.Show("Xác nhận thêm mặt hàng.", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmdKG = new SqlCommand("EXECUTE dbo.UID_USERS '" + txtUserName.Text + "','"+"1"+"',N'" + txtHoTen.Text + "','" + txtGT.Text + 
                        "','" + txtEmail.Text +"','" + txtQuyen.Text + "',N'Insert'", con);
                    cmdKG.ExecuteNonQuery();
                    DisplayData();

                    txtUserName.Text = "";
                    txtHoTen.Text = "";
                    txtEmail.Text = "";
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" && txtHoTen.Text != "" && txtEmail.Text != "" && UpdateModeOn == true)
            {
                if ((MessageBox.Show("Xác nhận SỬA ", "Xác nhận SỬA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    con.Open();
                    cmdKG = new SqlCommand("EXECUTE dbo.UID_USERS '" + txtUserName.Text + "','" + "1" + "',N'" + txtHoTen.Text + "','" + txtGT.Text +
                        "','" + txtEmail.Text + "','" + txtQuyen.Text + "',N'Update'", con);
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
            if (dataUsers.CurrentCell.ColumnIndex.Equals(7) && e.RowIndex != -1)
            {
                if (dataUsers.CurrentCell != null && dataUsers.CurrentCell.Value != null)
                {
                    string maNV = dataUsers.Rows[e.RowIndex].Cells[0].Value.ToString();
                    con.Open();
                    if (UpdateModeOn == true)
                    {
                        MessageBox.Show("Không thể xóa khi đang sửa");
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show(UserInfo.Quyen);
                        if (MessageBox.Show("Xác nhận XOÁ ", "Xác nhận XOÁ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            cmdKG = new SqlCommand("EXECUTE dbo.UID_USERS '" + txtUserName.Text + "','" + "" + "',N'','','','',N'Delete'", con);
                            cmdKG.ExecuteNonQuery();
                            con.Close();
                            DisplayData();
                        }
                        con.Close();
                    }
                }
            }
            if (dataUsers.CurrentCell.ColumnIndex.Equals(6) && e.RowIndex != -1)
            {
                if (dataUsers.CurrentCell != null && dataUsers.CurrentCell.Value != null)
                {
                    string check = dataUsers.Rows[e.RowIndex].Cells[4].Value.ToString();
                    if (check == "2")
                    {
                        txtQuyen.Enabled = false;
                    }
                    else txtQuyen.Enabled = true;
                    txtUserName.Enabled = false;
                    txtPanel.Visible = true;
                    btnCancel.Visible = true;
                    btnSave.Visible = false;
                    btnUpdate.Visible = true;
                    btnInsert.Visible = false;
                    UpdateModeOn = true;
                    txtUserName.Text = dataUsers.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtHoTen.Text = dataUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtGT.Text = dataUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtEmail.Text = dataUsers.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txtQuyen.Text = dataUsers.Rows[e.RowIndex].Cells[4].Value.ToString();
                }
            }
            if (dataUsers.CurrentCell.ColumnIndex.Equals(5) && e.RowIndex != -1)
            {
                if (dataUsers.CurrentCell != null && dataUsers.CurrentCell.Value != null)
                {
                    string check = dataUsers.Rows[e.RowIndex].Cells[5].Value.ToString();
                    if(check== "true")
                    {
                        if ((MessageBox.Show("Phục hồi hiển thự dữ liệu", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                        {
                            con.Open();
                            cmdKG = new SqlCommand("EXECUTE dbo.UID_USERS '" + txtUserName.Text + "','" + "" + "',N'','','','',N'Show'", con);
                            cmdKG.ExecuteNonQuery();
                            con.Close();
                            DisplayData();
                        }
                    }
                    else
                    {
                        con.Open();
                        cmdKG = new SqlCommand("EXECUTE dbo.UID_USERS '" + txtUserName.Text + "','" + "" + "',N'','','','',N'Hide'", con);
                        cmdKG.ExecuteNonQuery();
                        con.Close();
                        DisplayData();
                    }
                }
            }
        }
    }
}
