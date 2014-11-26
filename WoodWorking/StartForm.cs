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
            var details = new DetailForm((Species)speciesBox.SelectedItem);
            details.ShowDialog();
        }

        private void CreateNewSpecies(object sender, EventArgs e)
        {
            var newSpecies = new DetailForm(null);
            newSpecies.ShowDialog();
        }

        private void ViewCalculations(object sender, EventArgs e)
        {
            if ((Species)speciesBox.SelectedItem == null)
                return;

            var calcWindow = new CalculationsForm((Species)speciesBox.SelectedItem);
            calcWindow.ShowDialog();
        }

        public void RefreshSpecies()
        {
            speciesBox.SelectedIndex = 0;
            speciesBox.DataSource = EWood.Data.SpeciesList;
        }
    }
}
