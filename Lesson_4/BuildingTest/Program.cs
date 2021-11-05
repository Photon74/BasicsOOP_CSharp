using System;
using LetsBuild;

namespace BuildingTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var building1 = Creator.GetBuilding()
                .SetApartments(180)
                .SetEntrances(5)
                .SetFloors(9)
                .SetHeight(23).AddBuildingToTable()
                .Build();

            var building2 = Creator.GetBuilding()
                .SetApartments(120)
                .SetEntrances(5)
                .SetFloors(9)
                .SetHeight(27).AddBuildingToTable()
                .Build();

            var building3 = Creator.GetBuilding()
                .SetApartments(100)
                .SetEntrances(5)
                .SetFloors(5)
                .SetHeight(13).AddBuildingToTable()
                .Build();

            
            Console.WriteLine(building1);
            Console.WriteLine(building2);
            Console.WriteLine(building3);
        }
    }
}
