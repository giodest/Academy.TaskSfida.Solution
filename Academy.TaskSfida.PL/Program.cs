using Academy.TaskSfida.BL;

namespace Academy.TaskSfida.PL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var scuola1 = new Scuola("Tommaso del Bene", "Scientifico", "Via dei monti", 5, "Lecce", 45020, "Italia");
            var studente1 = new Studente("Giovanni", "Destratis", 26, "Via Giuseppe Mazzini", 30, "Lecce", 45320, "Italia");

            scuola1.getDettagliScuola();
            scuola1.getIndirizzo();
            studente1.getDettagliStudente();
            studente1.getIndirizzo();
        }
    }
}
