<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ViewScoreControl.ascx.cs" Inherits="StudentManagementWebForm.SinhVienWeb.ViewScoreControl" %>
<div class="title">Thông Tin Điểm</div>
<asp:GridView ID="ScoreGV" AutoGenerateColumns="false" runat="server" Height="261px" Width="471px" HorizontalAlign="Center">
    <Columns>
        <asp:BoundField HeaderText="Mã Môn Học" DataField="SubjectID" />
        <asp:BoundField HeaderText="Môn Học" DataField="SubjectName"/>
        <asp:TemplateField HeaderText="Tình Trạng">
            <ItemTemplate>
                <asp:Label CssClass='<%# Eval("color") %>' ID="Status" runat="server" Text='<%# Eval("StatusString") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
    <HeaderStyle HorizontalAlign="Center" />
    <RowStyle HorizontalAlign="Center" />
</asp:GridView>
