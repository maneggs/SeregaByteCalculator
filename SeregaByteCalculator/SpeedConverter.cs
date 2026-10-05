namespace SeregaByteCalculator
{
    public class SpeedConverter
    {
        public static void _SpeedConverter()
        {       
            while(true)
            {
                Console.WriteLine("\nВведи скорость (Мбит/с):\n");

                string? speedString = Console.ReadLine();

                if (double.TryParse(speedString, out double speed))
                {
                    Console.WriteLine($"Скорость: {(speed / 8).ToString("0.##")} МБ/с");

                    break;
                }

                else
                {
                    Console.WriteLine("Введи число!");
                }
            }
        }
    }
}
