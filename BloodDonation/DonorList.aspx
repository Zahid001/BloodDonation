<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DonorList.aspx.cs" Inherits="BloodDonation.DonorList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div style="margin-left: auto; margin-right: auto; text-decoration:underline; text-align: center;font-size:larger; font-weight:bolder">
                 <asp:Label ID="Label1" runat="server" Text="Donor List" ></asp:Label> <br /> 

                 
        <asp:Button ID="btnShow" runat="server" Text="Show" OnClick="btnShow_Click" />
        <asp:Button ID="btnHide" runat="server" Text="Hide" OnClick="btnHide_Click" />
                 

                 
                 <br /> <br />
        
     </div>
    <div>
        <asp:GridView ID="GridView11" runat="server" AutoGenerateColumns="False">
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
