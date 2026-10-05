namespace SeregaByteCalculator
{
    public class AlcoholCalculator
    {
        public static void _AlcoholCalculator()
        {
            double volume = 0;
            double strength = 0;

            while (true)
            {
                Console.WriteLine("\nВведите объем напитка в мл");

                string? volumeString = Console.ReadLine();

                if (double.TryParse(volumeString, out volume))
                {
                    if (volume < 0)
                    {
                        Console.WriteLine("\nЧисло меньше нуля. Введи больше!");
                    }

                    else
                    {
                        break;
                    }
                }

                else
                {
                    Console.WriteLine("\nВведи число!");
                }
            }

            while (true)
            {
                Console.WriteLine("\nВведите крепость(%)");

                string? strengthString = Console.ReadLine();

                if (double.TryParse(strengthString, out strength))
                {
                    if (strength < 0)
                    {
                        Console.WriteLine("\nЧисло меньше нуля. Введи больше!");
                    }

                    else
                    {
                        break;
                    }
                }

                else
                {
                    Console.WriteLine("\nВведи число!");
                }
            }

            Console.WriteLine($"\nОбъем спирта: {((volume*strength)/100).ToString("0.##")} мл");
            Console.WriteLine("Алкаш");

        }
    }
}
