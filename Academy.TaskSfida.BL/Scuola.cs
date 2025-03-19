namespace Academy.TaskSfida.BL
{
    public class Scuola
    {
        public string NomeScuola { get; set; }
        public string Specializzazione { get; set; }
        public Indirizzo IndirizzoScuola { get; set; }
        public List<Professore> Professori { get; set; }
        public List<Studente> Studenti { get; set; }


        public Scuola(string nomeScuola, string specializzazione, Indirizzo indirizzo)
        {
            NomeScuola = nomeScuola;
            Specializzazione = specializzazione;
            IndirizzoScuola = indirizzo;
            Professori = new List<Professore>();
            Studenti = new List<Studente>();
        }



        public void AggiungiProfessore(Professore professore)
        {
            Professori.Add(professore);
        }



        public void AggiungiStudente(Studente studente)
        {
            Studenti.Add(studente);
        }



        public void getDettagliScuola() 
        {
            Console.Write($"Nome Istituto: {NomeScuola}.\nSpecializzazione: {Specializzazione}." +
                $"\nIndirizzo: {IndirizzoScuola.Via} n° {IndirizzoScuola.Civico}, {IndirizzoScuola.Citta}, {IndirizzoScuola.CAP}, {IndirizzoScuola.Nazione}.");

            Console.Write("\n\nProfessori: ");

            for (int i = 0; i < Professori.Count; i++)
            {
                var professore = Professori[i];
                Console.Write($"{professore.Nome} {professore.Cognome}");

                if (i < Professori.Count - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.Write(".\n\nStudenti: ");

            for (int i = 0; i < Studenti.Count; i++)
            {
                var studente = Studenti[i];
                Console.Write($"{studente.Nome} {studente.Cognome}");

                if (i < Studenti.Count - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.Write(".");
        }
        
    }
}
