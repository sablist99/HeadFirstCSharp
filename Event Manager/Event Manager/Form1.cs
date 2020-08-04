﻿using System;
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
        BirthdayParty birthdayParty;
        public Form1()
        {
            InitializeComponent();

            dinnerParty = new DinnerParty((int)numberOfBox.Value, healthyBox.Checked, fancyBox.Checked);
            DisplayDinnerPartyCost();

            birthdayParty = new BirthdayParty((int)numberOfPeopleBirthday.Value, fancyBirthday.Checked, cakeWriting.Text);
            DisplayBirthdayPartyCost();

        }


        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.Cost;
            costLabel.Text = Cost.ToString("c");
        }

        private void DisplayBirthdayPartyCost()
        {
            tooLongLabel.Visible = birthdayParty.CakeWritingTooLong;
            decimal cost = birthdayParty.Cost;
            birthdayCost.Text = cost.ToString("c");
        }

        private void numberOfBox_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.setNumberOfPeople((int)numberOfBox.Value);
            DisplayDinnerPartyCost();
        }

        private void fancyBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.setFancyDecorations(fancyBox.Checked);
            DisplayDinnerPartyCost();
        }

        private void healthyBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.setHealthyOption(healthyBox.Checked);
            DisplayDinnerPartyCost();
        }

        private void cakeWriting_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.setCakeWriting(cakeWriting.Text);
            DisplayBirthdayPartyCost();
        }

        private void fancyBirthday_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.setFancyDecorations(fancyBirthday.Checked);
            DisplayBirthdayPartyCost();
        }

        private void numberOfPeopleBirthday_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.setNumberOfPeople((int)numberOfPeopleBirthday.Value);
            DisplayBirthdayPartyCost();
        }
    }

    
}
