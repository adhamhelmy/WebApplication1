<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SystemAdmin.aspx.cs" Inherits="WebApplication1.SystemAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <asp:Label runat="server" Text="System User"></asp:Label>
    <form id="form1" runat="server">
        <div>

           
            <div>
                <asp:Label runat="server" Text="Add Club"></asp:Label>
                <br />
                 <asp:Label runat="server" Text="Name"></asp:Label>
                 <asp:TextBox id="clubname" runat="server"></asp:TextBox>
                <br />
                 <asp:Label runat="server" Text="Location"></asp:Label>
                 <asp:TextBox id="clublocation" runat="server"></asp:TextBox>
                <br />
                 <asp:Button runat="server" OnClick="AddClub" Text="Add Club"></asp:Button>
            </div>
            <div>
             <asp:Label runat="server" Text="Delete Club"></asp:Label>
                <br />
                 <asp:Label runat="server" Text="Name"></asp:Label>
                 <asp:TextBox id="clubnamedelete" runat="server"></asp:TextBox>
                <br />
                 <asp:Button runat="server" OnClick="DeleteClub" Text="Delete Club"></asp:Button>
            </div>
             <div>
             <asp:Label runat="server" Text="Add Stadium"></asp:Label>
                  <br />
                 <asp:Label runat="server" Text="Name"></asp:Label>
                 <asp:TextBox id="stadiumname" runat="server"></asp:TextBox>
                <br />
                 <asp:Label runat="server" Text="Location"></asp:Label>
                 <asp:TextBox id="stadiumlocation" runat="server"></asp:TextBox>
                  <br />
                 <asp:Label runat="server" Text="Capacity"></asp:Label>
                 <asp:TextBox id="stadiumcapacity" runat="server"></asp:TextBox>
                <br />
                 <asp:Button runat="server" OnClick="AddStadium" Text="Add Stadium"></asp:Button>
            </div>
             <div>
             <asp:Label runat="server" Text="Delete Stadium"></asp:Label>
                  <br />
                 <asp:Label runat="server" Text="Name"></asp:Label>
                 <asp:TextBox id="stadiumnamedelete" runat="server"></asp:TextBox>
                 <br />
                 <asp:Button runat="server" OnClick="DeleteStadium" Text="Delete Stadium"></asp:Button>
            </div>
             <div>
             <asp:Label runat="server" Text="Block Fan"></asp:Label>
                  <br />
                 <asp:Label runat="server" Text="Natonal id"></asp:Label>
                 <asp:TextBox ID="fanid" runat="server"></asp:TextBox>
                 <br />
                 <asp:Button runat="server" OnClick="BlockFan" Text="Block Fan"></asp:Button>
            </div>


        </div>
    </form>
</body>
</html>
