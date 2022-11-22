internal class Program
{
    private static void Main(string[] args)
    {
        int a = 1;
        int b = 2;
        int sum = 2;
        int c = 0;

        while (c < 4000000)
        {
            c = a + b;
            int iseven = c % 2;
            if(iseven == 0) 
            {
                Console.WriteLine(c);
                if(c < 4000000)
                {
                    //Console.WriteLine("adding " +c);
                    sum = sum + c;
                } 
            }
            int nexta = b;
            int nextb = c;
            a = nexta;
            b = nextb;

        }
        Console.WriteLine(sum);
    }
}