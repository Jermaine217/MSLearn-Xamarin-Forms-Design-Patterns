using System;
using System.Collections.Generic;
using System.Text;

namespace GreatQuotes
{
    class QuoteLoaderFactory
    {
        public static Func<IQuoteLoader> Create { get; set; }
    }
}
