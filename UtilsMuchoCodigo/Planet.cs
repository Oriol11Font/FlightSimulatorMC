using System.Collections.Generic;

namespace UtilsMuchoCodigo
{
    public class Coordinates
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }

    public class Planet
    {
        public string Name { get; set; }
        public string Sector { get; set; }
        public string Filiation { get; set; }
        public Coordinates Situation { get; set; }
        public IEnumerable<string> HyperspaceRoutes { get; set; }
        public string Natives { get; set; }
    }
}