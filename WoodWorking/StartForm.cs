using System;
using System.Windows.Forms;

namespace WoodWorking
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            comboBox1.DataSource = Program.SpeciesList;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Name";
        }

        private void ViewClick(object sender, EventArgs e)
        {
            var details = new DetailsForm((Species)comboBox1.SelectedItem);
            details.ShowDialog();
        }

        private void CreateNewSpecies(object sender, EventArgs e)
        {
            var newSpecies = new DetailsForm(null);
            newSpecies.ShowDialog();
        }

        public void RefreshSpecies()
        {
            comboBox1.SelectedIndex = 0;
            comboBox1.DataSource = Program.SpeciesList;
        }
    }
}
