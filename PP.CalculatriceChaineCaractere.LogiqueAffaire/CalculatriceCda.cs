using PP.CalculatriceChaineCaractere.Entites;
using PP.CalculatriceChaineCaractere.LogiqueAffaire.Validateur;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP.CalculatriceChaineCaractere.LogiqueAffaire
{
    public class CalculatriceCda<T>:ICalculatriceCda
    {
        private IValidateurCda _validateurCda;

        public CalculatriceCda()
        {

        }

        public CalculatriceCda(IValidateurCda validateurCda)
        {
            _validateurCda = validateurCda;
        }

        public CalculEntites Calculer(CalculEntites calculAFaire)
        {
            string operationACalculer=calculAFaire.CalculAFaire.Trim();
            if (!_validateurCda.ValiderOperation(operationACalculer))
            {
                throw new Exception("L'opération n'est pas valide.");
            }
            calculAFaire.ResultatCalcul = Calculer(operationACalculer).ToString();

            return calculAFaire;
        }

        private T Calculer(string operation)
        {
           DataTable dt = new DataTable();

           return (T)(new DataTable().Compute(operation, ""));
        }
    }
}
