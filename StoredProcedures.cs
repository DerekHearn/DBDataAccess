


  
#pragma warning disable 1591 
using System;
using SubSonic;
using SubSonic.Schema;
using SubSonic.DataProviders;
using System.Data;

namespace DBDataAccess{
	public partial class MeetballDB{

        public StoredProcedure AdminBrowseAppSessionUserBySessionStartDate(DateTime StartDate,DateTime EndDate){
            StoredProcedure sp=new StoredProcedure("AdminBrowseAppSessionUserBySessionStartDate",this.Provider);
            sp.Command.AddParameter("StartDate",StartDate,DbType.DateTime);
            sp.Command.AddParameter("EndDate",EndDate,DbType.DateTime);
            return sp;
        }
        public StoredProcedure AdminBrowseAppSessionUserByUserIDSessionStartDate(DateTime StartDate,DateTime EndDate,int AppUserID){
            StoredProcedure sp=new StoredProcedure("AdminBrowseAppSessionUserByUserIDSessionStartDate",this.Provider);
            sp.Command.AddParameter("StartDate",StartDate,DbType.DateTime);
            sp.Command.AddParameter("EndDate",EndDate,DbType.DateTime);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            return sp;
        }
        public StoredProcedure AdminBrowseAppUsersByActivationDate(DateTime StartDate,DateTime EndDate){
            StoredProcedure sp=new StoredProcedure("AdminBrowseAppUsersByActivationDate",this.Provider);
            sp.Command.AddParameter("StartDate",StartDate,DbType.DateTime);
            sp.Command.AddParameter("EndDate",EndDate,DbType.DateTime);
            return sp;
        }
        public StoredProcedure AdminBrowseAppUsersByCreationDate(DateTime StartDate,DateTime EndDate){
            StoredProcedure sp=new StoredProcedure("AdminBrowseAppUsersByCreationDate",this.Provider);
            sp.Command.AddParameter("StartDate",StartDate,DbType.DateTime);
            sp.Command.AddParameter("EndDate",EndDate,DbType.DateTime);
            return sp;
        }
        public StoredProcedure AdminBrowseAppUsersByParameters(DateTime StartDate,DateTime EndDate,string Email,string FirstName,string LastName){
            StoredProcedure sp=new StoredProcedure("AdminBrowseAppUsersByParameters",this.Provider);
            sp.Command.AddParameter("StartDate",StartDate,DbType.DateTime);
            sp.Command.AddParameter("EndDate",EndDate,DbType.DateTime);
            sp.Command.AddParameter("Email",Email,DbType.AnsiString);
            sp.Command.AddParameter("FirstName",FirstName,DbType.AnsiString);
            sp.Command.AddParameter("LastName",LastName,DbType.AnsiString);
            return sp;
        }
        public StoredProcedure AdminBrowseFacebookLoginAppSessionUserBySessionStartDate(DateTime StartDate,DateTime EndDate){
            StoredProcedure sp=new StoredProcedure("AdminBrowseFacebookLoginAppSessionUserBySessionStartDate",this.Provider);
            sp.Command.AddParameter("StartDate",StartDate,DbType.DateTime);
            sp.Command.AddParameter("EndDate",EndDate,DbType.DateTime);
            return sp;
        }
        public StoredProcedure AdminBrowseMeetballByOwnerID(int AppUserID){
            StoredProcedure sp=new StoredProcedure("AdminBrowseMeetballByOwnerID",this.Provider);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            return sp;
        }
        public StoredProcedure AdminBrowseMeetBallLoginAppSessionUserBySessionStartDate(DateTime StartDate,DateTime EndDate){
            StoredProcedure sp=new StoredProcedure("AdminBrowseMeetBallLoginAppSessionUserBySessionStartDate",this.Provider);
            sp.Command.AddParameter("StartDate",StartDate,DbType.DateTime);
            sp.Command.AddParameter("EndDate",EndDate,DbType.DateTime);
            return sp;
        }
        public StoredProcedure AdminBrowseMeetBallReponsesByResponseDate(DateTime StartDate,DateTime EndDate,string Email){
            StoredProcedure sp=new StoredProcedure("AdminBrowseMeetBallReponsesByResponseDate",this.Provider);
            sp.Command.AddParameter("StartDate",StartDate,DbType.DateTime);
            sp.Command.AddParameter("EndDate",EndDate,DbType.DateTime);
            sp.Command.AddParameter("Email",Email,DbType.AnsiString);
            return sp;
        }
        public StoredProcedure AdminBrowseMeetBallReponsesBySentDate(DateTime StartDate,DateTime EndDate,string Email){
            StoredProcedure sp=new StoredProcedure("AdminBrowseMeetBallReponsesBySentDate",this.Provider);
            sp.Command.AddParameter("StartDate",StartDate,DbType.DateTime);
            sp.Command.AddParameter("EndDate",EndDate,DbType.DateTime);
            sp.Command.AddParameter("Email",Email,DbType.AnsiString);
            return sp;
        }
        public StoredProcedure AdminBrowseMeetBallsByCreateDate(DateTime StartDate,DateTime EndDate,string Email){
            StoredProcedure sp=new StoredProcedure("AdminBrowseMeetBallsByCreateDate",this.Provider);
            sp.Command.AddParameter("StartDate",StartDate,DbType.DateTime);
            sp.Command.AddParameter("EndDate",EndDate,DbType.DateTime);
            sp.Command.AddParameter("Email",Email,DbType.AnsiString);
            return sp;
        }
        public StoredProcedure AdminBrowseMethodLogBySessionGuidAndCalltDate(DateTime StartDate,DateTime EndDate,string AppSessionGuid){
            StoredProcedure sp=new StoredProcedure("AdminBrowseMethodLogBySessionGuidAndCalltDate",this.Provider);
            sp.Command.AddParameter("StartDate",StartDate,DbType.DateTime);
            sp.Command.AddParameter("EndDate",EndDate,DbType.DateTime);
            sp.Command.AddParameter("AppSessionGuid",AppSessionGuid,DbType.AnsiString);
            return sp;
        }
        public StoredProcedure AdminBrowseMethodLogExceptionsByExceptionDate(DateTime StartDate,DateTime EndDate){
            StoredProcedure sp=new StoredProcedure("AdminBrowseMethodLogExceptionsByExceptionDate",this.Provider);
            sp.Command.AddParameter("StartDate",StartDate,DbType.DateTime);
            sp.Command.AddParameter("EndDate",EndDate,DbType.DateTime);
            return sp;
        }
        public StoredProcedure AdminGetGeneralReportByDate(DateTime StartDate,DateTime EndDate){
            StoredProcedure sp=new StoredProcedure("AdminGetGeneralReportByDate",this.Provider);
            sp.Command.AddParameter("StartDate",StartDate,DbType.DateTime);
            sp.Command.AddParameter("EndDate",EndDate,DbType.DateTime);
            return sp;
        }
        public StoredProcedure AdminGetMeetBallKingList(){
            StoredProcedure sp=new StoredProcedure("AdminGetMeetBallKingList",this.Provider);
            return sp;
        }
        public StoredProcedure AppUserXFriendAppUser_Update(int AppUserID,int FriendAppUserID,int NewFriendStatusID){
            StoredProcedure sp=new StoredProcedure("AppUserXFriendAppUser_Update",this.Provider);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            sp.Command.AddParameter("FriendAppUserID",FriendAppUserID,DbType.Int32);
            sp.Command.AddParameter("NewFriendStatusID",NewFriendStatusID,DbType.Int32);
            return sp;
        }
        public StoredProcedure AppUserXFriendAppUser_UpdateFavorite(int AppUserID,int FriendAppUserID,bool NewFavorite){
            StoredProcedure sp=new StoredProcedure("AppUserXFriendAppUser_UpdateFavorite",this.Provider);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            sp.Command.AddParameter("FriendAppUserID",FriendAppUserID,DbType.Int32);
            sp.Command.AddParameter("NewFavorite",NewFavorite,DbType.Boolean);
            return sp;
        }
        public StoredProcedure AppUserXFriendAppUser_UpdateTrackingID(int AppUserID,int FriendAppUserID,int NewTrackingID){
            StoredProcedure sp=new StoredProcedure("AppUserXFriendAppUser_UpdateTrackingID",this.Provider);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            sp.Command.AddParameter("FriendAppUserID",FriendAppUserID,DbType.Int32);
            sp.Command.AddParameter("NewTrackingID",NewTrackingID,DbType.Int32);
            return sp;
        }
        public StoredProcedure BrowseAppSessionUserBySessionStartDate(DateTime StartDate,DateTime EndDate){
            StoredProcedure sp=new StoredProcedure("BrowseAppSessionUserBySessionStartDate",this.Provider);
            sp.Command.AddParameter("StartDate",StartDate,DbType.DateTime);
            sp.Command.AddParameter("EndDate",EndDate,DbType.DateTime);
            return sp;
        }
        public StoredProcedure BrowseAppUsersByActivationDate(DateTime StartDate,DateTime EndDate){
            StoredProcedure sp=new StoredProcedure("BrowseAppUsersByActivationDate",this.Provider);
            sp.Command.AddParameter("StartDate",StartDate,DbType.DateTime);
            sp.Command.AddParameter("EndDate",EndDate,DbType.DateTime);
            return sp;
        }
        public StoredProcedure BrowseAppUsersByCreationDate(DateTime StartDate,DateTime EndDate){
            StoredProcedure sp=new StoredProcedure("BrowseAppUsersByCreationDate",this.Provider);
            sp.Command.AddParameter("StartDate",StartDate,DbType.DateTime);
            sp.Command.AddParameter("EndDate",EndDate,DbType.DateTime);
            return sp;
        }
        public StoredProcedure BrowseAppUserXFriendAppUserByAppUserIDFavs(int AppUserID){
            StoredProcedure sp=new StoredProcedure("BrowseAppUserXFriendAppUserByAppUserIDFavs",this.Provider);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            return sp;
        }
        public StoredProcedure BrowseAppUserXFriendAppUserByAppUserIDFavsLocUpdate(int AppUserID){
            StoredProcedure sp=new StoredProcedure("BrowseAppUserXFriendAppUserByAppUserIDFavsLocUpdate",this.Provider);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            return sp;
        }
        public StoredProcedure BrowseCurrentMeetballByAppUserID(int AppUserID){
            StoredProcedure sp=new StoredProcedure("BrowseCurrentMeetballByAppUserID",this.Provider);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            return sp;
        }
        public StoredProcedure BrowseCurrentMeetballTrackingByMeetballID(int MeetballID){
            StoredProcedure sp=new StoredProcedure("BrowseCurrentMeetballTrackingByMeetballID",this.Provider);
            sp.Command.AddParameter("MeetballID",MeetballID,DbType.Int32);
            return sp;
        }
        public StoredProcedure BrowseCurrentMeetballTrackingByMeetballIDAppUserID(int MeetballID,int AppUserID){
            StoredProcedure sp=new StoredProcedure("BrowseCurrentMeetballTrackingByMeetballIDAppUserID",this.Provider);
            sp.Command.AddParameter("MeetballID",MeetballID,DbType.Int32);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            return sp;
        }
        public StoredProcedure BrowseFacebookLoginAppSessionUserBySessionStartDate(DateTime StartDate,DateTime EndDate){
            StoredProcedure sp=new StoredProcedure("BrowseFacebookLoginAppSessionUserBySessionStartDate",this.Provider);
            sp.Command.AddParameter("StartDate",StartDate,DbType.DateTime);
            sp.Command.AddParameter("EndDate",EndDate,DbType.DateTime);
            return sp;
        }
        public StoredProcedure BrowseFriendByAppUserIDFriendStatusID(int AppUserID,int FriendStatusID){
            StoredProcedure sp=new StoredProcedure("BrowseFriendByAppUserIDFriendStatusID",this.Provider);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            sp.Command.AddParameter("FriendStatusID",FriendStatusID,DbType.Int32);
            return sp;
        }
        public StoredProcedure BrowseMeetballByAppUserID(int AppUserID){
            StoredProcedure sp=new StoredProcedure("BrowseMeetballByAppUserID",this.Provider);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            return sp;
        }
        public StoredProcedure BrowseMeetballByOwnerID(int AppUserID){
            StoredProcedure sp=new StoredProcedure("BrowseMeetballByOwnerID",this.Provider);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            return sp;
        }
        public StoredProcedure BrowseMeetballCommentByMeetballID(int MeetballID){
            StoredProcedure sp=new StoredProcedure("BrowseMeetballCommentByMeetballID",this.Provider);
            sp.Command.AddParameter("MeetballID",MeetballID,DbType.Int32);
            return sp;
        }
        public StoredProcedure BrowseMeetballDetailByMeetballID(int MeetballID){
            StoredProcedure sp=new StoredProcedure("BrowseMeetballDetailByMeetballID",this.Provider);
            sp.Command.AddParameter("MeetballID",MeetballID,DbType.Int32);
            return sp;
        }
        public StoredProcedure BrowseMeetBallLoginAppSessionUserBySessionStartDate(DateTime StartDate,DateTime EndDate){
            StoredProcedure sp=new StoredProcedure("BrowseMeetBallLoginAppSessionUserBySessionStartDate",this.Provider);
            sp.Command.AddParameter("StartDate",StartDate,DbType.DateTime);
            sp.Command.AddParameter("EndDate",EndDate,DbType.DateTime);
            return sp;
        }
        public StoredProcedure BrowseMeetballOwnerByMeetballID(int MeetballID){
            StoredProcedure sp=new StoredProcedure("BrowseMeetballOwnerByMeetballID",this.Provider);
            sp.Command.AddParameter("MeetballID",MeetballID,DbType.Int32);
            return sp;
        }
        public StoredProcedure BrowseMeetballResponseByMeetballID(int MeetballID){
            StoredProcedure sp=new StoredProcedure("BrowseMeetballResponseByMeetballID",this.Provider);
            sp.Command.AddParameter("MeetballID",MeetballID,DbType.Int32);
            return sp;
        }
        public StoredProcedure BrowseMeetballResponseSummaryByMeetballID(int MeetballID){
            StoredProcedure sp=new StoredProcedure("BrowseMeetballResponseSummaryByMeetballID",this.Provider);
            sp.Command.AddParameter("MeetballID",MeetballID,DbType.Int32);
            return sp;
        }
        public StoredProcedure BrowseMeetBallsByCreateDate(DateTime StartDate,DateTime EndDate){
            StoredProcedure sp=new StoredProcedure("BrowseMeetBallsByCreateDate",this.Provider);
            sp.Command.AddParameter("StartDate",StartDate,DbType.DateTime);
            sp.Command.AddParameter("EndDate",EndDate,DbType.DateTime);
            return sp;
        }
        public StoredProcedure BrowseMeetballTrackingByMeetballID(int MeetballID){
            StoredProcedure sp=new StoredProcedure("BrowseMeetballTrackingByMeetballID",this.Provider);
            sp.Command.AddParameter("MeetballID",MeetballID,DbType.Int32);
            return sp;
        }
        public StoredProcedure BrowseMeetballTrackingByMeetballIDAppUserID(int MeetballID,int AppUserID){
            StoredProcedure sp=new StoredProcedure("BrowseMeetballTrackingByMeetballIDAppUserID",this.Provider);
            sp.Command.AddParameter("MeetballID",MeetballID,DbType.Int32);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            return sp;
        }
        public StoredProcedure BrowseMethodLogExceptionsByExceptionDate(DateTime StartDate,DateTime EndDate){
            StoredProcedure sp=new StoredProcedure("BrowseMethodLogExceptionsByExceptionDate",this.Provider);
            sp.Command.AddParameter("StartDate",StartDate,DbType.DateTime);
            sp.Command.AddParameter("EndDate",EndDate,DbType.DateTime);
            return sp;
        }
        public StoredProcedure BrowsePossibleFriendsByAppUserId(int AppUserID){
            StoredProcedure sp=new StoredProcedure("BrowsePossibleFriendsByAppUserId",this.Provider);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            return sp;
        }
        public StoredProcedure BrowseTopCurrentMeetballByAppUserID(int AppUserID,int count){
            StoredProcedure sp=new StoredProcedure("BrowseTopCurrentMeetballByAppUserID",this.Provider);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            sp.Command.AddParameter("count",count,DbType.Int32);
            return sp;
        }
        public StoredProcedure BrowseUnansweredMeetballResponsesByAppUserID(int AppUserID){
            StoredProcedure sp=new StoredProcedure("BrowseUnansweredMeetballResponsesByAppUserID",this.Provider);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            return sp;
        }
        public StoredProcedure BrowseVenueByVenueID(int VenueTypeID){
            StoredProcedure sp=new StoredProcedure("BrowseVenueByVenueID",this.Provider);
            sp.Command.AddParameter("VenueTypeID",VenueTypeID,DbType.Int32);
            return sp;
        }
        public StoredProcedure ConnectAppUsers(int AppUserID){
            StoredProcedure sp=new StoredProcedure("ConnectAppUsers",this.Provider);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            return sp;
        }
        public StoredProcedure ConnectAppUsersBatchByDate(int RunCheck,DateTime StartDate){
            StoredProcedure sp=new StoredProcedure("ConnectAppUsersBatchByDate",this.Provider);
            sp.Command.AddParameter("RunCheck",RunCheck,DbType.Int32);
            sp.Command.AddParameter("StartDate",StartDate,DbType.DateTime);
            return sp;
        }
        public StoredProcedure ConnectSponsors(int AppUserID){
            StoredProcedure sp=new StoredProcedure("ConnectSponsors",this.Provider);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            return sp;
        }
        public StoredProcedure ConnectSponsorsBatch(int RunCheck){
            StoredProcedure sp=new StoredProcedure("ConnectSponsorsBatch",this.Provider);
            sp.Command.AddParameter("RunCheck",RunCheck,DbType.Int32);
            return sp;
        }
        public StoredProcedure ConnectSponsorsBatchByDate(int RunCheck,DateTime StartDate){
            StoredProcedure sp=new StoredProcedure("ConnectSponsorsBatchByDate",this.Provider);
            sp.Command.AddParameter("RunCheck",RunCheck,DbType.Int32);
            sp.Command.AddParameter("StartDate",StartDate,DbType.DateTime);
            return sp;
        }
        public StoredProcedure ConvoCheck(int AppUserID,int FriendAppUserID){
            StoredProcedure sp=new StoredProcedure("ConvoCheck",this.Provider);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            sp.Command.AddParameter("FriendAppUserID",FriendAppUserID,DbType.Int32);
            return sp;
        }
        public StoredProcedure CountCommentsToAppUserID(int AppUserID,int MeetballID){
            StoredProcedure sp=new StoredProcedure("CountCommentsToAppUserID",this.Provider);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            sp.Command.AddParameter("MeetballID",MeetballID,DbType.Int32);
            return sp;
        }
        public StoredProcedure CountMeetballsByAppUser(int AppUserID){
            StoredProcedure sp=new StoredProcedure("CountMeetballsByAppUser",this.Provider);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            return sp;
        }
        public StoredProcedure CreateMeetball(string MBName,string MeetballDescription,bool Private,int MBOwnerID,DateTime StartDate,DateTime EndDate,string GeneralLocationAddress1,string GeneralLocationCity,string GeneralLocationGpxWkt,string GeneralLocationState,string GeneralLocationZip,string SpecificLocationGpxWkt,string LocationName,int UsageID,int GeneralLocationAccuracy,int Invitee1,int Invitee2,int Invitee3,int Invitee4,int Invitee5,int Invitee6,int Invitee7){
            StoredProcedure sp=new StoredProcedure("CreateMeetball",this.Provider);
            sp.Command.AddParameter("MBName",MBName,DbType.AnsiString);
            sp.Command.AddParameter("MeetballDescription",MeetballDescription,DbType.AnsiString);
            sp.Command.AddParameter("Private",Private,DbType.Boolean);
            sp.Command.AddParameter("MBOwnerID",MBOwnerID,DbType.Int32);
            sp.Command.AddParameter("StartDate",StartDate,DbType.DateTime);
            sp.Command.AddParameter("EndDate",EndDate,DbType.DateTime);
            sp.Command.AddParameter("GeneralLocationAddress1",GeneralLocationAddress1,DbType.AnsiString);
            sp.Command.AddParameter("GeneralLocationCity",GeneralLocationCity,DbType.AnsiString);
            sp.Command.AddParameter("GeneralLocationGpxWkt",GeneralLocationGpxWkt,DbType.AnsiString);
            sp.Command.AddParameter("GeneralLocationState",GeneralLocationState,DbType.AnsiString);
            sp.Command.AddParameter("GeneralLocationZip",GeneralLocationZip,DbType.AnsiString);
            sp.Command.AddParameter("SpecificLocationGpxWkt",SpecificLocationGpxWkt,DbType.AnsiString);
            sp.Command.AddParameter("LocationName",LocationName,DbType.AnsiString);
            sp.Command.AddParameter("UsageID",UsageID,DbType.Int32);
            sp.Command.AddParameter("GeneralLocationAccuracy",GeneralLocationAccuracy,DbType.Int32);
            sp.Command.AddParameter("Invitee1",Invitee1,DbType.Int32);
            sp.Command.AddParameter("Invitee2",Invitee2,DbType.Int32);
            sp.Command.AddParameter("Invitee3",Invitee3,DbType.Int32);
            sp.Command.AddParameter("Invitee4",Invitee4,DbType.Int32);
            sp.Command.AddParameter("Invitee5",Invitee5,DbType.Int32);
            sp.Command.AddParameter("Invitee6",Invitee6,DbType.Int32);
            sp.Command.AddParameter("Invitee7",Invitee7,DbType.Int32);
            return sp;
        }
        public StoredProcedure CreateMeetballOffPlatform(int MeetballID,int MBOwnerID,string InviteeName1,string InviteePhone1,string InviteeName2,string InviteePhone2,string InviteeName3,string InviteePhone3,string InviteeName4,string InviteePhone4,string InviteeName5,string InviteePhone5,string InviteeName6,string InviteePhone6,string InviteeName7,string InviteePhone7,string InviteeName8,string InviteePhone8,string InviteeName9,string InviteePhone9,string InviteeName10,string InviteePhone10){
            StoredProcedure sp=new StoredProcedure("CreateMeetballOffPlatform",this.Provider);
            sp.Command.AddParameter("MeetballID",MeetballID,DbType.Int32);
            sp.Command.AddParameter("MBOwnerID",MBOwnerID,DbType.Int32);
            sp.Command.AddParameter("InviteeName1",InviteeName1,DbType.AnsiString);
            sp.Command.AddParameter("InviteePhone1",InviteePhone1,DbType.AnsiString);
            sp.Command.AddParameter("InviteeName2",InviteeName2,DbType.AnsiString);
            sp.Command.AddParameter("InviteePhone2",InviteePhone2,DbType.AnsiString);
            sp.Command.AddParameter("InviteeName3",InviteeName3,DbType.AnsiString);
            sp.Command.AddParameter("InviteePhone3",InviteePhone3,DbType.AnsiString);
            sp.Command.AddParameter("InviteeName4",InviteeName4,DbType.AnsiString);
            sp.Command.AddParameter("InviteePhone4",InviteePhone4,DbType.AnsiString);
            sp.Command.AddParameter("InviteeName5",InviteeName5,DbType.AnsiString);
            sp.Command.AddParameter("InviteePhone5",InviteePhone5,DbType.AnsiString);
            sp.Command.AddParameter("InviteeName6",InviteeName6,DbType.AnsiString);
            sp.Command.AddParameter("InviteePhone6",InviteePhone6,DbType.AnsiString);
            sp.Command.AddParameter("InviteeName7",InviteeName7,DbType.AnsiString);
            sp.Command.AddParameter("InviteePhone7",InviteePhone7,DbType.AnsiString);
            sp.Command.AddParameter("InviteeName8",InviteeName8,DbType.AnsiString);
            sp.Command.AddParameter("InviteePhone8",InviteePhone8,DbType.AnsiString);
            sp.Command.AddParameter("InviteeName9",InviteeName9,DbType.AnsiString);
            sp.Command.AddParameter("InviteePhone9",InviteePhone9,DbType.AnsiString);
            sp.Command.AddParameter("InviteeName10",InviteeName10,DbType.AnsiString);
            sp.Command.AddParameter("InviteePhone10",InviteePhone10,DbType.AnsiString);
            return sp;
        }
        public StoredProcedure CreateMeetballOffPlatformTVP(int MeetballID,int MBOwnerID,int ReferralAppUserID,string TVP){
            StoredProcedure sp=new StoredProcedure("CreateMeetballOffPlatformTVP",this.Provider);
            sp.Command.AddParameter("MeetballID",MeetballID,DbType.Int32);
            sp.Command.AddParameter("MBOwnerID",MBOwnerID,DbType.Int32);
            sp.Command.AddParameter("ReferralAppUserID",ReferralAppUserID,DbType.Int32);
            sp.Command.AddParameter("TVP",TVP,DbType.AnsiString);
            return sp;
        }
        public StoredProcedure CreateMeetballResponse(int MeetballID,int MBOwnerID,int Invitee1,int Invitee2,int Invitee3,int Invitee4,int Invitee5,int Invitee6,int Invitee7,int Invitee8,int Invitee9,int Invitee10,int Invitee11,int Invitee12,int Invitee13,int Invitee14,int Invitee15){
            StoredProcedure sp=new StoredProcedure("CreateMeetballResponse",this.Provider);
            sp.Command.AddParameter("MeetballID",MeetballID,DbType.Int32);
            sp.Command.AddParameter("MBOwnerID",MBOwnerID,DbType.Int32);
            sp.Command.AddParameter("Invitee1",Invitee1,DbType.Int32);
            sp.Command.AddParameter("Invitee2",Invitee2,DbType.Int32);
            sp.Command.AddParameter("Invitee3",Invitee3,DbType.Int32);
            sp.Command.AddParameter("Invitee4",Invitee4,DbType.Int32);
            sp.Command.AddParameter("Invitee5",Invitee5,DbType.Int32);
            sp.Command.AddParameter("Invitee6",Invitee6,DbType.Int32);
            sp.Command.AddParameter("Invitee7",Invitee7,DbType.Int32);
            sp.Command.AddParameter("Invitee8",Invitee8,DbType.Int32);
            sp.Command.AddParameter("Invitee9",Invitee9,DbType.Int32);
            sp.Command.AddParameter("Invitee10",Invitee10,DbType.Int32);
            sp.Command.AddParameter("Invitee11",Invitee11,DbType.Int32);
            sp.Command.AddParameter("Invitee12",Invitee12,DbType.Int32);
            sp.Command.AddParameter("Invitee13",Invitee13,DbType.Int32);
            sp.Command.AddParameter("Invitee14",Invitee14,DbType.Int32);
            sp.Command.AddParameter("Invitee15",Invitee15,DbType.Int32);
            return sp;
        }
        public StoredProcedure CreateMeetballResponseTVP(int MeetballID,int MBOwnerID,string TVP){
            StoredProcedure sp=new StoredProcedure("CreateMeetballResponseTVP",this.Provider);
            sp.Command.AddParameter("MeetballID",MeetballID,DbType.Int32);
            sp.Command.AddParameter("MBOwnerID",MBOwnerID,DbType.Int32);
            sp.Command.AddParameter("TVP",TVP,DbType.AnsiString);
            return sp;
        }
        public StoredProcedure CreateMeetballV2(string MBName,string MeetballDescription,bool Private,int MBOwnerID,DateTime StartDate,DateTime EndDate,string GeneralLocationAddress1,string GeneralLocationCity,string GeneralLocationGpxWkt,string GeneralLocationState,string GeneralLocationZip,string SpecificLocationGpxWkt,string LocationName,int UsageID,int GeneralLocationAccuracy,string MBIDHash,string ShortURL){
            StoredProcedure sp=new StoredProcedure("CreateMeetballV2",this.Provider);
            sp.Command.AddParameter("MBName",MBName,DbType.AnsiString);
            sp.Command.AddParameter("MeetballDescription",MeetballDescription,DbType.AnsiString);
            sp.Command.AddParameter("Private",Private,DbType.Boolean);
            sp.Command.AddParameter("MBOwnerID",MBOwnerID,DbType.Int32);
            sp.Command.AddParameter("StartDate",StartDate,DbType.DateTime);
            sp.Command.AddParameter("EndDate",EndDate,DbType.DateTime);
            sp.Command.AddParameter("GeneralLocationAddress1",GeneralLocationAddress1,DbType.AnsiString);
            sp.Command.AddParameter("GeneralLocationCity",GeneralLocationCity,DbType.AnsiString);
            sp.Command.AddParameter("GeneralLocationGpxWkt",GeneralLocationGpxWkt,DbType.AnsiString);
            sp.Command.AddParameter("GeneralLocationState",GeneralLocationState,DbType.AnsiString);
            sp.Command.AddParameter("GeneralLocationZip",GeneralLocationZip,DbType.AnsiString);
            sp.Command.AddParameter("SpecificLocationGpxWkt",SpecificLocationGpxWkt,DbType.AnsiString);
            sp.Command.AddParameter("LocationName",LocationName,DbType.AnsiString);
            sp.Command.AddParameter("UsageID",UsageID,DbType.Int32);
            sp.Command.AddParameter("GeneralLocationAccuracy",GeneralLocationAccuracy,DbType.Int32);
            sp.Command.AddParameter("MBIDHash",MBIDHash,DbType.AnsiString);
            sp.Command.AddParameter("ShortURL",ShortURL,DbType.AnsiString);
            return sp;
        }
        public StoredProcedure CreateMeetballV3(string MBName,string MeetballDescription,bool Private,int MBOwnerID,DateTime StartDate,DateTime EndDate,string GeneralLocationAddress1,string GeneralLocationCity,string GeneralLocationGpxWkt,string GeneralLocationState,string GeneralLocationZip,string SpecificLocationGpxWkt,string LocationName,int UsageID,int GeneralLocationAccuracy,string MBIDHash,string ShortURL,bool HasPic){
            StoredProcedure sp=new StoredProcedure("CreateMeetballV3",this.Provider);
            sp.Command.AddParameter("MBName",MBName,DbType.AnsiString);
            sp.Command.AddParameter("MeetballDescription",MeetballDescription,DbType.AnsiString);
            sp.Command.AddParameter("Private",Private,DbType.Boolean);
            sp.Command.AddParameter("MBOwnerID",MBOwnerID,DbType.Int32);
            sp.Command.AddParameter("StartDate",StartDate,DbType.DateTime);
            sp.Command.AddParameter("EndDate",EndDate,DbType.DateTime);
            sp.Command.AddParameter("GeneralLocationAddress1",GeneralLocationAddress1,DbType.AnsiString);
            sp.Command.AddParameter("GeneralLocationCity",GeneralLocationCity,DbType.AnsiString);
            sp.Command.AddParameter("GeneralLocationGpxWkt",GeneralLocationGpxWkt,DbType.AnsiString);
            sp.Command.AddParameter("GeneralLocationState",GeneralLocationState,DbType.AnsiString);
            sp.Command.AddParameter("GeneralLocationZip",GeneralLocationZip,DbType.AnsiString);
            sp.Command.AddParameter("SpecificLocationGpxWkt",SpecificLocationGpxWkt,DbType.AnsiString);
            sp.Command.AddParameter("LocationName",LocationName,DbType.AnsiString);
            sp.Command.AddParameter("UsageID",UsageID,DbType.Int32);
            sp.Command.AddParameter("GeneralLocationAccuracy",GeneralLocationAccuracy,DbType.Int32);
            sp.Command.AddParameter("MBIDHash",MBIDHash,DbType.AnsiString);
            sp.Command.AddParameter("ShortURL",ShortURL,DbType.AnsiString);
            sp.Command.AddParameter("HasPic",HasPic,DbType.Boolean);
            return sp;
        }
        public StoredProcedure FriendCountBatch(int RunCheck){
            StoredProcedure sp=new StoredProcedure("FriendCountBatch",this.Provider);
            sp.Command.AddParameter("RunCheck",RunCheck,DbType.Int32);
            return sp;
        }
        public StoredProcedure FriendCounter(int AppUserID){
            StoredProcedure sp=new StoredProcedure("FriendCounter",this.Provider);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            return sp;
        }
        public StoredProcedure GetActiveFeaturedMBsByDistance(string searchpoint,double kmrad){
            StoredProcedure sp=new StoredProcedure("GetActiveFeaturedMBsByDistance",this.Provider);
            sp.Command.AddParameter("searchpoint",searchpoint,DbType.AnsiString);
            sp.Command.AddParameter("kmrad",kmrad,DbType.Double);
            return sp;
        }
        public StoredProcedure GetActiveFeaturedMBsByDistanceAndOwner(string searchpoint,double kmrad,int ownerid){
            StoredProcedure sp=new StoredProcedure("GetActiveFeaturedMBsByDistanceAndOwner",this.Provider);
            sp.Command.AddParameter("searchpoint",searchpoint,DbType.AnsiString);
            sp.Command.AddParameter("kmrad",kmrad,DbType.Double);
            sp.Command.AddParameter("ownerid",ownerid,DbType.Int32);
            return sp;
        }
        public StoredProcedure GetActiveMeetballsByAppUserID(DateTime CheckTime,int AppUserID,int TopX){
            StoredProcedure sp=new StoredProcedure("GetActiveMeetballsByAppUserID",this.Provider);
            sp.Command.AddParameter("CheckTime",CheckTime,DbType.DateTime);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            sp.Command.AddParameter("TopX",TopX,DbType.Int32);
            return sp;
        }
        public StoredProcedure GetActiveTeamMBsByDistance(string searchpoint,double kmrad){
            StoredProcedure sp=new StoredProcedure("GetActiveTeamMBsByDistance",this.Provider);
            sp.Command.AddParameter("searchpoint",searchpoint,DbType.AnsiString);
            sp.Command.AddParameter("kmrad",kmrad,DbType.Double);
            return sp;
        }
        public StoredProcedure GetActiveTeamMBsByDistanceV2(string searchpoint,double kmrad){
            StoredProcedure sp=new StoredProcedure("GetActiveTeamMBsByDistanceV2",this.Provider);
            sp.Command.AddParameter("searchpoint",searchpoint,DbType.AnsiString);
            sp.Command.AddParameter("kmrad",kmrad,DbType.Double);
            return sp;
        }
        public StoredProcedure GetAdminReportByDate(DateTime StartDate,DateTime EndDate){
            StoredProcedure sp=new StoredProcedure("GetAdminReportByDate",this.Provider);
            sp.Command.AddParameter("StartDate",StartDate,DbType.DateTime);
            sp.Command.AddParameter("EndDate",EndDate,DbType.DateTime);
            return sp;
        }
        public StoredProcedure GetAllBroadcastsByAppUserID(int AppUserID){
            StoredProcedure sp=new StoredProcedure("GetAllBroadcastsByAppUserID",this.Provider);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            return sp;
        }
        public StoredProcedure GetAllCommentsByMBID(int MeetballID,int AppUserID){
            StoredProcedure sp=new StoredProcedure("GetAllCommentsByMBID",this.Provider);
            sp.Command.AddParameter("MeetballID",MeetballID,DbType.Int32);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            return sp;
        }
        public StoredProcedure GetAllMeetballsByAppUserID(int AppUserID){
            StoredProcedure sp=new StoredProcedure("GetAllMeetballsByAppUserID",this.Provider);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            return sp;
        }
        public StoredProcedure GetALLTopXMB_ByAppUserID(DateTime CheckTime,int AppUserID,int TopX){
            StoredProcedure sp=new StoredProcedure("GetALLTopXMB_ByAppUserID",this.Provider);
            sp.Command.AddParameter("CheckTime",CheckTime,DbType.DateTime);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            sp.Command.AddParameter("TopX",TopX,DbType.Int32);
            return sp;
        }
        public StoredProcedure GetAppUserDefStats(int AppUserID){
            StoredProcedure sp=new StoredProcedure("GetAppUserDefStats",this.Provider);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            return sp;
        }
        public StoredProcedure GetAppUserID_MB_Participants(int MeetballID){
            StoredProcedure sp=new StoredProcedure("GetAppUserID_MB_Participants",this.Provider);
            sp.Command.AddParameter("MeetballID",MeetballID,DbType.Int32);
            return sp;
        }
        public StoredProcedure GetCommentCountTopXMB_ByAppUserID(DateTime CheckTime,int AppUserID,int TopX){
            StoredProcedure sp=new StoredProcedure("GetCommentCountTopXMB_ByAppUserID",this.Provider);
            sp.Command.AddParameter("CheckTime",CheckTime,DbType.DateTime);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            sp.Command.AddParameter("TopX",TopX,DbType.Int32);
            return sp;
        }
        public StoredProcedure GetConferencesBySportsTypeID(int SportsTypeID){
            StoredProcedure sp=new StoredProcedure("GetConferencesBySportsTypeID",this.Provider);
            sp.Command.AddParameter("SportsTypeID",SportsTypeID,DbType.Int32);
            return sp;
        }
        public StoredProcedure GetConvoByConvoID(int ConvoID){
            StoredProcedure sp=new StoredProcedure("GetConvoByConvoID",this.Provider);
            sp.Command.AddParameter("ConvoID",ConvoID,DbType.Int32);
            return sp;
        }
        public StoredProcedure GetConvoByMeetballID(int MeetballID){
            StoredProcedure sp=new StoredProcedure("GetConvoByMeetballID",this.Provider);
            sp.Command.AddParameter("MeetballID",MeetballID,DbType.Int32);
            return sp;
        }
        public StoredProcedure GetConvoHeadersByAppUserID(int AppUserID){
            StoredProcedure sp=new StoredProcedure("GetConvoHeadersByAppUserID",this.Provider);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            return sp;
        }
        public StoredProcedure GetConvoMarkRead(int MeetballID,int FromAppUserID,int ToAppUserID,int TopX){
            StoredProcedure sp=new StoredProcedure("GetConvoMarkRead",this.Provider);
            sp.Command.AddParameter("MeetballID",MeetballID,DbType.Int32);
            sp.Command.AddParameter("FromAppUserID",FromAppUserID,DbType.Int32);
            sp.Command.AddParameter("ToAppUserID",ToAppUserID,DbType.Int32);
            sp.Command.AddParameter("TopX",TopX,DbType.Int32);
            return sp;
        }
        public StoredProcedure GetDivisionsBySportsTypeID(int SportsTypeID){
            StoredProcedure sp=new StoredProcedure("GetDivisionsBySportsTypeID",this.Provider);
            sp.Command.AddParameter("SportsTypeID",SportsTypeID,DbType.Int32);
            return sp;
        }
        public StoredProcedure GetDLURL(){
            StoredProcedure sp=new StoredProcedure("GetDLURL",this.Provider);
            return sp;
        }
        public StoredProcedure GetEventHistoryByUser(int AppUserID,int Quantity,int StartMeetballID){
            StoredProcedure sp=new StoredProcedure("GetEventHistoryByUser",this.Provider);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            sp.Command.AddParameter("Quantity",Quantity,DbType.Int32);
            sp.Command.AddParameter("StartMeetballID",StartMeetballID,DbType.Int32);
            return sp;
        }
        public StoredProcedure GetEventsByOwnerAndTimespanTVP(string OwnerIDs,DateTime BeginningOfDateRangeUTC,DateTime EndOfDateRangeUTC){
            StoredProcedure sp=new StoredProcedure("GetEventsByOwnerAndTimespanTVP",this.Provider);
            sp.Command.AddParameter("OwnerIDs",OwnerIDs,DbType.AnsiString);
            sp.Command.AddParameter("BeginningOfDateRangeUTC",BeginningOfDateRangeUTC,DbType.DateTime);
            sp.Command.AddParameter("EndOfDateRangeUTC",EndOfDateRangeUTC,DbType.DateTime);
            return sp;
        }
        public StoredProcedure GetEventsByUserAndTimespan(int AppUserID,DateTime BeginningOfDateRangeUTC,DateTime EndOfDateRangeUTC){
            StoredProcedure sp=new StoredProcedure("GetEventsByUserAndTimespan",this.Provider);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            sp.Command.AddParameter("BeginningOfDateRangeUTC",BeginningOfDateRangeUTC,DbType.DateTime);
            sp.Command.AddParameter("EndOfDateRangeUTC",EndOfDateRangeUTC,DbType.DateTime);
            return sp;
        }
        public StoredProcedure GetFriendsByAppUserID(int AppUserID){
            StoredProcedure sp=new StoredProcedure("GetFriendsByAppUserID",this.Provider);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            return sp;
        }
        public StoredProcedure GetInviteeMBR(int MeetballID){
            StoredProcedure sp=new StoredProcedure("GetInviteeMBR",this.Provider);
            sp.Command.AddParameter("MeetballID",MeetballID,DbType.Int32);
            return sp;
        }
        public StoredProcedure GetInviteesTopXMB_ByAppUserID(DateTime CheckTime,int AppUserID,int TopX){
            StoredProcedure sp=new StoredProcedure("GetInviteesTopXMB_ByAppUserID",this.Provider);
            sp.Command.AddParameter("CheckTime",CheckTime,DbType.DateTime);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            sp.Command.AddParameter("TopX",TopX,DbType.Int32);
            return sp;
        }
        public StoredProcedure GetLiveBroadcastByID(int MeetballID){
            StoredProcedure sp=new StoredProcedure("GetLiveBroadcastByID",this.Provider);
            sp.Command.AddParameter("MeetballID",MeetballID,DbType.Int32);
            return sp;
        }
        public StoredProcedure GetMBInfoByHash(string MBIDHash){
            StoredProcedure sp=new StoredProcedure("GetMBInfoByHash",this.Provider);
            sp.Command.AddParameter("MBIDHash",MBIDHash,DbType.AnsiString);
            return sp;
        }
        public StoredProcedure GetMeetball(int MeetballID){
            StoredProcedure sp=new StoredProcedure("GetMeetball",this.Provider);
            sp.Command.AddParameter("MeetballID",MeetballID,DbType.Int32);
            return sp;
        }
        public StoredProcedure GetMeetballAndVenueDetails(string searchpoint,int MeetBallID){
            StoredProcedure sp=new StoredProcedure("GetMeetballAndVenueDetails",this.Provider);
            sp.Command.AddParameter("searchpoint",searchpoint,DbType.AnsiString);
            sp.Command.AddParameter("MeetBallID",MeetBallID,DbType.Int32);
            return sp;
        }
        public StoredProcedure GetMeetballURL(int MeetballID){
            StoredProcedure sp=new StoredProcedure("GetMeetballURL",this.Provider);
            sp.Command.AddParameter("MeetballID",MeetballID,DbType.Int32);
            return sp;
        }
        public StoredProcedure GetNascarUserAccounts(){
            StoredProcedure sp=new StoredProcedure("GetNascarUserAccounts",this.Provider);
            return sp;
        }
        public StoredProcedure GetPastMeetballsByAppUserID(DateTime CheckTime,int AppUserID,int TopX){
            StoredProcedure sp=new StoredProcedure("GetPastMeetballsByAppUserID",this.Provider);
            sp.Command.AddParameter("CheckTime",CheckTime,DbType.DateTime);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            sp.Command.AddParameter("TopX",TopX,DbType.Int32);
            return sp;
        }
        public StoredProcedure GetSportsTeamsByConferenceID(int ConferenceID){
            StoredProcedure sp=new StoredProcedure("GetSportsTeamsByConferenceID",this.Provider);
            sp.Command.AddParameter("ConferenceID",ConferenceID,DbType.Int32);
            return sp;
        }
        public StoredProcedure GetSportsTeamsByDivisionID(int DivisionID){
            StoredProcedure sp=new StoredProcedure("GetSportsTeamsByDivisionID",this.Provider);
            sp.Command.AddParameter("DivisionID",DivisionID,DbType.Int32);
            return sp;
        }
        public StoredProcedure GetTableList(){
            StoredProcedure sp=new StoredProcedure("GetTableList",this.Provider);
            return sp;
        }
        public StoredProcedure GetTop10MB_Future(DateTime CheckTime,int AppUserID){
            StoredProcedure sp=new StoredProcedure("GetTop10MB_Future",this.Provider);
            sp.Command.AddParameter("CheckTime",CheckTime,DbType.DateTime);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            return sp;
        }
        public StoredProcedure GetTop10MB_Past(DateTime CheckTime,int AppUserID){
            StoredProcedure sp=new StoredProcedure("GetTop10MB_Past",this.Provider);
            sp.Command.AddParameter("CheckTime",CheckTime,DbType.DateTime);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            return sp;
        }
        public StoredProcedure GetTopXMB_ByAppUserID(DateTime CheckTime,int AppUserID,int TopX){
            StoredProcedure sp=new StoredProcedure("GetTopXMB_ByAppUserID",this.Provider);
            sp.Command.AddParameter("CheckTime",CheckTime,DbType.DateTime);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            sp.Command.AddParameter("TopX",TopX,DbType.Int32);
            return sp;
        }
        public StoredProcedure GetTopXMB_ByAppUserIDV2(DateTime CheckTime,int AppUserID,int TopX){
            StoredProcedure sp=new StoredProcedure("GetTopXMB_ByAppUserIDV2",this.Provider);
            sp.Command.AddParameter("CheckTime",CheckTime,DbType.DateTime);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            sp.Command.AddParameter("TopX",TopX,DbType.Int32);
            return sp;
        }
        public StoredProcedure GetTopXMB_ByAppUserIDV2Test(DateTime CheckTime,int AppUserID,int TopX){
            StoredProcedure sp=new StoredProcedure("GetTopXMB_ByAppUserIDV2Test",this.Provider);
            sp.Command.AddParameter("CheckTime",CheckTime,DbType.DateTime);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            sp.Command.AddParameter("TopX",TopX,DbType.Int32);
            return sp;
        }
        public StoredProcedure GetTopXMB_Past(DateTime CheckTime,int AppUserID,int TopX){
            StoredProcedure sp=new StoredProcedure("GetTopXMB_Past",this.Provider);
            sp.Command.AddParameter("CheckTime",CheckTime,DbType.DateTime);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            sp.Command.AddParameter("TopX",TopX,DbType.Int32);
            return sp;
        }
        public StoredProcedure GetTwoWayCommentsByMBID(int MeetballID,int AppUser1ID,int AppUser2ID){
            StoredProcedure sp=new StoredProcedure("GetTwoWayCommentsByMBID",this.Provider);
            sp.Command.AddParameter("MeetballID",MeetballID,DbType.Int32);
            sp.Command.AddParameter("AppUser1ID",AppUser1ID,DbType.Int32);
            sp.Command.AddParameter("AppUser2ID",AppUser2ID,DbType.Int32);
            return sp;
        }
        public StoredProcedure GetUserServiceInfo(int AppUserID){
            StoredProcedure sp=new StoredProcedure("GetUserServiceInfo",this.Provider);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            return sp;
        }
        public StoredProcedure GetVenueByDistance(string searchpoint,double kmrad){
            StoredProcedure sp=new StoredProcedure("GetVenueByDistance",this.Provider);
            sp.Command.AddParameter("searchpoint",searchpoint,DbType.AnsiString);
            sp.Command.AddParameter("kmrad",kmrad,DbType.Double);
            return sp;
        }
        public StoredProcedure GetVenuesByAppUserID(int AppUserID){
            StoredProcedure sp=new StoredProcedure("GetVenuesByAppUserID",this.Provider);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            return sp;
        }
        public StoredProcedure InsertAppUserXFriendAppUser(int AppUserID,int FriendAppUserID){
            StoredProcedure sp=new StoredProcedure("InsertAppUserXFriendAppUser",this.Provider);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            sp.Command.AddParameter("FriendAppUserID",FriendAppUserID,DbType.Int32);
            return sp;
        }
        public StoredProcedure InsertAppUserXFriendAppUserPhone(int AppUserID,string Phone){
            StoredProcedure sp=new StoredProcedure("InsertAppUserXFriendAppUserPhone",this.Provider);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            sp.Command.AddParameter("Phone",Phone,DbType.AnsiString);
            return sp;
        }
        public StoredProcedure InsertCommentByAppUserID(int MeetballID,int AppUserID,string Comment){
            StoredProcedure sp=new StoredProcedure("InsertCommentByAppUserID",this.Provider);
            sp.Command.AddParameter("MeetballID",MeetballID,DbType.Int32);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            sp.Command.AddParameter("Comment",Comment,DbType.AnsiString);
            return sp;
        }
        public StoredProcedure InsertMBTrackingBroadcast(int AppUserID,DateTime UTCNow,string TrackingGPXWKT){
            StoredProcedure sp=new StoredProcedure("InsertMBTrackingBroadcast",this.Provider);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            sp.Command.AddParameter("UTCNow",UTCNow,DbType.DateTime);
            sp.Command.AddParameter("TrackingGPXWKT",TrackingGPXWKT,DbType.AnsiString);
            return sp;
        }
        public StoredProcedure InsertMessage(int ConvoID,int AppUserID,string Message){
            StoredProcedure sp=new StoredProcedure("InsertMessage",this.Provider);
            sp.Command.AddParameter("ConvoID",ConvoID,DbType.Int32);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            sp.Command.AddParameter("Message",Message,DbType.AnsiString);
            return sp;
        }
        public StoredProcedure InsertMessageByFriendID(int FromAppUserID,int ToAppUserID,string Message){
            StoredProcedure sp=new StoredProcedure("InsertMessageByFriendID",this.Provider);
            sp.Command.AddParameter("FromAppUserID",FromAppUserID,DbType.Int32);
            sp.Command.AddParameter("ToAppUserID",ToAppUserID,DbType.Int32);
            sp.Command.AddParameter("Message",Message,DbType.AnsiString);
            return sp;
        }
        public StoredProcedure InsertMessageMB(int ConvoID,int FromAppUserID,string Message,int MeetballID){
            StoredProcedure sp=new StoredProcedure("InsertMessageMB",this.Provider);
            sp.Command.AddParameter("ConvoID",ConvoID,DbType.Int32);
            sp.Command.AddParameter("FromAppUserID",FromAppUserID,DbType.Int32);
            sp.Command.AddParameter("Message",Message,DbType.AnsiString);
            sp.Command.AddParameter("MeetballID",MeetballID,DbType.Int32);
            return sp;
        }
        public StoredProcedure InsertMessageToNewUsersFromDate(DateTime JoinDate,string Message,int Sender){
            StoredProcedure sp=new StoredProcedure("InsertMessageToNewUsersFromDate",this.Provider);
            sp.Command.AddParameter("JoinDate",JoinDate,DbType.DateTime);
            sp.Command.AddParameter("Message",Message,DbType.AnsiString);
            sp.Command.AddParameter("Sender",Sender,DbType.Int32);
            return sp;
        }
        public StoredProcedure LinkByMeetcode(string Meetcode,int AppUserID){
            StoredProcedure sp=new StoredProcedure("LinkByMeetcode",this.Provider);
            sp.Command.AddParameter("Meetcode",Meetcode,DbType.AnsiString);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            return sp;
        }
        public StoredProcedure LinkFriendByHash(string Hash,int AppUserID){
            StoredProcedure sp=new StoredProcedure("LinkFriendByHash",this.Provider);
            sp.Command.AddParameter("Hash",Hash,DbType.AnsiString);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            return sp;
        }
        public StoredProcedure LinkOffPlatform(int NewAppUserID,string Phone){
            StoredProcedure sp=new StoredProcedure("LinkOffPlatform",this.Provider);
            sp.Command.AddParameter("NewAppUserID",NewAppUserID,DbType.Int32);
            sp.Command.AddParameter("Phone",Phone,DbType.AnsiString);
            return sp;
        }
        public StoredProcedure MarkConvoAsRead(int ConvoID,int AppUserID){
            StoredProcedure sp=new StoredProcedure("MarkConvoAsRead",this.Provider);
            sp.Command.AddParameter("ConvoID",ConvoID,DbType.Int32);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            return sp;
        }
        public StoredProcedure MarkMBConvoAsRead(int MeetballID,int AppUserID){
            StoredProcedure sp=new StoredProcedure("MarkMBConvoAsRead",this.Provider);
            sp.Command.AddParameter("MeetballID",MeetballID,DbType.Int32);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            return sp;
        }
        public StoredProcedure Meetball_UpdateGeneralLocation(string LocationName,string GeneralLocationAddress1,string GeneralLocationAddress2,string GeneralLocationCity,string GeneralLocationState,string GeneralLocationZip,string GeneralLocationPhone,string GeneralLocationGPXWKT,int GeneralLocationGPXTypeID,string LocationNotes,int MeetballID){
            StoredProcedure sp=new StoredProcedure("Meetball_UpdateGeneralLocation",this.Provider);
            sp.Command.AddParameter("LocationName",LocationName,DbType.AnsiString);
            sp.Command.AddParameter("GeneralLocationAddress1",GeneralLocationAddress1,DbType.AnsiString);
            sp.Command.AddParameter("GeneralLocationAddress2",GeneralLocationAddress2,DbType.AnsiString);
            sp.Command.AddParameter("GeneralLocationCity",GeneralLocationCity,DbType.AnsiString);
            sp.Command.AddParameter("GeneralLocationState",GeneralLocationState,DbType.AnsiString);
            sp.Command.AddParameter("GeneralLocationZip",GeneralLocationZip,DbType.AnsiString);
            sp.Command.AddParameter("GeneralLocationPhone",GeneralLocationPhone,DbType.AnsiString);
            sp.Command.AddParameter("GeneralLocationGPXWKT",GeneralLocationGPXWKT,DbType.AnsiString);
            sp.Command.AddParameter("GeneralLocationGPXTypeID",GeneralLocationGPXTypeID,DbType.Int32);
            sp.Command.AddParameter("LocationNotes",LocationNotes,DbType.AnsiString);
            sp.Command.AddParameter("MeetballID",MeetballID,DbType.Int32);
            return sp;
        }
        public StoredProcedure Meetball_UpdateIncrementNewUpdates(int MeetballID,int OwnerAppUserID){
            StoredProcedure sp=new StoredProcedure("Meetball_UpdateIncrementNewUpdates",this.Provider);
            sp.Command.AddParameter("MeetballID",MeetballID,DbType.Int32);
            sp.Command.AddParameter("OwnerAppUserID",OwnerAppUserID,DbType.Int32);
            return sp;
        }
        public StoredProcedure Meetball_UpdateSpecificGeneralLocation(string SpecificLocationGPXWKT,int SpecificLocationGPXTypeID,int MeetballID){
            StoredProcedure sp=new StoredProcedure("Meetball_UpdateSpecificGeneralLocation",this.Provider);
            sp.Command.AddParameter("SpecificLocationGPXWKT",SpecificLocationGPXWKT,DbType.AnsiString);
            sp.Command.AddParameter("SpecificLocationGPXTypeID",SpecificLocationGPXTypeID,DbType.Int32);
            sp.Command.AddParameter("MeetballID",MeetballID,DbType.Int32);
            return sp;
        }
        public StoredProcedure StopBroadcasts(int AppUserID){
            StoredProcedure sp=new StoredProcedure("StopBroadcasts",this.Provider);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            return sp;
        }
        public StoredProcedure UpdateAppUserXFriendAppUser(int FriendAppUserID,int AppUserID,int NewFriendAppUserID,int NewAppUserID){
            StoredProcedure sp=new StoredProcedure("UpdateAppUserXFriendAppUser",this.Provider);
            sp.Command.AddParameter("FriendAppUserID",FriendAppUserID,DbType.Int32);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            sp.Command.AddParameter("NewFriendAppUserID",NewFriendAppUserID,DbType.Int32);
            sp.Command.AddParameter("NewAppUserID",NewAppUserID,DbType.Int32);
            return sp;
        }
        public StoredProcedure UpdateMBRBroadcast(){
            StoredProcedure sp=new StoredProcedure("UpdateMBRBroadcast",this.Provider);
            return sp;
        }
        public StoredProcedure UpdateMBRExpDate(int MeetballID){
            StoredProcedure sp=new StoredProcedure("UpdateMBRExpDate",this.Provider);
            sp.Command.AddParameter("MeetballID",MeetballID,DbType.Int32);
            return sp;
        }
        public StoredProcedure UpdateVenueXAppUser(int VenueID,int AppUserID,int StatusID){
            StoredProcedure sp=new StoredProcedure("UpdateVenueXAppUser",this.Provider);
            sp.Command.AddParameter("VenueID",VenueID,DbType.Int32);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            sp.Command.AddParameter("StatusID",StatusID,DbType.Int32);
            return sp;
        }
        public StoredProcedure XReferencePhone(string Phone1,string Phone2,string Phone3,string Phone4,string Phone5,string Phone6,string Phone7,string Phone8,string Phone9,string Phone10,string Phone11,string Phone12,string Phone13,string Phone14,string Phone15,string Phone16,string Phone17,string Phone18,string Phone19,string Phone20){
            StoredProcedure sp=new StoredProcedure("XReferencePhone",this.Provider);
            sp.Command.AddParameter("Phone1",Phone1,DbType.AnsiString);
            sp.Command.AddParameter("Phone2",Phone2,DbType.AnsiString);
            sp.Command.AddParameter("Phone3",Phone3,DbType.AnsiString);
            sp.Command.AddParameter("Phone4",Phone4,DbType.AnsiString);
            sp.Command.AddParameter("Phone5",Phone5,DbType.AnsiString);
            sp.Command.AddParameter("Phone6",Phone6,DbType.AnsiString);
            sp.Command.AddParameter("Phone7",Phone7,DbType.AnsiString);
            sp.Command.AddParameter("Phone8",Phone8,DbType.AnsiString);
            sp.Command.AddParameter("Phone9",Phone9,DbType.AnsiString);
            sp.Command.AddParameter("Phone10",Phone10,DbType.AnsiString);
            sp.Command.AddParameter("Phone11",Phone11,DbType.AnsiString);
            sp.Command.AddParameter("Phone12",Phone12,DbType.AnsiString);
            sp.Command.AddParameter("Phone13",Phone13,DbType.AnsiString);
            sp.Command.AddParameter("Phone14",Phone14,DbType.AnsiString);
            sp.Command.AddParameter("Phone15",Phone15,DbType.AnsiString);
            sp.Command.AddParameter("Phone16",Phone16,DbType.AnsiString);
            sp.Command.AddParameter("Phone17",Phone17,DbType.AnsiString);
            sp.Command.AddParameter("Phone18",Phone18,DbType.AnsiString);
            sp.Command.AddParameter("Phone19",Phone19,DbType.AnsiString);
            sp.Command.AddParameter("Phone20",Phone20,DbType.AnsiString);
            return sp;
        }
        public StoredProcedure XReferencePhoneAutoFriend(int AppUserID,string Phone1,string Phone2,string Phone3,string Phone4,string Phone5,string Phone6,string Phone7,string Phone8,string Phone9,string Phone10,string Phone11,string Phone12,string Phone13,string Phone14,string Phone15,string Phone16,string Phone17,string Phone18,string Phone19,string Phone20){
            StoredProcedure sp=new StoredProcedure("XReferencePhoneAutoFriend",this.Provider);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            sp.Command.AddParameter("Phone1",Phone1,DbType.AnsiString);
            sp.Command.AddParameter("Phone2",Phone2,DbType.AnsiString);
            sp.Command.AddParameter("Phone3",Phone3,DbType.AnsiString);
            sp.Command.AddParameter("Phone4",Phone4,DbType.AnsiString);
            sp.Command.AddParameter("Phone5",Phone5,DbType.AnsiString);
            sp.Command.AddParameter("Phone6",Phone6,DbType.AnsiString);
            sp.Command.AddParameter("Phone7",Phone7,DbType.AnsiString);
            sp.Command.AddParameter("Phone8",Phone8,DbType.AnsiString);
            sp.Command.AddParameter("Phone9",Phone9,DbType.AnsiString);
            sp.Command.AddParameter("Phone10",Phone10,DbType.AnsiString);
            sp.Command.AddParameter("Phone11",Phone11,DbType.AnsiString);
            sp.Command.AddParameter("Phone12",Phone12,DbType.AnsiString);
            sp.Command.AddParameter("Phone13",Phone13,DbType.AnsiString);
            sp.Command.AddParameter("Phone14",Phone14,DbType.AnsiString);
            sp.Command.AddParameter("Phone15",Phone15,DbType.AnsiString);
            sp.Command.AddParameter("Phone16",Phone16,DbType.AnsiString);
            sp.Command.AddParameter("Phone17",Phone17,DbType.AnsiString);
            sp.Command.AddParameter("Phone18",Phone18,DbType.AnsiString);
            sp.Command.AddParameter("Phone19",Phone19,DbType.AnsiString);
            sp.Command.AddParameter("Phone20",Phone20,DbType.AnsiString);
            return sp;
        }
        public StoredProcedure XReferencePhoneAutoFriend20(int AppUserID,string Phone1,string Phone2,string Phone3,string Phone4,string Phone5,string Phone6,string Phone7,string Phone8,string Phone9,string Phone10,string Phone11,string Phone12,string Phone13,string Phone14,string Phone15,string Phone16,string Phone17,string Phone18,string Phone19,string Phone20){
            StoredProcedure sp=new StoredProcedure("XReferencePhoneAutoFriend20",this.Provider);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            sp.Command.AddParameter("Phone1",Phone1,DbType.AnsiString);
            sp.Command.AddParameter("Phone2",Phone2,DbType.AnsiString);
            sp.Command.AddParameter("Phone3",Phone3,DbType.AnsiString);
            sp.Command.AddParameter("Phone4",Phone4,DbType.AnsiString);
            sp.Command.AddParameter("Phone5",Phone5,DbType.AnsiString);
            sp.Command.AddParameter("Phone6",Phone6,DbType.AnsiString);
            sp.Command.AddParameter("Phone7",Phone7,DbType.AnsiString);
            sp.Command.AddParameter("Phone8",Phone8,DbType.AnsiString);
            sp.Command.AddParameter("Phone9",Phone9,DbType.AnsiString);
            sp.Command.AddParameter("Phone10",Phone10,DbType.AnsiString);
            sp.Command.AddParameter("Phone11",Phone11,DbType.AnsiString);
            sp.Command.AddParameter("Phone12",Phone12,DbType.AnsiString);
            sp.Command.AddParameter("Phone13",Phone13,DbType.AnsiString);
            sp.Command.AddParameter("Phone14",Phone14,DbType.AnsiString);
            sp.Command.AddParameter("Phone15",Phone15,DbType.AnsiString);
            sp.Command.AddParameter("Phone16",Phone16,DbType.AnsiString);
            sp.Command.AddParameter("Phone17",Phone17,DbType.AnsiString);
            sp.Command.AddParameter("Phone18",Phone18,DbType.AnsiString);
            sp.Command.AddParameter("Phone19",Phone19,DbType.AnsiString);
            sp.Command.AddParameter("Phone20",Phone20,DbType.AnsiString);
            return sp;
        }
        public StoredProcedure XReferencePhoneAutoFriend50(int AppUserID,string Phone1,string Phone2,string Phone3,string Phone4,string Phone5,string Phone6,string Phone7,string Phone8,string Phone9,string Phone10,string Phone11,string Phone12,string Phone13,string Phone14,string Phone15,string Phone16,string Phone17,string Phone18,string Phone19,string Phone20,string Phone21,string Phone22,string Phone23,string Phone24,string Phone25,string Phone26,string Phone27,string Phone28,string Phone29,string Phone30,string Phone31,string Phone32,string Phone33,string Phone34,string Phone35,string Phone36,string Phone37,string Phone38,string Phone39,string Phone40,string Phone41,string Phone42,string Phone43,string Phone44,string Phone45,string Phone46,string Phone47,string Phone48,string Phone49,string Phone50){
            StoredProcedure sp=new StoredProcedure("XReferencePhoneAutoFriend50",this.Provider);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            sp.Command.AddParameter("Phone1",Phone1,DbType.AnsiString);
            sp.Command.AddParameter("Phone2",Phone2,DbType.AnsiString);
            sp.Command.AddParameter("Phone3",Phone3,DbType.AnsiString);
            sp.Command.AddParameter("Phone4",Phone4,DbType.AnsiString);
            sp.Command.AddParameter("Phone5",Phone5,DbType.AnsiString);
            sp.Command.AddParameter("Phone6",Phone6,DbType.AnsiString);
            sp.Command.AddParameter("Phone7",Phone7,DbType.AnsiString);
            sp.Command.AddParameter("Phone8",Phone8,DbType.AnsiString);
            sp.Command.AddParameter("Phone9",Phone9,DbType.AnsiString);
            sp.Command.AddParameter("Phone10",Phone10,DbType.AnsiString);
            sp.Command.AddParameter("Phone11",Phone11,DbType.AnsiString);
            sp.Command.AddParameter("Phone12",Phone12,DbType.AnsiString);
            sp.Command.AddParameter("Phone13",Phone13,DbType.AnsiString);
            sp.Command.AddParameter("Phone14",Phone14,DbType.AnsiString);
            sp.Command.AddParameter("Phone15",Phone15,DbType.AnsiString);
            sp.Command.AddParameter("Phone16",Phone16,DbType.AnsiString);
            sp.Command.AddParameter("Phone17",Phone17,DbType.AnsiString);
            sp.Command.AddParameter("Phone18",Phone18,DbType.AnsiString);
            sp.Command.AddParameter("Phone19",Phone19,DbType.AnsiString);
            sp.Command.AddParameter("Phone20",Phone20,DbType.AnsiString);
            sp.Command.AddParameter("Phone21",Phone21,DbType.AnsiString);
            sp.Command.AddParameter("Phone22",Phone22,DbType.AnsiString);
            sp.Command.AddParameter("Phone23",Phone23,DbType.AnsiString);
            sp.Command.AddParameter("Phone24",Phone24,DbType.AnsiString);
            sp.Command.AddParameter("Phone25",Phone25,DbType.AnsiString);
            sp.Command.AddParameter("Phone26",Phone26,DbType.AnsiString);
            sp.Command.AddParameter("Phone27",Phone27,DbType.AnsiString);
            sp.Command.AddParameter("Phone28",Phone28,DbType.AnsiString);
            sp.Command.AddParameter("Phone29",Phone29,DbType.AnsiString);
            sp.Command.AddParameter("Phone30",Phone30,DbType.AnsiString);
            sp.Command.AddParameter("Phone31",Phone31,DbType.AnsiString);
            sp.Command.AddParameter("Phone32",Phone32,DbType.AnsiString);
            sp.Command.AddParameter("Phone33",Phone33,DbType.AnsiString);
            sp.Command.AddParameter("Phone34",Phone34,DbType.AnsiString);
            sp.Command.AddParameter("Phone35",Phone35,DbType.AnsiString);
            sp.Command.AddParameter("Phone36",Phone36,DbType.AnsiString);
            sp.Command.AddParameter("Phone37",Phone37,DbType.AnsiString);
            sp.Command.AddParameter("Phone38",Phone38,DbType.AnsiString);
            sp.Command.AddParameter("Phone39",Phone39,DbType.AnsiString);
            sp.Command.AddParameter("Phone40",Phone40,DbType.AnsiString);
            sp.Command.AddParameter("Phone41",Phone41,DbType.AnsiString);
            sp.Command.AddParameter("Phone42",Phone42,DbType.AnsiString);
            sp.Command.AddParameter("Phone43",Phone43,DbType.AnsiString);
            sp.Command.AddParameter("Phone44",Phone44,DbType.AnsiString);
            sp.Command.AddParameter("Phone45",Phone45,DbType.AnsiString);
            sp.Command.AddParameter("Phone46",Phone46,DbType.AnsiString);
            sp.Command.AddParameter("Phone47",Phone47,DbType.AnsiString);
            sp.Command.AddParameter("Phone48",Phone48,DbType.AnsiString);
            sp.Command.AddParameter("Phone49",Phone49,DbType.AnsiString);
            sp.Command.AddParameter("Phone50",Phone50,DbType.AnsiString);
            return sp;
        }
        public StoredProcedure XReferencePhoneAutoFriendTVP(int AppUserID,string TVP){
            StoredProcedure sp=new StoredProcedure("XReferencePhoneAutoFriendTVP",this.Provider);
            sp.Command.AddParameter("AppUserID",AppUserID,DbType.Int32);
            sp.Command.AddParameter("TVP",TVP,DbType.AnsiString);
            return sp;
        }
	
	}
	
}
 
#pragma warning restore 1591 