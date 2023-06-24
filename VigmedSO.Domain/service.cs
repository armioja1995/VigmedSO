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
    
    public partial class service
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public service()
        {
            this.auxiliaryexam = new HashSet<auxiliaryexam>();
            this.calendar = new HashSet<calendar>();
            this.diagnosticrepository = new HashSet<diagnosticrepository>();
            this.DigitalContactCenter = new HashSet<DigitalContactCenter>();
            this.medication = new HashSet<medication>();
            this.procedurebyservice = new HashSet<procedurebyservice>();
            this.recommendation = new HashSet<recommendation>();
            this.restriction = new HashSet<restriction>();
            this.servicecomponent = new HashSet<servicecomponent>();
            this.vigilanciaservice = new HashSet<vigilanciaservice>();
            this.servicemultimedia = new HashSet<servicemultimedia>();
        }
    
        public string v_ServiceId { get; set; }
        public string v_ProtocolId { get; set; }
        public string v_PersonId { get; set; }
        public Nullable<int> i_MasterServiceId { get; set; }
        public Nullable<int> i_ServiceStatusId { get; set; }
        public string v_Motive { get; set; }
        public Nullable<int> i_AptitudeStatusId { get; set; }
        public Nullable<System.DateTime> d_ServiceDate { get; set; }
        public Nullable<System.DateTime> d_GlobalExpirationDate { get; set; }
        public Nullable<System.DateTime> d_ObsExpirationDate { get; set; }
        public Nullable<int> i_FlagAgentId { get; set; }
        public string v_OrganizationId { get; set; }
        public string v_LocationId { get; set; }
        public string v_MainSymptom { get; set; }
        public Nullable<int> i_TimeOfDisease { get; set; }
        public Nullable<int> i_TimeOfDiseaseTypeId { get; set; }
        public string v_Story { get; set; }
        public Nullable<int> i_DreamId { get; set; }
        public Nullable<int> i_UrineId { get; set; }
        public Nullable<int> i_DepositionId { get; set; }
        public Nullable<int> i_AppetiteId { get; set; }
        public Nullable<int> i_ThirstId { get; set; }
        public Nullable<System.DateTime> d_Fur { get; set; }
        public string v_CatemenialRegime { get; set; }
        public Nullable<int> i_MacId { get; set; }
        public Nullable<int> i_IsNewControl { get; set; }
        public Nullable<int> i_HasMedicalBreakId { get; set; }
        public Nullable<System.DateTime> d_MedicalBreakStartDate { get; set; }
        public Nullable<System.DateTime> d_MedicalBreakEndDate { get; set; }
        public string v_GeneralRecomendations { get; set; }
        public Nullable<int> i_DestinationMedicationId { get; set; }
        public Nullable<int> i_TransportMedicationId { get; set; }
        public Nullable<System.DateTime> d_StartDateRestriction { get; set; }
        public Nullable<System.DateTime> d_EndDateRestriction { get; set; }
        public Nullable<int> i_HasRestrictionId { get; set; }
        public Nullable<int> i_HasSymptomId { get; set; }
        public Nullable<System.DateTime> d_UpdateDate { get; set; }
        public Nullable<System.DateTime> d_NextAppointment { get; set; }
        public Nullable<int> i_IsDeleted { get; set; }
        public Nullable<int> i_InsertUserId { get; set; }
        public Nullable<System.DateTime> d_InsertDate { get; set; }
        public Nullable<int> i_UpdateUserId { get; set; }
        public Nullable<int> i_SendToTracking { get; set; }
        public Nullable<int> i_InsertUserMedicalAnalystId { get; set; }
        public Nullable<int> i_UpdateUserMedicalAnalystId { get; set; }
        public Nullable<System.DateTime> d_InsertDateMedicalAnalyst { get; set; }
        public Nullable<System.DateTime> d_UpdateDateMedicalAnalyst { get; set; }
        public Nullable<int> i_InsertUserOccupationalMedicalId { get; set; }
        public Nullable<int> i_UpdateUserOccupationalMedicaltId { get; set; }
        public Nullable<System.DateTime> d_InsertDateOccupationalMedical { get; set; }
        public Nullable<System.DateTime> d_UpdateDateOccupationalMedical { get; set; }
        public Nullable<int> i_HazInterconsultationId { get; set; }
        public string v_Gestapara { get; set; }
        public string v_Menarquia { get; set; }
        public Nullable<System.DateTime> d_PAP { get; set; }
        public Nullable<System.DateTime> d_Mamografia { get; set; }
        public string v_CiruGine { get; set; }
        public string v_Findings { get; set; }
        public Nullable<int> i_StatusLiquidation { get; set; }
        public Nullable<int> i_ServiceTypeOfInsurance { get; set; }
        public Nullable<int> i_ModalityOfInsurance { get; set; }
        public Nullable<int> i_IsFac { get; set; }
        public Nullable<int> i_InicioEnf { get; set; }
        public Nullable<int> i_CursoEnf { get; set; }
        public Nullable<int> i_Evolucion { get; set; }
        public string v_ExaAuxResult { get; set; }
        public string v_ObsStatusService { get; set; }
        public Nullable<System.DateTime> d_FechaEntrega { get; set; }
        public string v_AreaId { get; set; }
        public string v_FechaUltimoPAP { get; set; }
        public string v_ResultadosPAP { get; set; }
        public string v_FechaUltimaMamo { get; set; }
        public string v_ResultadoMamo { get; set; }
        public Nullable<decimal> r_Costo { get; set; }
        public Nullable<int> i_EnvioCertificado { get; set; }
        public Nullable<int> i_EnvioHistoria { get; set; }
        public string v_IdVentaCliente { get; set; }
        public string v_IdVentaAseguradora { get; set; }
        public string v_InicioVidaSexaul { get; set; }
        public string v_NroParejasActuales { get; set; }
        public string v_NroAbortos { get; set; }
        public string v_PrecisarCausas { get; set; }
        public Nullable<int> i_MedicoTratanteId { get; set; }
        public Nullable<int> i_IsFacMedico { get; set; }
        public string v_centrocosto { get; set; }
        public string v_NroLiquidacion { get; set; }
        public Nullable<int> i_MedicoPagado { get; set; }
        public Nullable<int> i_PagoEspecialista { get; set; }
        public Nullable<int> i_IsControl { get; set; }
        public Nullable<int> i_IsRevisedHistoryId { get; set; }
        public Nullable<int> i_StatusVigilanciaId { get; set; }
        public string v_NroCartaSolicitud { get; set; }
        public string v_ComentaryUpdate { get; set; }
        public Nullable<int> i_PlanId { get; set; }
        public Nullable<int> i_AptitudesStatusId_First { get; set; }
        public string v_CommentAptitusStatus_First { get; set; }
        public string v_ComprobantePago { get; set; }
        public Nullable<int> i_ServiceUserId { get; set; }
        public string v_Area { get; set; }
        public string v_ComprobantePago_Anulado { get; set; }
        public Nullable<int> i_TramaCargada { get; set; }
        public string v_Puesto { get; set; }
        public string v_Cargo { get; set; }
        public Nullable<int> i_AltamedicaCovid19_1 { get; set; }
        public Nullable<int> i_AltamedicaCovid19_2 { get; set; }
        public Nullable<int> i_AltaMedica { get; set; }
        public string v_LicenciaConducir { get; set; }
        public string v_ObservacionesAdicionales { get; set; }
        public Nullable<System.DateTime> d_MacInicio { get; set; }
        public Nullable<System.DateTime> d_MacFin { get; set; }
        public Nullable<int> i_RelacionesS { get; set; }
        public Nullable<int> i_Fertilidad { get; set; }
        public string v_Fertilidad { get; set; }
        public Nullable<int> i_Dismenorrea { get; set; }
        public Nullable<int> i_Dispareunia { get; set; }
        public Nullable<int> i_Coitorragia { get; set; }
        public Nullable<int> i_Disquesia { get; set; }
        public string v_FUP { get; set; }
        public Nullable<int> i_TipoFUP { get; set; }
        public string v_VolumenRC { get; set; }
        public Nullable<int> i_ModTrabajo { get; set; }
        public Nullable<int> i_ProcedenciaPac_Mkt { get; set; }
        public Nullable<int> i_MedicoSolicitanteExterno { get; set; }
        public Nullable<int> i_Establecimiento { get; set; }
        public Nullable<int> i_VendedorExterno { get; set; }
        public Nullable<int> i_MedicoDerivado { get; set; }
        public Nullable<int> i_MedicoAtencion { get; set; }
        public Nullable<int> i_CodigoAtencion { get; set; }
        public Nullable<int> i_GrupoAtencion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<auxiliaryexam> auxiliaryexam { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<calendar> calendar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<diagnosticrepository> diagnosticrepository { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DigitalContactCenter> DigitalContactCenter { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<medication> medication { get; set; }
        public virtual person person { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<procedurebyservice> procedurebyservice { get; set; }
        public virtual protocol protocol { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<recommendation> recommendation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<restriction> restriction { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<servicecomponent> servicecomponent { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<vigilanciaservice> vigilanciaservice { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<servicemultimedia> servicemultimedia { get; set; }
    }
}
