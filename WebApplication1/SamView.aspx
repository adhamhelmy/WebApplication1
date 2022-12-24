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
            <div>
                <asp:Label runat="server" Text="Delete Match"></asp:Label>
                <br />
                 <asp:Label runat="server" Text="Host Club Name"></asp:Label>
                 <asp:TextBox id="hname2" runat="server"></asp:TextBox>
                <br />
                 <asp:Label runat="server" Text="Guest Club Name"></asp:Label>
                 <asp:TextBox id="gname2" runat="server"></asp:TextBox>
                <br />
                 <asp:Label runat="server" Text="Start Time"></asp:Label>
                 <asp:TextBox id="stime2" runat="server"></asp:TextBox>
                <br />
                 <asp:Label runat="server" Text="End Time"></asp:Label>
                 <asp:TextBox id="etime2" runat="server"></asp:TextBox>
                <br />
                 <asp:Button runat="server" OnClick="DeleteMatch" Text="Delete Match"></asp:Button>
            </div>
            <div>
                <br />
                 <asp:Button runat="server" OnClick="AllUpcomingMatches" Text="View All upcoming matches"></asp:Button>
                <br />
                 <asp:GridView  ID="Table1" runat="server"></asp:GridView>
            </div>
            <div>
                <br />
                 <asp:Button runat="server" OnClick="AlreadyPlayedMatches" Text="View already played matches"></asp:Button>
                <br />
                 <asp:GridView ID="Table2" runat="server"></asp:GridView>
            </div>
            <div>
                <br />
                 <asp:Button runat="server" OnClick="NeverMatched" Text="View Never matched clubs"></asp:Button>
                <br />
                 <asp:GridView ID="Table3" runat="server"></asp:GridView>
            </div>
        </div>
    </form>
</body>
</html>
