namespace ExamenTercerP
{
    partial class menuUsuario
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
            this.parejas = new System.Windows.Forms.Button();
            this.meses = new System.Windows.Forms.Button();
            this.respuesta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // parejas
            // 
            this.parejas.Location = new System.Drawing.Point(362, 133);
            this.parejas.Name = "parejas";
            this.parejas.Size = new System.Drawing.Size(97, 23);
            this.parejas.TabIndex = 0;
            this.parejas.Text = "Parejas iniciales";
            this.parejas.UseVisualStyleBackColor = true;
            this.parejas.Click += new System.EventHandler(this.Parejas_Click);
            // 
            // meses
            // 
            this.meses.Location = new System.Drawing.Point(362, 163);
            this.meses.Name = "meses";
            this.meses.Size = new System.Drawing.Size(97, 23);
            this.meses.TabIndex = 1;
            this.meses.Text = "Meses";
            this.meses.UseVisualStyleBackColor = true;
            this.meses.Click += new System.EventHandler(this.Meses_Click);
            // 
            // respuesta
            // 
            this.respuesta.Location = new System.Drawing.Point(362, 193);
            this.respuesta.Name = "respuesta";
            this.respuesta.Size = new System.Drawing.Size(97, 23);
            this.respuesta.TabIndex = 2;
            this.respuesta.Text = "Calcular";
            this.respuesta.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hola ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(465, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor actual = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(465, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor actual = ";
            // 
            // menuUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.respuesta);
            this.Controls.Add(this.meses);
            this.Controls.Add(this.parejas);
            this.Name = "menuUsuario";
            this.Text = "menuUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button parejas;
        private System.Windows.Forms.Button meses;
        private System.Windows.Forms.Button respuesta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}