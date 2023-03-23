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


//references
//https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number
//https://docs.microsoft.com/en-us/visualstudio/ide/create-csharp-winform-visual-studio?view=vs-2019

namespace P1
{
    public partial class frmOne : Form
    {
        public frmOne()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            int seed = Convert.ToInt32(txtSeed.Text);// get the seed value
            
            int numberOfRolls = Convert.ToInt32(txtRolls.Text); // get the number of rolls, convert the rolls to integer

            Random random = new RandomUtility().GetRandom(seed); // RandomUtility class gives us the random number

            int[] arrDieValue = new int[6];

            for (int i = 0; i < numberOfRolls; i++) //loop to generate random number based on Rolls
            {
                int myValue = new RandomUtility().Roll(random, 1, 6); // generating random number 1-6

                arrDieValue[myValue - 1]++; // storing that value in this array
            }

            chtDistribution.Series.Clear(); // clearing the chart before adding data points

            chtDistribution.ChartAreas[0].AxisY.Minimum = arrDieValue.Min() - 25;

            Series series = this.chtDistribution.Series.Add("Distribution Frequency");

            //Bar Chart
            series.ChartType = SeriesChartType.Bar;
            
            for (int i = 0; i < 6; i++)
            {
                series.Points.AddXY(i+1, arrDieValue[i]);
            }
        }

        // from two
        private void btnNext_Click(object sender, EventArgs e)
        {
            frmTwo frmtwo = new frmTwo(); // initialized

            frmtwo.Show(); // display

            this.Hide(); // hide
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit(); //exit
        }
    }
}
