using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.TaskSfida.BL.Entities
{
    public class Studente(string nome, string cognome, int eta, int numeroMatricola, Indirizzo indirizzo) : Utente(nome, cognome, eta, indirizzo)
    {

        public int NumeroMatricola { get; set; } = numeroMatricola;

        public void Matricola() 
        {
            Console.WriteLine($"Matricola: {NumeroMatricola}.");
        }               

    }
}
