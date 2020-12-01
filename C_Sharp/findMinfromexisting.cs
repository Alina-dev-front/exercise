using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> A = new List<int>() {-1,-2,-4,-5};
            int currentMin = 0;
            
            for(var i = 1; i < A.Count; i++) 
            {
                if(!A.Contains(i)) 
                {
                    currentMin = i;
                    break;
                }
            }
            Console.WriteLine(currentMin);
        }
    }
}
