<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Producto23.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<script src="https://cdn.jsdelivr.net/npm/sweetalert2@11.4.24/dist/sweetalert2.all.min.js"></script>
<script src="https://cdn.jsdelivr.net/npm/sweetalert2@11.4.24/dist/sweetalert2.all.min.js"></script>
<script src="https://cdn.jsdelivr.net/npm/sweetalert2@11.4.24/dist/sweetalert2.min.js"></script>
    <script type="text/javascript">
    function Mensaje(t,m,tipo)
    {
            Swal.fire(
                t, m, tipo
            )
    }
    </script>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

    <title></title>
    <link href="Content/bootstrap-grid.min.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <nav class="navbar navbar-expand-lg navbar-light bg-light">    
                <div class="collapse navbar-collapse" id="navbarNav">
                <ul class="navbar-nav">
                <li class="nav-item">
                  <a class="nav-link" href="marca.aspx">MARCAS</a>
                </li>
                <li class="nav-item">
                  <a class="nav-link" href="actualizacion.aspx">ACTUALIZACIONES</a>
                </li>
                <li class="nav-item">
                  <a class="nav-link" href="componente.aspx">COMPONENTES</a>
                </li>
                <li class="nav-item">
                  <a class="nav-link" href="computadorafinal.aspx">PC FINAL</a>
                </li>
                <li class="nav-item">
                  <a class="nav-link" href="laboratorio.aspx">LABORATORIO</a>
                 </li>
                    <li class="nav-item">
                  <a class="nav-link" href="modeloscpu.aspx">MODELOS</a>
                 </li>
                    <li class="nav-item">
                  <a class="nav-link" href="tiposcpu.aspx">CPU GENERICO</a>
                 </li>
                    <li class="nav-item">
                  <a class="nav-link" href="AccesoriosparaPC.aspx">ACCESORIOS </a>
                 </li>
                    <li class="nav-item">
                  <a class="nav-link" href="DiscoduroRam.aspx">HARDWARE</a>
                 </li>
                    <li class="nav-item">
                  <a class="nav-link" href="laboratorio.aspx">LABORATORIO</a>
                 </li>

      </ul>
    </div>
  </nav>
        </div>
        <div>
           <center><h2>BIENVENIDO AL INVENTARIO </h2></center> 
        </div>
        <center><h2>BIENVENIDO AL INVENTARIO </h2></center> 
        <center><h2>BIENVENIDO AL INVENTARIO </h2></center> 
        <center><h2>BIENVENIDO AL INVENTARIO </h2></center> 
    </form>
</body>
</html>
