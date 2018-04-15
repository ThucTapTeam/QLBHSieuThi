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
    public partial class FormHangHoa : UserControl
    {
        public FormHangHoa()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=SieuThi;Integrated Security=True");
        SqlDataAdapter adapt;
        SqlCommand cmdKG;

        private void FomHangHoa_Load(object sender, EventArgs e)
        {
            this.hANGHOATableAdapter.Fill(this.qLBHSieuThiDataSet_HANGHOA.HANGHOA);
            //Add Modified Icon
            DataGridViewImageColumn delbut = new DataGridViewImageColumn();
            delbut.Image = Image.FromFile(Environment.CurrentDirectory + @"\icons\modified.png");
            delbut.Width = 40;
            delbut.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataHangHoa.Columns.Add(delbut);
            //add Delete Icon
            DataGridViewImageColumn delbut2 = new DataGridViewImageColumn();
            delbut2.Image = Image.FromFile(Environment.CurrentDirectory + @"\icons\delicon.png");
            delbut2.Width = 40;
            delbut2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataHangHoa.Columns.Add(delbut2);
            
            btnSave.Enabled = false;
            txtPanel.Visible = false;
            ///
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

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from dbo.HANGHOA ", con);
            adapt.Fill(dt);
            dataHangHoa.DataSource = dt;
            con.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            txtPanel.Visible = true;
            btnSave.Enabled = true;
            btnInsert.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnInsert.Enabled = true;
            btnSave.Enabled = false;
            txtPanel.Visible = false;
        }
    }
}
