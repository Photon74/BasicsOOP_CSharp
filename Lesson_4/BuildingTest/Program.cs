using System;
using System.Linq;
using LetsBuild;

namespace BuildingTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new Creator();
            var building1 = builder.GetBuilding()
                .SetApartments(180)
                .SetEntrances(5)
                .SetFloors(9)
                .SetHeight(23)
                .Build();

            var building2 = builder.GetBuilding()
                .SetApartments(120)
                .SetEntrances(5)
                .SetFloors(9)
                .SetHeight(27)
                .Build();

            var building3 = builder.GetBuilding()
                .SetApartments(100)
                .SetEntrances(5)
                .SetFloors(5)
                .SetHeight(13)
                .Build();

            var a = builder.GetBuildingsTable();
            foreach (var building in a) Console.WriteLine(building);
        }
    }
}
