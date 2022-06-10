<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewScore.aspx.cs" Inherits="StudentManagementWebForm.ViewScore" %>

<%@ Register Src="~/SinhVienWeb/ViewScoreControl.ascx" TagPrefix="uc1" TagName="ViewScoreControl" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Thông Tin Kết Quả</title>
    <link href="SinhVienWeb/css/css.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div id="header">
                <div class="container">
                    <div class="logo">
                        University Academic Portal
                    </div>
                    
                </div>
            </div>
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
            <%--Thông Tin điểm--%>
            <div class="content">
                <uc1:ViewScoreControl runat="server" ID="ViewScoreControl" />
            </div>
        </div>
    </form>
</body>
</html>
