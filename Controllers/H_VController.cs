using BookStore.Models.Repo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sonacid.Models;
using Sonacid.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Sonacid.Controllers
{
    public class H_VController : Controller
    {
        private CultureInfo ci = (CultureInfo)CultureInfo.CurrentCulture.Clone();
        
        public IMasse_Lineique_Repo<H_V> HvRepo { get; }

        public H_VController(IMasse_Lineique_Repo<H_V> HvRepo)
        {
            this.HvRepo = HvRepo;
        }
        // GET: H_VController
        public ActionResult Index()
        {

            var Hv = HvRepo.List().ToList();
            float max = 0f;
            float min = 0f;
            if (Hv.Count()!=0)
            {
                max = MaxMesures(Hv);
                min = MinMesures(Hv);
            }
            
            var Lhv = new H_VResultViewModel()
            {
                Max_mesures=max,
                Min_mesures=min,
                HV=Hv

            };
            return View(Lhv);
        }

        // GET: H_VController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: H_VController/Create
        public ActionResult Create()
        {
            var hv = new H_V();
            return View(hv);
        }

        // POST: H_VController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(H_V hv)
        {
            try
            {
                HvRepo.Add(hv);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: H_VController/Edit/5
        public ActionResult Edit(int id)
        {
            var hv = HvRepo.Find(id);
            return View(hv);
        }

        // POST: H_VController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, H_V hv)
        {
            try
            {
                HvRepo.Update(hv, id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: H_VController/Delete/5
        public ActionResult Delete(int id)
        {
           var hv = HvRepo.Find(id);
            return View(hv);
        }

        // POST: H_VController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                HvRepo.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public float MinMesures(List<H_V> hv)
        {
            ci.NumberFormat.NumberDecimalSeparator = ".";
            string x = hv.Min(s => s.Mesures);
            float min = float.Parse(x,ci);
            return min;

        }
        public float MaxMesures(List<H_V> hv)
        {
            string x = hv.Max(s => s.Mesures);
            ci.NumberFormat.NumberDecimalSeparator = ".";
            float max = float.Parse(x,ci);
            return max;

        }
    }
}
