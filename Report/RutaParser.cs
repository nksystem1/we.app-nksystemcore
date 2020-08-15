using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using we.app_nksystemcore.ConectionService;
using we.app_nksystemcore.ConectionService.Implementation;
using we.app_model.Data;

namespace we.app_nksystemcore.Report
{
    public static class RutaParser
    {
       

        public static string Parse(string path, Ruta RutaObj)
        {
           
            Ruta ruta = RutaObj;

            string content = File.ReadAllText(path)
                .Replace("{{customer}}", ruta.codigo)
                .Replace("{{address}}", ruta.codigovendedor)
                .Replace("{{email}}", ruta.desdedos)
                .Replace("{{numberInvoice}}", ruta.hastados)
                .Replace("{{date}}", ruta.nombre)
                .Replace("{{dueDate}}", ruta.vendedor.nombre);

            StringBuilder sb = new StringBuilder();

            /*foreach (var invoiceItem in invoice.InvoiceDetails)
            {
                sb.Append("<tr>");
                sb.Append($"<td class='no'>{invoiceItem.InvoiceNumber}</td>");
                sb.Append($"<td class='desc'><h3>{invoiceItem.Product}</h3>{invoiceItem.Description}</td>");
                sb.Append($"<td class='unit'>${invoiceItem.Price}</td>");
                sb.Append($"<td class='qty'>{invoiceItem.Quantity}</td>");
                sb.Append($"<td class='total'>${invoiceItem.Total}</td>");
                sb.Append("</tr>");
            }*/

            /*content = content.Replace("{{invoiceDetails}}", sb.ToString())
                .Replace("{{subTotal}}", invoice.SubTotal.ToString("C"))
                .Replace("{{tax}}", invoice.Tax.ToString())
                .Replace("{{total}}", invoice.Total.ToString("C"));*/

            return content;
        }
    }
}
