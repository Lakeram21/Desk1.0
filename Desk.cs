using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mega
{
    public enum DesktopMatierial
    { 
            laminate,
            Oak,
            Pine,
            Rosewood,
            Veneer,
    }

    public class Desk
    {
        // Create static varibales for the max and min values
        public const short MAX_WIDTH = 96;
        public const short MIN_WIDTH = 24;
        public const short MAX_DEPTH = 48;
        public const short MIN_DEPTH = 12;
        public int Width { get; set; }
        public int Depth { get; set; }
        public int NumberOfDrawers { get; set; }
        public DesktopMatierial SurfaceMaterial { get; set; }
    }
}
