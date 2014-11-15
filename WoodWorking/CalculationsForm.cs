using System;
using System.Windows.Forms;

namespace WoodWorking
{
    public partial class CalculationsForm : Form
    {
        public Species Species;
        public CalculationsForm(Species species)
        {
            Species = species;
            InitializeComponent();
        }

        private void DoDimensionChangeCalculations(object sender, System.EventArgs e)
        {
            double length;
            double initialMoisture;
            double finalMoisture;

            try
            {
                length = double.Parse(lengthBox.Text);
                initialMoisture = double.Parse(initialMoistureBox.Text);
                finalMoisture = double.Parse(finalMoistureBox.Text);
            }
            catch (Exception)
            {
                var errorBox = new Error("Entered values are not valid.");
                errorBox.ShowDialog();
                radialChangeBox.Text = "";
                tangentialChangeBox.Text = "";
                return;
            }

            CheckForDimentionalZeros();

            try
            {
                radialChangeBox.Text =
                    Species.CalculateRadialDimensionalChange(length, initialMoisture, finalMoisture).ToString("N2");
            }
            catch (Exception)
            {
                var errorBox = new Error("Radial change calculation has failed.");
                errorBox.ShowDialog();
                radialChangeBox.Text = "";
            }

            try
            {
                tangentialChangeBox.Text =
                    Species.CalculateTangDimensionalChange(length, initialMoisture, finalMoisture).ToString("N2"); ;
            }
            catch (Exception)
            {
                var errorBox = new Error("Tangential change calculation has failed.");
                errorBox.ShowDialog();
                tangentialChangeBox.Text = "";
            }
        }

        private void CalculateDeflections(object sender, EventArgs e)
        {
            double width; 
            double height; 
            double span; 
            double load;

            try
            {
                load = double.Parse(LoadBox.Text);
                span = double.Parse(SpanBox.Text);
                height = double.Parse(HeightBox.Text);
                width = double.Parse(WidthBox.Text);
            }
            catch (Exception)
            {
                var errorBox = new Error("Entered values are not valid");
                errorBox.ShowDialog();
                FlatResultBox.Text = "";
                EdgeResultBox.Text = "";
                return;
            }

            CheckForDeflectionZeros();

            try
            {
                FlatResultBox.Text = Species.CalculateDeflectionForFlat(width,height,span,load).ToString("N2");
            }
            catch (Exception)
            {
                var errorBox = new Error("Flat deflection calculation has failed.");
                errorBox.ShowDialog();
                FlatResultBox.Text = "";
            }
            try
            {
                EdgeResultBox.Text = Species.CalculateDeflectionForEdge(width,height,span,load).ToString("N2");
            }
            catch (Exception)
            {
                var errorBox = new Error("Edge deflection change calculation has failed.");
                errorBox.ShowDialog();
                EdgeResultBox.Text = "";
            }
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

            var density = Species.GetDensityAtMoistureContent(double.Parse(MoistureLevel.Text));
            DensityLevel.Text = density.ToString("N2");
        }

        private void CheckForDimentionalZeros()
        {
            if (Species.TangentialChangeCoefficient == 0)
            {
                var errorBox = new Error("The tangential coefficient is zero for this species.");
                errorBox.ShowDialog();
            }

            if (Species.RadialChangeCoefficient == 0)
            {
                var errorBox = new Error("The radial coefficient is zero for this species.");
                errorBox.ShowDialog();
            }
        }

        private void CheckForDeflectionZeros()
        {
            if (Species.EdgeShearModulus == 0)
            {
                var errorBox = new Error("The edge shear modulus is zero for this species.");
                errorBox.ShowDialog();
            }

            if (Species.FlatShearModulus == 0)
            {
                var errorBox = new Error("The flat shear modulus is zero for this species.");
                errorBox.ShowDialog();
            }
        }

        private bool ValidateDensity()
        {
            return Species.SpecificGravityAtGreen > 0;
        }
    }
}
