
namespace Project2
{
    partial class formTwoDice
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblDice = new System.Windows.Forms.Label();
            this.txtTotalRolls = new System.Windows.Forms.TextBox();
            this.txtSeed = new System.Windows.Forms.TextBox();
            this.cboRolls = new System.Windows.Forms.ComboBox();
            this.cboTimer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rdoRolls = new System.Windows.Forms.RadioButton();
            this.rdoTimer = new System.Windows.Forms.RadioButton();
            this.btnRun = new System.Windows.Forms.Button();
            this.tmrFormOne = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();

            
            // Dice


            this.lblDice.AutoSize = true;
            this.lblDice.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblDice.Location = new System.Drawing.Point(162, 29);
            this.lblDice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDice.Name = "lblDice";
            this.lblDice.Size = new System.Drawing.Size(82, 45);
            this.lblDice.TabIndex = 0;
            this.lblDice.Text = "Dice";


            // Total Rolls

            
            this.txtTotalRolls.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTotalRolls.Location = new System.Drawing.Point(76, 178);
            this.txtTotalRolls.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalRolls.Name = "txtTotalRolls";
            this.txtTotalRolls.Size = new System.Drawing.Size(103, 39);
            this.txtTotalRolls.TabIndex = 1;
            this.txtTotalRolls.Text = "6000";


            // Text Seed

            
            this.txtSeed.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSeed.Location = new System.Drawing.Point(285, 174);
            this.txtSeed.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeed.Name = "txtSeed";
            this.txtSeed.Size = new System.Drawing.Size(90, 39);
            this.txtSeed.TabIndex = 2;
            this.txtSeed.Text = "123";

            
            // Rolls


            this.cboRolls.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cboRolls.FormattingEnabled = true;
            this.cboRolls.Location = new System.Drawing.Point(13, 298);
            this.cboRolls.Margin = new System.Windows.Forms.Padding(4);
            this.cboRolls.Name = "cboRolls";
            this.cboRolls.Size = new System.Drawing.Size(154, 40);
            this.cboRolls.TabIndex = 3;
            this.cboRolls.SelectedIndexChanged += new System.EventHandler(this.cboRolls_SelectedIndexChanged);


            // Timer


            this.cboTimer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cboTimer.FormattingEnabled = true;
            this.cboTimer.Location = new System.Drawing.Point(217, 298);
            this.cboTimer.Margin = new System.Windows.Forms.Padding(4);
            this.cboTimer.Name = "cboTimer";
            this.cboTimer.Size = new System.Drawing.Size(154, 40);
            this.cboTimer.TabIndex = 4;
            this.cboTimer.SelectedIndexChanged += new System.EventHandler(this.cboTimer_SelectedIndexChanged);


            // label 2

            
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(8, 182);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Rolls";


            // label 3

            
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(215, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Seed";

            
            // label 4


            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(30, 255);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Update by Rolls";


            // label 5

            
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(239, 257);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Update by Timer";


            // Rolls

            
            this.rdoRolls.AutoSize = true;
            this.rdoRolls.Location = new System.Drawing.Point(15, 261);
            this.rdoRolls.Margin = new System.Windows.Forms.Padding(4);
            this.rdoRolls.Name = "rdoRolls";
            this.rdoRolls.Size = new System.Drawing.Size(21, 20);
            this.rdoRolls.TabIndex = 9;
            this.rdoRolls.TabStop = true;
            this.rdoRolls.UseVisualStyleBackColor = true;

            
            // Timer


            this.rdoTimer.AutoSize = true;
            this.rdoTimer.Location = new System.Drawing.Point(222, 263);
            this.rdoTimer.Margin = new System.Windows.Forms.Padding(4);
            this.rdoTimer.Name = "rdoTimer";
            this.rdoTimer.Size = new System.Drawing.Size(21, 20);
            this.rdoTimer.TabIndex = 10;
            this.rdoTimer.TabStop = true;
            this.rdoTimer.UseVisualStyleBackColor = true;


            // Button to Run


            this.btnRun.Location = new System.Drawing.Point(15, 405);
            this.btnRun.Margin = new System.Windows.Forms.Padding(4);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(113, 49);
            this.btnRun.TabIndex = 11;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            this.tmrFormOne.Tick += new System.EventHandler(this.tmrFormOne_Tick);


            // First chart

            
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(439, 12);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(977, 579);
            this.chart1.TabIndex = 14;
            this.chart1.Text = "chart1";

            
            // label 1


            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(131, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "Dice Value";

            
            // Back button

            
            this.btnBack.Location = new System.Drawing.Point(151, 405);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(113, 49);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);


            // Exit button

            
            this.btnExit.Location = new System.Drawing.Point(285, 405);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 49);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);


            // Two Dice


            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 641);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.rdoTimer);
            this.Controls.Add(this.rdoRolls);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboTimer);
            this.Controls.Add(this.cboRolls);
            this.Controls.Add(this.txtSeed);
            this.Controls.Add(this.txtTotalRolls);
            this.Controls.Add(this.lblDice);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formTwoDice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Two Dice";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formTwoDice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDice;
        private System.Windows.Forms.TextBox txtTotalRolls;
        private System.Windows.Forms.TextBox txtSeed;
        private System.Windows.Forms.ComboBox cboRolls;
        private System.Windows.Forms.ComboBox cboTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdoRolls;
        private System.Windows.Forms.RadioButton rdoTimer;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Timer tmrFormOne;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
    }
}

