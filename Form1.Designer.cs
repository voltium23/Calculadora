
namespace Calculadora
{
    partial class Calculadora
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
            this.numero = new System.Windows.Forms.Label();
            this.bce = new System.Windows.Forms.Button();
            this.bc = new System.Windows.Forms.Button();
            this.bsigno = new System.Windows.Forms.Button();
            this.bretroceso = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.bdivision = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.bmultiplicacion = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.bresta = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.bdecimal = new System.Windows.Forms.Button();
            this.bigual = new System.Windows.Forms.Button();
            this.bsuma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numero
            // 
            this.numero.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero.Location = new System.Drawing.Point(12, 9);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(236, 44);
            this.numero.TabIndex = 0;
            this.numero.Text = "0.0";
            this.numero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bce
            // 
            this.bce.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bce.Location = new System.Drawing.Point(12, 70);
            this.bce.Name = "bce";
            this.bce.Size = new System.Drawing.Size(55, 43);
            this.bce.TabIndex = 1;
            this.bce.Text = "CE";
            this.bce.UseVisualStyleBackColor = true;
            this.bce.Click += new System.EventHandler(this.button1_Click);
            // 
            // bc
            // 
            this.bc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bc.Location = new System.Drawing.Point(73, 68);
            this.bc.Name = "bc";
            this.bc.Size = new System.Drawing.Size(55, 45);
            this.bc.TabIndex = 2;
            this.bc.Text = "C";
            this.bc.UseVisualStyleBackColor = true;
            this.bc.Click += new System.EventHandler(this.bc_Click);
            // 
            // bsigno
            // 
            this.bsigno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsigno.Location = new System.Drawing.Point(132, 69);
            this.bsigno.Name = "bsigno";
            this.bsigno.Size = new System.Drawing.Size(55, 44);
            this.bsigno.TabIndex = 3;
            this.bsigno.Text = "+/-";
            this.bsigno.UseVisualStyleBackColor = true;
            this.bsigno.Click += new System.EventHandler(this.bsigno_Click);
            // 
            // bretroceso
            // 
            this.bretroceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bretroceso.Location = new System.Drawing.Point(193, 69);
            this.bretroceso.Name = "bretroceso";
            this.bretroceso.Size = new System.Drawing.Size(55, 42);
            this.bretroceso.TabIndex = 4;
            this.bretroceso.Text = "«";
            this.bretroceso.UseVisualStyleBackColor = true;
            this.bretroceso.Click += new System.EventHandler(this.bretroceso_Click);
            // 
            // b7
            // 
            this.b7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b7.Location = new System.Drawing.Point(12, 129);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(55, 43);
            this.b7.TabIndex = 5;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b8
            // 
            this.b8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b8.Location = new System.Drawing.Point(73, 129);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(55, 43);
            this.b8.TabIndex = 6;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b9
            // 
            this.b9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b9.Location = new System.Drawing.Point(132, 129);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(55, 43);
            this.b9.TabIndex = 7;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // bdivision
            // 
            this.bdivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdivision.Location = new System.Drawing.Point(193, 129);
            this.bdivision.Name = "bdivision";
            this.bdivision.Size = new System.Drawing.Size(55, 43);
            this.bdivision.TabIndex = 8;
            this.bdivision.Text = "/";
            this.bdivision.UseVisualStyleBackColor = true;
            this.bdivision.Click += new System.EventHandler(this.bdivision_Click);
            // 
            // b4
            // 
            this.b4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b4.Location = new System.Drawing.Point(12, 178);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(55, 43);
            this.b4.TabIndex = 9;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b5
            // 
            this.b5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b5.Location = new System.Drawing.Point(73, 178);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(55, 43);
            this.b5.TabIndex = 10;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b6
            // 
            this.b6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b6.Location = new System.Drawing.Point(132, 178);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(55, 43);
            this.b6.TabIndex = 11;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // bmultiplicacion
            // 
            this.bmultiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmultiplicacion.Location = new System.Drawing.Point(193, 178);
            this.bmultiplicacion.Name = "bmultiplicacion";
            this.bmultiplicacion.Size = new System.Drawing.Size(55, 43);
            this.bmultiplicacion.TabIndex = 12;
            this.bmultiplicacion.Text = "*";
            this.bmultiplicacion.UseVisualStyleBackColor = true;
            this.bmultiplicacion.Click += new System.EventHandler(this.bmultiplicacion_Click);
            // 
            // b1
            // 
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(12, 227);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(55, 43);
            this.b1.TabIndex = 13;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.button13_Click);
            // 
            // b2
            // 
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(73, 227);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(55, 43);
            this.b2.TabIndex = 14;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b3
            // 
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.Location = new System.Drawing.Point(132, 227);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(55, 43);
            this.b3.TabIndex = 15;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // bresta
            // 
            this.bresta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bresta.Location = new System.Drawing.Point(193, 227);
            this.bresta.Name = "bresta";
            this.bresta.Size = new System.Drawing.Size(55, 43);
            this.bresta.TabIndex = 16;
            this.bresta.Text = "-";
            this.bresta.UseVisualStyleBackColor = true;
            this.bresta.Click += new System.EventHandler(this.bresta_Click);
            // 
            // b0
            // 
            this.b0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b0.Location = new System.Drawing.Point(12, 276);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(55, 43);
            this.b0.TabIndex = 17;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.b0_Click);
            // 
            // bdecimal
            // 
            this.bdecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdecimal.Location = new System.Drawing.Point(73, 276);
            this.bdecimal.Name = "bdecimal";
            this.bdecimal.Size = new System.Drawing.Size(55, 43);
            this.bdecimal.TabIndex = 18;
            this.bdecimal.Text = ".";
            this.bdecimal.UseVisualStyleBackColor = true;
            this.bdecimal.Click += new System.EventHandler(this.bdecimal_Click);
            // 
            // bigual
            // 
            this.bigual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigual.Location = new System.Drawing.Point(132, 276);
            this.bigual.Name = "bigual";
            this.bigual.Size = new System.Drawing.Size(55, 43);
            this.bigual.TabIndex = 19;
            this.bigual.Text = "=";
            this.bigual.UseVisualStyleBackColor = true;
            this.bigual.Click += new System.EventHandler(this.bigual_Click);
            // 
            // bsuma
            // 
            this.bsuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsuma.Location = new System.Drawing.Point(193, 276);
            this.bsuma.Name = "bsuma";
            this.bsuma.Size = new System.Drawing.Size(55, 43);
            this.bsuma.TabIndex = 20;
            this.bsuma.Text = "+";
            this.bsuma.UseVisualStyleBackColor = true;
            this.bsuma.Click += new System.EventHandler(this.bsuma_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(260, 370);
            this.Controls.Add(this.bsuma);
            this.Controls.Add(this.bigual);
            this.Controls.Add(this.bdecimal);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.bresta);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.bmultiplicacion);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.bdivision);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.bretroceso);
            this.Controls.Add(this.bsigno);
            this.Controls.Add(this.bc);
            this.Controls.Add(this.bce);
            this.Controls.Add(this.numero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Calculadora_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label numero;
        private System.Windows.Forms.Button bce;
        private System.Windows.Forms.Button bc;
        private System.Windows.Forms.Button bsigno;
        private System.Windows.Forms.Button bretroceso;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button bdivision;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button bmultiplicacion;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button bresta;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button bdecimal;
        private System.Windows.Forms.Button bigual;
        private System.Windows.Forms.Button bsuma;
    }
}

