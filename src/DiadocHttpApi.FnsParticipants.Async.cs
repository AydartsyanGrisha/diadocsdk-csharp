using System.Threading.Tasks;
using Diadoc.Api.Http;
using Diadoc.Api.Proto.FnsParticipants;

namespace Diadoc.Api
{
	public partial class DiadocHttpApi
	{
		public Task<SearchFnsParticipantsResponse> SearchFnsParticipantsAsync(string authToken, string myBoxId, SearchFnsParticipantsRequest request)
		{
			var qsb = new PathAndQueryBuilder("/SearchFnsParticipants");
			qsb.AddParameter("myBoxId", myBoxId);
			return PerformHttpRequestAsync<SearchFnsParticipantsRequest, SearchFnsParticipantsResponse>(authToken, qsb.BuildPathAndQuery(), request);
		}
	}
}
