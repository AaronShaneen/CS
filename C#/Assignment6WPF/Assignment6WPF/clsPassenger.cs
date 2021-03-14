using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6WPF
{
    class clsPassenger
    {
        public string sID;
        public string sFirstName;
        public string sLastName;
        public string sSeat;
        public string sFlight;

        public override string ToString()
        {
            return sFirstName + " " + sLastName;
        }
    }
}
