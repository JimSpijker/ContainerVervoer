using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Container
    {
        public static int minWeight = 4;
        public static int maxWeight = 30;
        public static int maxStackedWeight = 120;

        private LoadType load;
        private int weight;

        public Container(LoadType load, int weight)
        {
            this.load = load;
            this.weight = weight;
        }

        public LoadType Load { get => load; set => load = value; }
        public int Weight { get => weight; set => weight = value; }

        public override string ToString()
        {
            return load.ToString() + " " + weight.ToString();
        }
    }
}
