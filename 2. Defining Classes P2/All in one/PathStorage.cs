using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

static class PathStorage
{
    public static Path Load(string pathOfLoadFile)
    {
        Path loadedPath = new Path();
        using (StreamReader TextFile = new StreamReader(pathOfLoadFile))
        {
            string line = TextFile.ReadLine();
            Point3D currentPoint;
            while (line != null)
            {
                currentPoint = Point3D.Parse(line);
                loadedPath.AddPoint(currentPoint);
            }
        }
        return loadedPath;
    }

    public static void Save(string pathOfSaveFile)
    {
 
    }
}