using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

[DataContract]
public class rating
{
    [DataMember]
    public int rate_id { get; set; }
    [DataMember]
    public int mov_id { get; set; }
    [DataMember]
    public int rev_id { get; set; }
    [DataMember]
    public int rev_stars { get; set; }
    [DataMember]
    public int num_o_rating { get; set; }
    [DataMember]
    public int num_o_viewing { get; set; }
}