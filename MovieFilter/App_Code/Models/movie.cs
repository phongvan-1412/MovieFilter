﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

[DataContract]
public class movie
{
    public movie() {}

    [DataMember]
    public int mov_id { get; set; }
    [DataMember]
    public string mov_title { get; set; }
    [DataMember]
    public string mov_year { get; set; }
    [DataMember]
    public string mov_time { get; set; }
    [DataMember]
    public string mov_lang { get; set; }
    [DataMember]
    public string mov_dt_rel { get; set; }
    [DataMember]
    public string mov_rel_country { get; set; }
}