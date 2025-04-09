using Countries;
using static C_._29._03._25.DZ.Program;

namespace C_._29._03._25.DZ
{

    public class Program
    {
        
        static void Main(string[] args)
        {




            var chinaWall = new ChinaWall();
            Console.WriteLine($"{chinaWall.Name}: {chinaWall.Description}");

            var pyramidCheops = new PyramidCheops();
            Console.WriteLine($"{pyramidCheops.Name}: {pyramidCheops.Description}");

            var garderSemiramis = new GarderSemiramis();
            Console.WriteLine($"{garderSemiramis.Name}: {garderSemiramis.Description}");

            var statueZeus = new StatueZeus();
            Console.WriteLine($"{statueZeus.Name}: {statueZeus.Description}");

            var templeArtemis = new TempleArtemis();
            Console.WriteLine($"{templeArtemis.Name}: {templeArtemis.Description}");

            var alexandriaLighthouse = new AlexandriaLighthouse();
            Console.WriteLine($"{alexandriaLighthouse.Name}: {alexandriaLighthouse.Description}");

            var colossusRhodes = new ColossusRhodes();
            Console.WriteLine($"{colossusRhodes.Name}: {colossusRhodes.Description}");

 
            var brazilia = new Countries.Braziliya.Brazilia();
            var beijing = new Countries.China.Beijing();
            var newDelhi = new Countries.India.NewDelhi();

            Console.WriteLine($"{brazilia.Name}: {brazilia.Population}");
            Console.WriteLine($"{beijing.Name}: {beijing.Population}");
            Console.WriteLine($"{newDelhi.Name}: {newDelhi.Population}");

        }
    }
}
