using System;

class Program
{
    static void Main()
    {

        string hello = @"
███████ ██       ██████  ██    ██  █████  ██████      ██   ██ ██    ██  █████  ██████  ██████   █████  ████████ 
██      ██      ██    ██ ██    ██ ██   ██ ██   ██     ██  ██  ██    ██ ██   ██ ██   ██ ██   ██ ██   ██    ██    
███████ ██      ██    ██ ██    ██ ███████ ██████      █████   ██    ██ ███████ ██   ██ ██████  ███████    ██    
     ██ ██      ██    ██  ██  ██  ██   ██ ██   ██     ██  ██   ██  ██  ██   ██ ██   ██ ██   ██ ██   ██    ██    
███████ ███████  ██████    ████   ██   ██ ██   ██     ██   ██   ████   ██   ██ ██████  ██   ██ ██   ██    ██    
";

        Console.WriteLine(hello);

        List<string> words = new List<string> { "ARTS", "BEST", "CRAB", "DATE", "FIND", "IDEA", "NEXT", "RARE" };
        int pamagite = words.Count;

        Console.WriteLine("Наши словечки");
        for (int i = 0; i < words.Count; i++)
        {
            Console.Write(words[i]);
            Console.Write(" ");
        }

        Console.WriteLine("\n");

        Console.WriteLine("словарные майнкрафтики\n");

        for (int i = 0; i < words.Count; i++)//старт перебора всия руси
        {
            List<string> matchingWords = new List<string>(); //создал новый список

            for (int j = 1; j < words[i].Length; j++)
            {
                char letter = words[i][j];

                for (int k = 0; k < words.Count; k++)
                {
                    if (i != k && words[k][0] == letter)
                    {
                        matchingWords.Add(words[k]); // Добавляем совпадающее слово в список
                    }
                }
            }

            if (matchingWords.Count == (pamagite / 2) - 1) // чекаем если заполнил один квадрат (минус первое слово)
            {
                Console.WriteLine(words[i]);

                for (int m = 0; m < matchingWords.Count; m++) 
                {
                    Console.WriteLine(matchingWords[m]);
                }
                Console.WriteLine();
            }
        }
    }
}
//p.s. Анастасия Константиновна ПОЖАЛУЙСТА НЕ ЗАСТАВЛЯЙТЕ МЕНЯ ДЕЛАТЬ БЛОК СХЕМЫ