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
        List<Donacion> lista;
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

        private void ConsultarBton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            lista = new List<Donacion>();
            donacionService = new DonacionService();
            donacion = new Donacion();
            if (FiltroBox.Text.Equals("NiñosFelices"))
            {
                TotalText.Text = donacionService.ContarPorTipo(FechaFiltro.Value.Day, FechaFiltro.Value.Month, FechaFiltro.Value.Year, "NiñosFelices").ToString();
                ValorTotalText.Text = donacionService.SumarValorPortipo(FechaFiltro.Value.Day, FechaFiltro.Value.Month, FechaFiltro.Value.Year, "NiñosFelices").ToString();
                donacionService.GuardarFiltro(donacionService.ConsultarPorFecha(FechaFiltro.Value.Day, FechaFiltro.Value.Month, FechaFiltro.Value.Year, "NiñosFelices"), "NiñosFelices", FechaFiltro.Value.Date.ToString(), Convert.ToDouble(ValorTotalText.Text), Convert.ToInt32(TotalText.Text));
            }
            else if (FiltroBox.Text.Equals("DiscapacitadosActivos"))
            {
                dataGridView1.DataSource = donacionService.ConsultarPorFecha(FechaFiltro.Value.Day, FechaFiltro.Value.Month, FechaFiltro.Value.Year, "DiscapacitadosActivos");
                TotalText.Text = donacionService.ContarPorTipo(FechaFiltro.Value.Day, FechaFiltro.Value.Month, FechaFiltro.Value.Year, "NiñosFelices").ToString();
                ValorTotalText.Text = donacionService.SumarValorPortipo(FechaFiltro.Value.Day, FechaFiltro.Value.Month, FechaFiltro.Value.Year, "NiñosFelices").ToString();
            }
            else
            {
                dataGridView1.DataSource = donacionService.ConsultarPorFecha(FechaFiltro.Value.Day, FechaFiltro.Value.Month, FechaFiltro.Value.Year, "AncianosConCorazon");
                TotalText.Text = donacionService.ContarPorTipo(FechaFiltro.Value.Day, FechaFiltro.Value.Month, FechaFiltro.Value.Year, "NiñosFelices").ToString();
                ValorTotalText.Text = donacionService.SumarValorPortipo(FechaFiltro.Value.Day, FechaFiltro.Value.Month, FechaFiltro.Value.Year, "NiñosFelices").ToString();
            }
        }
    }
}
