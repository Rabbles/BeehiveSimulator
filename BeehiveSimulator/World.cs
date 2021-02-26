﻿using BeehiveSimulator.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveSimulator
{
    public class World
    {
        private const double NectarHarvestedPerNewFlower = 50.0;
        private const int FieldMinX = 15;
        private const int FieldMinY = 177;
        private const int FieldMaxX = 690;
        private const int FieldMaxY = 290;

        public Hive _hive;
        public List<Bee> Bees;
        public List<Flower> Flowers;

        public World(Hive hive)
        {
            Bees = new List<Bee>();
            Flowers = new List<Flower>();
            _hive = hive;
            var random = new Random();

            for(var i = 0; i < 10; i++)
            {
                AddFlower(random);
            }
        }

        public void Go(Random random)
        {
            _hive.Go(random);

            for (int i = Bees.Count - 1; i >= 0; i--)
            {
                var bee = Bees[i];
                bee.Go(random);

                if (bee.CurrentState == BeeState.Retired)
                {
                    Bees.Remove(bee);
                }
            }

            var totalNectarHarvested = 0.0;

            for (int i = Flowers.Count - 1; i >= 0 ; i--)
            {
                var flower = Flowers[i];
                flower.Go();
                totalNectarHarvested += flower.NectarHarvested;

                if(!flower.Alive)
                {
                    Flowers.Remove(flower);
                }

            }
        }

        private void AddFlower(Random random)
        {
            var location = new Point(random.Next(FieldMinX, FieldMaxY), random.Next(FieldMinY, FieldMaxY));
            var newflower = new Flower(location, random); 
        }
    }
}