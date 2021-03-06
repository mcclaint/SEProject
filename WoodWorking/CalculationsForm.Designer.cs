﻿namespace WoodWorking
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
            this.tChangeLabel = new System.Windows.Forms.Label();
            this.rChangeLabel = new System.Windows.Forms.Label();
            this.lengthBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.finalMoistureBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.initialMoistureBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.DensityPage = new System.Windows.Forms.TabPage();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.DensityLevel = new System.Windows.Forms.Label();
            this.DensityLabel = new System.Windows.Forms.Label();
            this.MoistureLevel = new System.Windows.Forms.Label();
            this.MoistureLabel = new System.Windows.Forms.Label();
            this.MoistureBar = new System.Windows.Forms.VScrollBar();
            this.DeflectionsTab = new System.Windows.Forms.TabPage();
            this.LoadBox = new System.Windows.Forms.TextBox();
            this.LoadLabel = new System.Windows.Forms.Label();
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
            this.label7 = new System.Windows.Forms.Label();
            this.inchRadio = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.feetRadio = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.widthInchRadio = new System.Windows.Forms.RadioButton();
            this.widthFeetRadio = new System.Windows.Forms.RadioButton();
            this.heightInchRadio = new System.Windows.Forms.RadioButton();
            this.heightFeetRadio = new System.Windows.Forms.RadioButton();
            this.spanInchRadio = new System.Windows.Forms.RadioButton();
            this.spanFeetRadio = new System.Windows.Forms.RadioButton();
            this.CalculationTabs.SuspendLayout();
            this.DimensionalTab.SuspendLayout();
            this.DensityPage.SuspendLayout();
            this.DeflectionsTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
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
            this.DimensionalTab.Controls.Add(this.panel1);
            this.DimensionalTab.Controls.Add(this.tangentialChangeBox);
            this.DimensionalTab.Controls.Add(this.radialChangeBox);
            this.DimensionalTab.Controls.Add(this.tChangeLabel);
            this.DimensionalTab.Controls.Add(this.rChangeLabel);
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
            this.DimensionalTab.Text = "Dimensional Change";
            this.DimensionalTab.UseVisualStyleBackColor = true;
            // 
            // tangentialChangeBox
            // 
            this.tangentialChangeBox.Enabled = false;
            this.tangentialChangeBox.Location = new System.Drawing.Point(671, 246);
            this.tangentialChangeBox.Name = "tangentialChangeBox";
            this.tangentialChangeBox.Size = new System.Drawing.Size(100, 26);
            this.tangentialChangeBox.TabIndex = 21;
            // 
            // radialChangeBox
            // 
            this.radialChangeBox.Enabled = false;
            this.radialChangeBox.Location = new System.Drawing.Point(671, 168);
            this.radialChangeBox.Name = "radialChangeBox";
            this.radialChangeBox.Size = new System.Drawing.Size(100, 26);
            this.radialChangeBox.TabIndex = 20;
            // 
            // tChangeLabel
            // 
            this.tChangeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tChangeLabel.AutoSize = true;
            this.tChangeLabel.Location = new System.Drawing.Point(462, 249);
            this.tChangeLabel.Name = "tChangeLabel";
            this.tChangeLabel.Size = new System.Drawing.Size(177, 20);
            this.tChangeLabel.TabIndex = 19;
            this.tChangeLabel.Text = "Tangential Change ( in )";
            // 
            // rChangeLabel
            // 
            this.rChangeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rChangeLabel.AutoSize = true;
            this.rChangeLabel.Location = new System.Drawing.Point(491, 171);
            this.rChangeLabel.Name = "rChangeLabel";
            this.rChangeLabel.Size = new System.Drawing.Size(148, 20);
            this.rChangeLabel.TabIndex = 18;
            this.rChangeLabel.Text = "Radial Change ( in )";
            // 
            // lengthBox
            // 
            this.lengthBox.Location = new System.Drawing.Point(275, 277);
            this.lengthBox.Name = "lengthBox";
            this.lengthBox.Size = new System.Drawing.Size(100, 26);
            this.lengthBox.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Width";
            // 
            // finalMoistureBox
            // 
            this.finalMoistureBox.Location = new System.Drawing.Point(275, 201);
            this.finalMoistureBox.Name = "finalMoistureBox";
            this.finalMoistureBox.Size = new System.Drawing.Size(100, 26);
            this.finalMoistureBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Final Moisture Content (%)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Initial Moisture Content (%)";
            // 
            // initialMoistureBox
            // 
            this.initialMoistureBox.Location = new System.Drawing.Point(275, 128);
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
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateDimensionalChanges);
            // 
            // DensityPage
            // 
            this.DensityPage.Controls.Add(this.label7);
            this.DensityPage.Controls.Add(this.ErrorLabel);
            this.DensityPage.Controls.Add(this.DensityLevel);
            this.DensityPage.Controls.Add(this.DensityLabel);
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
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Crimson;
            this.ErrorLabel.Location = new System.Drawing.Point(137, 61);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(591, 20);
            this.ErrorLabel.TabIndex = 6;
            this.ErrorLabel.Text = "This species has no data for specific gravity. Therefore, no calculation can be d" +
    "one.";
            this.ErrorLabel.Visible = false;
            // 
            // DensityLevel
            // 
            this.DensityLevel.AutoSize = true;
            this.DensityLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DensityLevel.Location = new System.Drawing.Point(584, 217);
            this.DensityLevel.Name = "DensityLevel";
            this.DensityLevel.Size = new System.Drawing.Size(26, 29);
            this.DensityLevel.TabIndex = 5;
            this.DensityLevel.Text = "0";
            // 
            // DensityLabel
            // 
            this.DensityLabel.AutoSize = true;
            this.DensityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DensityLabel.Location = new System.Drawing.Point(584, 169);
            this.DensityLabel.Name = "DensityLabel";
            this.DensityLabel.Size = new System.Drawing.Size(99, 29);
            this.DensityLabel.TabIndex = 4;
            this.DensityLabel.Text = "Density";
            // 
            // MoistureLevel
            // 
            this.MoistureLevel.AutoSize = true;
            this.MoistureLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoistureLevel.Location = new System.Drawing.Point(235, 217);
            this.MoistureLevel.Name = "MoistureLevel";
            this.MoistureLevel.Size = new System.Drawing.Size(41, 29);
            this.MoistureLevel.TabIndex = 2;
            this.MoistureLevel.Text = "20";
            // 
            // MoistureLabel
            // 
            this.MoistureLabel.AutoSize = true;
            this.MoistureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.MoistureLabel.Location = new System.Drawing.Point(194, 169);
            this.MoistureLabel.Name = "MoistureLabel";
            this.MoistureLabel.Size = new System.Drawing.Size(144, 29);
            this.MoistureLabel.TabIndex = 1;
            this.MoistureLabel.Text = "Moisture %";
            // 
            // MoistureBar
            // 
            this.MoistureBar.Location = new System.Drawing.Point(117, 123);
            this.MoistureBar.Maximum = 38;
            this.MoistureBar.Name = "MoistureBar";
            this.MoistureBar.Size = new System.Drawing.Size(26, 224);
            this.MoistureBar.TabIndex = 0;
            this.MoistureBar.Value = 20;
            this.MoistureBar.ValueChanged += new System.EventHandler(this.UpdateMoistureLabel);
            // 
            // DeflectionsTab
            // 
            this.DeflectionsTab.Controls.Add(this.panel5);
            this.DeflectionsTab.Controls.Add(this.panel3);
            this.DeflectionsTab.Controls.Add(this.panel2);
            this.DeflectionsTab.Controls.Add(this.LoadBox);
            this.DeflectionsTab.Controls.Add(this.LoadLabel);
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
            // LoadBox
            // 
            this.LoadBox.Location = new System.Drawing.Point(268, 65);
            this.LoadBox.Name = "LoadBox";
            this.LoadBox.Size = new System.Drawing.Size(100, 26);
            this.LoadBox.TabIndex = 12;
            // 
            // LoadLabel
            // 
            this.LoadLabel.AutoSize = true;
            this.LoadLabel.Location = new System.Drawing.Point(120, 68);
            this.LoadLabel.Name = "LoadLabel";
            this.LoadLabel.Size = new System.Drawing.Size(125, 20);
            this.LoadLabel.TabIndex = 11;
            this.LoadLabel.Text = "Load Weight (lb)";
            // 
            // CalculateDeflectionsButton
            // 
            this.CalculateDeflectionsButton.Location = new System.Drawing.Point(369, 375);
            this.CalculateDeflectionsButton.Name = "CalculateDeflectionsButton";
            this.CalculateDeflectionsButton.Size = new System.Drawing.Size(103, 39);
            this.CalculateDeflectionsButton.TabIndex = 10;
            this.CalculateDeflectionsButton.Text = "Calculate";
            this.CalculateDeflectionsButton.UseVisualStyleBackColor = true;
            this.CalculateDeflectionsButton.Click += new System.EventHandler(this.CalculateDeflections);
            // 
            // EdgeResultBox
            // 
            this.EdgeResultBox.Enabled = false;
            this.EdgeResultBox.Location = new System.Drawing.Point(705, 269);
            this.EdgeResultBox.Name = "EdgeResultBox";
            this.EdgeResultBox.Size = new System.Drawing.Size(100, 26);
            this.EdgeResultBox.TabIndex = 9;
            // 
            // FlatResultBox
            // 
            this.FlatResultBox.Enabled = false;
            this.FlatResultBox.Location = new System.Drawing.Point(705, 167);
            this.FlatResultBox.Name = "FlatResultBox";
            this.FlatResultBox.Size = new System.Drawing.Size(100, 26);
            this.FlatResultBox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(414, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(270, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Deflection With Edge Grain ( inches )";
            // 
            // FlatResultLabel
            // 
            this.FlatResultLabel.AutoSize = true;
            this.FlatResultLabel.Location = new System.Drawing.Point(414, 170);
            this.FlatResultLabel.Name = "FlatResultLabel";
            this.FlatResultLabel.Size = new System.Drawing.Size(259, 20);
            this.FlatResultLabel.TabIndex = 6;
            this.FlatResultLabel.Text = "Deflection With Flat Grain ( inches )";
            // 
            // SpanLabel
            // 
            this.SpanLabel.AutoSize = true;
            this.SpanLabel.Location = new System.Drawing.Point(72, 312);
            this.SpanLabel.Name = "SpanLabel";
            this.SpanLabel.Size = new System.Drawing.Size(93, 20);
            this.SpanLabel.TabIndex = 5;
            this.SpanLabel.Text = "Beam Span";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(63, 231);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(102, 20);
            this.HeightLabel.TabIndex = 4;
            this.HeightLabel.Text = "Beam Height";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(69, 144);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(96, 20);
            this.WidthLabel.TabIndex = 3;
            this.WidthLabel.Text = "Beam Width";
            // 
            // SpanBox
            // 
            this.SpanBox.Location = new System.Drawing.Point(268, 309);
            this.SpanBox.Name = "SpanBox";
            this.SpanBox.Size = new System.Drawing.Size(100, 26);
            this.SpanBox.TabIndex = 2;
            // 
            // HeightBox
            // 
            this.HeightBox.Location = new System.Drawing.Point(268, 228);
            this.HeightBox.Name = "HeightBox";
            this.HeightBox.Size = new System.Drawing.Size(100, 26);
            this.HeightBox.TabIndex = 1;
            // 
            // WidthBox
            // 
            this.WidthBox.Location = new System.Drawing.Point(268, 141);
            this.WidthBox.Name = "WidthBox";
            this.WidthBox.Size = new System.Drawing.Size(100, 26);
            this.WidthBox.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(651, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "lbs per cubic foot";
            // 
            // inchRadio
            // 
            this.inchRadio.AutoSize = true;
            this.inchRadio.Checked = true;
            this.inchRadio.Location = new System.Drawing.Point(17, 3);
            this.inchRadio.Name = "inchRadio";
            this.inchRadio.Size = new System.Drawing.Size(46, 24);
            this.inchRadio.TabIndex = 22;
            this.inchRadio.TabStop = true;
            this.inchRadio.Text = "in";
            this.inchRadio.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.feetRadio);
            this.panel1.Controls.Add(this.inchRadio);
            this.panel1.Location = new System.Drawing.Point(175, 262);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(79, 59);
            this.panel1.TabIndex = 23;
            // 
            // feetRadio
            // 
            this.feetRadio.AutoSize = true;
            this.feetRadio.Location = new System.Drawing.Point(17, 32);
            this.feetRadio.Name = "feetRadio";
            this.feetRadio.Size = new System.Drawing.Size(44, 24);
            this.feetRadio.TabIndex = 23;
            this.feetRadio.TabStop = true;
            this.feetRadio.Text = "ft";
            this.feetRadio.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.widthFeetRadio);
            this.panel2.Controls.Add(this.widthInchRadio);
            this.panel2.Location = new System.Drawing.Point(178, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(67, 75);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.heightFeetRadio);
            this.panel3.Controls.Add(this.heightInchRadio);
            this.panel3.Location = new System.Drawing.Point(178, 196);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(67, 82);
            this.panel3.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.spanFeetRadio);
            this.panel5.Controls.Add(this.spanInchRadio);
            this.panel5.Location = new System.Drawing.Point(178, 293);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(67, 69);
            this.panel5.TabIndex = 16;
            // 
            // widthInchRadio
            // 
            this.widthInchRadio.AutoSize = true;
            this.widthInchRadio.Checked = true;
            this.widthInchRadio.Location = new System.Drawing.Point(4, 4);
            this.widthInchRadio.Name = "widthInchRadio";
            this.widthInchRadio.Size = new System.Drawing.Size(46, 24);
            this.widthInchRadio.TabIndex = 0;
            this.widthInchRadio.TabStop = true;
            this.widthInchRadio.Text = "in";
            this.widthInchRadio.UseVisualStyleBackColor = true;
            // 
            // widthFeetRadio
            // 
            this.widthFeetRadio.AutoSize = true;
            this.widthFeetRadio.Location = new System.Drawing.Point(4, 35);
            this.widthFeetRadio.Name = "widthFeetRadio";
            this.widthFeetRadio.Size = new System.Drawing.Size(44, 24);
            this.widthFeetRadio.TabIndex = 1;
            this.widthFeetRadio.Text = "ft";
            this.widthFeetRadio.UseVisualStyleBackColor = true;
            // 
            // heightInchRadio
            // 
            this.heightInchRadio.AutoSize = true;
            this.heightInchRadio.Checked = true;
            this.heightInchRadio.Location = new System.Drawing.Point(4, 17);
            this.heightInchRadio.Name = "heightInchRadio";
            this.heightInchRadio.Size = new System.Drawing.Size(46, 24);
            this.heightInchRadio.TabIndex = 0;
            this.heightInchRadio.TabStop = true;
            this.heightInchRadio.Text = "in";
            this.heightInchRadio.UseVisualStyleBackColor = true;
            // 
            // heightFeetRadio
            // 
            this.heightFeetRadio.AutoSize = true;
            this.heightFeetRadio.Location = new System.Drawing.Point(4, 48);
            this.heightFeetRadio.Name = "heightFeetRadio";
            this.heightFeetRadio.Size = new System.Drawing.Size(44, 24);
            this.heightFeetRadio.TabIndex = 1;
            this.heightFeetRadio.Text = "ft";
            this.heightFeetRadio.UseVisualStyleBackColor = true;
            // 
            // spanInchRadio
            // 
            this.spanInchRadio.AutoSize = true;
            this.spanInchRadio.Location = new System.Drawing.Point(4, 4);
            this.spanInchRadio.Name = "spanInchRadio";
            this.spanInchRadio.Size = new System.Drawing.Size(46, 24);
            this.spanInchRadio.TabIndex = 0;
            this.spanInchRadio.Text = "in";
            this.spanInchRadio.UseVisualStyleBackColor = true;
            // 
            // spanFeetRadio
            // 
            this.spanFeetRadio.AutoSize = true;
            this.spanFeetRadio.Checked = true;
            this.spanFeetRadio.Location = new System.Drawing.Point(4, 35);
            this.spanFeetRadio.Name = "spanFeetRadio";
            this.spanFeetRadio.Size = new System.Drawing.Size(44, 24);
            this.spanFeetRadio.TabIndex = 1;
            this.spanFeetRadio.TabStop = true;
            this.spanFeetRadio.Text = "ft";
            this.spanFeetRadio.UseVisualStyleBackColor = true;
            // 
            // CalculationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 517);
            this.Controls.Add(this.CalculationTabs);
            this.Name = "CalculationsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalculationsForm";
            this.CalculationTabs.ResumeLayout(false);
            this.DimensionalTab.ResumeLayout(false);
            this.DimensionalTab.PerformLayout();
            this.DensityPage.ResumeLayout(false);
            this.DensityPage.PerformLayout();
            this.DeflectionsTab.ResumeLayout(false);
            this.DeflectionsTab.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl CalculationTabs;
        private System.Windows.Forms.TabPage DimensionalTab;
        private System.Windows.Forms.TextBox tangentialChangeBox;
        private System.Windows.Forms.TextBox radialChangeBox;
        private System.Windows.Forms.Label tChangeLabel;
        private System.Windows.Forms.Label rChangeLabel;
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
        private System.Windows.Forms.Label DensityLevel;
        private System.Windows.Forms.Label DensityLabel;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.TextBox LoadBox;
        private System.Windows.Forms.Label LoadLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton feetRadio;
        private System.Windows.Forms.RadioButton inchRadio;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton spanFeetRadio;
        private System.Windows.Forms.RadioButton spanInchRadio;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton heightFeetRadio;
        private System.Windows.Forms.RadioButton heightInchRadio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton widthFeetRadio;
        private System.Windows.Forms.RadioButton widthInchRadio;

    }
}