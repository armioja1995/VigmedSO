using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VigmedSO.Domain;
using VigmedSO.Interfaces;

namespace VigmedSO.Repository
{
    public class HojaReclamoRepositorio : HojaReclamoInterface
    {
        SigesoftDesarrollo_2Entities1 entidades;

        public HojaReclamoRepositorio(SigesoftDesarrollo_2Entities1 _entidades)
        {
            this.entidades = _entidades;    
        }

        public void AddHojaReclamo(HojaReclamo _hojaReclamo)
        {
            entidades.HojaReclamo.Add(_hojaReclamo);
            entidades.SaveChanges();
        }

        public List<HojaReclamo> AllHojaReclamo()
        {
            var result = from p in entidades.HojaReclamo select p;
            return result.ToList();
        }

        public void DeleteAlumno(string _hojaReclamoid)
        {
            var existe = entidades.HojaReclamo.Find(_hojaReclamoid);
            if (existe != null)
            {
                entidades.HojaReclamo.Remove(existe);
                entidades.SaveChanges();
            }
        }

        public void UpdateAlumno(HojaReclamo _hojaReclamo)
        {
            entidades.Entry(_hojaReclamo).State = EntityState.Modified;
            entidades.SaveChanges();
        }
    }
}
