using System;
using System.Windows.Forms;

namespace WoodWorking
{
    public class EWood
    {
        internal DataManager Data;
        internal static StartForm StartForm;

        public EWood()
        {
            try
            {
                Data = new DataManager();
            }
            catch (Exception)
            {
                var error = new Error("File upload failed.");
                error.ShowDialog();
                throw;
            }
        }

        public void Run()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            StartForm = new StartForm(Data);
            Application.Run(StartForm);
        }
    }
}
