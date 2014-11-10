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

        public void DoDimensionChangeCalculations(object sender, System.EventArgs e)
        {
            double length;
            double initialMoisture;
            double finalMoisture;

            double.TryParse(lengthBox.Text, out length);
            double.TryParse(initialMoistureBox.Text, out initialMoisture);
            double.TryParse(finalMoistureBox.Text, out finalMoisture);

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
            double.TryParse(WidthBox.Text, out width);
            double height; 
            double.TryParse(HeightBox.Text, out height);
            double span; 
            double.TryParse(SpanBox.Text, out span);
            double load; 
            double.TryParse(LoadBox.Text, out load);

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

        private bool ValidateDensity()
        {
            return Species.SpecificGravityAtGreen > 0;
        }
    }
}
