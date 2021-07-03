<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Unauthorizedpage.aspx.cs" Inherits="TPAS.Unauthorizedpage" %>

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
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>You are not Authorized to access the page</h1></div>
    </form>
</body>
</html>
