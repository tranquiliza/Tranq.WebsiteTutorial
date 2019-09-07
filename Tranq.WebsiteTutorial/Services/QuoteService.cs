using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tranq.WebsiteTutorial.Domain;

namespace Tranq.WebsiteTutorial.Services
{
    public class QuoteService : IQuoteService
    {
        private readonly List<Quote> _quotes = new List<Quote>();
        private readonly IDateTimeProvider _dateTimeProvider;

        public QuoteService(IDateTimeProvider dateTimeProvider)
        {
            _dateTimeProvider = dateTimeProvider;
            _quotes.Add(new Quote("Tranq", "We're making a website!", _dateTimeProvider.UtcNow));
        }

        public void CreateQuote(string personName, string quoteContent)
        {
            _quotes.Add(new Quote(personName, quoteContent, _dateTimeProvider.UtcNow));
        }

        public IEnumerable<Quote> GetQuotes()
        {
            return _quotes;
        }
    }
}
