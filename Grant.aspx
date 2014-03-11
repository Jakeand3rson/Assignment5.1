<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Grant.aspx.cs" Inherits="Grant" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <h1>Welcome to the Grant Page!!</h1>
        <h3>Get ready to get some money!</h3>
        <table>
             <tr>
            <td>Enter Username</td>
            <td><asp:TextBox ID="txtfirstname" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
            <td>Enter Grant Amount</td>
            <td><asp:TextBox ID="txtGrantAmount" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
            <td>Enter Date</td>
            <td><asp:TextBox ID="txtGrantDate" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
            <td>Enter Services needed</td>
            <td>
                <asp:DropDownList ID="ddlServices" runat="server"></asp:DropDownList></td>
            </tr>
            <tr>
            <td><asp:Button ID="btnSubmitGrant" runat="server" Text="Submit" OnClick="btnSubmitGrant_Click" /></td>
        </tr>
            
          
       </table>

    </div>
    </form>
</body>
</html>
