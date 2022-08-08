using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesInventario
{
    public class CPU_Generico
    {
        public int id_CPU { get; set; }
        public int f_Tipocpu { get; set; }
        public int f_Marca { get; set; }
        public string Modelo { get; set; }
        public string descripcion { get; set; }
        public int f_Ram { get; set; }
        public int f_Gabinete { get; set; }
        //public string Imagen   { get; set; }

    }
}
