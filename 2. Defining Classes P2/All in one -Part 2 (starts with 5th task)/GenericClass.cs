//Write a generic class GenericList<T> that keeps a list of elements of 
//some parametric type T. Keep the elements of the list in an array with 
//fixed capacity which is given as parameter in the class constructor. 
//Implement methods for adding element, accessing element by index, 
//removing element by index, inserting element at given position, clearing 
//the list, finding element by its value and ToString(). Check all input 
//parameters to avoid accessing elements at invalid positions.

using System;
using System.Linq;
using System.Text;


class GenericList<T>
{
    private const int defaultCapacity = 4;
    //fields
    private T[] list = new T[defaultCapacity];
    private int count = 0;
    private int capacity;

    //properties
    public int Capacity
    {
        get
        {
            return this.list.Length;
        }
        private set
        {
            this.capacity = value;
        }
    }
    public int Count
    {
        get
        {
            return this.count;
        }
        private set
        {
            this.count = value;
        }
    }
    
    //constructors
    public GenericList(int size)
    {
        this.capacity = size;
        this.list = new T[size];
    }
   
    //methods
    public void Add(T element)
    {
        if (count+1 >= list.Length)
        {
            this.Expand(count+1);
        }
        this.list[count] = element;
        this.Count++;
    }

    public void Remove(int indexOfRemoved)      //not going to work in all cases. Heck, not sure if it's going to work in most cases! :D
    {
        if (indexOfRemoved < 0 || indexOfRemoved> this.Count)
        {
            throw new IndexOutOfRangeException("The specified index does not exist in the list.");
        }
        this.Count--;
        for (int index = indexOfRemoved; index < this.Count; index++)
        {
            this.list[index] = this.list[index + 1];
        }
    }

    public T this[int index]        //out of the presentation
    {
        get
        {
            if (index >= count)
            {
                throw new IndexOutOfRangeException(String.Format("Invalid index: {0}.", index));
            }
            T result = list[index];
            return result;
        }
    }

    public int FindElementByValue(T value)
    {
        for (int index = 0; index < this.Count; index++)
        {
            if (this.list[index].Equals(value))
            {
                return index;
            }
        }
        return -1;
    }

    public void InsertAt(int indexOfInserted, T value)
    {
        if (indexOfInserted < 0 || indexOfInserted > this.Count)
        {
            throw new IndexOutOfRangeException("Index is out of the range!");
        }
        this.Count++;
        for (int index = indexOfInserted; index < this.Count - 1; index++)
        {
            this.list[index + 1] = this.list[index];

        }
        this.list[indexOfInserted] = value;
    }

    public void Clear()
    {
        Array.Clear(this.list, 0, Count);
    }

    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        for (int i = 0; i < this.Count; i++)
        {
            builder.Append(this.list[i].ToString() + " ");
        }

        return builder.ToString();
    }


    //Implement auto-grow functionality: when the internal array is full, 
    //create a new array of double size and move all elements to it.

    private void Expand(int neededCapacity)     //because it is called only from within the class
    {
        if (neededCapacity > this.Capacity)
        {
            this.Capacity = neededCapacity * 2;
            Array.Resize(ref list, this.Capacity);
        }
    }

    //Create generic methods Min<T>() and Max<T>() for finding the 
    //minimal and maximal element in the  GenericList<T>. You may need to 
    //add a generic constraints for the type T.

}