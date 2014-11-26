namespace WoodWorking
{
    partial class DetailForm
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
            this.ElasticityBox = new System.Windows.Forms.TextBox();
            this.FlatBox = new System.Windows.Forms.TextBox();
            this.EdgeBox = new System.Windows.Forms.TextBox();
            this.SGBox = new System.Windows.Forms.TextBox();
            this.elasticityLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.edgeLabel = new System.Windows.Forms.Label();
            this.SGLabel = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.TangentialChangeBox = new System.Windows.Forms.TextBox();
            this.RadialChangeBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CalculationsButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.locationBox = new System.Windows.Forms.ComboBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.SpeciesBox = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ElasticityBox
            // 
            this.ElasticityBox.Enabled = false;
            this.ElasticityBox.Location = new System.Drawing.Point(778, 450);
            this.ElasticityBox.Name = "ElasticityBox";
            this.ElasticityBox.Size = new System.Drawing.Size(100, 26);
            this.ElasticityBox.TabIndex = 68;
            // 
            // FlatBox
            // 
            this.FlatBox.Enabled = false;
            this.FlatBox.Location = new System.Drawing.Point(778, 362);
            this.FlatBox.Name = "FlatBox";
            this.FlatBox.Size = new System.Drawing.Size(100, 26);
            this.FlatBox.TabIndex = 67;
            // 
            // EdgeBox
            // 
            this.EdgeBox.Enabled = false;
            this.EdgeBox.Location = new System.Drawing.Point(778, 275);
            this.EdgeBox.Name = "EdgeBox";
            this.EdgeBox.Size = new System.Drawing.Size(100, 26);
            this.EdgeBox.TabIndex = 66;
            // 
            // SGBox
            // 
            this.SGBox.Enabled = false;
            this.SGBox.Location = new System.Drawing.Point(778, 181);
            this.SGBox.Name = "SGBox";
            this.SGBox.Size = new System.Drawing.Size(100, 26);
            this.SGBox.TabIndex = 65;
            // 
            // elasticityLabel
            // 
            this.elasticityLabel.AutoSize = true;
            this.elasticityLabel.Location = new System.Drawing.Point(773, 414);
            this.elasticityLabel.Name = "elasticityLabel";
            this.elasticityLabel.Size = new System.Drawing.Size(153, 20);
            this.elasticityLabel.TabIndex = 64;
            this.elasticityLabel.Text = "Modulus of Elasticity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(773, 324);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 63;
            this.label3.Text = "Flat Shear Ratio";
            // 
            // edgeLabel
            // 
            this.edgeLabel.AutoSize = true;
            this.edgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edgeLabel.Location = new System.Drawing.Point(773, 231);
            this.edgeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.edgeLabel.Name = "edgeLabel";
            this.edgeLabel.Size = new System.Drawing.Size(181, 25);
            this.edgeLabel.TabIndex = 62;
            this.edgeLabel.Text = "Edge Shear Ratio";
            // 
            // SGLabel
            // 
            this.SGLabel.AutoSize = true;
            this.SGLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SGLabel.Location = new System.Drawing.Point(773, 129);
            this.SGLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SGLabel.Name = "SGLabel";
            this.SGLabel.Size = new System.Drawing.Size(163, 25);
            this.SGLabel.TabIndex = 61;
            this.SGLabel.Text = "Specific Gravity";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Crimson;
            this.ErrorLabel.Location = new System.Drawing.Point(260, 515);
            this.ErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(401, 20);
            this.ErrorLabel.TabIndex = 60;
            this.ErrorLabel.Text = "This species did not save. There is an error on the page.";
            this.ErrorLabel.Visible = false;
            // 
            // TangentialChangeBox
            // 
            this.TangentialChangeBox.Enabled = false;
            this.TangentialChangeBox.Location = new System.Drawing.Point(519, 450);
            this.TangentialChangeBox.Margin = new System.Windows.Forms.Padding(4);
            this.TangentialChangeBox.Name = "TangentialChangeBox";
            this.TangentialChangeBox.Size = new System.Drawing.Size(143, 26);
            this.TangentialChangeBox.TabIndex = 59;
            // 
            // RadialChangeBox
            // 
            this.RadialChangeBox.Enabled = false;
            this.RadialChangeBox.Location = new System.Drawing.Point(292, 450);
            this.RadialChangeBox.Margin = new System.Windows.Forms.Padding(4);
            this.RadialChangeBox.Name = "RadialChangeBox";
            this.RadialChangeBox.Size = new System.Drawing.Size(143, 26);
            this.RadialChangeBox.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(519, 414);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 25);
            this.label2.TabIndex = 57;
            this.label2.Text = "Tangential Change";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 414);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 56;
            this.label1.Text = "Radial Change";
            // 
            // CalculationsButton
            // 
            this.CalculationsButton.Location = new System.Drawing.Point(77, 263);
            this.CalculationsButton.Margin = new System.Windows.Forms.Padding(4);
            this.CalculationsButton.Name = "CalculationsButton";
            this.CalculationsButton.Size = new System.Drawing.Size(163, 52);
            this.CalculationsButton.TabIndex = 55;
            this.CalculationsButton.Text = "Calculations";
            this.CalculationsButton.UseVisualStyleBackColor = true;
            this.CalculationsButton.Click += new System.EventHandler(this.ViewCalculations);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(77, 380);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(163, 59);
            this.DeleteButton.TabIndex = 54;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteSpecies);
            // 
            // locationBox
            // 
            this.locationBox.Enabled = false;
            this.locationBox.FormattingEnabled = true;
            this.locationBox.Location = new System.Drawing.Point(519, 359);
            this.locationBox.Margin = new System.Windows.Forms.Padding(4);
            this.locationBox.Name = "locationBox";
            this.locationBox.Size = new System.Drawing.Size(206, 28);
            this.locationBox.TabIndex = 53;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(77, 447);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(163, 56);
            this.SaveButton.TabIndex = 52;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveSpecies);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(77, 323);
            this.EditButton.Margin = new System.Windows.Forms.Padding(4);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(163, 50);
            this.EditButton.TabIndex = 51;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditSpecies);
            // 
            // SpeciesBox
            // 
            this.SpeciesBox.Enabled = false;
            this.SpeciesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.SpeciesBox.Location = new System.Drawing.Point(61, 64);
            this.SpeciesBox.Margin = new System.Windows.Forms.Padding(4);
            this.SpeciesBox.MaxLength = 120;
            this.SpeciesBox.Name = "SpeciesBox";
            this.SpeciesBox.Size = new System.Drawing.Size(515, 39);
            this.SpeciesBox.TabIndex = 50;
            this.SpeciesBox.Text = "New Species";
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(292, 359);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(143, 26);
            this.textBox5.TabIndex = 49;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(519, 274);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(143, 26);
            this.textBox4.TabIndex = 48;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(292, 274);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(143, 26);
            this.textBox3.TabIndex = 47;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(517, 181);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(143, 26);
            this.textBox2.TabIndex = 46;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(297, 181);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 26);
            this.textBox1.TabIndex = 45;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(511, 324);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(161, 25);
            this.label13.TabIndex = 44;
            this.label13.Text = "Native Location";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(285, 324);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(182, 25);
            this.label12.TabIndex = 43;
            this.label12.Text = "Volumetric Shrink";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(511, 231);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 25);
            this.label11.TabIndex = 42;
            this.label11.Text = "Tangential Shrink";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(285, 231);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 25);
            this.label10.TabIndex = 41;
            this.label10.Text = "Radial Shrink";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(511, 129);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 25);
            this.label9.TabIndex = 40;
            this.label9.Text = "SW Moisture";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(290, 129);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 25);
            this.label8.TabIndex = 39;
            this.label8.Text = "HW Moisture";
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 598);
            this.Controls.Add(this.ElasticityBox);
            this.Controls.Add(this.FlatBox);
            this.Controls.Add(this.EdgeBox);
            this.Controls.Add(this.SGBox);
            this.Controls.Add(this.elasticityLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edgeLabel);
            this.Controls.Add(this.SGLabel);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.TangentialChangeBox);
            this.Controls.Add(this.RadialChangeBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalculationsButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.locationBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.SpeciesBox);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Name = "DetailForm";
            this.Text = "DetailForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ElasticityBox;
        private System.Windows.Forms.TextBox FlatBox;
        private System.Windows.Forms.TextBox EdgeBox;
        private System.Windows.Forms.TextBox SGBox;
        private System.Windows.Forms.Label elasticityLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label edgeLabel;
        private System.Windows.Forms.Label SGLabel;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.TextBox TangentialChangeBox;
        private System.Windows.Forms.TextBox RadialChangeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CalculationsButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.ComboBox locationBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.TextBox SpeciesBox;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}