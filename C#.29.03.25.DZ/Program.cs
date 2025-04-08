
using Countries;
using static C_._29._03._25.DZ.Program;

namespace C_._29._03._25.DZ
{

    public class Program
    {
        
        static void Main(string[] args)
        {




            var GreatWall = new SevenWonders.ChinaWall();
            Console.WriteLine($"{ChinaWall.Name}: {ChinaWall.Description}");

            var brazilia = new Countries.Braziliya.Brazilia();
            var beijing = new Countries.China.Beijing();
            var newDelhi = new Countries.India.NewDelhi();

            Console.WriteLine($"{brazilia.Name}: {brazilia.Population}");
            Console.WriteLine($"{beijing.Name}: {beijing.Population}");
            Console.WriteLine($"{newDelhi.Name}: {newDelhi.Population}");

        }
    }
}
