using System;
using System.Collections.Generic;
using System.Linq;

					
public class Program
{
	static List<int> fromApi = new List<int>() { 1, 1, 9, 6, 6, 6, 9, 7 };
    int listLength = fromApi.Count();
	
	public int Main()
	{
		int arrayLength = listLength;
		List<int> uniqueArray = new List<int>();

		for(int i = 0; i < arrayLength; i++)
		{
			int element = fromApi[i];
			if(!uniqueArray.Contains(element))
			{
				uniqueArray.Add(element);
			}
		}
		Console.WriteLine(uniqueArray.Count());
		return uniqueArray.Count();
	}
}
