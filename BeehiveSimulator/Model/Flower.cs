using System.Drawing;

namespace BeehiveSimulator.Model
{
    public class Flower
    {
        private int lifespan;

        public const int LifeSpanMin = 15000;
        public const int LifeSpanMax = 30000;
        public const double InitialNectar = 1.5;

        public Point Location { get; private set; }
        public int Age { get; private set; }
        public bool Alive { get; private set; }
        public double Nectar { get; private set; }
        public double NectarHarvested { get; set; }

        public double HarvestNectar()
        {
            return 0.0;
        }

        public void Go()
        {
            
        }

    }
}
