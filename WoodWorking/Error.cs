using System.Windows.Forms;

namespace WoodWorking
{
    public partial class Error : Form
    {
        public Error(string error)
        {
            InitializeComponent();

            label1.Text = error;
        }
    }
}
