
namespace Project2
{
    partial class formStart
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblDice = new System.Windows.Forms.Label();
            this.btnOneDice = new System.Windows.Forms.Button();
            this.btnTwoDice = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();

           
            // label 1


            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(302, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 28);
            this.label1.TabIndex = 17;
            this.label1.Text = "Darshan Vala";

            
            // Dice

            
            this.lblDice.AutoSize = true;
            this.lblDice.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblDice.Location = new System.Drawing.Point(282, 66);
            this.lblDice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDice.Name = "lblDice";
            this.lblDice.Size = new System.Drawing.Size(204, 45);
            this.lblDice.TabIndex = 16;
            this.lblDice.Text = "DICE ROLLER";

            
            // for one dice

            
            this.btnOneDice.Location = new System.Drawing.Point(86, 288);
            this.btnOneDice.Name = "btnOneDice";
            this.btnOneDice.Size = new System.Drawing.Size(172, 51);
            this.btnOneDice.TabIndex = 18;
            this.btnOneDice.Text = "One Dice";
            this.btnOneDice.UseVisualStyleBackColor = true;
            this.btnOneDice.Click += new System.EventHandler(this.btnOneDice_Click);


            // for two dice


            this.btnTwoDice.Location = new System.Drawing.Point(314, 288);
            this.btnTwoDice.Name = "btnTwoDice";
            this.btnTwoDice.Size = new System.Drawing.Size(172, 51);
            this.btnTwoDice.TabIndex = 19;
            this.btnTwoDice.Text = "Two Dice";
            this.btnTwoDice.UseVisualStyleBackColor = true;
            this.btnTwoDice.Click += new System.EventHandler(this.btnTwoDice_Click);


            // to exit


            this.btnExit.Location = new System.Drawing.Point(528, 288);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(172, 51);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);


            // from start

            
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTwoDice);
            this.Controls.Add(this.btnOneDice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDice);
            this.Name = "formStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project #2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDice;
        private System.Windows.Forms.Button btnOneDice;
        private System.Windows.Forms.Button btnTwoDice;
        private System.Windows.Forms.Button btnExit;
    }
}