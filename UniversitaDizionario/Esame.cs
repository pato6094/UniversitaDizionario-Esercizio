namespace UniversitaDizionario
{
    internal partial class Program
    {
        public class Esame
        {
            public Esame(string nomeEsame, int iDEsame, int voto)
            {
                NomeEsame = nomeEsame;
                IDEsame = iDEsame;
                Voto = voto;
            }

            public string NomeEsame { get; set; }
            public int IDEsame { get; set; }    
            public int Voto { get; set; }   

            

        }
    }
}
