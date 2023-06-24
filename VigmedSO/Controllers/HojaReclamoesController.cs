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
    public class HojaReclamoesController : Controller
    {
        private SigesoftDesarrollo_2Entities1 db = new SigesoftDesarrollo_2Entities1();

        // GET: HojaReclamoes
        public ActionResult Index()
        {
            var hojaReclamo = db.HojaReclamo.Include(h => h.person);
            return View(hojaReclamo.ToList());
        }

        // GET: HojaReclamoes/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HojaReclamo hojaReclamo = db.HojaReclamo.Find(id);
            if (hojaReclamo == null)
            {
                return HttpNotFound();
            }
            return View(hojaReclamo);
        }

        // GET: HojaReclamoes/Create
        public ActionResult Create()
        {
            ViewBag.v_IdPaciente = new SelectList(db.person, "v_PersonId", "v_FirstName");
            return View();
        }

        // POST: HojaReclamoes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "v_IdHojaReclamo,i_CorrelativoReclamo,d_fechaR,v_IdPaciente,i_Parentesco,i_Producto,i_Servicio,v_MontoReclamo,v_Descripcion,i_Reclamo,i_Queja,v_Detalle,v_Pedido,b_FirmaConsumidor,d_FechaComunicacionRespuesta,b_FirmaProveedor,i_IsDeleted,i_InsertUserId,d_InsertDate,i_UpdateUserId,d_UpdateDate,v_ComentaryRegistros")] HojaReclamo hojaReclamo)
        {
            if (ModelState.IsValid)
            {
                db.HojaReclamo.Add(hojaReclamo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.v_IdPaciente = new SelectList(db.person, "v_PersonId", "v_FirstName", hojaReclamo.v_IdPaciente);
            return View(hojaReclamo);
        }

        // GET: HojaReclamoes/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HojaReclamo hojaReclamo = db.HojaReclamo.Find(id);
            if (hojaReclamo == null)
            {
                return HttpNotFound();
            }
            ViewBag.v_IdPaciente = new SelectList(db.person, "v_PersonId", "v_FirstName", hojaReclamo.v_IdPaciente);
            return View(hojaReclamo);
        }

        // POST: HojaReclamoes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "v_IdHojaReclamo,i_CorrelativoReclamo,d_fechaR,v_IdPaciente,i_Parentesco,i_Producto,i_Servicio,v_MontoReclamo,v_Descripcion,i_Reclamo,i_Queja,v_Detalle,v_Pedido,b_FirmaConsumidor,d_FechaComunicacionRespuesta,b_FirmaProveedor,i_IsDeleted,i_InsertUserId,d_InsertDate,i_UpdateUserId,d_UpdateDate,v_ComentaryRegistros")] HojaReclamo hojaReclamo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hojaReclamo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.v_IdPaciente = new SelectList(db.person, "v_PersonId", "v_FirstName", hojaReclamo.v_IdPaciente);
            return View(hojaReclamo);
        }

        // GET: HojaReclamoes/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HojaReclamo hojaReclamo = db.HojaReclamo.Find(id);
            if (hojaReclamo == null)
            {
                return HttpNotFound();
            }
            return View(hojaReclamo);
        }

        // POST: HojaReclamoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            HojaReclamo hojaReclamo = db.HojaReclamo.Find(id);
            db.HojaReclamo.Remove(hojaReclamo);
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
