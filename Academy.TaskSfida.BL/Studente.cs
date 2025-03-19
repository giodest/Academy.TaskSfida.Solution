using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.TaskSfida.BL
{
    public class Studente : Indirizzo
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Eta { get; set; }

        public Studente(string nome, string cognome, int eta, string via, int civico, string citta, int cap, string nazione) : base(via, civico, citta, cap, nazione)
        {
            Nome = nome;
            Cognome = cognome;
            Eta = eta;
        }

        public void getDettagliStudente() 
        {
            Console.WriteLine($"Nome Studente: {Nome}\nCognome Studente: {Cognome}\n{getIndirizzo()}\n");
        }
    }
}
