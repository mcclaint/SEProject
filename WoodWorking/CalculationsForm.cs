using System;
using System.Windows.Forms;

namespace WoodWorking
{
    public partial class CalculationsForm : Form
    {
        public Species Species;
        public CalculationsForm(Species species)
        {
            this.Species = species;
            InitializeComponent();
        }

        public double CalculateTangDimensionalChange()
        {
            return double.Parse(lengthBox.Text) * (Species.TangentialChangeCoefficient * (double.Parse(finalMoistureBox.Text) - double.Parse(initialMoistureBox.Text)));
        }

        public double CalculateRadialDimensionalChange()
        {
            return double.Parse(lengthBox.Text) * (Species.RadialChangeCoefficient * (double.Parse(finalMoistureBox.Text) - double.Parse(initialMoistureBox.Text)));
        }

        private void DoCalculations(object sender, System.EventArgs e)
        {
            try
            {
                radialChangeBox.Text =
                    CalculateRadialDimensionalChange().ToString();
            }
            catch (Exception)
            {
                radialChangeBox.Text = "";
            }

            try
            {
                tangentialChangeBox.Text =
                    CalculateTangDimensionalChange().ToString();
            }
            catch (Exception)
            {
                tangentialChangeBox.Text = "";
            }

        }
    }
}
