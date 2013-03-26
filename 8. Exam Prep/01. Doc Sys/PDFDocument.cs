using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class PDFDocument : BinaryDocuments, IEncryptable
{
    //Fields
    private string numberOfPages;
    private bool isEncrypted;

    //Properties
    public string NumberOfPages
    {
        get
        {
            return this.numberOfPages;
        }
        protected set
        {
            this.numberOfPages = value;
        }
    }

    public bool IsEncrypted
    {
        get
        {
            return this.isEncrypted;
        }
        protected set
        {
            this.isEncrypted = value;
        }
    }

    //Methods
    public override void LoadProperty(string key, string value)
    {
        if (key == "pages")
        {
            this.numberOfPages = value;
        }
        base.LoadProperty(key, value);
    }

    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string, object>("pages", this.numberOfPages));
        base.SaveAllProperties(output);
    }

    public void Encrypt()
    {
        this.isEncrypted = true;
    }

    public void Decrypt()
    {
        this.isEncrypted = false;
    }
}