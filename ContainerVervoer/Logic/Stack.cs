using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Stack
    {
        private Location location;
        public List<Container> Containers = new List<Container>();

        public Stack(Location location)
        {
            this.location = location;
        }

        public Location Location { get => location; set => location = value; }

        public bool CanContainerBeStacked(Container Container)
        {
            int SumContainerWeight = 0;
            if(Containers.Count != 0)
            {
                if (Containers.LastOrDefault().Load == LoadType.Valuable)
                {
                    return false;
                }
                foreach (Container container in Containers)
                {
                    SumContainerWeight += container.Weight;
                }
                SumContainerWeight -= Containers.FirstOrDefault().Weight;
                if (Container.Load == LoadType.Normal)
                {
                    if (SumContainerWeight + Container.Weight > Logic.Container.maxStackedWeight - Logic.Container.maxWeight)
                    {
                        return false;
                    }
                }
                else
                {
                    if (SumContainerWeight + Container.Weight > Logic.Container.maxStackedWeight)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
