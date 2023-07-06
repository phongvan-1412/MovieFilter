using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

[DataContract]
public class director
{
    public director() {}

    [DataMember]
    public int dir_id { get; set; }
    [DataMember]
    public string dir_fname { get; set; }
    [DataMember]
    public string dir_lname { get; set; }
    [DataMember]
    public string dir_fullname { get; set; }
}