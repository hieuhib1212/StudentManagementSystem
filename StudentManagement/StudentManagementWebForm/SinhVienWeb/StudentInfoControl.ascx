<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="StudentInfoControl.ascx.cs" Inherits="StudentManagementWebForm.SinhVienWeb.StudentInfoControl" %>
<asp:PlaceHolder ID="InfoPlaceHolder" runat="server"></asp:PlaceHolder>
<div class="title">Thông Tin Sinh Viên</div>
<asp:Table ID="Table1" runat="server" Height="323px" Width="640px">
    <asp:TableRow>
        <asp:TableCell>Mã số sinh viên</asp:TableCell>
        <asp:TableCell>
            <asp:TextBox ID="StudentID" runat="server"></asp:TextBox>
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell>Họ và Tên</asp:TableCell>
        <asp:TableCell>
            <asp:TextBox ID="StudentName" runat="server"></asp:TextBox>
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell>Ngày Sinh</asp:TableCell>
        <asp:TableCell>
            <asp:TextBox ID="StudentDOB" runat="server"></asp:TextBox>
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell>Giới Tính</asp:TableCell>
        <asp:TableCell>
            <asp:Label ID="Gender" runat="server" Text="Label"></asp:Label>
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell>Địa Chỉ Email</asp:TableCell>
        <asp:TableCell>
            <asp:TextBox ID="Email" runat="server" Width="200px"></asp:TextBox>
        </asp:TableCell>
    </asp:TableRow>
</asp:Table>
<div class="title">
    Thay Đổi Mật Khẩu
</div>
<asp:Label ID="Notify" runat="server" Text=""></asp:Label>
<asp:Table ID="ChangePassword" runat="server" Height="286px" Width="583px">
    <asp:TableRow>
        <asp:TableCell>Mật Khẩu Cũ</asp:TableCell>
        <asp:TableCell>
            <asp:TextBox ID="OldPassword" runat="server" TextMode="Password"></asp:TextBox>
        </asp:TableCell>
        <asp:TableCell>
            <asp:RequiredFieldValidator ID="RequiredOld" runat="server" ErrorMessage="Nhập Thông Tin" ControlToValidate="OldPassword"></asp:RequiredFieldValidator>
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell>Mật Khẩu Mới</asp:TableCell>
        <asp:TableCell>
            <asp:TextBox ID="NewPassword" runat="server" ControlToCompare="NewPassword" TextMode="Password"></asp:TextBox>
        </asp:TableCell>
        <asp:TableCell>
            <asp:RequiredFieldValidator ID="RequireNew" runat="server" ErrorMessage="Nhập Thông Tin" ControlToValidate="NewPassword"></asp:RequiredFieldValidator>
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell>Nhập Lại Mật Khẩu Mới</asp:TableCell>
        <asp:TableCell>
            <asp:TextBox ID="RenewPassword" runat="server" TextMode="Password"></asp:TextBox>
        </asp:TableCell>
        <asp:TableCell>
            <asp:RequiredFieldValidator ID="RequireRe" runat="server" ErrorMessage="Nhập Thông Tin" ControlToValidate="RenewPassword"></asp:RequiredFieldValidator>
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell>
            <asp:CompareValidator ID="Compare" runat="server" Display="Dynamic" ForeColor="Red" ErrorMessage="Mật Khẩu không trùng nhau" ControlToCompare="NewPassword" ControlToValidate="RenewPassword"></asp:CompareValidator>
        </asp:TableCell>
        <asp:TableCell>
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell>
        </asp:TableCell>
        <asp:TableCell>
            <asp:Button ID="ChangePW" runat="server" Text="Áp Dụng" OnClick="ChangePW_Click"  />
        </asp:TableCell>
    </asp:TableRow>

</asp:Table>

    



    
