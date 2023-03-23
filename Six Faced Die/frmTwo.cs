using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;



//link that I used for assistance
//https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.messagebox.show?view=net-5.0 

namespace P1
{
    public partial class frmTwo : Form
    {
        public frmTwo()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            int seedone = Convert.ToInt32(txtSeed1.Text); // seed value for first dice bcomes integer

            int numberOfRolls = Convert.ToInt32(txtRoll.Text); // rolls to integer

            int seedtwo = Convert.ToInt32(txtSeed2.Text); // second value for second dice becomes integer

            Random randone = new RandomUtility().GetRandom(seedone); // random number dice 1

            Random randtwo = new RandomUtility().GetRandom(seedtwo); // random number dice 2

            int[] arrDieValue = new int[11]; //initialize array

            for (int i = 0; i < numberOfRolls; i++) //generates the random number and add the sum of two dice
            {
                int dice1 = new RandomUtility().Roll(randone, 1, 6); // random value for dice 1

                int dice2 = new RandomUtility().Roll(randtwo, 1, 6); // get the random value for dice2

                arrDieValue[dice1 + dice2 - 2]++;// stores the sum value in the array and subtracting 2 to make it zero index based        
            }

            chtDistribution.Series.Clear(); //clears chart

            chtDistribution.ChartAreas[0].AxisY.Minimum = arrDieValue.Min() - 25;

            Series series = this.chtDistribution.Series.Add("Distribution Frequency"); // title of chart

            //Bar Chart
            series.ChartType = SeriesChartType.Bar;
                        
            //Bar Chart histogram
            for (int i = 0; i < 11; i++)
            {
                series.Points.AddXY(i+2, arrDieValue[i]);
            }
        }

        private void btnEnd_Click(object sender, EventArgs e) // ends application
        {
            Application.Exit();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            frmOne frmone = new frmOne(); //initialize

            frmone.Show(); // display

            this.Hide(); // hide
        }
    }
}
