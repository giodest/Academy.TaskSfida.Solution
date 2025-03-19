using Academy.TaskSfida.BL;

namespace Academy.TaskSfida.PL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Indirizzo indirizzoScuola = new Indirizzo("Via Mario Bianchi", 9, "Taranto", 33022, "Italia");
            var scuola1 = new Scuola("Tommaso del Bene", "Scientifico", indirizzoScuola);
            scuola1.getDettagliScuola1();

            Indirizzo indirizzoStudente = new Indirizzo("Via Per la Pace", 11, "Torino", 54011, "Italia");
            var studente1 = new Studente("Franco", "Gialli", 34, indirizzoStudente);
            studente1.getDettagliStudente();
        }
    }
}
