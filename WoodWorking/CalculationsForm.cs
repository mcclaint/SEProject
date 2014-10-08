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

        public double CalculateTangDimensionalChange(double length, double initMoisture, double alteredMoisture)
        {
            return length*(Species.TangentialChangeCoefficient*(alteredMoisture - initMoisture));
        }

        public double CalculateRadialDimensionalChange(double length, double initMoisture, double alteredMoisture)
        {
            return length * (Species.RadialChangeCoefficient * (alteredMoisture - initMoisture));
        }

        private void DoCalculations(object sender, System.EventArgs e)
        {
            try
            {
                textBox4.Text =
                    CalculateRadialDimensionalChange(double.Parse(textBox3.Text), double.Parse(textBox1.Text),
                        double.Parse(textBox2.Text)).ToString();
            }
            catch (Exception)
            {
                textBox4.Text = "";
            }

            try
            {
                textBox5.Text =
                    CalculateTangDimensionalChange(double.Parse(textBox3.Text), double.Parse(textBox1.Text),
                        double.Parse(textBox2.Text)).ToString();
            }
            catch (Exception)
            {
                textBox5.Text = "";
            }

        }
    }
}
