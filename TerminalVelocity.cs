//Source: https://www.grc.nasa.gov/www/k-12/airplane/termv.html
using System;
using System.Collections;

namespace TerminalVelocityCalc
{
    public class TerminalVelocity
    {
        public double weight;
        public double altitude;
        public double dragCoefficient;
        public double csArea;
        public double density;
        public TerminalVelocity(Hashtable args)
        {
            weight = (double) args["weight"];
            altitude = (double) args["altitude"];
            dragCoefficient = (double) args["dragCoefficient"];
            csArea = (double) args["csArea"];
            density = (double) args["density"];

        }
        public double calculateTV()
        {
            return Math.Sqrt((2.0 * weight) / (dragCoefficient * density * csArea));
        }
    }
}