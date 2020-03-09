using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace BloodDonation
{
    public class Database
    {
        private SqlConnection sqlCon;
        private SqlDataAdapter dataAdapter;
        private SqlCommand sqlCmd;
        private DataTable dataTable;


        public void databaseConnection()
        {
            sqlCon = new SqlConnection("Data Source=DESKTOP-QN58KVA;Initial Catalog=BloodDonation;Integrated Security=True");
            sqlCon.Open();
        }
        public DataTable showData(string query)
        {
            databaseConnection();
            sqlCmd = new SqlCommand(query,sqlCon);
            dataAdapter = new SqlDataAdapter(sqlCmd);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        }
        public int queryExecution(string query)
        {
            databaseConnection();
            sqlCmd = new SqlCommand(query, sqlCon);
            try
            {
                sqlCmd.ExecuteNonQuery();
                return 1;
            }
            catch(SqlException e)
            {
                return 0;
            }
        }
        public string queryExecutionSingleValue(string query)
        {
            databaseConnection();
            sqlCmd = new SqlCommand(query, sqlCon);
            try
            {
                string result =Convert.ToString( sqlCmd.ExecuteScalar());
                return result;
            }
            catch (SqlException e)
            {
                return null;
            }
        }
        public void readMultipleValue(string query,TextBox txtBox)
        {
            string value=queryExecutionSingleValue(query);
            txtBox.Text = value;
            /*databaseConnection();
            sqlCmd = new SqlCommand(query, sqlCon);
            SqlDataReader read ;
            sqlCmd.CommandText = query;
            read = sqlCmd.ExecuteReader();
            txtBox.Text = (read[queryId].ToString()); */

        }
        public void readIntValue(string query, TextBox txtBox)
        {
            string value = queryExecutionSingleValue(query);
            txtBox.Text = value;
        }


    }
}