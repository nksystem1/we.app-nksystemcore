using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace we.app_nksystemcore.Models
{
    public class Almacenes
    {

        public int Id { get; set; }
        public int EmpresaId { get; set; }
        
        public string Nombre { get; set; }
       
        public string Principal { get; set; }
       
        public string Tipoalmacen { get; set; }
       
        public string Estado { get; set; }
       
        
    }
}
