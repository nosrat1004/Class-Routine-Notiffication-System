<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SendNotice.aspx.cs" Inherits="FinalProject.UI.SendNotice" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Notification</title>
    <style>
        @font-face {
            font-family: 'OpenSans-Light';
            src: url('../fonts/OpenSans-Light.ttf') format('truetype');
        }

        .label {
            font-size: 50px;
            font-family:OpenSans-Light, Calibri;
            margin-top:200px;
            display:block;
            text-align:center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblMessage" runat="server" CssClass="label"></asp:Label>

        </div>
    </form>
</body>
</html>
