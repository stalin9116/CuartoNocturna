using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace WindowsServiceCorreo
{
    public class CorreoElectronico
    {
        public static bool EnviarCorreo(TBL_MAILCONFIG _infoMailConfiguration,  string asunto, string plantilla, TBL_MAIL _infoMail)
        {
            bool res = false;
            /*-------------------------MENSAJE DE CORREO----------------------*/

            //Creamos un nuevo Objeto de mensaje
            System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();

            mmsg.IsBodyHtml = true;

            //mmsg.Priority = MailPriority.High;
            //Direccion de correo electronico a la que queremos enviar el mensaje

            //foreach (var correo in correos)
            //{
            //    mmsg.To.Add(correo.Email);
            //}

            mmsg.To.Add(_infoMail.mus_correo);


            

            //Nota: La propiedad To es una colección que permite enviar el mensaje a más de un destinatario

            //Asunto
            mmsg.Subject = asunto;
            //mmsg.SubjectEncoding = System.Text.Encoding.UTF8;

            //Remplazar Datos.
            plantilla = plantilla.Replace("@Correo", _infoMail.mus_correo);
            plantilla = plantilla.Replace("@Nombre", _infoMail.mus_nombre);
            

            //Cuerpo del Mensaje
            AlternateView htmlView = AlternateView.CreateAlternateViewFromString(plantilla, null, MediaTypeNames.Text.Html);

            //mmsg.Body = mensaje;

            //Imagenes

            LinkedResource imageHtmlBanner1 = new LinkedResource("C:\\Itsco\\encabezadoEmail.jpg", MediaTypeNames.Image.Jpeg);
            imageHtmlBanner1.ContentId = "idBanner1";
            LinkedResource imageHtmlBanner2 = new LinkedResource("C:\\Itsco\\pieEmail.jpg", MediaTypeNames.Image.Jpeg);
            imageHtmlBanner2.ContentId = "idBanner2";

            htmlView.LinkedResources.Add(imageHtmlBanner1);
            htmlView.LinkedResources.Add(imageHtmlBanner2);

            mmsg.AlternateViews.Add(htmlView);

            //mmsg.BodyEncoding = System.Text.Encoding.UTF8;

            //Correo electronico desde la que enviamos el mensaje

            mmsg.From = new System.Net.Mail.MailAddress(_infoMailConfiguration.mai_user);

            ////Archivos Adjuntos

            //if (!string.IsNullOrEmpty(adjuntoXML))
            //{
            //    mmsg.Attachments.Add(new Attachment(adjuntoXML));
            //}
            //if (!string.IsNullOrEmpty(adjuntoPDF))
            //{
            //    mmsg.Attachments.Add(new Attachment(adjuntoPDF));
            //}


            /*-------------------------COFNIGURACION DE CORREO----------------------*/


            //Creamos un objeto de cliente de correo
            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();

            //cliente.UseDefaultCredentials = false;
            //Hay que crear las credenciales del correo emisor
            cliente.Credentials =
                new System.Net.NetworkCredential(_infoMailConfiguration.mai_user, _infoMailConfiguration.mai_password);

            cliente.Port = _infoMailConfiguration.mai_puerto;

            //ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
            //cliente.EnableSsl = true;
            

            //cliente.DeliveryMethod = SmtpDeliveryMethod.Network;

            //cliente.Timeout = 10000;

            cliente.EnableSsl = true;


            cliente.Host = _infoMailConfiguration.mai_servidor; //Para Gmail "smtp.gmail.com";


            /*-------------------------ENVIO DE CORREO----------------------*/
            try
            {
                //Enviamos el mensaje      
                cliente.Send(mmsg);
                mmsg.Dispose();
                res = true;
                return res;
            }
            catch (System.Net.Mail.SmtpException ex)
            {
                mmsg.Dispose();
                throw new ArgumentException(ex.Message);
                //Aquí gestionamos los errores al intentar enviar el correo
            }
        }

    }
}
