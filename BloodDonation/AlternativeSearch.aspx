<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AlternativeSearch.aspx.cs" Inherits="BloodDonation.AlternativeSearch" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div style="margin-left: auto; margin-right: auto;  text-align: center;font-size:larger; font-weight:bolder">
                 <asp:Label ID="Label1" runat="server" Text="Search Blood Alternative Way" ></asp:Label> <br /><br /><br />
       
         <asp:Label ID="Label2" runat="server" Text="Blood Group"></asp:Label>
        <asp:TextBox ID="txtBloodGroup" runat="server"></asp:TextBox> 
         
        
        <asp:DropDownList ID="DropDownList1" runat="server">
            
            <asp:ListItem>Age</asp:ListItem>
            <asp:ListItem>City</asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox ID="txtAlternativeSearch" runat="server"></asp:TextBox>

        <br />
        
        <asp:Button ID="btnSearch" runat="server" Text="Go" OnClick="btnSearch_Click" />

     </div>
    <div>
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
