namespace WindowsServiceCorreo
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.serviceProcessInstallerEmailCordillera = new System.ServiceProcess.ServiceProcessInstaller();
            this.serviceInstallerEmailCordillera = new System.ServiceProcess.ServiceInstaller();
            // 
            // serviceProcessInstallerEmailCordillera
            // 
            this.serviceProcessInstallerEmailCordillera.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.serviceProcessInstallerEmailCordillera.Password = null;
            this.serviceProcessInstallerEmailCordillera.Username = null;
            // 
            // serviceInstallerEmailCordillera
            // 
            this.serviceInstallerEmailCordillera.Description = "Email Cordillera";
            this.serviceInstallerEmailCordillera.ServiceName = "ServiceEmailCordillera";
            this.serviceInstallerEmailCordillera.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.serviceProcessInstallerEmailCordillera,
            this.serviceInstallerEmailCordillera});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller serviceProcessInstallerEmailCordillera;
        private System.ServiceProcess.ServiceInstaller serviceInstallerEmailCordillera;
    }
}