using System;
using Avalonia;

public class HW1
{
    public static long QueueTime(int[] customers, int n)
    {
        int busyCashdecks;
        int time = 0;
    for(time = 0;  customers.Length>0; time++) { 
       

            if (n > customers.Length)
            {
                busyCashdecks = customers.Length;
            }
            else
            {
                busyCashdecks = n;
            }
           
            for (int j = 0; j < busyCashdecks; j++)
            {
                customers[j]--;
            }
            customers = Array.FindAll(customers, x => x != 0);

            
        }
        return time;
    }
}

class Program
{
    public static void Main()
    {
        Console.WriteLine(HW1.QueueTime(new int[] { 5, 3, 4 }, 1) == 12);
        Console.WriteLine(HW1.QueueTime(new int[] { 10, 2, 3, 3 }, 2) == 10);
        Console.WriteLine(HW1.QueueTime(new int[] { 2, 3, 10 }, 2) == 12);
    }

}
