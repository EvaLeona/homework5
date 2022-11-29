using System;

public class MainClass
{
    public static void Main()
    {
        int[] array = new int[4];
        Random rnd = new Random();
    
        int even = 0;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(100, 999); 
        
            if (array[i] % 2 == 0)
            even++;
        }
        
        Console.WriteLine(even);
    }
}