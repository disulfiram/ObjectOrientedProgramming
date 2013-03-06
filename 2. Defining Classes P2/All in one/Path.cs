//Create a class Path to hold a sequence of points in the 3D space. 
//Create a static class PathStorage with static methods to save and load 
//paths from a text file. Use a file format of your choice.

using System;
using System.Collections.Generic;
using System.Linq;

class Path
{
    //fields
    private readonly List<Point3D> pathPoints;
    //properties
    //constructors
    public Path() : this( new List<Point3D>())
    {
    }
    public Path(List<Point3D> pathPoints) : this()
    {
        this.pathPoints = pathPoints;
    }

    //methods
    public Path AddPoint(Point3D point)
    {
        this.pathPoints.Add(point);     
        return new Path(this.pathPoints);       //pretty sure this is far from optimal
    }
    public Path RemovePoint(Point3D point)
    {
        this.pathPoints.Remove(point);
        return new Path(this.pathPoints);  
    }
    public Path ClearPath()
    {
        pathPoints.Clear();
        return new Path(this.pathPoints);
    }
}