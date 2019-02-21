//Source: https://www.grc.nasa.gov/www/k-12/airplane/termv.html

using System.Collections;


public class TerminalVelocity
{
    public TerminalVelocity(Hashtable args)
    {
        weight = args["weight"];
        altitude = args["altitude"];
        dragCoefficient = args["dragCoefficient"];
        csArea = args["csArea"];
        density = args["density"] || new Density(altitude).CalculateDensity();

    }
    public double calculateTV()
    {
        return Math.sqrt((2.0 * weight) / (dragCoefficient * density * csArea));
    }

}