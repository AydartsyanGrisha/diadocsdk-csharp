using Diadoc.Api.Http;
using Diadoc.Api.Proto.FnsParticipants;

namespace Diadoc.Api
{
	public partial class DiadocHttpApi
	{
		public SearchFnsParticipantsResponse SearchFnsParticipants(string authToken, string myBoxId, SearchFnsParticipantsRequest request)
		{
			var qsb = new PathAndQueryBuilder("/SearchFnsParticipants");
			qsb.AddParameter("myBoxId", myBoxId);
			return PerformHttpRequest<SearchFnsParticipantsRequest, SearchFnsParticipantsResponse>(authToken, qsb.BuildPathAndQuery(), request);
		}
	}
}
