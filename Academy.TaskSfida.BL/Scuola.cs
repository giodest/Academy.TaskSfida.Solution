namespace Academy.TaskSfida.BL
{
    public class Scuola : Indirizzo
    {
        public string NomeScuola { get; set; }
        public Indirizzo IndirizzoScuola { get; set; }
        public Studente StudentiScuola { get; set; }

        public void getScuola()
        {
            Console.WriteLine($"Nome Istituto: {NomeScuola}.\nIndirizzo: {IndirizzoScuola.Via} n° {IndirizzoScuola.Civico}, {IndirizzoScuola.Citta}, {IndirizzoScuola.CAP}, {IndirizzoScuola.Nazione}.");
        }
    }
}
