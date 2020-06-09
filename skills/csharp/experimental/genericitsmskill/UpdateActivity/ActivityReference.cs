﻿using Microsoft.Bot.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericITSMSkill.UpdateActivity
{
    public class ActivityReference
    {
        public string ThreadId { get; set; }

        public string ActivityId { get; set; }

        public object Data { get; set; }

        public ConversationReference ConversationReference { get; set; }

        public Dictionary<string, DateTimeOffset> PropertyUpdatedTimeMap { get; set; } = new Dictionary<string, DateTimeOffset>();
    }
}