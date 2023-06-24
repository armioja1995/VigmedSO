using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VigmedSO.Domain;

namespace VigmedSO.Interfaces
{
    public interface HojaReclamoInterface
    {
        void AddHojaReclamo(HojaReclamo _hojaReclamo);

        void UpdateAlumno(HojaReclamo _hojaReclamo);

        void DeleteAlumno(string _hojaReclamoid);

        List<HojaReclamo> AllHojaReclamo();

    }
}
