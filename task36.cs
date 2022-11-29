using System;

public class MainClass
{
    public static void Main()
    {
        int[] array = new int[4];
        Random rnd = new Random();
    
        int sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(-99, 99); 
        }
        
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 != 0)
            sum += array[i];
        }

        Console.WriteLine(sum);
    }
}