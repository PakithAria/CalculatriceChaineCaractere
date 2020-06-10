using PP.CalculatriceChaineCaractere.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP.CalculatriceChaineCaractere.LogiqueAffaire.Validateur
{
    public interface IValidateurCda
    {
        bool ValiderOperation(string calculAfaire);
    }
}
