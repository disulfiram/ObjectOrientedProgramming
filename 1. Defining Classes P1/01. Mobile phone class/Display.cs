﻿using System;
using System.Linq;

class Display
{
    //fields
    private string resolution;
    private int? colors;

    //constructors
    public Display() : this (null, null)
    { 
    }

    public Display(string resolution) : this (resolution, null)
    {
        this.resolution = resolution;
    }

    public Display(string resolution, int? colors)
    {
        this.resolution = resolution;
        this.colors = colors;
    }
}