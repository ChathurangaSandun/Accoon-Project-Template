using System;
using System.Collections.Generic;
using System.Text;

namespace Accoon.Application.Entities.Automapper
{
    public sealed class Map
    {
        public Type Source { get; set; }
        public Type Destination { get; set; }
    }
}
