namespace calculadoraForm
{
    partial class Operaciones
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
            this.salir = new System.Windows.Forms.Button();
            this.numero1 = new System.Windows.Forms.TextBox();
            this.numero2 = new System.Windows.Forms.TextBox();
            this.verificar = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.Opcion1 = new System.Windows.Forms.RadioButton();
            this.Opcion2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(247, 276);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 23);
            this.salir.TabIndex = 0;
            this.salir.Text = "SALIR";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // numero1
            // 
            this.numero1.Location = new System.Drawing.Point(73, 28);
            this.numero1.Name = "numero1";
            this.numero1.Size = new System.Drawing.Size(185, 20);
            this.numero1.TabIndex = 1;
            // 
            // numero2
            // 
            this.numero2.Location = new System.Drawing.Point(73, 54);
            this.numero2.Name = "numero2";
            this.numero2.Size = new System.Drawing.Size(185, 20);
            this.numero2.TabIndex = 2;
            // 
            // verificar
            // 
            this.verificar.Location = new System.Drawing.Point(123, 139);
            this.verificar.Name = "verificar";
            this.verificar.Size = new System.Drawing.Size(75, 30);
            this.verificar.TabIndex = 3;
            this.verificar.Text = "VERIFICAR";
            this.verificar.UseVisualStyleBackColor = true;
            this.verificar.Click += new System.EventHandler(this.Verificar_Click);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(123, 175);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 30);
            this.limpiar.TabIndex = 4;
            this.limpiar.Text = "LIMPIAR";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // Opcion1
            // 
            this.Opcion1.AutoSize = true;
            this.Opcion1.ForeColor = System.Drawing.SystemColors.Control;
            this.Opcion1.Location = new System.Drawing.Point(73, 88);
            this.Opcion1.Name = "Opcion1";
            this.Opcion1.Size = new System.Drawing.Size(78, 17);
            this.Opcion1.TabIndex = 5;
            this.Opcion1.TabStop = true;
            this.Opcion1.Text = "Par o impar";
            this.Opcion1.UseVisualStyleBackColor = true;
            // 
            // Opcion2
            // 
            this.Opcion2.AutoSize = true;
            this.Opcion2.ForeColor = System.Drawing.SystemColors.Control;
            this.Opcion2.Location = new System.Drawing.Point(73, 111);
            this.Opcion2.Name = "Opcion2";
            this.Opcion2.Size = new System.Drawing.Size(90, 17);
            this.Opcion2.TabIndex = 6;
            this.Opcion2.TabStop = true;
            this.Opcion2.Text = "Numero primo";
            this.Opcion2.UseVisualStyleBackColor = true;
            // 
            // Operaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.Opcion2);
            this.Controls.Add(this.Opcion1);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.verificar);
            this.Controls.Add(this.numero2);
            this.Controls.Add(this.numero1);
            this.Controls.Add(this.salir);
            this.Name = "Operaciones";
            this.Text = "Operaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.TextBox numero1;
        private System.Windows.Forms.TextBox numero2;
        private System.Windows.Forms.Button verificar;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.RadioButton Opcion1;
        private System.Windows.Forms.RadioButton Opcion2;
    }
}