﻿using System;

/// <sumery> Statement for Shape class </sumery>
class Shape
{
    /// <sumery>
    /// Throws an NotImplementedException with the message Area() is not implemented
    /// </sumery>
    public virtual int Area()
    {
        throw new NotImplementedException ("Area() is not implemented");
    }
}

/// <sumery> Statement for Rectangle class </sumery>
class Rectangle : Shape
{
    private int width;
    private int height;
    /// <sumery> Method that set the width </sumery>
    public int Width
    {
        get => width;
        set
        {
            if (value < 0)
                throw new ArgumentException ("Width must be greater than or equal to 0");
            else
                width = value;
        }
    }
    /// <sumery> Method that set the height </sumery>
    public int Height
    {
        get => height;
        set
        {
            if (value < 0)
                throw new ArgumentException ("Height must be greater than or equal to 0");
            else
                height = value;
        }
    }
}
