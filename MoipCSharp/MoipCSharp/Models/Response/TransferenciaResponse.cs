﻿using System;
using System.Collections.Generic;
#pragma warning disable IDE1006

namespace MoipCSharp.Models
{
    public class TransferenciaResponse
    {
        public DateTime updatedAt { get; set; }
        public int fee { get; set; }
        public int amount { get; set; }
        public string id { get; set; }
        public Transferinstrument transferInstrument { get; set; }
        public string status { get; set; }
        public DateTime createdAt { get; set; }
        public List<Event> events { get; set; }
        public List<Entry> entries { get; set; }
        public _Links _links { get; set; }
    }
}