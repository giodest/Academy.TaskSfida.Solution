﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.TaskSfida.BL.Entities
{
    public class Professore(string nome, string cognome, int eta, string disciplina, Indirizzo indirizzo) : Utente(nome, cognome, eta, indirizzo)
    {        
        public string Disciplina { get; set; } = disciplina;


        
        public void Insegna()
        {
            Console.WriteLine($"Il professore {Nome} {Cognome} insegna {Disciplina}");
        }
               
    }
}
