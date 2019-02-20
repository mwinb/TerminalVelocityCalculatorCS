//Defaults taken from https://www.grc.nasa.gov/www/k-12/airplane/termv.html

using System;
using System.Collections;
public class FallingObject
{


    public FallingObject(HashTable args)
    {
        this.weight = args["weight"] || 150;
        this.cs_area = args["cs_area"] || 5;
        this.drag_coefficient = args["drag_coefficient"] || .7;
        this.altitude = args["altitude"] || 0;
        
    }

    public void set_weight(double new_weight)
    {
        this.weight = new_weight;
    }

    public double get_weight()
    {
        return this.weight;
    }

    public void set_area(double new_area)
    {
        this.cs_area = new_area;
    }

    public double get_area()
    {
        return this.cs_area;
    }

    public void set_drag(double new_drag)
    {
        this.drag_coefficient = new_drag;
    }

    public double get_drag()
    {
        return this.drag_coefficient;
    }

    public void set_altitude(double new_altitude)
    {
        this.altitude = new_altitude;
    }

    public double get_altitude()
    {
        return this.altitude;
    }

    public HashTable to_hash()
    {
        HashTable falling_object = new HashTable();
        falling_object.add("weight", this.weight);
        falling_object.add("cs_area", this.cs_area);
        falling_object.add("drag_coefficient", this.drag_coefficient);
        falling_object.add("altitude", this.altitude);
        return falling_object;
    }
    
}