﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vote.Common.ViewModels.Events
{
    public class EventViewModel
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public string Title { get; set; }

        public string CreatorId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool IsClosed { get; set; }
    }
}
