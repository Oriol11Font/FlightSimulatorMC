using System.Collections.Generic;

namespace UtilsMuchoCodigo
{
    public class Route
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public string? ImageName { get; set; }
    }

    public class DefinedRoute
    {
        public string Origin { get; set; }
        public string Destination { get; set; }
        public IEnumerable<string> Routes { get; set; }
        public string? Map { get; set; }
    }
}