<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Kobranza</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <img alt="" dir="rtl" src="images/logo.png" /><br />
            <asp:Label ID="Label1" runat="server" Font-Names="Segoe UI Light" Font-Size="20pt" Text="INICIAR SESIÓN"></asp:Label>
            <br />
            <asp:TextBox ID="txtuser" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtpass" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
            <br />
            <asp:Label ID="labelex" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
