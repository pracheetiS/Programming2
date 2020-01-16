namespace Bus_Project
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
            this.btnSetMiles = new System.Windows.Forms.Button();
            this.btnSetGas = new System.Windows.Forms.Button();
            this.btnCalcNum = new System.Windows.Forms.Button();
            this.lblMiCost = new System.Windows.Forms.Label();
            this.lblStCost = new System.Windows.Forms.Label();
            this.lblStMiles = new System.Windows.Forms.Label();
            this.lblTotCost = new System.Windows.Forms.Label();
            this.lblLeftOvers = new System.Windows.Forms.Label();
            this.btnMileCost = new System.Windows.Forms.Button();
            this.btnStudCost = new System.Windows.Forms.Button();
            this.btnStudMiles = new System.Windows.Forms.Button();
            this.btnTripCost = new System.Windows.Forms.Button();
            this.btnLastCar = new System.Windows.Forms.Button();
            this.lblCars = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.lblSB = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.lblCW = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSetMiles
            // 
            this.btnSetMiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSetMiles.Location = new System.Drawing.Point(355, 277);
            this.btnSetMiles.Name = "btnSetMiles";
            this.btnSetMiles.Size = new System.Drawing.Size(75, 48);
            this.btnSetMiles.TabIndex = 42;
            this.btnSetMiles.Text = "Set Trip Distance";
            this.btnSetMiles.UseVisualStyleBackColor = false;
            this.btnSetMiles.Click += new System.EventHandler(this.btnSetMiles_Click);
            // 
            // btnSetGas
            // 
            this.btnSetGas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSetGas.Location = new System.Drawing.Point(355, 225);
            this.btnSetGas.Name = "btnSetGas";
            this.btnSetGas.Size = new System.Drawing.Size(75, 46);
            this.btnSetGas.TabIndex = 41;
            this.btnSetGas.Text = "Set Gas Price";
            this.btnSetGas.UseVisualStyleBackColor = false;
            this.btnSetGas.Click += new System.EventHandler(this.btnSetGas_Click);
            // 
            // btnCalcNum
            // 
            this.btnCalcNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCalcNum.Location = new System.Drawing.Point(234, 76);
            this.btnCalcNum.Name = "btnCalcNum";
            this.btnCalcNum.Size = new System.Drawing.Size(67, 102);
            this.btnCalcNum.TabIndex = 40;
            this.btnCalcNum.Text = "Calculate Number of Vehicles";
            this.btnCalcNum.UseVisualStyleBackColor = false;
            this.btnCalcNum.Click += new System.EventHandler(this.btnCalcNum_Click);
            // 
            // lblMiCost
            // 
            this.lblMiCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblMiCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiCost.Location = new System.Drawing.Point(160, 459);
            this.lblMiCost.Name = "lblMiCost";
            this.lblMiCost.Size = new System.Drawing.Size(66, 24);
            this.lblMiCost.TabIndex = 39;
            this.lblMiCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStCost
            // 
            this.lblStCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblStCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStCost.Location = new System.Drawing.Point(160, 404);
            this.lblStCost.Name = "lblStCost";
            this.lblStCost.Size = new System.Drawing.Size(66, 27);
            this.lblStCost.TabIndex = 38;
            this.lblStCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStMiles
            // 
            this.lblStMiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblStMiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStMiles.Location = new System.Drawing.Point(160, 345);
            this.lblStMiles.Name = "lblStMiles";
            this.lblStMiles.Size = new System.Drawing.Size(111, 29);
            this.lblStMiles.TabIndex = 37;
            this.lblStMiles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotCost
            // 
            this.lblTotCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTotCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotCost.Location = new System.Drawing.Point(160, 288);
            this.lblTotCost.Name = "lblTotCost";
            this.lblTotCost.Size = new System.Drawing.Size(129, 23);
            this.lblTotCost.TabIndex = 36;
            this.lblTotCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLeftOvers
            // 
            this.lblLeftOvers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblLeftOvers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeftOvers.Location = new System.Drawing.Point(160, 235);
            this.lblLeftOvers.Name = "lblLeftOvers";
            this.lblLeftOvers.Size = new System.Drawing.Size(39, 25);
            this.lblLeftOvers.TabIndex = 35;
            this.lblLeftOvers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMileCost
            // 
            this.btnMileCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMileCost.Location = new System.Drawing.Point(50, 448);
            this.btnMileCost.Name = "btnMileCost";
            this.btnMileCost.Size = new System.Drawing.Size(75, 46);
            this.btnMileCost.TabIndex = 34;
            this.btnMileCost.Text = "Cost per Mile";
            this.btnMileCost.UseVisualStyleBackColor = false;
            this.btnMileCost.Click += new System.EventHandler(this.btnMileCost_Click);
            // 
            // btnStudCost
            // 
            this.btnStudCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnStudCost.Location = new System.Drawing.Point(50, 391);
            this.btnStudCost.Name = "btnStudCost";
            this.btnStudCost.Size = new System.Drawing.Size(75, 51);
            this.btnStudCost.TabIndex = 33;
            this.btnStudCost.Text = "Cost per Student";
            this.btnStudCost.UseVisualStyleBackColor = false;
            // 
            // btnStudMiles
            // 
            this.btnStudMiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnStudMiles.Location = new System.Drawing.Point(49, 331);
            this.btnStudMiles.Name = "btnStudMiles";
            this.btnStudMiles.Size = new System.Drawing.Size(75, 54);
            this.btnStudMiles.TabIndex = 32;
            this.btnStudMiles.Text = "Total Student Miles";
            this.btnStudMiles.UseVisualStyleBackColor = false;
            // 
            // btnTripCost
            // 
            this.btnTripCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTripCost.Location = new System.Drawing.Point(49, 277);
            this.btnTripCost.Name = "btnTripCost";
            this.btnTripCost.Size = new System.Drawing.Size(75, 48);
            this.btnTripCost.TabIndex = 31;
            this.btnTripCost.Text = "Trip Cost @ ?.?? / gal";
            this.btnTripCost.UseVisualStyleBackColor = false;
            this.btnTripCost.Click += new System.EventHandler(this.btnTripCost_Click);
            // 
            // btnLastCar
            // 
            this.btnLastCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLastCar.Location = new System.Drawing.Point(49, 225);
            this.btnLastCar.Name = "btnLastCar";
            this.btnLastCar.Size = new System.Drawing.Size(75, 46);
            this.btnLastCar.TabIndex = 30;
            this.btnLastCar.Text = "Last Car Passengers";
            this.btnLastCar.UseVisualStyleBackColor = false;
            this.btnLastCar.Click += new System.EventHandler(this.btnLastCar_Click);
            // 
            // lblCars
            // 
            this.lblCars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCars.Location = new System.Drawing.Point(160, 155);
            this.lblCars.Name = "lblCars";
            this.lblCars.Size = new System.Drawing.Size(39, 23);
            this.lblCars.TabIndex = 29;
            this.lblCars.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(46, 165);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(72, 13);
            this.Label2.TabIndex = 28;
            this.Label2.Text = "Personal Cars";
            // 
            // lblSB
            // 
            this.lblSB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblSB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSB.Location = new System.Drawing.Point(160, 115);
            this.lblSB.Name = "lblSB";
            this.lblSB.Size = new System.Drawing.Size(39, 23);
            this.lblSB.TabIndex = 27;
            this.lblSB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(46, 121);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(79, 13);
            this.Label4.TabIndex = 26;
            this.Label4.Text = "Special Busses";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(46, 85);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(86, 13);
            this.Label3.TabIndex = 25;
            this.Label3.Text = "Cheese Wagons";
            // 
            // lblCW
            // 
            this.lblCW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblCW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCW.Location = new System.Drawing.Point(160, 76);
            this.lblCW.Name = "lblCW";
            this.lblCW.Size = new System.Drawing.Size(39, 22);
            this.lblCW.TabIndex = 24;
            this.lblCW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(35, 38);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(162, 13);
            this.Label1.TabIndex = 23;
            this.Label1.Text = "Enter the Number of Students -->";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(201, 31);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(475, 537);
            this.Controls.Add(this.btnSetMiles);
            this.Controls.Add(this.btnSetGas);
            this.Controls.Add(this.btnCalcNum);
            this.Controls.Add(this.lblMiCost);
            this.Controls.Add(this.lblStCost);
            this.Controls.Add(this.lblStMiles);
            this.Controls.Add(this.lblTotCost);
            this.Controls.Add(this.lblLeftOvers);
            this.Controls.Add(this.btnMileCost);
            this.Controls.Add(this.btnStudCost);
            this.Controls.Add(this.btnStudMiles);
            this.Controls.Add(this.btnTripCost);
            this.Controls.Add(this.btnLastCar);
            this.Controls.Add(this.lblCars);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.lblSB);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.lblCW);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Bus Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnSetMiles;
        internal System.Windows.Forms.Button btnSetGas;
        internal System.Windows.Forms.Button btnCalcNum;
        internal System.Windows.Forms.Label lblMiCost;
        internal System.Windows.Forms.Label lblStCost;
        internal System.Windows.Forms.Label lblStMiles;
        internal System.Windows.Forms.Label lblTotCost;
        internal System.Windows.Forms.Label lblLeftOvers;
        internal System.Windows.Forms.Button btnMileCost;
        internal System.Windows.Forms.Button btnStudCost;
        internal System.Windows.Forms.Button btnStudMiles;
        internal System.Windows.Forms.Button btnTripCost;
        internal System.Windows.Forms.Button btnLastCar;
        internal System.Windows.Forms.Label lblCars;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label lblSB;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label lblCW;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtInput;
    }
}

