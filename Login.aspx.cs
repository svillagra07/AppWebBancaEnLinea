using System;
using System.Collections.Generic;
//using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    ClientesManager clientesManager = new ClientesManager();

    protected void Page_Load(object sender, EventArgs e)
    {
    }
    async protected void btnLogin_Click(object sender, EventArgs e)
    {
        if (IsValid)
        {
            var manager = new AppUsuarioManager();
            string token = await manager.Validar(UserName.Text, Password.Text);
            if (!string.IsNullOrEmpty(token))
            {
                VariablesGlobales.AuthorizationKey = token;
             
                var jwthandler = new System.IdentityModel.Tokens.Jwt.JwtSecurityTokenHandler();
                VariablesGlobales.Token = jwthandler.ReadToken(token);

                VariablesGlobales.clienteActual = await clientesManager.GetCliente(0, UserName.Text);
                VariablesGlobales.EstadoSesionActual = EstadoSesion.Activa;
                FormsAuthentication.RedirectFromLoginPage(UserName.Text, Persist.Checked);
            }
            else
            {
                FailureText.Text = "Credenciales inválidas.";
                ErrorMessage.Visible = true;
            }

        }
    }
}