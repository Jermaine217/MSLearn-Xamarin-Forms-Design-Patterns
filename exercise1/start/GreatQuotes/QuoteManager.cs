using System;
using System.Collections.Generic;
using System.Text;
using GreatQuotes.ViewModels;
using System.Collections.ObjectModel;
using GreatQuotes;

public class QuoteManager
{
    static readonly Lazy<QuoteManager> instance = new Lazy<QuoteManager>(() => new QuoteManager());

    private IQuoteLoader loader;

    public static QuoteManager Instance { get => instance.Value; }

    public IList<GreatQuoteViewModel> Quotes { get; set; }

    private QuoteManager()
    {
        loader = QuoteLoaderFactory.Create();
        Quotes = new ObservableCollection<GreatQuoteViewModel>(loader.Load());
    }

    public void Save()
    {
        loader.Save(Quotes);
    }
}