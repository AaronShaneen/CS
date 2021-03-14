using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_Part_1.Business_Objects
{
    public class Flight
    {
        /// <summary>
        /// Integer representing the flight id
        /// </summary>
        public int FlightID { get; set; }

        /// <summary>
        /// Integer representing the flight number
        /// </summary>
        public int FlightNumber { get; set; }

        /// <summary>
        /// Integer representing the aircraft type
        /// </summary>
        public string AircraftType { get; set; }

        /// <summary>
        /// Overrides the ToString() method to display the flight in the combo box
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            try
            {
                return this.FlightNumber.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }
    }
}
