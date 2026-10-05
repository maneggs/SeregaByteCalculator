namespace SeregaByteCalculator
{
    public class TimeDownload
    {   
        public static void _TimeDownload()
        {
            double weight = 0;
            double speed = 0;

            while (true)
            {
                Console.WriteLine("\nВведите размер файла в МБ");

                string? weightString = Console.ReadLine();

                if (double.TryParse(weightString, out weight))
                {
                    if (weight < 0)
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
                    Console.WriteLine("\nВведи целое число!");
                }
            }

            while (true)
            {
                Console.WriteLine("\nВведите скорость (Мбит/с):");

                string? speedString = Console.ReadLine();

                if (double.TryParse(speedString, out speed))
                {
                    if (speed < 0)
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

            double totalSeconds = weight / (speed / 8);

            TimeSpan time = TimeSpan.FromSeconds(totalSeconds);

            int days = time.Days;
            int hours = time.Hours;
            int minutes = time.Minutes;
            int seconds = time.Seconds;
            int milliseconds = time.Milliseconds;

            Console.WriteLine($"\nВремя: {days}д. {hours}ч. {minutes}мин. {seconds}сек. {milliseconds}мс.");
        }
    }
}
