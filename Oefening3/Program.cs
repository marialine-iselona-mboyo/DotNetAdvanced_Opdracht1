// See https://aka.ms/new-console-template for more information

namespace MyApp
{
    public class Oefening3
    {
        public static void Main(String[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                int result = i * 7;

                Console.WriteLine(result); 

                if (result >= 546)
                {
                    break;
                }
            }
        }
    }
}