<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SportAssociationManager.aspx.cs" Inherits="WebApplication1.SportAssociationManager" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:Label runat="server" Text="Please Register"></asp:Label>
               <br/>
            <asp:Label runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="name" runat="server"></asp:TextBox>
               <br/>  
             <asp:Label runat="server" Text="Username"></asp:Label>
            <asp:TextBox ID="username" runat="server"></asp:TextBox>
               <br/>   
             <asp:Label runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="password" runat="server"></asp:TextBox>
              <br/>   
            <asp:Button ID="register" runat="server" OnClick="Register" Text="Register"></asp:Button>
        </div>
    </form>
</body>
</html>
