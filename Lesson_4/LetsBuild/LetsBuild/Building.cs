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

        internal void SetApartments(int apartments)
        {
            Apartments = apartments;
        }

        internal void SetEntrances(int entrances)
        {
            Entrances = entrances;
        }

        internal void SetFloors(int floors)
        {
            Floors = floors;
        }

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
