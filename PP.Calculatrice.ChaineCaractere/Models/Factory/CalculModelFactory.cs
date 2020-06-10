using PP.CalculatriceChaineCaractere.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PP.Calculatrice.ChaineCaractere.Models.Factory
{
    public class CalculModelFactory : ICalculModelFactory
    {
        public CalculEntites ConvertitEnCalculEntite(CalculModel model)
        {
            return new CalculEntites()
            {
                CalculAFaire = model.Calcul
            };
        }
    }
}