using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHangSieuThi.Layout
{
    public partial class sub_formDonHang : Form
    {
        public sub_formDonHang()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=SieuThi;Integrated Security=True");
        SqlDataAdapter adapt;
        SqlCommand cmdDH;
        string SugID, maKH, maSP, maKM;

        private void sub_formDonHang_Load(object sender, EventArgs e)
        {
            SuggestID();
            LoadMaDH();
            //Load values for combobox [Mã sản phẩm]
            con.Open();
            DataTable dt1 = new DataTable();
            adapt = new SqlDataAdapter("SELECT TENSANPHAM+' / '+MASANPHAM AS TEN FROM dbo.HANGHOA", con);
            adapt.Fill(dt1);
            foreach (DataRow row in dt1.Rows)
            {
                cmbSP.Items.Add((string)row["TEN"]);
            }
            con.Close();
            
            con.Open();
            DataTable dt2 = new DataTable();
            adapt = new SqlDataAdapter("SELECT HOTEN+'('+MAKHACH+')' as KhachHang FROM dbo.KHACHHANG", con);
            adapt.Fill(dt2);
            foreach (DataRow row in dt2.Rows)
            {
                cmbKH.Items.Add((string)row["KhachHang"]);
            }
            con.Close();
            //Load values for combobox [Mã khuyến mại]
            con.Open();
            DataTable dt3 = new DataTable();
            adapt = new SqlDataAdapter("select [TENKHUYENMAI]+' / '+MAKHUYENMAI as KM from dbo.[KHUYENMAI] WHERE GETDATE() BETWEEN NGAYBATDAU AND NGAYKETTHUC", con);
            adapt.Fill(dt3);
            foreach (DataRow row in dt3.Rows)
            {
                cmbMaKM.Items.Add((string)row["KM"]);
            }
            con.Close();
            DPDatHang.Value = DateTime.Now;
            DPGiaoHang.Value = DateTime.Now;
            txtNVGD.Text = UserInfo.HoTen;
        }

        private void SuggestID()
        {
            int num;
            string MaDonHang = string.Empty, str;
            con.Close();
            con.Open();
            cmdDH = new SqlCommand("SELECT MAX(MADONHANG) as max FROM dbo.DONHANG", con);
            SqlDataReader dta = cmdDH.ExecuteReader();
            if (dta.Read() == true)
            {
                MaDonHang = dta["max"].ToString();
                str = (dta["max"].ToString()).Substring(0, 2);
                num = Convert.ToInt32(MaDonHang.Substring(2));
                num++;
                SugID = str + num;
                cmbMaDon.Text = SugID;
            }
            else
            {
                SugID = "DH150000";
                cmbMaDon.Text = SugID;
            }
            con.Close();
        }

        private void LoadMaDH()
        {
            cmbMaDon.Items.Clear();
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select [MADONHANG] from dbo.[VIEW_DONHANG]", con);
            adapt.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                cmbMaDon.Items.Add((string)row["MADONHANG"]);
            }
            con.Close();
            SuggestID();
            cmbMaDon.Items.Add(SugID);
        }

        private bool isExist(string inp ,string inp1, string inp2, string inp3)
        {
            con.Open();
            cmdDH = new SqlCommand("SELECT MADONHANG FROM dbo.DONHANG WHERE MADONHANG ='"+inp+"' ",con);
            SqlDataReader dta = cmdDH.ExecuteReader();
            if (dta.Read() == false && inp!=SugID)
            {
                con.Close();
                MessageBox.Show("Không tồn tại mã đơn hàng này.");
                return false;
            }
            else
            {
                con.Close();
                con.Open();
                cmdDH = new SqlCommand("SELECT MAKHACH FROM dbo.KHACHHANG WHERE MAKHACH='" + inp1 + "'", con);
                SqlDataReader dta1 = cmdDH.ExecuteReader();
                if (dta1.Read() == false)
                {
                    con.Close();
                    MessageBox.Show("Không tồn tại khách hàng này.");
                    return false;
                }
                else
                {
                    con.Close();
                    con.Open();
                    cmdDH = new SqlCommand("SELECT MASANPHAM FROM dbo.HANGHOA WHERE MASANPHAM='" + inp2 + "'", con);
                    SqlDataReader dta2 = cmdDH.ExecuteReader();
                    if (dta2.Read() == false)
                    {
                        con.Close();
                        MessageBox.Show("Sản phẩm này không tồn tại.");
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
                            if (inp3 == "")
                            {
                                con.Close();
                                return true;
                            }
                            else
                            {
                                MessageBox.Show("Mã khuyến mại không tồn tại.");
                                con.Close();
                                return false;
                            }
                        }
                        else
                        {
                            con.Close();
                            return true;
                        }
                    }
                }
            }
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Check_OnValueChange(object sender, EventArgs e)
        {
            if (Check.Value == true)
                cmbMaDon.Enabled = true;
            else
                cmbMaDon.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("/" + maKM + "/");
            if ( isExist(cmbMaDon.Text,maKH, maSP, maKM))
            {
                con.Open();
                cmdDH = new SqlCommand("EXECUTE dbo.UID_DONHANG '"+cmbMaDon.Text+"','"+maSP+"','"+maKH+"','"+txtSL.Value+"','"+maKM+
                        "','"+DPDatHang.Value.ToShortDateString()+"','"+DPGiaoHang.Value.ToShortDateString()+"','"+txtNVGD.Text+"','Insert'", con);
                cmdDH.ExecuteNonQuery();
                con.Close();
                this.Hide();
            }
        }

        private void cmbMaKM_SelectedValueChanged(object sender, EventArgs e)
        {
            maKM = cmbMaKM.Text;
            int len = maKM.Length;
            int vt = maKM.IndexOf("/");
            maKM = maKM.Substring(vt + 2, len - vt - 2);
        }

        private void cmbKH_SelectedValueChanged(object sender, EventArgs e)
        {
            maKH = cmbKH.Text;
            int len = maKH.Length;
            int vt = maKH.IndexOf("(");
            maKH = maKH.Substring(vt + 1, len - vt - 2);//Tách mã khách chỉ còn mã không còn tên 
        }

        private void cmbSP_SelectedValueChanged(object sender, EventArgs e)
        {
            maSP = cmbSP.Text;
            int len = maSP.Length;
            int vt = maSP.IndexOf("/");
            maSP = maSP.Substring(vt + 2, len - vt - 2);//Tách mã khách chỉ còn mã không còn tên 
        }
    }
}
