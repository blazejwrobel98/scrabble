using System;
using System.Linq;
using System.Collections.Generic;

public class Test
{
	var listaTablic = new List<int[]>
			{
				new int[] { 1, 2, 3 },
				new int[] { 4, 5, 6 },
				new int[] { 7, 8, 9 }
			};
	//static readonly char[] dic1 = { 'A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T' };  //dic jako skrót od dictionary :)
	//static readonly char[] dic2 = { 'D', 'G' };
	//static readonly char[] dic3 = { 'B', 'C', 'M', 'P' };
	//static readonly char[] dic4 = { 'F', 'H', 'V', 'W', 'Y' };
	//static readonly char[] dic5 = { 'K' };
	//static readonly char[] dic6 = { 'J', 'X' };
	//static readonly char[] dic7 = { 'Q', 'Z' };
	public static void Main()
	{
		
		while (true)
		{
			Console.WriteLine("Podaj wyraz który chcesz sprawdzić\nWciśnij 0 jeśli chcesz zakończyć");
			string line = (Console.ReadLine()).ToUpper().Trim();
			if (line == "0")
			{
				break;
			}
			else
			{
				int wynik=0;
				for (int i = 0; i < line.Length; i++)
				{
					wynik += CheckPoints(line[i]);
				}
				Console.WriteLine("Twój wynik to: " + wynik);
			}
		}
	}
	static int CheckPoints(char znak)
    {
		if (dic1.Contains(znak))
		{
			return 1;
		}
		else if (dic2.Contains(znak))
		{
			return 2;
		}
		else if (dic3.Contains(znak))
		{
			return 3;
		}
		else if (dic4.Contains(znak))
		{
			return 4;
		}
		else if (dic5.Contains(znak))
		{
			return 5;
		}
		else if (dic6.Contains(znak))
		{
			return 8;
		}
		else if (dic7.Contains(znak))
		{
			return 10;
		}
		return 0;
	}
}