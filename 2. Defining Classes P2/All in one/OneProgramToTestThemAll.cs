using System;
using System.Linq;

class OneProgramToTestThemAll
{
    static void Main(string[] args)
    {
        Point3D point1 = new Point3D(1,2,3);
        int x = 2, y = 4, z = -1;
        Point3D point2 = new Point3D(x,y,z);
        Point3D point3 = new Point3D();
        Console.WriteLine(DistanceBetweenPoints.Distance(point1, Point3D.point0));
        Console.WriteLine(DistanceBetweenPoints.Distance(point1, point2));
        Console.WriteLine(DistanceBetweenPoints.Distance(point3, Point3D.point0));

        Path pointsPath = new Path();
        pointsPath.AddPoint(Point3D.point0);
        pointsPath.AddPoint(point1);
        pointsPath.AddPoint(point2);
        pointsPath.AddPoint(point3);

        PathStorage.Save(pointsPath/*add value if you want, else search in bin/Debug for save.txt*/);

        Path newPath = PathStorage.Load(/*add address if you want, else change Read Path.txt in bin/Debug*/);

        PathStorage.Save(newPath, "newSave.txt");

        newPath.PrintToConsole();
    }
}