<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewstate.aspx.cs" Inherits="RawanApp.viewstate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Name" Font-Bold="True" Font-Italic="True"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" Width="165px"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Italic="True" Text="LAST_name"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="sent " />
&nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="restore" />
        </div>
    </form>
</body>
</html>
