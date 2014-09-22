using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoodWorking
{
    public partial class DetailsForm : Form
    {
        public Species Species;
        public Species editedSpecies;

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
            editedSpecies = new Species
            {
                Name = SpeciesBox.Text,
                HeartwoodMoisture = double.Parse(textBox1.Text),
                SapwoodMoisture = double.Parse(textBox2.Text),
                RadialShrinkage = double.Parse(textBox3.Text),
                TangentialShrinkage = double.Parse(textBox4.Text),
                VolumetricShrinkage = double.Parse(textBox5.Text),
                NativeLocation = (NativeLocation)comboBox1.SelectedItem
            };

            if (Species != null && !Species.Equals(editedSpecies))

                Program.SpeciesList.Remove(Species);

            if (Species == null || !Species.Equals(editedSpecies))
            {
                Program.SpeciesList.Add(editedSpecies);
                Program.SpeciesList = Program.SpeciesList.OrderBy(s => s.Name).ToList();
                Program.WriteSpecies();
                Program.startForm.RefreshSpecies();
                Species = editedSpecies;
            }

            DisableEdits();
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
            comboBox1.Enabled = true;
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
            comboBox1.Enabled = false;
            EditButton.Visible = true;
            DeleteButton.Visible = true;
        }

        private void DeleteSpecies(object sender, EventArgs e)
        {
            VerifyDelete deleteWindow = new VerifyDelete(Species);
            deleteWindow.ShowDialog();
        }
    }
}
