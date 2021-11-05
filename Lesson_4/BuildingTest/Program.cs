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
                .SetApartments(180)
                .SetEntrances(5)
                .SetFloors(9)
                .SetHeight(23).AddBuildingToTable()
                .Build();

            var building3 = Creator.GetBuilding()
                .SetApartments(180)
                .SetEntrances(5)
                .SetFloors(9)
                .SetHeight(23).AddBuildingToTable()
                .Build();

            
            //building1.SetApartments(5); // Ошибка

            Console.WriteLine(building1);
        }
    }
}
