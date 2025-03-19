using Academy.TaskSfida.BL;

namespace Academy.TaskSfida.PL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            

            Indirizzo indirizzoPersona= new Indirizzo("Via Per la Pace", 11, "Torino", 54011, "Italia");

            var professore1 = new Professore("Franco", "Gialli", 34, "Italiano", indirizzoPersona);
            var professore2 = new Professore("Chiara", "Pastelli", 49, "Matematica", indirizzoPersona);
            var professore3 = new Professore("Giuseppe", "Antonelli", 57, "Arte", indirizzoPersona);

            var studente1 = new Studente("Giovanni", "Destratis", 16, 11111, indirizzoPersona);
            var studente2 = new Studente("Mario", "Verdi", 15, 22222, indirizzoPersona);
            var studente3 = new Studente("Marco", "Bianchi", 12, 33333, indirizzoPersona);
            var studente4 = new Studente("Francesco", "Rossi", 16, 44444, indirizzoPersona);
                        

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
            studente1.Studia();
            professore1.Insegna();


        }
    }
}
