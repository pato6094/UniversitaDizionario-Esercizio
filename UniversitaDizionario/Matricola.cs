namespace UniversitaDizionario
{
    public class Matricola
    {
        public string Nome { get; set; }
        public int Idmat { get; set; }

        public Matricola(string nome, int idmat)
        {
            Nome = nome;
            Idmat = idmat;
        }
    }
}
