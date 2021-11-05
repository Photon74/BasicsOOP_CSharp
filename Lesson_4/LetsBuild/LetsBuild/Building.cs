using System;
using System.Collections.Generic;

namespace LetsBuild
{
    public class Building
    {
        private static int _id;

        internal Building()
        {
            Number = ++_id;
            Height = 3;
            Floors = 1;
            Apartments = 1;
            Entrances = 1;
        }

        public int Number { get; }
        public double Height { get; internal set; }
        public int Floors { get; internal set; }
        public int Apartments { get; internal set; }
        public int Entrances { get; internal set; }

        /// <summary>
        /// Кол-во квартир
        /// </summary>
        /// <param name="apartments"></param>
        /// <returns></returns>
        internal void SetApartments(int apartments)
        {
            Apartments = apartments;
        }

        /// <summary>
        /// Кол-во подъездов
        /// </summary>
        /// <param name="entrances"></param>
        /// <returns></returns>
        internal void SetEntrances(int entrances)
        {
            Entrances = entrances;
        }

        /// <summary>
        /// Кол-во этажей
        /// </summary>
        /// <param name="floors"></param>
        /// <returns></returns>
        internal void SetFloors(int floors)
        {
            Floors = floors;
        }

        /// <summary>
        /// Высота здания
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        internal void SetHeight(double height)
        {
            Height = height;
        }

        private double FloorHeight()
        {
            if (Floors == 0) return 1;
            return Height / Floors;
        }

        private int ApartmentsInEntrance()
        {
            if (Entrances == 0) return 1;
            return Apartments / Entrances;
        }

        private int ApartmentsOnFloor()
        {
            if (Floors == 0) return 1;
            return ApartmentsInEntrance() / Floors;
        }

        public override string ToString()
        {
            return $"Номер дома: {Number}\n" +
                $"Кол-во этажей: {Floors}\n" +
                $"Кол-во подъездов: {Entrances}\n" +
                $"Кол-во квартир: {Apartments}\n" +
                $"Высота потолков: {FloorHeight():F2}\n" +
                $"Кол-во квартир в подъезде: {ApartmentsInEntrance()}\n" +
                $"Кол-во квартир на этаже: {ApartmentsOnFloor()}\n";
        }
    }
}
