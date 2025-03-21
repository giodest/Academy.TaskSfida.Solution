using Academy.TaskSfida.BL.Entities;
using Academy.TaskSfida.BL.Interfaces;
using Academy.TaskSfida.BL.Managers;
using Academy.TaskSfida.BL.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Academy.TaskSfida.PL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<IProfessoreService, ProfessoreService>();
            serviceCollection.AddSingleton<IStudenteService, IStudenteService>();

            serviceCollection.AddSingleton<StudenteManager>();
            serviceCollection.AddSingleton<ProfessoreManager>();

            var serviceProvider = serviceCollection.BuildServiceProvider();
            var service1 = serviceProvider.GetService<StudenteManager>();
            var service2 = serviceProvider.GetService<ProfessoreManager>();

            var studenti = new List<Studente>();
            studenti.Add(new Studente("Giovanni", "Destratis", 16, 11111, new Indirizzo("Via Per i Laghi", 21, "Torino", 54011, "Italia")));
            studenti.Add(new Studente("Mario", "Verdi", 15, 22222, new Indirizzo("Via Per la campagna", 56, "Torino", 54011, "Italia")));
            studenti.Add(new Studente("Marco", "Bianchi", 12, 33333, new Indirizzo("Via Ugo Foscolo ", 37, "Torino", 54011, "Italia")));
            studenti.Add(new Studente("Francesco", "Rossi", 16, 44444, new Indirizzo("Via Piazza Mazzini", 100, "Torino", 54011, "Italia")));

            var professori = new List<Professore>();
            professori.Add(new Professore("Franco", "Gialli", 34, "Italiano", new Indirizzo("Via Per la Pace", 11, "Torino", 54011, "Italia")));
            professori.Add(new Professore("Chiara", "Pastelli", 49, "Matematica", new Indirizzo("Via Per la Vittoria", 12, "Torino", 54011, "Italia")));
            professori.Add(new Professore("Giuseppe", "Antonelli", 57, "Arte", new Indirizzo("Via Per i Monti", 14, "Torino", 54011, "Italia")));

            var scuole = new List<Scuola>();
            scuole.Add(new Scuola("Tommaso del Bene", "Scientifico", new Indirizzo("Via Mario Bianchi", 9, "Taranto", 33022, "Italia")));


            foreach (Professore professore in professori)
            {
                scuole[0].Aggiungi(professore);
                professore.Informazioni();
            }

            foreach (Studente studente in studenti)
            {
                scuole[0].Aggiungi(studente);
                studente.Informazioni();
            }


            Console.WriteLine("\n\n");

            scuole[0].getDettagliScuola();

            Console.WriteLine("\n\n");

            studenti[2].Matricola(); 
            professori[0].Insegna();

        }
    }
}
