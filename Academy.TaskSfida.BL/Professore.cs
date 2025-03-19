using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.TaskSfida.BL
{
    public class Professore(string nome, string cognome, int eta, string disciplina, Indirizzo indirizzo) : Persona(nome, cognome, eta, indirizzo)
    {

        public string Disciplina { get; set; } = disciplina;


        public void Insegna()
        {
            Console.WriteLine($"Il professore {Nome} insegna {Disciplina}");
        }

        public override void Beve()
        {
            Console.WriteLine($"Il professore {Nome} beve");
        }

        public override void Dorme()
        {
            Console.WriteLine($"Il professore {Nome} dorme");
        }

        public override void Mangia()
        {
            Console.WriteLine($"Il professore {Nome} mangia");
        }
    }
}
