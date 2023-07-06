using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

[DataContract]
public class actor
{
    public actor() {}

    [DataMember]
    public int act_id { get; set; }
    [DataMember]
    public string act_fname { get; set; }
    [DataMember]
    public string act_lname { get; set; }
    [DataMember]
    public string act_fullname { get; set; }
    [DataMember]
    public int act_gender { get; set; }
}