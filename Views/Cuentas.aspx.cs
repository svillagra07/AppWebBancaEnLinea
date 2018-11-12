using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Views_Cuentas : System.Web.UI.Page
{

    CuentasManager cuentasManager = new CuentasManager();

    protected override void OnInit(EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.Cache.SetNoStore();
        Response.Cache.SetExpires(DateTime.MinValue);

        base.OnInit(e);
    }

    async protected void Page_Load(object sender, EventArgs e)
    {
        if ((VariablesGlobales.EstadoSesionActual != EstadoSesion.Activa))
        {
            Response.Redirect("~/Login.aspx");
        }

        lblBienvenido.Text = "Bienvenido";
        IEnumerable<Cuenta> cuentas =
         await cuentasManager.ObtenerCuentasCliente(VariablesGlobales.clienteActual.cli_cod_cliente);
        grdCuentas.DataSource = cuentas.ToList();
        grdCuentas.DataBind();
   
    }

}