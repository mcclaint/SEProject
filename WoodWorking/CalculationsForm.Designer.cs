namespace WoodWorking
{
    partial class CalculationsForm
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
            this.CalculateButton = new System.Windows.Forms.Button();
            this.initialMoistureBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.finalMoistureBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lengthBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radialChangeBox = new System.Windows.Forms.TextBox();
            this.tangentialChangeBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(251, 305);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(146, 41);
            this.CalculateButton.TabIndex = 0;
            this.CalculateButton.Text = "Do The Magic";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.DoCalculations);
            // 
            // initialMoistureBox
            // 
            this.initialMoistureBox.Location = new System.Drawing.Point(52, 55);
            this.initialMoistureBox.Name = "initialMoistureBox";
            this.initialMoistureBox.Size = new System.Drawing.Size(100, 26);
            this.initialMoistureBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Initial Moisture Content";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Final Moisture Content";
            // 
            // finalMoistureBox
            // 
            this.finalMoistureBox.Location = new System.Drawing.Point(52, 151);
            this.finalMoistureBox.Name = "finalMoistureBox";
            this.finalMoistureBox.Size = new System.Drawing.Size(100, 26);
            this.finalMoistureBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Initial Length";
            // 
            // lengthBox
            // 
            this.lengthBox.Location = new System.Drawing.Point(52, 263);
            this.lengthBox.Name = "lengthBox";
            this.lengthBox.Size = new System.Drawing.Size(100, 26);
            this.lengthBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Radial Change";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tangential Change";
            // 
            // radialChangeBox
            // 
            this.radialChangeBox.Enabled = false;
            this.radialChangeBox.Location = new System.Drawing.Point(436, 121);
            this.radialChangeBox.Name = "radialChangeBox";
            this.radialChangeBox.Size = new System.Drawing.Size(100, 26);
            this.radialChangeBox.TabIndex = 9;
            // 
            // tangentialChangeBox
            // 
            this.tangentialChangeBox.Enabled = false;
            this.tangentialChangeBox.Location = new System.Drawing.Point(436, 227);
            this.tangentialChangeBox.Name = "tangentialChangeBox";
            this.tangentialChangeBox.Size = new System.Drawing.Size(100, 26);
            this.tangentialChangeBox.TabIndex = 10;
            // 
            // CalculationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 383);
            this.Controls.Add(this.tangentialChangeBox);
            this.Controls.Add(this.radialChangeBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lengthBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.finalMoistureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.initialMoistureBox);
            this.Controls.Add(this.CalculateButton);
            this.Name = "CalculationsForm";
            this.Text = "CalculationsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox initialMoistureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox finalMoistureBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lengthBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox radialChangeBox;
        private System.Windows.Forms.TextBox tangentialChangeBox;
    }
}