using System;
using System.Collections.Generic;
using System.Text;
using GreatQuotes.ViewModels;

public interface IQuoteLoader
{
    IEnumerable<GreatQuoteViewModel> Load();
    void Save(IEnumerable<GreatQuoteViewModel> quotes);
}