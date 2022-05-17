using System;

public class Program
{
	public static void Main()
	{
		Console.Write("Введите количество элементов первого массива:\t");
		int elementsCount1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите количество элементов второго массива:\t");
		int elementsCount2 = Convert.ToInt32(Console.ReadLine());

        int[] a1 = new int[elementsCount1];
		
		int[] a2 = new int[elementsCount2];
		
        int s = 0;
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
        
        int a = 0;
        Console.Write("Введите позицию начала замены:\t");
        a=Convert.ToInt32(Console.ReadLine());

        Array.Resize(ref a1, elementsCount1+a);

        for (int i = a; i < a1.Length; i++)
           {
               int j = 0;
               a1[i] = a2[j];
               j++;
           }

        Console.Write("Значения первого массива:\t");

        for (int i = 0; i < a1.Length; i++)
           {
		      Console.WriteLine(a1[i]);
           }


	}
}