using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace GameOfLife
{
    /// <summary>
    /// Represents a grid of the game of life.
    /// </summary>
    public class Grid
    {
        int scale;
        int births;
        int deaths;
        int generations; 
        Cell[,] cells;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="width">Width of the grid.</param>
        /// <param name="height">Height of the grid.</param>
        /// <param name="scale">Scale of the grid.</param>
        public Grid(int width, int height, int scale)
        {
            this.scale = scale;
            this.cells = new Cell[width / scale, height / scale];
        }

        /// <summary>
        /// Updating the grid.
        /// </summary>
        public void Update()
        {
            // Check and calculate the neighbors of each cells
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    CheckNeighbors(x, y);
                }
            }

            // Check the state of each cells
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    CheckState(x, y);
                }
            }

            // Increase the cycles
            generations++;
        }

        /// <summary>
        ///  Generate a grid of x alive cells.
        /// </summary>
        /// <param name="number">Number of cells to spawn.</param>
        public void Generate(int number)
        {
            // ===================
            // NOTE 
            // ===================
            // I didn't want to spawn cells in a classic way
            // so I came up with this system which will use
            // a minimum amount of randoms and make sure
            // that cells will not be spawned at the same location

            // Create the random object
            Random random = new Random();

            // Create the array who will be used for random spawn
            Cell[] randomCells = new Cell[Width * Height];

            // Let's populate the array with alive cells
            for (int i = 0; i < number; i++)
            {
                randomCells[i] = new Cell(1);
            }

            // Let's populate the rest of the array with dead cells
            for (int i = number; i < randomCells.Length; i++)
            {
                randomCells[i] = new Cell(0);
            }

            // Shuffle the spawned cells
            for (int i = 0; i < number; i++)
            {
                // Make the rng
                int rng = random.Next(randomCells.Length);

                // Save the state before switching
                byte state = randomCells[rng].IsActive;

                // Switch the values
                randomCells[rng].IsActive = randomCells[i].IsActive;
                randomCells[i].IsActive = state;
            }

            // Transform 1D to 2D array
            for (int x = 0; x < cells.GetLength(0); x++)
            {
                for (int y = 0; y < cells.GetLength(1); y++)
                {
                    cells[x, y] = randomCells[Width * y + x];
                }
            }
        }

        /// <summary>
        /// Checks the neighbords of the cell.
        /// </summary>
        /// <param name="x">X coordinate of the cell.</param>
        /// <param name="y">Y coordinate of the cell.</param>
        private void CheckNeighbors(int x, int y)
        {
            // Initiate all around cells
            byte topLeftCell = 0;
            byte leftCell = 0;
            byte downLeftCell = 0;
            byte topCell = 0;
            byte downCell = 0;
            byte topRightCell = 0;
            byte rightCell = 0;
            byte downRightCell = 0;

            // If the cell is not against the left border
            if (x != 0)
            {
                leftCell = cells[x - 1, y].IsActive;

                if (y != 0)
                {
                    topLeftCell = cells[x - 1, y - 1].IsActive;
                }

                if (y != Height - 1)
                {
                    downLeftCell = cells[x - 1, y + 1].IsActive;
                }
            }

            // If the cell is not against the right border
            if (x != Width - 1)
            {
                rightCell = cells[x + 1, y].IsActive;

                if (y != 0)
                {
                    topRightCell = cells[x + 1, y - 1].IsActive;
                }

                if (y != Height - 1)
                {
                    downRightCell = cells[x + 1, y + 1].IsActive;
                }
            }

            // If the cell is not against the top border
            if (y != 0)
            {
                topCell = cells[x, y - 1].IsActive;
            }

            // If the cell is not against the bottom border
            if (y != Height - 1)
            {
                downCell = cells[x, y + 1].IsActive;
            }

            // Sum all the neighbors
            int neighbors = topCell + topLeftCell + topRightCell + downCell + downLeftCell + downRightCell + leftCell + rightCell;

            // Refresh the cell's neighbors
            cells[x, y].Neighbors = Convert.ToByte(neighbors);

        }

        /// <summary>
        /// Checks the state of the cell.
        /// </summary>
        /// <param name="x">X coordinate of the cell.</param>
        /// <param name="y">Y coordinate of the cell.</param>
        private void CheckState(int x, int y)
        {
            Cell cell = cells[x, y];

            if (cell.IsActive == 1)
            {
                if (cell.Neighbors < 2 || cell.Neighbors > 3)
                {
                    cell.IsActive = 0;

                    deaths++;
                }
            }

            else
            {
                if (cell.Neighbors == 3)
                {
                    cell.IsActive = 1;

                    births++;
                }
            }
        }

        /// <summary>
        /// Spawn a starship on the grid.
        /// </summary>
        /// <param name="x">X coordinate.</param>
        /// <param name="y">Y coordinate.</param>
        /// <param name="starship">Starship to spawn.</param>
        /// <returns>True if succesfully spawned, false if not.</returns>
        public bool SpawnStarship(int x, int y, byte[,] starship)
        {
            // Scales the coordinates
            x /= scale;
            y /= scale;

            // Lazy variables
            int starshipWidth = starship.GetLength(0);
            int starshipHeight = starship.GetLength(1);

            // Spawn the starship
            if (starshipWidth <= Width && starshipHeight <= Height)
            {
                for (int i = 0; i < starshipWidth; i++)
                {
                    for (int j = 0; j < starshipHeight; j++)
                    {
                        if (x + i < Width && y + j < Height) // If the starship collapse with the border of the grid, ignore the cell
                        {
                            cells[x + i, y + j].IsActive = starship[i, j];
                        }
                    }
                }

                return true;
            }

            else
            {
                return false;
            }
        }

        /// <summary>
        /// Width of the grid.
        /// </summary>
        public int Width
        {
            get { return cells.GetLength(0); }
        }

        /// <summary>
        /// Height of the grid.
        /// </summary>
        public int Height
        {
            get { return cells.GetLength(1); }
        }

        /// <summary>
        /// Scale of the grid.
        /// </summary>
        public int Scale
        {
            get { return scale; }
            set { scale = value; }
        }

        /// <summary>
        /// Count of cycles.
        /// </summary>
        public int Generations
        {
            get { return generations; }
        }

        /// <summary>
        /// Count of cells created.
        /// </summary>
        public int Births
        {
            get { return births; }
        }

        /// <summary>
        /// Count of cells destroyed.
        /// </summary>
        public int Deaths
        {
            get { return deaths; }
        }

        /// <summary>
        /// Cells.
        /// </summary>
        public Cell[,] Cells
        {
            get { return cells; }
        }
    }
}
