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
    
    public partial class product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public product()
        {
            this.movementdetail = new HashSet<movementdetail>();
            this.productwarehouse = new HashSet<productwarehouse>();
        }
    
        public string v_ProductId { get; set; }
        public Nullable<int> i_CategoryId { get; set; }
        public string v_Name { get; set; }
        public string v_GenericName { get; set; }
        public string v_BarCode { get; set; }
        public string v_ProductCode { get; set; }
        public string v_Brand { get; set; }
        public string v_Model { get; set; }
        public string v_SerialNumber { get; set; }
        public Nullable<System.DateTime> d_ExpirationDate { get; set; }
        public Nullable<int> i_MeasurementUnitId { get; set; }
        public Nullable<float> r_ReferentialCostPrice { get; set; }
        public Nullable<float> r_ReferentialSalesPrice { get; set; }
        public string v_Presentation { get; set; }
        public string v_AdditionalInformation { get; set; }
        public byte[] b_Image { get; set; }
        public Nullable<int> i_IsDeleted { get; set; }
        public Nullable<int> i_InsertUserId { get; set; }
        public Nullable<System.DateTime> d_InsertDate { get; set; }
        public Nullable<int> i_UpdateUserId { get; set; }
        public Nullable<System.DateTime> d_UpdateDate { get; set; }
        public string v_ComentaryUpdate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<movementdetail> movementdetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<productwarehouse> productwarehouse { get; set; }
    }
}