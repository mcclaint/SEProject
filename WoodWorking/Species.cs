using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public NativeLocation NativeLocation { get; set; }

        public bool Equals(Species other)
        {
            return (
                this.Name == other.Name &&
                this.HeartwoodMoisture == other.HeartwoodMoisture &&
                this.SapwoodMoisture == other.SapwoodMoisture &&
                this.RadialShrinkage == other.RadialShrinkage &&
                this.TangentialShrinkage == other.TangentialShrinkage &&
                this.VolumetricShrinkage == other.VolumetricShrinkage &&
                this.NativeLocation == other.NativeLocation
            );
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
