using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ExcelDocument : OfficeDocuments
{
    private string numberOfRows;
    private string numberOfColumns;

    public string NumberOfRows
    {
        get
        {
            return this.numberOfRows;
        }
        protected set
        {
            this.numberOfRows = value;
        }
    }

    public string NumberOfColumns
    {
        get
        {
            return this.numberOfColumns;
        }
        protected set
        {
            this.numberOfColumns = value;
        }
    }

    public override void LoadProperty(string key, string value)
    {
        if (key == "rows")
        {
            this.numberOfRows = value;
        }
        else if (key == "cols")
        {
            this.numberOfColumns = value;
        }
        else
        {
            base.LoadProperty(key, value);
        }
    }
}