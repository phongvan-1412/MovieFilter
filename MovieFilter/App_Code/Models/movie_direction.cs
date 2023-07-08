using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

[DataContract]
public class movie_direction
{
    public movie_direction() { }
    [DataMember]
    public int movie_director_id { get; set; }
    [DataMember]
    public int dir_id { get; set; }
    [DataMember]
    public int mov_id { get; set; }
}