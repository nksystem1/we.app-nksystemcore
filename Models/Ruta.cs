using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace we.app_nksystemcore.Models
{
	public class Ruta
	{
		[Required]
		[MaxLength(10)]
		public string codigo { get; set; }
		[Required]
		[MaxLength(65)]
		public string nombre { get; set; }
		[Required]
		public int codigozona { get; set; }
		[Required]
		public string desdeuno { get; set; }
		[Required]
		public string hastauno { get; set; }
		[Required]
		public string desdedos { get; set; }
		[Required]
		public string hastados { get; set; }		
		[Required]
		public string codigovendedor { get; set; }		
		public string codnegocio { get; set; }
		public Zona zona { get; set; }
		public Vendedor vendedor { get; set; }
	}
}
