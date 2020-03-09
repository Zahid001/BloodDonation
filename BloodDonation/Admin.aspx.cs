using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BloodDonation
{
    public partial class Admin : System.Web.UI.Page
    {
        Database database = new Database();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            deleteInfo();
        }

        public void deleteInfo()
        {
            string query = @"DELETE FROM [dbo].[Donor]
      WHERE donorId = '"+ txtDeleteId.Text +"'";
            database.queryExecution(query);
        }

   //     protected void btnUpdate_Click(object sender, EventArgs e)
   //     {
   //         updateName();
   //     }

   //     public void updateName()
   //     {
   //         string query = @"UPDATE [dbo].[Donor]
   //SET [name] = '" + txtNameUpdate.Text + "' WHERE  [donorId] = '"+ txtId.Text + "' ";
   //         database.queryExecution(query);
   //     }

   //     protected void btnUpdate2_Click(object sender, EventArgs e)
   //     {
   //         updateAge();
   //     }
   //     public void updateAge()
   //     {
   //         string query = @"UPDATE [dbo].[Donor]
   //SET [age] = '" + txtAge.Text +"' WHERE  [donorId] = '" + txtId2.Text + "'";
   //         database.queryExecution(query);
   //     }

   //     protected void btnUpdate3_Click(object sender, EventArgs e)
   //     {
   //         updateLastDateOfBloodDonation();
   //     }
   //     public void updateLastDateOfBloodDonation()
   //     {
   //         string query = @"UPDATE [dbo].[Donor]
   //SET [lastBloodDate] = '" + txtLastBloodDonation.Text +"' WHERE  [donorId] = '" + txtId3.Text + "'";
   //         database.queryExecution(query);
   //     }

        //protected void btnUpdate4_Click(object sender, EventArgs e)
        //{
        //    updateCity();
        //}
   //     public void updateCity()
   //     {
   //         string query = @"UPDATE [dbo].[Donor]
   //SET [city] = '" + txtCity.Text +"' WHERE  donorId = '" + txtId4.Text + "'";
   //         database.queryExecution(query);
   //     }

        //protected void btnUpdate5_Click(object sender, EventArgs e)
        //{
        //    updatePhone();
        //}
   //     public void updatePhone()
   //     {
   //         string query = @"UPDATE [dbo].[Donor]
   //SET [phone] = '" + txtPhone.Text +"' WHERE  donorId = '" + txtId5.Text + "'";
   //         database.queryExecution(query);
   //     }

        protected void btnUpdate6_Click(object sender, EventArgs e)
        {

        }
   //     public void updateMail()
   //     {
   //         string query = @"UPDATE [dbo].[Donor]
   //SET [email] = '" + txtEmail.Text +"' WHERE  donorId = '" + txtId6.Text + "'";
   //         database.queryExecution(query);
   //     }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
          /*  string id = DropDownList1.Text; ;
            string query = @"SELECT [donorId]
      ,[name]
      ,[age]
      ,[bloodGroup]
      ,[lastBloodDate]
      ,[phone]
      ,[email]
      ,[city]
      ,[address]
      ,[userName]
      ,[password]
  FROM [dbo].[Donor] WHERE donorId = "+ id +" ";

            if(DropDownList1.SelectedItem.Value == DropDownList1.SelectedValue)
            {
                
                database.readMultipleValue(query, "name",txtNameUpdate);
                database.readMultipleValue(query, "age", txtAge);
                database.readMultipleValue(query, "lastBloodDate", txtLastBloodDonation);
                database.readMultipleValue(query, "city", txtCity);
                database.readMultipleValue(query, "phone", txtPhone);
                database.readMultipleValue(query, "email", txtEmail);

            } */
        }

        protected void txtEdit_Click(object sender, EventArgs e)
        {
            string id = DropDownList1.Text; ;
         /*   string query = @"SELECT [donorId]
        ,[name]
        ,[age]
        ,[bloodGroup]
        ,[lastBloodDate]
        ,[phone]
        ,[email]
        ,[city]
        ,[address]
        ,[userName]
        ,[password]
    FROM [dbo].[Donor] WHERE donorId = '" + id + "' "; 
           // string query = @"SELECT *  FROM Donor WHERE donorId = '" + id + "' "; */
            string queryName= @"SELECT [name] FROM Donor WHERE donorId = '" + id + "' ";
            string queryAge = @"SELECT [age] FROM Donor WHERE donorId = '" + id + "' ";
            string queryLastBloodDonation = @"SELECT [lastBloodDate] FROM Donor WHERE donorId = '" + id + "' ";
            string queryCity = @"SELECT [city] FROM Donor WHERE donorId = '" + id + "' ";
            string queryPhone = @"SELECT [phone] FROM Donor WHERE donorId = '" + id + "' ";
            string queryEmail = @"SELECT [email] FROM Donor WHERE donorId = '" + id + "' ";

            if (DropDownList1.SelectedItem.Value == DropDownList1.SelectedValue)
            {

                database.readMultipleValue(queryName,  txtNameUpdate);
                database.readMultipleValue(queryAge,  txtAge);
                database.readMultipleValue(queryLastBloodDonation,  txtLastBloodDonation);
                database.readMultipleValue(queryCity,  txtCity);
                database.readMultipleValue(queryPhone,  txtPhone);
                database.readMultipleValue(queryEmail,  txtEmail);

            }
        }

        protected void btnUpdate_Click1(object sender, EventArgs e)
        {
            string query = @"UPDATE [dbo].[Donor]
   SET [name] = ' " + txtNameUpdate.Text + " ' ,[age] = '" +txtAge.Text+  "' ,[lastBloodDate] = '" + txtLastBloodDonation.Text +  "' ,[phone] = '" +txtPhone.Text+ "' ,[email] = '" +txtEmail.Text+ "' ,[city] = '" +txtCity.Text+ "' WHERE donorId = '" + DropDownList1.Text + "'";

            database.queryExecution(query);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string query = @"DELETE * FROM [dbo].[Donor]";
            database.queryExecution(query);
        }

        /*",[age] = <age, int,>
      ,[bloodGroup] = <bloodGroup, nvarchar(10),>
      ,[lastBloodDate] = <lastBloodDate, nvarchar(50),>
      ,[phone] = <phone, int,>
      ,[email] = <email, nvarchar(50),>
      ,[city] = <city, nvarchar(50),>
      ,[address] = <address, nvarchar(150),>
      ,[userName] = <userName, nvarchar(50),>
      ,[password] = <password, nvarchar(50),> */
    }
}
 