using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BloodDonation
{
    public partial class LogIn : System.Web.UI.Page
    {
        public Boolean logInStatus=false;
        Database database = new Database();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Response.Redirect("SignUp.aspx");
        }

        protected void btnLogIn_Click(object sender, EventArgs e)
        {
            string queryAdminUserName = @"SELECT [adminId]
  FROM[dbo].[Admin]";

            string adminUserName = database.queryExecutionSingleValue(queryAdminUserName);

            string queryAdminPassword = @"SELECT [adminPassword]
  FROM[dbo].[Admin]";
            string adminUserPassword = database.queryExecutionSingleValue(queryAdminPassword);

            string queryUserName = @"SELECT [userName] FROM [dbo].[Donor]
WHERE  [userName] = '"+txtLogName.Text+ "'  AND [password] ='" + txtLogPassword.Text + "' ";
            string queryUserPassword = @"SELECT [password] FROM [dbo].[Donor]
WHERE  [userName] = '" + txtLogName.Text + "'  AND [password] = '" + txtLogPassword.Text + "' ";

            string UserName =database.queryExecutionSingleValue(queryUserName);
            string UserPassword = database.queryExecutionSingleValue(queryUserPassword);

            if (txtLogName.Text == adminUserName && txtLogPassword.Text == adminUserPassword)
            {
                logInStatus = true;
                Response.Redirect("LogIn.aspx");
            }
            else if (txtLogName.Text == UserName && txtLogPassword.Text == UserPassword)
            {
                logInStatus = true;
                Response.Redirect("LogIn.aspx");
            }
             else
             {      
                 Response.Redirect("SearchBlood.aspx");
             } 
        }
    }    
}