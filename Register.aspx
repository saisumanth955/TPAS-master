<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="TPAS.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Register.css" rel="stylesheet" type="text/css" />
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
    <style>
.hide {
  display: none;
}
    
.myDIV:hover + .hide {
  display: block;
  color: green;
}
</style>
    <script src="Script/jquery-1.7.1.js"></script>
    

</head>
<body style="background-color: transparent; background-repeat: no-repeat; background-size: cover; height: 100%; background-image: url('index.jpg'); height: 1186px; margin-top: 0px; margin-left: 10px;">
    <form id="form1" runat="server">
        <div class="container">
        <div class="center">
            
            <asp:TextBox ID="TextBox1" runat="server" CssClass="login-username"  autofocus="true" required="true" placeholder="Username"></asp:TextBox>
            <br />
            
            <asp:TextBox ID="TextBox2" runat="server" type="password" CssClass="login-password" required="true" placeholder="Password"></asp:TextBox>
            <div class="myDIV"><img src="password.png" height="20" width="20"/></div>
            <br />
            
            <asp:TextBox ID="TextBox3" runat="server" type="password"  CssClass="login-password" required="true" placeholder="Confirm Password"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox2" ControlToValidate="TextBox3" ErrorMessage="Enter same password" ForeColor="Red"></asp:CompareValidator>
            <br />
            
            <asp:TextBox ID="TextBox4" runat="server" Width="235px"  CssClass="login-username"  autofocus="true" required="true" placeholder="Email"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox4" ErrorMessage="Please enter valid email address" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            <br />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="check password strength" Width="159px" class="login-submit" />
        
        <asp:ScriptManager runat="server" />
            <br />
        <div id="ReCaptchContainer"></div>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Register" Width="159px" class="login-submit"/>
            <br />
&nbsp;&nbsp;
            
        
        <label id="lblMessage" runat="server" clientidmode="static"></label>
        <br />

            
        
        <div>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;<br />
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
            </div>
            </div>

        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />

    <script src="https://www.google.com/recaptcha/api.js?onload=renderRecaptcha&render=explicit"></script>

    <script type="text/javascript">
        var your_site_key = '<%= ConfigurationManager.AppSettings["SiteKey"]%>';
        var renderRecaptcha = function () {
            grecaptcha.render('ReCaptchContainer', {
                'sitekey': your_site_key,
                'callback': reCaptchaCallback,
                theme: 'light', //light or dark
                type: 'audio',// image or audio
                size: 'normal'//normal or compact
            });
        };

        var reCaptchaCallback = function (response) {
            if (response !== '') {
                document.getElementById('lblMessage').innerHTML = "";
            }
        };

        jQuery('input[type="submit"]').on('click', (e) => {
            var message = 'Please check the checkbox';
            if (typeof (grecaptcha) != 'undefined') {
                var response = grecaptcha.getResponse();
                (response.length == 0) ? (message = 'Captcha verification failed') : (message = '');
            }
            jQuery('#lblMessage').html(message);
        });

    </script>
            </form>
    <a href="Login.aspx" class="login-forgot-pass">Sign in</a>
            <div class="underlay-photo"></div>
            <div class="underlay-black"></div>
</body>
</html>