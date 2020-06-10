using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP.CalculatriceChaineCaractere.Commun
{
    public class MessageFontionnel
    {
        private string message;

        public MessageFontionnel(string message)
        {
            this.message = message;
        }

        public string Message   
        {
            get { return message; }
            set { message = value; }
        }
    }
}
