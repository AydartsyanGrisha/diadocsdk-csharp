using System.Runtime.InteropServices;
using Diadoc.Api.Com;

namespace Diadoc.Api.Proto.FnsParticipants
{
	[ComVisible(true)]
	[Guid("B71C411B-0BE4-4712-B1D5-46F975F0200E")]
	public interface ISearchFnsParticipantsResponse
	{
		Com.FnsParticipantSearchStatus StatusValue { get; set; }
		ReadonlyList ParticipantsList { get; }
		void AddParticipant([MarshalAs(UnmanagedType.IDispatch)] object item);
	}

	[ComVisible(true)]
	[ProgId("Diadoc.Api.SearchFnsParticipantsResponse")]
	[Guid("810A2A5C-495A-436B-AEF5-CCC2FF43D631")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComDefaultInterface(typeof(ISearchFnsParticipantsResponse))]
	public partial class SearchFnsParticipantsResponse : SafeComObject, ISearchFnsParticipantsResponse
	{
		public Com.FnsParticipantSearchStatus StatusValue
		{
			get => (Com.FnsParticipantSearchStatus) Status;
			set => Status = (FnsParticipantSearchStatus) value;
		}

		public ReadonlyList ParticipantsList => new ReadonlyList(Participants);

		public void AddParticipant(object participant)
		{
			Participants.Add((FnsParticipant) participant);
		}
	}

	[ComVisible(true)]
	[Guid("87E552DC-0CC4-4C62-B5B4-D95D6C2D89C7")]
	public interface IFnsParticipant
	{
		string FnsParticipantId { get; set; }
		string Inn { get; set; }
		string Kpp { get; set; }
		string FullName { get; set; }
	}

	[ComVisible(true)]
	[ProgId("Diadoc.Api.FnsParticipant")]
	[Guid("D96E4555-A892-43C2-8CAA-CC425F579F5F")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComDefaultInterface(typeof(IFnsParticipant))]
	public partial class FnsParticipant : SafeComObject, IFnsParticipant
	{
	}
}
