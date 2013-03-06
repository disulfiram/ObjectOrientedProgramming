//Task 3: Write a static class with a static method to calculate the 
//distance between two points in the 3D space.

using System;

static class DistanceBetweenPoints
{
    public static double Distance(Point3D firstPoint, Point3D secondPoint)
    {
        double xDistance = Math.Abs(firstPoint.CoordinateX - secondPoint.CoordinateX);
        double yDistance = Math.Abs(firstPoint.CoordinateY - secondPoint.CoordinateY);
        double zDistance = Math.Abs(firstPoint.CoordinateZ - secondPoint.CoordinateZ);
        double distance = Math.Sqrt(xDistance*xDistance + yDistance*yDistance + zDistance*zDistance);
        return distance;
    }
}