using static System.Runtime.InteropServices.JavaScript.JSType;

namespace csharp_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // FUNZIONE PER STAMPARE A VIDEO UN ARRAY
            {
                void StampaArray(int[] array)
                {
                    Console.Write("[");
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.Write(array[i]);
                        if (i < array.Length - 1)
                            Console.Write(", ");
                    }
                    Console.WriteLine("]");
                }
                int[] elements = { 1, 2, 3, 4, 5, 6, 7 };
                StampaArray(elements);
            }

            // FUNZIONE PER CALCOLARE IL QUADRATO DI UN NUMERO PASSATO COME PARAMETRO
            {
                int Quadrato(int numero)
                {
                    return numero * numero;
                }
                int numero = 4;
                int quadrato = Quadrato(numero);
                Console.WriteLine($"Il quadrato di {numero} è: {quadrato}");
            }

            // FUNZIONE PER ELEVARE AL QUADRATO GLI ELEMENTI DELL'ARRAY PASSATO COME PARAMETRO CREANDO UN NUOVO ARRAY
            {
                int[] ElevaArrayAlQuadrato(int[] array)
                {
                    int[] arrayQuadrati = new int[array.Length];
                    for (int i = 0; i < array.Length; i++)
                    {
                        arrayQuadrati[i] = array[i] * array[i];
                    }
                    return arrayQuadrati;
                }

                void PrintArray(int[] array)
                {
                    Console.Write("[");
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.Write(array[i]);
                        if (i < array.Length - 1)
                            Console.Write(", ");
                    }
                    Console.WriteLine("]");
                }
                int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
                int[] numeriQuadrati = ElevaArrayAlQuadrato(numbers);

                Console.WriteLine("Array originale:");
                PrintArray(numbers);

                Console.WriteLine("Array con elementi elevati al quadrato:");
                PrintArray(numeriQuadrati);
            }
            
            // FUNZIONE PER RESTITUIRE LA SOMMA TOTALE DI TUTTI GLI ELEMENTI DELL'ARRAY
            {
                int sommaElementiArray(int[] array)
                {
                    int somma = 0;
                    foreach (int numero in array)
                    {
                        somma += numero;
                    }
                    return somma;
                }
                int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
                int somma = sommaElementiArray(numbers);
                Console.WriteLine($"La somma totale degli elementi dell'array è: {somma}");
            }
            
        }
    }
}
