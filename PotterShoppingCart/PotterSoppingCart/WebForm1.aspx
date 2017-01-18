<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PotterSoppingCart.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="哈利波特1"></asp:Label>
        <asp:TextBox ID="txtPotter1" runat="server"></asp:TextBox><br>
         <asp:Label ID="Label2" runat="server" Text="哈利波特2"></asp:Label>
        <asp:TextBox ID="txtPotter2" runat="server"></asp:TextBox><br>
         <asp:Label ID="Label3" runat="server" Text="哈利波特3"></asp:Label>
        <asp:TextBox ID="txtPotter3" runat="server"></asp:TextBox><br>
         <asp:Label ID="Label4" runat="server" Text="哈利波特4"></asp:Label>
        <asp:TextBox ID="txtPotter4" runat="server"></asp:TextBox><br>
         <asp:Label ID="Label5" runat="server" Text="哈利波特5"></asp:Label>
        <asp:TextBox ID="txtPotter5" runat="server"></asp:TextBox>
    
    </div>
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        Total:  <asp:Label ID="txtTotal" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
