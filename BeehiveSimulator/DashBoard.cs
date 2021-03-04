using BeehiveSimulator.Properties;
using System;
using System.Windows.Forms;

namespace BeehiveSimulator
{
    public partial class Dashboard : Form
    {
        private World _world;
        private Random _random = new Random();
        private DateTime _start = DateTime.Now;
        private DateTime _end;
        private int _framesRun;
        public Dashboard()
        {
            InitializeComponent();
           _world = new World();
            timer1.Interval = 50;
            timer1.Tick += RunFrame;
            timer1.Enabled = false;
            UpdateStatistics(new TimeSpan());
        }

        private void RunFrame(object sender, EventArgs e)
        {
            _framesRun++;
            _world.Go(_random);
            _end = DateTime.Now;
            var frameDuration = _end - _start;
            UpdateStatistics(frameDuration);
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
                LblFrameRate2.Text = Resources.NotApplicable;
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                StatusLabel.Text = Resources.ResumeSimulation;
                timer1.Stop();
            }
            else
            {
                StatusLabel.Text = Resources.PauseSimulation;
                timer1.Start();
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            _framesRun = 0;
            _world = new World();

            if(!timer1.Enabled)
            {
                StatusLabel.Text = Resources.StartSimulation;
            }
        }
    }
}
