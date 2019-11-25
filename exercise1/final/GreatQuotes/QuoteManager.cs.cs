using GreatQuotes.ViewModels;
using GreatQuotes;
using System;
using System.Collections.Generic;
using System.Text;

public class QuoteManager
{
 
    public void SayQuote(GreatQuoteViewModel quote)
    {
        if (quote == null)
            throw new ArgumentNullException("No quote set");

        ITextToSpeech tts = ServiceLocator.Instance.Resolve<ITextToSpeech>();

        if (tts != null)
        {
            var text = quote.QuoteText;

            if (!string.IsNullOrWhiteSpace(quote.Author))
                text += $" by {quote.Author}";

            tts.Speak(text);
        }
    }
}