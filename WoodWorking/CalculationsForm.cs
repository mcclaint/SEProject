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
                FlatResultBox.Text = CalculateDeflection(Species.FlatShearModulus).ToString("N2");
            }
            catch (Exception)
            {
                FlatResultBox.Text = "";
            }
            try
            {
                EdgeResultBox.Text = CalculateDeflection(Species.EdgeShearModulus).ToString("N2");
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
            double load = double.Parse(LoadBox.Text);

            double modifiedArea = ((double)5/(double)6)*width*height;
            double intertia = width*height*height*height/12;

            double kb = ((double)1/(double)48);
            double ks = .25;

            var firstBlock = (kb*load*span*span*span)/(Species.ModulusOfElasticity*intertia);
            var secondBlock = (ks*load*span)/(shearModulus*modifiedArea);

            return firstBlock + secondBlock;
        }

        private void UpdateMoistureLabel(object sender, EventArgs e)
        {
            MoistureLevel.Text = MoistureBar.Value.ToString();
        }

        private void CalculateDensity(object sender, EventArgs e)
        {
            if (!ValidateDensity())
            {
                ErrorLabel.Visible = true;
                return;
            }

            var moistureLevel = double.Parse(MoistureLevel.Text);
            var a = (30 - moistureLevel)/30;
            var specificGravityForMoistureContent = Species.SpecificGravityAtGreen/
                                             (1 - (.256*a*Species.SpecificGravityAtGreen));

            var density = 62.4 * specificGravityForMoistureContent * (1 + moistureLevel/100);
            DensityLevel.Text = density.ToString("N2");
        }

        private bool ValidateDensity()
        {
            return Species.SpecificGravityAtGreen > 0;
        }
    }
}
