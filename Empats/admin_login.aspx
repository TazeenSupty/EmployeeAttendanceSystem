<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin_login.aspx.cs" Inherits="Empats.admin_login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-top: 2px;
        }
    </style>
</head>
<body>
   <form id="form1" runat="server">
        <div>
            <p>Enter your login User Name &amp; Password below...</p>
        </div>
        <asp:Panel ID="Panel1" runat="server" Height="234px" Width="465px">
            <asp:Label ID="Label1" runat="server" Text="User Name"></asp:Label>
            <asp:TextBox ID="tbx_admin_userName" runat="server" CssClass="auto-style1" style="margin-left: 32px"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="tbx_admin_password" runat="server" TextMode="Password" CssClass="auto-style2" style="margin-left: 42px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btn_admin_login" runat="server" OnClick="Button1_Click" Text="Login" CssClass="auto-style1" Height="26px" Width="71px" />
            <br />
            <br />
            <asp:Label ID="lbl_errorMsg" runat="server"></asp:Label>
        </asp:Panel>
        <p>
       </p>
    </form>
</body>
</html>
