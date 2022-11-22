namespace euler3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long remaining = 600851475143;
            List<long> primes = new List<long>();

            while (remaining > 3)
            {
                int i = 2;
                while (true)
                {
                    long answer = remaining % i;

                    if (answer == 0)
                    {
                        long deleter = remaining / i;
                        primes.Add(i);
                        remaining = remaining - deleter;
                        break;
                    }
                    i++;
                }
            }
            primes.ForEach(Console.WriteLine);
        }
    }
}