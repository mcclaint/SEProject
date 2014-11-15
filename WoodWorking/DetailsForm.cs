﻿using System;
using System.Linq;
using System.Windows.Forms;

namespace WoodWorking
{
    public partial class DetailsForm : Form
    {
        internal Species Species;
        internal Species EditedSpecies;
        internal DataManager Data;

        internal DetailsForm(Species species, DataManager data)
        {
            Data = data;
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
                SGBox.Text = Species.SpecificGravityAtGreen.ToString();
                ElasticityBox.Text = Species.ModulusOfElasticity.ToString();
                EdgeBox.Text = Species.EdgeShearModulusRatio.ToString();
                FlatBox.Text = Species.FlatShearModulusRatio.ToString();
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

            if (Species != null)
                Data.SpeciesList.Remove(Species);

            if (CheckForDuplicateNames(SpeciesBox.Text))
            {
                var error = new Error("A species with that name is already in the data file.");
                error.ShowDialog();
                Data.SpeciesList.Add(Species);
                Data.SpeciesList = Data.SpeciesList.OrderBy(s => s.Name).ToList();
                Data.WriteSpecies();
                EWood.StartForm.RefreshSpecies();

                Close();
            }
            
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
                NativeLocation = (NativeLocation)comboBox1.SelectedItem,
                EdgeShearModulusRatio = double.Parse(EdgeBox.Text),
                FlatShearModulusRatio = double.Parse(FlatBox.Text),
                ModulusOfElasticity = double.Parse(ElasticityBox.Text),
                SpecificGravityAtGreen = double.Parse(SGBox.Text)
            };

            Data.SpeciesList.Add(EditedSpecies);
            Data.SpeciesList = Data.SpeciesList.OrderBy(s => s.Name).ToList();
            Data.WriteSpecies();
            EWood.StartForm.RefreshSpecies();
            Species = EditedSpecies;

            DisableEdits();
        }

        private bool CheckForDuplicateNames(string name)
        {
            return Data.SpeciesList.Any(s => s.Name.Equals(name));
        }

        private bool ValidateSave()
        {
            if (!SpeciesBox.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c) || c.Equals(',') || c.Equals('-')))
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
                double.TryParse(TangentialChangeBox.Text, out temp) &&
                double.TryParse(EdgeBox.Text, out temp) &&
                double.TryParse(FlatBox.Text, out temp) &&
                double.TryParse(SGBox.Text, out temp) &&
                double.TryParse(ElasticityBox.Text, out temp) &&
                comboBox1.SelectedItem != null);
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
            SGBox.Enabled = true;
            ElasticityBox.Enabled = true;
            EdgeBox.Enabled = true;
            FlatBox.Enabled = true;
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
            SGBox.Enabled = false;
            ElasticityBox.Enabled = false;
            FlatBox.Enabled = false;
            EdgeBox.Enabled = false;
            EditButton.Visible = true;
            DeleteButton.Visible = true;
            CalculationsButton.Visible = true;
        }

        private void DeleteSpecies(object sender, EventArgs e)
        {
            var deleteWindow = new VerifyDelete(Species, Data);
            deleteWindow.ShowDialog();
            Close();
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
