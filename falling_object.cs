//Source: https://www.grc.nasa.gov/www/k-12/airplane/termv.html

using System;
using System.Collections;
public class FallingObject
{
    public FallingObject(HashTable args)
    {
        weight = args["weight"] || 150;
        cs_area = args["cs_area"] || 5;
        drag_coefficient = args["drag_coefficient"] || .7;
        altitude = args["altitude"] || 0;    
    }

    public void set_weight(double new_weight)
    {
        weight = new_weight;
    }

    public HashTable to_hash()
    {
        HashTable falling_object = new HashTable();
        falling_object.add("weight", weight);
        falling_object.add("cs_area", cs_area);
        falling_object.add("drag_coefficient", drag_coefficient);
        falling_object.add("altitude", altitude);
        return falling_object;
    }
    
}