<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewAllUser.aspx.cs" Inherits="FinalProject.UI.ViewAllUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View All Users</title>
    <link href="../css/viewall.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>View All Users Info</h1>
        </div>
        <div class="btn-content">
            <asp:Button ID="btnViewStudent" CssClass="btn" runat="server" Text="View All Student Info" OnClick="btnViewStudent_Click" />
            <asp:Button ID="btnViewTeacher" CssClass="btn" runat="server" Text="View All Teacher Info" OnClick="btnViewTeacher_Click" />
            <asp:Button ID="btnViewGuardin" CssClass="btn" runat="server" Text="View All Guardian Info" OnClick="btnViewGuardin_Click" />
        </div>

        <div class="table">
            <asp:GridView ID="gv" CssClass="grid" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <EditRowStyle BackColor="#7C6F57" />
                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#E3EAEB" />
                <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F8FAFA" />
                <SortedAscendingHeaderStyle BackColor="#246B61" />
                <SortedDescendingCellStyle BackColor="#D4DFE1" />
                <SortedDescendingHeaderStyle BackColor="#15524A" />
            </asp:GridView>
        </div>
    </form>
</body>
</html>
