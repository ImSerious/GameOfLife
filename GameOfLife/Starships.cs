using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfLife
{
    /// <summary>
    /// Socks every spaceships.
    /// </summary>
    public class Starships
    {
        /// <summary>
        /// A glider : http://www.conwaylife.com/wiki/Glider
        /// </summary>
        static public byte[,] Glider = new byte[,] { { 0, 1, 0 }, { 0, 0, 1 }, { 1, 1, 1 } };
        /// <summary>
        /// A lightweight : http://www.conwaylife.com/wiki/Lightweight_spaceship
        /// </summary>
        static public byte[,] LightWeight = new byte[,] { { 0, 1, 0, 0, 1 }, { 1, 0, 0, 0, 0 }, { 1, 0, 0, 0, 1 }, { 1, 1, 1, 1, 0 } };
    }
}
