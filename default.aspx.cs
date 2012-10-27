﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _default : System.Web.UI.Page {

    protected void Page_Load(object sender, EventArgs e) {
        GeneratePageDate();
    }

    private void GeneratePageDate() {
        string formatedDate;

        formatedDate = DateTime.Now.ToString("dd/MM/yyyy");
        lblDate.Text = ("Fecha: " + formatedDate);
    }
}