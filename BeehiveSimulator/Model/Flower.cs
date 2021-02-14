using System;
using System.Drawing;

namespace BeehiveSimulator.Model
{
    public class Flower
    {
        private readonly int lifespan;

        private const int MinimumLifeSpan = 15000;
        private const int MaximumLifeSpan = 30000;
        private const double InitialNectar = 1.5;
        private const double MaximumNectar = 5.0;
        private const double NectarAddedPerGrowthCycle = 0.01;
        private const double NectarGatheredPerGrowthCycle = 0.3;


        public Point Location { get; private set; }
        public int Age { get; private set; }
        public bool Alive { get; private set; }
        public double TotalNectar { get; private set; }
        public double NectarHarvested { get; set; }

        public Flower(Point location, Random random)
        {
            Location = location;
            TotalNectar = InitialNectar;
            NectarHarvested = 0;
            Age = 0;
            Alive = true;
            lifespan = random.Next(MinimumLifeSpan, MaximumLifeSpan + 1);
        }

        public double HarvestNectar()
        {

            if (NectarGatheredPerGrowthCycle > TotalNectar)
            {
                return 0;
            }
            else
            {
                TotalNectar -= NectarGatheredPerGrowthCycle;
                NectarHarvested += NectarGatheredPerGrowthCycle;
                return NectarGatheredPerGrowthCycle;
            }
        }

        public void Go()
        {
            Age++;

            if(Age > lifespan)
            {
                Alive = false;
            }
            else
            {
                TotalNectar += NectarAddedPerGrowthCycle;
                if (TotalNectar > MaxNectar)
                {
                    TotalNectar = MaxNectar;
                }
            }
        }

    }
}
