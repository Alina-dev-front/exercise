using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        public static List<int> MakeRandomList(int listLenght) 
        {
            List<int> list = new List<int>();

            var random = new Random();

            for(int i = 0; i < listLenght; i++) 
            {
                int number = random.Next(100);
                list.Add(number);
            }

            return list;
        }

        public static List<int> GetJamnNumbers(List<int> list) 
        {
            List<int> jamnNumbers = new List<int>();
            foreach(var i in list)
            {
                if(i % 2 == 0) 
                {
                    jamnNumbers.Add(i);
                }
            }
            return jamnNumbers;
        }


        static void Main(string[] args)
        {
            int listLenght = 10;
            
            var list = MakeRandomList(listLenght);

            var result = GetJamnNumbers(list);

            foreach(var i in result) 
            {
                Console.WriteLine(i);
            }
        }
    }
}
