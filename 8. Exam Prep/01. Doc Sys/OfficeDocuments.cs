using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class OfficeDocuments : BinaryDocuments, IEncryptable
{
    private string version;
    private bool isEncrypted;

    public string Version
    {
        get
        {
            return this.version;
        }
        protected set
        {
            this.version = value;
        }
    }

    public bool IsEncrypted
    {
        get
        {
            return this.isEncrypted;
        }
    }

    public void Encrypt()
    {
        this.isEncrypted = true;
    }

    public void Decrypt()
    {
        this.isEncrypted = false;
    }

    public override void LoadProperty(string key, string value)
    {
        if (key == "version")
        {
            this.version = value;
        }
        else
        {
            base.LoadProperty(key, value);
        }
    }

    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string, object>("version", this.version));
        base.SaveAllProperties(output);
    }
}