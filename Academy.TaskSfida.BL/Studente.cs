using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.TaskSfida.BL
{
    public class Studente(string nome, string cognome, int eta, int numeroMatricola, Indirizzo indirizzo) : Persona(nome, cognome, eta, indirizzo)
    {

        public int NumeroMatricola { get; set; } = numeroMatricola;

        public void getNumeroMatricola() 
        {
            Console.WriteLine($"La matricola dello studente {Nome} {Cognome} è: {NumeroMatricola}.");
        }

        public void Studia()
        {
            Console.WriteLine($"Lo studente {Nome} studia");
        }
                
        public override void Beve()
        {
            Console.WriteLine($"Lo studente {Nome} beve");
        }

        public override void Dorme()
        {
            Console.WriteLine($"Lo studente {Nome} dorme");
        }

        public override void Mangia()
        {
            Console.WriteLine($"Lo studente {Nome} mangia");
        }

    }
}
