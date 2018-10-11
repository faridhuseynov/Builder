using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//builders for different bodies created inheriting the base class Builder
namespace Builder_DP
{
    public abstract class Builder
    {
        public  Car Car { get; protected set; }
        public Builder()
        {
            Car = new Car();
        }
        public abstract void SetBody();
        public abstract void SetEngine();
        public abstract void SetTires();
        public abstract void SetEfficiency();
    }
    public class SedanBuilder : Builder
    {
        Sedan Sedan = new Sedan();
        public override void SetBody()
        {
            Car.Body = Sedan.Body;
        }

        public override void SetEfficiency()
        {
            Car.Efficiency = Sedan.Efficiency;
        }

        public override void SetEngine()
        {
            Car.Engine = Sedan.Engine;
        }

        public override void SetTires()
        {
            Car.Tires = Sedan.Tires;
        }
    }   
    public class CoupeBuilder:Builder
    {
        Coupe Coupe = new Coupe();

        public override void SetBody()
        {
            Car.Body = Coupe.Body;
        }

        public override void SetEfficiency()
        {
            Car.Efficiency = Coupe.Efficiency;
        }

        public override void SetEngine()
        {
            Car.Engine = Coupe.Engine;
        }

        public override void SetTires()
        {
            Car.Tires = Coupe.Tires;
        }
    }
    public class UniversalBuilder : Builder
    {
        Universal universal = new Universal();
        public override void SetBody()
        {
            Car.Body = universal.Body;
        }

        public override void SetEfficiency()
        {
            Car.Efficiency = universal.Efficiency;
        }

        public override void SetEngine()
        {
            Car.Engine = universal.Engine;
        }

        public override void SetTires()
        {
            Car.Tires = universal.Tires;
        }
    }
}
