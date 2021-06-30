<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registercolorcombination.aspx.cs" Inherits="TPAS.Rgstrcolorcomb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style3 {
            margin-left: 280px;
        }
        .auto-style5 {
            margin-left: 200px;
        }
        .auto-style6 {
            margin-left: 320px;
        }
        .auto-style7 {
            margin-left: 480px;
        }
        .auto-style8 {
            margin-left: 177px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style5">
            Username:
            <asp:TextBox ID="clrusrname" runat="server" Width="297px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Required Field" ForeColor="Red" ControlToValidate="clrusrname"></asp:RequiredFieldValidator>
            <br />
            Email:
            <asp:TextBox ID="TextBox1" runat="server" Width="335px"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Please enter a valid email address" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Required field to send your color comb" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
        </div>
        <p class="auto-style3">
            <asp:Button ID="Button2" runat="server" BackColor="#FF3300" Height="50px" Text="RED" Width="101px" OnClick="Button2_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" BackColor="Lime" Height="52px" Text="GREEN" Width="101px" OnClick="Button3_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button4" runat="server" BackColor="Blue" Height="47px" Text="BLUE" Width="100px" OnClick="Button4_Click" />
            <br />
            <br />
            &nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<br />
            &nbsp;&nbsp;
            <asp:Label ID="Label5" runat="server" Text="Password: "></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="rgtrpwdbox" runat="server" style="margin-left: 0px" Width="274px" type="password"></asp:TextBox>
&nbsp;&nbsp;<h6>*your password is being saved</h6>
        <p class="auto-style8">Phone Number:
            <asp:TextBox ID="TextBox3" runat="server" Width="231px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="RequiredField" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox3" ErrorMessage="Please enter a 10 digit mobile number" ForeColor="Red" ValidationExpression="^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$"></asp:RegularExpressionValidator>
        </p>
        </p>
        <p class="auto-style7">
            <asp:Button ID="colorcombrst" runat="server" OnClick="colorcombrst_Click" Text="Reset color comb" Width="181px" />
            &nbsp;&nbsp;&nbsp;</p>
        <p class="auto-style7">
            &nbsp;&nbsp;<asp:TextBox ID="TextBox2" runat="server" Width="219px" type="hidden"></asp:TextBox>
        </p>
        <p class="auto-style3">
            &nbsp;</p>
        <p class="auto-style6">
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Click to save your Color Combination" Width="351px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="bckbutton" runat="server" Text="Back to previous page to select another level of Auth" Width="471px" OnClick="bckbutton_Click" />
        </p>
        <p class="auto-style6">
            &nbsp;</p>
    </form>
</body>
</html>
