<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="BloodDonation.SignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="margin-left: auto; margin-right: auto; text-decoration:underline; text-align: center;font-size:larger; font-weight:bolder">
                 <asp:Label ID="Label1" runat="server" Text="Blood Donation Form" ></asp:Label>
     </div> <br /> <br /> 

    <table>
        <tr>
            <td>
                <asp:Label ID="Label12" runat="server" Text="Donor Id"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Full Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Age"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Blood Group"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtBloodGroup" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Last Date of Blood Donation"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDateBloodDonation" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Phone"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label7" runat="server" Text="Email"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label13" runat="server" Text="City"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtCity"  runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label8" runat="server" Text="Address"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtAddress" TextMode="MultiLine" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label9" runat="server" Text="User Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            </td>
            
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label10" runat="server" Text="Password"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPassword" TextMode="Password"  runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label11" runat="server" Text="Confirm Password"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtConfirmPassword" TextMode="Password"  runat="server"></asp:TextBox>
            </td>
        </tr>
        
        <tr>
            <td>

            </td>
            <td style="text-align:right">
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="Button1_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
