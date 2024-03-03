using Engines.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engines.Domain.Entities
{
    public class Jet : Engine
    {
        public int Traction { get; set; }

        public int Overclocking { get; set; }

        public int Operational_duration {  get; set; }
    }
}
