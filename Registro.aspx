<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registro.aspx.cs" Inherits="AppWebBancaEnLinea_Registro" Async="true" %>


<!DOCTYPE html>
<html>
<style>
body {font-family: Arial, Helvetica, sans-serif;}
* {box-sizing: border-box}

/* Full-width input fields */
input[type=text], input[type=password] {
    width: 100%;
    padding: 15px;
    margin: 5px 0 22px 0;
    display: inline-block;
   border: 1px solid #ccc;
    background: #f1f1f1;
}

input[type=text]:focus, input[type=password]:focus {
    background-color: #ddd;
    outline: none;
}

hr {
    border: 1px solid #f1f1f1;
    margin-bottom: 25px;
}

/* Set a style for all buttons */
.button {
    background-color: #243054;
    color: white;
    padding: 14px 20px;
    margin: 8px 0;
    border: none;
    cursor: pointer;
    width: 100%;
    opacity: 0.9;
}

button:hover {
    opacity:1;
}

/* Extra styles for the cancel button */
.cancelbtn {
    width: 100%;
    padding: 10px 18px;
    color: white;
    background-color: #898989;
}

.imgcontainer {
    text-align: center;
    margin: 24px 0 12px 0;
}


/* Add padding to container elements */
.container {
    padding: 16px;
}

/* Clear floats */
.clearfix::after {
    content: "";
    clear: both;
    display: table;
}

img.avatar {
    width: 8%;
    border-radius: 10%;
}

/* Change styles for cancel button and signup button on extra small screens */
@media screen and (max-width: 300px) {
    .cancelbtn, .signupbtn {
       width: 100%;
    }
}
</style>
<body>
<form id="form1" runat="server" style="border:1px solid #ccc">
  <div class="container">
  <div class="imgcontainer">
    <img src="logo_sama.jpg" alt="Avatar" class="avatar">
  </div>
    <h1>Registro</h1>
    <p>Complete el siguiente formulario para crear una cuenta.</p>
    <hr>
    <label for="Nombre"><b>Nombre:</b></label>
    <asp:TextBox  runat="server" Placeholder="Ingrese su nombre" ID="Nombre" CssClass="form-control" />
    <asp:RequiredFieldValidator runat="server" ControlToValidate="Nombre" CssClass="text-danger" ErrorMessage="El campo de nombre es obligatorio." />
    <br /><label for="Username"><b>Username:</b></label>
    <asp:TextBox  runat="server" Placeholder="Ingrese su usuario" ID="UserName" CssClass="form-control" />
    <asp:RequiredFieldValidator runat="server" ControlToValidate="UserName" CssClass="text-danger" ErrorMessage="El campo de nombre de usuario es obligatorio." />
    <br /><label for="Email"><b>Email</b></label>
    <asp:TextBox  runat="server" Placeholder="Ingrese su email" ID="Email" CssClass="form-control" />
    <asp:RequiredFieldValidator runat="server" ControlToValidate="Email" CssClass="text-danger" ErrorMessage="El campo de nombre de email es obligatorio." />
    <br /><label for="Password"><b>Password</b></label>
    <asp:TextBox  runat="server" Placeholder="Ingrese su password" ID="Password" CssClass="form-control" />
    <asp:RequiredFieldValidator runat="server" ControlToValidate="Password" CssClass="text-danger" ErrorMessage="El campo de nombre de password es obligatorio." />
    <br /><label for="ConfirmacionPassword"><b>Confirme password</b></label>
    <asp:TextBox  runat="server" Placeholder="Confirme su password" ID="ConfirmacionPassword" CssClass="form-control" />
    <asp:RequiredFieldValidator runat="server" ControlToValidate="ConfirmacionPassword" CssClass="text-danger" ErrorMessage="La confirmación del password es obligatoria." />
    <div class="clearfix">

    <asp:Button type="button" CssClass="button" ID="btnRegistro"  runat="server" Text="Registrarme" OnClick="btnRegistro_Click" /> 
    <br><br>
    <asp:Button type="button" CssClass="cancelbtn" ID="btnCancelar"  runat="server" Text="Cancelar" />
    
    <asp:PlaceHolder runat="server" ID="ErrorMessage" Visible="false">
                <p class="text-danger">
                    <asp:Literal runat="server" ID="FailureText" />
                </p>
      </asp:PlaceHolder>
          
      <label>
      <input type="checkbox" checked="checked" name="remember" style="margin-bottom:15px"> Recordarme
    </label>
    </div>
  </div>
</form>

</body>
</html>
