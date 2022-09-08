namespace Galactica
{

    internal class Star : SpaceObject
    {
        public string Type { get; set; }
        public int Temperature { get; set; }

        public List<Planet> planetList = new List<Planet>();

        public new Position position { get; }
        public Star()

        {
            this.position = new Position(0, 0);

        }


    }

}
