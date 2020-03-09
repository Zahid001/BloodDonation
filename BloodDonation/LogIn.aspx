<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="BloodDonation.LogIn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <div style="margin-left: auto; margin-right: auto; text-align: center;font-size:larger; font-weight:bolder">
                 <asp:Label ID="Label1" runat="server" Text="Welcome To Blood Donation" ></asp:Label>
     </div> <br /> <br /> <br />
    
  <!--  <div style="text-align: center;font-weight:bold; font-size:medium"> -->
     <table style="text-align: left;font-weight:bold; font-size:medium">
          <tr>
              <td>
                  <asp:Label ID="Label2"  runat="server" Text="Name" ></asp:Label>
              </td>
              <td>
                  <asp:TextBox ID="txtLogName" runat="server"></asp:TextBox>
              </td>
         </tr>
         <tr>
              <td>
                  <asp:Label ID="Label3" runat="server" Text="Password" ></asp:Label>
              </td>
              <td>
                  <asp:TextBox ID="txtLogPassword" TextMode="Password" runat="server"></asp:TextBox>
              </td>
        </tr>
         <tr>
             <td>
                 
             </td>
             <td style="font-weight:900;">
                 <asp:Button ID="Button1" runat="server" Text="Sign Up" OnClick="Button1_Click" />
                 <asp:Button ID="btnLogIn" runat="server" Text="Log In" OnClick="btnLogIn_Click" />
             </td>
         </tr>
    </table>

    
       <br />
       
        
    

        
            
               
            
           
        
    

</asp:Content>
