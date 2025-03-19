using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.TaskSfida.BL
{
    public class Studente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Specializzazione { get; set; }
        public Indirizzo IndirizzoStudente { get; set; }

    }
}
