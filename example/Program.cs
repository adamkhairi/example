using System;

namespace example
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            Personne Marwan = new Personne("Marwan Khadiri", 23, 4, 5);
            Personne Adam = new Personne("Adam Khairi", 24, 1, 5);

            Console.WriteLine(Marwan.Refr);
            Marwan.Refr = 0;
            Console.WriteLine(Marwan.Refr);
            
        }
    }
}