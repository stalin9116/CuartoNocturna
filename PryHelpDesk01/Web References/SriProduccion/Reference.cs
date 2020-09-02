﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.42000.
// 
#pragma warning disable 1591

namespace PryHelpDesk01.SriProduccion {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="AutorizacionComprobantesOfflineServiceSoapBinding", Namespace="http://ec.gob.sri.ws.autorizacion")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(mensaje[]))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(autorizacion[]))]
    public partial class AutorizacionComprobantesOfflineService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback autorizacionComprobanteOperationCompleted;
        
        private System.Threading.SendOrPostCallback autorizacionComprobanteLoteOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public AutorizacionComprobantesOfflineService() {
            this.Url = global::PryHelpDesk01.Properties.Settings.Default.PryHelpDesk01_SriProduccion_AutorizacionComprobantesOfflineService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event autorizacionComprobanteCompletedEventHandler autorizacionComprobanteCompleted;
        
        /// <remarks/>
        public event autorizacionComprobanteLoteCompletedEventHandler autorizacionComprobanteLoteCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://ec.gob.sri.ws.autorizacion", ResponseNamespace="http://ec.gob.sri.ws.autorizacion", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("RespuestaAutorizacionComprobante", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public object autorizacionComprobante([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string claveAccesoComprobante) {
            object[] results = this.Invoke("autorizacionComprobante", new object[] {
                        claveAccesoComprobante});
            return (results[0]);
        }
        
        /// <remarks/>
        public void autorizacionComprobanteAsync(string claveAccesoComprobante) {
            this.autorizacionComprobanteAsync(claveAccesoComprobante, null);
        }
        
        /// <remarks/>
        public void autorizacionComprobanteAsync(string claveAccesoComprobante, object userState) {
            if ((this.autorizacionComprobanteOperationCompleted == null)) {
                this.autorizacionComprobanteOperationCompleted = new System.Threading.SendOrPostCallback(this.OnautorizacionComprobanteOperationCompleted);
            }
            this.InvokeAsync("autorizacionComprobante", new object[] {
                        claveAccesoComprobante}, this.autorizacionComprobanteOperationCompleted, userState);
        }
        
        private void OnautorizacionComprobanteOperationCompleted(object arg) {
            if ((this.autorizacionComprobanteCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.autorizacionComprobanteCompleted(this, new autorizacionComprobanteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://ec.gob.sri.ws.autorizacion", ResponseNamespace="http://ec.gob.sri.ws.autorizacion", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("RespuestaAutorizacionLote", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public respuestaLote autorizacionComprobanteLote([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string claveAccesoLote) {
            object[] results = this.Invoke("autorizacionComprobanteLote", new object[] {
                        claveAccesoLote});
            return ((respuestaLote)(results[0]));
        }
        
        /// <remarks/>
        public void autorizacionComprobanteLoteAsync(string claveAccesoLote) {
            this.autorizacionComprobanteLoteAsync(claveAccesoLote, null);
        }
        
        /// <remarks/>
        public void autorizacionComprobanteLoteAsync(string claveAccesoLote, object userState) {
            if ((this.autorizacionComprobanteLoteOperationCompleted == null)) {
                this.autorizacionComprobanteLoteOperationCompleted = new System.Threading.SendOrPostCallback(this.OnautorizacionComprobanteLoteOperationCompleted);
            }
            this.InvokeAsync("autorizacionComprobanteLote", new object[] {
                        claveAccesoLote}, this.autorizacionComprobanteLoteOperationCompleted, userState);
        }
        
        private void OnautorizacionComprobanteLoteOperationCompleted(object arg) {
            if ((this.autorizacionComprobanteLoteCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.autorizacionComprobanteLoteCompleted(this, new autorizacionComprobanteLoteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ec.gob.sri.ws.autorizacion")]
    public partial class respuestaComprobante {
        
        private string claveAccesoConsultadaField;
        
        private string numeroComprobantesField;
        
        private autorizacion[] autorizacionesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string claveAccesoConsultada {
            get {
                return this.claveAccesoConsultadaField;
            }
            set {
                this.claveAccesoConsultadaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string numeroComprobantes {
            get {
                return this.numeroComprobantesField;
            }
            set {
                this.numeroComprobantesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public autorizacion[] autorizaciones {
            get {
                return this.autorizacionesField;
            }
            set {
                this.autorizacionesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ec.gob.sri.ws.autorizacion")]
    public partial class autorizacion {
        
        private string estadoField;
        
        private string numeroAutorizacionField;
        
        private System.DateTime fechaAutorizacionField;
        
        private bool fechaAutorizacionFieldSpecified;
        
        private string ambienteField;
        
        private string comprobanteField;
        
        private mensaje[] mensajesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string estado {
            get {
                return this.estadoField;
            }
            set {
                this.estadoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string numeroAutorizacion {
            get {
                return this.numeroAutorizacionField;
            }
            set {
                this.numeroAutorizacionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.DateTime fechaAutorizacion {
            get {
                return this.fechaAutorizacionField;
            }
            set {
                this.fechaAutorizacionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fechaAutorizacionSpecified {
            get {
                return this.fechaAutorizacionFieldSpecified;
            }
            set {
                this.fechaAutorizacionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ambiente {
            get {
                return this.ambienteField;
            }
            set {
                this.ambienteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string comprobante {
            get {
                return this.comprobanteField;
            }
            set {
                this.comprobanteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public mensaje[] mensajes {
            get {
                return this.mensajesField;
            }
            set {
                this.mensajesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ec.gob.sri.ws.autorizacion")]
    public partial class mensaje {
        
        private string identificadorField;
        
        private string mensaje1Field;
        
        private string informacionAdicionalField;
        
        private string tipoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string identificador {
            get {
                return this.identificadorField;
            }
            set {
                this.identificadorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mensaje", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string mensaje1 {
            get {
                return this.mensaje1Field;
            }
            set {
                this.mensaje1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string informacionAdicional {
            get {
                return this.informacionAdicionalField;
            }
            set {
                this.informacionAdicionalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string tipo {
            get {
                return this.tipoField;
            }
            set {
                this.tipoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ec.gob.sri.ws.autorizacion")]
    public partial class respuestaLote {
        
        private string claveAccesoLoteConsultadaField;
        
        private string numeroComprobantesLoteField;
        
        private autorizacion[] autorizacionesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string claveAccesoLoteConsultada {
            get {
                return this.claveAccesoLoteConsultadaField;
            }
            set {
                this.claveAccesoLoteConsultadaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string numeroComprobantesLote {
            get {
                return this.numeroComprobantesLoteField;
            }
            set {
                this.numeroComprobantesLoteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public autorizacion[] autorizaciones {
            get {
                return this.autorizacionesField;
            }
            set {
                this.autorizacionesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void autorizacionComprobanteCompletedEventHandler(object sender, autorizacionComprobanteCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class autorizacionComprobanteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal autorizacionComprobanteCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public respuestaComprobante Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((respuestaComprobante)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void autorizacionComprobanteLoteCompletedEventHandler(object sender, autorizacionComprobanteLoteCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class autorizacionComprobanteLoteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal autorizacionComprobanteLoteCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public respuestaLote Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((respuestaLote)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591