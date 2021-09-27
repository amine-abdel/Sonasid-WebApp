using BookStore.Models.Repo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sonacid.Models;
using Sonacid.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace Sonacid.Controllers
{
    public class Masse_Lineique_IIController : Controller
    {
        public IMasse_Lineique_Repo<Masse_Lineique_II> MLIIRepo { get; }

        public Masse_Lineique_IIController(IMasse_Lineique_Repo<Masse_Lineique_II> MLIIRepo)
        {
            this.MLIIRepo = MLIIRepo;
        }
        // GET: Masse_Lineique_IIControllerController
        public ActionResult Index()
        {
            var ml = MLIIRepo.List().ToList();
            var max = 0;
            var min = 0;
            var moy = 0d;
            var nombre_Confirm = 0;
            var nombre_Mesures = 0;
            var Taux = Taux_de_conformite(nombre_Confirm, nombre_Mesures);
            if (ml.Count() != 0)
            {

                max = Max(ml);
                min = Min(ml);
                moy = Moy(ml);
                nombre_Confirm = Nombre_Total_Conforme(ml);
                nombre_Mesures = Nombre_Total_Mesures(ml);
                Taux = Taux_de_conformite(nombre_Confirm, nombre_Mesures);
            }
            var listML_II = new Masse_Lineique_IIViewModel()
            {
                Max = max,
                Min = min,
                Moy = moy,
                Nombre_Confirm = nombre_Confirm,
                Nombre_Mesures = nombre_Mesures,
                Taux_Conformite = Taux,
                Ml_I_list = ml

            };
            return View(listML_II);
        }

        // GET: Masse_Lineique_IIControllerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Masse_Lineique_IIControllerController/Create
        public ActionResult Create()
        {
            var ml = new Masse_Lineique_II();
            return View(ml);
        }

        // POST: Masse_Lineique_IIControllerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Masse_Lineique_II ml)
        {
            try
            {
                float red = (ml.Mesures - ml.MLDivMoy);
                float resit = red / ml.MLDivMoy;
                int v = resit < -0.036 ? 1 : 0;
                var m = new Masse_Lineique_II()
                {
                    Id = ml.Id,
                    MLDivMoy = ml.MLDivMoy,
                    Max = ml.Max,
                    Min = ml.Min,
                    Cible = ml.Cible,
                    Mesures = ml.Mesures,
                    SP_EBOU = ml.SP_EBOU,
                    N_ech = ml.N_ech,
                    Nombre = ml.Nombre,

                    Reduction = resit,
                    Conforme = v

                };
                MLIIRepo.Add(m);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Masse_Lineique_IIControllerController/Edit/5
        public ActionResult Edit(int id)
        {
            var ml = MLIIRepo.Find(id);
            return View(ml);
        }

        // POST: Masse_Lineique_IIControllerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Masse_Lineique_II ml)
        {
            try
            {
                MLIIRepo.Update(ml, id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Masse_Lineique_IIControllerController/Delete/5
        public ActionResult Delete(int id)
        {
            var ml = MLIIRepo.Find(id);
            return View(ml);
        }

        // POST: Masse_Lineique_IIControllerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                MLIIRepo.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public int Min(List<Masse_Lineique_II> ML)
        {
            int min = ML.Min(s => s.Mesures);
            return min;
        }
        public int Max(List<Masse_Lineique_II> ML)
        {
            int min = ML.Max(s => s.Mesures);
            return min;
        }
        public double Moy(List<Masse_Lineique_II> ML)
        {
            double min = ML.Average(s => s.Mesures);
            return min;
        }
        public int Nombre_Total_Conforme(List<Masse_Lineique_II> ML)
        {
            var sum = ML.Sum(s => s.Conforme);
            return sum;

        }
        public int Nombre_Total_Mesures(List<Masse_Lineique_II> ML)
        {
            var sum = ML.Sum(s => s.Nombre);
            return sum;

        }
        public float Taux_de_conformite(float n, float m)
        {
            float result = n / m;
            
            return result;
        }
    }
}
