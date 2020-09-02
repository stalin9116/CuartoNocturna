using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Xml;


namespace WindowsServiceCorreo
{
    public partial class Service1 : ServiceBase
    {
        EventLog eventLog = new EventLog();
        Timer timer1 = new Timer();
        private int tiempo;

        private TBL_MAILCONFIG _dataConfiguration { get; set; }

        public Service1()
        {
            InitializeComponent();
            if (!System.Diagnostics.EventLog.SourceExists("MailComentarios"))
            {
                System.Diagnostics.EventLog.CreateEventSource("MailComentarios", "MailComentariosLog");
            }
            eventLog.Source = "MailComentarios";
            eventLog.Log = "MailComentariosLog";
            //loadFileConfig();
            //loadConfigServer();even
            //test();
        }

        private void test()
        {
            try
            {
                List<TBL_MAIL> _listaMails = new List<TBL_MAIL>();
                _listaMails = logicaMail.getEmails();
                if (_listaMails.Count > 0 && _listaMails != null)
                {
                    foreach (var item in _listaMails)
                    {
                        bool res = logicaMail.sendEmail(_dataConfiguration, item);
                        if (!res)
                        {
                            eventLog.WriteEntry("Error al enviar el correo electrónico");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                eventLog.WriteEntry(ex.Message);
            }

        }

        private void loadFileConfig()
        {
            string urlArchvio = "C:/Configuration.xml";

            if (File.Exists(urlArchvio))
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(urlArchvio);
                XmlNodeList tagConfiguration = xDoc.GetElementsByTagName("CONFIGURATION");
                XmlNodeList tagServiceMail = ((XmlElement)tagConfiguration[0]).GetElementsByTagName("SERMAIL");
                foreach (XmlElement item in tagServiceMail)
                {
                    XmlNodeList TIME = item.GetElementsByTagName("TIME");
                    tiempo = int.Parse(TIME[0].InnerText);
                    eventLog.WriteEntry("Archivo de configuración cargado correctamente");
                }
            }
            else
            {
                eventLog.WriteEntry("Error al cargar XML de Configuración");
            }
        }

        private void loadConfigServer()
        {
            try
            {
                TBL_MAILCONFIG _infoMailConfig = new TBL_MAILCONFIG();
                _infoMailConfig = logicaMail.getConfigMail();
                if (_infoMailConfig != null)
                {
                    _dataConfiguration = new TBL_MAILCONFIG();
                    _dataConfiguration = _infoMailConfig;
                    eventLog.WriteEntry("Archivo de configuración de servidor cargado correctamente");
                }
            }
            catch (Exception)
            {
                eventLog.WriteEntry("Error al cargar datos de Configuración de la base");

            }
        }

        protected override void OnStart(string[] args)
        {
            loadFileConfig();
            loadConfigServer();
            timer1.Elapsed += new ElapsedEventHandler(timer1_Elepsed);
            timer1.Interval = tiempo;
            timer1.Enabled = true;
            timer1.Start();
            eventLog.WriteEntry("Servicio de Correo iniciado Correctamente");
        }

        protected override void OnStop()
        {
            timer1.Enabled = false;
            eventLog.WriteEntry("Servicio de Correo Detenido Correctamente");
        }

        private void timer1_Elepsed(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Enabled = false;

            try
            {
                List<TBL_MAIL> _listaMails = new List<TBL_MAIL>();
                _listaMails = logicaMail.getEmails();
                if (_listaMails.Count > 0 && _listaMails != null)
                {
                    foreach (var item in _listaMails)
                    {
                        bool res = logicaMail.sendEmail(_dataConfiguration, item);
                        if (!res)
                        {
                            eventLog.WriteEntry("Error al enviar el correo electrónico");
                        }
                    }
                }
                timer1.Enabled = true;
                timer1.Start();

            }
            catch (Exception ex)
            {
                eventLog.WriteEntry(ex.Message);
            }
        }

    }
}
