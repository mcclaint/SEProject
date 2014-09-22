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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.DataSource = Program.SpeciesList;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Name";
        }

        private void ViewClick(object sender, EventArgs e)
        {
            DetailsForm details = new DetailsForm((Species)comboBox1.SelectedItem);
            details.ShowDialog();
        }

        private void CreateNewSpecies(object sender, EventArgs e)
        {
            DetailsForm newSpecies = new DetailsForm((Species)null);
            newSpecies.ShowDialog();
        }

        public void RefreshSpecies()
        {
            comboBox1.SelectedIndex = 0;
            comboBox1.DataSource = Program.SpeciesList;
        }
    }
}
