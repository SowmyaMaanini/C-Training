<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="goldnsilver.aspx.cs" Inherits="WebApplication4.goldnsilver" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Gold"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="View Rate" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Width="573px"></asp:TextBox>
        <br />
        <asp:HiddenField ID="HiddenField1" runat="server" />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Silver"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="View Rate" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" Width="574px"></asp:TextBox>
        <br />
        <asp:HiddenField ID="HiddenField2" runat="server" />
    </form>
</body>
</html>
