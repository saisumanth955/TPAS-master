<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateColorCombination.aspx.cs" Inherits="TPAS.UpdateColorCombination" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" language="javascript">
        function DisableBackButton() {
            window.history.forward()
        }
        DisableBackButton();
        window.onload = DisableBackButton;
        window.onpageshow = function (evt) { if (evt.persisted) DisableBackButton() }
        window.onunload = function () { void (0) }
    </script>
    <style type="text/css">
        .auto-style1 {
            margin-left: 360px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
           <h6>*Your password is being stored</h6>
        <p>
            Username:
            <asp:TextBox ID="clrusrname" runat="server" Width="297px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="clrusrname" ErrorMessage="Username mandatory to update your combination" ForeColor="Red"></asp:RequiredFieldValidator>
        </p>
        <p>
            Email: <asp:TextBox ID="TextBox2" runat="server" Width="339px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="Field mandatory to send comb to your mail ID" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Please enter correct email ID" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="TextBox2"></asp:RegularExpressionValidator>
        </p>
        <div>
            <asp:Button ID="Button2" runat="server" BackColor="#FF3300" Height="50px" Text="RED" Width="101px" OnClick="Button2_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" BackColor="Lime" Height="52px" Text="GREEN" Width="101px" OnClick="Button3_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button4" runat="server" BackColor="Blue" Height="47px" Text="BLUE" Width="100px" OnClick="Button4_Click" />
            <br />
            <br />
            <asp:TextBox ID="TextBox3" runat="server" Width="284px" type="hidden"></asp:TextBox>
            <br />
            &nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<br />
            &nbsp;&nbsp;
            <asp:Label ID="Label5" runat="server" Text="Password: "></asp:Label>
            &nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox1" type="password" runat="server" Width="278px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="colorcombrst" runat="server" OnClick="colorcombrst_Click" Text="Reset color comb" Width="181px" />
            <br />
            <br />
        </div>
        <div class="auto-style1">
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Update Combination" />
        </div>
    </form>
</body>
</html>
