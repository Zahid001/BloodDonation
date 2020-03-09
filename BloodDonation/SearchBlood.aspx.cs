using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BloodDonation
{
    public partial class SearchBlood : System.Web.UI.Page
    {
        Database database = new Database();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearchAlternate_Click(object sender, EventArgs e)
        {
            Response.Redirect("AlternativeSearch.aspx");
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            searchData();
        }

        public void searchData()
        {
            string query = @"SELECT [donorId]
      ,[name]
      ,[age]
      ,[bloodGroup]
      ,[lastBloodDate]
      ,[phone]
      ,[email]
      ,[city]
      ,[address]
  FROM [dbo].[Donor] WHERE bloodGroup = '"+ txtSearchBlood.Text + "'";

            
            GridView1.DataSource=database.showData(query);
            GridView1.DataBind();
        }
    }
}