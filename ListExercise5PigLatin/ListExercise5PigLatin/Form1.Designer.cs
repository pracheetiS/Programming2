namespace ListExercise5PigLatin
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
            this.lblCommand = new System.Windows.Forms.Label();
            this.txtEntered = new System.Windows.Forms.TextBox();
            this.lblTranformed = new System.Windows.Forms.Label();
            this.btnPigLatin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCommand
            // 
            this.lblCommand.AutoSize = true;
            this.lblCommand.Font = new System.Drawing.Font("Trajan Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommand.Location = new System.Drawing.Point(73, 98);
            this.lblCommand.Name = "lblCommand";
            this.lblCommand.Size = new System.Drawing.Size(489, 30);
            this.lblCommand.TabIndex = 0;
            this.lblCommand.Text = "Enter the text to be transformed:";
            // 
            // txtEntered
            // 
            this.txtEntered.Font = new System.Drawing.Font("Trajan Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntered.Location = new System.Drawing.Point(568, 98);
            this.txtEntered.Name = "txtEntered";
            this.txtEntered.Size = new System.Drawing.Size(131, 36);
            this.txtEntered.TabIndex = 1;
            // 
            // lblTranformed
            // 
            this.lblTranformed.AutoSize = true;
            this.lblTranformed.Font = new System.Drawing.Font("Trajan Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTranformed.Location = new System.Drawing.Point(377, 242);
            this.lblTranformed.Name = "lblTranformed";
            this.lblTranformed.Size = new System.Drawing.Size(96, 30);
            this.lblTranformed.TabIndex = 2;
            this.lblTranformed.Text = "label2";
            // 
            // btnPigLatin
            // 
            this.btnPigLatin.Font = new System.Drawing.Font("Trajan Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPigLatin.Location = new System.Drawing.Point(186, 220);
            this.btnPigLatin.Name = "btnPigLatin";
            this.btnPigLatin.Size = new System.Drawing.Size(150, 75);
            this.btnPigLatin.TabIndex = 3;
            this.btnPigLatin.Text = "Pig Latin Me";
            this.btnPigLatin.UseVisualStyleBackColor = true;
            this.btnPigLatin.Click += new System.EventHandler(this.btnPigLatin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPigLatin);
            this.Controls.Add(this.lblTranformed);
            this.Controls.Add(this.txtEntered);
            this.Controls.Add(this.lblCommand);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCommand;
        private System.Windows.Forms.TextBox txtEntered;
        private System.Windows.Forms.Label lblTranformed;
        private System.Windows.Forms.Button btnPigLatin;
    }
}

