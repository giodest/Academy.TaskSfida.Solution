namespace Academy.TaskSfida.BL
{
    public class Scuola
    {
        public string NomeScuola { get; set; }
        public string Specializzazione { get; set; }
        public Indirizzo IndirizzoScuola { get; set; }

        
        public Scuola(string nomeScuola, string specializzazione, Indirizzo indirizzo)
        {
            NomeScuola = nomeScuola;
            Specializzazione = specializzazione;
            IndirizzoScuola = indirizzo;
        }

        public void getDettagliScuola1() 
        {
            Console.WriteLine($"Nome Istituto: {NomeScuola}.\nSpecializzazione: {Specializzazione}." +
                $"\nIndirizzo: {IndirizzoScuola.Via} n° {IndirizzoScuola.Civico}, {IndirizzoScuola.Citta}, {IndirizzoScuola.CAP}, {IndirizzoScuola.Nazione}.\n");
        }
        
    }
}
