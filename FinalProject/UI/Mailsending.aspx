<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mailsending.aspx.cs" Inherits="sendemail.Mailsending" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>sending email</title>
    <link href="../css/Emailsend.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <table class="item">
                <tr>
                    <td>
                        <label>To:</label></td>
                    <td>
                        <asp:TextBox ID="txtTo" runat="server" CssClass="txtbox"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <label>Subject:</label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtSub" runat="server" CssClass="txtbox"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label>Body:</label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtBody" runat="server" TextMode="MultiLine" Columns="30" Rows="10"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                </tr>
            </table>

            <asp:Button ID="btnSend" runat="server" Text="Send" CssClass="bSend" OnClick="btnSend_Click" />
            <br />
            <asp:Label ID="lblStatus" runat="server"></asp:Label>
        </div>

    </form>
</body>
</html>
