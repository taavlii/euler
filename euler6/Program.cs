using System.Runtime.InteropServices;

namespace euler6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumsquares =0;
            int squaresums = 0;
            for(int i =1; i < 101; i++)
            {
                sumsquares = sumsquares + i * i;
                squaresums = squaresums + i;
            }
            squaresums = squaresums * squaresums;
            int answer = squaresums - sumsquares;
            Console.WriteLine(answer);
        }
    }
}