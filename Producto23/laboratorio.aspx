<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="laboratorio.aspx.cs" Inherits="Producto23.laboratotrio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
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
                  <a class="nav-link" href="index.aspx">INICIO</a>
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

      </ul>
    </div>
  </nav>
        </div>
        <div class="bg-dark font-italic"><center><h3>INSERTAR LABORATORIOS</h3></center></div>
        <div><center>

             <asp:Label ID="Label1" runat="server" Text="nombre de laboratorio"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server" Width="197px"></asp:TextBox>
             <br />
             <br />
             <asp:Label ID="Label2" runat="server" Text="ubicacion"></asp:Label>
             <asp:TextBox ID="TextBox2" runat="server" Width="270px"></asp:TextBox>
             <br />
             <br />
             <asp:Button ID="Button1" runat="server" BackColor="#3399FF" Text="Insertar laboratorio" Width="145px" OnClick="Button1_Click" />
             <br />
             <br />
             <asp:TextBox ID="TextBox3" runat="server" Width="410px"></asp:TextBox>

             </center></div>
        <div class="bg-dark font-italic" ><center><h3>MOSTRAR LABORATORIOS</h3>
            <p>
                <asp:Button ID="Button2" runat="server" BackColor="#0066CC" OnClick="Button2_Click" Text="Mostrar laboratorios" Width="208px" />
            </p></center></div>
        <div><center>
            <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <EditRowStyle BackColor="#7C6F57" />
                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#E3EAEB" />
                <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F8FAFA" />
                <SortedAscendingHeaderStyle BackColor="#246B61" />
                <SortedDescendingCellStyle BackColor="#D4DFE1" />
                <SortedDescendingHeaderStyle BackColor="#15524A" />
            </asp:GridView>
             </center></div>
        <div class="bg-dark font-italic" ><center><h3>ACTUALIZAR</h3></center></div>
        <div><center></center></div>
        <div class="bg-dark font-italic "><center><h3>ELIMINAR</h3></center></div>
        <div><center></center></div>
    </form>
</body>
</html>
