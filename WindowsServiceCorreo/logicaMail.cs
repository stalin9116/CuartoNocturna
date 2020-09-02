using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace WindowsServiceCorreo
{
    public class logicaMail
    {
        private static DCMailDataContext dc { get; set; }

        public static TBL_MAILCONFIG getConfigMail()
        {
            try
            {
                dc = new DCMailDataContext();
                var configmail = dc.TBL_MAILCONFIG.FirstOrDefault(data => data.mai_status == 'A');
                return configmail;
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Error al obtener configuacion de mail data");
            }
        }

        public static List<TBL_MAIL> getEmails()
        {
            try
            {
                dc = new DCMailDataContext();
                var lista = dc.TBL_MAIL.Where(data => data.mus_sendstatus == false
                                              && data.mus_errorstatus == false
                                              && data.mus_status == 'A');

                return lista.ToList();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al obtener mails para envio");
            }

        }

        public static bool updateStatusEmail(TBL_MAIL _infoMail)
        {
            try
            {
                _infoMail.mus_sendstatus = true;
                _infoMail.mus_add = DateTime.Now;
                dc.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Error al modificar el estado del correo");
            }
        }

        public static bool sendEmail(TBL_MAILCONFIG _infoMailConfiguration, TBL_MAIL _infoMail)
        {
            bool res = false;
            try
            {
                if (_infoMailConfiguration != null)
                {
                    if (_infoMail != null)
                    {
                        //Envio Correo
                        bool resultado = CorreoElectronico.EnviarCorreo(_infoMailConfiguration, "Registro Plataforma", PopulateBody(), _infoMail);
                        if (resultado)
                        {

                            res = true;

                            bool update = updateStatusEmail(_infoMail);

                        }
                    }
                }

                return res;
            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.Message);
            }
        }

        private static string PopulateBody()
        {
            string body = string.Empty;
            using (StreamReader reader = new StreamReader(@"C:\Itsco\Plantilla.html"))
            {
                body = reader.ReadToEnd();
            }
            return body;
        }


    }
}
