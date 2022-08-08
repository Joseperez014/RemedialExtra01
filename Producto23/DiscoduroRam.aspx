<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DiscoduroRam.aspx.cs" Inherits="Producto23.DiscoduroRam" %>

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
                  <a class="nav-link" href="laboratorio.aspx">LABORATORIO</a>
                 </li>

      </ul>
    </div>
  </nav>
        <div class="bg-dark font-italic"><center><h3>INSERTAR DISCO DURO</h3></center></div>
        <div><center>

             <asp:Label ID="Label1" runat="server" Text="Tipo de disco"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server" Width="183px"></asp:TextBox>
             <br />
             <asp:Label ID="Label2" runat="server" Text="conector"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox2" runat="server" Width="193px"></asp:TextBox>
             <br />
             <asp:Label ID="Label3" runat="server" Text="capacidad"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
             <br />
             <asp:Label ID="Label4" runat="server" Text="Elige una Marca"></asp:Label>
&nbsp;<br />
             <asp:GridView ID="GridView5" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                 <AlternatingRowStyle BackColor="White" />
                 <Columns>
                     <asp:CommandField ShowSelectButton="True" />
                 </Columns>
                 <EditRowStyle BackColor="#2461BF" />
                 <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                 <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                 <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                 <RowStyle BackColor="#EFF3FB" />
                 <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                 <SortedAscendingCellStyle BackColor="#F5F7FB" />
                 <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                 <SortedDescendingCellStyle BackColor="#E9EBEF" />
                 <SortedDescendingHeaderStyle BackColor="#4870BE" />
             </asp:GridView>
             <br />
             extra
             <asp:TextBox ID="TextBox4" runat="server" Width="192px"></asp:TextBox>
             <br />
             &nbsp;<asp:Label ID="Label5" runat="server" Text="Escribe el numero de un inventario en el recuadro siguiente"></asp:Label>
             <br />
             <asp:GridView ID="GridView6" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="244px">
                 <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                 <EditRowStyle BackColor="#999999" />
                 <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                 <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                 <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                 <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                 <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                 <SortedAscendingCellStyle BackColor="#E9E7E2" />
                 <SortedAscendingHeaderStyle BackColor="#506C8C" />
                 <SortedDescendingCellStyle BackColor="#FFFDF8" />
                 <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
             </asp:GridView>
             <br />
             <asp:Label ID="Label11" runat="server" Text="Numero de inventario"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox12" runat="server" Width="199px"></asp:TextBox>
             <br />
             <br />
             <asp:Button ID="Button1" runat="server" BackColor="#0033CC" Text="Insertar Disco Duro" Width="147px" OnClick="Button1_Click" />
             <br />
             <br />
             <asp:TextBox ID="TextBox9" runat="server" Width="453px"></asp:TextBox>

             </center></div>
        <div class="bg-dark font-italic" ><center><h3>MOSTRAR DISCO DUROS</h3></center></div>
        <div><center>
            <asp:Button ID="Button5" runat="server" BackColor="#3366FF" OnClick="Button5_Click" Text="Mostrar Discos duros" Width="147px" />
            <br />
            <asp:GridView ID="GridView2" runat="server" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" Height="150px" Width="191px">
                <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                <RowStyle BackColor="White" ForeColor="#330099" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                <SortedAscendingCellStyle BackColor="#FEFCEB" />
                <SortedAscendingHeaderStyle BackColor="#AF0101" />
                <SortedDescendingCellStyle BackColor="#F6F0C0" />
                <SortedDescendingHeaderStyle BackColor="#7E0000" />
            </asp:GridView>
             </center></div>
        <div class="bg-dark font-italic" ><center><h3>ACTUALIZAR DISCO DURO</h3></center></div>
        <div><center>

             </center></div>
        <div class="bg-dark font-italic" ><center><h3>ELIMINAR DISCO DURO</h3></center></div>
        <div><center>

             </center></div>

            <div class="bg-dark font-italic"><center><h3>INSERTAR CANTIDAD DE DISCOS DUROS</h3></center></div>
        <div><center>

             <asp:Label ID="Label6" runat="server" Text="cantidad de discos"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox5" runat="server" Width="196px" OnTextChanged="TextBox5_TextChanged"></asp:TextBox>
             <br />
             Escribe el
             numero de inventario
             en el recuadro siguiente&nbsp;
             <br />
             <asp:GridView ID="GridView7" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" OnSelectedIndexChanged="GridView7_SelectedIndexChanged">
                 <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                 <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                 <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                 <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                 <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                 <SortedAscendingCellStyle BackColor="#FFF1D4" />
                 <SortedAscendingHeaderStyle BackColor="#B95C30" />
                 <SortedDescendingCellStyle BackColor="#F1E5CE" />
                 <SortedDescendingHeaderStyle BackColor="#93451F" />
             </asp:GridView>
             <br />
             <asp:Label ID="Label13" runat="server" Text="Numero de inventario"></asp:Label>
             <asp:TextBox ID="TextBox14" runat="server" Width="179px"></asp:TextBox>
             <br />
             selecciona un
             <asp:Label ID="Label7" runat="server" Text="numero de disco"></asp:Label>
&nbsp;<br />
             <asp:GridView ID="GridView8" runat="server" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4">
                 <Columns>
                     <asp:CommandField ShowSelectButton="True" />
                 </Columns>
                 <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                 <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                 <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                 <RowStyle BackColor="White" ForeColor="#330099" />
                 <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                 <SortedAscendingCellStyle BackColor="#FEFCEB" />
                 <SortedAscendingHeaderStyle BackColor="#AF0101" />
                 <SortedDescendingCellStyle BackColor="#F6F0C0" />
                 <SortedDescendingHeaderStyle BackColor="#7E0000" />
             </asp:GridView>
             <br />
             <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:Button ID="Button2" runat="server" BackColor="#66CCFF" Text="Insertar cantidad de disco" Width="183px" OnClick="Button2_Click" />
             <br />
             <br />
             <asp:TextBox ID="TextBox8" runat="server" Width="438px"></asp:TextBox>

             </center></div>
        <div class="bg-dark font-italic" ><center><h3>MOSTRAR CANTIDAD DE DISCOS DUROS</h3></center></div>
        <div><center>
            <asp:Button ID="Button6" runat="server" BackColor="#6666FF" OnClick="Button6_Click" Text="Mostrar cantidad de discos duros" Width="230px" />
            <br />
            <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle ForeColor="#000066" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#00547E" />
            </asp:GridView>

             </center></div>
        <div class="bg-dark font-italic" ><center><h3>ACTUALIZAR CANTIDAD DE DISCOS DUROS</h3></center></div>
        <div><center>

             </center></div>
        <div class="bg-dark font-italic" ><center><h3>ELIMINAR CANTIDAD DE DISCOS DUROS</h3></center></div>
             <div><center>

             </center></div>
            <div class="bg-dark font-italic"><center><h3>INSERTAR TIPOS DE RAM</h3></center></div>
        <div><center>

             <asp:Label ID="Label8" runat="server" Text="Tipo Memoria RAM"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox6" runat="server" Width="175px"></asp:TextBox>
             <br />
             <br />
             <asp:Label ID="Label9" runat="server" Text="Extra"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox7" runat="server" Width="206px"></asp:TextBox>
             <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:Button ID="Button3" runat="server" BackColor="#0033CC" Text="Insertar Tipo RAM" Width="210px" OnClick="Button3_Click" />
             <br />
             <asp:TextBox ID="TextBox10" runat="server" Width="403px"></asp:TextBox>

             </center></div>
        <div class="bg-dark font-italic" ><center><h3>MOSTRAR TIPOS DE RAM</h3></center></div>
        <div><center>
            <asp:Button ID="Button7" runat="server" BackColor="Lime" OnClick="Button7_Click" Text="Mostrar tipos de ram" Width="198px" />
            <br />
            <asp:GridView ID="GridView3" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical">
                <AlternatingRowStyle BackColor="#DCDCDC" />
                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#0000A9" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#000065" />
            </asp:GridView>
             </center></div>
        <div class="bg-dark font-italic" ><center><h3>ACTUALIZAR TIPOS DE RAM</h3></center></div>
        <div><center>

             </center></div>
        <div class="bg-dark font-italic" ><center><h3>ELIMINAR TIPOS DE RAM</h3></center></div>
            <div><center>

                 </center></div>
            <div class="bg-dark font-italic"><center><h3>INSERTAR RAM</h3></center></div>
        <div><center>

             <asp:Label ID="Label10" runat="server" Text="Capacidad"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox11" runat="server" Width="148px"></asp:TextBox>
             <br />
             <br />

             <asp:Label ID="Label12" runat="server" Text="Velocidad"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox13" runat="server" Width="165px"></asp:TextBox>
             <br />
             Elige un Tipo de RAM<br />
             <asp:GridView ID="GridView9" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
                 <Columns>
                     <asp:CommandField ShowSelectButton="True" />
                 </Columns>
                 <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                 <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                 <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                 <RowStyle BackColor="White" ForeColor="#003399" />
                 <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                 <SortedAscendingCellStyle BackColor="#EDF6F6" />
                 <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                 <SortedDescendingCellStyle BackColor="#D6DFDF" />
                 <SortedDescendingHeaderStyle BackColor="#002876" />
             </asp:GridView>
             <br />
             <asp:Button ID="Button4" runat="server" BackColor="#99CCFF" Text="Insertar RAM" Width="178px" OnClick="Button4_Click" />

             </center></div>
        <div class="bg-dark font-italic" ><center><h3>MOSTRAR RAM</h3></center></div>
        <div><center>
            <asp:Button ID="Button8" runat="server" BackColor="#66FFCC" OnClick="Button8_Click" Text="Mostrar RAM'S" Width="165px" />
            <br />
            <asp:GridView ID="GridView4" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
             </center></div>
        <div class="bg-dark font-italic "><center><h3>ACTUALIZAR RAM</h3></center></div>
        <div><center>

             </center></div>
        <div class="bg-dark font-italic" ><center><h3>ELIMINAR RAM </h3></center></div>
            <div><center>

                 </center></div>
    </form>
</body>
</html>
