/*
 * Corie Beale
 * IGME 206
 * E9
 */


namespace Box_Stacking_Simulation
{
    class Program
    {
        const int DAYS = 3;
        const int STACKS = 4;
        const int MINHEIGHT = 1;
        const int MAXHEIGHT = 3;
        const int MINITEMS = 1;
        const int MAXITEMS = 9;

        static void Main(string[] args)
        {
            Box[,,] array = createArray();
            printArray(array);
        }

        /// <summary>
        /// Creates an array using given constants
        /// </summary>
        /// <returns>the array created</returns>
        static Box[,,] createArray()
        {
            // array[ROW,COLUMN,ARRAY]
            Box[,,] array = new Box[MAXHEIGHT,STACKS,DAYS];
            Random rand = new Random();

            // depending on stack #, find height and populate
            int height;
            Box temp;
            for (int k = 0; k < DAYS; k++) {
                for (int j = 0; j < STACKS; j++)
                {
                    height = rand.Next(MINHEIGHT - 1, MAXHEIGHT + 1);
                    for (int i = 0; i < MAXHEIGHT; i++)
                    {
                        if (i <= height)
                        {
                            temp = new Box(MINITEMS, MAXITEMS);
                            array[i,j,k] = temp;
                        }
                        else
                        {
                            array[i,j,k] = new Box();
                        }
                    }
                }
            }
            return array;
        }

        /// <summary>
        /// Prints the array provided.
        /// </summary>
        /// <param name="a">array</param>
        static void printArray(Box[,,] a)
        {
            for (int k = 0; k < DAYS; k++)
            {
                Console.WriteLine("\nDay " + (k + 1) + ":");

                for (int i = MAXHEIGHT - 1; i >= 0; i--)
                {
                    for (int j = 0; j < STACKS; j++)
                    {
                        if (a[i,j,k].Items == 0)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write(a[i, j, k].Items);
                        }
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}