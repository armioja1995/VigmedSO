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
    
    public partial class GetServiceComponentsReportC_SP_Result
    {
        public string v_ComponentId { get; set; }
        public string v_ComponentName { get; set; }
        public string v_ServiceComponentId { get; set; }
        public string v_CreationUser { get; set; }
        public string v_UpdateUser { get; set; }
        public Nullable<System.DateTime> d_CreationDate { get; set; }
        public Nullable<System.DateTime> d_UpdateDate { get; set; }
        public Nullable<int> i_IsDeleted { get; set; }
        public Nullable<int> i_CategoryId { get; set; }
        public string v_CategoryName { get; set; }
        public Nullable<int> i_ServiceComponentStatusId { get; set; }
        public byte[] FirmaMedico { get; set; }
    }
}
