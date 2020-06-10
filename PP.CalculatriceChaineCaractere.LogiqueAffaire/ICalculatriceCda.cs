using PP.CalculatriceChaineCaractere.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP.CalculatriceChaineCaractere.LogiqueAffaire
{
    public interface ICalculatriceCda
    {
        CalculEntites Calculer(CalculEntites calculAFaire);
    }
}
