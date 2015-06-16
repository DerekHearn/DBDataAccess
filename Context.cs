


#pragma warning disable 1591 
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using SubSonic.DataProviders;
using SubSonic.Extensions;
using SubSonic.Linq.Structure;
using SubSonic.Query;
using SubSonic.Schema;
using System.Data.Common;
using System.Collections.Generic;
using System.Configuration;

namespace DBDataAccess
{
    public partial class MeetballDB : IQuerySurface
    {

        public IDataProvider DataProvider;
        public DbQueryProvider provider;
        
        public static IDataProvider DefaultDataProvider { get; set; }

        public bool TestMode
		{
            get
			{
                return DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            }
        }

        public MeetballDB() 
        {
            if (DefaultDataProvider == null) {
							
                DataProvider = ProviderFactory.GetProvider("meetball");
							
            }
            else {
                DataProvider = DefaultDataProvider;
            }
            Init();
        }

        public MeetballDB(string connectionStringName)
        {
            DataProvider = ProviderFactory.GetProvider(connectionStringName);
            Init();
        }

		public MeetballDB(string connectionString, string providerName)
        {
            DataProvider = ProviderFactory.GetProvider(connectionString,providerName);
            Init();
        }

		public ITable FindByPrimaryKey(string pkName)
        {
            return DataProvider.Schema.Tables.SingleOrDefault(x => x.PrimaryKey.Name.Equals(pkName, StringComparison.InvariantCultureIgnoreCase));
        }

        public Query<T> GetQuery<T>()
        {
            return new Query<T>(provider);
        }
        
        public ITable FindTable(string tableName)
        {
            return DataProvider.FindTable(tableName);
        }
               
        public IDataProvider Provider
        {
            get { return DataProvider; }
            set {DataProvider=value;}
        }
        
        public DbQueryProvider QueryProvider
        {
            get { return provider; }
        }
        
        BatchQuery _batch = null;
        public void Queue<T>(IQueryable<T> qry)
        {
            if (_batch == null)
                _batch = new BatchQuery(Provider, QueryProvider);
            _batch.Queue(qry);
        }

        public void Queue(ISqlQuery qry)
        {
            if (_batch == null)
                _batch = new BatchQuery(Provider, QueryProvider);
            _batch.Queue(qry);
        }

        public void ExecuteTransaction(IList<DbCommand> commands)
		{
            if(!TestMode)
			{
                using(var connection = commands[0].Connection)
				{
                   if (connection.State == ConnectionState.Closed)
                        connection.Open();
                   
                   using (var trans = connection.BeginTransaction()) 
				   {
                        foreach (var cmd in commands) 
						{
                            cmd.Transaction = trans;
                            cmd.Connection = connection;
                            cmd.ExecuteNonQuery();
                        }
                        trans.Commit();
                    }
                    connection.Close();
                }
            }
        }

        public IDataReader ExecuteBatch()
        {
            if (_batch == null)
                throw new InvalidOperationException("There's nothing in the queue");
            if(!TestMode)
                return _batch.ExecuteReader();
            return null;
        }
			
        public Query<TimeZone> TimeZones { get; set; }
        public Query<SportsType> SportsTypes { get; set; }
        public Query<NotificationAction> NotificationActions { get; set; }
        public Query<ConvoXAppUser> ConvoXAppUsers { get; set; }
        public Query<SportsEventType> SportsEventTypes { get; set; }
        public Query<Notification> Notifications { get; set; }
        public Query<AppUserActivity> AppUserActivities { get; set; }
        public Query<PhoneAppUser> PhoneAppUsers { get; set; }
        public Query<GPXType> GPXTypes { get; set; }
        public Query<Usage> Usages { get; set; }
        public Query<FriendStatus> FriendStatuses { get; set; }
        public Query<EventType> EventTypes { get; set; }
        public Query<WebAssetCollection> WebAssetCollections { get; set; }
        public Query<ContactImport> ContactImports { get; set; }
        public Query<Division> Divisions { get; set; }
        public Query<ncaaVenueImport> ncaaVenueImports { get; set; }
        public Query<SportsTeam> SportsTeams { get; set; }
        public Query<Sharing> Sharings { get; set; }
        public Query<Event> Events { get; set; }
        public Query<MeetBallVariable> MeetBallVariables { get; set; }
        public Query<FriendGroup> FriendGroups { get; set; }
        public Query<Conference> Conferences { get; set; }
        public Query<FriendGroupXFriendAppUser> FriendGroupXFriendAppUsers { get; set; }
        public Query<LocationSharing> LocationSharings { get; set; }
        public Query<AppUser> AppUsers { get; set; }
        public Query<TwitterAppUser> TwitterAppUsers { get; set; }
        public Query<Venue> Venues { get; set; }
        public Query<Response> Responses { get; set; }
        public Query<VenueLot> VenueLots { get; set; }
        public Query<AppUserDefault> AppUserDefaults { get; set; }
        public Query<VenueXAppUserStatus> VenueXAppUserStatuses { get; set; }
        public Query<SportsEvent> SportsEvents { get; set; }
        public Query<VenueXAppUser> VenueXAppUsers { get; set; }
        public Query<SportsTeamXVenue> SportsTeamXVenues { get; set; }
        public Query<WebAssetCategory> WebAssetCategories { get; set; }
        public Query<url_base> url_bases { get; set; }
        public Query<AppUserXSportsTeam> AppUserXSportsTeams { get; set; }
        public Query<Meetball> Meetballs { get; set; }
        public Query<AppUserXFriendAppUser> AppUserXFriendAppUsers { get; set; }
        public Query<EventXHashtag> EventXHashtags { get; set; }
        public Query<AppUserOffPlatform> AppUserOffPlatforms { get; set; }
        public Query<AppUserActivityLog> AppUserActivityLogs { get; set; }
        public Query<WebAssetSetting> WebAssetSettings { get; set; }
        public Query<MeetballXHashtag> MeetballXHashtags { get; set; }
        public Query<MeetballOwner> MeetballOwners { get; set; }
        public Query<AppUserXPhone> AppUserXPhones { get; set; }
        public Query<MeetballComment> MeetballComments { get; set; }
        public Query<EmailTemplate> EmailTemplates { get; set; }
        public Query<AppUserPush> AppUserPushes { get; set; }
        public Query<url_short> url_shorts { get; set; }
        public Query<AppUserPushSession> AppUserPushSessions { get; set; }
        public Query<EmailLog> EmailLogs { get; set; }
        public Query<MeetballResponseLog> MeetballResponseLogs { get; set; }
        public Query<MessageType> MessageTypes { get; set; }
        public Query<Platform> Platforms { get; set; }
        public Query<AppUserLog> AppUserLogs { get; set; }
        public Query<WebAsset> WebAssets { get; set; }
        public Query<LoginType> LoginTypes { get; set; }
        public Query<MeetballLog> MeetballLogs { get; set; }
        public Query<MeetballTracking> MeetballTrackings { get; set; }
        public Query<MeetballResponse> MeetballResponses { get; set; }
        public Query<ncaa_import> ncaa_imports { get; set; }
        public Query<FBAppUser> FBAppUsers { get; set; }
        public Query<AppSession> AppSessions { get; set; }
        public Query<MethodLog> MethodLogs { get; set; }
        public Query<Broadcast> Broadcasts { get; set; }
        public Query<MeetBallXBroadcast> MeetBallXBroadcasts { get; set; }
        public Query<MBXBroadcastTemp> MBXBroadcastTemps { get; set; }
        public Query<AppUserXNotPossibleFriendAppUser> AppUserXNotPossibleFriendAppUsers { get; set; }
        public Query<AppUserMerge> AppUserMerges { get; set; }
        public Query<EmailAppUser> EmailAppUsers { get; set; }
        public Query<MethodLogException> MethodLogExceptions { get; set; }
        public Query<AppUserPlatform> AppUserPlatforms { get; set; }
        public Query<MethodLogMBException> MethodLogMBExceptions { get; set; }
        public Query<MeetballTrackingSession> MeetballTrackingSessions { get; set; }
        public Query<ApiKey> ApiKeys { get; set; }
        public Query<MBException> MBExceptions { get; set; }
        public Query<AppDeveloper> AppDevelopers { get; set; }
        public Query<MeetballAction> MeetballActions { get; set; }
        public Query<Convo> Convos { get; set; }
        public Query<SubvenueType> SubvenueTypes { get; set; }
        public Query<Message> Messages { get; set; }
        public Query<Subvenue> Subvenues { get; set; }
        public Query<AppUserLoginLog> AppUserLoginLogs { get; set; }
        public Query<VenueType> VenueTypes { get; set; }
        public Query<MessageMB> MessageMBs { get; set; }
        public Query<TVNetwork> TVNetworks { get; set; }

			

        #region ' Aggregates and SubSonic Queries '
        public Select SelectColumns(params string[] columns)
        {
            return new Select(DataProvider, columns);
        }

        public Select Select
        {
            get { return new Select(this.Provider); }
        }

        public Insert Insert
		{
            get { return new Insert(this.Provider); }
        }

        public Update<T> Update<T>() where T:new()
		{
            return new Update<T>(this.Provider);
        }

        public SqlQuery Delete<T>(Expression<Func<T,bool>> column) where T:new()
        {
            LambdaExpression lamda = column;
            SqlQuery result = new Delete<T>(this.Provider);
            result = result.From<T>();
            result.Constraints=lamda.ParseConstraints().ToList();
            return result;
        }

        public SqlQuery Max<T>(Expression<Func<T,object>> column)
        {
            LambdaExpression lamda = column;
            string colName = lamda.ParseObjectValue();
            string objectName = typeof(T).Name;
            string tableName = DataProvider.FindTable(objectName).Name;
            return new Select(DataProvider, new Aggregate(colName, AggregateFunction.Max)).From(tableName);
        }

        public SqlQuery Min<T>(Expression<Func<T,object>> column)
        {
            LambdaExpression lamda = column;
            string colName = lamda.ParseObjectValue();
            string objectName = typeof(T).Name;
            string tableName = this.Provider.FindTable(objectName).Name;
            return new Select(this.Provider, new Aggregate(colName, AggregateFunction.Min)).From(tableName);
        }

        public SqlQuery Sum<T>(Expression<Func<T,object>> column)
        {
            LambdaExpression lamda = column;
            string colName = lamda.ParseObjectValue();
            string objectName = typeof(T).Name;
            string tableName = this.Provider.FindTable(objectName).Name;
            return new Select(this.Provider, new Aggregate(colName, AggregateFunction.Sum)).From(tableName);
        }

        public SqlQuery Avg<T>(Expression<Func<T,object>> column)
        {
            LambdaExpression lamda = column;
            string colName = lamda.ParseObjectValue();
            string objectName = typeof(T).Name;
            string tableName = this.Provider.FindTable(objectName).Name;
            return new Select(this.Provider, new Aggregate(colName, AggregateFunction.Avg)).From(tableName);
        }

        public SqlQuery Count<T>(Expression<Func<T,object>> column)
        {
            LambdaExpression lamda = column;
            string colName = lamda.ParseObjectValue();
            string objectName = typeof(T).Name;
            string tableName = this.Provider.FindTable(objectName).Name;
            return new Select(this.Provider, new Aggregate(colName, AggregateFunction.Count)).From(tableName);
        }

        public SqlQuery Variance<T>(Expression<Func<T,object>> column)
        {
            LambdaExpression lamda = column;
            string colName = lamda.ParseObjectValue();
            string objectName = typeof(T).Name;
            string tableName = this.Provider.FindTable(objectName).Name;
            return new Select(this.Provider, new Aggregate(colName, AggregateFunction.Var)).From(tableName);
        }

        public SqlQuery StandardDeviation<T>(Expression<Func<T,object>> column)
        {
            LambdaExpression lamda = column;
            string colName = lamda.ParseObjectValue();
            string objectName = typeof(T).Name;
            string tableName = this.Provider.FindTable(objectName).Name;
            return new Select(this.Provider, new Aggregate(colName, AggregateFunction.StDev)).From(tableName);
        }

        #endregion

        void Init()
        {
            provider = new DbQueryProvider(this.Provider);

            #region ' Query Defs '
            TimeZones = new Query<TimeZone>(provider);
            SportsTypes = new Query<SportsType>(provider);
            NotificationActions = new Query<NotificationAction>(provider);
            ConvoXAppUsers = new Query<ConvoXAppUser>(provider);
            SportsEventTypes = new Query<SportsEventType>(provider);
            Notifications = new Query<Notification>(provider);
            AppUserActivities = new Query<AppUserActivity>(provider);
            PhoneAppUsers = new Query<PhoneAppUser>(provider);
            GPXTypes = new Query<GPXType>(provider);
            Usages = new Query<Usage>(provider);
            FriendStatuses = new Query<FriendStatus>(provider);
            EventTypes = new Query<EventType>(provider);
            WebAssetCollections = new Query<WebAssetCollection>(provider);
            ContactImports = new Query<ContactImport>(provider);
            Divisions = new Query<Division>(provider);
            ncaaVenueImports = new Query<ncaaVenueImport>(provider);
            SportsTeams = new Query<SportsTeam>(provider);
            Sharings = new Query<Sharing>(provider);
            Events = new Query<Event>(provider);
            MeetBallVariables = new Query<MeetBallVariable>(provider);
            FriendGroups = new Query<FriendGroup>(provider);
            Conferences = new Query<Conference>(provider);
            FriendGroupXFriendAppUsers = new Query<FriendGroupXFriendAppUser>(provider);
            LocationSharings = new Query<LocationSharing>(provider);
            AppUsers = new Query<AppUser>(provider);
            TwitterAppUsers = new Query<TwitterAppUser>(provider);
            Venues = new Query<Venue>(provider);
            Responses = new Query<Response>(provider);
            VenueLots = new Query<VenueLot>(provider);
            AppUserDefaults = new Query<AppUserDefault>(provider);
            VenueXAppUserStatuses = new Query<VenueXAppUserStatus>(provider);
            SportsEvents = new Query<SportsEvent>(provider);
            VenueXAppUsers = new Query<VenueXAppUser>(provider);
            SportsTeamXVenues = new Query<SportsTeamXVenue>(provider);
            WebAssetCategories = new Query<WebAssetCategory>(provider);
            url_bases = new Query<url_base>(provider);
            AppUserXSportsTeams = new Query<AppUserXSportsTeam>(provider);
            Meetballs = new Query<Meetball>(provider);
            AppUserXFriendAppUsers = new Query<AppUserXFriendAppUser>(provider);
            EventXHashtags = new Query<EventXHashtag>(provider);
            AppUserOffPlatforms = new Query<AppUserOffPlatform>(provider);
            AppUserActivityLogs = new Query<AppUserActivityLog>(provider);
            WebAssetSettings = new Query<WebAssetSetting>(provider);
            MeetballXHashtags = new Query<MeetballXHashtag>(provider);
            MeetballOwners = new Query<MeetballOwner>(provider);
            AppUserXPhones = new Query<AppUserXPhone>(provider);
            MeetballComments = new Query<MeetballComment>(provider);
            EmailTemplates = new Query<EmailTemplate>(provider);
            AppUserPushes = new Query<AppUserPush>(provider);
            url_shorts = new Query<url_short>(provider);
            AppUserPushSessions = new Query<AppUserPushSession>(provider);
            EmailLogs = new Query<EmailLog>(provider);
            MeetballResponseLogs = new Query<MeetballResponseLog>(provider);
            MessageTypes = new Query<MessageType>(provider);
            Platforms = new Query<Platform>(provider);
            AppUserLogs = new Query<AppUserLog>(provider);
            WebAssets = new Query<WebAsset>(provider);
            LoginTypes = new Query<LoginType>(provider);
            MeetballLogs = new Query<MeetballLog>(provider);
            MeetballTrackings = new Query<MeetballTracking>(provider);
            MeetballResponses = new Query<MeetballResponse>(provider);
            ncaa_imports = new Query<ncaa_import>(provider);
            FBAppUsers = new Query<FBAppUser>(provider);
            AppSessions = new Query<AppSession>(provider);
            MethodLogs = new Query<MethodLog>(provider);
            Broadcasts = new Query<Broadcast>(provider);
            MeetBallXBroadcasts = new Query<MeetBallXBroadcast>(provider);
            MBXBroadcastTemps = new Query<MBXBroadcastTemp>(provider);
            AppUserXNotPossibleFriendAppUsers = new Query<AppUserXNotPossibleFriendAppUser>(provider);
            AppUserMerges = new Query<AppUserMerge>(provider);
            EmailAppUsers = new Query<EmailAppUser>(provider);
            MethodLogExceptions = new Query<MethodLogException>(provider);
            AppUserPlatforms = new Query<AppUserPlatform>(provider);
            MethodLogMBExceptions = new Query<MethodLogMBException>(provider);
            MeetballTrackingSessions = new Query<MeetballTrackingSession>(provider);
            ApiKeys = new Query<ApiKey>(provider);
            MBExceptions = new Query<MBException>(provider);
            AppDevelopers = new Query<AppDeveloper>(provider);
            MeetballActions = new Query<MeetballAction>(provider);
            Convos = new Query<Convo>(provider);
            SubvenueTypes = new Query<SubvenueType>(provider);
            Messages = new Query<Message>(provider);
            Subvenues = new Query<Subvenue>(provider);
            AppUserLoginLogs = new Query<AppUserLoginLog>(provider);
            VenueTypes = new Query<VenueType>(provider);
            MessageMBs = new Query<MessageMB>(provider);
            TVNetworks = new Query<TVNetwork>(provider);
            #endregion


            #region ' Schemas '
        	if(DataProvider.Schema.Tables.Count == 0)
			{
            	DataProvider.Schema.Tables.Add(new TimeZoneTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new SportsTypeTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new NotificationActionTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new ConvoXAppUserTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new SportsEventTypeTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new NotificationTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new AppUserActivityTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new PhoneAppUserTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new GPXTypeTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new UsageTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new FriendStatusTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new EventTypeTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new WebAssetCollectionTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new ContactImportTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new DivisionTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new ncaaVenueImportTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new SportsTeamTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new SharingTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new EventTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new MeetBallVariableTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new FriendGroupTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new ConferenceTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new FriendGroupXFriendAppUserTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new LocationSharingTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new AppUserTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TwitterAppUserTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new VenueTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new ResponseTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new VenueLotTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new AppUserDefaultTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new VenueXAppUserStatusTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new SportsEventTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new VenueXAppUserTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new SportsTeamXVenueTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new WebAssetCategoryTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new url_baseTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new AppUserXSportsTeamTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new MeetballTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new AppUserXFriendAppUserTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new EventXHashtagTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new AppUserOffPlatformTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new AppUserActivityLogTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new WebAssetSettingTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new MeetballXHashtagTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new MeetballOwnerTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new AppUserXPhoneTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new MeetballCommentTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new EmailTemplateTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new AppUserPushTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new url_shortTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new AppUserPushSessionTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new EmailLogTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new MeetballResponseLogTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new MessageTypeTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new PlatformTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new AppUserLogTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new WebAssetTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new LoginTypeTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new MeetballLogTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new MeetballTrackingTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new MeetballResponseTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new ncaa_importTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new FBAppUserTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new AppSessionTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new MethodLogTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new BroadcastTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new MeetBallXBroadcastTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new MBXBroadcastTempTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new AppUserXNotPossibleFriendAppUserTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new AppUserMergeTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new EmailAppUserTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new MethodLogExceptionTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new AppUserPlatformTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new MethodLogMBExceptionTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new MeetballTrackingSessionTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new ApiKeyTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new MBExceptionTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new AppDeveloperTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new MeetballActionTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new ConvoTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new SubvenueTypeTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new MessageTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new SubvenueTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new AppUserLoginLogTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new VenueTypeTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new MessageMBTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TVNetworkTable(DataProvider));
            }
            #endregion
        }
        

        #region ' Helpers '
            
        internal static DateTime DateTimeNowTruncatedDownToSecond() {
            var now = DateTime.Now;
            return now.AddTicks(-now.Ticks % TimeSpan.TicksPerSecond);
        }

        #endregion

    }
}
#pragma warning restore 1591 