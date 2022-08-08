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
    public partial class tiposcpu : System.Web.UI.Page
    {
        Logicadeentidadesinventario objBL = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                objBL = new Logicadeentidadesinventario(ConfigurationManager.ConnectionStrings["cn1"].ConnectionString);
                Session["BL"] = objBL;
                CPU();
                tipoCPU();
                Marcas();
                ram();
                Gabinetes();



            }
            else
            {
                objBL = (Logicadeentidadesinventario)Session["BL"];
                GridView6.DataSource = Session["cpu"];
                GridView6.DataBind();
                GridView7.DataSource = Session["cpu"];
                GridView7.DataBind();
                GridView1.DataSource = Session["tipo"];
                GridView1.DataBind();
                GridView3.DataSource = Session["marcas"];
                GridView3.DataBind();
                GridView5.DataSource = Session["gabinete"];
                GridView5.DataBind();
            }
        }
        public void CPU()
        {
            string m = "";
            Session["cpu"] = objBL.obtencpugenerico(ref m);
            GridView6.DataSource = Session["cpu"];
            GridView6.DataBind();
            GridView7.DataSource = Session["cpu"];
            GridView7.DataBind();

        }
        public void tipoCPU()
        {
            string m = "";
            Session["tipo"] = objBL.obtentipocpu(ref m);
            GridView1.DataSource = Session["tipo"];
            GridView1.DataBind();
            

        }
        public void Marcas()
        {
            string m = "";
            Session["marcas"] = objBL.obtentodasMarcas(ref m);
            GridView3.DataSource = Session["marcas"];
            GridView3.DataBind();

        }
        public void ram()
        {
            string m = "";
            Session["tiporam"] = objBL.obtenram(ref m);
            GridView4.DataSource = Session["tiporam"];
            GridView4.DataBind();

        }
        public void Gabinetes()
        {
            string m = "";
            Session["gabinete"] = objBL.obtengabinete(ref m);
            GridView5.DataSource = Session["gabinete"];
            GridView5.DataBind();
            

        }
        
        protected void Button4_Click(object sender, EventArgs e)
        {

        }

        protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string m = "";
            string md = "";
            GridView1.DataSource = objBL.obtencpugenerico(ref m);
            GridView1.DataBind();
            TextBox5.Text = m;
            md = objBL.MiMessageBox("CONSULTA CORRECTA", m, 2);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "etiqueta" + 1, "" + md + "", true);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string m = "";
            string md = "";
            if (GridView2.SelectedIndex >= 0)
            {
                if (GridView3.SelectedIndex >= 0)
                {
                    if (GridView4.SelectedIndex >= 0)
                    {
                        if (GridView5.SelectedIndex >= 0)
                        {
                            objBL.Insertarcpugenerico( Convert.ToInt16(GridView2.Rows[GridView2.SelectedIndex].Cells[1].Text),
                               Convert.ToInt16(GridView3.Rows[GridView3.SelectedIndex].Cells[1].Text), TextBox1.Text, TextBox2.Text, Convert.ToInt16(GridView4.Rows[GridView4.SelectedIndex].Cells[1].Text)
                              , Convert.ToInt16(GridView5.Rows[GridView5.SelectedIndex].Cells[1].Text), ref m);
                            md = objBL.MiMessageBox("CONSULTA CORRECTA", m, 2);
                            TextBox3.Text = m;
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "etiqueta" + 1, "" + md + "", true);


                        }
                        else
                        {
                            TextBox3.Text = "Consulta Incorrecta";
                            md = objBL.MiMessageBox("No se pudo Insertar correctamente", m, 3);
                            TextBox2.Text = m;
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "etiqueta" + 1, "" + md + "", true);
                        }
                    }
                    else
                    {
                        TextBox3.Text = "Consulta Incorrecta";
                        md = objBL.MiMessageBox("No se pudo Insertar correctamente", m, 3);
                        TextBox2.Text = m;
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "etiqueta" + 1, "" + md + "", true);
                    }
                }
                else
                {
                    TextBox3.Text = "Consulta Incorrecta";
                    md = objBL.MiMessageBox("No se pudo Insertar correctamente", m, 3);
                    TextBox2.Text = m;
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "etiqueta" + 1, "" + md + "", true);
                }


            }
            else
            {
                TextBox3.Text = "Consulta Incorrecta";
                md = objBL.MiMessageBox("No se pudo Insertar correctamente", m, 3);
                TextBox2.Text = m;
                Page.ClientScript.RegisterStartupScript(this.GetType(), "etiqueta" + 1, "" + md + "", true);
            }
        }

        protected void GridView6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string z = "";
            string md = "";
            objBL.ActualizarCPUgenerico(TextBox4.Text, Convert.ToInt16(GridView6.Rows[GridView6.SelectedIndex].Cells[1].Text),  ref z);
            TextBox6.Text = z;
            md = objBL.MiMessageBox("CONSULTA CORRECTA", z, 2);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "etiqueta" + 1, "" + md + "", true);
        }

        protected void Button4_Click1(object sender, EventArgs e)
        {
            string z = "";
            string md = "";
            objBL.eliminarCPUgenerico(Convert.ToInt16(GridView7.Rows[GridView7.SelectedIndex].Cells[1].Text), ref z);
            TextBox7.Text = z;
            md = objBL.MiMessageBox("CONSULTA CORRECTA", z, 2);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "etiqueta" + 1, "" + md + "", true);
        }
    }
}