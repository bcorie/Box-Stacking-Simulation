/*
 * Corie Beale
 * IGME 206
 * E9
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box_Stacking_Simulation
{
    internal class Box
    {
        private Random rand = new Random();

        /// <summary>
        /// Create an empty box.
        /// </summary>
        public Box()
        {
            Items = 0;
        }

        /// <summary>
        /// Create an empty box with a random number of items, inclusive.
        /// </summary>
        /// <param name="minItems">minimum items</param>
        /// <param name="maxItems">maximum items</param>
        public Box(int minItems, int maxItems)
        {
            Items = rand.Next(minItems, maxItems + 1);
        }

        /// <summary>
        /// Items in the box.
        /// </summary>
        public int Items
        {
            get;
        }
    }
}
