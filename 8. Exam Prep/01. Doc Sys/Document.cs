using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Document : IDocument
{
    //Fields
    private string name;
    private string content;

    //Properties
    public string Name
    {
        get
        {
            return this.name;
        }
        protected set
        {
            this.name = value;
        }
    }

    public string Content
    {
        get
        {
            return this.content;
        }
        protected set
        {
            this.content = value;
        }
    }

    //Constructors
    
    //Methods
    public virtual void LoadProperty(string key, string value)
    {
        if (key == "name")
        {
            this.name = value;
        }
        if (key == "content")
        {
            this.content = value;
        }
    }

    public virtual void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string, object>("name", this.Name));
        output.Add(new KeyValuePair<string, object>("content", this.Content));
    }

    public override string ToString()
    {
        StringBuilder toString = new StringBuilder();
        toString.Append(this.GetType().Name);
        toString.Append("[");
        IList<KeyValuePair<string, object>> attributes = new List<KeyValuePair<string, object>>();
        SaveAllProperties(attributes);
        var sortedAttributes = attributes.OrderBy(item => item.Key);
        foreach (var attribute in sortedAttributes)
        {
            if (attribute.Value != null)
            {
                toString.Append(attribute.Key);
                toString.Append("=");
                toString.Append(attribute.Value);
                toString.Append(";");
            }
        }
        toString.Length--;
        toString.Append("]");

        return toString.ToString();
    }
}