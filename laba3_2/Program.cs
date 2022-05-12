using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace laba3_program2
{
    class Program
    { 
        static void Main(string[] args)
        {
            Dictionary<char, int> d1 = new Dictionary<char, int>()
            {
                { 'a', 100},
                { 'b', 200},
                { 'c', 300},
             };

            Dictionary<char, int> d2 = new Dictionary<char, int>()
            {
                { 'a', 300},
                { 'b', 200},
                { 'c', 400},
            };
          
            Dictionary<char, int> d = new Dictionary<char, int>();

            //цикл по ключам першого словника
            foreach (var key in d1.Keys) 
            {
                //якщо такий ключ містить і другий словник
                if (d2.ContainsKey(key)) 
                {
                    //об'єднати значення по цьому ключу
                    //та додати до третього словника
                    d[key] = d1[key] + d2[key];  
                                                     
                }
            }
      
            //виведення результату
            d.Select(i => $"{i.Key}: {i.Value}").ToList().ForEach(Console.WriteLine);

            //зберігання в json
            var toJson = JsonConvert.SerializeObject(d);
            System.IO.File.WriteAllText("C:\\kpii\\programing\\лабки\\лаба3\\laba3 program2\\dictjson.json", toJson);
           
        }
    }
}
