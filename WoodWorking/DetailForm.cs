using System;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

namespace WoodWorking
{
    public partial class DetailForm : Form
    {
        internal Species Species;
        internal Species EditedSpecies;

        internal DetailForm(Species species)
        {
            InitializeComponent();
            locationBox.DataSource = Enum.GetValues(typeof(NativeLocation));

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
                SGBox.Text = Species.SpecificGravityAtGreen.ToString();
                ElasticityBox.Text = Species.ModulusOfElasticity.ToString();
                EdgeBox.Text = Species.EdgeShearModulusRatio.ToString();
                FlatBox.Text = Species.FlatShearModulusRatio.ToString();
                locationBox.SelectedItem = Enum.Parse(typeof(NativeLocation), Species.NativeLocation.ToString());

                SaveButton.Visible = false;
            }

            else
            {
                Species = null;
                SpeciesBox.Text = "New Species";
                textBox1.Text = "0";
                textBox2.Text = "0";
                textBox3.Text = "0";
                textBox4.Text = "0";
                textBox5.Text = "0";
                RadialChangeBox.Text = "0";
                TangentialChangeBox.Text = "0";
                SGBox.Text = "0";
                ElasticityBox.Text = "0";
                EdgeBox.Text = "0";
                FlatBox.Text = "0";
                EnableEdits();
            }
        }

        private void EditSpecies(object sender, EventArgs e)
        {
            EnableEdits();
        }

        private void SaveSpecies(object sender, EventArgs e)
        {
            #region validation
            ErrorLabel.Visible = false;

            if (Species != null)
                EWood.Data.SpeciesList.Remove(Species);

            if (!InputIsValidForSave())
            {
                ErrorLabel.Visible = true;
                AddSpeciesToData(Species);
                return;
            }

            if (DuplicateNamesExist(SpeciesBox.Text))
            {
                AddSpeciesToData(Species);
                Close();
            }

            #endregion

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
                NativeLocation = (NativeLocation)locationBox.SelectedItem,
                EdgeShearModulusRatio = double.Parse(EdgeBox.Text),
                FlatShearModulusRatio = double.Parse(FlatBox.Text),
                ModulusOfElasticity = double.Parse(ElasticityBox.Text),
                SpecificGravityAtGreen = double.Parse(SGBox.Text)
            };

            AddSpeciesToData(EditedSpecies);
            Species = EditedSpecies;

            DisableEdits();
        }

        private void DeleteSpecies(object sender, EventArgs e)
        {
            var deleteWindow = new VerifyDelete(Species);
            deleteWindow.ShowDialog();
            Close();
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
            locationBox.Enabled = true;
            SGBox.Enabled = true;
            ElasticityBox.Enabled = true;
            EdgeBox.Enabled = true;
            FlatBox.Enabled = true;
            EditButton.Visible = false;
            DeleteButton.Visible = false;
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
            locationBox.Enabled = false;
            SGBox.Enabled = false;
            ElasticityBox.Enabled = false;
            FlatBox.Enabled = false;
            EdgeBox.Enabled = false;
            EditButton.Visible = true;
            DeleteButton.Visible = true;
        }

        private static void AddSpeciesToData(Species species)
        {
            if (species == null)
                return;

            EWood.Data.SpeciesList.Add(species);
            EWood.Data.SpeciesList = EWood.Data.SpeciesList.OrderBy(s => s.Name).ToList();
            EWood.Data.WriteSpecies();
            EWood.StartForm.RefreshSpecies();
        }

        #region Validation Methods

        private bool NameIsValid()
        {
            if (!SpeciesBox.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c) || c.Equals(',') || c.Equals('-')))
            {
                var error = new Error("A species name must only contain letters.");
                error.ShowDialog();
                return false;
            }

            return true;
        }

        private static bool DuplicateNamesExist(string name)
        {
            if (EWood.Data.SpeciesList.Any(s => s.Name.Equals(name)))
            {
                var error = new Error("A species with that name is already in the data file.");
                error.ShowDialog();
                return true;
            }

            return false;
        }

        private bool InputIsValidForSave()
        {
            if (!NameIsValid())
                return false;

            double temp;

            if (
                !(!string.IsNullOrEmpty(SpeciesBox.Text) &&
                  double.TryParse(textBox1.Text, out temp) &&
                  double.TryParse(textBox2.Text, out temp) &&
                  double.TryParse(textBox3.Text, out temp) &&
                  double.TryParse(textBox4.Text, out temp) &&
                  double.TryParse(textBox5.Text, out temp) &&
                  double.TryParse(RadialChangeBox.Text, out temp) &&
                  double.TryParse(TangentialChangeBox.Text, out temp) &&
                  double.TryParse(EdgeBox.Text, out temp) &&
                  double.TryParse(FlatBox.Text, out temp) &&
                  double.TryParse(SGBox.Text, out temp) &&
                  double.TryParse(ElasticityBox.Text, out temp) &&
                  locationBox.SelectedItem != null))
                return false;

            if (textBox1.Text.Contains("-") ||
                  textBox2.Text.Contains("-") ||
                  textBox3.Text.Contains("-") ||
                  textBox4.Text.Contains("-") ||
                  textBox5.Text.Contains("-") ||
                  RadialChangeBox.Text.Contains("-") ||
                  TangentialChangeBox.Text.Contains("-") ||
                  EdgeBox.Text.Contains("-") ||
                  FlatBox.Text.Contains("-") ||
                  SGBox.Text.Contains("-") ||
                  ElasticityBox.Text.Contains("-"))
            {
                var error = new Error("Negative values are not allowed.");
                error.ShowDialog();
                return false;
            }

            return true;
        }
        #endregion
    }
}
