using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace laba3_program1
{
    class Program
    {
        static void Main(string[] args)
        { 
            string text="";
            Console.WriteLine("=================================================");
            try { 
                text = File.ReadAllText(@"C:\\kpii\\programing\\лабки\\лаба3\\laba3 program1\\text_file.txt"); ///зчитуємо текст з файлу
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message); //виводимо повідомлення при проблемі зі зчитуванням файлу
                Environment.Exit(0); //закінчуємо виконання програми
            }

            Console.WriteLine("Input text: \n"); ///виводимо вхідні дані
            Console.WriteLine(text +'\n');

            text = text.ToLower(); //змінюємо на нижній регістр
            char[] separators = new char[] {' ', '.',',','!','?','+','-','*','/','\\','@','^','(',')','='};
            String[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries); //розбиваємо текст на слова , не враховуючи пробіли та знаки
 
            List<String> ListWord = new List<String>(); //створюємо колекцію отриманих слів    
            ListWord.AddRange(words);
              
            List<String> Result = ListWord.Distinct().ToList(); //виключаємо ті ,які повторюються

            Console.WriteLine("=================================================");
            Console.WriteLine("Words: "+ "\n");                                    //виводимо результат
            Result.ForEach(item => Console.Write(item + "\n"));
            Console.WriteLine("=================================================");
        }
    }
}
