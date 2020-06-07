using System;
using System.Linq;

public class Test
{
	public static void Main()
	{
		char[] dic1 = { 'A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T' };	//dic jako skrót od dictionary :)
		char[] dic2 = { 'D', 'G' };
		char[] dic3 = { 'B', 'C', 'M', 'P' };
		char[] dic4 = { 'F', 'H', 'V', 'W', 'Y' };
		char[] dic5 = { 'K' };
		char[] dic6 = { 'J', 'X' };
		char[] dic7 = { 'Q', 'Z' };
		while (true)
		{
			Console.WriteLine("Podaj wyraz który chcesz sprawdzić\nWciśnij 0 jeśli chcesz zakończyć");
			string line = (Console.ReadLine()).ToUpper();
			if (line == "0")
			{
				break;
			}
			else
			{
				int wynik=0;
				for (int i = 0; i < line.Length; i++)
				{
					char znak = line[i];
                    if (dic1.Contains(znak))
                    {
						wynik += 1;
                    }
					else if(dic2.Contains(znak))
					{
						wynik += 2;
					}
					else if (dic3.Contains(znak))
					{
						wynik += 3;
					}
					else if (dic4.Contains(znak))
					{
						wynik += 4;
					}
					else if (dic5.Contains(znak))
					{
						wynik += 5;
					}
					else if (dic6.Contains(znak))
					{
						wynik += 8;
					}
					else if (dic7.Contains(znak))
					{
						wynik += 10;
					}
				}
				Console.WriteLine("Twój wynik to: " + wynik);
			}
		}
	}
}