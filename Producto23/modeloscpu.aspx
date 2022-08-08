<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="modeloscpu.aspx.cs" Inherits="Producto23.modeloscpu" %>

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
        <div class="bg-dark font-italic"><center><h3>INSERTAR MODELO DEL CPU</h3></center></div>
        <div><center>

             <asp:Label ID="Label1" runat="server" Text="Modelo del CPU"></asp:Label>
&nbsp;
             <asp:TextBox ID="TextBox1" runat="server" Width="209px"></asp:TextBox>
             <br />
             Elige una Marca
             <br />
             <br />
             <asp:GridView ID="GridView3" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None">
                 <AlternatingRowStyle BackColor="PaleGoldenrod" />
                 <Columns>
                     <asp:CommandField ShowSelectButton="True" />
                 </Columns>
                 <FooterStyle BackColor="Tan" />
                 <HeaderStyle BackColor="Tan" Font-Bold="True" />
                 <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                 <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                 <SortedAscendingCellStyle BackColor="#FAFAE7" />
                 <SortedAscendingHeaderStyle BackColor="#DAC09E" />
                 <SortedDescendingCellStyle BackColor="#E1DB9C" />
                 <SortedDescendingHeaderStyle BackColor="#C2A47B" />
             </asp:GridView>
             <br />
             <asp:Button ID="Button1" runat="server" BackColor="Aqua" Text="Insertar Modelo" Width="183px" OnClick="Button1_Click" />

             <br />
             <br />
             <asp:TextBox ID="TextBox7" runat="server" Width="397px"></asp:TextBox>

             </center></div>
        <div class="bg-dark font-italic" ><center><h3>MOSTRAR MODELOS </h3></center></div>
        <div><center>
            <asp:Button ID="Button4" runat="server" Text="Mostrar CPUS" Width="180px" BackColor="#99FFCC" OnClick="Button4_Click" />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None">
                <AlternatingRowStyle BackColor="PaleGoldenrod" />
                <FooterStyle BackColor="Tan" />
                <HeaderStyle BackColor="Tan" Font-Bold="True" />
                <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                <SortedAscendingCellStyle BackColor="#FAFAE7" />
                <SortedAscendingHeaderStyle BackColor="#DAC09E" />
                <SortedDescendingCellStyle BackColor="#E1DB9C" />
                <SortedDescendingHeaderStyle BackColor="#C2A47B" />
            </asp:GridView>
             </center></div>
        <div class="bg-dark font-italic" ><center><h3>ACTUALIZAR</h3></center></div>
        <div><center></center></div>
        <div class="bg-dark font-italic" ><center><h3>ELIMINAR</h3></center></div>
        <div><center></center></div>
        <div class="bg-dark font-italic"><center><h3>INSERTAR TIPO DE CPU</h3></center></div>
        <div><center>

             <asp:Label ID="Label3" runat="server" Text="Tipo CPU "></asp:Label>
&nbsp;<asp:TextBox ID="TextBox2" runat="server" Width="217px"></asp:TextBox>
             <br />
             <br />
             <asp:Label ID="Label4" runat="server" Text="Familia"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox3" runat="server" Width="187px"></asp:TextBox>
             <br />
             <br />
             <asp:Label ID="Label5" runat="server" Text="Velocidad"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox4" runat="server" Width="189px"></asp:TextBox>
             <br />
             Elige
             Modelo CPU
             <br />
             <asp:GridView ID="GridView4" runat="server" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal">
                 <Columns>
                     <asp:CommandField ShowSelectButton="True" />
                 </Columns>
                 <FooterStyle BackColor="White" ForeColor="#333333" />
                 <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                 <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                 <RowStyle BackColor="White" ForeColor="#333333" />
                 <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                 <SortedAscendingCellStyle BackColor="#F7F7F7" />
                 <SortedAscendingHeaderStyle BackColor="#487575" />
                 <SortedDescendingCellStyle BackColor="#E5E5E5" />
                 <SortedDescendingHeaderStyle BackColor="#275353" />
             </asp:GridView>
             <br />
             <br />
             <asp:Label ID="Label6" runat="server" Text="Extra"></asp:Label>
             <asp:TextBox ID="TextBox5" runat="server" Width="217px"></asp:TextBox>
             <br />
             <br />
             <asp:Button ID="Button2" runat="server" BackColor="#00CC99" Text="Insertar TipoCPU" Width="201px" OnClick="Button2_Click" />

             <br />
             <br />
             <asp:TextBox ID="TextBox6" runat="server" Width="367px"></asp:TextBox>

             </center></div>
        <div class="bg-dark font-italic" ><center><h3>MOSTRAR TIPOS CPU</h3></center></div>
        <div><center>

             <asp:Button ID="Button3" runat="server" BackColor="#0099FF" Text="Mostrar Tipos CPU" Width="191px" OnClick="Button3_Click" />
             <br />
             <br />
             <asp:GridView ID="GridView2" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical">
                 <AlternatingRowStyle BackColor="#CCCCCC" />
                 <FooterStyle BackColor="#CCCCCC" />
                 <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                 <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                 <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                 <SortedAscendingCellStyle BackColor="#F1F1F1" />
                 <SortedAscendingHeaderStyle BackColor="#808080" />
                 <SortedDescendingCellStyle BackColor="#CAC9C9" />
                 <SortedDescendingHeaderStyle BackColor="#383838" />
             </asp:GridView>

             </center></div>
         </form>
</body>
</html>
