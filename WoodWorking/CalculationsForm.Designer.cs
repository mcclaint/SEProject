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
            this.CalculationTabs = new System.Windows.Forms.TabControl();
            this.DimensionalTab = new System.Windows.Forms.TabPage();
            this.tangentialChangeBox = new System.Windows.Forms.TextBox();
            this.radialChangeBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lengthBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.finalMoistureBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.initialMoistureBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.DensityPage = new System.Windows.Forms.TabPage();
            this.DeflectionsTab = new System.Windows.Forms.TabPage();
            this.CalculateDeflectionsButton = new System.Windows.Forms.Button();
            this.EdgeResultBox = new System.Windows.Forms.TextBox();
            this.FlatResultBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FlatResultLabel = new System.Windows.Forms.Label();
            this.SpanLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.SpanBox = new System.Windows.Forms.TextBox();
            this.HeightBox = new System.Windows.Forms.TextBox();
            this.WidthBox = new System.Windows.Forms.TextBox();
            this.MoistureBar = new System.Windows.Forms.VScrollBar();
            this.MoistureLabel = new System.Windows.Forms.Label();
            this.MoistureLevel = new System.Windows.Forms.Label();
            this.CalculationTabs.SuspendLayout();
            this.DimensionalTab.SuspendLayout();
            this.DensityPage.SuspendLayout();
            this.DeflectionsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalculationTabs
            // 
            this.CalculationTabs.Controls.Add(this.DimensionalTab);
            this.CalculationTabs.Controls.Add(this.DensityPage);
            this.CalculationTabs.Controls.Add(this.DeflectionsTab);
            this.CalculationTabs.Location = new System.Drawing.Point(0, 3);
            this.CalculationTabs.Name = "CalculationTabs";
            this.CalculationTabs.SelectedIndex = 0;
            this.CalculationTabs.Size = new System.Drawing.Size(849, 517);
            this.CalculationTabs.TabIndex = 11;
            // 
            // DimensionalTab
            // 
            this.DimensionalTab.Controls.Add(this.tangentialChangeBox);
            this.DimensionalTab.Controls.Add(this.radialChangeBox);
            this.DimensionalTab.Controls.Add(this.label5);
            this.DimensionalTab.Controls.Add(this.label4);
            this.DimensionalTab.Controls.Add(this.lengthBox);
            this.DimensionalTab.Controls.Add(this.label3);
            this.DimensionalTab.Controls.Add(this.finalMoistureBox);
            this.DimensionalTab.Controls.Add(this.label2);
            this.DimensionalTab.Controls.Add(this.label1);
            this.DimensionalTab.Controls.Add(this.initialMoistureBox);
            this.DimensionalTab.Controls.Add(this.CalculateButton);
            this.DimensionalTab.Location = new System.Drawing.Point(4, 29);
            this.DimensionalTab.Name = "DimensionalTab";
            this.DimensionalTab.Padding = new System.Windows.Forms.Padding(3);
            this.DimensionalTab.Size = new System.Drawing.Size(841, 484);
            this.DimensionalTab.TabIndex = 0;
            this.DimensionalTab.Text = "Dimensional Δ";
            this.DimensionalTab.UseVisualStyleBackColor = true;
            // 
            // tangentialChangeBox
            // 
            this.tangentialChangeBox.Enabled = false;
            this.tangentialChangeBox.Location = new System.Drawing.Point(539, 280);
            this.tangentialChangeBox.Name = "tangentialChangeBox";
            this.tangentialChangeBox.Size = new System.Drawing.Size(100, 26);
            this.tangentialChangeBox.TabIndex = 21;
            // 
            // radialChangeBox
            // 
            this.radialChangeBox.Enabled = false;
            this.radialChangeBox.Location = new System.Drawing.Point(539, 174);
            this.radialChangeBox.Name = "radialChangeBox";
            this.radialChangeBox.Size = new System.Drawing.Size(100, 26);
            this.radialChangeBox.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(535, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tangential Change";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(535, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Radial Change";
            // 
            // lengthBox
            // 
            this.lengthBox.Location = new System.Drawing.Point(155, 316);
            this.lengthBox.Name = "lengthBox";
            this.lengthBox.Size = new System.Drawing.Size(100, 26);
            this.lengthBox.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Initial Length";
            // 
            // finalMoistureBox
            // 
            this.finalMoistureBox.Location = new System.Drawing.Point(155, 204);
            this.finalMoistureBox.Name = "finalMoistureBox";
            this.finalMoistureBox.Size = new System.Drawing.Size(100, 26);
            this.finalMoistureBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Final Moisture Content";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Initial Moisture Content";
            // 
            // initialMoistureBox
            // 
            this.initialMoistureBox.Location = new System.Drawing.Point(155, 108);
            this.initialMoistureBox.Name = "initialMoistureBox";
            this.initialMoistureBox.Size = new System.Drawing.Size(100, 26);
            this.initialMoistureBox.TabIndex = 12;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(354, 358);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(146, 41);
            this.CalculateButton.TabIndex = 11;
            this.CalculateButton.Text = "Do The Magic";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.DoDimensionChangeCalculations);
            // 
            // DensityPage
            // 
            this.DensityPage.Controls.Add(this.MoistureLevel);
            this.DensityPage.Controls.Add(this.MoistureLabel);
            this.DensityPage.Controls.Add(this.MoistureBar);
            this.DensityPage.Location = new System.Drawing.Point(4, 29);
            this.DensityPage.Name = "DensityPage";
            this.DensityPage.Padding = new System.Windows.Forms.Padding(3);
            this.DensityPage.Size = new System.Drawing.Size(841, 484);
            this.DensityPage.TabIndex = 1;
            this.DensityPage.Text = "Density";
            this.DensityPage.UseVisualStyleBackColor = true;
            // 
            // DeflectionsTab
            // 
            this.DeflectionsTab.Controls.Add(this.CalculateDeflectionsButton);
            this.DeflectionsTab.Controls.Add(this.EdgeResultBox);
            this.DeflectionsTab.Controls.Add(this.FlatResultBox);
            this.DeflectionsTab.Controls.Add(this.label6);
            this.DeflectionsTab.Controls.Add(this.FlatResultLabel);
            this.DeflectionsTab.Controls.Add(this.SpanLabel);
            this.DeflectionsTab.Controls.Add(this.HeightLabel);
            this.DeflectionsTab.Controls.Add(this.WidthLabel);
            this.DeflectionsTab.Controls.Add(this.SpanBox);
            this.DeflectionsTab.Controls.Add(this.HeightBox);
            this.DeflectionsTab.Controls.Add(this.WidthBox);
            this.DeflectionsTab.Location = new System.Drawing.Point(4, 29);
            this.DeflectionsTab.Name = "DeflectionsTab";
            this.DeflectionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.DeflectionsTab.Size = new System.Drawing.Size(841, 484);
            this.DeflectionsTab.TabIndex = 2;
            this.DeflectionsTab.Text = "Deflections";
            this.DeflectionsTab.UseVisualStyleBackColor = true;
            // 
            // CalculateDeflectionsButton
            // 
            this.CalculateDeflectionsButton.Location = new System.Drawing.Point(372, 338);
            this.CalculateDeflectionsButton.Name = "CalculateDeflectionsButton";
            this.CalculateDeflectionsButton.Size = new System.Drawing.Size(103, 39);
            this.CalculateDeflectionsButton.TabIndex = 10;
            this.CalculateDeflectionsButton.Text = "Calculate";
            this.CalculateDeflectionsButton.UseVisualStyleBackColor = true;
            this.CalculateDeflectionsButton.Click += new System.EventHandler(this.CalculateDeflections);
            // 
            // EdgeResultBox
            // 
            this.EdgeResultBox.Location = new System.Drawing.Point(580, 276);
            this.EdgeResultBox.Name = "EdgeResultBox";
            this.EdgeResultBox.Size = new System.Drawing.Size(100, 26);
            this.EdgeResultBox.TabIndex = 9;
            // 
            // FlatResultBox
            // 
            this.FlatResultBox.Location = new System.Drawing.Point(580, 174);
            this.FlatResultBox.Name = "FlatResultBox";
            this.FlatResultBox.Size = new System.Drawing.Size(100, 26);
            this.FlatResultBox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(539, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Deflection with edge grain";
            // 
            // FlatResultLabel
            // 
            this.FlatResultLabel.AutoSize = true;
            this.FlatResultLabel.Location = new System.Drawing.Point(535, 131);
            this.FlatResultLabel.Name = "FlatResultLabel";
            this.FlatResultLabel.Size = new System.Drawing.Size(178, 20);
            this.FlatResultLabel.TabIndex = 6;
            this.FlatResultLabel.Text = "Deflection with flat grain";
            // 
            // SpanLabel
            // 
            this.SpanLabel.AutoSize = true;
            this.SpanLabel.Location = new System.Drawing.Point(66, 276);
            this.SpanLabel.Name = "SpanLabel";
            this.SpanLabel.Size = new System.Drawing.Size(93, 20);
            this.SpanLabel.TabIndex = 5;
            this.SpanLabel.Text = "Beam Span";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(66, 192);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(102, 20);
            this.HeightLabel.TabIndex = 4;
            this.HeightLabel.Text = "Beam Height";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(62, 108);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(96, 20);
            this.WidthLabel.TabIndex = 3;
            this.WidthLabel.Text = "Beam Width";
            // 
            // SpanBox
            // 
            this.SpanBox.Location = new System.Drawing.Point(206, 273);
            this.SpanBox.Name = "SpanBox";
            this.SpanBox.Size = new System.Drawing.Size(100, 26);
            this.SpanBox.TabIndex = 2;
            // 
            // HeightBox
            // 
            this.HeightBox.Location = new System.Drawing.Point(206, 186);
            this.HeightBox.Name = "HeightBox";
            this.HeightBox.Size = new System.Drawing.Size(100, 26);
            this.HeightBox.TabIndex = 1;
            // 
            // WidthBox
            // 
            this.WidthBox.Location = new System.Drawing.Point(206, 105);
            this.WidthBox.Name = "WidthBox";
            this.WidthBox.Size = new System.Drawing.Size(100, 26);
            this.WidthBox.TabIndex = 0;
            // 
            // MoistureBar
            // 
            this.MoistureBar.Location = new System.Drawing.Point(117, 123);
            this.MoistureBar.Name = "MoistureBar";
            this.MoistureBar.Size = new System.Drawing.Size(26, 224);
            this.MoistureBar.TabIndex = 0;
            // 
            // MoistureLabel
            // 
            this.MoistureLabel.AutoSize = true;
            this.MoistureLabel.Location = new System.Drawing.Point(194, 144);
            this.MoistureLabel.Name = "MoistureLabel";
            this.MoistureLabel.Size = new System.Drawing.Size(88, 20);
            this.MoistureLabel.TabIndex = 1;
            this.MoistureLabel.Text = "Moisture %";
            // 
            // MoistureLevel
            // 
            this.MoistureLevel.AutoSize = true;
            this.MoistureLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoistureLevel.Location = new System.Drawing.Point(212, 217);
            this.MoistureLevel.Name = "MoistureLevel";
            this.MoistureLevel.Size = new System.Drawing.Size(41, 29);
            this.MoistureLevel.TabIndex = 2;
            this.MoistureLevel.Text = "20";
            // 
            // CalculationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 517);
            this.Controls.Add(this.CalculationTabs);
            this.Name = "CalculationsForm";
            this.Text = "CalculationsForm";
            this.CalculationTabs.ResumeLayout(false);
            this.DimensionalTab.ResumeLayout(false);
            this.DimensionalTab.PerformLayout();
            this.DensityPage.ResumeLayout(false);
            this.DensityPage.PerformLayout();
            this.DeflectionsTab.ResumeLayout(false);
            this.DeflectionsTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl CalculationTabs;
        private System.Windows.Forms.TabPage DimensionalTab;
        private System.Windows.Forms.TextBox tangentialChangeBox;
        private System.Windows.Forms.TextBox radialChangeBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lengthBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox finalMoistureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox initialMoistureBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TabPage DensityPage;
        private System.Windows.Forms.TabPage DeflectionsTab;
        private System.Windows.Forms.TextBox SpanBox;
        private System.Windows.Forms.TextBox HeightBox;
        private System.Windows.Forms.TextBox WidthBox;
        private System.Windows.Forms.Label SpanLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.TextBox EdgeResultBox;
        private System.Windows.Forms.TextBox FlatResultBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label FlatResultLabel;
        private System.Windows.Forms.Button CalculateDeflectionsButton;
        private System.Windows.Forms.Label MoistureLevel;
        private System.Windows.Forms.Label MoistureLabel;
        private System.Windows.Forms.VScrollBar MoistureBar;

    }
}