using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace HospitalIMS.Models
{
    public class Functions
    {
        private SqlConnection Con;
        private SqlCommand Cmd;
        private DataTable dt;
        private string ConStr;
        private SqlDataAdapter sda;
        public Functions()
        {
            ConStr = "Data Source=GAURAV\\SQLEXPRESS;Initial Catalog=ClinicASPDb;Integrated Security=True";
            Con=new SqlConnection (ConStr);
            Cmd=new SqlCommand();
            Cmd.Connection = Con;
        }
        public int SetDatas(string sql)
        {
            int cnt = 0;
            if(Con.State==ConnectionState.Closed)
            {
                Con.Open();
            }
            Cmd.CommandText = sql;
            cnt=Cmd.ExecuteNonQuery();
            Con.Close();

            return cnt;
        }
        public DataTable GetDatas(string Query) 
        {
            dt=new DataTable();
            sda=new SqlDataAdapter(Query,ConStr);
            sda.Fill(dt);
            return dt;
        }
    }
}