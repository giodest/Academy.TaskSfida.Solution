using Academy.TaskSfida.BL;

namespace Academy.TaskSfida.PL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            

            Indirizzo indirizzoPersona1 = new Indirizzo("Via Per la Pace", 11, "Torino", 54011, "Italia");
            Indirizzo indirizzoPersona2 = new Indirizzo("Via Per la Vittoria", 12, "Torino", 54011, "Italia");
            Indirizzo indirizzoPersona3 = new Indirizzo("Via Per i Monti", 14, "Torino", 54011, "Italia");
            Indirizzo indirizzoPersona4 = new Indirizzo("Via Per i Laghi", 21, "Torino", 54011, "Italia");
            Indirizzo indirizzoPersona5 = new Indirizzo("Via Per la campagna", 56, "Torino", 54011, "Italia");
            Indirizzo indirizzoPersona6 = new Indirizzo("Via Ugo Foscolo ", 37, "Torino", 54011, "Italia");
            Indirizzo indirizzoPersona7 = new Indirizzo("Via Piazza Mazzini", 100, "Torino", 54011, "Italia");


            var professore1 = new Professore("Franco", "Gialli", 34, "Italiano", indirizzoPersona1);
            var professore2 = new Professore("Chiara", "Pastelli", 49, "Matematica", indirizzoPersona2);
            var professore3 = new Professore("Giuseppe", "Antonelli", 57, "Arte", indirizzoPersona3);

            var studente1 = new Studente("Giovanni", "Destratis", 16, 11111, indirizzoPersona4);
            var studente2 = new Studente("Mario", "Verdi", 15, 22222, indirizzoPersona5);
            var studente3 = new Studente("Marco", "Bianchi", 12, 33333, indirizzoPersona6);
            var studente4 = new Studente("Francesco", "Rossi", 16, 44444, indirizzoPersona7);
                        

            Indirizzo indirizzoScuola = new Indirizzo("Via Mario Bianchi", 9, "Taranto", 33022, "Italia");
            var scuola1 = new Scuola("Tommaso del Bene", "Scientifico", indirizzoScuola);



            scuola1.AggiungiProfessore(professore1);
            scuola1.AggiungiProfessore(professore2);
            scuola1.AggiungiProfessore(professore3);

            scuola1.AggiungiStudente(studente1);
            scuola1.AggiungiStudente(studente2);
            scuola1.AggiungiStudente(studente3);
            scuola1.AggiungiStudente(studente4);

            scuola1.getDettagliScuola();

            Console.WriteLine("\n\n");

            studente1.getNumeroMatricola();
            professore1.Insegna();

            studente1.getInformazioni();
            professore1.getInformazioni();


        }
    }
}
