﻿namespace Parcial2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FechaPago = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.NoIdentificacionText = new System.Windows.Forms.TextBox();
            this.ValorDonadoText = new System.Windows.Forms.TextBox();
            this.NombreText = new System.Windows.Forms.TextBox();
            this.TipoBox = new System.Windows.Forms.ComboBox();
            this.GuardarBton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NoIdentificacion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "FechaPago:";
            // 
            // FechaPago
            // 
            this.FechaPago.Location = new System.Drawing.Point(221, 172);
            this.FechaPago.Name = "FechaPago";
            this.FechaPago.Size = new System.Drawing.Size(200, 20);
            this.FechaPago.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "ValorDinado:";
            // 
            // NoIdentificacionText
            // 
            this.NoIdentificacionText.Location = new System.Drawing.Point(221, 103);
            this.NoIdentificacionText.Name = "NoIdentificacionText";
            this.NoIdentificacionText.Size = new System.Drawing.Size(100, 20);
            this.NoIdentificacionText.TabIndex = 6;
            // 
            // ValorDonadoText
            // 
            this.ValorDonadoText.Location = new System.Drawing.Point(221, 212);
            this.ValorDonadoText.Name = "ValorDonadoText";
            this.ValorDonadoText.Size = new System.Drawing.Size(100, 20);
            this.ValorDonadoText.TabIndex = 7;
            // 
            // NombreText
            // 
            this.NombreText.Location = new System.Drawing.Point(221, 136);
            this.NombreText.Name = "NombreText";
            this.NombreText.Size = new System.Drawing.Size(100, 20);
            this.NombreText.TabIndex = 8;
            // 
            // TipoBox
            // 
            this.TipoBox.FormattingEnabled = true;
            this.TipoBox.Location = new System.Drawing.Point(221, 71);
            this.TipoBox.Name = "TipoBox";
            this.TipoBox.Size = new System.Drawing.Size(121, 21);
            this.TipoBox.TabIndex = 9;
            // 
            // GuardarBton
            // 
            this.GuardarBton.Location = new System.Drawing.Point(506, 214);
            this.GuardarBton.Name = "GuardarBton";
            this.GuardarBton.Size = new System.Drawing.Size(75, 23);
            this.GuardarBton.TabIndex = 10;
            this.GuardarBton.Text = "Guardar";
            this.GuardarBton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(87, 279);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(726, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 499);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GuardarBton);
            this.Controls.Add(this.TipoBox);
            this.Controls.Add(this.NombreText);
            this.Controls.Add(this.ValorDonadoText);
            this.Controls.Add(this.NoIdentificacionText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FechaPago);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker FechaPago;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NoIdentificacionText;
        private System.Windows.Forms.TextBox ValorDonadoText;
        private System.Windows.Forms.TextBox NombreText;
        private System.Windows.Forms.ComboBox TipoBox;
        private System.Windows.Forms.Button GuardarBton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

