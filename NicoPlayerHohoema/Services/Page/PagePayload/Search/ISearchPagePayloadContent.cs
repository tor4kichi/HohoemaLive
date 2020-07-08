using HohoemaLive.Models;

namespace HohoemaLive.Services.Page
{
    public interface ISearchPagePayloadContent
	{
		string Keyword { get; }

        SearchTarget SearchTarget { get; }

		string ToParameterString();
	}
}
