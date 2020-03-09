using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BloodDonation
{

    public partial class AlternativeSearch : System.Web.UI.Page
    {
        Database database = new Database();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (DropDownList1.Text == "City")
            {
                searchDataForCity();
            }
            else
            {
                searchDataForAge();
            }
        }

        public void searchDataForCity()
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
  FROM [dbo].[Donor] WHERE bloodGroup = '" + txtBloodGroup.Text + "' AND  city = '" + txtAlternativeSearch.Text + "'  ";


            GridView1.DataSource = database.showData(query);
            GridView1.DataBind();
        }
        public void searchDataForAge()
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
  FROM [dbo].[Donor] WHERE bloodGroup = '" + txtBloodGroup.Text + "' AND  age = '" + txtAlternativeSearch.Text + "'  ";


            GridView1.DataSource = database.showData(query);
            GridView1.DataBind();
        }
    }
}