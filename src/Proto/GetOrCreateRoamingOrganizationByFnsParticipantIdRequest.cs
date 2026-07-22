using System.Runtime.InteropServices;

namespace Diadoc.Api.Proto
{
	[ComVisible(true)]
	[Guid("56BD01E2-CC0D-48A1-B618-C8B044F11010")]
	public interface IGetOrCreateRoamingOrganizationByFnsParticipantIdRequest
	{
		string FnsParticipantId { get; set; }
	}

	[ComVisible(true)]
	[ProgId("Diadoc.Api.GetOrCreateRoamingOrganizationByFnsParticipantIdRequest")]
	[Guid("6483B99C-DF83-47A2-9EE2-5BD0DED840C3")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComDefaultInterface(typeof(IGetOrCreateRoamingOrganizationByFnsParticipantIdRequest))]
	public partial class GetOrCreateRoamingOrganizationByFnsParticipantIdRequest : SafeComObject, IGetOrCreateRoamingOrganizationByFnsParticipantIdRequest
	{
	}
}
