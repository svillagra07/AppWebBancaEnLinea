using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Views_Transferencias : System.Web.UI.Page
{
    CuentasManager cuentasManager = new CuentasManager();
    TransferenciaManager transferenciasManager = new TransferenciaManager();

    protected override void OnInit(EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.Cache.SetNoStore();
        Response.Cache.SetExpires(DateTime.MinValue);

        base.OnInit(e);
    }


    protected void Page_Load(object sender, EventArgs e)
    {
        CargarTransferencias();
        CargarCuentas();
    }

    async void CargarTransferencias()
    {

        IEnumerable<Transferencia> transferencias =
         await transferenciasManager.ObtenerTransferencias(VariablesGlobales.clienteActual.cli_cod_cliente);
        grdTransferencias.DataSource = transferencias.ToList();
        grdTransferencias.DataBind();
    }

    async void CargarCuentas()
    {
        IEnumerable<Cuenta> cuentas =
        await cuentasManager.ObtenerCuentasCliente(VariablesGlobales.clienteActual.cli_cod_cliente);
        ddCuentaOrigen.DataSource = cuentas.ToList();
        ddCuentaOrigen.DataValueField = "cue_cod_cuenta";
        ddCuentaOrigen.DataTextField = "cue_descripcion";
        ddCuentaOrigen.DataBind();

        ddCuentaDestino.DataSource = cuentas.ToList();
        ddCuentaDestino.DataValueField = "cue_cod_cuenta";
        ddCuentaDestino.DataTextField = "cue_descripcion";
        ddCuentaDestino.DataBind();
    }

    protected void btnEnviar_Click(object sender, EventArgs e)
    {
        if(Validar())
            EnviarTransferencia();
    }

    async void EnviarTransferencia()
    {
        try
        {
            Transferencia transferenciaRealizada = await transferenciasManager.Ingresar(VariablesGlobales.clienteActual.cli_cod_cliente,
                Int32.Parse(ddCuentaOrigen.SelectedValue), Int32.Parse(ddCuentaDestino.SelectedValue), txtDescripcion.Text, "A",
                    DateTime.Now, Convert.ToDecimal(txtMonto.Text));
            lblEstado.Text = "Transferencia exitosa";
            lblEstado.ForeColor = System.Drawing.Color.Green;
        }
        catch (Exception ex)
        {
            lblEstado.Text = "Hubo un error al enviar la transferencia. Detalle: " + ex.Message;
            lblEstado.ForeColor = System.Drawing.Color.Red;
        }
    }

    private bool Validar()
    {
        if (ddCuentaOrigen.SelectedIndex < 0)
        {
            lblEstado.Text = "Seleccione una cuenta de origen";
            lblEstado.ForeColor = System.Drawing.Color.Red;
            return false;
        }
            

        if (ddCuentaDestino.SelectedIndex < 0)
        {
            lblEstado.Text = "Seleccione una cuenta de destino";
            lblEstado.ForeColor = System.Drawing.Color.Red;
            return false;
        }

        if(string.IsNullOrEmpty(txtDescripcion.Text))
        {
            lblEstado.Text = "Debe ingresar una descripcion";
            lblEstado.ForeColor = System.Drawing.Color.Red;
            return false;
        }

        if (string.IsNullOrEmpty(txtMonto.Text))
        {
            lblEstado.Text = "Debe ingresar un monto";
            lblEstado.ForeColor = System.Drawing.Color.Red;
            return false;
        }

        return true;
    }



    protected void grdTransferencias_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (grdTransferencias.Columns.Count > 0)
        {
            if (grdTransferencias.Columns.Count > 0)
            {
                if (e.Row.RowType == DataControlRowType.Header)
                {
                    grdTransferencias.Columns[0].HeaderText = "Codigo";
                    grdTransferencias.Columns[1].HeaderText = "Cliente";
                    grdTransferencias.Columns[2].HeaderText = "Origen";
                    grdTransferencias.Columns[3].HeaderText = "Destino";
                    grdTransferencias.Columns[4].HeaderText = "Descripcion";
                    grdTransferencias.Columns[5].HeaderText = "Estado";
                    grdTransferencias.Columns[6].HeaderText = "Fecha";
                    grdTransferencias.Columns[7].HeaderText = "Monto";
                }
            }
        }
    }
}