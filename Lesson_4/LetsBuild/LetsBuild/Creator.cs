using System.Collections.Generic;

namespace LetsBuild
{
    public class Creator
    {
        private Building _building = new Building();

        public Dictionary<int, Building> BuildingsTable { get; set; } = new();

        private Creator() { }

        public static Creator GetBuilding() => new Creator();

        public Building Build() => _building;

        /// <summary>
        /// Кол-во квартир
        /// </summary>
        /// <param name="apartments"></param>
        /// <returns></returns>
        public Creator SetApartments(int apartments)
        {
            _building.SetApartments(apartments);
            return this;
        }

        /// <summary>
        /// Кол-во подъездов
        /// </summary>
        /// <param name="entrances"></param>
        /// <returns></returns>
        public Creator SetEntrances(int entrances)
        {
            _building.SetEntrances(entrances);
            return this;
        }

        /// <summary>
        /// Кол-во этажей
        /// </summary>
        /// <param name="floors"></param>
        /// <returns></returns>
        public Creator SetFloors(int floors)
        {
            _building.SetFloors(floors);
            return this;
        }

        /// <summary>
        /// Высота здания
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public Creator SetHeight(double height)
        {
            _building.SetHeight(height);
            return this;
        }

        public Creator AddBuildingToTable()
        {
            BuildingsTable.Add(_building.Number, _building);
            return this;
        }

        public IEnumerable<string> PrintBuildingsTable()
        {
            foreach (KeyValuePair<int, Building> pair in BuildingsTable)
            {
                yield return pair.Key + " - " + pair.Value; ;
            }
        }

        public static implicit operator Building(Creator builder) => builder._building;
    }
}
