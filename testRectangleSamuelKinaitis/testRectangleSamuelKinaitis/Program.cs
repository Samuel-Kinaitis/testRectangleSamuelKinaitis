using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Samuel Kinaitis 10.3 
namespace testRectangleSamuelKinaitis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Ask for date input
            //Length
            Console.WriteLine("Length of rectangle is");
            float length = float.Parse(Console.ReadLine());
            //Width
            Console.WriteLine("Width of rectangle is");
            float width = float.Parse(Console.ReadLine());

            //Date output
            Rectangle rect = new Rectangle(length, width);
            Console.WriteLine(rect);
            //Pause/exit
            Console.WriteLine("Press enter to close the program");
            Console.ReadLine();
        }
    }
}
