using Engines.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engines.Domain.Entities
{
    public class ICE : Engine
    {
        public int Volume { get; set; }

        public int Power { get; set; }

        public int RPM { get; set; }
    }
}
