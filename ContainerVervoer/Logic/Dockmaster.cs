using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Dockmaster
    {
        public List<Container> UnsortedContainers = new List<Container>();
        public List<Container> Containers = new List<Container>();
        private Ship ship;

        public Ship Ship { get => ship; set => ship = value; }

        public int SumContainersWeight()
        {
            int sumContainersWeight = 0;

            foreach (Container container in UnsortedContainers)
            {
                sumContainersWeight += container.Weight;
            }

            return sumContainersWeight;
        }

        public bool ValidateMaxWeight()
        {
            if (SumContainersWeight() <= ship.MaxWeight)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidateMinWeight()
        {
            if (SumContainersWeight() >= ship.MinWeight)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidateSpaceCooled()
        {
            int SumCooledContainersWeight = 0;
            int MaxCooledContainersWeight = ship.Width * (Container.maxWeight + Container.maxStackedWeight);
            foreach (Container container in Containers)
            {
                if (container.Load != LoadType.Cooled)
                {
                    continue;
                }
                SumCooledContainersWeight += container.Weight;
            }
            if (SumCooledContainersWeight <= MaxCooledContainersWeight)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidateSpaceValuable()
        {
            int SumValuableContainersWeight = 0;
            int MaxValuableContainersWeight = (ship.Length - (int)Math.Floor((decimal)ship.Length / 3) - 1) * ship.Width * Container.maxWeight;
            foreach (Container container in Containers)
            {
                if (container.Load != LoadType.Valuable)
                {
                    continue;
                }
                SumValuableContainersWeight += container.Weight;
            }
            if (SumValuableContainersWeight <= MaxValuableContainersWeight)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidateSpaceNormal()
        {
            int SumNormalContainersWeight = 0;
            int MaxNormalContainersWeight = (ship.Length - 1) * ship.Width * Container.maxStackedWeight;
            foreach (Container container in Containers)
            {
                if (container.Load != LoadType.Normal)
                {
                    continue;
                }
                SumNormalContainersWeight += container.Weight;
            }
            if (SumNormalContainersWeight <= MaxNormalContainersWeight)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool SortContainersCooled()
        {
            List<int> AllowedRows = new List<int>();
            AllowedRows.Add(0);
            List<Container> PlacedContainers = new List<Container>();
            foreach (Container container in Containers)
            {
                if (container.Load != LoadType.Cooled)
                {
                    continue;
                }
                if (!PlaceContainer(container, AllowedRows))
                {
                    return false;
                }
                PlacedContainers.Add(container);
            }
            RemoveContainersFromList(PlacedContainers);
            return true;
        }

        public bool SortContainersNormal()
        {
            List<int> AllowedRows = new List<int>();
            for (int i = 1; i < ship.Length; i++)
            {
                if ((i + 1) % 3 != 0)
                {
                    AllowedRows.Add(i);
                }
            }

            List<Container> PlacedContainers = new List<Container>();
            foreach (Container container in Containers)
            {
                if (container.Load != LoadType.Normal)
                {
                    continue;
                }
                if (!PlaceContainer(container, AllowedRows))
                {
                    break;
                }
                PlacedContainers.Add(container);
            }
            RemoveContainersFromList(PlacedContainers);

            AllowedRows = new List<int>();
            for (int i = 1; i < ship.Length; i++)
            {
                if ((i + 1) % 3 == 0)
                {
                    AllowedRows.Add(i);
                }
            }

            PlacedContainers = new List<Container>();
            foreach (Container container in Containers)
            {
                if (container.Load != LoadType.Normal)
                {
                    continue;
                }
                if (!PlaceContainer(container, AllowedRows))
                {
                    return false;
                }
                PlacedContainers.Add(container);
            }
            RemoveContainersFromList(PlacedContainers);
            return true;
        }

        public bool SortContainersValuable()
        {
            List<int> AllowedRows = new List<int>();
            for (int i = 1; i < ship.Length; i++)
            {
                if ((i + 1) % 3 != 0)
                {
                    AllowedRows.Add(i);
                }
            }

            List<Container> PlacedContainers = new List<Container>();
            foreach (Container container in Containers)
            {
                if (container.Load != LoadType.Valuable)
                {
                    continue;
                }
                if (!PlaceContainer(container, AllowedRows))
                {
                    return false;
                }
                PlacedContainers.Add(container);
            }
            RemoveContainersFromList(PlacedContainers);
            return true;
        }

        public void RemoveContainersFromList(List<Container> ToBeRemovedContainers)
        {
            foreach (Container container in ToBeRemovedContainers)
            {
                Containers.Remove(container);
            }
        }

        public bool PlaceContainer(Container container, List<int> AllowedRows)
        {
            foreach (int row in AllowedRows)
            {
                foreach (Stack stack in ship.Rows[row].Stacks)
                {
                    if (ship.GetLightestSide() != Location.Middle)
                    {
                        if (stack.Location != ship.GetLightestSide() && stack.Location != Location.Middle)
                        {
                            continue;
                        }
                    }
                    if (stack.CanContainerBeStacked(container))
                    {
                        stack.Containers.Add(container);
                        return true;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return false;
        }

        public LoadShipResult PlaceContainers()
        {
            Containers = UnsortedContainers.OrderBy(c => c.Weight).ToList();
            if (!ValidateMaxWeight())
            {
                return LoadShipResult.TooHeavy;
            }
            if (!ValidateMinWeight())
            {
                return LoadShipResult.TooLight;
            }
            if (!ValidateSpaceCooled())
            {
                return LoadShipResult.TooLittleCooledSpace;
            }
            if (!ValidateSpaceNormal())
            {
                return LoadShipResult.TooLittleNormalSpace;
            }
            if (!ValidateSpaceValuable())
            {
                return LoadShipResult.TooLittleValuableSpace;
            }
            if (!SortContainersCooled())
            {
                return LoadShipResult.ErrorPlacing;
            }
            if (!SortContainersNormal())
            {
                return LoadShipResult.ErrorPlacing;
            }
            if (!SortContainersValuable())
            {
                return LoadShipResult.ErrorPlacing;
            }
            if (!ValidateWeightDifference())
            {
                return LoadShipResult.BadWeightDistribution;
            }
            return LoadShipResult.Succes;
        }

        public bool ValidateWeightDifference()
        {
            if (Ship.GetWeightDifference() != 0)
            {
                if (SumContainersWeight() / Ship.GetWeightDifference() <= Ship.maxWeightDifference)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        
    }
}
