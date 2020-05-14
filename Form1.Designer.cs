namespace Parcial2
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
            this.ConsultarBton = new System.Windows.Forms.Button();
            this.FiltroBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FechaFiltro = new System.Windows.Forms.DateTimePicker();
            this.ValorTotalText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TotalText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NoIdentificacion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 178);
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
            this.label5.Location = new System.Drawing.Point(109, 219);
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
            this.TipoBox.Items.AddRange(new object[] {
            "NiñosFelices",
            "DiscapacitadosActivos",
            "AncianosConCorazon"});
            this.TipoBox.Location = new System.Drawing.Point(221, 67);
            this.TipoBox.Name = "TipoBox";
            this.TipoBox.Size = new System.Drawing.Size(121, 21);
            this.TipoBox.TabIndex = 9;
            // 
            // GuardarBton
            // 
            this.GuardarBton.Location = new System.Drawing.Point(429, 209);
            this.GuardarBton.Name = "GuardarBton";
            this.GuardarBton.Size = new System.Drawing.Size(75, 23);
            this.GuardarBton.TabIndex = 10;
            this.GuardarBton.Text = "Guardar";
            this.GuardarBton.UseVisualStyleBackColor = true;
            this.GuardarBton.Click += new System.EventHandler(this.GuardarBton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(56, 302);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 185);
            this.dataGridView1.TabIndex = 11;
            // 
            // ConsultarBton
            // 
            this.ConsultarBton.Location = new System.Drawing.Point(616, 255);
            this.ConsultarBton.Name = "ConsultarBton";
            this.ConsultarBton.Size = new System.Drawing.Size(75, 23);
            this.ConsultarBton.TabIndex = 12;
            this.ConsultarBton.Text = "Consultar";
            this.ConsultarBton.UseVisualStyleBackColor = true;
            this.ConsultarBton.Click += new System.EventHandler(this.ConsultarBton_Click);
            // 
            // FiltroBox
            // 
            this.FiltroBox.FormattingEnabled = true;
            this.FiltroBox.Items.AddRange(new object[] {
            "NiñosFelices",
            "DiscapacitadosActivos",
            "AncianosConCorazon"});
            this.FiltroBox.Location = new System.Drawing.Point(221, 255);
            this.FiltroBox.Name = "FiltroBox";
            this.FiltroBox.Size = new System.Drawing.Size(121, 21);
            this.FiltroBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "FiltrarTipo:";
            // 
            // FechaFiltro
            // 
            this.FechaFiltro.Location = new System.Drawing.Point(382, 255);
            this.FechaFiltro.Name = "FechaFiltro";
            this.FechaFiltro.Size = new System.Drawing.Size(200, 20);
            this.FechaFiltro.TabIndex = 15;
            // 
            // ValorTotalText
            // 
            this.ValorTotalText.Location = new System.Drawing.Point(190, 528);
            this.ValorTotalText.Name = "ValorTotalText";
            this.ValorTotalText.Size = new System.Drawing.Size(100, 20);
            this.ValorTotalText.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 531);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "ValorDonadoTotal:";
            // 
            // TotalText
            // 
            this.TotalText.Location = new System.Drawing.Point(454, 528);
            this.TotalText.Name = "TotalText";
            this.TotalText.Size = new System.Drawing.Size(100, 20);
            this.TotalText.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(351, 531);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "TotalTipo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 560);
            this.Controls.Add(this.TotalText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ValorTotalText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FechaFiltro);
            this.Controls.Add(this.FiltroBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ConsultarBton);
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
        private System.Windows.Forms.Button ConsultarBton;
        private System.Windows.Forms.ComboBox FiltroBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker FechaFiltro;
        private System.Windows.Forms.TextBox ValorTotalText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TotalText;
        private System.Windows.Forms.Label label8;
    }
}

