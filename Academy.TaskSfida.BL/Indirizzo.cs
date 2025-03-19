using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.TaskSfida.BL
{
    public class Indirizzo
    {
        public string Via { get; set; }
        public int Civico { get; set; }
        public string Citta { get; set; }
        public int CAP { get; set; }
        public string Nazione { get; set; }

        public Indirizzo(string via, int civico, string citta, int cap, string nazione)
        {
            Via = via;
            Civico = civico;
            Citta = citta;
            CAP = cap;
            Nazione = nazione;
        }
              
    }
}
