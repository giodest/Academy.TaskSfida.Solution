using Academy.TaskSfida.BL;

namespace Academy.TaskSfida.PL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var scuola1 = new Scuola();
            var indirizzo = new Indirizzo();
            indirizzo.Via = "Via dei monti";
            indirizzo.Civico = 5;
            indirizzo.Citta = "Lecce";
            indirizzo.CAP = 45020;
            indirizzo.Nazione = "Italia";

            scuola1.NomeScuola = "Tommaso del Bene";
            scuola1.IndirizzoScuola = indirizzo;
            scuola1.getScuola();

        }
    }
}
