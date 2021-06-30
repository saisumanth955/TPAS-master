<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResetcolorCombination.aspx.cs" Inherits="TPAS.colorPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #pwdfrmcolor {
            width: 421px;
        }
        #Password1 {
            width: 464px;
        }
        #rstpwd {
            width: 537px;
        }
        .auto-style1 {
            margin-left: 400px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <asp:Label ID="Label2" runat="server" Text="Username: "></asp:Label>
            <asp:TextBox ID="rstclrcombusrtxt" runat="server"></asp:TextBox>
        </div>
        <p style="width: 895px; margin-left: 65px">
            <asp:Button ID="Button1" runat="server" BackColor="Red" Height="61px" Text="RED" Width="139px" OnClick="Button1_Click1" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" BackColor="#66FF33" Height="58px" Text="GREEN" Width="170px" OnClick="Button2_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" BackColor="Blue" Height="57px" Text="BLUE" Width="146px" OnClick="Button3_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p>
            &nbsp;</p>
        <p style="width: 623px; margin-left: 108px">
&nbsp;
            <asp:Label ID="Label1" runat="server" Text="PWD: "></asp:Label>
&nbsp;<asp:TextBox ID="pwdrst" runat="server" Width="518px" type="password"></asp:TextBox>
        </p>
        <p style="width: 623px; margin-left: 108px">
            &nbsp;</p>
        <p style="width: 623px; margin-left: 388px">
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" style="margin-left: 0px" Text="Update Color Combination" Width="259px" />
        </p>
    </form>
</body>
</html>
