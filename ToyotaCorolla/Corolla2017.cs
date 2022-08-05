using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyotaCorolla
{
    internal interface ICorollaProductionRules
    {
        public string carColor {get; set; } 
        public string carName {get; set; }
        public string carEngine { get; set; }
        public bool carTyre(string carName);  
    }
}
