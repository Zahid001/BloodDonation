using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BloodDonation
{
    public partial class DonorList : System.Web.UI.Page
    {
        Database database = new Database();
        protected void Page_Load(object sender, EventArgs e)
        {
            showList();
        }

        public void showList()
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
  FROM [dbo].[Donor]";


            GridView11.DataSource = database.showData(query);
            GridView11.DataBind();
        } 

        

        

        

        protected void btnShow_Click(object sender, EventArgs e)
        {
            //this.GridView11.Columns[0].Visible = true;
            GridView11.Visible = true;
        }

        protected void btnHide_Click(object sender, EventArgs e)
        {
           // this.GridView11.Columns[0].Visible = false;
            GridView11.Visible = false;
        }
    }
    }
