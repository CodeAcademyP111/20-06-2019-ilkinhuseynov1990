using System;

namespace edediorta
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] intArray = { 10, 20, 30, 40 };  //massiv

			int[] intArray1 = { 25, 25, 30, 20 }; //massiv

			Console.WriteLine("Brinici massivin ededi ortasi "+findMediumNumber(intArray)); // funcsiyanin caqrilmasi

			Console.WriteLine();  // bosluqun qoyulmasi

			Console.WriteLine("Ikinci massivin ededi ortasi "+findMediumNumber(intArray1)); // funcsiyanin caqrilmasi
		}


		static int findMediumNumber(int[] array) {

			int sum = 0;  // massivin elementlerini toplamaq ucun

			foreach (int item in array)
			{
				sum += item;  //Massivin elemetlerini toplayir;
			}

			sum /= array.Length;  //ededi ortanin tapilmasi


			return sum; // son netice

		}
	}
}
