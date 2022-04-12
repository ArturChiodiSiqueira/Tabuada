using System;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tabuada, inicioTabuada = 1, fimTabuada, resultadoTabuada;
            Console.Write("INFORME O NÚMERO CORRESPONDENTE A TABUADA: ");
            tabuada = int.Parse(Console.ReadLine());

            do
            {
                Console.Write("\nINFORME O NÚMERO DE PARADA: ");
                fimTabuada = int.Parse(Console.ReadLine());
            } while (fimTabuada < inicioTabuada);

            Console.WriteLine("\n\tA tabuada de " + tabuada + " é:\n");

            for (int i = inicioTabuada; i <= fimTabuada; i++)
            {
                resultadoTabuada = tabuada * i;
                Console.WriteLine("\t" + tabuada + " * " + i + " = " + resultadoTabuada);
            }
            Console.WriteLine("\n\nPRESSIONE QUALQUER TECLA PARA SAIR.");
            Console.ReadKey();
        }
    }
}
