using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected override void OnInit(EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.Cache.SetNoStore();
        Response.Cache.SetExpires(DateTime.MinValue);

        base.OnInit(e);
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if ((VariablesGlobales.EstadoSesionActual != EstadoSesion.Activa))
        {
            Response.Redirect("~/Login.aspx");
        }

    }

    protected void LinkButtonCuentas_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Views/Cuentas.aspx");
    }

    protected void LinkButtonTransferencias_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Views/Transferencias.aspx");
    }

    protected void LinkPagos_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Views/Pagos.aspx");
    }

    protected void lnkButton_Click(object sender, EventArgs e)
    {
        FormsAuthentication.SignOut();
        Response.Redirect("Login.aspx");
    }
}