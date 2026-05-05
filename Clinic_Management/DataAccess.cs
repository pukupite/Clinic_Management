using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Clinic_Management
{
    internal class DataAccess
    {

        private SqlConnection sqlcon;
        private SqlCommand sqlcom;
        private SqlDataAdapter sda;
        private DataSet ds;

        public DataAccess()
        {
            this.sqlcon = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=""ClinicDB"";Integrated Security=True;");
        }

        private void QueryText(string query)
        {
            this.sqlcom = new SqlCommand(query, this.sqlcon);
        }

      
        public DataSet ExecuteQuery(string sql)
        {
            try
            {
                this.QueryText(sql);
                this.sda = new SqlDataAdapter(this.sqlcom);
                this.ds = new DataSet();

                this.sqlcon.Open();
                this.sda.Fill(this.ds);
                this.sqlcon.Close();

                return this.ds;
            }
            catch (Exception ex)
            {
                this.sqlcon.Close();
                throw ex;
            }
        }

        public DataTable ExecuteQueryTable(string sql)
        {
            try
            {
                this.QueryText(sql);
                this.sda = new SqlDataAdapter(this.sqlcom);
                this.ds = new DataSet();

                this.sqlcon.Open();
                this.sda.Fill(this.ds);
                this.sqlcon.Close();

                return this.ds.Tables[0];
            }
            catch (Exception)
            {
                this.sqlcon.Close();
                throw;
            }
        }
        
        public int ExecuteUpdateQuery(string sql)
        {
            try
            {
                this.QueryText(sql);
                this.sqlcon.Open();
                int rows = this.sqlcom.ExecuteNonQuery();
                this.sqlcon.Close();

                return rows;
            }
            catch (Exception ex)
            {
                this.sqlcon.Close();
                throw ex;
            }
        }


    }
}
