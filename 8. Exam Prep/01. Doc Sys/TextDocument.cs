using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class TextDocument : Document, IEditable
{
    //Fields
    private string charset;

    //Properties
    public string Charset
    {
        get
        {
            return this.charset;
        }
        protected set
        {
            this.charset = value;
        }
    }

    //Methods

    public override void LoadProperty(string key, string value)
    {
        if (key == "charset")
        {
            this.charset = value;
        }
        else
        {
            base.LoadProperty(key, value);
        }
    }

    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string, object>("charset", this.charset));
        base.SaveAllProperties(output);
    }

    public void ChangeContent(string newContent)
    {
        this.Content = newContent;
    }
}