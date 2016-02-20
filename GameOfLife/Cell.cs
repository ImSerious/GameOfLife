using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfLife
{
    /// <summary>
    /// Represents a cell.
    /// </summary>
    public class Cell
    {
        /// <summary>
        /// Amount of neigbors of the cell.
        /// </summary>
        public byte Neighbors { get; set; }
        /// <summary>
        /// Tells if the cell is active or not.
        /// </summary>
        public byte IsActive { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="isActive">Tells if the cell is active or not.</param>
        public Cell(byte isActive)
        {
            IsActive = isActive;
        }
    }
}
