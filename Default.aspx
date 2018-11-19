<%@ Page Title="Home Page" Language="C#"  AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" Debug="true"%>

<!DOCTYPE html>
<html lang="en">
<head>
  <title>Banca en línea UTN</title>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
  <link href="https://fonts.googleapis.com/css?family=Montserrat" rel="stylesheet" type="text/css">
  <link href="https://fonts.googleapis.com/css?family=Lato" rel="stylesheet" type="text/css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
  <style>
  body {
      font: 400 15px Lato, sans-serif;
      line-height: 1.8;
      color: #818181;
  }
  h2 {
      font-size: 24px;
      text-transform: uppercase;
      color: #303030;
      font-weight: 600;
      margin-bottom: 30px;
  }
  h4 {
      font-size: 19px;
      line-height: 1.375em;
      color: #303030;
      font-weight: 400;
      margin-bottom: 30px;
  }  
  .jumbotron {
      background-color: #243054;
      color: #fff;
      padding: 50px 25px;
      font-family: Montserrat, sans-serif;
  }
  .container-fluid {
      padding: 60px 50px;
  }
  .bg-grey {
      background-color: #f6f6f6;
  }
  .logo-small {
      color: #243054;
      font-size: 50px;
  }
  .logo {
      color: #243054;
      font-size: 200px;
  }
  .thumbnail {
      padding: 0 0 15px 0;
      border: none;
      border-radius: 0;
  }
  .thumbnail img {
      width: 100%;
      height: 100%;
      margin-bottom: 10px;
  }
  .carousel-control.right, .carousel-control.left {
      background-image: none;
      color: #243054;
  }
  .carousel-indicators li {
      border-color: #243054;
  }
  .carousel-indicators li.active {
      background-color: #243054;
  }
  .item h4 {
      font-size: 19px;
      line-height: 1.375em;
      font-weight: 400;
      font-style: italic;
      margin: 70px 0;
  }
  .item span {
      font-style: normal;
  }
  .panel {
      border: 1px solid #243054; 
      border-radius:0 !important;
      transition: box-shadow 0.5s;
  }
  .panel:hover {
      box-shadow: 5px 0px 40px rgba(0,0,0, .2);
  }
  .panel-footer .btn:hover {
      border: 1px solid #243054;
      background-color: #fff !important;
      color: #243054;
  }
  .panel-heading {
      color: #fff !important;
      background-color: #243054 !important;
      padding: 25px;
      border-bottom: 1px solid transparent;
      border-top-left-radius: 0px;
      border-top-right-radius: 0px;
      border-bottom-left-radius: 0px;
      border-bottom-right-radius: 0px;
  }
  .panel-footer {
      background-color: white !important;
  }
  .panel-footer h3 {
      font-size: 32px;
  }
  .panel-footer h4 {
      color: #aaa;
      font-size: 14px;
  }
  .panel-footer .btn {
      margin: 15px 0;
      background-color: #243054;
      color: #fff;
  }
  .navbar {
      margin-bottom: 0;
      background-color: #243054;
      z-index: 9999;
      border: 0;
      font-size: 12px !important;
      line-height: 1.42857143 !important;
      letter-spacing: 4px;
      border-radius: 0;
      font-family: Montserrat, sans-serif;
  }
  .navbar li a, .navbar .navbar-brand {
      color: #fff !important;
  }
  .navbar-nav li a:hover, .navbar-nav li.active a {
      color: #243054 !important;
      background-color: #fff !important;
  }
  .navbar-default .navbar-toggle {
      border-color: transparent;
      color: #fff !important;
  }
  footer .glyphicon {
      font-size: 20px;
      margin-bottom: 20px;
      color: #243054;
  }

  img.avatar {
    width: 45%;
    border-radius: 10%;
}

  .slideanim {visibility:hidden;}
  .slide {
      animation-name: slide;
      -webkit-animation-name: slide;
      animation-duration: 1s;
      -webkit-animation-duration: 1s;
      visibility: visible;
  }
  @keyframes slide {
    0% {
      opacity: 0;
      transform: translateY(70%);
    } 
    100% {
      opacity: 1;
      transform: translateY(0%);
    }
  }
  @-webkit-keyframes slide {
    0% {
      opacity: 0;
      -webkit-transform: translateY(70%);
    } 
    100% {
      opacity: 1;
      -webkit-transform: translateY(0%);
    }
  }
  @media screen and (max-width: 768px) {
    .col-sm-4 {
      text-align: center;
      margin: 25px 0;
    }
    .btn-lg {
        width: 100%;
        margin-bottom: 35px;
    }
  }
  @media screen and (max-width: 480px) {
    .logo {
        font-size: 150px;
    }
  }
  </style>
</head>
<body id="myPage" data-spy="scroll" data-target=".navbar" data-offset="60">

<nav class="navbar navbar-default navbar-fixed-top">
  <div class="container">
    <div class="navbar-header">
     <a href="MenuPrincipal.aspx"></a>
    </div>
    <div class="collapse navbar-collapse" id="myNavbar">
      <ul class="nav navbar-nav navbar-right">
         <li><a href="Views/Cuentas.aspx">Cuentas</a></li>
        <li><a href="Views/Transferencias.aspx">Transferencias</a></li>
        <li><a href="Views/Pagos.aspx">Pagos</a></li>
        <li><a href="Logout.aspx" >Cerrar sesión</a></li>
      </ul>
    </div>
  </div>
</nav>

<!-- Container (Services Section) -->
<div id="services" class="container-fluid text-center">
<form id="form1" runat="server">
<h1><asp:Label ID="lblBienvenido" runat="server" Text="Bienvenido(a)"></asp:Label></h1>
  <h2>Menú principal</h2>
  <br>
<!--  <div class="row slideanim"> -->
    <div class="col-sm-3">
      <span class="glyphicon glyphicon-user logo-small"></span>
      <h4><asp:LinkButton ID="LinkButtonCuentas" runat="server" OnClick="LinkButtonCuentas_Click" >Cuentas</asp:LinkButton></h4>
      <p>Administrar sus cuentas</p>
    </div>
    <div class="col-sm-3">
      <span class="glyphicon glyphicon-lock logo-small"></span>
       <h4><asp:LinkButton ID="LinkButtonTransferencias" runat="server" OnClick="LinkButtonTransferencias_Click" >Transferencias</asp:LinkButton></h4>
      <p>Transfiera dinero entre sus cuentas</p>
    </div>
    <div class="col-sm-3">
      <span class="glyphicon glyphicon-signal logo-small"></span>
      <h4><asp:LinkButton ID="LinkPagos" runat="server" OnClick="LinkPagos_Click" >Pagos en línea</asp:LinkButton></h4>
      <p>Pago de servicios</p>
    </div>
        <div class="col-sm-3">
      <span class="glyphicon glyphicon-off logo-small"></span>
      <h4><asp:LinkButton ID="lnkButton" runat="server" OnClick="lnkButton_Click">Cerrar sesión</asp:LinkButton></h4>
      <p>Salir del sitio</p>
    </div>
</form>
<!-- </div> -->
</div>


<footer class="container-fluid text-center">
  <a href="#myPage" title="To Top">
    <span class="glyphicon glyphicon-chevron-up"></span>
  </a>
  <p>UTN - Visite nuestro sitio principal<a href="http://www.utn.ac.cr" title="Visite nuestro sitio principal">www.utn.ac.cr</a></p>
</footer>
</body>
</html>
