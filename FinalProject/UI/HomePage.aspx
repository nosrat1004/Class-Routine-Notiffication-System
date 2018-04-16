<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="FinalProject.UI.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../css/home.css" rel="stylesheet" />
    <link href="../scripts/fontawesome-all.min.css" rel="stylesheet" />
    <script src="../scripts/fontawesome-all.min.js"></script>
    <script src="../scripts/jQuery-3.2.1.js"></script>
</head>
<body>
    <form id="form1" runat="server">

        <div class="container">
            <img src="../images/kids.jpeg" alt="Kids Learning Image" />
        </div>

        <div class="header">
            <div class="wrapper">
                <h1>CRN&nbsp;<i class="fas fa-hourglass-half"></i></h1>
                <nav>
                    <ul>
                        <li><a class="active" runat="server" id="lnkHome" href="HomePage.aspx">Home</a></li>
                        <li><a runat="server" id="lnkSales" href="Teacherdashboard.aspx">Teacher Dashboard</a></li>
                        <li><a runat="server" id="lnkProduct" href="AdminDashBoard.aspx">Administrator</a></li>
                    </ul>
                </nav>
            </div>
        </div>
        <div class="content">
            <h1>Class Routine Notification</h1>
        </div>
    </form>
</body>
</html>
