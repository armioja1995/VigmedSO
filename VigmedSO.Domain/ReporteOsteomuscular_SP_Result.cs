//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VigmedSO.Domain
{
    using System;
    
    public partial class ReporteOsteomuscular_SP_Result
    {
        public string Trabajador { get; set; }
        public Nullable<System.DateTime> FechaNacimiento { get; set; }
        public Nullable<System.DateTime> FechaEvaluacion { get; set; }
        public string Puesto { get; set; }
        public string ServicioId { get; set; }
        public byte[] FirmaUsuarioGraba { get; set; }
        public string NombreUsuarioGraba { get; set; }
        public byte[] HuellaTrabajador { get; set; }
        public byte[] FirmaTrabajador { get; set; }
        public string TipoEso { get; set; }
        public string Dni { get; set; }
        public Nullable<int> Edad { get; set; }
    }
}
