<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CloudPay - Iniciar sesi&oacute;n</title>
    <link rel="stylesheet" type="text/css" href="css/main_style.css" />
</head>
<body>
    <form id="frmMain" runat="server">
        <div id="main">
            <div id="header">
            </div>
            <div id="session_status">
                <div id="session_date">
                    <asp:Label ID="lblDate" runat="server" Text="Fecha: 00/00/0000" 
                        CssClass="SessionText"></asp:Label>
                </div>
            </div>
        </div>
    </form>
</body>
</html>