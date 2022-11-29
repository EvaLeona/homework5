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
        
        int more = 0;
        int less = 0;
        int a = 0;
        int e = a + 1;
        for (int n = array.Length; n > 0; n--)
        {
            while (e < n)
            {
                if (array[a] < array[e])
                {
                    more = array[e];
                    less = array[a];
                    array[e] = less;
                    array[a] = more;
                }
                a++;
                e++;
            }
            a = 0;
            e = a + 1;
        }
        foreach (var num in array)
        {
            Console.Write(num + " ");
        }
    }
}