using System;
using System.Linq;
using System.Windows.Forms;

namespace WoodWorking
{
    public partial class VerifyDelete : Form
    {
        Species Species;
        private DataManager Data;

        internal VerifyDelete(Species species, DataManager data)
        {
            Data = data;
            this.Species = species;
            InitializeComponent();
        }

        private void CancelDelete(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AcceptDelete(object sender, EventArgs e)
        {
            if (Data.SpeciesList.Remove(Species))
            {
                Data.SpeciesList = Data.SpeciesList.OrderBy(s => s.Name).ToList();
                Data.WriteSpecies();
                EWood.StartForm.RefreshSpecies();
            }
            this.Close();
        }
    }
}
