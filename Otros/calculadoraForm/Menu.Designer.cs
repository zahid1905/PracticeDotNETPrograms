namespace calculadoraForm
{
    partial class Menu
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
            this.calculadora = new System.Windows.Forms.Button();
            this.operaciones = new System.Windows.Forms.Button();
            this.creditos = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calculadora
            // 
            this.calculadora.Location = new System.Drawing.Point(121, 82);
            this.calculadora.Name = "calculadora";
            this.calculadora.Size = new System.Drawing.Size(113, 38);
            this.calculadora.TabIndex = 0;
            this.calculadora.Text = "CALCULADORA";
            this.calculadora.UseVisualStyleBackColor = true;
            this.calculadora.Click += new System.EventHandler(this.Calculadora_Click);
            // 
            // operaciones
            // 
            this.operaciones.Location = new System.Drawing.Point(121, 126);
            this.operaciones.Name = "operaciones";
            this.operaciones.Size = new System.Drawing.Size(113, 38);
            this.operaciones.TabIndex = 1;
            this.operaciones.Text = "OPERACIONES";
            this.operaciones.UseVisualStyleBackColor = true;
            this.operaciones.Click += new System.EventHandler(this.Operaciones_Click);
            // 
            // creditos
            // 
            this.creditos.Location = new System.Drawing.Point(121, 170);
            this.creditos.Name = "creditos";
            this.creditos.Size = new System.Drawing.Size(113, 38);
            this.creditos.TabIndex = 2;
            this.creditos.Text = "CREDITOS";
            this.creditos.UseVisualStyleBackColor = true;
            this.creditos.Click += new System.EventHandler(this.Creditos_Click);
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(247, 276);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 23);
            this.salir.TabIndex = 3;
            this.salir.Text = "SALIR";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.creditos);
            this.Controls.Add(this.operaciones);
            this.Controls.Add(this.calculadora);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button calculadora;
        private System.Windows.Forms.Button operaciones;
        private System.Windows.Forms.Button creditos;
        private System.Windows.Forms.Button salir;
    }
}