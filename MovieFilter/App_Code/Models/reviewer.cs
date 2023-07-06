using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

[DataContract]
public class reviewer
{
    public reviewer() { }

    [DataMember]
    public int rev_id { get; set; }
    [DataMember]
    public string rev_name { get; set; }
    [DataMember]
    public string history { get; set; }
    [DataMember]
    public string rev_email { get; set; }
    [DataMember]
    public string rev_password { get; set; }
}