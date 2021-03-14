using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6WPF
{
    class clsFlights
    {
        public string sID;
        public string sFlightNumber;
        public string sAircraftType;

        public override string ToString() 
        {
            return sFlightNumber + " " + sAircraftType;
        }
    }

}
