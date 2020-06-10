using PP.Calculatrice.ChaineCaractere.Models;
using PP.Calculatrice.ChaineCaractere.Models.Factory;
using PP.CalculatriceChaineCaractere.Entites;
using PP.CalculatriceChaineCaractere.LogiqueAffaire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PP.Calculatrice.ChaineCaractere.Controllers
{
    public class CalculatriceController: Controller
    {
        private ICalculModelFactory _calculModelFactory;
        private ICalculatriceCda _calculatriceCda;

        public CalculatriceController()
        {

        }

        CalculatriceController(ICalculModelFactory calculModelFactory,
                               ICalculatriceCda calculatriceCda)
        {
            _calculModelFactory = calculModelFactory;
            _calculatriceCda = calculatriceCda;
        }

        public ActionResult Index()
        {
            return View("Calculatrice");
        }

        [HttpPost]
        public ActionResult Index(CalculModel model)
        {
            CalculEntites calcul = _calculModelFactory.ConvertitEnCalculEntite(model);
            CalculEntites resultCalcul=_calculatriceCda.Calculer(calcul);

            return View("Calculatrice");
        }
    }
}