using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.TaskSfida.BL
{
    public class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Eta { get; set; }
        public Indirizzo IndirizzoPersona { get; set; }


        public Persona(string nome, string cognome, int eta, Indirizzo indirizzo)
        {
            Nome = nome;
            Cognome = cognome;
            Eta = eta;
            IndirizzoPersona = indirizzo;
        }


        
        public virtual void Informazioni() 
        {
            Console.WriteLine($"Nome: {Nome}\nCognome: {Cognome}\nEtà: {Eta}\nIndirizzo: {IndirizzoPersona.Via} n° {IndirizzoPersona.Civico}, {IndirizzoPersona.Citta}, {IndirizzoPersona.CAP}, {IndirizzoPersona.Nazione}.");
        }   


    }
}
