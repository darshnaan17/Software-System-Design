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

namespace Project2
{
    public partial class formTwoDice : Form
    {

        int counter = 0;
        int timercounter = 0;
        int defaultRollsForTimer = 100;
        private static readonly object syncLock = new object();
        aDie dice;
        int numberOfUpdate = 0;
        int totalNumberOfRolls = 0;
        public formTwoDice()
        {
            InitializeComponent();
        }

        private void formTwoDice_Load(object sender, EventArgs e)
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
            else if (rdoTimer.Checked == true)
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
            int d1 = 0;
            int d2 = 0;

            lock (syncLock)
            {
                d1 = dice.getRandomValue(1, 7);
                d2 = dice.getRandomValue(1, 7);
            }

            lblDice.Text = (d1+d2).ToString();

            int[] arrDieValue = new int[11];

            for (int i = 0; i < numberOfRollsForEachRun; i++) // saving dice value in array
            {
                d1 = dice.getRandomValue(1, 7);
                d2 = dice.getRandomValue(1, 7);
                arrDieValue[d1 + d2 - 2]++; // storing in this array
            }

            int totalRollAfterEachRun = 0;

            for (int i = 0; i < 11; i++)
            {
                totalRollAfterEachRun += arrDieValue[i];
            }

            if (totalRollAfterEachRun <= totalNumberOfRolls)
            {
                chart1.Series.Clear();
                chart1.Titles.Clear();
                chart1.Titles.Add("Totals for Two Die");
                chart1.ChartAreas[0].AxisX.Title = "Dice Values";
                Series series = chart1.Series.Add("Two Die Total");
                chart1.ChartAreas[0].AxisY.Maximum = arrDieValue.Max() + 30;
                series.IsValueShownAsLabel = true;

                for (int i = 0; i < 11; i++)
                {
                    series.Points.AddXY(i + 2, arrDieValue[i]);
                }
                chart1.Update();
            }
            else
            {
                tmrFormOne.Enabled = false;
            }
        }

        private void DisplayValues(int numberOfRollsForEachRun)
        {
            int d1 = 0;
            int d2 = 0;

            lock (syncLock)
            {
                d1 = dice.getRandomValue(1, 7);
                d2 = dice.getRandomValue(1, 7);
            }

            lblDice.Text = (d1 + d2).ToString();

            int[] arrDieValue = new int[11];

            for (int i = 0; i < numberOfRollsForEachRun; i++) // saving dice value in array
            {
                d1 = dice.getRandomValue(1, 7);
                d2 = dice.getRandomValue(1, 7);
                arrDieValue[d1 + d2 - 2]++; // storing in this array
            }

            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.Titles.Add("Totals for Two Die");
            chart1.ChartAreas[0].AxisX.Title = "Dice Values";
            Series series = chart1.Series.Add("Two Die Total");
            chart1.ChartAreas[0].AxisY.Maximum = arrDieValue.Max() + 30;
            series.IsValueShownAsLabel = true;

            for (int i = 0; i < 11; i++)
            {
                series.Points.AddXY(i + 2, arrDieValue[i]);
            }
            chart1.Update(); // update
            System.Threading.Thread.Sleep(75); 
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
