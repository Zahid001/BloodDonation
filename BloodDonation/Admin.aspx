<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="BloodDonation.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="margin-left: auto; margin-right: auto; text-decoration:underline; text-align: center;font-size:larger; font-weight:bolder">
                 <asp:Label ID="Label1" runat="server" Text="Admin Panel" ></asp:Label> <br /> <br /> <br />
        </div>
    <div>
        <h3>Update Information</h3>
        <table>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtNameUpdate" runat="server"></asp:TextBox>
            </td>
            <td></td>
             <td>
                 <asp:Label ID="Label3" runat="server" Text="SELECT ID"></asp:Label>
            </td>
            
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>6</asp:ListItem>
                    <asp:ListItem>7</asp:ListItem>
                    <asp:ListItem>8</asp:ListItem>
                    <asp:ListItem>9</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    <asp:ListItem>11</asp:ListItem>
                </asp:DropDownList>
            
                <asp:Button ID="txtEdit" runat="server" Text="EDIT" OnClick="txtEdit_Click" />
            </td>
            <td></td>
            <td>
                <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click1" />
            </td>
        </tr>
            <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Age"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
            </td>
            
        </tr>
            <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Last Date of Blood Donation"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtLastBloodDonation" runat="server"></asp:TextBox>
            </td>
            
        </tr>
            <tr>
            <td>
                <asp:Label ID="Label8" runat="server" Text="City"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
            </td>
            
        </tr>
            <tr>
            <td>
                <asp:Label ID="Label10" runat="server" Text="Phone"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
            </td>
            
        </tr>
            <tr>
            <td>
                <asp:Label ID="Label12" runat="server" Text="Email"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </td>
            
        </tr>
        </table>
    </div>
    <h3>Delete Information<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Delete" />
    </h3>
    <table>
        
        <tr>
            <td>
                 <asp:Label ID="Label14" runat="server" Text="Donor Id"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDeleteId" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
