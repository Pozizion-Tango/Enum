using System;

namespace Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool stop = false;//A bool used to help stop the loop when the user wants it.
            Hat hat = new Hat();//Creates new "sorting hat"
            while (!stop)
            {
                Console.WriteLine(hat.Sort());//displays what college is choosen
                if (Console.ReadLine() == "stop")//Reads if the player wants to stop or not.
                    stop = true;
            }
        }
    }
}
