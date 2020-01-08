using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Ship
    {
        public static int maxWeightDifference = 20 / 100;

        private int length;
        private int width;
        private int maxWeight;
        private int minWeight;
        public List<Row> Rows = new List<Row>();

        public Ship(int length, int width)
        {
            this.length = length;
            this.width = width;
            maxWeight = length * width * (Container.maxStackedWeight + Container.maxWeight);
            minWeight = Convert.ToInt32(maxWeight / 2);
            for (int i = 0; i < this.length; i++)
            {
                Rows.Add(new Row(this.width));
            }
        }

        public int Length { get => length; set => length = value; }
        public int Width { get => width; set => width = value; }
        public int MaxWeight { get => maxWeight; set => maxWeight = value; }
        public int MinWeight { get => minWeight; set => minWeight = value; }

        public int GetWeightLeft()
        {
            int SumWeightLeft = 0;
            foreach (Row row in Rows)
            {
                foreach(Stack stack in row.Stacks)
                {
                    if(stack.Location != Location.Left)
                    {
                        continue;
                    }
                    foreach(Container container in stack.Containers)
                    {
                        SumWeightLeft += container.Weight;
                    }
                }
            }
            return SumWeightLeft;
        }

        public int GetWeightRight()
        {
            int SumWeightRight = 0;
            foreach (Row row in Rows)
            {
                foreach (Stack stack in row.Stacks)
                {
                    if (stack.Location != Location.Right)
                    {
                        continue;
                    }
                    foreach (Container container in stack.Containers)
                    {
                        SumWeightRight += container.Weight;
                    }
                }
            }
            return SumWeightRight;
        }

        public int GetWeightDifference()
        {
            if(GetWeightRight() > GetWeightLeft())
            {
                return GetWeightRight() - GetWeightLeft();
            }
            else if(GetWeightLeft() > GetWeightRight())
            {
                return GetWeightLeft() - GetWeightRight();
            }
            else
            {
                return 0;
            }
        }

        public Location GetLightestSide()
        {
            if (GetWeightRight() > GetWeightLeft())
            {
                return Location.Left;
            }
            else if (GetWeightLeft() > GetWeightRight())
            {
                return Location.Right;
            }
            else
            {
                return Location.Middle;
            }
        }
        public override string ToString()
        {
            string stacks = "";
            string weights = "";
            foreach (Row row in Rows)
            {
                string stacksRowString = "/";
                string weightsRowString = "/";
                foreach (Stack stack in row.Stacks)
                {
                    string stacksStacksString = ",";
                    string weightsStackString = ",";
                     
                        foreach (Container container in stack.Containers)
                        {
                            stacksStacksString += "" + ((int)container.Load + 1);
                            weightsStackString += "-" + container.Weight.ToString();
                        }
                        weightsStackString = weightsStackString.Remove(weightsStackString.IndexOf("-"), 1);
                    
                    stacksRowString += stacksStacksString;
                    weightsRowString += weightsStackString;
                }
                stacksRowString = stacksRowString.Remove(stacksRowString.IndexOf(","), 1);
                weightsRowString = weightsRowString.Remove(weightsRowString.IndexOf(","), 1);
                stacks += stacksRowString;
                weights += weightsRowString;
            }
            stacks = stacks.Remove(stacks.IndexOf("/"), 1);
            weights = weights.Remove(weights.IndexOf("/"), 1);

            return "length=" + width + "&width=" + length + "&stacks=" + stacks + "&weights=" + weights;
            //https://i872272core.venus.fhict.nl/ContainerVisualizer/index.html?length=1&width=2&stacks=1/1&weights=1/1
        }
    }
}
