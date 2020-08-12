using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace we.app_nksystemcore.Models
{
	[Serializable]
    public class Vendedor
    {
		public Vendedor()
		{
			lstComisiones = new List<Comision>();
		}
		[Required]
		[MaxLength(12)]
		public string codigo { get; set; }
		[Required]
		[MaxLength(120)]
		public string nombre { get; set; }
		public double porcfclimp { get; set; }
		public double porclclimp { get; set; }
		public double porcfclexp { get; set; }
		public string interno { get; set; }
		public string cobrador { get; set; }
		[Required]
		[MaxLength(120)]
		public string direccionfiscal { get; set; }
		[Required]
		[MaxLength(50)]
		public string correoe { get; set; }
		public string codnegocio { get; set; }
		public int codzona { get; set; }
		public string codusuario { get; set; }
		public List<Comision> lstComisiones { get; set; }
		[DataType(DataType.Currency), DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = true)]
		[MaxLength(12)]
		public double montometa { get; set; } = 0;
	}
}
