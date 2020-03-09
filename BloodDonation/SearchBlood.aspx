<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SearchBlood.aspx.cs" Inherits="BloodDonation.SearchBlood" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div style="margin-left: auto; margin-right: auto; text-decoration:underline; text-align: center;font-size:larger; font-weight:bolder">
                 <asp:Label ID="Label1" runat="server" Text="Search Blood" ></asp:Label>
     </div> <br /> <br /> 
    <div style="margin-left: auto; margin-right: auto; text-align: center;font-size:larger; font-weight:400"">
        <asp:Label ID="Label2" runat="server" Text="Blood Group" ></asp:Label> <br />
        <asp:TextBox ID="txtSearchBlood" runat="server"></asp:TextBox> <br />
        <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" /> <br /><br />
        <asp:Button ID="btnSearchAlternate" runat="server" Text="Alternative Search" OnClick="btnSearchAlternate_Click" />
         <br />

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="donorId" HeaderText="Donor ID" />
                <asp:BoundField DataField="name" HeaderText="Name" />
                <asp:BoundField DataField="age" HeaderText="Age" />
                <asp:BoundField DataField="bloodGroup" HeaderText="Blood Group" />
                <asp:BoundField DataField="lastBloodDate" HeaderText="Last Date of Blood Donation" />
                <asp:BoundField DataField="phone" HeaderText="Phone" />
                <asp:BoundField DataField="email" HeaderText="Mail" />
                <asp:BoundField DataField="city" HeaderText="City" />
                <asp:BoundField DataField="address" HeaderText="Address" />
            </Columns>
        </asp:GridView>

    </div>

</asp:Content>
