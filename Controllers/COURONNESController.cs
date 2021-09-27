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
    public class COURONNESController : Controller
    {
        public IMasse_Lineique_Repo<COURONNES> CRepo { get; }

        public COURONNESController(IMasse_Lineique_Repo<COURONNES> CRepo)
        {
            this.CRepo = CRepo;
        }
        // GET: COURONNESController
        public ActionResult Index()
        {

            int a = Score_c(CRepo.List().ToList());
            var Vmodel = new COURONNESVeiwModel()
            {
                ListC = CRepo.List().ToList(),

                score = a,
                conforme = conforme(a, IMasse_Lineique_Repo<COURONNES>.nbr_v),
                nbr_verification = IMasse_Lineique_Repo<COURONNES>.nbr_v,
            };
           
            return View(Vmodel);
        }

        // GET: COURONNESController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: COURONNESController/Create
        public ActionResult Create()
        {
            var Vmodel = new COURONNESVeiwModel()
            {
                ListC = CRepo.List().ToList()
            };
            return View(Vmodel);
           
        }

        // POST: COURONNESController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(COURONNESVeiwModel Vm)
        {
            try
            {
                var list = Vm.ListC.ToList();
                
                 CRepo.Add(list);

                IMasse_Lineique_Repo<COURONNES>.nbr_v = Vm.nbr_verification;

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: COURONNESController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: COURONNESController/Edit/5
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

        // GET: COURONNESController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: COURONNESController/Delete/5
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
        public int Score_c(List<COURONNES> listc)
        {
            int sum = 0;
            foreach (var item in listc)
            {
               
                sum = sum + item.conforme + item.Non_Conforme + item.Derogeable;
            }
            return sum;
        }
        public double conforme(double score,double nbr_V)
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
