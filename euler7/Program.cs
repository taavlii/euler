namespace euler7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<long> longs= new List<long>();
            
            long starter = 2;
            while(true) 
            {
                bool looksgood = true;
                for (long i = starter /2; i > 1; i--)
                {
                    if(starter % i == 0 )
                    {   
                        //Console.WriteLine(starter+ " does not worky" );
                        looksgood= false;
                        break;
                    }
                }
                if (looksgood)
                {
                    longs.Add(starter);
                    Console.WriteLine("added " + starter);
                }
                if(longs.Count == 10001)
                {
                    Console.WriteLine(longs[10000]);
                    break;
                }
                starter++;
            }
        }
    }
}