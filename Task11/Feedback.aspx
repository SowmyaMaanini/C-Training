<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Feedback.aspx.cs" Inherits="WebApplication3.Feedback" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Courseware Feedback Form</h3>
        </div>
        <div>

            <asp:Label ID="Label1" runat="server" Text="StudentName"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

        </div>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Sex"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="gender" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Male" />
        </p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="gender" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Female" />
        </p>
        <asp:Label ID="Label3" runat="server" Text="Select Course"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>*select*</asp:ListItem>
            <asp:ListItem>dot net</asp:ListItem>
            <asp:ListItem>HTML</asp:ListItem>
            <asp:ListItem>CSS</asp:ListItem>
        </asp:DropDownList>
        <p>
            <asp:Label ID="Label5" runat="server" Text="Technical Coverage"></asp:Label>
        </p>
        <p>
            <asp:RadioButton ID="RadioButton3" runat="server" GroupName="tech" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Excellent" />
        </p>
        <p>
            <asp:RadioButton ID="RadioButton4" runat="server" GroupName="tech" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Good" />
        </p>
        <p>
            <asp:RadioButton ID="RadioButton5" runat="server" GroupName="tech" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Average" />
        </p>
        <p>
            <asp:RadioButton ID="RadioButton6" runat="server" GroupName="tech" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Poor" />
        </p>
        <p>
            <asp:Label ID="Label6" runat="server" Text="Suggestions"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="TextBox2" runat="server" Height="41px" Width="640px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" style="height: 29px" Text="Submit" OnClick="Button1_Click" />
        </p>
        <p>
            <asp:TextBox ID="TextBox3" runat="server" Height="16px" Width="519px">
                
            </asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
