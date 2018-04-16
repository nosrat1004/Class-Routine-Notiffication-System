<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminDashBoard.aspx.cs" Inherits="FinalProject.UI.AdminDashBoard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Dashboard</title>
    <link href="../CDN/fa.css" rel="stylesheet" />
    <script src="../CDN/fa.js"></script>
    <script src="../CDN/jQuery.js"></script>
    <link href="../css/adminDashboard.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="content">
                <div class="inside">
                    <div class="icon">
                        <a href="UploadRoutine.aspx"><i class="fas fa-cloud-upload-alt"></i></a>
                        <label>Upload Routine</label>
                    </div>
                    <div class="icon">
                        <a href="Mailsending.aspx"><i class="far fa-envelope"></i></a>
                        <label>Send Email</label>
                    </div>
                    <div class="icon">
                        <a href="ViewAllUser.aspx"><i class="fas fa-address-card"></i></a>
                        <label>View Users Info</label>
                    </div>
                    <div class="icon">
                        <a href="CountDown.aspx"><i class="fas fa-address-card"></i></a>
                        <label>Mail to Guardians</label>
                    </div>
                    <div class="icon">
                        <div class="logout">
                            <asp:Button ID="btnLogout" CssClass="btn" runat="server" OnClick="btnLogout_Click" />
                            <i class="fas fa-sign-out-alt i"></i>
                        </div>
                        <label>LogOut</label>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
