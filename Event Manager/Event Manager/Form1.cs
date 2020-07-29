using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Manager
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)numberOfBox.Value, healthyBox.Checked, fancyBox.Checked);
            DisplayDinnerPartyCost();
        }


        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.Cost;
            costLabel.Text = Cost.ToString("c");
        }

        private void numberOfBox_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numberOfBox.Value;
            DisplayDinnerPartyCost();
        }

        private void fancyBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.FancyDecorations = fancyBox.Checked;
            DisplayDinnerPartyCost();
        }

        private void healthyBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.HealthyOption = healthyBox.Checked;
            DisplayDinnerPartyCost();
        }
    }

    
}
