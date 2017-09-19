using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /* The next part is just for fun. It's boring just to write
             * the same "Hello World!" again and again, isn't it?
             */

            Console.WriteLine("\n");

            String helloWorld = "Hello Beautiful World!\n\n";
            String word = "";
            int position = 0;
            Console.WriteLine(helloWorld);

            do
            {
                if (helloWorld.ElementAt(position) != '!' && helloWorld.ElementAt(position) != ' ')
                {
                    word += helloWorld.ElementAt(position);
                    position++;
                }
                else
                {
                    Console.WriteLine(word + "!\n");
                    word = "";
                    position++;
                }
            }
            while (position < helloWorld.Length);

            Console.WriteLine("press any key to exit");
            Console.ReadKey();
        }
    }
}
