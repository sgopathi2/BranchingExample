<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebAppToExplainingBranching.Contact" %>

<%@ Register src="MyMenu.ascx" tagname="MyMenu" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>
                        <uc1:MyMenu ID="MyMenu1" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td><h2>Contact Page</h2></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
