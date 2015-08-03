using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBDataAccess
{
	public enum EmailTemplateEnum
	{
		NotInUse0 = 0,

		JoinMeetBall = 1,

		InvitationToMeetBall = 2,

		WelcomeToMeetball = 3,

		FriendJustJoinedToMeetBall = 4,

		MeetBallPasswordReset = 5,

		NotInUse6 = 6,

		DeliveryFailure = 7,

		MeetBallComment = 8,

		NotInUse9 = 9,

		AddFriend = 10,

		VerifyCell = 11,

		UpdateMBLocation = 12,

		ReplyBack = 13,
		
		MBComplete = 14,

		Ping = 15,

		AcceptedMeetBall = 16,

		UpdateMeetBallTime = 17,

		UpdateMeetBallLoc = 18,

		UpdateMeetBallTimeLoc = 19,

		PhotoTagged = 20,

		MeetBallMessage = 21,

		OneToOneMessage = 22,

		InvitationToLiveBroadcast = 23,

		UpdateLiveBroadcastDesc = 24,

		JoinedLiveBroadcast = 25,

		StillBroadcasting = 26,
	}
}
