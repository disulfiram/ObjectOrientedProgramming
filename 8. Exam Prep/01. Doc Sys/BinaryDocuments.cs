using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class BinaryDocuments : Document
{
    //Fields
    private string size;

    //propertes
    public string Size
    {
        get
        {
            return this.size;
        }
        protected set
        {
            this.size = value;
        }
    }

    //Methods
    public override void LoadProperty(string key, string value)
    {
        if (key == "size")
        {
            this.size = value;
        }
        base.LoadProperty(key, value);
    }

    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string, object>("size", this.size));
        base.SaveAllProperties(output);
    }
}