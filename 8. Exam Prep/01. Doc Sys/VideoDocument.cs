﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class VideoDocument : MultimediaDocuments
{
    private string frameRate;

    public string FrameRate
    {
        get
        {
            return this.frameRate;
        }
        protected set
        {
            this.frameRate = value;
        }
    }

    public override void LoadProperty(string key, string value)
    {
        if (key == "framerate")
        {
            this.FrameRate = value;
        }
        else
        {
            base.LoadProperty(key, value);
        }
    }

    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string, object>("framerate", this.frameRate));
        base.SaveAllProperties(output);
    }
    
}