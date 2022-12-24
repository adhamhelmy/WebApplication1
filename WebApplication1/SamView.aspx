<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SamView.aspx.cs" Inherits="WebApplication1.SamView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <div>
                <asp:Label runat="server" Text="Add Match"></asp:Label>
                <br />
                 <asp:Label runat="server" Text="Host Club Name"></asp:Label>
                 <asp:TextBox id="hname" runat="server"></asp:TextBox>
                <br />
                 <asp:Label runat="server" Text="Guest Club Name"></asp:Label>
                 <asp:TextBox id="gname" runat="server"></asp:TextBox>
                <br />
                 <asp:Label runat="server" Text="Start Time"></asp:Label>
                 <asp:TextBox id="stime" runat="server"></asp:TextBox>
                <br />
                 <asp:Label runat="server" Text="End Time"></asp:Label>
                 <asp:TextBox id="etime" runat="server"></asp:TextBox>
                <br />
                 <asp:Button runat="server" OnClick="AddMatch" Text="Add Match"></asp:Button>
            </div>
        </div>
    </form>
</body>
</html>
