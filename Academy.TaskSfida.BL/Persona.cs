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

        public virtual void Mangia()
        {
            Console.WriteLine("La persona mangia.");
        }

        public virtual void Beve() 
        {
            Console.WriteLine("La persona beve");
        }

        public virtual void Dorme() 
        {
            Console.WriteLine("La persona dorme");
        }


    }
}
