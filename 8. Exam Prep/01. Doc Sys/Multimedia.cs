using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class MultimediaDocuments : BinaryDocuments
{
    private string length;

    public string Length
    {
        get
        {
            return this.length;
        }
        protected set
        {
            this.length = value;
        }
    }

    public override void LoadProperty(string key, string value)
    {
        if (key == "length")
        {
            this.length = value;
        }
        else
        {
            base.LoadProperty(key, value);
        }
    }

    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string, object>("length", this.length));
        base.SaveAllProperties(output);
    }
}