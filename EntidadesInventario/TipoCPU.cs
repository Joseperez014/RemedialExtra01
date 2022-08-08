using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesInventario
{
    public class TipoCPU
    {
        public int id_TCPU{ get; set; }
        public string Tipo { get; set; }
        public string Familia { get; set; }
        public string Velocidad { get; set; }
        public int f_modelo { get; set; }
        public string Extra { get; set; }

    }
}
