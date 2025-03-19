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
        public int Eta { get; set; }
        public Indirizzo IndirizzoStudente { get; set; }

        public Studente(string nome, string cognome, int eta, Indirizzo indirizzo)
        {
            Nome = nome;
            Cognome = cognome;
            Eta = eta;
            IndirizzoStudente = indirizzo;
        }

        public void getDettagliStudente() 
        {
            Console.WriteLine($"Nome Studente: {Nome}\nCognome Studente: {Cognome}" +
                $"\nIndirizzo: {IndirizzoStudente.Via} n° {IndirizzoStudente.Civico}, {IndirizzoStudente.Citta}, {IndirizzoStudente.CAP}, {IndirizzoStudente.Nazione}.\n");
        }
    }
}
