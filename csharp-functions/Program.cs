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
                int[] elements = { 2, 6, 7, 5, 3, 9 };
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

            // FUNZIONE PER ELEVARE AL QUADRATO GLI ELEMENTI DELL'ARRAY PASSATO COME PARAMETRO CREANDO UN NUOVO ARRAY ED ESEGUIRE UNA SOMMA DEGLI ELEMENTI ELEVATI AL QUADRATO
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

                // Somma quadrato
                int SommaQuadratiArray(int[] array)
                {
                    int sommaQuadrati = 0;
                    foreach (int numero in array)
                    {
                        int quadrato = numero * numero;
                        sommaQuadrati += quadrato;
                    }
                    return sommaQuadrati;
                }

                // Stampa array
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
                int[] numbers = { 2, 6, 7, 5, 3, 9 };
                int[] numeriQuadrati = ElevaArrayAlQuadrato(numbers);

                Console.WriteLine("Array originale:");
                PrintArray(numbers);

                Console.WriteLine("Array con elementi elevati al quadrato:");
                PrintArray(numeriQuadrati);

                int sommaQuadrati = SommaQuadratiArray(numbers);
                Console.WriteLine($"La somma totale dei quadrati degli elementi dell'array è: {sommaQuadrati}");
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
                int[] numbers = { 2, 6, 7, 5, 3, 9 };
                int somma = sommaElementiArray(numbers);
                Console.WriteLine($"La somma totale degli elementi dell'array è: {somma}");
            }
            
            // -----------------------------------------------------------------
            // BONUS
            // -----------------------------------------------------------------
            {
                // Stampa array
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

                // Quadrato di un numero
                int Quadrato(int numero)
                {
                    return numero * numero;
                }

                // Quadrato di un array
                int[] ElevaArrayAlQuadrato(int[] array)
                {
                    int[] arrayQuadrati = new int[array.Length];
                    for (int i = 0; i < array.Length; i++)
                    {
                        arrayQuadrati[i] = array[i] * array[i];
                    }
                    return arrayQuadrati;
                }

                // Somma quadrato
                int SommaQuadratiArray(int[] array)
                {
                    int sommaQuadrati = 0;
                    foreach (int numero in array)
                    {
                        sommaQuadrati += numero * numero;
                    }
                    return sommaQuadrati;
                }

                // Somma di tutti gli elementi di un array
                int sommaElementiArray(int[] array)
                {
                    int somma = 0;
                    foreach (int numero in array)
                    {
                        somma += numero;
                    }
                    return somma;
                }

                // Utente inserisce la lunghezza dell'array desiderata
                Console.Write("Inserisci la lunghezza dell'array: ");
                int lunghezza = Convert.ToInt32(Console.ReadLine());

                int[] numeri = new int[lunghezza];
                for (int i = 0; i < lunghezza; i++)
                {
                    Console.Write($"Inserisci il {i + 1}° numero: ");
                    numeri[i] = Convert.ToInt32(Console.ReadLine());
                }

                // Chiamata alle funzioni
                Console.WriteLine("Array creato:");
                PrintArray(numeri);

                Console.WriteLine("Array con elementi elevati al quadrato:");
                int[] numeriQuadrati = ElevaArrayAlQuadrato(numeri);
                PrintArray(numeriQuadrati);

                int sommaQuadrati = SommaQuadratiArray(numeri);
                Console.WriteLine($"La somma totale dei quadrati degli elementi dell'array è: {sommaQuadrati}");

                int somma = sommaElementiArray(numeri);
                Console.WriteLine($"La somma totale degli elementi dell'array è: {somma}");
            }
            
        }
    }
}
