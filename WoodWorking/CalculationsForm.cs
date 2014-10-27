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

        private double CalculateTangDimensionalChange()
        {
            return double.Parse(lengthBox.Text) * (Species.TangentialChangeCoefficient * (double.Parse(finalMoistureBox.Text) - double.Parse(initialMoistureBox.Text)));
        }

        private double CalculateRadialDimensionalChange()
        {
            return double.Parse(lengthBox.Text) * (Species.RadialChangeCoefficient * (double.Parse(finalMoistureBox.Text) - double.Parse(initialMoistureBox.Text)));
        }

        public void DoDimensionChangeCalculations(object sender, System.EventArgs e)
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

        private void CalculateDeflections(object sender, EventArgs e)
        {
            try
            {
                FlatResultBox.Text = CalculateDeflection(Species.FlatShearModulus).ToString();
            }
            catch (Exception)
            {
                FlatResultBox.Text = "";
            }
            try
            {
                EdgeResultBox.Text = CalculateDeflection(Species.EdgeShearModulus).ToString();
            }
            catch (Exception)
            {
                EdgeResultBox.Text = "";
            }
        }

        private double CalculateDeflection(double shearModulus)
        {
            double width = double.Parse(WidthBox.Text);
            double height = double.Parse(HeightBox.Text);
            double span = double.Parse(SpanBox.Text);

            double modifiedArea = 5/6*width*height;
            double intertia = width*height*height*height/12;

            return 0;
        }

        
    }
}
