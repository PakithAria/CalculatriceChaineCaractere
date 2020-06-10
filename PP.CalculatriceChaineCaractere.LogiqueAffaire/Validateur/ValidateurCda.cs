using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PP.CalculatriceChaineCaractere.LogiqueAffaire.Validateur
{
    public class ValidateurCda : IValidateurCda
    {
        Regex rgx = new Regex(@"^(-?[1-9]+\\d*([.]\\d+)?)$|^(-?0[.]\\d*[1-9]+)$|^0$"); 

        public bool ValiderOperation(string calculAfaire)
        {
            if (string.IsNullOrEmpty(calculAfaire))
                return false;
            if (rgx.IsMatch(calculAfaire))
                return false;
            return true;
        }
    }
}
