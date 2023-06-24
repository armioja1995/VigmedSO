using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using VigmedSO.Domain.Generado;
using VigmedSO.Interfaces;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data;
using System.Data.Entity;
using System.Net;
using VigmedSO.Repository;

namespace VigmedSO.Controllers
{
    public class GraficoController : Controller
    {
        private PersonaInterface repositorio;
        public GraficoController(PersonaInterface repositorio)
        {
            this.repositorio = repositorio;
        }
        // GET: Grafico
        public ActionResult Index()
        {
            //var list = repositorio.AllPerson();
            //List<int> sexo_ty = new List<int>();
            //List<int> sexo_masc = new List<int>();
            //List<int> sexo_fem = new List<int>();
            //var sexos_TEXT = list.Select(x => x.i_TipoSexo == 1?"MASC":"FEM").Distinct();
            //var sexos = list.Select(x => x.i_TipoSexo).Distinct();

            //foreach (var item in sexos)
            //{
            //    sexo_ty.Add(list.Count(x => x.i_TipoSexo == item));
            //    if (item == 1)
            //    {
            //        sexo_masc.Add(list.Count(x => x.i_TipoSexo == 1));
            //    }
            //    if (item == 2)
            //    {
            //        sexo_fem.Add(list.Count(x => x.i_TipoSexo == 2));
            //    }
            //}
            //var sex = sexo_ty;
            //var sex_mas = sexo_masc;
            //var sex_fem = sexo_fem;

            //ViewBag.Sexos = sexos_TEXT;
            //ViewBag.Listas = sex.ToList();

            //ViewBag.Msc = sex_mas.ToList();
            //ViewBag.Fem = sex_fem.ToList();

            return View();
        }
    }
}