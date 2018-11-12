<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" Async="true" %>

<!DOCTYPE html>
<html>
<head>
<meta name="viewport" content="width=device-width, initial-scale=1">
<style>
body {font-family: Arial, Helvetica, sans-serif;}
form {border: 3px solid #f1f1f1;}

input[type=text], input[type=password] {
    width: 100%;
    padding: 12px 20px;
    margin: 8px 0;
    display: inline-block;
    border: 1px solid #ccc;
    box-sizing: border-box;
}

.button {
    background-color: #243054;
    color: white;
    padding: 14px 20px;
    margin: 8px 0;
    border: none;
    cursor: pointer;
    width: 100%;
}

button:hover {
    opacity: 0.8;
}

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

img.avatar {
    width: 10%;
    border-radius: 10%;
}

/* Clear floats */
.clearfix::after {
    content: "";
    clear: both;
    display: table;
}

.container {
    padding: 16px;
}

span.psw {
    float: right;
    padding-top: 16px;
}

/* Change styles for span and cancel button on extra small screens */
@media screen and (max-width: 300px) {
    span.psw {
       display: block;
       float: none;
        text-align: left;
    }
    .cancelbtn {
       width: 100%;
    }
}
</style>
</head>
<body>
    <form id="form1" runat="server">
         <div class="imgcontainer">
    <img src="utn.png" class="avatar">
  </div>
  <div class="container">
    <label for="uname"><b>Ingrese sus credenciales</b></label>
    <asp:TextBox Placeholder="Ingrese su usuario"  runat="server" ID="UserName" CssClass="form-control" />
    <asp:RequiredFieldValidator runat="server" ControlToValidate="UserName" CssClass="text-danger" ErrorMessage="El campo de nombre de usuario es obligatorio." />
      <br />
    <asp:TextBox Placeholder="Ingrese su password" runat="server" ID="Password" TextMode="Password" CssClass="form-control" />
    <asp:RequiredFieldValidator runat="server" ControlToValidate="Password" CssClass="text-danger" ErrorMessage="El campo de password es obligatorio." />
        
    <asp:Button type="button" CssClass="button" ID="btnLogin" OnClick="btnLogin_Click"  runat="server" Text="Ingresar"/> 
    <asp:Button type="button" CssClass="cancelbtn" ID="btnCancelar"  runat="server" Text="Cancelar" />

      <asp:PlaceHolder runat="server" ID="ErrorMessage"  Visible="false">
                        <p class="text-danger">
                            <asp:Literal runat="server"  ID="FailureText" />
                        </p>
                    </asp:PlaceHolder>
      <%--  --%>
    <label>
       <asp:CheckBox ID="Persist" runat="server" Text ="Recordarme" />
    </label>
     <br><br>
     Olvidé mi <a href="#">password</a></span>
     <br><br>
    <a href="Registro.aspx">Registrarme</a></span>
  </div>
 
    </form>
</body>
</html>
