using System.Text;

namespace SeregaByteCalculator
{
    public class SymbolCounter
    {
        public static void _SymbolCounter()
        {
            Console.OutputEncoding = Encoding.UTF8;

            while(true)
            {
                Console.WriteLine("\nВведи текст:");

                string? text = Console.ReadLine();

                if(!string.IsNullOrWhiteSpace(text))
                {
                    int ru = 0, en = 0, digits = 0, spaces = 0, puncts = 0, emojiChars = 0;

                    foreach (char c in text)
                    {
                        if (char.IsSurrogate(c)) emojiChars++; 
                        else if ((c >= 'А' && c <= 'я') || c == 'Ё' || c == 'ё') ru++;
                        else if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z')) en++;
                        else if (char.IsDigit(c)) digits++;
                        else if (char.IsWhiteSpace(c)) spaces++;
                        else if (char.IsPunctuation(c)) puncts++;
                    }

                    int emojiCount = emojiChars / 2;

                    int realBytes = Encoding.UTF8.GetByteCount(text);

                    Console.WriteLine($"\nРусских: {ru}, Латиницы: {en}, Цифр: {digits}, Пробелов: {spaces}, Знаков: {puncts}, Эмодзи: {emojiCount}");
                    Console.WriteLine($"Длина строки:   {text.Length}");
                    Console.WriteLine($"Реальный вес в UTF-8:    {realBytes} байт");

                    break;
                }

                else
                {
                    Console.WriteLine("Введи текст!");
                }
            }
        }
    }
}
