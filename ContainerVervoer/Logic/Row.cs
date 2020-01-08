using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Row
    {
        public List<Stack> Stacks = new List<Stack>();

        public Row(int width)
        {
            for (int i = 0; i < width; i++)
            {
                if (width % 2 == 0)
                {
                    if ((i + 1) <= width / 2)
                    {
                        Stacks.Add(new Stack(Location.Left));
                    }
                    else
                    {
                        Stacks.Add(new Stack(Location.Right));
                    }
                }
                else
                {
                    if ((i + 1) <= Math.Floor(Convert.ToDecimal(width) / 2))
                    {
                        Stacks.Add(new Stack(Location.Left));
                    }
                    else if ((i + 1) == Math.Ceiling(Convert.ToDecimal(width) / 2))
                    {
                        Stacks.Add(new Stack(Location.Middle));
                    }
                    else
                    {
                        Stacks.Add(new Stack(Location.Right));
                    }
                }
            }
        }
    }
}
