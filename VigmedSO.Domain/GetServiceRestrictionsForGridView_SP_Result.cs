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
    
    public partial class GetServiceRestrictionsForGridView_SP_Result
    {
        public string v_DiagnosticRepositoryId { get; set; }
        public string v_RestrictionByDiagnosticId { get; set; }
        public string v_MasterRestrictionId { get; set; }
        public string v_RestrictionName { get; set; }
        public string v_ComponentId { get; set; }
        public int i_RecordStatus { get; set; }
        public int i_RecordType { get; set; }
        public Nullable<System.DateTime> d_StartDateRestriction { get; set; }
        public Nullable<System.DateTime> d_EndDateRestriction { get; set; }
    }
}
