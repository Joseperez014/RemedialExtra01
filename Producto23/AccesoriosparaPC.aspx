<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AccesoriosparaPC.aspx.cs" Inherits="Producto23.AccesoriosparaPC" %>

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
                  <a class="nav-link" href="ubicacion.aspx">UBICACION</a>
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
        <br />
        <div class="bg-light fst-italic"><center><h3>INSERTAR TECLADO</h3>
            <p>&nbsp;</p>
            <p>selecciona una marca<br />
                <asp:GridView ID="GridView5" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                    </Columns>
                    <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                    <SortedAscendingCellStyle BackColor="#FDF5AC" />
                    <SortedAscendingHeaderStyle BackColor="#4D0000" />
                    <SortedDescendingCellStyle BackColor="#FCF6C0" />
                    <SortedDescendingHeaderStyle BackColor="#820000" />
                </asp:GridView>
            </p>
            <br />conector
             <asp:TextBox ID="TextBox1" runat="server" Width="222px"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" BackColor="#0099FF" Text="Insertar Teclado" Width="130px" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:TextBox ID="TextBox2" runat="server" Width="404px"></asp:TextBox>
            <br /></center>
        </div>
        <div class="bg-light fst-italic"><center><h3>MOSTRAR TECLADOS </h3></center></div>
        <div><center>

             <asp:Button ID="Button2" runat="server" BackColor="#0066FF" Text="Mostrar Teclados" Width="174px" OnClick="Button2_Click" />
             <br />
             <br />
             <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
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
             <br />
             <asp:TextBox ID="TextBox3" runat="server" Width="426px"></asp:TextBox>
             <br />
             <br />

             </center></div>
        <div class="bg-light fst-italic"><center><h3>INSERTAR MOUSE</h3>
            <p>&nbsp;</p>
            selecciona una marca<br />
             <asp:GridView ID="GridView6" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="29px" OnSelectedIndexChanged="GridView6_SelectedIndexChanged" Width="80px">
                 <AlternatingRowStyle BackColor="White" />
                 <Columns>
                     <asp:CommandField ShowSelectButton="True" />
                 </Columns>
                 <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                 <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                 <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                 <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                 <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                 <SortedAscendingCellStyle BackColor="#FDF5AC" />
                 <SortedAscendingHeaderStyle BackColor="#4D0000" />
                 <SortedDescendingCellStyle BackColor="#FCF6C0" />
                 <SortedDescendingHeaderStyle BackColor="#820000" />
            </asp:GridView>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Conector "></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server" Width="254px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" BackColor="#0033CC" Text="Insertar Mouse" Width="221px" OnClick="Button3_Click" />
            <br />
            <br />
            <asp:TextBox ID="TextBox15" runat="server" Width="420px"></asp:TextBox>
            <br />
            <br /></center>
        </div>
        <div class="bg-light fst-italic"><center><h3>MOSTRAR MOUSES </h3></center></div>
        <div><center>
            <asp:Button ID="Button4" runat="server" BackColor="#0066CC" Text="Mostrar Mouses" Width="169px" OnClick="Button4_Click" />
            <br />
            <br />
            <asp:GridView ID="GridView2" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="159px" Width="187px">
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
            <br />
            <asp:TextBox ID="TextBox14" runat="server" Width="366px"></asp:TextBox>
            <br />
            <br />
            </center> </div>
        <div class="bg-light fst-italic"><center><h3>INSERTAR MONITOR </h3></center></div>
        <div> <center> 
            selecciona una marca<br />
             <asp:GridView ID="GridView7" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                 <AlternatingRowStyle BackColor="White" />
                 <Columns>
                     <asp:CommandField ShowSelectButton="True" />
                 </Columns>
                 <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                 <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                 <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                 <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                 <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                 <SortedAscendingCellStyle BackColor="#FDF5AC" />
                 <SortedAscendingHeaderStyle BackColor="#4D0000" />
                 <SortedDescendingCellStyle BackColor="#FCF6C0" />
                 <SortedDescendingHeaderStyle BackColor="#820000" />
            </asp:GridView>
&nbsp;<br />
            <br />
            conectores
            <asp:TextBox ID="TextBox5" runat="server" Width="177px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="dimensiones"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox6" runat="server" Width="164px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="tamaño"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox7" runat="server" Width="188px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label7" runat="server" Text="Tipo monitor"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox8" runat="server" Width="156px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button5" runat="server" BackColor="#0066CC" Text="Insertar Monitor" Width="215px" OnClick="Button5_Click" />
            <br />
            <br />
            <asp:TextBox ID="TextBox13" runat="server" Width="388px"></asp:TextBox>
            <br />
            </center></div>
       <div class="bg-light fst-italic"><center><h3>MOSTRAR MONITORES   </h3>
           </center></div>
        <div><center>
            <asp:Button ID="Button6" runat="server" BackColor="#33CCFF" Text="Mostrar Monitores" Width="175px" OnClick="Button6_Click" />
            <br />
            <br />
            <asp:GridView ID="GridView3" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal">
                <AlternatingRowStyle BackColor="#F7F7F7" />
                <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                <SortedAscendingCellStyle BackColor="#F4F4FD" />
                <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
                <SortedDescendingCellStyle BackColor="#D8D8F0" />
                <SortedDescendingHeaderStyle BackColor="#3E3277" />
            </asp:GridView>
            <br />
            </center> </div>
        <div class="bg-light fst-italic"><center><h3>INSERTAR GABINETE</h3></center></div>
        <div><center>

             <asp:Label ID="Label8" runat="server" Text="modelo"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox9" runat="server" Width="185px"></asp:TextBox>
             <br />
             <asp:Label ID="Label9" runat="server" Text="tipoForma"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox10" runat="server" Width="164px"></asp:TextBox>
             <br />
             selecciona una marca<br />
             <asp:GridView ID="GridView8" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                 <AlternatingRowStyle BackColor="White" />
                 <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                 <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                 <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                 <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                 <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                 <SortedAscendingCellStyle BackColor="#FDF5AC" />
                 <SortedAscendingHeaderStyle BackColor="#4D0000" />
                 <SortedDescendingCellStyle BackColor="#FCF6C0" />
                 <SortedDescendingHeaderStyle BackColor="#820000" />
             </asp:GridView>
             <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:Button ID="Button7" runat="server" BackColor="#3333CC" Text="Insertar gabinete" Width="242px" OnClick="Button7_Click" />
             <br />
             <br />
&nbsp;&nbsp;&nbsp;
             <asp:TextBox ID="TextBox11" runat="server" Width="439px"></asp:TextBox>
             <br />

             </center></div>
          <div class="bg-light fst-italic"><center><h3>INSERTAR GABINETE</h3></center></div>
        <div><center><h3>MOSTRAR GABINETES</h3></center></div>
        <div><center>

             <asp:Button ID="Button8" runat="server" BackColor="#6666FF" Text="Mostrar Gabinetes" Width="206px" OnClick="Button8_Click1" />
             <br />
             <br />

             <asp:GridView ID="GridView4" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
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
             <br />
&nbsp;&nbsp;&nbsp;
             <asp:TextBox ID="TextBox12" runat="server" Width="443px"></asp:TextBox>

             </center></div>
            <div class="bg-light fst-italic"><center><h3>MODIFICAR GABINETE</h3></center></div>
        <div><center>

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
             <asp:Label ID="Label10" runat="server" Text="Escribe un nuevo modelo de gabinete"></asp:Label>
             <br />
             <br />
             <asp:TextBox ID="TextBox16" runat="server" Width="329px"></asp:TextBox>
             <br />
             <br />
             <asp:Button ID="Button9" runat="server" BackColor="#0099CC" BorderColor="#006699" OnClick="Button9_Click" Text="Modificar Gabinete" Width="194px" />
             <br />
             <br />
             <asp:TextBox ID="TextBox17" runat="server" Width="547px"></asp:TextBox>

             </center></div>
            <div class="bg-light fst-italic"><center><h3>ELIMINAR GABINETE</h3></center></div>
         <div><center>

              <asp:GridView ID="GridView10" runat="server" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" OnSelectedIndexChanged="GridView10_SelectedIndexChanged">
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
              <asp:Button ID="Button10" runat="server" BackColor="#CC0066" Text="Eliminar gabinete" Width="162px" />
              <br />
              <br />
              <asp:TextBox ID="TextBox18" runat="server" Width="654px"></asp:TextBox>
              <br />

              </center></div>
    </form>
</body>
</html>
