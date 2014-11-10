using System;
using System.Linq;
using System.Windows.Forms;

namespace WoodWorking
{
    public partial class DetailsForm : Form
    {
        public Species Species;
        public Species EditedSpecies;

        public DetailsForm(Species species)
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(NativeLocation));

            if (species != null)
            {
                Species = species;
                SpeciesBox.Text = Species.Name;
                textBox1.Text = Species.HeartwoodMoisture.ToString();
                textBox2.Text = Species.SapwoodMoisture.ToString();
                textBox3.Text = Species.RadialShrinkage.ToString();
                textBox4.Text = Species.TangentialShrinkage.ToString();
                textBox5.Text = Species.VolumetricShrinkage.ToString();
                RadialChangeBox.Text = Species.RadialChangeCoefficient.ToString();
                TangentialChangeBox.Text = Species.TangentialChangeCoefficient.ToString();
                comboBox1.SelectedItem = Enum.Parse(typeof(NativeLocation), Species.NativeLocation.ToString());

                SaveButton.Visible = false;
            }

            else
            {
                Species = null;
                SpeciesBox.Text = "New Species";
                EnableEdits();
            }
            
        }

        private void EditSpecies(object sender, EventArgs e)
        {
            EnableEdits();
        }

        private void SaveSpecies(object sender, EventArgs e)
        {
            if (!ValidateSave())
            {
                ErrorLabel.Visible = true;
                return;
            }

            ErrorLabel.Visible = false;

            EditedSpecies = new Species
            {
                Name = SpeciesBox.Text,
                HeartwoodMoisture = double.Parse(textBox1.Text),
                SapwoodMoisture = double.Parse(textBox2.Text),
                RadialShrinkage = double.Parse(textBox3.Text),
                TangentialShrinkage = double.Parse(textBox4.Text),
                VolumetricShrinkage = double.Parse(textBox5.Text),
                RadialChangeCoefficient = double.Parse(RadialChangeBox.Text),
                TangentialChangeCoefficient = double.Parse(TangentialChangeBox.Text),
                NativeLocation = (NativeLocation)comboBox1.SelectedItem
            };

            if (Species != null && !Species.Equals(EditedSpecies))

                Program.SpeciesList.Remove(Species);

            if (Species == null || !Species.Equals(EditedSpecies))
            {
                Program.SpeciesList.Add(EditedSpecies);
                Program.SpeciesList = Program.SpeciesList.OrderBy(s => s.Name).ToList();
                Program.WriteSpecies();
                Program.StartForm.RefreshSpecies();
                Species = EditedSpecies;
            }

            DisableEdits();
        }

        private bool ValidateSave()
        {
            if (!SpeciesBox.Text.All(char.IsLetter))
            {
                var error = new Error("A species name must only contain letters.");
                error.ShowDialog();
                return false;
            }

            double temp;

            return (
                !string.IsNullOrEmpty(SpeciesBox.Text)&&
                double.TryParse(textBox1.Text, out temp) &&
                double.TryParse(textBox2.Text, out temp) &&
                double.TryParse(textBox3.Text, out temp) &&
                double.TryParse(textBox4.Text, out temp) &&
                double.TryParse(textBox5.Text, out temp) &&
                double.TryParse(RadialChangeBox.Text, out temp) &&
                double.TryParse(TangentialChangeBox.Text, out temp));
        }

        private void EnableEdits()
        {
            SaveButton.Visible = true;
            SpeciesBox.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            TangentialChangeBox.Enabled = true;
            RadialChangeBox.Enabled = true;
            comboBox1.Enabled = true;
            EditButton.Visible = false;
            DeleteButton.Visible = false;
            CalculationsButton.Visible = false;
        }

        private void DisableEdits()
        {
            SaveButton.Visible = false;
            SpeciesBox.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            RadialChangeBox.Enabled = false;
            TangentialChangeBox.Enabled = false;
            comboBox1.Enabled = false;
            EditButton.Visible = true;
            DeleteButton.Visible = true;
            CalculationsButton.Visible = true;
        }

        private void DeleteSpecies(object sender, EventArgs e)
        {
            var deleteWindow = new VerifyDelete(Species);
            deleteWindow.ShowDialog();
        }

        private void ViewCalculations(object sender, EventArgs e)
        {
            if (Species == null)
                return;

            var calcWindow = new CalculationsForm(Species);
            calcWindow.ShowDialog();
        }
    }
}
