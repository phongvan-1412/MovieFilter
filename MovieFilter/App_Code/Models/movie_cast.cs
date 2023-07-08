using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

[DataContract]
public class movie_cast
{
    public movie_cast() { }
    [DataMember]
    public int movie_cast_id { get; set; }
    [DataMember]
    public int act_id { get; set; }
    [DataMember]
    public int mov_id { get; set; }
    [DataMember]
    public string role { get; set; }
}