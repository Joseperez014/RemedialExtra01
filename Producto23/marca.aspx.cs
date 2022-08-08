using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using LogicaNegociosInventario;

namespace Producto23
{
    public partial class marca : System.Web.UI.Page
    {
        Logicadeentidadesinventario objBL = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                objBL = new Logicadeentidadesinventario(ConfigurationManager.ConnectionStrings["cn1"].ConnectionString);
                Session["BL"] = objBL; 
                Marcas();
            }
            else
            {
                objBL = (Logicadeentidadesinventario)Session["BL"];
                GridView2.DataSource = Session["marcas"];
                GridView2.DataBind();
                GridView3.DataSource = Session["marcas"];
                GridView3.DataBind();
            }
        }
        public void Marcas()
        {
            string m = "";
            Session["marcas"] = objBL.obtentodasMarcas(ref m);
            GridView2.DataSource = Session["marcas"];
            GridView2.DataBind();
            GridView3.DataSource = Session["marcas"];
            GridView3.DataBind();
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string z = "";
            string md = "";
            objBL.Insertarmarca(TextBox1.Text, TextBox2.Text, ref z);
            TextBox3.Text = z;
            md = objBL.MiMessageBox("CONSULTA CORRECTA", z, 2);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "etiqueta" + 1, "" + md + "", true);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string m = "";
            string md = "";
            GridView1.DataSource = objBL.obtenmodelocpu(ref m);
            GridView1.DataBind();
            TextBox3.Text = m;
            md = objBL.MiMessageBox("CONSULTA CORRECTA", m, 2);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "etiqueta" + 1, "" + md + "", true);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string z = "";
            string md = "";
            objBL.Insertarmarca(TextBox1.Text, TextBox2.Text, ref z);
            TextBox3.Text = z;
            md = objBL.MiMessageBox("CONSULTA CORRECTA", z, 2);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "etiqueta" + 1, "" + md + "", true);
        }
    }
}