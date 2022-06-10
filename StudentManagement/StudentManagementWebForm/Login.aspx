<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="StudentManagementWebForm.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
    <link href="SinhVienWeb/css/login.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="header">
            <p>Đăng Nhập</p>
        </div>
        <div class="container">
            Tên Đăng Nhập<br />
            <asp:TextBox ID="StudentLogin" runat="server" Width="396px" Height="25px"></asp:TextBox>
            <br />
            Mật Khẩu<br />
            <asp:TextBox ID="StudentPassword" runat="server" Height="25px" TextMode="Password" Width="397px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="LoginBttn" runat="server" OnClick="LoginBttn_Click" style="margin-left: 108px" Text="Đăng Nhập" Width="199px" />
            <br />
        </div>
    </form>
</body>
</html>
