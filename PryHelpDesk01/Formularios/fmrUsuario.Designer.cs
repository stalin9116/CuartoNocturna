namespace PryHelpDesk01.Formularios
{
    partial class fmrUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gdvUsuarios = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbBuscar = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gdvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // gdvUsuarios
            // 
            this.gdvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvUsuarios.Location = new System.Drawing.Point(9, 56);
            this.gdvUsuarios.Name = "gdvUsuarios";
            this.gdvUsuarios.Size = new System.Drawing.Size(761, 150);
            this.gdvUsuarios.TabIndex = 0;
            this.gdvUsuarios.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gdvUsuarios_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Correo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Clave";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Apellidos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(407, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nombres";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(407, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Rol";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(78, 289);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(235, 20);
            this.txtCorreo.TabIndex = 8;
            this.txtCorreo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtCorreo_MouseClick);
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(78, 324);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(235, 20);
            this.txtClave.TabIndex = 9;
            this.txtClave.UseSystemPasswordChar = true;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(79, 362);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(235, 20);
            this.txtApellidos.TabIndex = 10;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(462, 257);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(235, 20);
            this.txtNombres.TabIndex = 11;
            // 
            // cmbRol
            // 
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(462, 292);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(235, 21);
            this.cmbRol.TabIndex = 12;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(356, 415);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(465, 415);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(239, 415);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 15;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(120, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Buscar";
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.FormattingEnabled = true;
            this.cmbBuscar.Items.AddRange(new object[] {
            "Todos",
            "Correo",
            "Apellidos",
            "Nombres",
            "Rol"});
            this.cmbBuscar.Location = new System.Drawing.Point(166, 217);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(147, 21);
            this.cmbBuscar.TabIndex = 17;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(319, 217);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(269, 20);
            this.txtBuscar.TabIndex = 18;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(78, 259);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(0, 13);
            this.lblCodigo.TabIndex = 19;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(595, 217);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // fmrUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cmbBuscar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gdvUsuarios);
            this.Name = "fmrUsuario";
            this.Text = "fmrUsuario";
            this.Load += new System.EventHandler(this.fmrUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gdvUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnBuscar;
    }
}