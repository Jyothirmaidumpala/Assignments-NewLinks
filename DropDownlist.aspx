<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DropDownlist.aspx.cs" Inherits="Asp_DropDown.DropDownlist" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Select Any Item <asp:DropDownList ID="DropDownList1" runat="server" Height="50px" Width="50px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList><br /><br/><br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        <asp:Image ID="Image1" runat="server" Height="100px" Width="100px" /><br /><br /><br />
         <asp:Button ID="Button1" runat="server" Text="Cost" Height="35px" Width="50px" OnClick="Button1_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label1" runat="server" Text="Cost of the Item"></asp:Label>
             &nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </form>
</body>
</html>
