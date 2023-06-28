using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VigmedSO.Domain;

namespace VigmedSO.Controllers
{
    public class PersonController : Controller
    {
        private SigesoftDesarrollo_2Entities1 db = new SigesoftDesarrollo_2Entities1();

        // GET: Person
        public ActionResult Index()
        {
            var person = db.person.Include(p => p.pacient).Include(p => p.professional);
            return View(person.ToList());
        }

        // GET: Person/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            person person = db.person.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }

        // GET: Person/Create
        public ActionResult Create()
        {
            ViewBag.v_PersonId = new SelectList(db.pacient, "v_PersonId", "v_ComentaryUpdate");
            ViewBag.v_PersonId = new SelectList(db.professional, "v_PersonId", "v_ProfessionalCode");
            return View();
        }

        // POST: Person/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "v_PersonId,v_FirstName,v_FirstLastName,v_SecondLastName,i_DocTypeId,v_DocNumber,d_Birthdate,v_BirthPlace,i_SexTypeId,i_MaritalStatusId,i_LevelOfId,v_TelephoneNumber,v_AdressLocation,v_GeografyLocationId,v_ContactName,v_EmergencyPhone,b_PersonImage,v_Mail,i_BloodGroupId,i_BloodFactorId,b_FingerPrintTemplate,b_RubricImage,b_FingerPrintImage,t_RubricImageText,v_CurrentOccupation,i_DepartmentId,i_ProvinceId,i_DistrictId,i_ResidenceInWorkplaceId,v_ResidenceTimeInWorkplace,i_TypeOfInsuranceId,i_NumberLivingChildren,i_NumberDependentChildren,i_OccupationTypeId,v_OwnerName,i_NumberLiveChildren,i_NumberDeadChildren,i_IsDeleted,i_InsertUserId,d_InsertDate,i_UpdateUserId,d_UpdateDate,i_InsertNodeId,i_UpdateNodeId,i_Relationship,v_ExploitedMineral,i_AltitudeWorkId,i_PlaceWorkId,v_NroPoliza,v_Deducible,i_NroHermanos,v_Password,v_Procedencia,v_CentroEducativo,v_Religion,v_Nacionalidad,v_ResidenciaAnterior,v_Subs,v_ComentaryUpdate,v_PhoneContac,i_Marketing,v_ProtocolId,d_ExpirationDate,i_TotalAtenciones,i_CountAtenciones,i_EtniaRaza,i_Migrante,v_Migrante")] person person)
        {
            if (ModelState.IsValid)
            {
                db.person.Add(person);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.v_PersonId = new SelectList(db.pacient, "v_PersonId", "v_ComentaryUpdate", person.v_PersonId);
            ViewBag.v_PersonId = new SelectList(db.professional, "v_PersonId", "v_ProfessionalCode", person.v_PersonId);
            return View(person);
        }

        // GET: Person/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            person person = db.person.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            ViewBag.v_PersonId = new SelectList(db.pacient, "v_PersonId", "v_ComentaryUpdate", person.v_PersonId);
            ViewBag.v_PersonId = new SelectList(db.professional, "v_PersonId", "v_ProfessionalCode", person.v_PersonId);
            return View(person);
        }

        // POST: Person/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "v_PersonId,v_FirstName,v_FirstLastName,v_SecondLastName,i_DocTypeId,v_DocNumber,d_Birthdate,v_BirthPlace,i_SexTypeId,i_MaritalStatusId,i_LevelOfId,v_TelephoneNumber,v_AdressLocation,v_GeografyLocationId,v_ContactName,v_EmergencyPhone,b_PersonImage,v_Mail,i_BloodGroupId,i_BloodFactorId,b_FingerPrintTemplate,b_RubricImage,b_FingerPrintImage,t_RubricImageText,v_CurrentOccupation,i_DepartmentId,i_ProvinceId,i_DistrictId,i_ResidenceInWorkplaceId,v_ResidenceTimeInWorkplace,i_TypeOfInsuranceId,i_NumberLivingChildren,i_NumberDependentChildren,i_OccupationTypeId,v_OwnerName,i_NumberLiveChildren,i_NumberDeadChildren,i_IsDeleted,i_InsertUserId,d_InsertDate,i_UpdateUserId,d_UpdateDate,i_InsertNodeId,i_UpdateNodeId,i_Relationship,v_ExploitedMineral,i_AltitudeWorkId,i_PlaceWorkId,v_NroPoliza,v_Deducible,i_NroHermanos,v_Password,v_Procedencia,v_CentroEducativo,v_Religion,v_Nacionalidad,v_ResidenciaAnterior,v_Subs,v_ComentaryUpdate,v_PhoneContac,i_Marketing,v_ProtocolId,d_ExpirationDate,i_TotalAtenciones,i_CountAtenciones,i_EtniaRaza,i_Migrante,v_Migrante")] person person)
        {
            if (ModelState.IsValid)
            {
                db.Entry(person).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.v_PersonId = new SelectList(db.pacient, "v_PersonId", "v_ComentaryUpdate", person.v_PersonId);
            ViewBag.v_PersonId = new SelectList(db.professional, "v_PersonId", "v_ProfessionalCode", person.v_PersonId);
            return View(person);
        }

        // GET: Person/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            person person = db.person.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }

        // POST: Person/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            person person = db.person.Find(id);
            db.person.Remove(person);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
