using System.Runtime.InteropServices;

namespace Diadoc.Api.Proto.FnsParticipants
{
	[ComVisible(true)]
	[Guid("B44F82DF-D8F7-4071-AC1F-672B9CD06A15")]
	public interface ISearchFnsParticipantsRequest
	{
		string Inn { get; set; }
		string Kpp { get; set; }
		string FnsParticipantId { get; set; }
	}

	[ComVisible(true)]
	[ProgId("Diadoc.Api.SearchFnsParticipantsRequest")]
	[Guid("5F5AF81D-4B51-42B5-A438-7F15DD810012")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComDefaultInterface(typeof(ISearchFnsParticipantsRequest))]
	public partial class SearchFnsParticipantsRequest : SafeComObject, ISearchFnsParticipantsRequest
	{
	}
}
