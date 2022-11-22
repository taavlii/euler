namespace euler1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 0; i < 1000; i++)
            {
                int remainder3 = i % 3;
                int remainder5 = i % 5;
                if (remainder3 == 0)
                {
                    sum = sum + i;
                }
                else if (remainder5 == 0)
                {
                    sum = sum + i;
                }
            }

            Console.WriteLine(sum);

        }
    }
}