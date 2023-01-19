using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Core.Entities
{
    public class Car:Vehicle
    {
        public int Wheels { get; set; }
        public bool Headlights { get; set; } = false;
    }
}
