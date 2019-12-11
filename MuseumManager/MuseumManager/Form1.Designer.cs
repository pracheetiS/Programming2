namespace MuseumManager
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
            this.picArt = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNameDate = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picArt)).BeginInit();
            this.SuspendLayout();
            // 
            // picArt
            // 
            this.picArt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picArt.Location = new System.Drawing.Point(12, 210);
            this.picArt.Name = "picArt";
            this.picArt.Size = new System.Drawing.Size(188, 228);
            this.picArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picArt.TabIndex = 0;
            this.picArt.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Lithos Pro Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 139);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(188, 23);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "label1";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNameDate
            // 
            this.lblNameDate.Font = new System.Drawing.Font("Lithos Pro Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameDate.Location = new System.Drawing.Point(12, 171);
            this.lblNameDate.Name = "lblNameDate";
            this.lblNameDate.Size = new System.Drawing.Size(188, 36);
            this.lblNameDate.TabIndex = 2;
            this.lblNameDate.Text = "label2";
            this.lblNameDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 73);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(188, 20);
            this.txtInput.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Lithos Pro Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter Name of Piece:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOptions
            // 
            this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions.Font = new System.Drawing.Font("Lithos Pro Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptions.Location = new System.Drawing.Point(47, 12);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(109, 28);
            this.btnOptions.TabIndex = 5;
            this.btnOptions.Text = "List of Pieces";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("Lithos Pro Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(47, 99);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(109, 28);
            this.btnEnter.TabIndex = 6;
            this.btnEnter.Text = "Search";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 450);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblNameDate);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picArt);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picArt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picArt;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNameDate;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnEnter;
    }
}

