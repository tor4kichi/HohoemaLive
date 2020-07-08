using HohoemaLive.Models;

namespace HohoemaLive.Services.Page
{
    public class KeywordSearchPagePayloadContent : VideoSearchOption
	{
		public override SearchTarget SearchTarget => SearchTarget.Keyword;
	}
}
