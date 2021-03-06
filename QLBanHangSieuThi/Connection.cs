﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QLBanHangSieuThi
{
    class Connection
    {
        string conn= @"Data Source=DESKTOP-SSCJKUR;Initial Catalog=SieuThi;Integrated Security=True";
        SqlConnection sqlconn;
        SqlCommand sqlcom;
        SqlDataReader sqldatar;
        DataSet ds = new DataSet();
        public void ketnoi()
        {
            sqlconn = new SqlConnection(conn);
            sqlconn.Open();
        }
        public void ngatketnoi()
        {
            sqlconn.Close();
        }
        public bool ktlogin(string data,string strsql,byte cot)
        {
            bool ok = false;
            ketnoi();
            sqlcom = new SqlCommand(strsql, sqlconn);
            sqldatar = sqlcom.ExecuteReader();
            while(sqldatar.Read())
            {
                if(data.ToLower() == sqldatar[cot].ToString().ToLower())
                {
                    ok = true;
                }
            }
            ngatketnoi();
            return ok;
            
        }
        public string LayBien(string strsql, byte cot)
        {
            string temp = null;
            ketnoi();
            sqlcom = new SqlCommand(strsql, sqlconn);
            sqldatar = sqlcom.ExecuteReader();
            while (sqldatar.Read())
            {
                temp = sqldatar[cot].ToString();

            }
            if (temp == "")
            {
                temp = "0";
            }
            ngatketnoi();
            return temp;
        }
        public bool LayBien1(string data, string strsql, byte cot)
        {
            bool ok = false;
            ketnoi();
            sqlcom = new SqlCommand(strsql, sqlconn);
            sqldatar = sqlcom.ExecuteReader();
            while (sqldatar.Read())
            {
                if (data == sqldatar[cot].ToString())
                {
                    ok = true;
                }
            }
            ngatketnoi();
            return ok;
        }

        public bool tongquan1(string data,string strsql, byte cot)
        {
            bool ok = false;
            ketnoi();
            sqlcom = new SqlCommand(strsql, sqlconn);
            sqldatar = sqlcom.ExecuteReader();
            while (sqldatar.Read())
            {
                if(data == sqldatar[cot].ToString())
                {
                    ok = true;
                }
            }
            ngatketnoi();
            return ok;
        }
        public void getUserInfo(string user)
        {
            ketnoi();
            string sql = "select * from dbo.USERS where USERNAME='" + user +"'";
            sqlcom = new SqlCommand(sql, sqlconn);
            sqldatar = sqlcom.ExecuteReader(); //select ExecuteReader();  insert/delete ExecuteNonQuery
            if (sqldatar.Read() == true)
            {
                UserInfo.ID = user;
                UserInfo.HoTen = sqldatar["USERNAME"].ToString();
                UserInfo.Quyen = sqldatar["QUYEN"].ToString();
                ngatketnoi();
            }
            else ngatketnoi();
        }
    }
}
