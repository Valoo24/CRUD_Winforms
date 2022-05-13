using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    internal class Adresse
    {
        public string Street { get; private set; }
        public string City { get; private set; }
        public string Country { get; private set; }
        public int StreetNumber { get; private set; }
        public int PostCode { get; private set; }
    }
}
