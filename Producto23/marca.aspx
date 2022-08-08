<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="marca.aspx.cs" Inherits="Producto23.marca" %>

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
                    <li class="nav-item">
                  <a class="nav-link" href="laboratorio.aspx">LABORATORIO</a>
                 </li>

          </ul>
        </div>
      </nav>
   </div>
        
            <div class="bg-info font-italic">
            <center><h3>INSERTAR MARCA</h3> </center>
        </div>
        <div> <center>
             <p>Nombre de la Marca:
                    <asp:TextBox ID="TextBox1" runat="server" Width="197px"></asp:TextBox>
                </p>
                <p>Extra o descripcion:
                    <asp:TextBox ID="TextBox2" runat="server" Width="292px"></asp:TextBox>
                </p>
                <p>
                    <asp:Button ID="Button1" runat="server" BackColor="Aqua" ForeColor="Black" Text="Insertar Marca" Width="164px" OnClick="Button1_Click" />
                </p>
             <p>
                    <asp:TextBox ID="TextBox3" runat="server" Width="465px"></asp:TextBox>
                </p>
             </center>
        </div>
        <div class="bg-info font-italic">
            <center><h3>MOSTRAR MARCAS</h3></center>
        </div>
        <div>
             <center>

                 <asp:Button ID="Button2" runat="server" BackColor="#0066CC" Text="Mostrar Marcas" OnClick="Button2_Click" />
                 <br />
                 <br />

                 <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="414px">
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

             </center>
        </div>
        <div class="bg-info font-italic">
            <center><h3>MODIFICAR MARCA</h3></center>
        </div>
        <div>
             <center>

                 <asp:GridView ID="GridView2" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
                     <Columns>
                         <asp:CommandField ShowSelectButton="True"></asp:CommandField>
                     </Columns>
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
                 <asp:Label ID="Label1" runat="server" Text="Escribe un nuevo extra de la marca seleccionada"></asp:Label>
                 <br />
                 <br />
                 <asp:Label ID="Label2" runat="server" Text="Extra"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox4" runat="server" Width="273px"></asp:TextBox>
                 <br />
                 <br />
                 <asp:Button ID="Button3" runat="server" BackColor="#66FFFF" Text="Modificar Marca" Width="214px" OnClick="Button3_Click1" />
                 <br />
                 <br />
                 <br />
                 <asp:TextBox ID="TextBox5" runat="server" Width="753px"></asp:TextBox>
                 <br />

             </center>
        </div>
        <div class="bg-info font-italic">
            <center><h3>ELIMINAR MARCA</h3>
            </center>
        </div>
        <div>
             <center>

                 <asp:GridView ID="GridView3" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
                     <Columns>
                         <asp:CommandField ShowSelectButton="True"></asp:CommandField>
                     </Columns>
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
                 <asp:Button ID="Button4" runat="server" BackColor="#9999FF" OnClick="Button4_Click" Text="Eliminar Marca" Width="289px" />
                 <br />
                 <br />
                 <asp:TextBox ID="TextBox6" runat="server" Width="706px"></asp:TextBox>

             </center>
        </div>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
