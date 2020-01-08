using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;

namespace ContainerVervoer
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            ErrorMessage.Text = "";
            tBMaxWeight.Text = Convert.ToString(nUDShipLength.Value * nUDShipWidth.Value * (Logic.Container.maxStackedWeight + Logic.Container.maxWeight));
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                lBContainers.Items.Add(new Logic.Container(LoadType.Cooled, random.Next(29, 30)));
            }
            for (int i = 0; i < 12; i++)
            {
                lBContainers.Items.Add(new Logic.Container(LoadType.Normal, random.Next(29, 30)));
            }
            for (int i = 0; i < 2; i++)
            {
                lBContainers.Items.Add(new Logic.Container(LoadType.Valuable, random.Next(29, 30)));
            }
        }

        private void bAddContainer_Click(object sender, EventArgs e)
        {
            if (nUDContainerWeight.Value != 0 && cBLoadType != null)
            {
                if(cBLoadType.SelectedItem.ToString() == "Normal")
                {
                    lBContainers.Items.Add(new Logic.Container(LoadType.Normal, Convert.ToInt32(nUDContainerWeight.Value)));
                }
                else if (cBLoadType.SelectedItem.ToString() == "Cooled")
                {
                    lBContainers.Items.Add(new Logic.Container(LoadType.Cooled, Convert.ToInt32(nUDContainerWeight.Value)));
                }
                else if (cBLoadType.SelectedItem.ToString() == "Valuable")
                {
                    lBContainers.Items.Add(new Logic.Container(LoadType.Valuable, Convert.ToInt32(nUDContainerWeight.Value)));
                }

            }
        }

        private void bDeleteContainer_Click(object sender, EventArgs e)
        {
            if(lBContainers.SelectedItem != null)
            {
                lBContainers.Items.Remove(lBContainers.SelectedItem);
            }
        }

        private void bSortShip_Click(object sender, EventArgs e)
        {
            ErrorMessage.Text = "";
            Dockmaster dockmaster = new Dockmaster();
            foreach(Logic.Container container in lBContainers.Items)
            {
                dockmaster.UnsortedContainers.Add(container);
            }
            dockmaster.Ship = new Ship(Convert.ToInt32(nUDShipLength.Value), Convert.ToInt32(nUDShipWidth.Value));
            LoadShipResult result = dockmaster.PlaceContainers();

            switch (result)
            {
                case LoadShipResult.Succes:
                    ErrorMessage.Text = "Succes!";
                    break;
                case LoadShipResult.TooHeavy:
                    ErrorMessage.Text = "The load is too heavy for the selected ship!";
                    break;
                case LoadShipResult.TooLight:
                    ErrorMessage.Text = "The load is too light for the selected ship!";
                    break;
                case LoadShipResult.TooLittleCooledSpace:
                    ErrorMessage.Text = "The ship doesn't have enough space for the amount of cooled containers!";
                    break;
                case LoadShipResult.TooLittleNormalSpace:
                    ErrorMessage.Text = "The ship doesn't have enough space for the amount of normal containers!";
                    break;
                case LoadShipResult.TooLittleValuableSpace:
                    ErrorMessage.Text = "The ship doesn't have enough space for the amount of valuable containers!";
                    break;
                case LoadShipResult.BadWeightDistribution:
                    ErrorMessage.Text = "The weight distribution is too not good enough!";
                    break;
                case LoadShipResult.ErrorPlacing:
                    ErrorMessage.Text = "There was an error placing a container!";
                    break;
                default:
                    ErrorMessage.Text = "Oops, something went wrong!";
                    break;
            }
            string url = "https://i872272core.venus.fhict.nl/ContainerVisualizer/index.html?" + dockmaster.Ship.ToString();
            tBUrl.Text = url;
        }

        private void nUDShipLength_ValueChanged(object sender, EventArgs e)
        {
            tBMaxWeight.Text = Convert.ToString(nUDShipLength.Value * nUDShipWidth.Value * (Logic.Container.maxStackedWeight + Logic.Container.maxWeight));
        }

        private void nUDShipWidth_ValueChanged(object sender, EventArgs e)
        {
            tBMaxWeight.Text = Convert.ToString(nUDShipLength.Value * nUDShipWidth.Value * (Logic.Container.maxStackedWeight + Logic.Container.maxWeight));
        }

    }
}
