using System;

public class data4
{
    public static void Main()
    {
        int[,] data4 = {
            {1,1},
            {2,2},
            {3,9},
            {4,16},
            {5,25},
            {6,36},
            {7,49},
            {8,64},
            {9,81},
            {10,100}
        };
        int i, j;
        for(i=0;i<10;i++)
        {
            for(j = 0; j<2; j++)
            {
                Console.WriteLine(data4[i,j]+" ");
            }
            Console.WriteLine();
        }
    }
}