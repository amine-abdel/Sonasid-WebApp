using BookStore.Models.Repo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_SONASID.Models;
using MVC_SONASID.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SONASID.Controllers
{
    public class FARDEAUXController : Controller
    {
        public IMasse_Lineique_Repo<FARDEAUX> FRepo { get; }

        public FARDEAUXController(IMasse_Lineique_Repo<FARDEAUX> FRepo)
        {
            this.FRepo = FRepo;
        }
        // GET: FARDEAUXController
        public ActionResult Index()
        {

            int a = Score_c(FRepo.List().ToList());
            var Vmodel = new FARDEAUXVeiwModel()
            {
                ListC = FRepo.List().ToList(),

                score = a,
                conforme = conforme(a, IMasse_Lineique_Repo<COURONNES>.nbr_v),
                nbr_verification = IMasse_Lineique_Repo<COURONNES>.nbr_v,
            };
            return View(Vmodel);
        }

        // GET: FARDEAUXController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FARDEAUXController/Create
        public ActionResult Create()
        {
            var Vmodel = new  FARDEAUXVeiwModel()
            {
                ListC = FRepo.List().ToList()
            };
            return View(Vmodel);
        }

        // POST: FARDEAUXController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FARDEAUXVeiwModel Vm)
        {
            try
            {
                var list = Vm.ListC.ToList();

                FRepo.Add(list);

                IMasse_Lineique_Repo<COURONNES>.nbr_v = Vm.nbr_verification;

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FARDEAUXController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FARDEAUXController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FARDEAUXController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FARDEAUXController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public int Score_c(List<FARDEAUX> listc)
        {
            int sum = 0;
            foreach (var item in listc)
            {

                sum = sum + item.conforme + item.Non_Conforme + item.Derogeable;
            }
            return sum;
        }
        public double conforme(double score, double nbr_V)
        {
            double result = score / nbr_V;

            if (nbr_V == 0)
            {
                return 0;
            }
            else
            {
                return result;
            }

        }
    }
}
