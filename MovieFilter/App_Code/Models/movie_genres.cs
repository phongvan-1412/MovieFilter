using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

[DataContract]
public class movie_genres
{
    [DataMember]
    public int movie_genres_id { get; set; }
    [DataMember]
    public int mov_id { get; set; }
    [DataMember]
    public int gen_id { get; set; }
}