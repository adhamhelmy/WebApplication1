

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" Text="Please Login"></asp:Label>
               <br/>
             <asp:Label runat="server" Text="Username"></asp:Label>
            <asp:TextBox ID="username" runat="server"></asp:TextBox>
               <br/>   
             <asp:Label runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="password" runat="server"></asp:TextBox>
              <br/>   
            <asp:Button ID="login" runat="server" OnClick="Login" Text="Login"></asp:Button>
        </div>
    </form>
   

</body>
</html>
