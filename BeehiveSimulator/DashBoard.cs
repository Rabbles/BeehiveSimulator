using System;
using System.Windows.Forms;

namespace BeehiveSimulator
{
    public partial class Dashboard : Form
    {
        private World _world;
        private int _framesRun;
        public Dashboard()
        {
            InitializeComponent();
           _world = new World();
        }

        private void UpdateStatistics(TimeSpan frameDuration)
        {
            LblBees.Text = _world.Bees.Count.ToString();
            LblFlowers.Text = _world.Flowers.Count.ToString();
            LblHoneyInHive.Text = $"{_world.Hive.Honey:f3}";
            var nectar = 0.0;

            foreach (var flower in _world.Flowers)
            {
                nectar += flower.NectarHarvested;
            }

            LblNectarInFlowers.Text = $"{nectar:f3}";
            LblFramesRun2.Text = _framesRun.ToString();

            if (frameDuration.TotalMilliseconds != 0.0)
            {
                LblFrameRate2.Text = $"{1000 / frameDuration.TotalMilliseconds:f0}  ({frameDuration.TotalMilliseconds:f1}ms)";
            }
            else 
            {
                LblFrameRate2.Text = "N/A";
            }
        }
    }
}
