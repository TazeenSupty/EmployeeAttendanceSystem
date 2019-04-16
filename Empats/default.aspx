<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Empats._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Home page</h1>
            <div>
                <asp:HyperLink runat="server" NavigateUrl="~/user_login.aspx" Text=" Login as User"> </asp:HyperLink>
            </div>
            
           <div>
                <asp:HyperLink runat="server" NavigateUrl="~/admin_login.aspx" Text=" Login as Admin"> </asp:HyperLink>
           </div>

        </div>
    </form>
</body>
</html>
