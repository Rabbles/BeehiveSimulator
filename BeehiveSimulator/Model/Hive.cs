using System;
using System.Collections.Generic;
using System.Drawing;

namespace BeehiveSimulator.Model
{
    public class Hive
    {
        private const int InitialBees = 6;
        private const int MaximumBees = 8;
        private const double IntiialHoney = 3.2;
        private const double MaximumHoneyStorageOfHive = 15.0;
        private const double NectarToHoneyRatio = 0.25;
        private const double MinimumHoneyToProduceBees = 4;

        private int _beeCount;
        private Dictionary<string, Point> _locations;
        public double Honey { get; private set; }

        public Hive()
        {
            Honey = IntiialHoney;
            InitialiseLocations();

            var random = new Random();

            for(var i = 0; i < InitialBees; i++)
            {
                AddBee(random);
            }
        }


        public void InitialiseLocations() 
        {
            _locations = new Dictionary<string, Point> { { "Entrance", new Point(600, 100)}, { "Nursery", new Point(95, 174)}, { "Honey Factory", new Point(157, 98)}, { "Exit", new Point(194, 213)}};
        }

        public bool AddHoney(double nectar) { return false; }

        public bool ConsumeHoney(double amount) { return false; }

        public void AddBee(Random random) { }

        public void Go(Random random) { }

        public Point GetLocation(string location) 
        {
            return _locations.ContainsKey(location) ? _locations[location] : throw new ArgumentException($"Unknown location: {location}");
        }

    }
}
