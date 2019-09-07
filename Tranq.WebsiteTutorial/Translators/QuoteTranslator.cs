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
                DateOfQuote = quote.DateOfQuote,
                PersonName = quote.PersonName,
                QuoteContent = quote.QuoteContent
            };
        }
    }
}
