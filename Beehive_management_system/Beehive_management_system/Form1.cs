using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beehive_management_system
{
    public partial class Form1 : Form
    {
        const string NECTAR_COLLECTOR = "Nectar collector";
        const string HONEY_MANUFACTURING = "Honey manufacturing";
        const string EGG_CARE = "Egg care";
        const string BABY_BEE_TUTORING = "Baby bee tutoring";
        const string HIVE_MAINTENANCE = "Hive maintenance";
        const string STRING_PATROL = "String patrol";

        Queen queen;
        
        public Form1()
        {
            InitializeComponent();
            workerBeeJob.Items.Add(NECTAR_COLLECTOR);
            workerBeeJob.Items.Add(HONEY_MANUFACTURING);
            workerBeeJob.Items.Add(EGG_CARE);
            workerBeeJob.Items.Add(BABY_BEE_TUTORING);
            workerBeeJob.Items.Add(HIVE_MAINTENANCE);
            workerBeeJob.Items.Add(STRING_PATROL);
            workerBeeJob.SelectedIndex = 0;

            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { NECTAR_COLLECTOR, HONEY_MANUFACTURING }, 175);
            workers[1] = new Worker(new string[] { EGG_CARE, BABY_BEE_TUTORING }, 114);
            workers[2] = new Worker(new string[] { HIVE_MAINTENANCE, STRING_PATROL }, 149);
            workers[3] = new Worker(new string[] { NECTAR_COLLECTOR, HONEY_MANUFACTURING, EGG_CARE, BABY_BEE_TUTORING, HIVE_MAINTENANCE, STRING_PATROL }, 155);

            queen = new Queen(workers, 275);
        }

        private void assign_Click(object sender, EventArgs e)
        {
            if (!queen.AssignWork(workerBeeJob.SelectedItem.ToString(), (int)shifts.Value))
                MessageBox.Show("Для задания '" + workerBeeJob.Text + "' рабочих нет", "Матка говорит...");
            else
                MessageBox.Show("Задание '" + workerBeeJob.Text + "' будет закончено через " + shifts.Value + " смен", "Матка говорит...");

        }

        private void nextShift_Click(object sender, EventArgs e)
        {
            report.Text = queen.WorkTheNextShift(); 
        }
    }
}
