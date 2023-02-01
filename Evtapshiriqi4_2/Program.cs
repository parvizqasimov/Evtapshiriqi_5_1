using EvTapshiriqi_4_2;

namespace Evtapshiriqi4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var conus = new Cone(5, 4, 5);
            Console.WriteLine(conus);
            var silindr = new Cylinder(4, 3);
            Console.WriteLine(silindr);

        }
    }
}