<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="KursDemo1WebForm.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Pierwsza strona</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <p>Hello from WebForms</p>
    </div>
        <asp:Label ID="Label1" runat="server" Text="Podaj imię"></asp:Label>
        <br />
        <asp:TextBox ID="tbImie" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Wyświetl" />
        <br />
        <asp:Label ID="lbWynik" runat="server"></asp:Label>
    </form>
</body>
</html>
