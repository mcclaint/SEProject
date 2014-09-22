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
    public partial class VerifyDelete : Form
    {
        Species Species;

        public VerifyDelete(Species species)
        {
            this.Species = species;
            InitializeComponent();
        }

        private void CancelDelete(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AcceptDelete(object sender, EventArgs e)
        {
            if (Program.SpeciesList.Remove(Species))
            {
                Program.SpeciesList = Program.SpeciesList.OrderBy(s => s.Name).ToList();
                Program.WriteSpecies();
                Program.startForm.RefreshSpecies();
            }
            this.Close();
        }
    }
}
