namespace ExamenTercerP
{
    partial class menuPrincipal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.creditos = new System.Windows.Forms.Button();
            this.entradaUsuario = new System.Windows.Forms.TextBox();
            this.entradaContrasena = new System.Windows.Forms.TextBox();
            this.botonInicio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // creditos
            // 
            this.creditos.Location = new System.Drawing.Point(48, 93);
            this.creditos.Name = "creditos";
            this.creditos.Size = new System.Drawing.Size(97, 23);
            this.creditos.TabIndex = 3;
            this.creditos.Text = "CREDITOS";
            this.creditos.UseVisualStyleBackColor = true;
            this.creditos.Click += new System.EventHandler(this.Creditos_Click);
            // 
            // entradaUsuario
            // 
            this.entradaUsuario.Location = new System.Drawing.Point(48, 12);
            this.entradaUsuario.Name = "entradaUsuario";
            this.entradaUsuario.Size = new System.Drawing.Size(97, 20);
            this.entradaUsuario.TabIndex = 5;
            this.entradaUsuario.Text = "Usuario";
            // 
            // entradaContrasena
            // 
            this.entradaContrasena.Location = new System.Drawing.Point(48, 38);
            this.entradaContrasena.Name = "entradaContrasena";
            this.entradaContrasena.Size = new System.Drawing.Size(97, 20);
            this.entradaContrasena.TabIndex = 6;
            this.entradaContrasena.Text = "Contrasena";
            // 
            // botonInicio
            // 
            this.botonInicio.Location = new System.Drawing.Point(48, 64);
            this.botonInicio.Name = "botonInicio";
            this.botonInicio.Size = new System.Drawing.Size(97, 23);
            this.botonInicio.TabIndex = 7;
            this.botonInicio.Text = "INICIAR SESION";
            this.botonInicio.UseVisualStyleBackColor = true;
            this.botonInicio.Click += new System.EventHandler(this.BotonInicio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, -7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 8;
            // 
            // menuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 127);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonInicio);
            this.Controls.Add(this.entradaContrasena);
            this.Controls.Add(this.entradaUsuario);
            this.Controls.Add(this.creditos);
            this.Name = "menuPrincipal";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button creditos;
        private System.Windows.Forms.TextBox entradaUsuario;
        private System.Windows.Forms.TextBox entradaContrasena;
        private System.Windows.Forms.Button botonInicio;
        private System.Windows.Forms.Label label1;
    }
}

