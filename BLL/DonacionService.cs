using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class DonacionService
    {
        DonacionRepository donacionRepository;
        
        public DonacionService()
        {
            donacionRepository = new DonacionRepository();
        }
        public void Guardar(Donacion donacion)
        {
            donacionRepository.Guardar(donacion);
        }
        public IList<Donacion> Consultar()
        {
            return donacionRepository.Consultar();
        }

       
        public int ContarPortipo(string tipo)
        {
            return donacionRepository.ContarPortipo(tipo);
        }
        public double SumarValorPortipo(string tipo)
        {
            return donacionRepository.SumarValorPortipo(tipo);
        }
        public IList<Donacion> ConsultarPorTipo(string tipo)
        {
            return donacionRepository.ConsultarPorTipo(tipo);
        }
        public IList<Donacion> ConsultarPorFecha(int dia, int mes, int año)
        {
            return donacionRepository.ConsultarPorFecha(dia, mes, año);
        }
    }
}
