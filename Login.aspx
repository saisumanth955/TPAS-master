<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TPAS.Login" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="TPAS" TagPrefix="asp" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <link href="Login.css" rel="stylesheet" type="text/css" />

    <title>Welcome to Login page</title>
    <script type="text/javascript" language="javascript">
        function DisableBackButton() {
            window.history.forward()
        }
        DisableBackButton();
        window.onload = DisableBackButton;
        window.onpageshow = function (evt) { if (evt.persisted) DisableBackButton() }
        window.onunload = function () { void (0) }
    </script>
     
</head>
<body style="background-color: transparent; background-repeat: no-repeat; background-size: cover; height: 100%; background-image: url('index.jpg'); height: 1186px; margin-top: 0px; class=auto-style2">
     
    <form id="form1" runat="server">
    
    <h3 class="auto-style2">
        
        <asp:ScriptManager  ID="ScriptManager1" runat="server"></asp:ScriptManager>
        
        
        
        
        &nbsp; Your login time:&nbsp;<span id="secondsIdle"></span>&nbsp;seconds.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        
        
        
        
        </h3>
      
        <div class="auto-style1">
            &nbsp;
    <asp:LinkButton ID="lnkFake" runat="server" />
        
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
            <p class="login-text">
                <span class="fa-stack fa-lg">
                    <i class="fa fa-circle fa-stack-2x"></i>
                    <i class="fa fa-lock fa-stack-1x"></i>
                </span>
            </p>
            <div class="container">
            <div class="center">
            <asp:TextBox CssClass="login-username" ID="usernametxt" runat="server" autofocus="true" required="true" placeholder="Username"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="usernametxt" ErrorMessage="Username is Mandatory" ForeColor="#FF3300"></asp:RequiredFieldValidator>
            <asp:TextBox CssClass="login-password" required="true" placeholder="Password" ID="pwdtxt" runat="server" type="password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="pwdtxt" ErrorMessage="Password is Mandatory" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:Button ID="sgnin" runat="server" value="Login" class="login-submit" Text="Sign-In" Width="159px" OnClick="sgnin_Click" />
            </div>
            </div>
        
            <a href="Register.aspx" class="login-forgot-pass">Sig up here</a>
            <div class="underlay-photo"></div>
            <div class="underlay-black"></div>

    <asp:Panel ID="pnlPopup" runat="server" CssClass="modalPopup" Style="display: none">
        <div class="header">
            Session Expiring!
        </div>
        <div class="body">
            Your Session will expire in&nbsp;<span id="seconds"></span>&nbsp;seconds.<br />
            Do you want to reset?
        </div>
        <div class="footer" align="right">
            <asp:Button ID="btnYes" runat="server" Text="Yes" CssClass="yes" />
            <asp:Button ID="btnNo" runat="server" Text="No" CssClass="no" />
        </div>
    </asp:Panel>
    <script type="text/javascript">
        function SessionExpireAlert(timeout) {
            var seconds = timeout / 1000;
            document.getElementsByName("secondsIdle").innerHTML = seconds;
            document.getElementsByName("seconds").innerHTML = seconds;
            setInterval(function () {
                seconds--;
                document.getElementById("seconds").innerHTML = seconds;
                document.getElementById("secondsIdle").innerHTML = seconds;
            }, 1000);
            setTimeout(function () {
                //Show Popup before 20 seconds of timeout.
                $find("mpeTimeout").show();
            }, timeout - 6 * 1000);
            setTimeout(function () {
                window.location = "index.aspx";
            }, timeout);
        };



    </script>

            
      
        
        </div>
        
         
    </form>
         
    </body>
</html>
