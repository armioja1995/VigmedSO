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
    
    public partial class ticketdetalle
    {
        public string v_TicketDetalleId { get; set; }
        public string v_TicketId { get; set; }
        public string v_Descripcion { get; set; }
        public string v_IdProductoDetalle { get; set; }
        public string v_CodInterno { get; set; }
        public Nullable<decimal> d_Cantidad { get; set; }
        public Nullable<decimal> d_PrecioVenta { get; set; }
        public Nullable<decimal> d_SaldoPaciente { get; set; }
        public Nullable<decimal> d_SaldoAseguradora { get; set; }
        public Nullable<int> i_EsDespachado { get; set; }
        public string v_IdUnidadProductiva { get; set; }
        public Nullable<int> i_IsDeleted { get; set; }
        public Nullable<int> i_InsertUserId { get; set; }
        public Nullable<System.DateTime> d_InsertDate { get; set; }
        public Nullable<int> i_UpdateUserId { get; set; }
        public Nullable<System.DateTime> d_UpdateDate { get; set; }
        public string v_ComentaryUpdate { get; set; }
    
        public virtual ticket ticket { get; set; }
    }
}
