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

        public void EditQuote(Guid id, string quoteContent)
        {
            var quoteToEdit = _quotes.First(quote => quote.Id == id);
            quoteToEdit.UpdateQuoteContent(quoteContent);
        }

        public Quote GetQuote(Guid id)
        {
            return _quotes.First(quote => quote.Id == id);
        }

        public IEnumerable<Quote> GetQuotes()
        {
            return _quotes;
        }
    }
}
