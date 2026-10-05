namespace SeregaByteCalculator
{
    public class ByteConverter
    {
        public static void _ByteConverter()
        {
            long bytes = 0;        

            while(true)
            {
                Console.WriteLine("\nВведи число в байтах:\n");

                string? stringBytes = Console.ReadLine();

                if (long.TryParse(stringBytes, out bytes))
                {
                    if (bytes < 0)
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

            double kb1 = (double)bytes / 1024;
            double mb1 = (double)kb1 / 1024;
            double gb1 = (double)mb1 / 1024;

            double kb2 = (double)bytes / 1000;
            double mb2 = (double)kb2 / 1000;
            double gb2 = (double)mb2 / 1000;

            Console.WriteLine($"\n    |{"Реальный объем", - 20}|На коробке");

            Console.WriteLine($" КБ |{kb1.ToString("0.##"),-20}|{kb2.ToString("0.##")}");
            Console.WriteLine($" МБ |{mb1.ToString("0.##"),-20}|{mb2.ToString("0.##")}");
            Console.WriteLine($" ГБ |{gb1.ToString("0.##"),-20}|{gb2.ToString("0.##")}");
        }
        
    }
}
