using HohoemaLive.Models;

namespace HohoemaLive.Services.Page
{
    public class TagSearchPagePayloadContent : VideoSearchOption
	{
		public override SearchTarget SearchTarget => SearchTarget.Tag;
	}
}
