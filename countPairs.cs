using System;
using System.Collections.Generic;
using System.Linq;
					
public class Program
{
	// api call imitation
	static List<int> fromApi = new List<int>() { 1, 1, 9, 6, 6, 6, 9, 7 };
    int listLength = fromApi.Count();
	
	public int Main()
	{
		int arrayLength = listLength;
		IDictionary<int, int> result = new Dictionary<int, int>();
		
            for (int i = 0; i < arrayLength; i++)
            {
                int element = fromApi[i];
                if(result.ContainsKey(element))
                {
                    result[element] += 1;
                } else
                {
                    result[element] = 1;
                }
            }
			int numberOfPairs = 0;
			foreach(var index in result)
				{
					if(index.Value ==2) {
						numberOfPairs++;
					}
				}
			            
			Console.WriteLine(numberOfPairs);
      return numberOfPairs;
	}
}
