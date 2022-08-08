using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using AccesoDatosInventario;
using EntidadesInventario;
namespace LogicaNegociosInventario
{
    public class Logicadeentidadesinventario
    {

        private AccesoSQL operacion = null;
        public Logicadeentidadesinventario(string cadconexion)
        {
            operacion = new AccesoSQL(cadconexion);
        }
        public string MiMessageBox(string titulo, string msg, short tip)
        {
            string icono = "";
            switch (tip)
            {
                case 1:
                    icono = "'info'";
                    break;
                case 2:
                    icono = "'success'";
                    break;
                case 3:
                    icono = "'error'";
                    break;
                case 4:
                    icono = "'question'";
                    break;
            }
            string functionjs = "Mensaje('" + titulo + "','" + msg + "'," + icono + ");";
            return functionjs;
        }

        //INSERCIONES DE LA BASE DE DATOS
        public Boolean Insertaractualizacion(string numero_serie, string descripcion, DateTime fecha, string num_inv, ref string m)
        {
            string sentencia = "insert into actualizacion(num_serie,descripcion,fecha,num_inv) " +
                "values (@num_serie,@descripcion,@fecha,@num_inv);";
            SqlParameter[] coleccion = new SqlParameter[]
            {

                new SqlParameter("id_act",SqlDbType.Int),
                new SqlParameter("num_serie",SqlDbType.VarChar,11),
                new SqlParameter("descripcion",SqlDbType.VarChar,64),
                new SqlParameter("fecha",SqlDbType.Date),
                new SqlParameter("num_inv",SqlDbType.VarChar,10)

            };
            coleccion[0].Value = numero_serie;
            coleccion[1].Value = descripcion;
            coleccion[2].Value = fecha;
            coleccion[3].Value = num_inv;

            Boolean salida = false;
            operacion.ModificarBDMasseguro(sentencia, operacion.Abrirconexion(ref m), ref m, coleccion);
            return salida;
        }

        public Boolean Insertarcantdisco(int cantidaddiscos, string f_num_inv, int f_Disco, ref string m)
        {
            string sentencia = "insert into cantDisc (cantidaddiscos,f_num_inv,f_Disco) values(@cantidaddiscos,@f_num_inv,@f_Disco);";
            SqlParameter[] coleccion = new SqlParameter[]
            {


                new SqlParameter("cantidaddiscos",SqlDbType.Int),
                new SqlParameter("f_num_inv",SqlDbType.VarChar,10),
                new SqlParameter("f_Disco",SqlDbType.Int)
            };
            coleccion[0].Value = cantidaddiscos;
            coleccion[1].Value = f_num_inv;
            coleccion[2].Value = f_Disco;

            Boolean salida = false;
            operacion.ModificarBDMasseguro(sentencia, operacion.Abrirconexion(ref m), ref m, coleccion);
            return salida;
        }
        public Boolean Insertarcomponente(string NombreComponente, string Modelo, ref string m)
        {
            string sentencia = "insert into Componente(NombreComponente,Modelo) values(@nombrecomponente,@modelo);";
            SqlParameter[] coleccion = new SqlParameter[]
            {


                new SqlParameter("NombreComponente",SqlDbType.VarChar,25),
                 new SqlParameter("Modelo",SqlDbType.VarChar,25)

            };
            coleccion[0].Value = NombreComponente;
            coleccion[1].Value = Modelo;

            Boolean salida = false;
            operacion.ModificarBDMasseguro(sentencia, operacion.Abrirconexion(ref m), ref m, coleccion);
            return salida;
        }


        public Boolean Insertarcomputadorafinal(string num_inv, string num_cpu, int f_cpug, string num_teclado, int f_tecladog
            , string num_monitor, int f_monitorg, string num_mouse, int f_mouse, string estado, int f_numlaboratorio,
            ref string m)
        {
            string sentencia = "insert into computadorafinal(num_inv,num_cpu,f_cpug,num_teclado,f_tecladog,num_monitor,f_monitorg,num_mouse,f_mouse,estado,f_num_laboratorio) " +
                "values(@num_inv, @num_cpu, @f_cpug, @num_teclado, @f_tecladog, @num_monitor, @f_monitorg, @num_mouse, @f_mouse, @estado, @f_num_laboratorio)";
            SqlParameter[] coleccion = new SqlParameter[]
            {

                new SqlParameter("num_inv",SqlDbType.VarChar,10),
                new SqlParameter("num_cpu",SqlDbType.VarChar,11),
                new SqlParameter("f_cpug",SqlDbType.Int),
                new SqlParameter("num_teclado",SqlDbType.VarChar,11),
                new SqlParameter("f_tecladog",SqlDbType.Int),
                new SqlParameter("num_monitor",SqlDbType.VarChar,11),
                new SqlParameter("f_monitorg",SqlDbType.Int),
                new SqlParameter("num_mouse",SqlDbType.VarChar,11),
                new SqlParameter("f_mouse",SqlDbType.Int),
                new SqlParameter("estado",SqlDbType.VarChar,15),
                new SqlParameter("f_num_laboratorio",SqlDbType.Int)

            };
            coleccion[0].Value = num_inv;
            coleccion[1].Value = num_cpu;
            coleccion[2].Value = f_cpug;
            coleccion[3].Value = num_teclado;
            coleccion[4].Value = f_tecladog;
            coleccion[5].Value = num_monitor;
            coleccion[6].Value = f_monitorg;
            coleccion[7].Value = num_mouse;
            coleccion[8].Value = f_mouse;
            coleccion[9].Value = estado;
            coleccion[10].Value = f_numlaboratorio;
            Boolean salida = false;
            operacion.ModificarBDMasseguro(sentencia, operacion.Abrirconexion(ref m), ref m, coleccion);
            return salida;
        }

        public Boolean Insertarcpugenerico(int f_Tipocpu, int f_Marca, string Modelo, string descripcion, int f_Ram, int f_Gabinete, ref string m)
        {
            string sentencia = "insert into CPU_Generico (f_Tipocpu,f_Marca,Modelo,descripcion,f_Ram,f_Gabinete) " +
                "values (@f_Tipocpu,@f_Marca,@Modelo,@descripcion,@f_Ram,@f_Gabinete);";
            SqlParameter[] coleccion = new SqlParameter[]
            {


                new SqlParameter("f_Tipocpu",SqlDbType.Int),
                new SqlParameter("f_Marca",SqlDbType.Int),
                new SqlParameter("Modelo",SqlDbType.VarChar,20),
                new SqlParameter("descripcion",SqlDbType.VarChar,40),
                new SqlParameter("f_Ram",SqlDbType.Int),
                new SqlParameter("f_Gabinete",SqlDbType.Int)


            };
            coleccion[0].Value = f_Tipocpu;
            coleccion[1].Value = f_Marca;
            coleccion[2].Value = Modelo;
            coleccion[3].Value = descripcion;
            coleccion[4].Value = f_Ram;
            coleccion[5].Value = f_Gabinete;

            Boolean salida = false;
            operacion.ModificarBDMasseguro(sentencia, operacion.Abrirconexion(ref m), ref m, coleccion);
            return salida;
        }

        public Boolean Insertardiscoduro(string TipoDisco, string conector, string capacidad,
            int f_Marca, string Extra, string f_num_inv, ref string m)
        {
            string sentencia = "insert into DiscoDuro(TipoDisco,conector,capacidad,f_Marca,Extra,f_num_inv) " +
                "values( @TipoDisco, @conector, @capacidad, @f_Marca, @Extra, @f_num_inv); ";
            SqlParameter[] coleccion = new SqlParameter[]
            {


                new SqlParameter("TipoDisco",SqlDbType.VarChar,20),
                new SqlParameter("conector",SqlDbType.VarChar,20),
                new SqlParameter("capacidad",SqlDbType.VarChar,20),
                new SqlParameter("f_Marca",SqlDbType.Int),
                new SqlParameter("Extra",SqlDbType.VarChar,30),
                new SqlParameter("f_num_inv",SqlDbType.VarChar,10)

            };
            coleccion[0].Value = TipoDisco;
            coleccion[1].Value = conector;
            coleccion[2].Value = capacidad;
            coleccion[3].Value = f_Marca;
            coleccion[4].Value = Extra;
            coleccion[5].Value = f_num_inv;

            Boolean salida = false;
            operacion.ModificarBDMasseguro(sentencia, operacion.Abrirconexion(ref m), ref m, coleccion);
            return salida;
        }

        public Boolean Insertargabinete(string Modelo, string TipoForma, int f_Marca, ref string m)
        {
            string sentencia = "insert into Gabinete(Modelo,TipoForma,f_Marca) " +
                "values (@Modelo,@TipoForma,@f_Marca);";
            SqlParameter[] coleccion = new SqlParameter[]
            {


                new SqlParameter("Modelo",SqlDbType.VarChar,10),
                new SqlParameter("TipoForma",SqlDbType.VarChar,30),
                new SqlParameter("f_Marca",SqlDbType.Int)

            };
            coleccion[0].Value = Modelo;
            coleccion[1].Value = TipoForma;
            coleccion[2].Value = f_Marca;

            Boolean salida = false;
            operacion.ModificarBDMasseguro(sentencia, operacion.Abrirconexion(ref m), ref m, coleccion);
            return salida;
        }

        public Boolean Insertarlaboratorio(string nombre_laboratorio, string ubicacion, ref string m)
        {
            string sentencia = "insert into laboratorio(nombre_laboratorio,ubicacion) values (@nombre_laboratorio,@ubicacion);";
            SqlParameter[] coleccion = new SqlParameter[]
            {


                new SqlParameter("nombre_laboratorio",SqlDbType.VarChar,64),
                new SqlParameter("ubicacion",SqlDbType.VarChar,64)

            };
            coleccion[0].Value = nombre_laboratorio;
            coleccion[1].Value = ubicacion;

            Boolean salida = false;
            operacion.ModificarBDMasseguro(sentencia, operacion.Abrirconexion(ref m), ref m, coleccion);
            return salida;
        }

        public Boolean Insertarmarca(string Marca, string Extra, ref string m)
        {
            string sentencia = "insert into Marca(Marca,Extra) values (@Marca,@Extra);";
            SqlParameter[] coleccion = new SqlParameter[]
            {


                new SqlParameter("Marca",SqlDbType.VarChar,50),
                new SqlParameter("Extra",SqlDbType.VarChar,50)

            };
            coleccion[0].Value = Marca;
            coleccion[1].Value = Extra;

            Boolean salida = false;
            operacion.ModificarBDMasseguro(sentencia, operacion.Abrirconexion(ref m), ref m, coleccion);
            return salida;
        }
        public Boolean Insertarmarcacomponente(int f_Componente, int f_Marca, ref string m)
        {
            string sentencia = "insert into Marca_Componente(f_Componente,f_Marca) values(@f_Componente,@f_Marca); ";
            SqlParameter[] coleccion = new SqlParameter[]
            {

                new SqlParameter("f_Componente",SqlDbType.Int),
                new SqlParameter("f_Marca",SqlDbType.Int)

            };
            coleccion[0].Value = f_Componente;
            coleccion[1].Value = f_Marca;
            Boolean salida = false;
            operacion.ModificarBDMasseguro(sentencia, operacion.Abrirconexion(ref m), ref m, coleccion);
            return salida;
        }

        public Boolean Insertarmodelocpu(string modelocpu, int f_marca, ref string m)
        {
            string sentencia = "insert into ModeloCPU(modelocpu,f_marca)values(@modelocpu,@f_marca); ";
            SqlParameter[] coleccion = new SqlParameter[]
            {


                new SqlParameter("modelocpu",SqlDbType.VarChar,250),
                new SqlParameter("f_marca",SqlDbType.Int)

            };
            coleccion[0].Value = modelocpu;
            coleccion[1].Value = f_marca;

            Boolean salida = false;
            operacion.ModificarBDMasseguro(sentencia, operacion.Abrirconexion(ref m), ref m, coleccion);
            return salida;
        }

        public Boolean Insertarmonitor(int f_Marca, string conectores,
            string dimensiones, string tamano, string tipomonitor, ref string m)
        {
            string sentencia = "insert into Monitor(f_Marca,conectores,dimensiones,tamano,tipomonitor) " +
                "values(,@f_Marca,@conectores,@dimensiones,@taman,@tipomonitor); ";
            SqlParameter[] coleccion = new SqlParameter[]
            {


                new SqlParameter("f_Marca",SqlDbType.Int),
                new SqlParameter("conectores",SqlDbType.VarChar,64),
                new SqlParameter("dimensiones",SqlDbType.VarChar,64),
                new SqlParameter("tamano",SqlDbType.VarChar,64),
                new SqlParameter("tipomonitor",SqlDbType.VarChar,64),

            };
            coleccion[0].Value = f_Marca;
            coleccion[1].Value = conectores;
            coleccion[2].Value = dimensiones;
            coleccion[3].Value = tamano;
            coleccion[4].Value = tipomonitor;

            Boolean salida = false;
            operacion.ModificarBDMasseguro(sentencia, operacion.Abrirconexion(ref m), ref m, coleccion);
            return salida;
        }
        public Boolean Insertarmouse(int f_Marcamouse, string conector, ref string m)
        {
            string sentencia = "insert into mouse(f_Marcamouse,conector) values (@f_Marcamouse,@conector); ";
            SqlParameter[] coleccion = new SqlParameter[]
            {


                new SqlParameter("f_Marcamouse",SqlDbType.Int),
                new SqlParameter("conector",SqlDbType.VarChar,70)

            };
            coleccion[0].Value = f_Marcamouse;
            coleccion[1].Value = conector;

            Boolean salida = false;
            operacion.ModificarBDMasseguro(sentencia, operacion.Abrirconexion(ref m), ref m, coleccion);
            return salida;
        }
        public Boolean Insertarram(int Capacidad, string Velocidad, int F_TipoR, ref string m)
        {
            string sentencia = "insert into RAM (Capacidad,Velocidad,F_TipoR) values (@Capacidad,@Velocidad,@F_TipoR); ";
            SqlParameter[] coleccion = new SqlParameter[]
            {


                new SqlParameter("Capacidad",SqlDbType.SmallInt),
                new SqlParameter("Velocidad",SqlDbType.VarChar,15),
                new SqlParameter("F_TipoR",SqlDbType.Int)
            };
            coleccion[0].Value = Capacidad;
            coleccion[1].Value = Velocidad;
            coleccion[2].Value = F_TipoR;

            Boolean salida = false;
            operacion.ModificarBDMasseguro(sentencia, operacion.Abrirconexion(ref m), ref m, coleccion);
            return salida;
        }
        public Boolean Insertarteclado(int f_Marca, string conector, ref string m)
        {
            string sentencia = "insert into Teclado(f_Marca,conector) values (@f_Marca,@conector); ";
            SqlParameter[] coleccion = new SqlParameter[]
            {


                new SqlParameter("f_Marca",SqlDbType.Int),
                new SqlParameter("conector",SqlDbType.VarChar,10)

            };
            coleccion[0].Value = f_Marca;
            coleccion[1].Value = conector;

            Boolean salida = false;
            operacion.ModificarBDMasseguro(sentencia, operacion.Abrirconexion(ref m), ref m, coleccion);
            return salida;
        }

        public Boolean Insertartipocpu(string Tipo, string Familia, string Velocidad, int f_modelo, string Extra, ref string m)
        {
            string sentencia = "insert into Tipo_CPU(Tipo,Familia,Velocidad,f_modelo,Extra) values (@Tipo,@Familia,@Velocidad,@f_modelo,@Extra); ";
            SqlParameter[] coleccion = new SqlParameter[]
            {


                new SqlParameter("Tipo",SqlDbType.VarChar,40),
                new SqlParameter("Familia",SqlDbType.VarChar,30),
                new SqlParameter("Velocidad",SqlDbType.VarChar,50),
                new SqlParameter("f_modelo",SqlDbType.Int),
                new SqlParameter("Extra",SqlDbType.VarChar,30)

            };
            coleccion[0].Value = Tipo;
            coleccion[1].Value = Familia;
            coleccion[2].Value = Velocidad;
            coleccion[3].Value = f_modelo;
            coleccion[4].Value = Extra;
            Boolean salida = false;
            operacion.ModificarBDMasseguro(sentencia, operacion.Abrirconexion(ref m), ref m, coleccion);
            return salida;
        }
        public Boolean Insertartiporam( string Tipo, string Extra, ref string m)
        {
            string sentencia = "insert into TipoRAM(Tipo,Extra)values(@Tipo,@Extra); ";
            SqlParameter[] coleccion = new SqlParameter[]
            {


                new SqlParameter("Tipo",SqlDbType.VarChar,250),
                new SqlParameter("Extra",SqlDbType.VarChar,250)

            };
            coleccion[0].Value = Tipo;
            coleccion[1].Value = Extra;
        
            Boolean salida = false;
            operacion.ModificarBDMasseguro(sentencia, operacion.Abrirconexion(ref m), ref m, coleccion);
            return salida;
        }
        
        //SELECT DE LA BASE DE DATOS///////////////////////////////////////////////////////////////////////////////////////////////////////////// 
        public DataTable obtenactualizaciones(ref string mensaje)
        {
            string consulta = "select * from actualizacion;";
            DataSet obtener = null;
            DataTable salida = null;
            obtener = operacion.ConsultaDataSet(consulta, operacion.Abrirconexion(ref mensaje), ref mensaje);

            if (obtener != null)
            {
                salida = obtener.Tables[0];
            }
            return salida;
        }
        public DataTable obtencantdisco(ref string mensaje)
        {
            string consulta = "select * from cantDisc;";
            DataSet obtener = null;
            DataTable salida = null;
            obtener = operacion.ConsultaDataSet(consulta, operacion.Abrirconexion(ref mensaje), ref mensaje);

            if (obtener != null)
            {
                salida = obtener.Tables[0];
            }
            return salida;
        }
        public DataTable obtencomponente(ref string mensaje)
        {
            string consulta = "select * from Componente;";
            DataSet obtener = null;
            DataTable salida = null;
            obtener = operacion.ConsultaDataSet(consulta, operacion.Abrirconexion(ref mensaje), ref mensaje);

            if (obtener != null)
            {
                salida = obtener.Tables[0];
            }
            return salida;
        }
        public DataTable obtencomputadorafinal(ref string mensaje)
        {
            string consulta = "select * from computadorafinal;";
            DataSet obtener = null;
            DataTable salida = null;
            obtener = operacion.ConsultaDataSet(consulta, operacion.Abrirconexion(ref mensaje), ref mensaje);

            if (obtener != null)
            {
                salida = obtener.Tables[0];
            }
            return salida;
        }
        public DataTable obtencpugenerico(ref string mensaje)
        {
            string consulta = "select * from CPU_Generico;";
            DataSet obtener = null;
            DataTable salida = null;
            obtener = operacion.ConsultaDataSet(consulta, operacion.Abrirconexion(ref mensaje), ref mensaje);

            if (obtener != null)
            {
                salida = obtener.Tables[0];
            }
            return salida;
        }
        public DataTable obtendiscoduro(ref string mensaje)
        {
            string consulta = "select* from DiscoDuro;";
            DataSet obtener = null;
            DataTable salida = null;
            obtener = operacion.ConsultaDataSet(consulta, operacion.Abrirconexion(ref mensaje), ref mensaje);

            if (obtener != null)
            {
                salida = obtener.Tables[0];
            }
            return salida;
        }
        public DataTable obtengabinete(ref string mensaje)
        {
            string consulta = "select * from Gabinete;";
            DataSet obtener = null;
            DataTable salida = null;
            obtener = operacion.ConsultaDataSet(consulta, operacion.Abrirconexion(ref mensaje), ref mensaje);

            if (obtener != null)
            {
                salida = obtener.Tables[0];
            }
            return salida;
        }
        public DataTable obtenlaboratorio(ref string mensaje)
        {
            string consulta = "select * from laboratorio;";
            DataSet obtener = null;
            DataTable salida = null;
            obtener = operacion.ConsultaDataSet(consulta, operacion.Abrirconexion(ref mensaje), ref mensaje);

            if (obtener != null)
            {
                salida = obtener.Tables[0];
            }
            return salida;
        }

        public DataTable obtentodasMarcas(ref string mensaje)
        {
            string consulta = "select * from Marca;";
            DataSet obtener = null;
            DataTable salida = null;
            obtener = operacion.ConsultaDataSet(consulta, operacion.Abrirconexion(ref mensaje), ref mensaje);

            if (obtener != null)
            {
                salida = obtener.Tables[0];
            }
            return salida;
        }
        public DataTable obtenmarcacomponente(ref string mensaje)
        {
            string consulta = "select * from Marca_Componente;";
            DataSet obtener = null;
            DataTable salida = null;
            obtener = operacion.ConsultaDataSet(consulta, operacion.Abrirconexion(ref mensaje), ref mensaje);

            if (obtener != null)
            {
                salida = obtener.Tables[0];
            }
            return salida;
        }
        public DataTable obtenmodelocpu(ref string mensaje)
        {
            string consulta = "select * from ModeloCPU;";
            DataSet obtener = null;
            DataTable salida = null;
            obtener = operacion.ConsultaDataSet(consulta, operacion.Abrirconexion(ref mensaje), ref mensaje);

            if (obtener != null)
            {
                salida = obtener.Tables[0];
            }
            return salida;
        }
        public DataTable obtenmonitor(ref string mensaje)
        {
            string consulta = "select * from Monitor;";
            DataSet obtener = null;
            DataTable salida = null;
            obtener = operacion.ConsultaDataSet(consulta, operacion.Abrirconexion(ref mensaje), ref mensaje);

            if (obtener != null)
            {
                salida = obtener.Tables[0];
            }
            return salida;
        }
        public DataTable obtenmouse(ref string mensaje)
        {
            string consulta = "select * from mouse;";
            DataSet obtener = null;
            DataTable salida = null;
            obtener = operacion.ConsultaDataSet(consulta, operacion.Abrirconexion(ref mensaje), ref mensaje);

            if (obtener != null)
            {
                salida = obtener.Tables[0];
            }
            return salida;
        }
        public DataTable obtenram(ref string mensaje)
        {
            string consulta = "select * from RAM;";
            DataSet obtener = null;
            DataTable salida = null;
            obtener = operacion.ConsultaDataSet(consulta, operacion.Abrirconexion(ref mensaje), ref mensaje);

            if (obtener != null)
            {
                salida = obtener.Tables[0];
            }
            return salida;
        }
        public DataTable obtenteclado(ref string mensaje)
        {
            string consulta = "select * from Teclado;";
            DataSet obtener = null;
            DataTable salida = null;
            obtener = operacion.ConsultaDataSet(consulta, operacion.Abrirconexion(ref mensaje), ref mensaje);

            if (obtener != null)
            {
                salida = obtener.Tables[0];
            }
            return salida;
        }
        public DataTable obtentipocpu(ref string mensaje)
        {
            string consulta = "select * from Tipo_CPU;";
            DataSet obtener = null;
            DataTable salida = null;
            obtener = operacion.ConsultaDataSet(consulta, operacion.Abrirconexion(ref mensaje), ref mensaje);

            if (obtener != null)
            {
                salida = obtener.Tables[0];
            }
            return salida;
        }
        public DataTable obtentiporam(ref string mensaje)
        {
            string consulta = "select * from TipoRAM;";
            DataSet obtener = null;
            DataTable salida = null;
            obtener = operacion.ConsultaDataSet(consulta, operacion.Abrirconexion(ref mensaje), ref mensaje);

            if (obtener != null)
            {
                salida = obtener.Tables[0];
            }
            return salida;
        }
        
        public DataTable obtenusuarios(ref string mensaje)
        {
            string consulta = "select * from usuario;";
            DataSet obtener = null;
            DataTable salida = null;
            obtener = operacion.ConsultaDataSet(consulta, operacion.Abrirconexion(ref mensaje), ref mensaje);

            if (obtener != null)
            {
                salida = obtener.Tables[0];
            }
            return salida;
        }
        //UPDATE DE LA BASE DE DATOS
        public DataTable ActualizarMarca(string descripcion,int idmarca, ref string mensaje)
        {
            
            string consulta = "Update Marca Set Extra  = " + descripcion + "where  Id_Marca =" + idmarca;
            DataSet obtener = null;
            DataTable salida = null;
            obtener = operacion.ConsultaDataSet(consulta, operacion.Abrirconexion(ref mensaje), ref mensaje);

            if (obtener != null)
            {
                salida = obtener.Tables[0];
            }
            return salida;
        }
        public DataTable ActualizarCPUgenerico(string num_inv, string estado,  ref string mensaje)
        {
            string consulta = "Update computadorafinal Set estado = " + estado + "where num_inv ="+ num_inv ;
            DataSet obtener = null;
            DataTable salida = null;
            obtener = operacion.ConsultaDataSet(consulta, operacion.Abrirconexion(ref mensaje), ref mensaje);

            if (obtener != null)
            {
                salida = obtener.Tables[0];
            }
            return salida;
        }
        public DataTable Actualizarcomputadorafinal(string descripcion,int cpu, ref string mensaje)
        {
            string consulta = "Update CPU_Generico Set descripcion = "+descripcion + "where id_CPU =" + cpu;
            DataSet obtener = null;
            DataTable salida = null;
            obtener = operacion.ConsultaDataSet(consulta, operacion.Abrirconexion(ref mensaje), ref mensaje);

            if (obtener != null)
            {
                salida = obtener.Tables[0];
            }
            return salida;
        }
        public DataTable UbicacionGabinete(string modelo,int gabinete, ref string mensaje)
        {
            string consulta = "Update Gabinete Set Modelo = " + modelo + "where Id_Gabinete =" + gabinete;
            DataSet obtener = null;
            DataTable salida = null;
            obtener = operacion.ConsultaDataSet(consulta, operacion.Abrirconexion(ref mensaje), ref mensaje);

            if (obtener != null)
            {
                salida = obtener.Tables[0];
            }
            return salida;
        }
        //DELETE DE LA BASE DE DATOS
        public DataTable eliminarMarca(int idmarca, ref string mensaje)
        {

            string consulta = "delete from Marca where Id_Marca ="+idmarca;
            DataSet obtener = null;
            DataTable salida = null;
            obtener = operacion.ConsultaDataSet(consulta, operacion.Abrirconexion(ref mensaje), ref mensaje);

            if (obtener != null)
            {
                salida = obtener.Tables[0];
            }
            return salida;
        }
        public DataTable eliminarCPUgenerico(string cpu, ref string mensaje)
        {
            string consulta = "delete from CPU_Generico where id_CPU=" + cpu;
            DataSet obtener = null;
            DataTable salida = null;
            obtener = operacion.ConsultaDataSet(consulta, operacion.Abrirconexion(ref mensaje), ref mensaje);

            if (obtener != null)
            {
                salida = obtener.Tables[0];
            }
            return salida;
        }
        public DataTable eliminarcomputadorafinal( int pcfinal, ref string mensaje)
        {
            string consulta = "delete from computadorafinal where num_inv=" + pcfinal;
            DataSet obtener = null;
            DataTable salida = null;
            obtener = operacion.ConsultaDataSet(consulta, operacion.Abrirconexion(ref mensaje), ref mensaje);

            if (obtener != null)
            {
                salida = obtener.Tables[0];
            }
            return salida;
        }
        public DataTable eliminarGabinete( int gabinete, ref string mensaje)
        {
            string consulta = "delete from Gabinete where Id_Gabinete =" + gabinete;
            DataSet obtener = null;
            DataTable salida = null;
            obtener = operacion.ConsultaDataSet(consulta, operacion.Abrirconexion(ref mensaje), ref mensaje);

            if (obtener != null)
            {
                salida = obtener.Tables[0];
            }
            return salida;
        }
        //CONSULTAS ESPECIFICAS
        public DataTable UbicacionDetalles(string NumSerie, ref string mensaje)
        {
            string consulta = "execute equlab5 " + NumSerie ;
            DataSet obtener = null;
            DataTable salida = null;
            obtener = operacion.ConsultaDataSet(consulta, operacion.Abrirconexion(ref mensaje), ref mensaje);

            if (obtener != null)
            {
                salida = obtener.Tables[0];
            }
            return salida;
        }
    }
    
    



}
