using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTROPY
{
    // A hex-tile in GameBoard
    class MapTile
    {
        Terrain terrain_type;
    }

    // A terrain has 5 layers: space, sky, surface, shallow, deep
    class Terrain
    {
        enum Layers{Deep, Shallow, Surface, Sky, Space};
    }
}
