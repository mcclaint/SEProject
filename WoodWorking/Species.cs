using System;

namespace WoodWorking
{
    public class Species : IEquatable<Species>
    {
        public string Name { get; set; }
        public double HeartwoodMoisture { get; set; }
        public double SapwoodMoisture { get; set; }
        public double RadialShrinkage { get; set; }
        public double TangentialShrinkage { get; set; }
        public double VolumetricShrinkage { get; set; }
        public double TangentialChangeCoefficient { get; set; }
        public double RadialChangeCoefficient { get; set; }
        public double ModulusOfElasticity { get; set; }
        public double SpecificGravityAtGreen { get; set; }
        public double SpecificGravityAt12 { get; set; }
        public double FlatShearModulusRatio { get; set; }
        public double EdgeShearModulusRatio { get; set; }
        public double EdgeShearModulus {
            get { return EdgeShearModulusRatio*(ModulusOfElasticity + ModulusOfElasticity*.1); }
        }

        public double FlatShearModulus {
            get { return FlatShearModulusRatio*(ModulusOfElasticity + ModulusOfElasticity*.1); }
        }
        public NativeLocation NativeLocation { get; set; }

        public bool Equals(Species other)
        {
            return
                this.Name == other.Name &&
                this.HeartwoodMoisture == other.HeartwoodMoisture &&
                this.SapwoodMoisture == other.SapwoodMoisture &&
                this.RadialShrinkage == other.RadialShrinkage &&
                this.TangentialShrinkage == other.TangentialShrinkage &&
                this.VolumetricShrinkage == other.VolumetricShrinkage &&
                this.TangentialChangeCoefficient == other.TangentialChangeCoefficient &&
                this.RadialChangeCoefficient == other.TangentialChangeCoefficient &&
                this.NativeLocation == other.NativeLocation
            ;
        }

        public double CalculateTangDimensionalChange(double length, double initialMoisture, double finalMoisture)
        {
            return length * (TangentialChangeCoefficient * (finalMoisture - initialMoisture));
        }

        public double CalculateRadialDimensionalChange(double length, double initialMoisture, double finalMoisture)
        {
            return length * (RadialChangeCoefficient * (finalMoisture - initialMoisture));
        }

        public double GetDensityAtMoistureContent(double moistureContent)
        {
            var a = (30 - moistureContent) / 30;
            var specificGravityForMoistureContent = SpecificGravityAtGreen /
                                             (1 - (.256 * a * SpecificGravityAtGreen));

            return 62.4 * specificGravityForMoistureContent * (1 + moistureContent / 100);
        }

        public double CalculateDeflectionForEdge(double width, double height, double span, double load)
        {
            double modifiedArea = ((double)5 / (double)6) * width * height;
            double intertia = width * height * height * height / 12;

            double kb = ((double)1 / (double)48);
            double ks = .25;

            var firstBlock = (kb * load * span * span * span) / (ModulusOfElasticity * intertia);
            var secondBlock = (ks * load * span) / (EdgeShearModulus * modifiedArea);

            return firstBlock + secondBlock;
        }

        public double CalculateDeflectionForFlat(double width, double height, double span, double load)
        {
            double modifiedArea = ((double)5 / (double)6) * width * height;
            double intertia = width * height * height * height / 12;

            double kb = ((double)1 / (double)48);
            double ks = .25;

            var firstBlock = (kb * load * span * span * span) / (ModulusOfElasticity * intertia);
            var secondBlock = (ks * load * span) / (FlatShearModulus * modifiedArea);

            return firstBlock + secondBlock;
        }
    }

    public enum NativeLocation
    {
        UnitedStates = 0,
        Africa = 1,
        TropicalAmerica = 2,
        AsiaOceania = 4
    }
}
