namespace MarathonTraining
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRunnerMileage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lstRunners = new System.Windows.Forms.ListBox();
            this.txtMon = new System.Windows.Forms.TextBox();
            this.txtTues = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTeamStats = new System.Windows.Forms.Button();
            this.txtWed = new System.Windows.Forms.TextBox();
            this.txtThu = new System.Windows.Forms.TextBox();
            this.txtFri = new System.Windows.Forms.TextBox();
            this.txtSat = new System.Windows.Forms.TextBox();
            this.txtSun = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblIndivTotal = new System.Windows.Forms.Label();
            this.lblIndivAvg = new System.Windows.Forms.Label();
            this.lblTeamTotal = new System.Windows.Forms.Label();
            this.lblTeamAvg = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRunnerMileage
            // 
            this.btnRunnerMileage.Location = new System.Drawing.Point(41, 209);
            this.btnRunnerMileage.Name = "btnRunnerMileage";
            this.btnRunnerMileage.Size = new System.Drawing.Size(153, 24);
            this.btnRunnerMileage.TabIndex = 0;
            this.btnRunnerMileage.Text = "Enter Runner\'s Mileage";
            this.btnRunnerMileage.UseVisualStyleBackColor = true;
            this.btnRunnerMileage.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tues:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Wed:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Thu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fri:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Sat:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(203, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Sun:";
            // 
            // lstRunners
            // 
            this.lstRunners.FormattingEnabled = true;
            this.lstRunners.Items.AddRange(new object[] {
            "Roberto",
            "Kevin",
            "Thomas"});
            this.lstRunners.Location = new System.Drawing.Point(126, 95);
            this.lstRunners.Name = "lstRunners";
            this.lstRunners.Size = new System.Drawing.Size(153, 30);
            this.lstRunners.TabIndex = 8;
            // 
            // txtMon
            // 
            this.txtMon.Location = new System.Drawing.Point(71, 142);
            this.txtMon.Name = "txtMon";
            this.txtMon.Size = new System.Drawing.Size(38, 20);
            this.txtMon.TabIndex = 9;
            this.txtMon.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTues
            // 
            this.txtTues.Location = new System.Drawing.Point(155, 142);
            this.txtTues.Name = "txtTues";
            this.txtTues.Size = new System.Drawing.Size(38, 20);
            this.txtTues.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(329, 39);
            this.label8.TabIndex = 16;
            this.label8.Text = "Select runner, and enter daily mileage then press the button to enter \r\ndata.  Af" +
                "ter entering each member, press Calculate Team Statistics \r\nto view team data.";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnTeamStats
            // 
            this.btnTeamStats.Location = new System.Drawing.Point(222, 209);
            this.btnTeamStats.Name = "btnTeamStats";
            this.btnTeamStats.Size = new System.Drawing.Size(143, 23);
            this.btnTeamStats.TabIndex = 17;
            this.btnTeamStats.Text = "Calculate Team Statistics";
            this.btnTeamStats.UseVisualStyleBackColor = true;
            this.btnTeamStats.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtWed
            // 
            this.txtWed.Location = new System.Drawing.Point(238, 142);
            this.txtWed.Name = "txtWed";
            this.txtWed.Size = new System.Drawing.Size(38, 20);
            this.txtWed.TabIndex = 18;
            // 
            // txtThu
            // 
            this.txtThu.Location = new System.Drawing.Point(327, 142);
            this.txtThu.Name = "txtThu";
            this.txtThu.Size = new System.Drawing.Size(38, 20);
            this.txtThu.TabIndex = 19;
            // 
            // txtFri
            // 
            this.txtFri.Location = new System.Drawing.Point(71, 170);
            this.txtFri.Name = "txtFri";
            this.txtFri.Size = new System.Drawing.Size(38, 20);
            this.txtFri.TabIndex = 20;
            // 
            // txtSat
            // 
            this.txtSat.Location = new System.Drawing.Point(155, 170);
            this.txtSat.Name = "txtSat";
            this.txtSat.Size = new System.Drawing.Size(38, 20);
            this.txtSat.TabIndex = 21;
            // 
            // txtSun
            // 
            this.txtSun.Location = new System.Drawing.Point(238, 173);
            this.txtSun.Name = "txtSun";
            this.txtSun.Size = new System.Drawing.Size(38, 20);
            this.txtSun.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Runner Stats:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(219, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Team Stats:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 279);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Total weekly  mileage:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 301);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Average daily mileage:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(219, 279);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Total weekly  mileage:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(219, 301);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Average daily mileage:";
            // 
            // lblIndivTotal
            // 
            this.lblIndivTotal.AutoSize = true;
            this.lblIndivTotal.Location = new System.Drawing.Point(143, 276);
            this.lblIndivTotal.Name = "lblIndivTotal";
            this.lblIndivTotal.Size = new System.Drawing.Size(0, 13);
            this.lblIndivTotal.TabIndex = 29;
            // 
            // lblIndivAvg
            // 
            this.lblIndivAvg.AutoSize = true;
            this.lblIndivAvg.Location = new System.Drawing.Point(143, 301);
            this.lblIndivAvg.Name = "lblIndivAvg";
            this.lblIndivAvg.Size = new System.Drawing.Size(0, 13);
            this.lblIndivAvg.TabIndex = 30;
            // 
            // lblTeamTotal
            // 
            this.lblTeamTotal.AutoSize = true;
            this.lblTeamTotal.Location = new System.Drawing.Point(337, 276);
            this.lblTeamTotal.Name = "lblTeamTotal";
            this.lblTeamTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTeamTotal.TabIndex = 31;
            // 
            // lblTeamAvg
            // 
            this.lblTeamAvg.AutoSize = true;
            this.lblTeamAvg.Location = new System.Drawing.Point(337, 301);
            this.lblTeamAvg.Name = "lblTeamAvg";
            this.lblTeamAvg.Size = new System.Drawing.Size(0, 13);
            this.lblTeamAvg.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(84, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(237, 25);
            this.label15.TabIndex = 33;
            this.label15.Text = "Running Log Calculator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 339);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblTeamAvg);
            this.Controls.Add(this.lblTeamTotal);
            this.Controls.Add(this.lblIndivAvg);
            this.Controls.Add(this.lblIndivTotal);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSun);
            this.Controls.Add(this.txtSat);
            this.Controls.Add(this.txtFri);
            this.Controls.Add(this.txtThu);
            this.Controls.Add(this.txtWed);
            this.Controls.Add(this.btnTeamStats);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTues);
            this.Controls.Add(this.txtMon);
            this.Controls.Add(this.lstRunners);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRunnerMileage);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team Running Log";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRunnerMileage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstRunners;
        private System.Windows.Forms.TextBox txtMon;
        private System.Windows.Forms.TextBox txtTues;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTeamStats;
        private System.Windows.Forms.TextBox txtWed;
        private System.Windows.Forms.TextBox txtThu;
        private System.Windows.Forms.TextBox txtFri;
        private System.Windows.Forms.TextBox txtSat;
        private System.Windows.Forms.TextBox txtSun;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblIndivTotal;
        private System.Windows.Forms.Label lblIndivAvg;
        private System.Windows.Forms.Label lblTeamTotal;
        private System.Windows.Forms.Label lblTeamAvg;
        private System.Windows.Forms.Label label15;
    }
}

