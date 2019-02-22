//Source: https://www.grc.nasa.gov/www/k-12/airplane/termv.html



namespace TerminalVelocityCalc
{
    using System;
    using System.Collections.Generic;
    public class DropItem
    {
        private double weight;
        private double csArea;
        private double dragCoefficient;
        private double altitude;
        private double density;
        public DropItem(Dictionary<String, Double> args)
        {
            weight = args["weight"];
            csArea = args["csArea"];
            dragCoefficient = args["dragCoefficient"];
            altitude = args["altitude"];
            density = GetDensity();

        }

        public DropItem()
        {
            weight = 150;
            csArea = 5;
            dragCoefficient = .7;
            altitude = 0;
            density = GetDensity();
        }

        public Dictionary<String, Double> ToDictionary()
        {
            Dictionary<String, Double> dropHash = new Dictionary<String, Double>();
            dropHash.Add("weight", weight);
            dropHash.Add("csArea", csArea);
            dropHash.Add("dragCoefficient", dragCoefficient);
            dropHash.Add("altitude", altitude);
            dropHash.Add("density", density);
            return dropHash;
        }

        private double GetDensity()
        {
            Density dens = new Density(altitude);
            return dens.CalculateDensity();   
        }

    }
}