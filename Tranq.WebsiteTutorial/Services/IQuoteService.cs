﻿using System.Collections.Generic;
using Tranq.WebsiteTutorial.Domain;

namespace Tranq.WebsiteTutorial.Services
{
    public interface IQuoteService
    {
        IEnumerable<Quote> GetQuotes();
        void CreateQuote(string personName, string quoteContent);
    }
}