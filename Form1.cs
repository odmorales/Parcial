using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BLL;

namespace Parcial2
{
    public partial class Form1 : Form
    {
        Donacion donacion;
        DonacionService donacionService;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GuardarBton_Click(object sender, EventArgs e)
        {
            donacionService = new DonacionService();
            donacion = new Donacion();

            donacion.Tipo = TipoBox.Text;
            donacion.NumeroIdentificacion = NoIdentificacionText.Text;
            donacion.Nombre = NombreText.Text;
            donacion.FechaPago = FechaPago.Value.Date;
            donacion.ValorDonado = Convert.ToDouble(ValorDonadoText.Text);
            donacionService.Guardar(donacion);
        }
    }
}
