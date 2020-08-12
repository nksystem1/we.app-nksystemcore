using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace we.app_nksystemcore.Models
{
    public class Comision
    {
        public int id { get; set; }
        public double porcentajeinferior { get; set; }
        public double porcentajesuperior { get; set; }
        public double porcentajecomisionvendedor { get; set; }
        public string codvendedor { get; set; }
    }
}
