﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tranq.WebsiteTutorial.Models
{
    public class QuoteViewModel
    {
        public Guid Id { get; set; }
        public string PersonName { get; set; }
        public string QuoteContent { get; set; }
        public DateTime DateOfQuote { get; set; }
    }
}
