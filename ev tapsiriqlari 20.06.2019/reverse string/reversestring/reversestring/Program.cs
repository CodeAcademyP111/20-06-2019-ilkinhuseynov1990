using System;

namespace reversestring
{
	class Program
	{
		static void Main(string[] args)
		{

			string name = "salam ilkin";

			Console.WriteLine(reverseinstring(name));

		}

		/// <summary>
		/// String ifadeni tersden duzmek 
		/// </summary>
		/// <param name="word"> Gonderilen string deyer</param>
		/// <returns>Geriye string donder</returns>

		static string reverseinstring (string word)
		{
			string result = ""; //string neticenin saxlamaq ucun

			for (int i = word.Length-1; i >= 0; i--)
			{
				result += word[i];//herfleri tersden duzmek ucun;
			}


			return result; //neticenin geriye dondermek
		}
	}
}
