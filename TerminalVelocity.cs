//Source: https://www.grc.nasa.gov/www/k-12/airplane/termv.html
using System;
using System.Collections.Generic;

namespace TerminalVelocityCalc
{
    public class TerminalVelocity
    {
        public double weight;
        public double altitude;
        public double dragCoefficient;
        public double csArea;
        public double density;
        public TerminalVelocity(Dictionary<String, Double> args)
        {
            weight = args["weight"];
            altitude = args["altitude"];
            dragCoefficient = args["dragCoefficient"];
            csArea = args["csArea"];
            density = args["density"];

        }
        public double calculateTV()
        {
            return Math.Sqrt((2.0 * weight) / (dragCoefficient * density * csArea));
        }
    }
}