using System;

namespace findspace
{
	class Program
	{
		static void Main(string[] args)
		{

			string name = "Ilkin Ferid"; 


			Console.WriteLine("bosluqlarin sayi : "+findspaceinstring(name));

			Console.WriteLine(); //bosluq buraxmaq ucun

			string[] strArray = { "azer", "vusal","ayaz"};

			// overload prinsipinden istifade etmek

			Console.WriteLine("bosluqlarin sayi: "+findspaceinstring(strArray));
		}

		/// <summary>
		/// gonderilen stringde bosluqun tapilmasi
		/// </summary>
		/// <param name="sen">String ifadennin gonderilmesi</param>
		/// <returns>bosluqlarin sayini hesablayib geriye gonderir</returns>
		static int  findspaceinstring( string sen) {

			int count = 0; //bosluqlarin sayini yazmaq ucun

			for (int i = 0; i < sen.Length; i++)
			{

				if (sen[i] == ' ')  //sert odendikde sayi artir
				{

					count++;  //sayi artir
				}
			}


			return count;  // cixisa ver
		}


		static int findspaceinstring(params string[] array) {

			int count = 0;  //bosluqlarin sayini artirmaq ucun

			string concat=""; //gonderilen string birlesdirmek ucun

			foreach (string item in array)
			{

				if (item != array[0])
				{
					concat = " " + item;  //elemetleri birlesdirmek

					count++; // bosluq sayini artirmaq
				}
				else {
					concat += item; //ilk elementin qarsisindan bosluqu goturmek;
				}

			}

			

			return count; // sayi cixisa vermek
		}
	}
}
