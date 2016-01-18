using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimplexLayersDemo
{
    /// <summary>
    /// Handles rendering behavior
    /// </summary>
    class Renderer
    {
        /// <summary>
        /// Store for the progress bar of the application.
        /// </summary>
        public ProgressBar progressBar;
        /// <summary>
        /// Width of the map
        /// </summary>
        private int x;
        /// <summary>
        /// Height of the map
        /// </summary>
        private int y;
        /// <summary>
        /// The values held by the renderer
        /// </summary>
        private float[,] map;

        /// <summary>
        /// Get a new renderer of the given size
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Renderer(int x, int y)
        {
            this.x = x;
            this.y = y;
            map = new float[x, y];
        }

        /// <summary>
        /// Get the content as a bitmap
        /// </summary>
        /// <returns>The rendered content.</returns>
        public Bitmap RenderBitmap()
        {
            Bitmap output = new Bitmap(x, y);
            Graphics outputGraphics = Graphics.FromImage(output);

            float numberPx = x * y;
            float numberPxLeft = numberPx;

            for (int i = 0; i < x; i++)
            {
                for(int j = 0; j < y; j++)
                {
                    int val = (int)(map[i, j] * 255);
                    Color color = Color.FromArgb(val , val, val);
                    Brush brush = new SolidBrush(color);
                    outputGraphics.FillRectangle(brush, i, j, 1, 1);
                    numberPxLeft -= 1.0f;
                    if(progressBar != null)
                        progressBar.Value = 100 - (int)((numberPxLeft / numberPx) * 50.0f);
                }
            }

            return output;
        }

        /// <summary>
        /// Builds the map of 2D simplex noise.
        /// </summary>
        /// <param name="layers">Number of layers of simplex noise to apply</param>
        /// <param name="scale">Sample width for the noise function. Higher width introduces more
        /// variance between two positions.</param>
        public void AddSimplexNoise(int layers, float scale)
        {
            if (layers <= 0)
                return;

            float numberPx = x * y;
            float numberPxLeft = numberPx;

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    //Here we sum from the broadest layers to the most detailed.
                    //With infinite layers, this sum will max at 1, so any positive number will be safe.
                    for(float k = 0f; k < layers; k += 1.0f)
                    {
                        map[i, j] += GetNoise(i, j, scale * (float)Math.Pow(2, k), 0.5f * (float)Math.Pow(0.5, k));
                    }
                    numberPxLeft -= 1.0f;
                    progressBar.Value = 50 - (int)((numberPxLeft / numberPx) * 50.0f);
                }
            }
        }

        /// <summary>
        /// Wrapper for the generate function in the noise lib.
        /// </summary>
        /// <param name="x">The x-coordinate to sample</param>
        /// <param name="y">The y-coordinate to sample</param>
        /// <param name="scale">The scale to sample on. Higher scales produce higher variance between
        /// sample positions.</param>
        /// <param name="max">The maximum value to return.</param>
        /// <returns></returns>
        private float GetNoise(int x, int y, float scale, float max)
        {
            return (SimplexNoise.Noise.Generate(x * scale, y * scale) + 1f) * (max / 2f);
        }
    }
}
