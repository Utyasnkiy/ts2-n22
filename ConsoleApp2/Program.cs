using System;
using System.IO;
using System.Collections.Generic;
 // 22 задача 
 // 2 таск
 // только для английских слов

string path = @"C:\Users\Auter\source\repos\ConsoleApp2\ConsoleApp2\Text.txt"; // путь к файлу
Dictionary<string, int> wordFreq = new Dictionary<string, int>(); // словарь для хранения частоты слов

try
{
    // создаем экземпляр класса StreamReader
    using (StreamReader sr = new StreamReader(path))
    {
        string line;
        // читаем файл построчно и обрабатываем каждое слово
        while ((line = sr.ReadLine()) != null)
        {
            string[] words = line.Split(' '); // разбиваем строку на слова
            foreach (string word in words)
            {
                if (wordFreq.ContainsKey(word)) // если слово уже есть в словаре, увеличиваем его частоту на 1
                {
                    wordFreq[word]++;
                }
                else // если слова нет в словаре, добавляем его со значением частоты 1
                {
                    wordFreq.Add(word, 1);
                }
            }
        }
    }

    // выводим словарь в консоль
    foreach (KeyValuePair<string, int> pair in wordFreq)
    {
        Console.WriteLine("Слово: " + pair.Key + " Частота: " + pair.Value);
    }
}
catch (Exception e)
{
    Console.WriteLine("Ошибка чтения файла: " + e.Message);
}