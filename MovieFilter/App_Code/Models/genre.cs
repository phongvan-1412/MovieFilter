using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

[DataContract]
public class genre
{
    public genre() {}

    [DataMember]
    public int gen_id { get; set; }
    [DataMember]
    public string gen_title { get; set; }
}