using System;
using System.Collections.Generic;

namespace UniversitaDizionario
{
    internal partial class Program
    {
        static void Main(string[] args)
        {

            Matricola mat1 = new Matricola("Giovanni", 125466);
            Matricola mat2 = new Matricola("Bruno", 32466);
            Matricola mat3 = new Matricola("Emma", 55321);
            Matricola mat4 = new Matricola("Francesco", 1235346);

            Esame es1 = new Esame("\nProgrammazione I", 001, 26);
            Esame es2 = new Esame("Analisi 3", 002, 29);
            Esame es3 = new Esame("Chimica I", 003, 22);
            Esame es4 = new Esame("Medicina Generale", 004, 24);

            Dictionary<DIPARTIMENTI, Dictionary<Matricola, List<Esame>>> uni = new Dictionary<DIPARTIMENTI, Dictionary<Matricola, List<Esame>>>();

            uni.Add(DIPARTIMENTI.INFORMATICA, new());
            uni.Add(DIPARTIMENTI.FISICA, new());
            uni.Add(DIPARTIMENTI.BIOLOGIA, new());
            uni.Add(DIPARTIMENTI.MEDICINA, new());

            uni[DIPARTIMENTI.INFORMATICA].Add(mat1, new());
            uni[DIPARTIMENTI.FISICA].Add(mat2, new());
            uni[DIPARTIMENTI.BIOLOGIA].Add(mat3, new());
            uni[DIPARTIMENTI.MEDICINA].Add(mat4, new());

            uni[DIPARTIMENTI.INFORMATICA][mat1].Add(es1);
            uni[DIPARTIMENTI.FISICA][mat2].Add(es2);
            uni[DIPARTIMENTI.BIOLOGIA][mat3].Add(es3);
            uni[DIPARTIMENTI.MEDICINA][mat4].Add(es4);

            Console.WriteLine("Esami delle varie universita");
            Console.WriteLine(uni[DIPARTIMENTI.INFORMATICA][mat1][0].NomeEsame);    
            Console.WriteLine(uni[DIPARTIMENTI.FISICA][mat2][0].NomeEsame);    
            Console.WriteLine(uni[DIPARTIMENTI.BIOLOGIA][mat3][0].NomeEsame);    
            Console.WriteLine(uni[DIPARTIMENTI.MEDICINA][mat4][0].NomeEsame);
            
            Console.WriteLine("\n--- Voti Esami ----");
            Console.WriteLine(uni[DIPARTIMENTI.INFORMATICA][mat1][0].Voto);
            Console.WriteLine(uni[DIPARTIMENTI.FISICA][mat2][0].Voto);
            Console.WriteLine(uni[DIPARTIMENTI.BIOLOGIA][mat3][0].Voto);
            Console.WriteLine(uni[DIPARTIMENTI.MEDICINA][mat4][0].Voto);

           
   
             



        }
    }





    public enum DIPARTIMENTI {

        INFORMATICA,
        FISICA,
        BIOLOGIA,
        MEDICINA
        
    }
}
