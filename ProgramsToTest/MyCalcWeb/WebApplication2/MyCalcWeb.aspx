<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyCalcWeb.aspx.cs" Inherits="WebApplication2.MyCalcWeb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="tb_a" runat="server"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" Text=":"></asp:Label>
        <asp:TextBox ID="tb_b" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        <asp:Label ID="lb_Result" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
