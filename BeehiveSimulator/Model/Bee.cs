using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveSimulator.Model
{
    public class Bee
    {
        private Point _location;
        private int ID;
        private Flower destinationFlower;

        private const double HoneyConsumed = 0.5;
        private const double MinimumFlowerNectar = 1.5;
        private const int MoveRate = 3;
        private const int CareerSpan = 1000;

        public int Age { get; private set; }
        public bool InsideHive { get; private set; }
        public double NectarCollected { get; private set; }
        public Point Location { get { return _location; } }

        public Bee(int id, Point location)  
        {
            _location = location;
            Age = 0;
            ID = id;
            InsideHive = true;
            destinationFlower = null;
            NectarCollected = 0;
        }

        public void Go(Random random)
        {
            Age++;
        }
        
    }
}
