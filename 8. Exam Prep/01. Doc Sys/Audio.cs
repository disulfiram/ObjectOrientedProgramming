using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class AudioDocument : MultimediaDocuments
{
    private string samplerate;

    public string SampleRate
    {
        get
        {
            return this.samplerate;
        }
        set
        {
            this.samplerate = value;
        }
    }

    public override void LoadProperty(string key, string value)
    {
        if (key == "samplerate")
        {
            this.samplerate = value;
        }
        else
        {
            base.LoadProperty(key, value);
        }
    }

    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string, object>("samplerate", this.samplerate));
        base.SaveAllProperties(output);
    }
}