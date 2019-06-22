using System;

namespace countsimvols
{
	class Program
	{
		static void Main(string[] args)
		{

			string name = "ilkin";
			countsimvolinstring(name);
		}


		/// <summary>
		/// sozdeki simvollarin sayini goteren method
		/// </summary>
		/// <param name="word">string parametr</param>

		static void countsimvolinstring(string word) {
			int index = 0; // simvollarin sayini 

			foreach (char item in word)
			{
				foreach (char item1 in word)
				{
					if(item1 == item) //simvollar beraberdise
					{
						index++; // indexi artir
					}
				}

				Console.WriteLine(item + " simvol sayi: " + index); // neticeni goster
				index = 0;//indexsi sifirla
				
			}
			
		}
	}
}
