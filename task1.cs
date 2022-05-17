using System;

public class Program
{
	public static void Main()
	{
		Console.Write("Введите количество элементов первого массива:\t");
		int elementsCount1 = Convert.ToInt32(Console.ReadLine());
		int[] a1 = new int[elementsCount1];
		Console.Write("Введите количество элементов второго массива:\t");
		int elementsCount2 = Convert.ToInt32(Console.ReadLine());
		int[] a2 = new int[elementsCount2];
		int s=0;
		Console.Write("Введите значения первого массива:\t");
		for (int i = 0; i < elementsCount1; i++)
           {
               a1[i]=Convert.ToInt32(Console.ReadLine());
           }
		Console.Write("Введите значения второго массива:\t");
		for (int j = 0; j < elementsCount1; j++)
           {
               a1[j]=Convert.ToInt32(Console.ReadLine());
           }
	}
}