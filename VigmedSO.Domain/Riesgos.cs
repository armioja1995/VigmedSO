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
    using System.Collections.Generic;
    
    public partial class Riesgos
    {
        public string v_RiesgoId { get; set; }
        public string v_ServicioId { get; set; }
        public Nullable<bool> b_Ruido { get; set; }
        public Nullable<bool> b_Polvo { get; set; }
        public Nullable<bool> b_VidaSedentaria { get; set; }
        public Nullable<bool> b_VibTotal { get; set; }
        public Nullable<bool> b_Cancerigenos { get; set; }
        public Nullable<bool> b_Mutagenicos { get; set; }
        public Nullable<bool> b_Solventes { get; set; }
        public Nullable<bool> b_MetalPesado { get; set; }
        public Nullable<bool> b_Temperatura { get; set; }
        public Nullable<bool> b_Biologicos { get; set; }
        public Nullable<bool> b_Posturas { get; set; }
        public Nullable<bool> b_Turnos { get; set; }
        public Nullable<bool> b_Cargas { get; set; }
        public Nullable<bool> b_MovimientosRepetitivos { get; set; }
        public Nullable<bool> b_PantallaPVD { get; set; }
        public Nullable<bool> b_Otros { get; set; }
        public string i_Descripcion { get; set; }
        public Nullable<System.DateTime> d_FechaInsercion { get; set; }
        public Nullable<int> i_UsuarioInsertaId { get; set; }
        public Nullable<System.DateTime> d_FechaActualizacion { get; set; }
        public Nullable<int> i_UsuarioActualizaId { get; set; }
        public Nullable<bool> i_EsEliminado { get; set; }
    
        public virtual Servicio Servicio { get; set; }
    }
}
