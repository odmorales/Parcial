using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.IO;


namespace DAL
{
    public class DonacionRepository
    {
        private string ruta = "Donaciones.txt";
        private IList<Donacion> lista;
        public DonacionRepository()
        {
            lista = new List<Donacion>();
        }
        public void Guardar(Donacion donacion)
        {
            FileStream fileStream = new FileStream(ruta, FileMode.Append);
            StreamWriter escritor = new StreamWriter(fileStream);

            escritor.WriteLine($"{donacion.Tipo};{donacion.NumeroIdentificacion};{donacion.Nombre};" +
                $"{donacion.FechaPago.ToString("dd/MM/yyyy")};{donacion.ValorDonado}");

            escritor.Close();
            fileStream.Close();
        }
        public IList<Donacion> Consultar()
        {
            
            FileStream fileStream = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader leer = new StreamReader(fileStream);

            string Linea = string.Empty;
            Linea = leer.ReadLine();

            while ((Linea = leer.ReadLine()) != null)
            {
                Mapear(Linea);
            }

            leer.Close();
            fileStream.Close();

            return lista;
        }

        private void Mapear(string Linea)
        {
            char delimiter = ';';
            string[] Datos = Linea.Split(delimiter);
            Donacion donacion = new Donacion();

            donacion.Tipo = Datos[0];
            donacion.NumeroIdentificacion = Datos[1];
            donacion.Nombre = Datos[2];
            donacion.FechaPago = Convert.ToDateTime(Datos[3]);
            donacion.ValorDonado = Convert.ToDouble(Datos[4]);

            lista.Add(donacion);
        }
        public int ContarPortipo(string tipo)
        {
            lista = Consultar();

           return lista.Count(t => t.Tipo.Equals(tipo));
        }
        public double SumarValorPortipo(string tipo)
        {
            lista = Consultar();

           return lista.Where(d => d.Tipo.Equals(tipo)).Sum(d => d.ValorDonado);
        }
        public IList<Donacion> ConsultarPorTipo(string tipo)
        {
            lista = Consultar();
            return lista.Where(t => t.Tipo.Equals(tipo)).ToList();
        }
        public IList<Donacion> ConsultarPorFecha(int dia,int mes, int año)
        {
            lista = Consultar();
            return lista.Where(l => ((l.FechaPago.Day) == dia && (l.FechaPago.Month == mes) && (l.FechaPago.Year == año))).ToList();
        }
    }
}
