<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="TPAS.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <link href="index.css" rel="stylesheet" type="text/css" />
    <title></title>
    <style type="text/css">
                
        
        .auto-style4 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: xx-large;
            font-weight: lighter;
            font-style: oblique;
            text-transform: uppercase;
            color: white;
            text-decoration: blink;
           
        }
        .newStyle2 {
            
            background-repeat: inherit;
            background-attachment: fixed;
            background-position: inherit;
        }
        
        
        .auto-style5 {
            text-align: center;
        }
        
    </style>
</head>
<body style="height: 569px; background-color: transparent; background-repeat: no-repeat; background-size: cover; height: 100%; background-image: url('index.jpg'); height: 1186px; margin-top: 0px;" >
    <form id="form1" runat="server">

         <div class="auto-style5">
        
        
            
                
        
        
            
                <br />
                    <span class="auto-style4">
                    <br />
                    <br />
                    Secure web authentication</span><br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
            <asp:Button ID="Button2" style="color:white; background-color: #4CAF50;" runat="server" OnClick="Button1_Click" Text="Enter" Width="145px" CssClass="newStyle3" Height="45px" />
        
                </div>
        
    </form>
                
</body>
</html>
