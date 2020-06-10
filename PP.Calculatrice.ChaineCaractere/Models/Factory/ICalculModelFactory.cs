using PP.CalculatriceChaineCaractere.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP.Calculatrice.ChaineCaractere.Models.Factory
{
    public interface ICalculModelFactory
    {
        CalculEntites ConvertitEnCalculEntite(CalculModel model);
    }
}
