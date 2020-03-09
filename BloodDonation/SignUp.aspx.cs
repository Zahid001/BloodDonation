using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BloodDonation
{
    public partial class SignUp : System.Web.UI.Page
    {
        Database database = new Database();
        LogIn lg = new LogIn();
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (lg.logInStatus == true)
            {
                Response.Redirect("LogOut.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text == txtPassword.Text)
            {
                insertValue();
                Response.Redirect("LogIn.aspx");
            }
            else
            {
                string msg = "Password Missmatch";
                Response.Write("<script>alert('" + msg + "')</script>");
            }
            
            /* Boolean Button1_Click = true;
             string msg = "Successfully Submited";
             Response.Write("<script>alert('" + msg + "')</script>");
             btnSubmit.Visible = false;
             Button btn = new Button();
             Button clickedButton = (Button)sender;
             btn.Text = "OK";
             if (Button1_Click == true  && btn.Text=="OK")
             {
                 Response.Redirect("LogIn.aspx");
             }
             //Response.Redirect("LogIn.aspx"); */

        }

        public void insertValue()
        {
            string query = @"INSERT INTO [dbo].[Donor]
           ([donorId]
           ,[name]
           ,[age]
           ,[bloodGroup]
           ,[lastBloodDate]
           ,[phone]
           ,[email]
           ,[city]
           ,[address]
           ,[userName]
           ,[password])
     VALUES ('"+txtId.Text+"','"+txtName.Text + "','"+txtAge.Text + "','"+txtBloodGroup.Text + "','"+txtDateBloodDonation.Text+ "','"+txtPhone.Text+ "','"+txtEmail.Text + "','"+txtCity.Text + "','"+txtAddress.Text + "','"+txtUserName.Text + "','"+txtPassword.Text + "')";
            database.queryExecution(query);
        }


    }
}