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
    
    public partial class hospitalizacionCheckList
    {
        public string v_HospitalizacionCheckListId { get; set; }
        public string v_HopitalizacionId { get; set; }
        public Nullable<int> i_Epicrisis { get; set; }
        public string v_Epicrisis { get; set; }
        public Nullable<int> i_Kardex { get; set; }
        public string v_Kardex { get; set; }
        public Nullable<int> i_RegistroClinico { get; set; }
        public string v_RegistroClinico { get; set; }
        public Nullable<int> i_AtencionMedicaHCL { get; set; }
        public string v_AtencionMedicaHCL { get; set; }
        public Nullable<int> i_Evolucion { get; set; }
        public string v_Evolucion { get; set; }
        public Nullable<int> i_Indicaciones { get; set; }
        public string v_Indicaciones { get; set; }
        public Nullable<int> i_ExamenesAuxiliares { get; set; }
        public string v_ExamenesAuxiliares { get; set; }
        public Nullable<int> i_NotasEnfermeria { get; set; }
        public string v_NotasEnfermeria { get; set; }
        public Nullable<int> i_ConsentimientoInformado { get; set; }
        public string v_ConsentimientoInformado { get; set; }
        public Nullable<int> i_HojaSegura { get; set; }
        public string v_HojaSegura { get; set; }
        public Nullable<int> i_PrePosAnestesia { get; set; }
        public string v_PrePosAnestesia { get; set; }
        public Nullable<int> i_RegistroAnestesia { get; set; }
        public string v_RegistroAnestesia { get; set; }
        public Nullable<int> i_ReporteOperatorio { get; set; }
        public string v_ReporteOperatorio { get; set; }
        public Nullable<int> i_HojaPaes { get; set; }
        public string v_HojaPaes { get; set; }
        public Nullable<int> i_AutorizacionHospitalizacion { get; set; }
        public string v_AutorizacionHospitalizacion { get; set; }
        public Nullable<int> i_OtrosAnexos { get; set; }
        public string v_OtrosAnexos { get; set; }
        public Nullable<int> i_IsDeleted { get; set; }
        public Nullable<int> i_InsertUserId { get; set; }
        public Nullable<System.DateTime> d_InsertDate { get; set; }
        public Nullable<int> i_UpdateUserId { get; set; }
        public Nullable<System.DateTime> d_UpdateDate { get; set; }
        public string v_ComentaryUpdate { get; set; }
    
        public virtual hospitalizacion hospitalizacion { get; set; }
    }
}
