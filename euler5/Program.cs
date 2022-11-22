namespace euler5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            long tried = 20; 
            while(true)
            {
                bool matches = true;
                for (int i = 1; i < 21; i++)
                {
                    if(tried % i != 0)
                    {
                        matches = false;

                    }
                }
                if(matches == true)
                {
                    Console.WriteLine(tried);
                    break;
                }
                tried++;
            }
        }
    }
}