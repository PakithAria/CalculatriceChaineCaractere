using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP.CalculatriceChaineCaractere.Commun
{
    public class MessagesFontionnels
    {
        private List<MessageFontionnel> messages;

        public MessagesFontionnels(MessageFontionnel message)
        {
            this.messages.Add(message);
        }

        public List<MessageFontionnel> Messages   
        {
            get { return messages; }
            set { messages = value; }
        }
    }
}
