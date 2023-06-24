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
    
    public partial class Servicio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Servicio()
        {
            this.Audiometria = new HashSet<Audiometria>();
            this.Cardiologia = new HashSet<Cardiologia>();
            this.Espirometria = new HashSet<Espirometria>();
            this.Laboratorio = new HashSet<Laboratorio>();
            this.Medicina = new HashSet<Medicina>();
            this.Odontologia = new HashSet<Odontologia>();
            this.Oftalmologia = new HashSet<Oftalmologia>();
            this.Psicologia = new HashSet<Psicologia>();
            this.Psicosensometrico = new HashSet<Psicosensometrico>();
            this.RayosX = new HashSet<RayosX>();
            this.Riesgos = new HashSet<Riesgos>();
            this.Triaje = new HashSet<Triaje>();
        }
    
        public string v_ServicioId { get; set; }
        public string v_PersonaId { get; set; }
        public Nullable<int> i_TipoExamen { get; set; }
        public string v_NombreExamen { get; set; }
        public Nullable<System.DateTime> d_FechaExamen { get; set; }
        public byte[] v_Ocupacion { get; set; }
        public string v_EmpresaTrabajo { get; set; }
        public string v_Contrata { get; set; }
        public string v_ClinicaExamen { get; set; }
        public string v_Diagnosticos { get; set; }
        public string v_Recomendaciones { get; set; }
        public string v_Restricciones { get; set; }
        public Nullable<int> i_Aptitud { get; set; }
        public string v_MotivoObservacion { get; set; }
        public Nullable<System.DateTime> d_FechaVigencia { get; set; }
        public Nullable<System.DateTime> d_FechaInsercion { get; set; }
        public Nullable<int> i_UsuarioInsertaId { get; set; }
        public Nullable<System.DateTime> d_FechaActualizacion { get; set; }
        public Nullable<int> i_UsuarioActualizaId { get; set; }
        public Nullable<bool> i_EsEliminado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Audiometria> Audiometria { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cardiologia> Cardiologia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Espirometria> Espirometria { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Laboratorio> Laboratorio { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Medicina> Medicina { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Odontologia> Odontologia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Oftalmologia> Oftalmologia { get; set; }
        public virtual Persona Persona { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Psicologia> Psicologia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Psicosensometrico> Psicosensometrico { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RayosX> RayosX { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Riesgos> Riesgos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Triaje> Triaje { get; set; }
    }
}