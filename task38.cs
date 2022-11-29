using System;

public class MainClass
{
    public static void Main()
    {
        int[] array = new int[5];
        Random rnd = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(0, 999); 
        }
        
        int min = array[0];
        int max = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
                min = array[i];
            if (array[i] > max)
                max = array[i];
        }
        max -= min;

        Console.WriteLine(max);
    }
}