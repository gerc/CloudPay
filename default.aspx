<%@ Page Language="C#" AutoEventWireup="true" CodeFile="default.aspx.cs" Inherits="_default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CloudPay - Inicio</title>
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
                <div id="session_action">
                    <asp:HyperLink ID="lnkSessionAction" runat="server" CssClass="SessionText" 
                        NavigateUrl="~/login.aspx">Iniciar sesi&oacute;n</asp:HyperLink>
                </div>
                <div id="session_user">
                    <asp:Label ID="lblSessionUser" runat="server" Text="Bienvenido, Invitado" 
                        CssClass="SessionText"></asp:Label>
                </div>
            </div>
            <div id="body">
                    <div id="body_interior">
                        
                    </div>
                </div>
                <div id="page_foot">
                </div>
        </div>
    </form>
</body>
</html>