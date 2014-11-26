using System;

namespace WoodWorking
{
    public class Species : IEquatable<Species>
    {
        public string Name { get; internal set; }
        public double HeartwoodMoisture { get; internal set; }
        public double SapwoodMoisture { get; internal set; }
        public double RadialShrinkage { get; internal set; }
        public double TangentialShrinkage { get; internal set; }
        public double VolumetricShrinkage { get; internal set; }
        public double TangentialChangeCoefficient { get; internal set; }
        public double RadialChangeCoefficient { get; internal set; }
        public double ModulusOfElasticity { get; internal set; }
        public double SpecificGravityAtGreen { get; internal set; }
        public double FlatShearModulusRatio { get; internal set; }
        public double EdgeShearModulusRatio { get; internal set; }

        public double EdgeShearModulus {
            get { return EdgeShearModulusRatio*(ModulusOfElasticity + ModulusOfElasticity*.1); }
        }

        public double FlatShearModulus {
            get { return FlatShearModulusRatio*(ModulusOfElasticity + ModulusOfElasticity*.1); }
        }

        public NativeLocation NativeLocation { get; internal set; }

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
                this.RadialChangeCoefficient == other.RadialChangeCoefficient &&
                this.NativeLocation == other.NativeLocation &&
                this.EdgeShearModulusRatio == other.EdgeShearModulusRatio &&
                this.FlatShearModulusRatio == other.FlatShearModulusRatio &&
                this.ModulusOfElasticity == other.ModulusOfElasticity &&
                this.SpecificGravityAtGreen == other.SpecificGravityAtGreen
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
            return CalculateDeflection(width, height, span, load, EdgeShearModulus);
        }

        public double CalculateDeflectionForFlat(double width, double height, double span, double load)
        {
            return CalculateDeflection(width, height, span, load, FlatShearModulus);
        }

        private double CalculateDeflection(double width, double height, double span, double load, double shear)
        {
            double modifiedArea = (5.0 / 6.0) * width * height;
            double intertia = width * height * height * height / 12.0;

            double kb = (1.0 / 192.0);
            double ks = .25;

            double firstBlock = (kb * load * span * span * span) / (ModulusOfElasticity * 1000000 * intertia);
            double secondBlock = (ks * load * span) / (shear * modifiedArea);

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
