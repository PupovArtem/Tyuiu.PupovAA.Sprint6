using System;
using System.Collections.Generic;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PupovAA.Sprint6.Task6.V21.Lib
{
    public class DataService : ISprint6Task6V21
    {
        public string CollectTextFromFile(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException("Файл не найден", path);
            }

            string text = File.ReadAllText(path);

            
            char[] separators =
            {
                ' ', '\t', '\r', '\n',
                ',', '.', ';', ':', '!', '?',
                '-', '—', '(', ')', '[', ']', '\"', '\'', '/'
            };

            string[] parts = text.Split(
                separators,
                StringSplitOptions.RemoveEmptyEntries);

            List<string> resultWords = new List<string>();

            foreach (string word in parts)
            {

                if (word.Contains('g') || word.Contains('G'))
                {
                    resultWords.Add(word);
                }
            }

            
            return string.Join(" ", resultWords);
        }
    }
}
 