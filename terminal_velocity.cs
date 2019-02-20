//Source: https://www.grc.nasa.gov/www/k-12/airplane/termv.html

using System.Collections;
using Density.cs;


public class TerminalVelocity
{
    public TerminalVelocity(Hashtable args)
    {
        weight = args["weight"];
        altitude = args["altitude"];
        drag_coefficient = args["drag_coefficient"];
        cs_area = args["cs_area"];
        density = args["density"] || new Density(altitude).calculate_density();

    }
    public double calculate_tv()
    {
        return Math.sqrt((2.0 * weight) / (drag_coefficient * density * cs_area));
    }

}