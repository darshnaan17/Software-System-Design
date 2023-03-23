
namespace P1
{
    partial class frmTwo
    {
        /// <summary>
        /// 
        /// designer variable
        /// 
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 
        /// Clean up any resources
        /// </summary>
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chtDistribution = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSeed1 = new System.Windows.Forms.TextBox();
            this.txtRoll = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.txtSeed2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chtDistribution)).BeginInit();
            this.SuspendLayout();


            // Chat Distribution


            chartArea2.Name = "ChartArea1";
            this.chtDistribution.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chtDistribution.Legends.Add(legend2);
            this.chtDistribution.Location = new System.Drawing.Point(27, 190);
            this.chtDistribution.Name = "chtDistribution";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chtDistribution.Series.Add(series2);
            this.chtDistribution.Size = new System.Drawing.Size(943, 372);
            this.chtDistribution.TabIndex = 12;
            this.chtDistribution.Text = "Distribution of Die Frequency";


            // label 2

            
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Number of times to throw the Dice";

            
            // label 1
            

            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Please enter seed value for Die 1:";


            // text Seed1


            this.txtSeed1.Location = new System.Drawing.Point(278, 73);
            this.txtSeed1.Name = "txtSeed1";
            this.txtSeed1.Size = new System.Drawing.Size(100, 26);
            this.txtSeed1.TabIndex = 9;
            this.txtSeed1.Text = "123";


            // text Roll


            this.txtRoll.Location = new System.Drawing.Point(278, 35);
            this.txtRoll.Name = "txtRoll";
            this.txtRoll.Size = new System.Drawing.Size(100, 26);
            this.txtRoll.TabIndex = 8;
            this.txtRoll.Text = "6000";


            // running the button

            
            this.btnRun.Location = new System.Drawing.Point(426, 79);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(100, 35);
            this.btnRun.TabIndex = 7;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);


            // text Seed2


            this.txtSeed2.Location = new System.Drawing.Point(278, 116);
            this.txtSeed2.Name = "txtSeed2";
            this.txtSeed2.Size = new System.Drawing.Size(100, 26);
            this.txtSeed2.TabIndex = 14;
            this.txtSeed2.Text = "100";

            
            // label 3


            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Please enter seed value for Die 2";


            // button to go previous

            
            this.btnPrevious.Location = new System.Drawing.Point(555, 79);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(100, 35);
            this.btnPrevious.TabIndex = 16;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);


            // button to end
            
           
            this.btnEnd.Location = new System.Drawing.Point(682, 79);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(100, 35);
            this.btnEnd.TabIndex = 17;
            this.btnEnd.Text = "End";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);


            // From two (described later)

            
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 574);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSeed2);
            this.Controls.Add(this.chtDistribution);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSeed1);
            this.Controls.Add(this.txtRoll);
            this.Controls.Add(this.btnRun);
            this.Name = "frmTwo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Die - Part 2";
            ((System.ComponentModel.ISupportInitialize)(this.chtDistribution)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chtDistribution;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSeed1;
        private System.Windows.Forms.TextBox txtRoll;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtSeed2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnEnd;
    }
}