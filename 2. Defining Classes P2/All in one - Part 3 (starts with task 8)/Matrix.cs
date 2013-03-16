//No time to implement!
//Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, 
//floats, decimals). 

using System;
using System.Linq;

class Matrix<T>
{
    //fields
    private T[,] matrix = null;


    //properties
    public int Rows
    {
        get 
        {
            return this.Rows;
        }
        private set     //only the constructor should have access
        {
            this.Rows = value;
        }
    }
    public int Colomns
    {
        get
        {
            return this.Colomns;
        }
        private set     //only the constructor should have access
        {
            this.Colomns = value;
        }
    }
    //contructors
    public Matrix(int rows, int cols)
    {
        this.Rows = rows;
        this.Colomns = cols;
    }

    //Implement an indexer this[row, col] to access the inner matrix cells.

    public T this[int row, int col]
    {
        get 
        {
            return matrix[row, col];
        }
        set
        {
            matrix[row, col] = value;
        }
    }
    //methods
    //Implement the operators + and - (addition and subtraction of
    //matrices of the same size) and * for matrix multiplication. Throw an 
    //exception when the operation cannot be performed. Implement the true 
    //operator (check for non-zero elements).

    //incomplete multiplication! Too complex and not enough time.

    public static Matrix<T> operator +(Matrix<T> matrix1, Matrix<T> matrix2)
    {
        if (matrix1.Colomns != matrix2.Colomns || matrix1.Rows != matrix2.Rows)
        {
            throw new ArgumentException("The two matrices need to be of the same size!");
        }
        Matrix<T> addedMatrix = new Matrix<T>(matrix1.Colomns, matrix1.Rows);
        for (int row = 0; row < addedMatrix.Rows; row++)
        {
            for (int cols = 0; cols < addedMatrix.Colomns; cols++)
            {
                addedMatrix[row, cols] = (dynamic)matrix1[row, cols] + (dynamic)matrix2[row, cols];
            }
        }
        return addedMatrix;
    }

    public static Matrix<T> operator -(Matrix<T> matrix1, Matrix<T> matrix2)
    {
        if (matrix1.Colomns != matrix2.Colomns || matrix1.Rows != matrix2.Rows)
        {
            throw new ArgumentException("The two matrices need to be of the same size!");
        }
        Matrix<T> subtractedMatrix = new Matrix<T>(matrix1.Colomns, matrix1.Rows);
        for (int row = 0; row < subtractedMatrix.Rows; row++)
        {
            for (int cols = 0; cols < subtractedMatrix.Colomns; cols++)
            {
                subtractedMatrix[row, cols] = (dynamic)matrix1[row, cols] - (dynamic)matrix2[row, cols];
            }
        }
        return subtractedMatrix;
    }

    public static Matrix<T> operator -(Matrix<T> matrix1, Matrix<T> matrix2)
    {
        if (matrix1.Rows != matrix2.Colomns)
        {
            throw new ArgumentException("First matrix has to have amount of rows equal to amount of colomns in second matrix!");
        }
        Matrix<T> multipliedMatrix = new Matrix<T>(matrix1.Colomns, matrix1.Rows);
        for (int row = 0; row < multipliedMatrix.Rows; row++)
        {
            for (int cols = 0; cols < multipliedMatrix.Colomns; cols++)
            {
                multipliedMatrix[row, cols] = (dynamic)matrix1[row, cols] * (dynamic)matrix2[row, cols];
            }
        }
    }
}