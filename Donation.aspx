<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Donation.aspx.cs" Inherits="Donation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Welcome to the Donation Page!!</h1>
        <h3>Get ready to give us money!</h3>
        <table>
        <tr>
            <td>Enter Donation Amount</td>
            <td><asp:TextBox ID="txtDonationAmount" runat="server"></asp:TextBox></td>
            <td><asp:Button ID="btnSubmitDonation" runat="server" Text="Submit" /></td>
        </tr>
       </table>
    </div>
    </form>
</body>
</html> 
