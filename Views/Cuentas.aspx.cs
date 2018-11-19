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



    protected void grdCuentas_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if(grdCuentas.Columns.Count > 0)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                grdCuentas.Columns[0].HeaderText = "Cuenta";
                grdCuentas.Columns[1].HeaderText = "Cliente";
                grdCuentas.Columns[2].HeaderText = "Descripcion";
                grdCuentas.Columns[3].HeaderText = "Saldo";
                grdCuentas.Columns[4].HeaderText = "Estado";
                grdCuentas.Columns[5].HeaderText = "Moneda";
            }
        }
     
    }
}