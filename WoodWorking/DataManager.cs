using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WoodWorking
{
    internal class DataManager
    {
        public List<Species> SpeciesList;

        public DataManager()
        {
            Initialize();
        }

        private void Initialize()
        {
            SpeciesList = new List<Species>();
            using (var reader = new StreamReader("./data.txt"))
            {
                string line;
                while (!string.IsNullOrWhiteSpace((line = reader.ReadLine())))
                {
                    var words = line.Split('|');
                    SpeciesList.Add(new Species
                    {
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

        public void WriteSpecies()
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
    }
}
