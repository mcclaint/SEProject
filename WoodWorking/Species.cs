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

        // denoted as GLR/EL in table 4-1
        public double FlatShearModulusRatio { get; internal set; }
        // denoted as GLT/EL in table 4-1
        public double EdgeShearModulusRatio { get; internal set; }

        //calculated field from above ratio
        public double EdgeShearModulus {
            get { return EdgeShearModulusRatio*((ModulusOfElasticity * 1000000.0) + ModulusOfElasticity*1000000.0*.1); }
        }
        //calculated field from above ratio
        public double FlatShearModulus {
            get { return FlatShearModulusRatio*((ModulusOfElasticity * 1000000.0) + ModulusOfElasticity*1000000.0*.1); }
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

        //uses equation 12-2
        public double CalculateTangDimensionalChange(double length, double initialMoisture, double finalMoisture)
        {
            return length * (TangentialChangeCoefficient * (finalMoisture - initialMoisture));
        }
        
        //uses equation 12-2
        public double CalculateRadialDimensionalChange(double length, double initialMoisture, double finalMoisture)
        {
            return length * (RadialChangeCoefficient * (finalMoisture - initialMoisture));
        }

        //uses equation 3-6b
        public double GetDensityAtMoistureContent(double moistureContent)
        {
            var a = (30 - moistureContent) / 30;
            var specificGravityForMoistureContent = SpecificGravityAtGreen /
                                             (1 - (.256 * a * SpecificGravityAtGreen));

            return 62.4 * specificGravityForMoistureContent * (1 + moistureContent / 100);
        }

        #region Deflection Calculations => uses equation 8-2 : data from table 4-1

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

            //values from table 8-1 => clamped on both ends, concentrated at midpoint
            double kb = (1.0 / 192.0);
            double ks = .25;

            double firstBlock = (kb * load * span * span * span) / (ModulusOfElasticity * 1000000.0 * intertia);
            double secondBlock = (ks * load * span) / (shear * modifiedArea);

            return firstBlock + secondBlock;
        }
        #endregion
    }

    public enum NativeLocation
    {
        UnitedStates = 0,
        Africa = 1,
        TropicalAmerica = 2,
        AsiaOceania = 4
    }
}
