using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tranq.WebsiteTutorial.Domain;
using Tranq.WebsiteTutorial.Models;

namespace Tranq.WebsiteTutorial.Translators
{
    public static class QuoteTranslator
    {
        public static QuoteViewModel Translate(this Quote quote)
        {
            return new QuoteViewModel
            {
                Id = quote.Id,
                DateOfQuote = quote.DateOfQuote,
                PersonName = quote.PersonName,
                QuoteContent = quote.QuoteContent
            };
        }

        public static EditQuoteModel TranslateToEditModel(this Quote quote)
        {
            return new EditQuoteModel
            {
                QuoteContent = quote.QuoteContent
            };
        }
    }
}
