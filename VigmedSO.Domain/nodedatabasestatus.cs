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
    
    public partial class nodedatabasestatus
    {
        public int i_NodeId { get; set; }
        public string v_CurrentDatabaseVersion { get; set; }
        public string v_PreviousDatabaseVersion { get; set; }
        public Nullable<int> i_CurrentDatabaseStatus { get; set; }
        public Nullable<System.DateTime> d_LastDatabaseUpgrade { get; set; }
        public Nullable<System.DateTime> d_LastDatabaseDataSync { get; set; }
        public string v_ComentaryUpdate { get; set; }
    }
}