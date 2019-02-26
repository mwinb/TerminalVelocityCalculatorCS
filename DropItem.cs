//Source: https://www.grc.nasa.gov/www/k-12/airplane/termv.html

using System;
using System.Collections;


namespace TerminalVelocityCalc
{
    public class DropItem
    {
        private double csArea;

        private double dragCoefficient;
        private double altitude;
        private double density;

        private double weight;
        public DropItem(Hashtable args)
        {
            weight = (double) args["weight"];
            csArea = (double) args["csArea"];
            dragCoefficient = (double) args["dragCoefficient"];
            altitude = (double) args["altitude"];
            GetDensity();

        }

        public DropItem()
        {
            GetWeight();
            GetArea();
            GetDragCoeficient();
            GetAltitude();
            GetDensity();

        }

        public void printTable()
        {
            Hashtable hash = ToHash();
        
            foreach(string key in hash.Keys)
            {
                Console.WriteLine(String.Format("{0}: {1}", key, hash[key]));
            }


        }

        public Hashtable ToHash()
        {
            Hashtable dropHash = new Hashtable();
            dropHash.Add("weight", weight);
            dropHash.Add("csArea", csArea);
            dropHash.Add("dragCoefficient", dragCoefficient);
            dropHash.Add("altitude", altitude);
            dropHash.Add("density", density);
            return dropHash;
        }

        private void GetDensity()
        {
            Density dens = new Density(altitude);
            density = dens.CalculateDensity();   
        }

        private void GetWeight()
        {
            try
            {
                Console.Write("Enter weight in lbs: ");
                weight = Double.Parse(Console.ReadLine());

            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Input must be a valid weight.");
                GetWeight();
            }

        }

        private void GetArea()
        {
            try
            {
                Console.Write("Enter Cross Sectional Area in sq feet: ");
                csArea = Double.Parse(Console.ReadLine());
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Input must be a valid area.");
                GetArea();
            }

        }
        private void GetDragCoeficient()
        {
            try
            {
                Console.Write("Enter Drag Coefficient: ");
                dragCoefficient = Double.Parse(Console.ReadLine());
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Input must be a valid number.");
                GetDragCoeficient();
            }
        }
        private void GetAltitude()
        {
            try
            {
                Console.Write("Enter Altitude in ft: ");
                altitude = Double.Parse(Console.ReadLine());

            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Input must be a valid number.");
                GetAltitude();
            }

        }

    }
}