namespace SeregaByteCalculator
{
    public class VolumeConverter
    {
        public static void _VolumeConverter()
        {
            long gb = 0;    

            while (true)
            {
                Console.WriteLine("\nВведи целое число (ГБ):\n");

                string? stringGB = Console.ReadLine();

                if (long.TryParse(stringGB, out gb))
                {
                    if (gb < 0)
                    {
                        Console.WriteLine("Число меньше нуля. Введи больше!");
                    }

                    else
                    {
                        break;
                    }
                }

                else
                {
                    Console.WriteLine("Введи целое число!");
                }
            }

            Console.WriteLine($"Реальный объем: {((double)gb * 0.9313).ToString("0.##")} ГБ");

        }
    }
}
