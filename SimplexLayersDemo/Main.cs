using System;
using System.Drawing;
using System.Windows.Forms;

/// <summary>
/// Application to demonstrate layered 2D simplex noise.
/// </summary>
namespace SimplexLayersDemo
{
    public partial class Main : Form
    {
        Random rng = new Random();

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e) { }

        private void ButtonRender_Click(object sender, EventArgs e)
        {
            int x = pictureBox2.Width;
            int y = pictureBox2.Height;
            int layers = (int)NumericLayers.Value;
            float scale = float.Parse(TextBoxScale.Text);
            int seed = (int)float.Parse(TextBoxSeed.Text);

            if (scale <= 0)
            {
                LogToConsole("Scale must be greater than zero.");
                return;
            }
            Renderer renderer = new Renderer(x, y);
            renderer.progressBar = ProgressBar;
            renderer.AddSimplexNoise(layers, scale, seed);
            pictureBox2.Image = renderer.RenderBitmap();
            ProgressBar.Value = 0;
            LogToConsole("Done");
        }

        private void LogToConsole(String str)
        {
            LabelConsolePrint.Text = str;
        }

        private void ButtonRollSeed_Click(object sender, EventArgs e)
        {
            TextBoxSeed.Text = "" + rng.Next();
        }
    }
}
