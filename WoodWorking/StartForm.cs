using System;
using System.Windows.Forms;

namespace WoodWorking
{
    public partial class StartForm : Form
    {
        internal StartForm()
        {
            InitializeComponent();
            speciesBox.DataSource = EWood.Data.SpeciesList;
            speciesBox.DisplayMember = "Name";
            speciesBox.ValueMember = "Name";
        }

        private void ViewClick(object sender, EventArgs e)
        {
            var details = new DetailsForm((Species)speciesBox.SelectedItem);
            details.ShowDialog();
        }

        private void CreateNewSpecies(object sender, EventArgs e)
        {
            var newSpecies = new DetailsForm(null);
            newSpecies.ShowDialog();
        }

        public void RefreshSpecies()
        {
            speciesBox.SelectedIndex = 0;
            speciesBox.DataSource = EWood.Data.SpeciesList;
        }
    }
}
