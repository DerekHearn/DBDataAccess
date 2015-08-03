


using System.Runtime.Serialization; 

namespace DBDataAccess 
{
	public partial class Enums 
	{
		/// <summary>
		/// Enum generated from table: LoginType
		/// </summary>
		public enum LoginType
		{
			MeetBall = 1,
			Facebook = 2,
			Unknown = 3,
		}
		/// <summary>
		/// Enum generated from table: FriendStatus
		/// </summary>
		public enum FriendStatus
		{
			Accepted = 1,
			Waiting = 2,
			Declined = 3,
			DeFriended = 4,
			Blocked = 5,
			IsBlocked = 6,
		}
		/// <summary>
		/// Enum generated from table: Sharing
		/// </summary>
		public enum Sharing
		{
			OwnerInviteOnly = 1,
			InvitedAddInvites = 2,
			PublicInvite = 3,
		}
		/// <summary>
		/// Enum generated from table: AppUserActivity
		/// </summary>
		public enum AppUserActivity
		{
			SentAppInvitation = 1,
			MeetballCreated = 2,
			MeetballUpdated = 3,
			SentInvitationtoMeetball = 4,
			ReceivedInvitationtoMeetball = 5,
			RespondedtoMeetballInvitation = 6,
			MeetballCheckIn = 7,
			MeetballInviteeUpdate = 8,
			ProfileUpdated = 9,
			UpdatedMeetballLocation = 10,
			MeetballTrackingStarted = 11,
			InvitedFriendViewedMeetBall = 12,
			CommentedOnAMeetBall = 13,
			CommentedOnYourMeetBall = 14,
			RequesttoaMeetBall = 15,
		}
		/// <summary>
		/// Enum generated from table: EmailTemplate
		/// </summary>
		public enum EmailTemplate
		{
			JoinMeetball = 1,
			InvitationToMeetball = 2,
			WelcomeToMeetball = 10,
			FriendJustJoinedToMeetBall = 51,
			MeetBallPasswordReset = 58,
			NewEmailAddressVerification = 26,
			DeliveryFailure = 24,
			JoinMeetBall = 59,
			InvitationToMeetBall = 70,
			MeetBallComment = 53,
			RequestToAMeetBall = 21,
			AddFriend = 50,
			VerifyCell = 57,
			UpdateMBLocation = 71,
			ReplyBack = 55,
			MBComplete = 56,
			Ping = 60,
			AcceptedMeetBall = 72,
			UpdateMeetBallTime = 73,
			UpdateMeetBallLoc = 74,
			UpdateMeetBallTimeLoc = 75,
			PhotoTagged = 65,
			MeetBallMessage = 66,
			OneToOneMessage = 67,
			InvitationToLiveBroadcast = 76,
			UpdateLiveBroadcastDesc = 77,
			JoinedLiveBroadcast = 78,
			StillBroadcasting = 79,
		}
		/// <summary>
		/// Enum generated from table: MessageType
		/// </summary>
		public enum MessageType
		{
			Email = 1,
			FacebookPrivateMessage = 2,
			CellphoneText = 3,
			PushNotification = 4,
		}
		/// <summary>
		/// Enum generated from table: WebAssetCollection
		/// </summary>
		public enum WebAssetCollection
		{
		}
	}
}