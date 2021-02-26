﻿using System;
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
        private World _world;

        public Hive(World world)
        {
            Honey = IntiialHoney;
            _world = world;
            InitialiseLocations();

            var random = new Random();

            for(var i = 0; i < InitialBees; i++)
            {
                AddBee(random);
            }     
        }


        public void InitialiseLocations() 
        {
            _locations = new Dictionary<string, Point> {{ "Entrance", new Point(600, 100)}, 
                                                        { "Nursery", new Point(95, 174)}, 
                                                        { "Honey Factory", new Point(157, 98)}, 
                                                        { "Exit", new Point(194, 213)}};
        }

        public bool AddHoney(double nectar) 
        {
            var honeyToAdd = nectar * NectarToHoneyRatio;

            if(honeyToAdd + Honey > MaximumHoneyStorageOfHive)
            {
                return false;
            }

            Honey += honeyToAdd;

            return true;
        }

        public bool ConsumeHoney(double amount) 
        {
            if (amount > Honey)
            {
                return false;
            }
            else
            {
                Honey -= amount;
                return true;
            }

        }

        public void AddBee(Random random) 
        {
            _beeCount++;
            var random1 = random.Next(100) - 50;
            var random2 = random.Next(100) - 50;
            var startPoint = new Point(_locations["Nursery"].X + random1,
                                       _locations["Nursery"].Y + random2);
            var newBee = new Bee(_beeCount, startPoint, this, _world);
        }

        public void Go(Random random) 
        {
            if (Honey > MinimumHoneyToProduceBees && random.Next(10) == 1)
            {
                AddBee(random);
            }
        }

        public Point GetLocation(string location) 
        {
            return _locations.ContainsKey(location) ? _locations[location] : throw new ArgumentException($"Unknown location: {location}");
        }

    }
}
