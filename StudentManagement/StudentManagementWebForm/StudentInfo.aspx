<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentInfo.aspx.cs" Inherits="StudentManagementWebForm.StudentInfo" %>

<%@ Register Src="~/SinhVienWeb/StudentInfoControl.ascx" TagPrefix="uc1" TagName="StudentInfoControl" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Thông tin sinh viên</title>
    <link href="SinhVienWeb/css/css.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%--header--%>
            <div id="header">
                <div class="container">
                    <div class="logo">
                        University Academic Portal
                    </div>
                    
                </div>
            </div>
            <%--Main menu--%>
            <div class="MainMenu">
                <div class="container">
                    <ul>
                        <li >
                            <a href="/StudentPage.aspx">
                                <asp:Label ID="StudentName" runat="server" Text="Label"></asp:Label>
                            </a>
                        </li>
                        <li><a href="/StudentPage.aspx" title="Trang chủ">Trang chủ</a></li>
                        <li><a href="/ViewScore.aspx" title="Kêt Quả">Kêt Quả</a></li>
                        <li><a href="/StudentInfo.aspx" title="Thông Tin">Thông Tin</a></li>
                    </ul>
                </div>
            </div>
            <%--Content--%>
            <div class="content">
                <uc1:StudentInfoControl runat="server" ID="StudentInfoControl" />
            </div>
        </div>
    </form>
</body>
</html>
