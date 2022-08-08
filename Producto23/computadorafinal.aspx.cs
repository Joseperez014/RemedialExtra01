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
    public partial class comptadorafinal : System.Web.UI.Page
    {
        Logicadeentidadesinventario objBL = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                objBL = new Logicadeentidadesinventario(ConfigurationManager.ConnectionStrings["cn1"].ConnectionString);
                Session["BL"] = objBL;
                Cpugenerico();
                teclado();
                Mouse();
                Monitor();
                Laboratorio();
            }
            else
            {
                objBL = (Logicadeentidadesinventario)Session["BL"];
                GridView2.DataSource = Session["generico"];
                GridView2.DataBind();
                GridView3.DataSource = Session["teclado"];
                GridView3.DataBind();
                GridView5.DataSource = Session["mouse"];
                GridView5.DataBind();
                GridView4.DataSource = Session["monitor"];
                GridView4.DataBind();
                GridView6.DataSource = Session["laboratorio"];
                GridView6.DataBind();
            }
        }
        public void Cpugenerico()
        {
            string m = "";
            Session["generico"] = objBL.obtencpugenerico(ref m);
            GridView2.DataSource = Session["generico"];
            GridView2.DataBind();
            
        }
        public void teclado()
        {
            string m = "";
            Session["teclado"] = objBL.obtenteclado(ref m);
            GridView3.DataSource = Session["teclado"];
            GridView3.DataBind();
            
        }
        public void Mouse()
        {
            string m = "";
            Session["mouse"] = objBL.obtenmouse(ref m);
            GridView5.DataSource = Session["mouse"];
            GridView5.DataBind();
            
        }
        public void Monitor()
        {
            string m = "";
            Session["monitor"] = objBL.obtenmonitor(ref m);
            GridView4.DataSource = Session["monitor"];
            GridView4.DataBind();
            
        }
        public void Laboratorio()
        {
            string m = "";
            Session["laboratorio"] = objBL.obtenlaboratorio(ref m);
            GridView6.DataSource = Session["laboratorio"];
            GridView6.DataBind();

        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            string m = "";
            string md = "";
            GridView1.DataSource = objBL.obtencomputadorafinal(ref m);
            GridView1.DataBind();
            TextBox8.Text = m;
            md = objBL.MiMessageBox("CONSULTA CORRECTA", m, 2);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "etiqueta" + 1, "" + md + "", true);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string m = "";
            string md = "";
            if (GridView2.SelectedIndex >= 0)
            {
                if(GridView3.SelectedIndex >= 0)
                {
                    if (GridView4.SelectedIndex >= 0)
                    {
                        if (GridView5.SelectedIndex >= 0)
                        {
                            if (GridView6.SelectedIndex >= 0)
                            {
                                objBL.Insertarcomputadorafinal(TextBox1.Text, TextBox2.Text, Convert.ToInt16(GridView2.Rows[GridView2.SelectedIndex].Cells[1].Text), TextBox3.Text
                               , Convert.ToInt16(GridView3.Rows[GridView3.SelectedIndex].Cells[1].Text), TextBox4.Text, Convert.ToInt16(GridView4.Rows[GridView4.SelectedIndex].Cells[1].Text)
                               , TextBox5.Text, Convert.ToInt16(GridView5.Rows[GridView5.SelectedIndex].Cells[1].Text), TextBox6.Text, Convert.ToInt16(GridView6.Rows[GridView6.SelectedIndex].Cells[1].Text) ,ref m);
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
                        else
                        {
                            TextBox7.Text = "Consulta Incorrecta";
                            md = objBL.MiMessageBox("No se pudo Insertar correctamente", m, 3);
                            TextBox2.Text = m;
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
                else
                {
                    TextBox7.Text = "Consulta Incorrecta";
                    md = objBL.MiMessageBox("No se pudo Insertar correctamente", m, 3);
                    TextBox2.Text = m;
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
    }
}

