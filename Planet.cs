using static Galactica.SpaceObject;

namespace Galactica
{
    public enum PlanetType { Terrestial, Giant, Dwarf, Gas_Giant }
    internal class Planet : SpaceObject
    {



        public double Diameter { get; set; }

        public double RotationPeriod { get; set; }

        public double RevolutionPeriod { get; set; }
        public object PlanetType { get; set; }
        public object Type { get; internal set; }

        public List<Moon> moonList = new List<Moon>();
        public void Distance(Position first, Position second)

        {

            double distance = Math.Sqrt(Math.Pow(second.X - first.X, 2) + Math.Pow(second.Y - first.Y, 2));


        }

    }
}
