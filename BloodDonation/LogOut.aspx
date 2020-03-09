<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LogOut.aspx.cs" Inherits="BloodDonation.LogOut" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   
    <div  style="text-align:center">
         <h1>Do you want to log out?</h1> 
         <asp:Button ID="btnLogOut" runat="server" Text="Log Out" OnClick="btnLogOut_Click" />
    </div>
</asp:Content>
