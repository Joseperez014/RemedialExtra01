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
    public partial class DiscoduroRam : System.Web.UI.Page
    {

        Logicadeentidadesinventario objBL = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                objBL = new Logicadeentidadesinventario(ConfigurationManager.ConnectionStrings["cn1"].ConnectionString);
                Session["BL"] = objBL;
                Marca();
                pcfinal();
                discoduro();
                tiporam();
            }
            else
            {
                objBL = (Logicadeentidadesinventario)Session["BL"];
                GridView5.DataSource = Session["marca"];
                GridView5.DataBind();
                GridView6.DataSource = Session["pcfinal"];
                GridView6.DataBind();
                GridView7.DataSource = Session["pcfinal"];
                GridView7.DataBind();
                GridView8.DataSource = Session["discoduro"];
                GridView8.DataBind();
                GridView9.DataSource = Session["tiporam"];
                GridView9.DataBind();
            }
        }

        public void Marca()
        {
            string m = "";
            Session["marca"] = objBL.obtentodasMarcas(ref m);
            GridView5.DataSource = Session["marca"];
            GridView5.DataBind();

        }
        public void pcfinal()
        {
            string m = "";
            Session["pcfinal"] = objBL.obtencomputadorafinal(ref m);
            GridView6.DataSource = Session["pcfinal"];
            GridView6.DataBind();
            GridView7.DataSource = Session["pcfinal"];
            GridView7.DataBind();

        }
        public void discoduro()
        {
            string m = "";
            Session["discoduro"] = objBL.obtendiscoduro(ref m);
            GridView8.DataSource = Session["discoduro"];
            GridView8.DataBind();

        }
        public void tiporam()
        {
            string m = "";
            Session["tiporam"] = objBL.obtentiporam(ref m);
            GridView9.DataSource = Session["tiporam"];
            GridView9.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string m = "";
            string md = "";
            if (GridView5.SelectedIndex >= 0)
            {
                if (GridView6.SelectedIndex >= 0)
                {
                    objBL.Insertardiscoduro(TextBox1.Text, TextBox2.Text, TextBox3.Text, Convert.ToInt16(GridView5.Rows[GridView5.SelectedIndex].Cells[1].Text), TextBox4.Text, TextBox12.Text, ref m);
                    md = objBL.MiMessageBox("CONSULTA CORRECTA", m, 2);
                    TextBox9.Text = m;
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "etiqueta" + 1, "" + md + "", true);
                }
                else
                {
                    TextBox9.Text = "Consulta Incorrecta";
                    md = objBL.MiMessageBox("No se pudo Insertar correctamente", m, 3);
                    TextBox9.Text = m;
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "etiqueta" + 1, "" + md + "", true);
                }


            }
            else
            {
                TextBox7.Text = "Consulta Incorrecta";
                md = objBL.MiMessageBox("No se pudo Insertar correctamente", m, 3);
                TextBox2.Text = m;
                Page.ClientScript.RegisterStartupScript(this.GetType(), "etiqueta" + 1, "" + md + "", true);
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            string m = "";
            string md = "";
            GridView2.DataSource = objBL.obtendiscoduro(ref m);
            GridView2.DataBind();
            TextBox8.Text = m;
            md = objBL.MiMessageBox("CONSULTA CORRECTA", m, 2);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "etiqueta" + 1, "" + md + "", true);
        }

        protected void GridView7_SelectedIndexChanged(object sender, EventArgs e)
        {
            string m = "";
            string md = "";
            GridView2.DataSource = objBL.obtencantdisco(ref m);
            GridView2.DataBind();
            TextBox8.Text = m;
            md = objBL.MiMessageBox("CONSULTA CORRECTA", m, 2);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "etiqueta" + 1, "" + md + "", true);
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            string m = "";
            string md = "";
            GridView1.DataSource = objBL.obtencantdisco(ref m);
            GridView1.DataBind();
            TextBox8.Text = m;
            md = objBL.MiMessageBox("CONSULTA CORRECTA", m, 2);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "etiqueta" + 1, "" + md + "", true);
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            string m = "";
            string md = "";
            GridView3.DataSource = objBL.obtentiporam(ref m);
            GridView3.DataBind();
            TextBox8.Text = m;
            md = objBL.MiMessageBox("CONSULTA CORRECTA", m, 2);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "etiqueta" + 1, "" + md + "", true);
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            string m = "";
            string md = "";
            GridView4.DataSource = objBL.obtenram(ref m);
            GridView4.DataBind();
            TextBox8.Text = m;
            md = objBL.MiMessageBox("CONSULTA CORRECTA", m, 2);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "etiqueta" + 1, "" + md + "", true);
        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string m = "";
            string md = "";
            if (GridView8.SelectedIndex >= 0)
            {
                objBL.Insertarcantdisco(Convert.ToInt16(TextBox5.Text), TextBox14.Text, Convert.ToInt16(GridView8.Rows[GridView8.SelectedIndex].Cells[1].Text), ref m);
                md = objBL.MiMessageBox("CONSULTA CORRECTA", m, 2);
                TextBox8.Text = m;
                Page.ClientScript.RegisterStartupScript(this.GetType(), "etiqueta" + 1, "" + md + "", true);
            }
            else
            {
                TextBox8.Text = "Consulta Incorrecta";
                md = objBL.MiMessageBox("No se pudo Insertar correctamente", m, 3);
                TextBox8.Text = m;
                Page.ClientScript.RegisterStartupScript(this.GetType(), "etiqueta" + 1, "" + md + "", true);
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string m = "";
            string md = "";
            objBL.Insertartiporam (TextBox6.Text,TextBox7.Text, ref m);
            md = objBL.MiMessageBox("CONSULTA CORRECTA", m, 2);
            TextBox10.Text = m;
            Page.ClientScript.RegisterStartupScript(this.GetType(), "etiqueta" + 1, "" + md + "", true);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string m = "";
            string md = "";
            if (GridView9.SelectedIndex >= 0)
            {
                objBL.Insertarram(Convert.ToInt16(TextBox11.Text),TextBox13.Text, Convert.ToInt16(GridView9.Rows[GridView9.SelectedIndex].Cells[1].Text), ref m);
                md = objBL.MiMessageBox("CONSULTA CORRECTA", m, 2);
                TextBox8.Text = m;
                Page.ClientScript.RegisterStartupScript(this.GetType(), "etiqueta" + 1, "" + md + "", true);
            }
            else
            {
                TextBox8.Text = "Consulta Incorrecta";
                md = objBL.MiMessageBox("No se pudo Insertar correctamente", m, 3);
                TextBox8.Text = m;
                Page.ClientScript.RegisterStartupScript(this.GetType(), "etiqueta" + 1, "" + md + "", true);
            }
        }
    }
}