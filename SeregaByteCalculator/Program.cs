using SeregaByteCalculator;

public class Program
{
    public static void Main()
    {
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Clear();

        Console.WriteLine("SeregaByteCalculator\n");
        Console.WriteLine("Введи свое имя:");

        string? username = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(username))
        {
            string cleanName = username.Trim();

            Console.WriteLine($"\nПривет, {cleanName}!");
            Console.WriteLine($"Дата: {DateTime.Today:dd.MM.yyyy}\nКол-во символов в имени: {cleanName.Length}");
        }
        else
        {
            Console.WriteLine("\nПривет, Пользователь!");
            Console.WriteLine($"Дата: {DateTime.Today:dd.MM.yyyy}");
        }

        while (true)
        {
            Console.WriteLine("\nВыбери действие\n1 - Калькулятор байтов\n2 - Посчитать реальный объем флешки\n3 - Калькулятор скорости Интернететета\n4 - Посчитать байты в UTF-8\n5 - Расчитать время скачивания\n6 - Расчитать объем спирта в напитке\n");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ByteConverter._ByteConverter();
                    break;

                case "2":
                    VolumeConverter._VolumeConverter();
                    break;

                case "3":
                    SpeedConverter._SpeedConverter();
                    break;

                case "4":
                    SymbolCounter._SymbolCounter();
                    break;

                case "5":
                    TimeDownload._TimeDownload();
                    break;

                case "6":
                    AlcoholCalculator._AlcoholCalculator();
                    break;

                default:
                    Console.WriteLine("\nНезаконно");
                    break;
            }
        }
    }
}