<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Welcome.aspx.cs" Inherits="Welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Welcome</h1>
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        
        <table><tr>
            <td>
                <asp:Button ID="btnDonation" runat="server" Text="Click to make a Donation" OnClick="btnDonation_Click" Width="176px" />
                <asp:Button ID="btnGrant" runat="server" Text="Click to apply for a Grant" OnClick="btnGrant_Click" Width="207px" />
            </td>
        </tr>

        </table>
    </div>
    </form>
</body>
</html>
