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
    public partial class AccesoriosparaPC : System.Web.UI.Page
    {
        Logicadeentidadesinventario objBL = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                objBL = new Logicadeentidadesinventario(ConfigurationManager.ConnectionStrings["cn1"].ConnectionString);
                Session["BL"] = objBL;
                Marcas();
                Gabinetes();
            }
            else
            {
                objBL = (Logicadeentidadesinventario)Session["BL"];
                GridView5.DataSource = Session["marcas"];
                GridView5.DataBind();
                GridView6.DataSource = Session["marcas"];
                GridView6.DataBind();
                GridView7.DataSource = Session["marcas"];
                GridView7.DataBind();
                GridView8.DataSource = Session["marcas"];
                GridView8.DataBind();
                GridView9.DataSource = Session["gabinete"];
                GridView9.DataBind();
                GridView10.DataSource = Session["gabinete"];
                GridView10.DataBind();
            }

        }
        public void Marcas()
        {
            string m = "";
            Session["marcas"] = objBL.obtentodasMarcas(ref m);
            GridView5.DataSource = Session["marcas"];
            GridView5.DataBind();
            GridView6.DataSource = Session["marcas"];
            GridView6.DataBind();
            GridView7.DataSource = Session["marcas"];
            GridView7.DataBind();
            GridView8.DataSource = Session["marcas"];
            GridView8.DataBind();
        }
        public void Gabinetes()
        {
            string m = "";
            Session["gabinete"] = objBL.obtengabinete(ref m);
            GridView9.DataSource = Session["gabinete"];
            GridView9.DataBind();
            GridView10.DataSource = Session["gabinete"];
            GridView10.DataBind();
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string m = "";
            string md = "";
            if (GridView5.SelectedIndex >= 0)
            {
                objBL.Insertarteclado(Convert.ToInt16(GridView5.Rows[GridView5.SelectedIndex].Cells[1].Text), TextBox1.Text, ref m);
                md = objBL.MiMessageBox("CONSULTA CORRECTA", m, 2);
                TextBox2.Text = m;
                Page.ClientScript.RegisterStartupScript(this.GetType(), "etiqueta" + 1, "" + md + "", true);
            }
            else
            {
                TextBox2.Text = "Consulta Incorrecta";
                md = objBL.MiMessageBox("No se pudo Insertar correctamente", m, 3);
                TextBox2.Text = m;
                Page.ClientScript.RegisterStartupScript(this.GetType(), "etiqueta" + 1, "" + md + "", true);
            }
        }

        protected void GridView6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            string m = "";
            string md = "";
            GridView3.DataSource = objBL.obtenmonitor(ref m);
            GridView3.DataBind();
            TextBox1.Text = m;
            md = objBL.MiMessageBox("CONSULTA CORRECTA", m, 2);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "etiqueta" + 1, "" + md + "", true);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string m = "";
            string md = "";
            GridView1.DataSource = objBL.obtenteclado(ref m);
            GridView1.DataBind();
            TextBox3.Text = m;
            md = objBL.MiMessageBox("CONSULTA CORRECTA", m, 2);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "etiqueta" + 1, "" + md + "", true);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string m = "";
            string md = "";
            GridView2.DataSource = objBL.obtenmouse(ref m);
            GridView2.DataBind();
            TextBox14.Text = m;
            md = objBL.MiMessageBox("CONSULTA CORRECTA", m, 2);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "etiqueta" + 1, "" + md + "", true);
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            string m = "";
            string md = "";
            GridView4.DataSource = objBL.obtengabinete(ref m);
            GridView4.DataBind();
            TextBox1.Text = m;
            md = objBL.MiMessageBox("CONSULTA CORRECTA", m, 2);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "etiqueta" + 1, "" + md + "", true);
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            string m = "";
            string md = "";
            if (GridView7.SelectedIndex >= 0)
            {
                objBL.Insertarmonitor(Convert.ToInt16(GridView7.Rows[GridView7.SelectedIndex].Cells[1].Text), TextBox5.Text, TextBox6.Text, TextBox7.Text, TextBox8.Text, ref m);
                md = objBL.MiMessageBox("CONSULTA CORRECTA", m, 2);
                TextBox15.Text = m;
                Page.ClientScript.RegisterStartupScript(this.GetType(), "etiqueta" + 1, "" + md + "", true);
            }
            else
            {
                TextBox13.Text = "Consulta Incorrecta";
                md = objBL.MiMessageBox("No se pudo Insertar correctamente", m, 3);
                TextBox13.Text = m;
                Page.ClientScript.RegisterStartupScript(this.GetType(), "etiqueta" + 1, "" + md + "", true);
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string m = "";
            string md = "";
            if (GridView6.SelectedIndex >= 0)
            {
                objBL.Insertarmouse(Convert.ToInt16(GridView6.Rows[GridView6.SelectedIndex].Cells[1].Text), TextBox4.Text, ref m);
                md = objBL.MiMessageBox("CONSULTA CORRECTA", m, 2);
                TextBox14.Text = m;
                Page.ClientScript.RegisterStartupScript(this.GetType(), "etiqueta" + 1, "" + md + "", true);
            }
            else
            {
                TextBox14.Text = "Consulta Incorrecta";
                md = objBL.MiMessageBox("No se pudo Insertar correctamente", m, 3);
                TextBox15.Text = m;
                Page.ClientScript.RegisterStartupScript(this.GetType(), "etiqueta" + 1, "" + md + "", true);
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            string m = "";
            string md = "";
            if (GridView6.SelectedIndex >= 0)
            {
                objBL.Insertargabinete(TextBox9.Text, TextBox10.Text, Convert.ToInt16(GridView6.Rows[GridView6.SelectedIndex].Cells[1].Text), ref m);
                md = objBL.MiMessageBox("CONSULTA CORRECTA", m, 2);
                TextBox11.Text = m;
                Page.ClientScript.RegisterStartupScript(this.GetType(), "etiqueta" + 1, "" + md + "", true);
            }
            else
            {
                TextBox11.Text = "Consulta Incorrecta";
                md = objBL.MiMessageBox("No se pudo Insertar correctamente", m, 3);
                TextBox11.Text = m;
                Page.ClientScript.RegisterStartupScript(this.GetType(), "etiqueta" + 1, "" + md + "", true);
            }
        }

        protected void Button8_Click1(object sender, EventArgs e)
        {
            string m = "";
            string md = "";
            GridView4.DataSource = objBL.obtengabinete(ref m);
            GridView4.DataBind();
            TextBox12.Text = m;
            md = objBL.MiMessageBox("CONSULTA CORRECTA", m, 2);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "etiqueta" + 1, "" + md + "", true);
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            string z = "";
            string md = "";
            objBL.eliminarGabinete(Convert.ToInt16(GridView10.Rows[GridView10.SelectedIndex].Cells[1].Text), ref z);
            TextBox18.Text = z;
            md = objBL.MiMessageBox("CONSULTA CORRECTA", z, 2);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "etiqueta" + 1, "" + md + "", true);
        }

        protected void GridView10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            string z = "";
            string md = "";
            objBL.actualizarGabinete(TextBox16.Text, Convert.ToInt16(GridView9.Rows[GridView9.SelectedIndex].Cells[1].Text),  ref z);
            TextBox17.Text = z;
            md = objBL.MiMessageBox("CONSULTA CORRECTA", z, 2);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "etiqueta" + 1, "" + md + "", true);
        }
    }
}