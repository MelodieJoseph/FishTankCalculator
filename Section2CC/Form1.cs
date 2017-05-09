using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Section2CC
{
    public partial class 
Form1 : Form
    {

        const int TANKSIZELOWER = 20;
        const int TANKSIZEUPPER = 160;
        const int FISHSIZELOWER = 3;
        const int FISHSIZEUPPER = 20;
        const int POOLVOLUMELOWER = 20;
        const int POOLVOLUMEMIDDLE = 60;
        const int POOLVOLUMEUPPER = 160;


        public Form1()
        {
            InitializeComponent();
        }

        public bool FishType(string type)
        {
            if ((txtFishType.Text == "Tropical") || (txtFishType.Text == "Saltwater") || (txtFishType.Text == "Goldfish"))
            {
                return true;
            }
            else
            {
                MessageBox.Show("That fish doesn't exist here");
                return false;
            }
        }

        public bool FishSize(int size)
        {
            if ((int.Parse(txtFishSize.Text) >= FISHSIZELOWER) && (int.Parse(txtFishSize.Text) <= FISHSIZEUPPER))
            {
                return true;
            }
            else
            {
                MessageBox.Show("No fish that size here. \r\n Please enter a balue greater than " + FISHSIZELOWER + "and less than " + FISHSIZEUPPER +                    ".");
                return false;
            }
        }

        public bool TankSize(int size)
        {
            if ((int.Parse(txtTankSize.Text) >= TANKSIZELOWER) && (int.Parse(txtTankSize.Text) <= TANKSIZEUPPER))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Tanks that size do not exist. \r\n Please enter a value greater than " + TANKSIZELOWER + "and less than " +                       TANKSIZEUPPER + ".");
                return false;
            }
        }

        public String PoolVolume(int tankSize)
        {

            if ((int.Parse(txtTankSize.Text) >= POOLVOLUMELOWER) && (int.Parse(txtTankSize.Text) < POOLVOLUMEMIDDLE))
            {
                return lblTankSize.Text = "Small";
            }
            else if ((int.Parse(txtTankSize.Text) >= POOLVOLUMEMIDDLE) && (int.Parse(txtTankSize.Text) <= POOLVOLUMEUPPER))
            {
                return lblTankSize.Text = "Medium";
            }
            else
            {
                return lblTankSize.Text = "Large";
            }
        }

        public void OptimalFish(int fishAmount)
        {
            if (txtFishType.Text == "Tropical")
            {
                lblMaxFishAllowed.Text = ((int)((double.Parse(txtTankSize.Text)) /
                 ((double.Parse(txtFishSize.Text) * 3.8 / 2.54)))).ToString();
            }
            else if (txtFishType.Text == "Saltwater")
            {
                lblMaxFishAllowed.Text = ((int)((double.Parse(txtTankSize.Text)) /
                 ((double.Parse(txtFishSize.Text) * 18.9 / 2.54)))).ToString();
            }
            else if (txtFishType.Text == "Goldfish")
            {
                lblMaxFishAllowed.Text = ((int)(((double.Parse(txtTankSize.Text) - 37.85)) / 37.85)).ToString();
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (FishType(txtFishType.Text) != true)
            {
                return;
            }
            if (FishSize(int.Parse(txtFishSize.Text)) != true)
            {
                return;
            }
            if (TankSize(int.Parse(txtTankSize.Text)) != true)
            {
                return;
            }

            PoolVolume(int.Parse(txtTankSize.Text));

            OptimalFish(int.Parse(txtTankSize.Text));

            TankSizeRange();
        }

        public void TankSizeRange()  // method to populate Tank Sizes and display the maximum fish intake for those sizes.
        {
            String output = "";
            String output2 = "";
            if (txtFishType.Text == "Tropical")
            {
                for (int counter = TANKSIZELOWER; counter <= TANKSIZEUPPER; counter += TANKSIZELOWER)
                {
                    output += (counter.ToString() + " \r\n");
                    output2 += (((double)counter) / ((double.Parse(txtFishSize.Text) * 3.8 / 2.54))).ToString() + " \r\n";
                }
                txtTankSizeRange.Text = output;
                txtFishAmountRange.Text = output2;
            }
            else if (txtFishType.Text == "Saltwater")
            {               
                for (int counter = TANKSIZELOWER; counter <= TANKSIZEUPPER; counter += TANKSIZELOWER)
                {
                    output += (counter.ToString() + " \r\n");
                    output2 += (((double)counter) / ((double.Parse(txtFishSize.Text) * 18.9 / 2.54))).ToString() + " \r\n";
                }
                txtTankSizeRange.Text = output;
                txtFishAmountRange.Text = output2;
            }
            else if (txtFishType.Text == "Goldfish")
            {
                for (int counter = TANKSIZELOWER; counter <= TANKSIZEUPPER; counter += TANKSIZELOWER)
                {
                    output += (counter.ToString() + " \r\n");
                    output2 += ((((double)counter) - 37.85) / 37.85).ToString() + "\r\n";
                }
                txtTankSizeRange.Text = output;
                txtFishAmountRange.Text = output2;
            }
        }
    }
}
