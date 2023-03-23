
namespace P1
{
    partial class frmOne
    {
        private System.ComponentModel.IContainer components = null;

        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnRun = new System.Windows.Forms.Button();
            this.txtRolls = new System.Windows.Forms.TextBox();
            this.txtSeed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chtDistribution = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chtDistribution)).BeginInit();
            this.SuspendLayout();


            // Button to run

             
            this.btnRun.Location = new System.Drawing.Point(70, 124);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(100, 35);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);


            // text roll


            this.txtRolls.Location = new System.Drawing.Point(229, 23);
            this.txtRolls.Name = "txtRolls";
            this.txtRolls.Size = new System.Drawing.Size(100, 26);
            this.txtRolls.TabIndex = 1;
            this.txtRolls.Text = "6000";

            
            // text seed


            this.txtSeed.Location = new System.Drawing.Point(229, 70);
            this.txtSeed.Name = "txtSeed";
            this.txtSeed.Size = new System.Drawing.Size(100, 26);
            this.txtSeed.TabIndex = 2;
            this.txtSeed.Text = "123";


            // label 1

            
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please enter seed value";

            
            // label 2


            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "How many Rolls";


            // Chart Distribution


            chartArea1.Name = "ChartArea1";
            this.chtDistribution.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtDistribution.Legends.Add(legend1);
            this.chtDistribution.Location = new System.Drawing.Point(368, 12);
            this.chtDistribution.Name = "chtDistribution";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtDistribution.Series.Add(series1);
            this.chtDistribution.Size = new System.Drawing.Size(701, 314);
            this.chtDistribution.TabIndex = 6;
            this.chtDistribution.Text = "Distribution of Die Frequency";


            // Next Button 


            this.btnNext.Location = new System.Drawing.Point(923, 369);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(93, 39);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);


            // End Button


            this.btnEnd.Location = new System.Drawing.Point(197, 124);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(100, 35);
            this.btnEnd.TabIndex = 8;
            this.btnEnd.Text = "End";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);


            // From One function


            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 450);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.chtDistribution);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSeed);
            this.Controls.Add(this.txtRolls);
            this.Controls.Add(this.btnRun);
            this.Name = "frmOne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Die - Part 1";
            ((System.ComponentModel.ISupportInitialize)(this.chtDistribution)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtRolls;
        private System.Windows.Forms.TextBox txtSeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtDistribution;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnEnd;
    }
}

