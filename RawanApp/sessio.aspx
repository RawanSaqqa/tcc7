<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sessio.aspx.cs" Inherits="RawanApp.sessio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" Text="job"></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 59px" Text="set session" />
        </div>
    </form>
</body>
</html>
