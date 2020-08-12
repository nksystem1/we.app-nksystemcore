using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using we.app_nksystemcore.Models;

namespace web.appcore_nksystem.Models
{
    public class Cliente
    {
        public string codcliente { get; set; }
        public string codgrupo { get; set; }
        public string codvendedor { get; set; }
        public string cedula { get; set; }
        public string rif { get; set; }
        public string telefonofijo1 { get; set; }
        public string telefonofijo2 { get; set; }
        public string telefonomovil { get; set; }
        public string telefonofax { get; set; }
        public string direccionfiscal { get; set; }
        public string correoe { get; set; }
        public string paginaweb { get; set; }
        public string tipopersona { get; set; }
        public int plazocredito { get; set; }
        public Double montocredito { get; set; }
        public string tipocredito { get; set; }
        public string unidadplazocredito { get; set; }
        public string status { get; set; }
        public string nombre { get; set; }
        public string regimeniva { get; set; }
        public string razonsocial { get; set; }
        public DateTime fecharegistro { get; set; }
        public string tarifa { get; set; }
        public string codnegocio { get; set; }
        public string contribuyente { get; set; }
        public String codigoruta { get; set; }
        public Vendedor vendedor { get; set; }
        public Negocio negocio { get; set; }
        public Ruta ruta { get; set; }
        public Grupocliente grupocliente { get; set; }
    }
}