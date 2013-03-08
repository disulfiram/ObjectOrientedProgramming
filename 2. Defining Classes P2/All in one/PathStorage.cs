using System;
using System.IO;
using System.Linq;

static class PathStorage
{
    public static Path Load(string pathOfLoadFile="Read Path.txt")
    {
        Path loadedPath = new Path();
        using (StreamReader textFile = new StreamReader(pathOfLoadFile))
        {
            string line = textFile.ReadLine();
            Point3D currentPoint;
            while (line != null)
            {
                currentPoint = Point3D.Parse(line);
                loadedPath.AddPoint(currentPoint);
                line = textFile.ReadLine();
            }
        }
        return loadedPath;
    }

    public static void Save(Path pointPathToSave, string pathOfSaveFile="save.txt")
    {
        using (StreamWriter saveFile = new StreamWriter(pathOfSaveFile))
        {
            for (int pontNumber = 0; pontNumber < pointPathToSave.List.Count; pontNumber++)
            {
                saveFile.WriteLine("Point {0}: {1}", pontNumber, pointPathToSave.List[pontNumber].ToString());
            }
        }
    }
}