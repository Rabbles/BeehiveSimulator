using BeehiveSimulator.Properties;
using System;
using System.Drawing;

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

        private Hive _hive;
        private World _world;

        public int Age { get; private set; }
        public bool InsideHive { get; private set; }
        public double NectarCollected { get; private set; }
        public Point Location => _location;

        public BeeState CurrentState { get; private set; }

        public Bee(int id, Point location, Hive hive, World world)  
        {
            _location = location;
            Age = 0;
            ID = id;
            InsideHive = true;
            destinationFlower = null;
            NectarCollected = 0;
            CurrentState = BeeState.Idle;
            _hive = hive;
            _world = world;
        }

        public void Go(Random random)
        {
            Age++;

            switch (CurrentState)
            {
                case BeeState.Idle:
                    if(Age > CareerSpan)
                    {
                        CurrentState = BeeState.Retired;
                    }
                    else if(_world.Flowers.Count > 0 && _hive.ConsumeHoney(HoneyConsumed))
                    {    
                        var flower =_world.Flowers[random.Next(_world.Flowers.Count)];

                        if(flower.TotalNectar >= MinimumFlowerNectar && flower.Alive)
                        {
                            destinationFlower = flower;
                            CurrentState = BeeState.FlyingToFlower;
                        }
                    }
                    break;

                case BeeState.FlyingToFlower:
                    if(!_world.Flowers.Contains(destinationFlower))
                    {
                        CurrentState = BeeState.ReturningToHive;
                    }
                    else if(InsideHive)
                    {
                        if(MoveTowardsLocation(_hive.GetLocation(Resources.Exit)))
                        {
                            InsideHive = false;
                            _location = _hive.GetLocation(Resources.Entrance);
                        }
                    }
                    else if(MoveTowardsLocation(destinationFlower.Location))
                    {
                        CurrentState = BeeState.GatheringNectar;
                    }

                    break;

                case BeeState.GatheringNectar:
                    var nectar = destinationFlower.HarvestNectar();

                    if (nectar > 0)
                    {
                        NectarCollected += nectar;
                    }
                    else
                    {
                        CurrentState = BeeState.ReturningToHive;
                    }

                    break;

                case BeeState.MakingHoney:
                    
                    if(NectarCollected > 0.5)
                    {
                        NectarCollected = 0;
                        CurrentState = BeeState.Idle;
                    }

                    break;

                case BeeState.ReturningToHive:

                    if(!InsideHive)
                    {
                        // move towards hive
                    }
                    else
                    {
                        //todo
                    }
                    break;

                case BeeState.Retired:
                    break;
            }
        }

        /// <summary>
        /// Returns true when bee reaches it's destination.
        /// </summary>
        /// <param name="destination"></param>
        private bool MoveTowardsLocation(Point destination)
        {
            if(Math.Abs(destination.X - _location.X) <= MoveRate && Math.Abs(destination.Y - _location.Y) <= MoveRate)
            {
                return true;
            }

            if (destination.X > _location.X)
            {
                _location.X += MoveRate;
            }
            else if(destination.X < _location.X)
            {
                _location.X -= MoveRate;
            }

            if (destination.Y > _location.Y)
            {
                _location.Y += MoveRate;
            }
            else if (destination.Y < _location.Y)
            {
                _location.Y -= MoveRate;
            }

            return false;

        }
        
    }
}
