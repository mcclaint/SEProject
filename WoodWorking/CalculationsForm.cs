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

        private void CalculateDimensionalChanges(object sender, System.EventArgs e)
        {
            #region validation

            if (!DataIsValidForDimensionalChange())
                return;

            CheckForDimentionalZeros();
            #endregion

            var length = double.Parse(lengthBox.Text);
            var initialMoisture = double.Parse(initialMoistureBox.Text);
            var finalMoisture = double.Parse(finalMoistureBox.Text);

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
            #region validation

            if (!DataIsValidForDeflection())
                return;

            CheckForDeflectionZeros();
            #endregion

            var load = double.Parse(LoadBox.Text);
            var span = double.Parse(SpanBox.Text);
            var height = double.Parse(HeightBox.Text);
            var width = double.Parse(WidthBox.Text);

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
            #region validation
            if (!ValidateDensity())
            {
                ErrorLabel.Visible = true;
                return;
            }
            #endregion

            var density = Species.GetDensityAtMoistureContent(double.Parse(MoistureLevel.Text));
            DensityLevel.Text = density.ToString("N2");
        }

        #region Validation Methods

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

        private bool DataIsValidForDeflection()
        {
            double trash;

            if (!(double.TryParse(LoadBox.Text, out trash) && double.TryParse(HeightBox.Text, out trash) &&
                double.TryParse(WidthBox.Text, out trash) && double.TryParse(SpanBox.Text, out trash)))
            {
                var errorBox = new Error("Entered values are not valid");
                errorBox.ShowDialog();
                FlatResultBox.Text = "";
                EdgeResultBox.Text = "";
                return false;
            }

            return true;
        }

        private bool DataIsValidForDimensionalChange()
        {
            double trash;

            if (!(double.TryParse(lengthBox.Text, out trash) &&
                double.TryParse(initialMoistureBox.Text, out trash) &&
                double.TryParse(finalMoistureBox.Text, out trash)))
            {
                var errorBox = new Error("Entered values are not valid.");
                errorBox.ShowDialog();
                radialChangeBox.Text = "";
                tangentialChangeBox.Text = "";
                return false;
            }

            return true;
        }
        #endregion
    }
}
