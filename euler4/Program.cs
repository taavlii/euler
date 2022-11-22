namespace euler4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int highest = 0;
            for (int i = 1; i < 1000; i++)
            {
                for (int y = 1; y < 1000; y++)
                {
                    int looksgood = 1;
                    int iy = i * y;
                    string textlike = iy.ToString();
                    char[] firstarray = textlike.ToCharArray();
                    char[] secondarray = new char[firstarray.Length];
                    int q = 0;


                    for (int z = firstarray.Length - 1; z > -1; z--)
                    {
                        
                        secondarray[q] = firstarray[z];
                        //Console.WriteLine("adding " + firstarray[z]);
                        //Console.WriteLine(secondarray[q] + " was added");
                        q++;
                    }

                    for(int f = 0; f < firstarray.Length; f++)
                    {

                        //Console.WriteLine("comparing "+ firstarray[f] + " and " + secondarray[f]);
                        if (firstarray[f] != secondarray[f])
                        {
                            looksgood = 0;
                        }
                    }





                    if (looksgood == 1 && iy > highest)
                    {
                        highest = iy;
                    }



                    //if(secondarray == firstarray)
                    //{
                    //    Console.WriteLine(iy);
                    //}


                    //calcs.Add(i * y);
                }
            }
            Console.WriteLine(highest);
        }
    }
}