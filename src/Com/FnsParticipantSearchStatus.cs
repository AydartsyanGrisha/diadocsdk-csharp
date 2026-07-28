using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace Diadoc.Api.Com
{
	[ComVisible(true)]
	[Guid("18F8E100-0FF0-4CF0-9B6E-5735EB81B581")]
	[XmlType(TypeName = "FnsParticipantSearchStatus", Namespace = "https://diadoc-api.kontur.ru")]
	public enum FnsParticipantSearchStatus
	{
		UnknownFnsParticipantSearchStatus = Proto.FnsParticipants.FnsParticipantSearchStatus.UnknownFnsParticipantSearchStatus,
		OkFnsParticipantSearchStatus = Proto.FnsParticipants.FnsParticipantSearchStatus.OkFnsParticipantSearchStatus,
		NotAllowedFnsParticipantSearchStatus = Proto.FnsParticipants.FnsParticipantSearchStatus.NotAllowedFnsParticipantSearchStatus,
		NotFoundFnsParticipantSearchStatus = Proto.FnsParticipants.FnsParticipantSearchStatus.NotFoundFnsParticipantSearchStatus
	}
}
