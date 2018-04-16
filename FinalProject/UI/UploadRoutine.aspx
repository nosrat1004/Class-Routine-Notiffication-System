<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UploadRoutine.aspx.cs" Inherits="FinalProject.UI.UploadRoutine" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Upload Routine</title>
    <link href="../css/upload.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="upload">
                <asp:FileUpload ID="fuRoutine" CssClass="fu-routine" runat="server" />

                <br />
                <asp:Button Text="Upload Routine"  CssClass="btn" runat="server" ID="btnUploadRoutine" OnClick="btnUploadRoutine_Click"/>
                <br/>
                <asp:Label ID="lblMessage" runat="server" />
            </div>
        </div>

    </form>
</body>
</html>
