using System;

namespace Mappy.Net.Test
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Object2 mapped = Mapper.Map<Object2>(new Object1()
            {
                T_est = "Testy"
            });
            
            Console.WriteLine(mapped.Test);
        }
    }
}