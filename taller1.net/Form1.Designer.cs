namespace taller1.net
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnmasacorporal = new System.Windows.Forms.Button();
            this.btnllamadas = new System.Windows.Forms.Button();
            this.btnnotas = new System.Windows.Forms.Button();
            this.btnvolumen = new System.Windows.Forms.Button();
            this.btnraiz = new System.Windows.Forms.Button();
            this.btnedadsegundos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Qué deseas hacer?";
            // 
            // btnmasacorporal
            // 
            this.btnmasacorporal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmasacorporal.Location = new System.Drawing.Point(32, 125);
            this.btnmasacorporal.Name = "btnmasacorporal";
            this.btnmasacorporal.Size = new System.Drawing.Size(132, 56);
            this.btnmasacorporal.TabIndex = 1;
            this.btnmasacorporal.Text = "Masa Corporal";
            this.btnmasacorporal.UseVisualStyleBackColor = true;
            // 
            // btnllamadas
            // 
            this.btnllamadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnllamadas.Location = new System.Drawing.Point(32, 209);
            this.btnllamadas.Name = "btnllamadas";
            this.btnllamadas.Size = new System.Drawing.Size(132, 52);
            this.btnllamadas.TabIndex = 2;
            this.btnllamadas.Text = "Llamadas al exterior";
            this.btnllamadas.UseVisualStyleBackColor = true;
            // 
            // btnnotas
            // 
            this.btnnotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnotas.Location = new System.Drawing.Point(32, 297);
            this.btnnotas.Name = "btnnotas";
            this.btnnotas.Size = new System.Drawing.Size(132, 54);
            this.btnnotas.TabIndex = 3;
            this.btnnotas.Text = "Promedio de notas";
            this.btnnotas.UseVisualStyleBackColor = true;
            // 
            // btnvolumen
            // 
            this.btnvolumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolumen.Location = new System.Drawing.Point(254, 125);
            this.btnvolumen.Name = "btnvolumen";
            this.btnvolumen.Size = new System.Drawing.Size(185, 56);
            this.btnvolumen.TabIndex = 4;
            this.btnvolumen.Text = "Volumen de una caja";
            this.btnvolumen.UseVisualStyleBackColor = true;
            this.btnvolumen.Click += new System.EventHandler(this.Btnvolumen_Click);
            // 
            // btnraiz
            // 
            this.btnraiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnraiz.Location = new System.Drawing.Point(254, 209);
            this.btnraiz.Name = "btnraiz";
            this.btnraiz.Size = new System.Drawing.Size(185, 52);
            this.btnraiz.TabIndex = 5;
            this.btnraiz.Text = "Raiz cuadrada";
            this.btnraiz.UseVisualStyleBackColor = true;
            // 
            // btnedadsegundos
            // 
            this.btnedadsegundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedadsegundos.Location = new System.Drawing.Point(254, 297);
            this.btnedadsegundos.Name = "btnedadsegundos";
            this.btnedadsegundos.Size = new System.Drawing.Size(185, 54);
            this.btnedadsegundos.TabIndex = 6;
            this.btnedadsegundos.Text = "Edad en segundos";
            this.btnedadsegundos.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(511, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 56);
            this.button1.TabIndex = 7;
            this.button1.Text = "Total a pagar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(511, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 52);
            this.button2.TabIndex = 8;
            this.button2.Text = "Area triángulo ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(511, 297);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 54);
            this.button3.TabIndex = 9;
            this.button3.Text = "Categoria según edad";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(275, 399);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(146, 60);
            this.button4.TabIndex = 10;
            this.button4.Text = "Cerrar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnedadsegundos);
            this.Controls.Add(this.btnraiz);
            this.Controls.Add(this.btnvolumen);
            this.Controls.Add(this.btnnotas);
            this.Controls.Add(this.btnllamadas);
            this.Controls.Add(this.btnmasacorporal);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnmasacorporal;
        private System.Windows.Forms.Button btnllamadas;
        private System.Windows.Forms.Button btnnotas;
        private System.Windows.Forms.Button btnvolumen;
        private System.Windows.Forms.Button btnraiz;
        private System.Windows.Forms.Button btnedadsegundos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

