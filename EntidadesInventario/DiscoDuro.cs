using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesInventario
{
    public class DiscoDuro
    {
        public int id_Disco { get; set; }
        public string TipoDisco { get; set; }
        public string conector { get; set; }
        public string capacidad { get; set; }
        public int f_Marca { get; set; }
        public string Extra { get; set; }

        public string f_num_inv { get; set; }
    }
}
