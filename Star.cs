namespace Galactica
{

    internal class Star : SpaceObject
    {   //properties and list
        public int Temperature { get; set; }
        public string Type { get; set; }
        

        internal List<Planet> planetList = new();

        public new Position position { get; set; }
        public Star()

        {
            position = new Position(0, 0);

        }


    }

}
