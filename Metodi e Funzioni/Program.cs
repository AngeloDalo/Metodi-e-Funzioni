using System;

namespace Corso
{
    class Program
    {
        static void Main(string[] args)
        {
            saluta(nome: "luca", orario: 1); //se non metto nome: devo metterli ordinati
            int risultato = faiSomma(5, 3);
            Console.WriteLine(risultato);
        }

        static void saluta(string nome, int orario = 0) //orario default è 0 nel caso no lo inseriamo
        {
            switch (orario)
            {
                case 0:
                    Console.WriteLine($"CIAO {nome} e buongiorno");
                    break;
                case 1:
                    Console.WriteLine($"CIAO {nome} e buonasera");
                    break;
            }
        }

        static int faiSomma (int n1, int n2)
        {
            int result = n1 + n2;
            return result;
        }
    }
}
