using System;
using System.Linq;
using System.Windows.Forms;

namespace WoodWorking
{
    public partial class VerifyDelete : Form
    {
        Species Species;

        internal VerifyDelete(Species species)
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
            if (EWood.Data.SpeciesList.Remove(Species))
            {
                EWood.Data.SpeciesList = EWood.Data.SpeciesList.OrderBy(s => s.Name).ToList();
                EWood.Data.WriteSpecies();
                EWood.StartForm.RefreshSpecies();
            }
            this.Close();
        }
    }
}
