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


        public double SumarValorPortipo(int dia, int mes, int año, string tipo)
        {
            return donacionRepository.SumarValorPortipo(dia, mes, año, tipo);
        }
        public int ContarPorTipo(int dia, int mes, int año, string tipo)
        {
            return donacionRepository.ContarPorTipo(dia, mes, año, tipo);
        }
        public IList<Donacion> ConsultarPorFecha(int dia, int mes, int año,string tipo)
        {
            return donacionRepository.ConsultarPorFecha(dia, mes, año,tipo);
        }
    }
}
