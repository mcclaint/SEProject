using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WoodWorking
{
    public static class Program
    {
        public static List<Species> SpeciesList;
        public static Form1 startForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            initialize();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            startForm = new Form1();
            Application.Run(startForm);
        }

        static void initialize()
        {
            SpeciesList = new List<Species>();
            string line;
            using (var reader = new StreamReader("./data.txt"))
            {
                while (!string.IsNullOrWhiteSpace((line = reader.ReadLine())))
                {
                    var words = line.Split('|');
                    SpeciesList.Add(new Species { 
                        Name = words[0],
                        HeartwoodMoisture = double.Parse(words[1]),
                        SapwoodMoisture = double.Parse(words[2]),
                        RadialShrinkage = double.Parse(words[3]),
                        TangentialShrinkage = double.Parse(words[4]),
                        VolumetricShrinkage = double.Parse(words[5]),
                        NativeLocation = (NativeLocation)Enum.Parse(typeof(NativeLocation), words[6])
                    });
                }
            }
            SpeciesList = SpeciesList.OrderBy(s => s.Name).ToList();
        }

        public static void WriteSpecies()
        {
            using (var writer = new StreamWriter("./data.txt"))
            {
                SpeciesList.ForEach(s => writer.WriteLine(
                        s.Name + "|" +
                        s.HeartwoodMoisture + "|" +
                        s.SapwoodMoisture + "|" +
                        s.RadialShrinkage + "|" +
                        s.TangentialShrinkage + "|" +
                        s.VolumetricShrinkage + "|" +
                        s.NativeLocation
                    ));
            }
        }

        //WARNING
        //WARNING
        //------ This code is to only be used for initially setting up data------
        //------ Do not call this method and do not alter------
        static List<Species> PopulateSpecies()
        {
            var speciesList = new List<Species>();

            using (var reader = new StreamReader("./initData.txt"))
            {
                string line;
                while (!(line = reader.ReadLine()).Contains("Break"))
                {
                    string[] words = line.Split((string[])null, StringSplitOptions.RemoveEmptyEntries); ;

                    string treeName = "";

                    for (int i = 0; i < words.Length - 3; i++)
                    {
                        treeName += words[i] + " ";
                    }
                    if (!speciesList.Any(s => s.Name == treeName))
                    {
                        speciesList.Add(new Species
                        {
                            Name = treeName.Trim(),
                            RadialShrinkage = double.Parse(words[words.Length - 3]),
                            TangentialShrinkage = double.Parse(words[words.Length - 2]),
                            VolumetricShrinkage = double.Parse(words[words.Length - 1])
                        });
                    }
                }

                while ((line = reader.ReadLine()) != "Moisture")
                {
                    string[] words = line.Split((string[])null, StringSplitOptions.RemoveEmptyEntries); ;

                    string treeName = "";

                    for (int i = 0; i < words.Length - 4; i++)
                    {
                        treeName += words[i] + " ";
                    }
                    if (!speciesList.Any(s => s.Name == treeName))
                    {
                        NativeLocation nativeLocation;

                        if (words[words.Length - 1] == "AF")
                            nativeLocation = NativeLocation.Africa;
                        else if (words[words.Length - 1] == "AM")
                            nativeLocation = NativeLocation.TropicalAmerica;
                        else
                            nativeLocation = NativeLocation.AsiaOceania;

                        speciesList.Add(new Species
                        {
                            Name = treeName.Split('(')[0].Trim(),
                            RadialShrinkage = double.Parse(words[words.Length - 4]),
                            TangentialShrinkage = double.Parse(words[words.Length - 3]),
                            VolumetricShrinkage = double.Parse(words[words.Length - 2]),
                            NativeLocation = nativeLocation
                        });
                    }
                }

                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split((string[])null, StringSplitOptions.RemoveEmptyEntries); ;

                    string name = "";

                    for (int i = 0; i < words.Length - 2; i++)
                    {
                        name += words[i] + " ";
                    }

                    var editSpecies = speciesList.FirstOrDefault(s => s.Name.ToLower().Contains(name.ToLower().Trim()));

                    if (editSpecies != null)
                    {
                        editSpecies.HeartwoodMoisture = double.Parse(words[words.Length - 2]);
                        editSpecies.SapwoodMoisture = double.Parse(words[words.Length - 1]);
                    }
                }
            }

            using (var writer = new StreamWriter("./data.txt"))
            {
                speciesList = speciesList.OrderBy(s => s.Name).ToList();
                speciesList.ForEach(s =>
                    writer.WriteLine(
                        s.Name + "|" +
                        s.HeartwoodMoisture + "|" +
                        s.SapwoodMoisture + "|" +
                        s.RadialShrinkage + "|" +
                        s.TangentialShrinkage + "|" +
                        s.VolumetricShrinkage + "|" +
                        s.NativeLocation
                    )
                );
            }

            return speciesList.OrderBy(s => s.Name).ToList();
        }
    }
}
