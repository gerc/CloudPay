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
            <div id="body">
                <div id="body_interior">
                    <br />
                    <br />
                    <asp:Login ID="lLogin" runat="server" Style="margin:auto; font-size: small;"
                    FailureText="Usuario o contraseña inválidos" 
                    LoginButtonText="Iniciar sesión" 
                    PasswordRequiredErrorMessage="Ingrese la contraseña" RememberMeSet="True" 
                    RememberMeText="Recordarme" TitleText="" UserNameLabelText="Usuario:" 
                    UserNameRequiredErrorMessage="Ingrese el usuario" BackColor="#F7F6F3" 
                        BorderColor="Silver" BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" 
                        Font-Names="Verdana" Font-Size="0.9em" ForeColor="#333333" 
                        DisplayRememberMe="False" onauthenticate="lIniciarSesion_Authenticate">
                        <InstructionTextStyle Font-Italic="True" ForeColor="Black" Font-Size="0.9em" />
                        <LoginButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" 
                            BorderWidth="1px" Font-Names="Verdana" Font-Size="0.9em" 
                            ForeColor="#666666" />
                        <TextBoxStyle Font-Size="0.9em" />
                        <TitleTextStyle BackColor="#5D7B9D" Font-Bold="True" Font-Size="0.9em" 
                            ForeColor="White" />
                    </asp:Login>
                    <br />
                    <br />
                </div>
            </div>
            <div id="page_foot">
            </div>
        </div>
    </form>
</body>
</html>