using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AppWebBancaEnLinea_Registro : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    async protected void btnRegistro_Click(object sender, EventArgs e)
    {
        if (IsValid)
        {
            var manager = new AppUsuarioManager();
            AppUsuario usuario = await manager.Registrar(UserName.Text, Nombre.Text, Password.Text, Email.Text);
            if (usuario != null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                FailureText.Text = "Error en la creación del usuario.";
                ErrorMessage.Visible = true;
            }
        }
    }

    private bool Validar()
    {
        if (!Password.Text.Equals(ConfirmacionPassword.Text))
        {
            FailureText.Text = "Los password no coinciden.";
            ErrorMessage.Visible = true;
            return false;
        }

        return true;
    }
}