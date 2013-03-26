using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class WordDocument : OfficeDocuments, IEditable
{
    private string numberOfCharacters;

    public string NumberOfCharacters
    {
        get
        {
            return this.numberOfCharacters;
        }
        protected set
        {
            this.numberOfCharacters = value;
        }
    }

    public void ChangeContent(string newContent)
    {
        this.Content = newContent;
    }

    public override void LoadProperty(string key, string value)
    {
        if (key == "chars")
        {
            this.numberOfCharacters = value;
        }
        else
        {
            base.LoadProperty(key, value);
        }
    }

    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string, object>("chars", this.numberOfCharacters));
        base.SaveAllProperties(output);
    }
}