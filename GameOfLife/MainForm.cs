using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace GameOfLife
{
    /// <summary>
    /// Main form of the software.
    /// </summary>
    public partial class MainForm : Form
    {
        int cells;
        Grid grid;
        Bitmap bitmap;
        SolidBrush brushCell;
        SolidBrush brushGrid;
        Graphics panelGraphics;
        Graphics bitmapGraphics;

        /// <summary>
        /// Constructor.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loading everything when the form is shown.
        /// </summary>
        private void Loading(object sender, EventArgs e)
        {
            // Create the graphics
            panelGraphics = panelDraw.CreateGraphics();

            // Create the bitmap
            bitmap = new Bitmap(panelDraw.Width, panelDraw.Height);

            // Create the brushes
            brushCell = new SolidBrush(Color.Lavender);
            brushGrid = new SolidBrush(Color.FromArgb(33,33,33));

        }

        /// <summary>
        /// Displaying the grid.
        /// </summary>
        private void DrawGrid()
        {
            // Reset the cells counter
            cells = 0;

            // Reset the bitmap
            bitmap = new Bitmap(panelDraw.Width, panelDraw.Height);

            // Reset the bitmap graphics
            bitmapGraphics = Graphics.FromImage(bitmap);

            // Clear the bitmap with panel back color before drawing
            bitmapGraphics.Clear(panelDraw.BackColor);

            // Draw every cells on the bitmap
            for (int x = 0; x < grid.Width; x++)
            {
                for (int y = 0; y < grid.Height; y++)
                {
                    if (grid.Cells[x, y].IsActive == 1)
                    {
                        // Draw only alive cells
                        bitmapGraphics.FillRectangle(brushCell, x * grid.Scale, y * grid.Scale, grid.Scale, grid.Scale);

                        // Increase the counter
                        cells++;
                    }
                }
            }

            // Display the bitmap
            panelGraphics.DrawImage(bitmap, 0, 0);
        }

        /// <summary>
        /// Click on "Start" button.
        /// </summary>
        private void StartClick(object sender, EventArgs e)
        {
            // Init the parameters of the grid
            int scale = 1;
            int spawns = 0;

            try
            {
                // Get user inputs
                scale = Convert.ToInt32(tbScale.Text);
                spawns = Convert.ToInt32(tbSpawnCount.Text);
            }
            catch
            {
                // Notify the user
                MessageBox.Show("Wrong parameters, please check your inputs");
            }
            
            // Makes sure every parameters are good
            if (spawns > 0 && scale > 0)
            {
                // If there is enough space to spawn all the cells
                if (spawns < (panelDraw.Width * panelDraw.Height) / (scale * scale))
                {
                    // Create the grid
                    grid = new Grid(panelDraw.Width, panelDraw.Height, scale);

                    // Generate the cells
                    grid.Generate(spawns);

                    // Start the timer
                    timer.Start();
                }
                else
                {
                    // Notify the user
                    MessageBox.Show("Not enough space to spawn all the cells, reduce scale or cells.\nMaximum capacity with current scale :" + (panelDraw.Width * panelDraw.Height) / (scale * scale));
                }
            }
        }

        /// <summary>
        /// Timer's tick.
        /// </summary>
        private void TimerTick(object sender, EventArgs e)
        {
            // Upgrade the grid
            grid.Update();

            // Draw the grid
            DrawGrid();

            // Display the informations
            lGenerations.Text = grid.Generations.ToString();
            lDestroyed.Text = grid.Deaths.ToString();
            lCreated.Text = grid.Births.ToString();
            lCells.Text = cells.ToString();
        }

        /// <summary>
        /// Happens when the user scroll on the track bar.
        /// </summary>
        private void TimeScroll(object sender, EventArgs e)
        {
            // Refresh the timer's interval
            timer.Interval = trackTime.Value;

            // Display the time
            lTime.Text = trackTime.Value.ToString();
        }

        /// <summary>
        /// Happens when the user click on the grid.
        /// </summary>
        private void GridClick(object sender, MouseEventArgs e)
        {
            if (grid != null)
            {
                grid.SpawnStarship(e.X, e.Y, Starships.LightWeight);
            }
        }
    }
}
