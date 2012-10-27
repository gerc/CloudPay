using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using CloudPay.Session;

public partial class _default : System.Web.UI.Page {

    protected void Page_Load(object sender, EventArgs e) {
        ValidateSession();
        GeneratePageDate();
    }

    private void GeneratePageDate() {
        string formatedDate;

        formatedDate = DateTime.Now.ToString("dd/MM/yyyy");
        lblDate.Text = ("Fecha: " + formatedDate);
    }

    private void ValidateSession() {
        UserSession userSessionInfo;

        if (Session["user_session_info"] != null) {
            userSessionInfo = (UserSession)Session["user_session_info"];
            lblSessionUser.Text = "Bienvenido, " + userSessionInfo.Name + " (" + userSessionInfo.AppName + ")";
            lnkSessionAction.Text = "Cerrar sesi&oacute;n";
        }
    }
}