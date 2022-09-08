namespace Galactica
{
    internal class SpaceObject
    {
        //properties of star
        public enum StarType { YellowDwarf, White, BlueNeutron, RedGiant }
        public Position? position { get; set; }
        public string? Name { get; set; }
        public int Id { get; set; }


        //position of X and Y
        public class Position : SpaceObject
        {
            public Position()
            {
            }

            public Position(int n1, int n2)
            {
                N1 = n1;
                N2 = n2;
            }

            public double X { get; set; }
            public double Y { get; set; }
            public int N1 { get; }
            public int N2 { get; }

            public override string ToString()
            {
                return $"({X}, {Y})";
            }
        }
    }
}
