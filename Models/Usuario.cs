using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace we.app_nksystemcore.Models
{
    public class Usuario
    {
		[MaxLength(14)]
		public string login { get; set; }
		[MaxLength(20)]
		public string contrasena { get; set; }
		[MaxLength(255)]
		public string nombrecompleto { get; set; }
		[MaxLength(255)]
		public string descripcion { get; set; }

		public bool desistema { get; set; }

		public String foto { get; set; }

		public bool concorreo { get; set; }
		[MaxLength(255)]
		public string direccioncorreo { get; set; }
		[MaxLength(6)]
	    public string rolid { get; set; }

		public string estado { get; set; }

		public DateTime creadoel { get; set; }
	}
}
