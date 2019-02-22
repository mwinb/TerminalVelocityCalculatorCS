//Source: https://www.grc.nasa.gov/www/k-12/airplane/termv.html

using System;

namespace TerminalVelocityCalc
{
    public class Density
    {
        private double altitude;
        public Density(double newAltitude)
        {
            altitude = newAltitude;
        }

        public double CalculateDensity()
        {
            double gasConstant = 1716;
            double stratosphereStart = 36152;
            double stratosphereEnd = 82345;
            double temp;
            double pressure;

            if (altitude <= stratosphereStart)
            {
                temp = 518.6 - (0.00356 * altitude);
                pressure = 2116 * Math.Pow(temp / 518.6, 5.256);
            }
            else if (altitude <= stratosphereEnd)
            {
                temp = 389.98;
                pressure = 2116 * 0.2236 * Math.Exp((36000 - altitude) / (53.35 * 389.98));
            }
            else
            {
                temp = 389.98 + (1.645 * ((altitude - 82345) / 1000));
                pressure = 2116 * 0.02456 * Math.Pow(temp / 389.98, -11.388);
            }

            return pressure / (temp * gasConstant);

        }

    }
}