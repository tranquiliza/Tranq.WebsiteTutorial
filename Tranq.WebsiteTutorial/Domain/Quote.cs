using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tranq.WebsiteTutorial.Domain
{
    public class Quote
    {
        public Guid Id { get; private set; }
        public string PersonName { get; private set; }
        public string QuoteContent { get; private set; }
        public DateTime DateOfQuote { get; private set; }

        [Obsolete("Only for serilization", true)]
        public Quote() { }

        public Quote(string personName, string quoteContent, DateTime dateOfQuote)
        {
            Id = Guid.NewGuid();
            PersonName = personName;
            QuoteContent = quoteContent;
            DateOfQuote = dateOfQuote;
        }

        internal void UpdateQuoteContent(string quoteContent)
        {
            if (string.IsNullOrWhiteSpace(quoteContent)) throw new ArgumentException("Quote cannot be empty!", nameof(quoteContent));

            QuoteContent = quoteContent;
        }
    }
}
