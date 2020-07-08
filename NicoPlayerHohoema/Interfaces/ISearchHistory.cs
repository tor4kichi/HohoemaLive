using HohoemaLive.Models;

namespace HohoemaLive.Interfaces
{
    public interface ISearchHistory
    {
        string Keyword { get; }
        SearchTarget Target { get; }
    }
}