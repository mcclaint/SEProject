using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace WoodWorking
{
    public static class Program
    {
        public static List<Species> SpeciesList;
        public static StartForm StartForm;

        [STAThread]
        static void Main()
        {
            try
            {
                Initialize();
            }
            catch (Exception)
            {
                var error = new Error("File upload failed.");
                error.ShowDialog();
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            StartForm = new StartForm();
            Application.Run(StartForm);
        }

        static void Initialize()
        {
            SpeciesList = new List<Species>();
            using (var reader = new StreamReader("./data.txt"))
            {
                string line;
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
                        NativeLocation = (NativeLocation)Enum.Parse(typeof(NativeLocation), words[6]),
                        RadialChangeCoefficient = double.Parse(words[7]),
                        ModulusOfElasticity = double.Parse(words[8]),
                        EdgeShearModulusRatio = double.Parse(words[9]),
                        FlatShearModulusRatio = double.Parse(words[10]),
                        TangentialChangeCoefficient = double.Parse(words[11]),
                        SpecificGravityAtGreen = double.Parse(words[12])
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
                        s.NativeLocation + "|" +
                        s.RadialChangeCoefficient + "|" +
                        s.ModulusOfElasticity + "|" +
                        s.EdgeShearModulusRatio + "|" +
                        s.FlatShearModulusRatio + "|" +
                        s.TangentialChangeCoefficient + "|" +
                        s.SpecificGravityAtGreen
                    ));
            }
        }

        //WARNING
        //WARNING
        //------ This code is to only be used for initially setting up data------
        //------ Do not call this method or any code below this point------
        #region data generation/parsing
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
                    if (speciesList.All(s => s.Name != treeName))
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
                    if (speciesList.All(s => s.Name != treeName))
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

        public static void ParseDimensionChanges()
        {
            using (var reader = new StreamReader("./dimenChange.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    string[] words = line.Split((string[])null, StringSplitOptions.RemoveEmptyEntries); ;

                    for (int i = 0; i < words.Count(); i++)
                    {
                        words[i] = words[i].Trim(',');
                    }

                    string name = "";

                    for (int i = 0; i < words.Length - 2; i++)
                    {
                        name += words[i] + " ";
                    }

                    name = name.Trim();

                    var editSpecies = SpeciesList.FirstOrDefault(s => s.Name.ToLower().Trim().Contains(name.ToLower().Trim()));

                    if (editSpecies != null)
                    {
                        editSpecies.RadialChangeCoefficient = double.Parse(words[words.Length - 2]);
                        editSpecies.TangentialChangeCoefficient = double.Parse(words[words.Length - 1]);
                    }
                }
                WriteSpecies();
            }
        }

        public static void ParseElasticityData()
        {
            using (var reader = new StreamReader("./modulusData.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != "canada")
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    string[] words = line.Split((string[])null, StringSplitOptions.RemoveEmptyEntries); ;

                    for (int i = 0; i < words.Count(); i++)
                    {
                        words[i] = words[i].Trim(',');
                    }

                    string name = "";

                    for (int i = 0; i < words.Length - 22; i++)
                    {
                        name += words[i] + " ";
                    }

                    name = name.Trim();

                    var editSpecies = SpeciesList.FirstOrDefault(s => s.Name.ToLower().Trim().Contains(name.ToLower().Trim()));

                    if (editSpecies != null)
                    {
                        editSpecies.ModulusOfElasticity = double.Parse(words[words.Length - 19]);
                        editSpecies.SpecificGravityAtGreen = double.Parse(words[words.Length - 21]);
                        
                    }
                }

                while ((line = reader.ReadLine()) != "break")
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    string[] words = line.Split((string[])null, StringSplitOptions.RemoveEmptyEntries); ;

                    for (int i = 0; i < words.Count(); i++)
                    {
                        words[i] = words[i].Trim(',');
                    }

                    string name = "";

                    for (int i = 0; i < words.Length - 13; i++)
                    {
                        name += words[i] + " ";
                    }

                    name = name.Trim();

                    var editSpecies = SpeciesList.FirstOrDefault(s => s.Name.ToLower().Trim().Contains(name.ToLower().Trim()));

                    if (editSpecies != null)
                    {
                        editSpecies.ModulusOfElasticity = double.Parse(words[words.Length - 10]);
                        editSpecies.SpecificGravityAtGreen = double.Parse(words[words.Length - 12]);
                    }
                }

                while ((line = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    string[] words = line.Split((string[])null, StringSplitOptions.RemoveEmptyEntries); ;

                    for (int i = 0; i < words.Count(); i++)
                    {
                        words[i] = words[i].Trim(',');
                    }

                    string name = "";

                    for (int i = 0; i < words.Length - 5; i++)
                    {
                        name += words[i] + " ";
                    }

                    name = name.Trim();

                    var editSpecies = SpeciesList.FirstOrDefault(s => s.Name.ToLower().Trim().Contains(name.ToLower().Trim()));

                    if (editSpecies != null)
                    {
                        if (words[words.Length - 2] != "-")
                            editSpecies.FlatShearModulusRatio = double.Parse(words[words.Length - 2]);
                        editSpecies.EdgeShearModulusRatio = double.Parse(words[words.Length - 3]);
                    }
                }

                WriteSpecies();
            }
        }
        #endregion
    }
}
