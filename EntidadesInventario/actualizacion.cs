using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesInventario
{
    public class actualizacion
    {
        public int id_act { get; set; }
        public string num_serie { get; set; }
        public string descripcion { get; set; }
        public DateTime fecha { get; set; }
        public string num_inv { get; set; }
    }
}
