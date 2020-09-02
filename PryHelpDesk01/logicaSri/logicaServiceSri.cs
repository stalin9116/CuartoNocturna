using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using PryHelpDesk01.objetos;
using PryHelpDesk01.SriProduccion;

namespace PryHelpDesk01.logicaSri
{
    public class logicaServiceSri
    {
        public static string consultaFacturaSriProduccion(string claveAcceso)
        {
            string resultado = "";

            AutorizacionComprobantesOfflineService Service = new AutorizacionComprobantesOfflineService();
            XmlNode[] xmlRespuesta = (XmlNode[])Service.autorizacionComprobante(claveAcceso);

            XDocument res = new XDocument();
            clsObjetosAutorizacion _infoAutorizacion = new clsObjetosAutorizacion();

            if (!string.IsNullOrEmpty(xmlRespuesta[2].InnerXml))
            {
                res = XDocument.Parse(xmlRespuesta[2].InnerXml);
            }

            var queryXml = res.Descendants("autorizacion").Select(data => new
            {
                estado = data.Element("estado").Value,
                numeroAutorizacion = data.Element("numeroAutorizacion").Value,
                fechaAutorizacion = data.Element("fechaAutorizacion").Value,
                ambiente = data.Element("ambiente").Value,
                comprobante = data.Element("comprobante").Value
            });

            foreach (var item in queryXml)
            {
                _infoAutorizacion.estado = item.estado;
                _infoAutorizacion.numeroAutorizacion = item.numeroAutorizacion;
                _infoAutorizacion.fechaAutorizacion = item.fechaAutorizacion;
                _infoAutorizacion.ambiente = item.ambiente;
                _infoAutorizacion.comprobante = XDocument.Parse(item.comprobante);
            }

            //_infoAutorizacion.comprobante.Save();
            //var nombre=_infoAutorizacion.numeroAutorizacion + ".xml";

            return "";
        }


    }
}
