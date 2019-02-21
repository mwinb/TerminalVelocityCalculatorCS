//Source: https://www.grc.nasa.gov/www/k-12/airplane/termv.html

using System;
using System.Collections;

namespace TerminalVelocityCalc
{
    public class DropItem
    {
        private double weight;
        private double csArea;
        private double dragCoefficient;
        private double altitude;
        public DropItem(HashTable args)
        {
            weight = args["weight"] || 150;
            csArea = args["csArea"] || 5;
            dragCoefficient = args["dragCoefficient"] || .7;
            altitude = args["altitude"] || 0;
        }

        public DropItem()
        {
            weight = 150;
            cs_area = 5;
            dreag_coefficient = .7;
            altitude = 0;
        }
        public double weight { get; }
        public double csArea { get; }
        public double dragCoefficient { get; }
        public double altitude { get; }

        public HashTable ToHash()
        {
            HashTable dropHash = new HashTable();
            dropHash.add("weight", weight);
            dropHash.add("cs_area", csArea);
            dropHash.add("drag_coefficient", dragCoefficient);
            dropHash.add("altitude", altitude);
            return dropItem;
        }

    }
}