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

            
            
        }
    }
}
