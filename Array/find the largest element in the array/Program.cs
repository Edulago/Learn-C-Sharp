using System;

class Progrma
{
    public static void Main(string[] args)
    {
        int[] array = new int[] { 18, 21, 37, 30, 91, 99, 12};

        int aux = array[0];

        for(int i = 1; i < array.Length; i++)
        {
            if(array[i] > aux)
            {
                aux = array[i];
            }
        }
        Console.WriteLine(aux);
    }
}