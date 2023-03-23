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

//Resources
// https://help.syncfusion.com/windowsforms/chart/chart-types


namespace Project2
{
    public partial class formOneDice : Form
    {

        int counter = 0;
        int timercounter = 0;
        int defaultRollsForTimer = 100;

        private static readonly object syncLock = new object();
        aDie dice; 
        int numberOfUpdate = 0;
        int totalNumberOfRolls = 0;

        public formOneDice()
        {
            InitializeComponent();
        }

        private void fromOneDice_Load(object sender, EventArgs e)
        {
            totalNumberOfRolls = Convert.ToInt32(txtTotalRolls.Text);
            dice = new aDie(int.Parse(txtSeed.Text)); 
            

            cboRolls.Items.Add("10");
            cboRolls.Items.Add("100");
            cboRolls.Items.Add("500");
            cboRolls.Items.Add("1000");
            cboRolls.Items.Add("10000");


            cboTimer.Items.Add("1");
            cboTimer.Items.Add("10");
            cboTimer.Items.Add("100");
            cboTimer.Items.Add("1000");
            cboTimer.Items.Add("10000");

            cboRolls.SelectedIndex = 3;
            cboTimer.SelectedIndex = 0;

            rdoRolls.Checked = true;
            tmrFormOne.Enabled = false;

            numberOfUpdate = totalNumberOfRolls / int.Parse(cboRolls.SelectedItem.ToString());
        }

        private void btnRun_Click(object sender, EventArgs e)
        {

            counter = 0;
            timercounter = 0;

            totalNumberOfRolls = Convert.ToInt32(txtTotalRolls.Text);
            dice = new aDie(int.Parse(txtSeed.Text));

            numberOfUpdate = totalNumberOfRolls / int.Parse(cboRolls.SelectedItem.ToString());

            int updateRolls = int.Parse(cboRolls.SelectedItem.ToString());

            if (rdoTimer.Checked == true)
            {
                tmrFormOne.Interval = int.Parse(cboTimer.SelectedItem.ToString());
                tmrFormOne.Enabled = true;
            }
            else if (updateRolls > totalNumberOfRolls)
            {
                string msg = "Update Rolls value is greater than Total Number of Rolls.";
                MessageBox.Show(msg);
                tmrFormOne.Enabled = false;
            }
            else
            {
                tmrFormOne.Enabled = true;
            }

        }

        private void tmrFormOne_Tick(object sender, EventArgs e)
        {
            if (rdoRolls.Checked == true)
            {                
                if (counter <= numberOfUpdate)
                {
                    DisplayValues(counter * int.Parse(cboRolls.SelectedItem.ToString()));
                    counter = counter + 1;
                }
                else
                {
                    tmrFormOne.Enabled = false;
                    counter = 0;
                }
            }
            else if(rdoTimer.Checked == true)
            {
                if (tmrFormOne.Enabled == false)
                {
                    tmrFormOne.Enabled = true;
                }

                DisplayChartForTimer(timercounter * defaultRollsForTimer);
                timercounter = timercounter + 1;
            }
        }

        private void DisplayChartForTimer(int numberOfRollsForEachRun)
        {
            int myval = 0;
            lock (syncLock)
            {
                myval = dice.getRandomValue(1, 7);
            }

            lblDice.Text = myval.ToString();
            int[] arrDieValue = new int[6];

            for (int i = 0; i < numberOfRollsForEachRun; i++) // saving value from sice in array
            {
                int dieValue = dice.getRandomValue(1, 7);   //generating random number 1-6
                arrDieValue[dieValue - 1]++; // storing that alvue in this array
            }

            int totalRollAfterEachRun = 0;
            
            for (int i = 0; i < 6; i++)
            {
                totalRollAfterEachRun += arrDieValue[i];
            }
                        
            if (totalRollAfterEachRun <= totalNumberOfRolls)
            {
                chart1.Series.Clear();
                chart1.Titles.Clear();
                chart1.Titles.Add("Dice One Distribution"); // adding title
                chart1.ChartAreas[0].AxisX.Title = "Dice Values"; // x title
                Series series = chart1.Series.Add("One Dice Frequency");
                chart1.ChartAreas[0].AxisY.Maximum = arrDieValue.Max() + 50;

                series.IsValueShownAsLabel = true;
                for (int i = 0; i < 6; i++)
                {
                    series.Points.AddXY(i + 1, arrDieValue[i]);
                }
                chart1.Update(); // updating
                
            }
            else
            {
                tmrFormOne.Enabled = false;
            }
        }

        private void DisplayValues(int numberOfRollsForEachRun)
        {
            int myval = 0;
            lock (syncLock)
            {
                myval = dice.getRandomValue(1, 7);
            }

            lblDice.Text = myval.ToString();

            int[] arrDieValue = new int[6];

            for (int i = 0; i < numberOfRollsForEachRun; i++) // saving dice value in this array
            {
                int dieValue = dice.getRandomValue(1, 7);   //get random numver 1-6
                arrDieValue[dieValue - 1]++; // storing that value in this array
            }

            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.Titles.Add("Dice One Distribution");
            chart1.ChartAreas[0].AxisX.Title = "Dice Values";
            Series series = chart1.Series.Add("One Dice Frequency");
            chart1.ChartAreas[0].AxisY.Maximum = arrDieValue.Max() + 100;
            series.IsValueShownAsLabel = true;
            for (int i = 0; i < 6; i++)
            {
                series.Points.AddXY(i + 1, arrDieValue[i]);
            }
            chart1.Update(); // update
            System.Threading.Thread.Sleep(100);
        }

        private void cboRolls_SelectedIndexChanged(object sender, EventArgs e)
        {
            totalNumberOfRolls = Convert.ToInt32(txtTotalRolls.Text);
            numberOfUpdate = totalNumberOfRolls / int.Parse(cboRolls.SelectedItem.ToString());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            formStart stratForm = new formStart();
            stratForm.Show();
            this.Hide();
        }

        private void cboTimer_SelectedIndexChanged(object sender, EventArgs e)
        {
            tmrFormOne.Interval = int.Parse(cboTimer.SelectedItem.ToString());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
