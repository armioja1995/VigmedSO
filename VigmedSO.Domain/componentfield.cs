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
    
    public partial class componentfield
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public componentfield()
        {
            this.componentfields = new HashSet<componentfields>();
            this.componentfieldvalues = new HashSet<componentfieldvalues>();
        }
    
        public string v_ComponentFieldId { get; set; }
        public string v_TextLabel { get; set; }
        public Nullable<int> i_LabelWidth { get; set; }
        public string v_abbreviation { get; set; }
        public string v_DefaultText { get; set; }
        public Nullable<int> i_ControlId { get; set; }
        public Nullable<int> i_GroupId { get; set; }
        public Nullable<int> i_ItemId { get; set; }
        public Nullable<int> i_WidthControl { get; set; }
        public Nullable<int> i_HeightControl { get; set; }
        public Nullable<int> i_MaxLenght { get; set; }
        public Nullable<int> i_IsRequired { get; set; }
        public Nullable<int> i_IsCalculate { get; set; }
        public string v_Formula { get; set; }
        public Nullable<int> i_Order { get; set; }
        public Nullable<int> i_MeasurementUnitId { get; set; }
        public Nullable<float> r_ValidateValue1 { get; set; }
        public Nullable<float> r_ValidateValue2 { get; set; }
        public Nullable<int> i_Column { get; set; }
        public Nullable<int> i_defaultIndex { get; set; }
        public Nullable<int> i_IsDeleted { get; set; }
        public Nullable<int> i_InsertUserId { get; set; }
        public Nullable<System.DateTime> d_InsertDate { get; set; }
        public Nullable<int> i_UpdateUserId { get; set; }
        public Nullable<System.DateTime> d_UpdateDate { get; set; }
        public Nullable<int> i_NroDecimales { get; set; }
        public Nullable<int> i_ReadOnly { get; set; }
        public Nullable<int> i_Enabled { get; set; }
        public string v_ComentaryUpdate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<componentfields> componentfields { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<componentfieldvalues> componentfieldvalues { get; set; }
    }
}
