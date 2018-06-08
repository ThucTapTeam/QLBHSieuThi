using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHangSieuThi.Layout
{
    public partial class FormDoanhThu : UserControl
    {
        Connection conn = new Connection();
        ChuanHoa ch = new ChuanHoa();
        public FormDoanhThu()
        {
            InitializeComponent();
            DPDoanhThu.Value = DateTime.Now;
            TongDoanhThu();
            LoiNhuan();
            HangBanRa();
        }
        string day, month, year;
        string day1, month1, year1;
        private void DPDoanhThu_Change(object sender, EventArgs e)
        {
            TongDoanhThu1();
        }

        private void switchdoanhthu_Change(object sender, EventArgs e)
        {
            TongDoanhThu();
        }

        public void TongDoanhThu()
        {
            if (switchdoanhthu.Value == true)
            {
                ch.ChuanHoaDate(DPDoanhThu.Value.ToString(), out day, out month, out year);
                lbtongtien.Text = conn.LayBien("EXEC PROC_TONGTIEN1 '" + day + "','" + month + "','" + year + "'", 0);
                lbtienlai.Text = conn.LayBien("EXEC PROC_TONGTIENLAI1 '" + day + "','" + month + "','" + year + "'", 0);
                lbsohang.Text = conn.LayBien("EXEC PROC_SOHANGBANRA1 '" + day + "','" + month + "','" + year + "'", 0);

            }
            else
            {
                lbtongtien.Text = conn.LayBien("EXEC PROC_TONGTIEN", 0);
                lbtienlai.Text = conn.LayBien("EXEC PROC_TONGTIENLAI", 0);
                lbsohang.Text = conn.LayBien("EXEC PROC_SOHANGBANRA", 0);
            }
        }
        public void TongDoanhThu1()
        {
            if (switchdoanhthu.Value == true)
            {
                ch.ChuanHoaDate(DPDoanhThu.Value.ToString(), out day, out month, out year);
                lbtongtien.Text = conn.LayBien("EXEC PROC_TONGTIEN1 '" + day + "','" + month + "','" + year + "'", 0);
                lbtienlai.Text = conn.LayBien("EXEC PROC_TONGTIENLAI1 '" + day + "','" + month + "','" + year + "'", 0);
                lbsohang.Text = conn.LayBien("EXEC PROC_SOHANGBANRA1 '" + day + "','" + month + "','" + year + "'", 0);
            }
        }
        public void LoiNhuan()
        {
            int loinhuanthangnay = 0;
            int loinhuanthangtrc = 0;
            ch.ChuanHoaDate(DateTime.Now.ToString(), out day, out month, out year);
            if (month == "1")
            {
                month1 = "12";
                year1 = (Convert.ToInt32(year) - 1).ToString();
            }
            else
            {
                month1 = (Convert.ToInt32(month) - 1).ToString();
            }
            loinhuanthangnay = Convert.ToInt32(conn.LayBien("PROC_LOINHUAN '" + month + "','" + year + "'", 0));
            loinhuanthangtrc = Convert.ToInt32(conn.LayBien("PROC_LOINHUAN '" + month1 + "','" + year1 + "'", 0));
            if (loinhuanthangnay > loinhuanthangtrc)
            {
                lbtgloinhuan.Text = "Tăng";
                if (loinhuanthangtrc != 0)
                {
                    CPloinhuan.Value = (loinhuanthangtrc * 100 / loinhuanthangnay);
                }
                else
                {
                    CPloinhuan.Value = 100;
                }

            }
            else if (loinhuanthangnay < loinhuanthangtrc)
            {
                lbtgloinhuan.Text = "Giảm";
                if (loinhuanthangnay != 0)
                {
                    CPloinhuan.Value = (loinhuanthangnay * 100 / loinhuanthangtrc);
                }
                else
                {
                    CPloinhuan.Value = 100;
                }
            }
            else
            {
                lbtgloinhuan.Text = "Không đổi";
                CPloinhuan.Value = 0;
            }
        }
        public void HangBanRa()
        {
            int hangbanthangnay = 0;
            int hangbanthangtrc = 0;
            ch.ChuanHoaDate(DateTime.Now.ToString(), out day, out month, out year);
            if (month == "1")
            {
                month1 = "12";
                year1 = (Convert.ToInt32(year) - 1).ToString();
            }
            else
            {
                month1 = (Convert.ToInt32(month) - 1).ToString();
            }
            hangbanthangnay = Convert.ToInt32(conn.LayBien("PROC_HANGBANRA '" + month + "','" + year + "'", 0));
            hangbanthangtrc = Convert.ToInt32(conn.LayBien("PROC_HANGBANRA '" + month1 + "','" + year1 + "'", 0));
            if (hangbanthangnay > hangbanthangtrc)
            {
                lbtghangban.Text = "Tăng";
                if (hangbanthangtrc != 0)
                {
                    CPhangban.Value = (hangbanthangtrc * 100 / hangbanthangnay);
                }
                else
                {
                    CPhangban.Value = 100;
                }

            }
            else if (hangbanthangnay < hangbanthangtrc)
            {
                lbtghangban.Text = "Giảm";
                if (hangbanthangnay != 0)
                {
                    CPhangban.Value = (hangbanthangnay * 100 / hangbanthangtrc);
                }
                else
                {
                    CPhangban.Value = 100;
                }
            }
            else
            {
                lbtghangban.Text = "Không đổi";
                CPhangban.Value = 0;
            }
        }
    }
}
