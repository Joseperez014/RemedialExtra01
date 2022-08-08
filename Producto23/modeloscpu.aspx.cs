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
    public partial class modeloscpu : System.Web.UI.Page
    {
        Logicadeentidadesinventario objBL = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                objBL = new Logicadeentidadesinventario(ConfigurationManager.ConnectionStrings["cn1"].ConnectionString);
                Session["BL"] = objBL;
                modelo();
                tipocpu();
            }
            else
            {
                objBL = (Logicadeentidadesinventario)Session["BL"];
                GridView4.DataSource = Session["tipocpu"];
                GridView4.DataBind();
                GridView3.DataSource = Session["discoduro"];
                GridView3.DataBind();
            }
        }
        public void modelo()
        {
            string m = "";
            Session["modelo"] = objBL.obtenmodelocpu(ref m);
            GridView3.DataSource = Session["discoduro"];
            GridView3.DataBind();

        }
        public void tipocpu()
        {
            string m = "";
            Session["tipocpu"] = objBL.obtendiscoduro(ref m);
            GridView4.DataSource = Session["tipocpu"];
            GridView4.DataBind();

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string m = "";
            string md = "";
            if (GridView3.SelectedIndex >= 0)
            {
                objBL.Insertarmodelocpu (TextBox1.Text, Convert.ToInt16(GridView3.Rows[GridView3.SelectedIndex].Cells[1].Text), ref m);
                md = objBL.MiMessageBox("CONSULTA CORRECTA", m, 2);
                TextBox7.Text = m;
                Page.ClientScript.RegisterStartupScript(this.GetType(), "etiqueta" + 1, "" + md + "", true);
            }
            else
            {
                TextBox7.Text = "Consulta Incorrecta";
                md = objBL.MiMessageBox("No se pudo Insertar correctamente", m, 3);
                TextBox7.Text = m;
                Page.ClientScript.RegisterStartupScript(this.GetType(), "etiqueta" + 1, "" + md + "", true);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string m = "";
            string md = "";
            if (GridView4.SelectedIndex >= 0)
            {
                objBL.Insertartipocpu(TextBox2.Text,TextBox3.Text,TextBox4.Text, Convert.ToInt16(GridView4.Rows[GridView4.SelectedIndex].Cells[1].Text),TextBox5.Text, ref m);
                md = objBL.MiMessageBox("CONSULTA CORRECTA", m, 2);
                TextBox6.Text = m;
                Page.ClientScript.RegisterStartupScript(this.GetType(), "etiqueta" + 1, "" + md + "", true);
            }
            else
            {
                TextBox6.Text = "Consulta Incorrecta";
                md = objBL.MiMessageBox("No se pudo Insertar correctamente", m, 3);
                TextBox6.Text = m;
                Page.ClientScript.RegisterStartupScript(this.GetType(), "etiqueta" + 1, "" + md + "", true);
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string m = "";
            string md = "";
            GridView1.DataSource = objBL.obtenmodelocpu(ref m);
            GridView1.DataBind();
            TextBox7.Text = m;
            md = objBL.MiMessageBox("CONSULTA CORRECTA", m, 2);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "etiqueta" + 1, "" + md + "", true);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string m = "";
            string md = "";
            GridView2.DataSource = objBL.obtentipocpu(ref m);
            GridView2.DataBind();
            TextBox7.Text = m;
            md = objBL.MiMessageBox("CONSULTA CORRECTA", m, 2);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "etiqueta" + 1, "" + md + "", true);
        }
    }
}