//Task 1: Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in 
//the Euclidian 3D space. Implement the ToString() to enable printing a 3D 
//point.

//Task 2: Add a private static read-only field to hold the start of the 
//coordinate system – the point O{0, 0, 0}. Add a static property to 
//return the point O.


struct Point3D
{
    //static field
    public static readonly Point3D point0 = new Point3D(0, 0, 0);

    //properties
    public int CoordinateX { get; set; }
    public int CoordinateY { get; set; }
    public int CoordinateZ { get; set; }
    public Point3D Point0
    {
        get
        {
            return point0;
        }
    }


    //constructors
    public Point3D(int x, int y, int z)
        : this()
    {
        this.CoordinateX = x;
        this.CoordinateY = y;
        this.CoordinateZ = z;
    }

    //methods
    public override string ToString()
    {
        return string.Format("X coordinate: {0}\nY coordinate: {1}\n Z coordinate: {2}", this.CoordinateX, this.CoordinateY, this.CoordinateZ);
    }
    static public Point3D Parse(string pointCoordinatesInString)
    {
        char separator = ' ';
        pointCoordinatesInString.Split(separator);
    }
}