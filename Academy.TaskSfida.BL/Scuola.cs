namespace Academy.TaskSfida.BL
{
    public class Scuola : Indirizzo
    {
        public string NomeScuola { get; set; }
        public string Specializzazione { get; set; }
        public Scuola(string nomeScuola, string specializzazione, string via, int civico, string citta, int cap, string nazione) : base (via, civico, citta, cap, nazione)
        {
            NomeScuola = nomeScuola;
            Specializzazione = specializzazione;
        }

        public void getDettagliScuola()
        {
            Console.WriteLine($"Nome Istituto: {NomeScuola}.\nSpecializzazione: {Specializzazione}.\n{getIndirizzo()}\n");
        }
    }
}
