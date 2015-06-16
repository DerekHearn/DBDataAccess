


#pragma warning disable 1591 
using System;
using SubSonic.Schema;
using System.Collections.Generic;
using SubSonic.DataProviders;
using System.Data;

namespace DBDataAccess {
	
        /// <summary>
        /// Table: TimeZone
        /// Primary Key: TimeZoneID
        /// </summary>

        public class TimeZoneTable: DatabaseTable {
            
            public TimeZoneTable(IDataProvider provider):base("TimeZone",provider){
                ClassName = "TimeZone";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("TimeZoneID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("TimeZoneAbbreviation", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("TimeZoneName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("VarianceFromGMT", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn TimeZoneID{
                get{
                    return this.GetColumn("TimeZoneID");
                }
            }
				
   			public static string TimeZoneIDColumn{
			      get{
        			return "TimeZoneID";
      			}
		    }
            
            public IColumn TimeZoneAbbreviation{
                get{
                    return this.GetColumn("TimeZoneAbbreviation");
                }
            }
				
   			public static string TimeZoneAbbreviationColumn{
			      get{
        			return "TimeZoneAbbreviation";
      			}
		    }
            
            public IColumn TimeZoneName{
                get{
                    return this.GetColumn("TimeZoneName");
                }
            }
				
   			public static string TimeZoneNameColumn{
			      get{
        			return "TimeZoneName";
      			}
		    }
            
            public IColumn VarianceFromGMT{
                get{
                    return this.GetColumn("VarianceFromGMT");
                }
            }
				
   			public static string VarianceFromGMTColumn{
			      get{
        			return "VarianceFromGMT";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: SportsType
        /// Primary Key: SportsTypeID
        /// </summary>

        public class SportsTypeTable: DatabaseTable {
            
            public SportsTypeTable(IDataProvider provider):base("SportsType",provider){
                ClassName = "SportsType";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("SportsTypeID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SportsTypeName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("StatusID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreateDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifyDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn SportsTypeID{
                get{
                    return this.GetColumn("SportsTypeID");
                }
            }
				
   			public static string SportsTypeIDColumn{
			      get{
        			return "SportsTypeID";
      			}
		    }
            
            public IColumn SportsTypeName{
                get{
                    return this.GetColumn("SportsTypeName");
                }
            }
				
   			public static string SportsTypeNameColumn{
			      get{
        			return "SportsTypeName";
      			}
		    }
            
            public IColumn StatusID{
                get{
                    return this.GetColumn("StatusID");
                }
            }
				
   			public static string StatusIDColumn{
			      get{
        			return "StatusID";
      			}
		    }
            
            public IColumn CreateDate{
                get{
                    return this.GetColumn("CreateDate");
                }
            }
				
   			public static string CreateDateColumn{
			      get{
        			return "CreateDate";
      			}
		    }
            
            public IColumn ModifyDate{
                get{
                    return this.GetColumn("ModifyDate");
                }
            }
				
   			public static string ModifyDateColumn{
			      get{
        			return "ModifyDate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: NotificationAction
        /// Primary Key: NotificationActionID
        /// </summary>

        public class NotificationActionTable: DatabaseTable {
            
            public NotificationActionTable(IDataProvider provider):base("NotificationAction",provider){
                ClassName = "NotificationAction";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("NotificationActionID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("NotificationActionName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });
                    
                
                
            }

            public IColumn NotificationActionID{
                get{
                    return this.GetColumn("NotificationActionID");
                }
            }
				
   			public static string NotificationActionIDColumn{
			      get{
        			return "NotificationActionID";
      			}
		    }
            
            public IColumn NotificationActionName{
                get{
                    return this.GetColumn("NotificationActionName");
                }
            }
				
   			public static string NotificationActionNameColumn{
			      get{
        			return "NotificationActionName";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: ConvoXAppUser
        /// Primary Key: AppUserID
        /// </summary>

        public class ConvoXAppUserTable: DatabaseTable {
            
            public ConvoXAppUserTable(IDataProvider provider):base("ConvoXAppUser",provider){
                ClassName = "ConvoXAppUser";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ConvoID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AppUserID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ToRead", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("LastMessageDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn ConvoID{
                get{
                    return this.GetColumn("ConvoID");
                }
            }
				
   			public static string ConvoIDColumn{
			      get{
        			return "ConvoID";
      			}
		    }
            
            public IColumn AppUserID{
                get{
                    return this.GetColumn("AppUserID");
                }
            }
				
   			public static string AppUserIDColumn{
			      get{
        			return "AppUserID";
      			}
		    }
            
            public IColumn ToRead{
                get{
                    return this.GetColumn("ToRead");
                }
            }
				
   			public static string ToReadColumn{
			      get{
        			return "ToRead";
      			}
		    }
            
            public IColumn LastMessageDate{
                get{
                    return this.GetColumn("LastMessageDate");
                }
            }
				
   			public static string LastMessageDateColumn{
			      get{
        			return "LastMessageDate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: SportsEventType
        /// Primary Key: SportsEventTypeID
        /// </summary>

        public class SportsEventTypeTable: DatabaseTable {
            
            public SportsEventTypeTable(IDataProvider provider):base("SportsEventType",provider){
                ClassName = "SportsEventType";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("SportsEventTypeID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SportsEventTypeName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("StatusID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreateDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifyDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn SportsEventTypeID{
                get{
                    return this.GetColumn("SportsEventTypeID");
                }
            }
				
   			public static string SportsEventTypeIDColumn{
			      get{
        			return "SportsEventTypeID";
      			}
		    }
            
            public IColumn SportsEventTypeName{
                get{
                    return this.GetColumn("SportsEventTypeName");
                }
            }
				
   			public static string SportsEventTypeNameColumn{
			      get{
        			return "SportsEventTypeName";
      			}
		    }
            
            public IColumn StatusID{
                get{
                    return this.GetColumn("StatusID");
                }
            }
				
   			public static string StatusIDColumn{
			      get{
        			return "StatusID";
      			}
		    }
            
            public IColumn CreateDate{
                get{
                    return this.GetColumn("CreateDate");
                }
            }
				
   			public static string CreateDateColumn{
			      get{
        			return "CreateDate";
      			}
		    }
            
            public IColumn ModifyDate{
                get{
                    return this.GetColumn("ModifyDate");
                }
            }
				
   			public static string ModifyDateColumn{
			      get{
        			return "ModifyDate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: Notification
        /// Primary Key: NotificationID
        /// </summary>

        public class NotificationTable: DatabaseTable {
            
            public NotificationTable(IDataProvider provider):base("Notification",provider){
                ClassName = "Notification";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("NotificationID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AppUserID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsRead", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("NotificationActionID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("NotificationDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("NotificationTitle", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("NotificationBody", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });

                Columns.Add(new DatabaseColumn("NotificationAppUserID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("NotificationMeetballID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn NotificationID{
                get{
                    return this.GetColumn("NotificationID");
                }
            }
				
   			public static string NotificationIDColumn{
			      get{
        			return "NotificationID";
      			}
		    }
            
            public IColumn AppUserID{
                get{
                    return this.GetColumn("AppUserID");
                }
            }
				
   			public static string AppUserIDColumn{
			      get{
        			return "AppUserID";
      			}
		    }
            
            public IColumn IsRead{
                get{
                    return this.GetColumn("IsRead");
                }
            }
				
   			public static string IsReadColumn{
			      get{
        			return "IsRead";
      			}
		    }
            
            public IColumn NotificationActionID{
                get{
                    return this.GetColumn("NotificationActionID");
                }
            }
				
   			public static string NotificationActionIDColumn{
			      get{
        			return "NotificationActionID";
      			}
		    }
            
            public IColumn NotificationDate{
                get{
                    return this.GetColumn("NotificationDate");
                }
            }
				
   			public static string NotificationDateColumn{
			      get{
        			return "NotificationDate";
      			}
		    }
            
            public IColumn NotificationTitle{
                get{
                    return this.GetColumn("NotificationTitle");
                }
            }
				
   			public static string NotificationTitleColumn{
			      get{
        			return "NotificationTitle";
      			}
		    }
            
            public IColumn NotificationBody{
                get{
                    return this.GetColumn("NotificationBody");
                }
            }
				
   			public static string NotificationBodyColumn{
			      get{
        			return "NotificationBody";
      			}
		    }
            
            public IColumn NotificationAppUserID{
                get{
                    return this.GetColumn("NotificationAppUserID");
                }
            }
				
   			public static string NotificationAppUserIDColumn{
			      get{
        			return "NotificationAppUserID";
      			}
		    }
            
            public IColumn NotificationMeetballID{
                get{
                    return this.GetColumn("NotificationMeetballID");
                }
            }
				
   			public static string NotificationMeetballIDColumn{
			      get{
        			return "NotificationMeetballID";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: AppUserActivity
        /// Primary Key: AppUserActivityID
        /// </summary>

        public class AppUserActivityTable: DatabaseTable {
            
            public AppUserActivityTable(IDataProvider provider):base("AppUserActivity",provider){
                ClassName = "AppUserActivity";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("AppUserActivityID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AppUserActivityName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("AppUserActivityDescription", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 300
                });

                Columns.Add(new DatabaseColumn("StatusID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreateDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifyDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn AppUserActivityID{
                get{
                    return this.GetColumn("AppUserActivityID");
                }
            }
				
   			public static string AppUserActivityIDColumn{
			      get{
        			return "AppUserActivityID";
      			}
		    }
            
            public IColumn AppUserActivityName{
                get{
                    return this.GetColumn("AppUserActivityName");
                }
            }
				
   			public static string AppUserActivityNameColumn{
			      get{
        			return "AppUserActivityName";
      			}
		    }
            
            public IColumn AppUserActivityDescription{
                get{
                    return this.GetColumn("AppUserActivityDescription");
                }
            }
				
   			public static string AppUserActivityDescriptionColumn{
			      get{
        			return "AppUserActivityDescription";
      			}
		    }
            
            public IColumn StatusID{
                get{
                    return this.GetColumn("StatusID");
                }
            }
				
   			public static string StatusIDColumn{
			      get{
        			return "StatusID";
      			}
		    }
            
            public IColumn CreateDate{
                get{
                    return this.GetColumn("CreateDate");
                }
            }
				
   			public static string CreateDateColumn{
			      get{
        			return "CreateDate";
      			}
		    }
            
            public IColumn ModifyDate{
                get{
                    return this.GetColumn("ModifyDate");
                }
            }
				
   			public static string ModifyDateColumn{
			      get{
        			return "ModifyDate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: PhoneAppUser
        /// Primary Key: PhoneAppUserId
        /// </summary>

        public class PhoneAppUserTable: DatabaseTable {
            
            public PhoneAppUserTable(IDataProvider provider):base("PhoneAppUser",provider){
                ClassName = "PhoneAppUser";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("PhoneAppUserId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AppUserId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Phone", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("StatusId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreateDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifyDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn PhoneAppUserId{
                get{
                    return this.GetColumn("PhoneAppUserId");
                }
            }
				
   			public static string PhoneAppUserIdColumn{
			      get{
        			return "PhoneAppUserId";
      			}
		    }
            
            public IColumn AppUserId{
                get{
                    return this.GetColumn("AppUserId");
                }
            }
				
   			public static string AppUserIdColumn{
			      get{
        			return "AppUserId";
      			}
		    }
            
            public IColumn Phone{
                get{
                    return this.GetColumn("Phone");
                }
            }
				
   			public static string PhoneColumn{
			      get{
        			return "Phone";
      			}
		    }
            
            public IColumn StatusId{
                get{
                    return this.GetColumn("StatusId");
                }
            }
				
   			public static string StatusIdColumn{
			      get{
        			return "StatusId";
      			}
		    }
            
            public IColumn CreateDate{
                get{
                    return this.GetColumn("CreateDate");
                }
            }
				
   			public static string CreateDateColumn{
			      get{
        			return "CreateDate";
      			}
		    }
            
            public IColumn ModifyDate{
                get{
                    return this.GetColumn("ModifyDate");
                }
            }
				
   			public static string ModifyDateColumn{
			      get{
        			return "ModifyDate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: GPXType
        /// Primary Key: GPXTypeID
        /// </summary>

        public class GPXTypeTable: DatabaseTable {
            
            public GPXTypeTable(IDataProvider provider):base("GPXType",provider){
                ClassName = "GPXType";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("GPXTypeID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("GPXTypeName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("StatusID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreateDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifyDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn GPXTypeID{
                get{
                    return this.GetColumn("GPXTypeID");
                }
            }
				
   			public static string GPXTypeIDColumn{
			      get{
        			return "GPXTypeID";
      			}
		    }
            
            public IColumn GPXTypeName{
                get{
                    return this.GetColumn("GPXTypeName");
                }
            }
				
   			public static string GPXTypeNameColumn{
			      get{
        			return "GPXTypeName";
      			}
		    }
            
            public IColumn StatusID{
                get{
                    return this.GetColumn("StatusID");
                }
            }
				
   			public static string StatusIDColumn{
			      get{
        			return "StatusID";
      			}
		    }
            
            public IColumn CreateDate{
                get{
                    return this.GetColumn("CreateDate");
                }
            }
				
   			public static string CreateDateColumn{
			      get{
        			return "CreateDate";
      			}
		    }
            
            public IColumn ModifyDate{
                get{
                    return this.GetColumn("ModifyDate");
                }
            }
				
   			public static string ModifyDateColumn{
			      get{
        			return "ModifyDate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: Usage
        /// Primary Key: UsageId
        /// </summary>

        public class UsageTable: DatabaseTable {
            
            public UsageTable(IDataProvider provider):base("Usage",provider){
                ClassName = "Usage";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("UsageId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("UsageName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });
                    
                
                
            }

            public IColumn UsageId{
                get{
                    return this.GetColumn("UsageId");
                }
            }
				
   			public static string UsageIdColumn{
			      get{
        			return "UsageId";
      			}
		    }
            
            public IColumn UsageName{
                get{
                    return this.GetColumn("UsageName");
                }
            }
				
   			public static string UsageNameColumn{
			      get{
        			return "UsageName";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: FriendStatus
        /// Primary Key: FriendStatusID
        /// </summary>

        public class FriendStatusTable: DatabaseTable {
            
            public FriendStatusTable(IDataProvider provider):base("FriendStatus",provider){
                ClassName = "FriendStatus";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("FriendStatusID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("FriendStatusName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("StatusID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreateDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifyDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn FriendStatusID{
                get{
                    return this.GetColumn("FriendStatusID");
                }
            }
				
   			public static string FriendStatusIDColumn{
			      get{
        			return "FriendStatusID";
      			}
		    }
            
            public IColumn FriendStatusName{
                get{
                    return this.GetColumn("FriendStatusName");
                }
            }
				
   			public static string FriendStatusNameColumn{
			      get{
        			return "FriendStatusName";
      			}
		    }
            
            public IColumn StatusID{
                get{
                    return this.GetColumn("StatusID");
                }
            }
				
   			public static string StatusIDColumn{
			      get{
        			return "StatusID";
      			}
		    }
            
            public IColumn CreateDate{
                get{
                    return this.GetColumn("CreateDate");
                }
            }
				
   			public static string CreateDateColumn{
			      get{
        			return "CreateDate";
      			}
		    }
            
            public IColumn ModifyDate{
                get{
                    return this.GetColumn("ModifyDate");
                }
            }
				
   			public static string ModifyDateColumn{
			      get{
        			return "ModifyDate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: EventType
        /// Primary Key: EventTypeID
        /// </summary>

        public class EventTypeTable: DatabaseTable {
            
            public EventTypeTable(IDataProvider provider):base("EventType",provider){
                ClassName = "EventType";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("EventTypeID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("EventTypeName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("EventTypeAbbr", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 20
                });

                Columns.Add(new DatabaseColumn("EventNameReplacement", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("StatusID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreateDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifyDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn EventTypeID{
                get{
                    return this.GetColumn("EventTypeID");
                }
            }
				
   			public static string EventTypeIDColumn{
			      get{
        			return "EventTypeID";
      			}
		    }
            
            public IColumn EventTypeName{
                get{
                    return this.GetColumn("EventTypeName");
                }
            }
				
   			public static string EventTypeNameColumn{
			      get{
        			return "EventTypeName";
      			}
		    }
            
            public IColumn EventTypeAbbr{
                get{
                    return this.GetColumn("EventTypeAbbr");
                }
            }
				
   			public static string EventTypeAbbrColumn{
			      get{
        			return "EventTypeAbbr";
      			}
		    }
            
            public IColumn EventNameReplacement{
                get{
                    return this.GetColumn("EventNameReplacement");
                }
            }
				
   			public static string EventNameReplacementColumn{
			      get{
        			return "EventNameReplacement";
      			}
		    }
            
            public IColumn StatusID{
                get{
                    return this.GetColumn("StatusID");
                }
            }
				
   			public static string StatusIDColumn{
			      get{
        			return "StatusID";
      			}
		    }
            
            public IColumn CreateDate{
                get{
                    return this.GetColumn("CreateDate");
                }
            }
				
   			public static string CreateDateColumn{
			      get{
        			return "CreateDate";
      			}
		    }
            
            public IColumn ModifyDate{
                get{
                    return this.GetColumn("ModifyDate");
                }
            }
				
   			public static string ModifyDateColumn{
			      get{
        			return "ModifyDate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: WebAssetCollection
        /// Primary Key: WebAssetCollectionId
        /// </summary>

        public class WebAssetCollectionTable: DatabaseTable {
            
            public WebAssetCollectionTable(IDataProvider provider):base("WebAssetCollection",provider){
                ClassName = "WebAssetCollection";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("WebAssetCollectionId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("WebAssetCollectionName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });

                Columns.Add(new DatabaseColumn("Description", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });
                    
                
                
            }

            public IColumn WebAssetCollectionId{
                get{
                    return this.GetColumn("WebAssetCollectionId");
                }
            }
				
   			public static string WebAssetCollectionIdColumn{
			      get{
        			return "WebAssetCollectionId";
      			}
		    }
            
            public IColumn WebAssetCollectionName{
                get{
                    return this.GetColumn("WebAssetCollectionName");
                }
            }
				
   			public static string WebAssetCollectionNameColumn{
			      get{
        			return "WebAssetCollectionName";
      			}
		    }
            
            public IColumn Description{
                get{
                    return this.GetColumn("Description");
                }
            }
				
   			public static string DescriptionColumn{
			      get{
        			return "Description";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: ContactImport
        /// Primary Key: ContactImportID
        /// </summary>

        public class ContactImportTable: DatabaseTable {
            
            public ContactImportTable(IDataProvider provider):base("ContactImport",provider){
                ClassName = "ContactImport";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ContactImportID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("BatchID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ImportAppUserID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("DisplayName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("TwitterHandle", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 300
                });

                Columns.Add(new DatabaseColumn("Phone", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("StatusID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreateDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn ContactImportID{
                get{
                    return this.GetColumn("ContactImportID");
                }
            }
				
   			public static string ContactImportIDColumn{
			      get{
        			return "ContactImportID";
      			}
		    }
            
            public IColumn BatchID{
                get{
                    return this.GetColumn("BatchID");
                }
            }
				
   			public static string BatchIDColumn{
			      get{
        			return "BatchID";
      			}
		    }
            
            public IColumn ImportAppUserID{
                get{
                    return this.GetColumn("ImportAppUserID");
                }
            }
				
   			public static string ImportAppUserIDColumn{
			      get{
        			return "ImportAppUserID";
      			}
		    }
            
            public IColumn DisplayName{
                get{
                    return this.GetColumn("DisplayName");
                }
            }
				
   			public static string DisplayNameColumn{
			      get{
        			return "DisplayName";
      			}
		    }
            
            public IColumn TwitterHandle{
                get{
                    return this.GetColumn("TwitterHandle");
                }
            }
				
   			public static string TwitterHandleColumn{
			      get{
        			return "TwitterHandle";
      			}
		    }
            
            public IColumn Phone{
                get{
                    return this.GetColumn("Phone");
                }
            }
				
   			public static string PhoneColumn{
			      get{
        			return "Phone";
      			}
		    }
            
            public IColumn StatusID{
                get{
                    return this.GetColumn("StatusID");
                }
            }
				
   			public static string StatusIDColumn{
			      get{
        			return "StatusID";
      			}
		    }
            
            public IColumn CreateDate{
                get{
                    return this.GetColumn("CreateDate");
                }
            }
				
   			public static string CreateDateColumn{
			      get{
        			return "CreateDate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: Division
        /// Primary Key: DivisionID
        /// </summary>

        public class DivisionTable: DatabaseTable {
            
            public DivisionTable(IDataProvider provider):base("Division",provider){
                ClassName = "Division";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("DivisionID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("DivisionName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("StatusID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreateDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifyDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SportsTypeID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn DivisionID{
                get{
                    return this.GetColumn("DivisionID");
                }
            }
				
   			public static string DivisionIDColumn{
			      get{
        			return "DivisionID";
      			}
		    }
            
            public IColumn DivisionName{
                get{
                    return this.GetColumn("DivisionName");
                }
            }
				
   			public static string DivisionNameColumn{
			      get{
        			return "DivisionName";
      			}
		    }
            
            public IColumn StatusID{
                get{
                    return this.GetColumn("StatusID");
                }
            }
				
   			public static string StatusIDColumn{
			      get{
        			return "StatusID";
      			}
		    }
            
            public IColumn CreateDate{
                get{
                    return this.GetColumn("CreateDate");
                }
            }
				
   			public static string CreateDateColumn{
			      get{
        			return "CreateDate";
      			}
		    }
            
            public IColumn ModifyDate{
                get{
                    return this.GetColumn("ModifyDate");
                }
            }
				
   			public static string ModifyDateColumn{
			      get{
        			return "ModifyDate";
      			}
		    }
            
            public IColumn SportsTypeID{
                get{
                    return this.GetColumn("SportsTypeID");
                }
            }
				
   			public static string SportsTypeIDColumn{
			      get{
        			return "SportsTypeID";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: ncaaVenueImport
        /// Primary Key: 
        /// </summary>

        public class ncaaVenueImportTable: DatabaseTable {
            
            public ncaaVenueImportTable(IDataProvider provider):base("ncaaVenueImport",provider){
                ClassName = "ncaaVenueImport";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("Team", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Venue", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("StreetAddress", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("City", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("State", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("ZipCode", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("GPSLocation", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("IndexofComma", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Double,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("LengthofText", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Double,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("GPSLat", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("GPSLong", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("PointLongLatAlt", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Capacity", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Double,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn Team{
                get{
                    return this.GetColumn("Team");
                }
            }
				
   			public static string TeamColumn{
			      get{
        			return "Team";
      			}
		    }
            
            public IColumn Venue{
                get{
                    return this.GetColumn("Venue");
                }
            }
				
   			public static string VenueColumn{
			      get{
        			return "Venue";
      			}
		    }
            
            public IColumn StreetAddress{
                get{
                    return this.GetColumn("StreetAddress");
                }
            }
				
   			public static string StreetAddressColumn{
			      get{
        			return "StreetAddress";
      			}
		    }
            
            public IColumn City{
                get{
                    return this.GetColumn("City");
                }
            }
				
   			public static string CityColumn{
			      get{
        			return "City";
      			}
		    }
            
            public IColumn State{
                get{
                    return this.GetColumn("State");
                }
            }
				
   			public static string StateColumn{
			      get{
        			return "State";
      			}
		    }
            
            public IColumn ZipCode{
                get{
                    return this.GetColumn("ZipCode");
                }
            }
				
   			public static string ZipCodeColumn{
			      get{
        			return "ZipCode";
      			}
		    }
            
            public IColumn GPSLocation{
                get{
                    return this.GetColumn("GPSLocation");
                }
            }
				
   			public static string GPSLocationColumn{
			      get{
        			return "GPSLocation";
      			}
		    }
            
            public IColumn IndexofComma{
                get{
                    return this.GetColumn("IndexofComma");
                }
            }
				
   			public static string IndexofCommaColumn{
			      get{
        			return "IndexofComma";
      			}
		    }
            
            public IColumn LengthofText{
                get{
                    return this.GetColumn("LengthofText");
                }
            }
				
   			public static string LengthofTextColumn{
			      get{
        			return "LengthofText";
      			}
		    }
            
            public IColumn GPSLat{
                get{
                    return this.GetColumn("GPSLat");
                }
            }
				
   			public static string GPSLatColumn{
			      get{
        			return "GPSLat";
      			}
		    }
            
            public IColumn GPSLong{
                get{
                    return this.GetColumn("GPSLong");
                }
            }
				
   			public static string GPSLongColumn{
			      get{
        			return "GPSLong";
      			}
		    }
            
            public IColumn PointLongLatAlt{
                get{
                    return this.GetColumn("PointLongLatAlt");
                }
            }
				
   			public static string PointLongLatAltColumn{
			      get{
        			return "PointLongLatAlt";
      			}
		    }
            
            public IColumn Capacity{
                get{
                    return this.GetColumn("Capacity");
                }
            }
				
   			public static string CapacityColumn{
			      get{
        			return "Capacity";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: SportsTeam
        /// Primary Key: SportsTeamID
        /// </summary>

        public class SportsTeamTable: DatabaseTable {
            
            public SportsTeamTable(IDataProvider provider):base("SportsTeam",provider){
                ClassName = "SportsTeam";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("SportsTeamID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SportsTeamLocation", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("SportsTeamName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("SportsTeamAbbr", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 20
                });

                Columns.Add(new DatabaseColumn("DivisionID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Mascot", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("StatusID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreateDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifyDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SportsTypeID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ConferenceID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn SportsTeamID{
                get{
                    return this.GetColumn("SportsTeamID");
                }
            }
				
   			public static string SportsTeamIDColumn{
			      get{
        			return "SportsTeamID";
      			}
		    }
            
            public IColumn SportsTeamLocation{
                get{
                    return this.GetColumn("SportsTeamLocation");
                }
            }
				
   			public static string SportsTeamLocationColumn{
			      get{
        			return "SportsTeamLocation";
      			}
		    }
            
            public IColumn SportsTeamName{
                get{
                    return this.GetColumn("SportsTeamName");
                }
            }
				
   			public static string SportsTeamNameColumn{
			      get{
        			return "SportsTeamName";
      			}
		    }
            
            public IColumn SportsTeamAbbr{
                get{
                    return this.GetColumn("SportsTeamAbbr");
                }
            }
				
   			public static string SportsTeamAbbrColumn{
			      get{
        			return "SportsTeamAbbr";
      			}
		    }
            
            public IColumn DivisionID{
                get{
                    return this.GetColumn("DivisionID");
                }
            }
				
   			public static string DivisionIDColumn{
			      get{
        			return "DivisionID";
      			}
		    }
            
            public IColumn Mascot{
                get{
                    return this.GetColumn("Mascot");
                }
            }
				
   			public static string MascotColumn{
			      get{
        			return "Mascot";
      			}
		    }
            
            public IColumn StatusID{
                get{
                    return this.GetColumn("StatusID");
                }
            }
				
   			public static string StatusIDColumn{
			      get{
        			return "StatusID";
      			}
		    }
            
            public IColumn CreateDate{
                get{
                    return this.GetColumn("CreateDate");
                }
            }
				
   			public static string CreateDateColumn{
			      get{
        			return "CreateDate";
      			}
		    }
            
            public IColumn ModifyDate{
                get{
                    return this.GetColumn("ModifyDate");
                }
            }
				
   			public static string ModifyDateColumn{
			      get{
        			return "ModifyDate";
      			}
		    }
            
            public IColumn SportsTypeID{
                get{
                    return this.GetColumn("SportsTypeID");
                }
            }
				
   			public static string SportsTypeIDColumn{
			      get{
        			return "SportsTypeID";
      			}
		    }
            
            public IColumn ConferenceID{
                get{
                    return this.GetColumn("ConferenceID");
                }
            }
				
   			public static string ConferenceIDColumn{
			      get{
        			return "ConferenceID";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: Sharing
        /// Primary Key: SharingID
        /// </summary>

        public class SharingTable: DatabaseTable {
            
            public SharingTable(IDataProvider provider):base("Sharing",provider){
                ClassName = "Sharing";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("SharingID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SharingName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("StatusID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreateDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifyDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn SharingID{
                get{
                    return this.GetColumn("SharingID");
                }
            }
				
   			public static string SharingIDColumn{
			      get{
        			return "SharingID";
      			}
		    }
            
            public IColumn SharingName{
                get{
                    return this.GetColumn("SharingName");
                }
            }
				
   			public static string SharingNameColumn{
			      get{
        			return "SharingName";
      			}
		    }
            
            public IColumn StatusID{
                get{
                    return this.GetColumn("StatusID");
                }
            }
				
   			public static string StatusIDColumn{
			      get{
        			return "StatusID";
      			}
		    }
            
            public IColumn CreateDate{
                get{
                    return this.GetColumn("CreateDate");
                }
            }
				
   			public static string CreateDateColumn{
			      get{
        			return "CreateDate";
      			}
		    }
            
            public IColumn ModifyDate{
                get{
                    return this.GetColumn("ModifyDate");
                }
            }
				
   			public static string ModifyDateColumn{
			      get{
        			return "ModifyDate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: Event
        /// Primary Key: EventID
        /// </summary>

        public class EventTable: DatabaseTable {
            
            public EventTable(IDataProvider provider):base("Event",provider){
                ClassName = "Event";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("EventID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("EventTypeID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("EventName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 150
                });

                Columns.Add(new DatabaseColumn("EventDescription", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 300
                });

                Columns.Add(new DatabaseColumn("EventDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("VenueID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("StatusID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreateDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifyDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn EventID{
                get{
                    return this.GetColumn("EventID");
                }
            }
				
   			public static string EventIDColumn{
			      get{
        			return "EventID";
      			}
		    }
            
            public IColumn EventTypeID{
                get{
                    return this.GetColumn("EventTypeID");
                }
            }
				
   			public static string EventTypeIDColumn{
			      get{
        			return "EventTypeID";
      			}
		    }
            
            public IColumn EventName{
                get{
                    return this.GetColumn("EventName");
                }
            }
				
   			public static string EventNameColumn{
			      get{
        			return "EventName";
      			}
		    }
            
            public IColumn EventDescription{
                get{
                    return this.GetColumn("EventDescription");
                }
            }
				
   			public static string EventDescriptionColumn{
			      get{
        			return "EventDescription";
      			}
		    }
            
            public IColumn EventDate{
                get{
                    return this.GetColumn("EventDate");
                }
            }
				
   			public static string EventDateColumn{
			      get{
        			return "EventDate";
      			}
		    }
            
            public IColumn VenueID{
                get{
                    return this.GetColumn("VenueID");
                }
            }
				
   			public static string VenueIDColumn{
			      get{
        			return "VenueID";
      			}
		    }
            
            public IColumn StatusID{
                get{
                    return this.GetColumn("StatusID");
                }
            }
				
   			public static string StatusIDColumn{
			      get{
        			return "StatusID";
      			}
		    }
            
            public IColumn CreateDate{
                get{
                    return this.GetColumn("CreateDate");
                }
            }
				
   			public static string CreateDateColumn{
			      get{
        			return "CreateDate";
      			}
		    }
            
            public IColumn ModifyDate{
                get{
                    return this.GetColumn("ModifyDate");
                }
            }
				
   			public static string ModifyDateColumn{
			      get{
        			return "ModifyDate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: MeetBallVariable
        /// Primary Key: MeetBallVariableId
        /// </summary>

        public class MeetBallVariableTable: DatabaseTable {
            
            public MeetBallVariableTable(IDataProvider provider):base("MeetBallVariable",provider){
                ClassName = "MeetBallVariable";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("MeetBallVariableId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Value", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });
                    
                
                
            }

            public IColumn MeetBallVariableId{
                get{
                    return this.GetColumn("MeetBallVariableId");
                }
            }
				
   			public static string MeetBallVariableIdColumn{
			      get{
        			return "MeetBallVariableId";
      			}
		    }
            
            public IColumn Name{
                get{
                    return this.GetColumn("Name");
                }
            }
				
   			public static string NameColumn{
			      get{
        			return "Name";
      			}
		    }
            
            public IColumn Value{
                get{
                    return this.GetColumn("Value");
                }
            }
				
   			public static string ValueColumn{
			      get{
        			return "Value";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: FriendGroup
        /// Primary Key: FriendGroupID
        /// </summary>

        public class FriendGroupTable: DatabaseTable {
            
            public FriendGroupTable(IDataProvider provider):base("FriendGroup",provider){
                ClassName = "FriendGroup";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("FriendGroupID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AppUserID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("FriendGroupName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("FriendGroupDescription", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 300
                });

                Columns.Add(new DatabaseColumn("Private", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("StatusID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreateDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifyDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn FriendGroupID{
                get{
                    return this.GetColumn("FriendGroupID");
                }
            }
				
   			public static string FriendGroupIDColumn{
			      get{
        			return "FriendGroupID";
      			}
		    }
            
            public IColumn AppUserID{
                get{
                    return this.GetColumn("AppUserID");
                }
            }
				
   			public static string AppUserIDColumn{
			      get{
        			return "AppUserID";
      			}
		    }
            
            public IColumn FriendGroupName{
                get{
                    return this.GetColumn("FriendGroupName");
                }
            }
				
   			public static string FriendGroupNameColumn{
			      get{
        			return "FriendGroupName";
      			}
		    }
            
            public IColumn FriendGroupDescription{
                get{
                    return this.GetColumn("FriendGroupDescription");
                }
            }
				
   			public static string FriendGroupDescriptionColumn{
			      get{
        			return "FriendGroupDescription";
      			}
		    }
            
            public IColumn Private{
                get{
                    return this.GetColumn("Private");
                }
            }
				
   			public static string PrivateColumn{
			      get{
        			return "Private";
      			}
		    }
            
            public IColumn StatusID{
                get{
                    return this.GetColumn("StatusID");
                }
            }
				
   			public static string StatusIDColumn{
			      get{
        			return "StatusID";
      			}
		    }
            
            public IColumn CreateDate{
                get{
                    return this.GetColumn("CreateDate");
                }
            }
				
   			public static string CreateDateColumn{
			      get{
        			return "CreateDate";
      			}
		    }
            
            public IColumn ModifyDate{
                get{
                    return this.GetColumn("ModifyDate");
                }
            }
				
   			public static string ModifyDateColumn{
			      get{
        			return "ModifyDate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: Conference
        /// Primary Key: ConferenceID
        /// </summary>

        public class ConferenceTable: DatabaseTable {
            
            public ConferenceTable(IDataProvider provider):base("Conference",provider){
                ClassName = "Conference";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ConferenceID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SportsTypeID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ConferenceName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("ConferenceAbbr", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 20
                });

                Columns.Add(new DatabaseColumn("StatusID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreateDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifyDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn ConferenceID{
                get{
                    return this.GetColumn("ConferenceID");
                }
            }
				
   			public static string ConferenceIDColumn{
			      get{
        			return "ConferenceID";
      			}
		    }
            
            public IColumn SportsTypeID{
                get{
                    return this.GetColumn("SportsTypeID");
                }
            }
				
   			public static string SportsTypeIDColumn{
			      get{
        			return "SportsTypeID";
      			}
		    }
            
            public IColumn ConferenceName{
                get{
                    return this.GetColumn("ConferenceName");
                }
            }
				
   			public static string ConferenceNameColumn{
			      get{
        			return "ConferenceName";
      			}
		    }
            
            public IColumn ConferenceAbbr{
                get{
                    return this.GetColumn("ConferenceAbbr");
                }
            }
				
   			public static string ConferenceAbbrColumn{
			      get{
        			return "ConferenceAbbr";
      			}
		    }
            
            public IColumn StatusID{
                get{
                    return this.GetColumn("StatusID");
                }
            }
				
   			public static string StatusIDColumn{
			      get{
        			return "StatusID";
      			}
		    }
            
            public IColumn CreateDate{
                get{
                    return this.GetColumn("CreateDate");
                }
            }
				
   			public static string CreateDateColumn{
			      get{
        			return "CreateDate";
      			}
		    }
            
            public IColumn ModifyDate{
                get{
                    return this.GetColumn("ModifyDate");
                }
            }
				
   			public static string ModifyDateColumn{
			      get{
        			return "ModifyDate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: FriendGroupXFriendAppUser
        /// Primary Key: FriendAppUserID
        /// </summary>

        public class FriendGroupXFriendAppUserTable: DatabaseTable {
            
            public FriendGroupXFriendAppUserTable(IDataProvider provider):base("FriendGroupXFriendAppUser",provider){
                ClassName = "FriendGroupXFriendAppUser";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("FriendGroupID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("FriendAppUserID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn FriendGroupID{
                get{
                    return this.GetColumn("FriendGroupID");
                }
            }
				
   			public static string FriendGroupIDColumn{
			      get{
        			return "FriendGroupID";
      			}
		    }
            
            public IColumn FriendAppUserID{
                get{
                    return this.GetColumn("FriendAppUserID");
                }
            }
				
   			public static string FriendAppUserIDColumn{
			      get{
        			return "FriendAppUserID";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: LocationSharing
        /// Primary Key: LocationSharingID
        /// </summary>

        public class LocationSharingTable: DatabaseTable {
            
            public LocationSharingTable(IDataProvider provider):base("LocationSharing",provider){
                ClassName = "LocationSharing";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("LocationSharingID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("LocationSharingName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("StatusID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreateDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifyDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn LocationSharingID{
                get{
                    return this.GetColumn("LocationSharingID");
                }
            }
				
   			public static string LocationSharingIDColumn{
			      get{
        			return "LocationSharingID";
      			}
		    }
            
            public IColumn LocationSharingName{
                get{
                    return this.GetColumn("LocationSharingName");
                }
            }
				
   			public static string LocationSharingNameColumn{
			      get{
        			return "LocationSharingName";
      			}
		    }
            
            public IColumn StatusID{
                get{
                    return this.GetColumn("StatusID");
                }
            }
				
   			public static string StatusIDColumn{
			      get{
        			return "StatusID";
      			}
		    }
            
            public IColumn CreateDate{
                get{
                    return this.GetColumn("CreateDate");
                }
            }
				
   			public static string CreateDateColumn{
			      get{
        			return "CreateDate";
      			}
		    }
            
            public IColumn ModifyDate{
                get{
                    return this.GetColumn("ModifyDate");
                }
            }
				
   			public static string ModifyDateColumn{
			      get{
        			return "ModifyDate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: AppUser
        /// Primary Key: AppUserID
        /// </summary>

        public class AppUserTable: DatabaseTable {
            
            public AppUserTable(IDataProvider provider):base("AppUser",provider){
                ClassName = "AppUser";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("AppUserID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("FirstName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("LastName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("Email", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("Password", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("PasswordResetRequired", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Activated", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("FacebookID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("ParseUserID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("Facebook", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("TimeZoneID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("StatusID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreateDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifyDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Handle", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("DefaultPhoneId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsInternal", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("TwitterID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Twitter", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Avatar", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 10
                });

                Columns.Add(new DatabaseColumn("DisplayName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("Activity", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("LastXrefDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn AppUserID{
                get{
                    return this.GetColumn("AppUserID");
                }
            }
				
   			public static string AppUserIDColumn{
			      get{
        			return "AppUserID";
      			}
		    }
            
            public IColumn FirstName{
                get{
                    return this.GetColumn("FirstName");
                }
            }
				
   			public static string FirstNameColumn{
			      get{
        			return "FirstName";
      			}
		    }
            
            public IColumn LastName{
                get{
                    return this.GetColumn("LastName");
                }
            }
				
   			public static string LastNameColumn{
			      get{
        			return "LastName";
      			}
		    }
            
            public IColumn Email{
                get{
                    return this.GetColumn("Email");
                }
            }
				
   			public static string EmailColumn{
			      get{
        			return "Email";
      			}
		    }
            
            public IColumn Password{
                get{
                    return this.GetColumn("Password");
                }
            }
				
   			public static string PasswordColumn{
			      get{
        			return "Password";
      			}
		    }
            
            public IColumn PasswordResetRequired{
                get{
                    return this.GetColumn("PasswordResetRequired");
                }
            }
				
   			public static string PasswordResetRequiredColumn{
			      get{
        			return "PasswordResetRequired";
      			}
		    }
            
            public IColumn Activated{
                get{
                    return this.GetColumn("Activated");
                }
            }
				
   			public static string ActivatedColumn{
			      get{
        			return "Activated";
      			}
		    }
            
            public IColumn FacebookID{
                get{
                    return this.GetColumn("FacebookID");
                }
            }
				
   			public static string FacebookIDColumn{
			      get{
        			return "FacebookID";
      			}
		    }
            
            public IColumn ParseUserID{
                get{
                    return this.GetColumn("ParseUserID");
                }
            }
				
   			public static string ParseUserIDColumn{
			      get{
        			return "ParseUserID";
      			}
		    }
            
            public IColumn Facebook{
                get{
                    return this.GetColumn("Facebook");
                }
            }
				
   			public static string FacebookColumn{
			      get{
        			return "Facebook";
      			}
		    }
            
            public IColumn TimeZoneID{
                get{
                    return this.GetColumn("TimeZoneID");
                }
            }
				
   			public static string TimeZoneIDColumn{
			      get{
        			return "TimeZoneID";
      			}
		    }
            
            public IColumn StatusID{
                get{
                    return this.GetColumn("StatusID");
                }
            }
				
   			public static string StatusIDColumn{
			      get{
        			return "StatusID";
      			}
		    }
            
            public IColumn CreateDate{
                get{
                    return this.GetColumn("CreateDate");
                }
            }
				
   			public static string CreateDateColumn{
			      get{
        			return "CreateDate";
      			}
		    }
            
            public IColumn ModifyDate{
                get{
                    return this.GetColumn("ModifyDate");
                }
            }
				
   			public static string ModifyDateColumn{
			      get{
        			return "ModifyDate";
      			}
		    }
            
            public IColumn Handle{
                get{
                    return this.GetColumn("Handle");
                }
            }
				
   			public static string HandleColumn{
			      get{
        			return "Handle";
      			}
		    }
            
            public IColumn DefaultPhoneId{
                get{
                    return this.GetColumn("DefaultPhoneId");
                }
            }
				
   			public static string DefaultPhoneIdColumn{
			      get{
        			return "DefaultPhoneId";
      			}
		    }
            
            public IColumn IsInternal{
                get{
                    return this.GetColumn("IsInternal");
                }
            }
				
   			public static string IsInternalColumn{
			      get{
        			return "IsInternal";
      			}
		    }
            
            public IColumn TwitterID{
                get{
                    return this.GetColumn("TwitterID");
                }
            }
				
   			public static string TwitterIDColumn{
			      get{
        			return "TwitterID";
      			}
		    }
            
            public IColumn Twitter{
                get{
                    return this.GetColumn("Twitter");
                }
            }
				
   			public static string TwitterColumn{
			      get{
        			return "Twitter";
      			}
		    }
            
            public IColumn Avatar{
                get{
                    return this.GetColumn("Avatar");
                }
            }
				
   			public static string AvatarColumn{
			      get{
        			return "Avatar";
      			}
		    }
            
            public IColumn DisplayName{
                get{
                    return this.GetColumn("DisplayName");
                }
            }
				
   			public static string DisplayNameColumn{
			      get{
        			return "DisplayName";
      			}
		    }
            
            public IColumn Activity{
                get{
                    return this.GetColumn("Activity");
                }
            }
				
   			public static string ActivityColumn{
			      get{
        			return "Activity";
      			}
		    }
            
            public IColumn LastXrefDate{
                get{
                    return this.GetColumn("LastXrefDate");
                }
            }
				
   			public static string LastXrefDateColumn{
			      get{
        			return "LastXrefDate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: TwitterAppUser
        /// Primary Key: TwitterAppUserID
        /// </summary>

        public class TwitterAppUserTable: DatabaseTable {
            
            public TwitterAppUserTable(IDataProvider provider):base("TwitterAppUser",provider){
                ClassName = "TwitterAppUser";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("TwitterAppUserID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AppUserID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("FirstName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("LastName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("ScreenName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 300
                });

                Columns.Add(new DatabaseColumn("Location", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 300
                });

                Columns.Add(new DatabaseColumn("URL", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 300
                });

                Columns.Add(new DatabaseColumn("Description", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("Protected", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreatedAt", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("UTCOffset", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("TimeZone", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Verified", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Language", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("CreateDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifyDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn TwitterAppUserID{
                get{
                    return this.GetColumn("TwitterAppUserID");
                }
            }
				
   			public static string TwitterAppUserIDColumn{
			      get{
        			return "TwitterAppUserID";
      			}
		    }
            
            public IColumn AppUserID{
                get{
                    return this.GetColumn("AppUserID");
                }
            }
				
   			public static string AppUserIDColumn{
			      get{
        			return "AppUserID";
      			}
		    }
            
            public IColumn FirstName{
                get{
                    return this.GetColumn("FirstName");
                }
            }
				
   			public static string FirstNameColumn{
			      get{
        			return "FirstName";
      			}
		    }
            
            public IColumn LastName{
                get{
                    return this.GetColumn("LastName");
                }
            }
				
   			public static string LastNameColumn{
			      get{
        			return "LastName";
      			}
		    }
            
            public IColumn ScreenName{
                get{
                    return this.GetColumn("ScreenName");
                }
            }
				
   			public static string ScreenNameColumn{
			      get{
        			return "ScreenName";
      			}
		    }
            
            public IColumn Location{
                get{
                    return this.GetColumn("Location");
                }
            }
				
   			public static string LocationColumn{
			      get{
        			return "Location";
      			}
		    }
            
            public IColumn URL{
                get{
                    return this.GetColumn("URL");
                }
            }
				
   			public static string URLColumn{
			      get{
        			return "URL";
      			}
		    }
            
            public IColumn Description{
                get{
                    return this.GetColumn("Description");
                }
            }
				
   			public static string DescriptionColumn{
			      get{
        			return "Description";
      			}
		    }
            
            public IColumn Protected{
                get{
                    return this.GetColumn("Protected");
                }
            }
				
   			public static string ProtectedColumn{
			      get{
        			return "Protected";
      			}
		    }
            
            public IColumn CreatedAt{
                get{
                    return this.GetColumn("CreatedAt");
                }
            }
				
   			public static string CreatedAtColumn{
			      get{
        			return "CreatedAt";
      			}
		    }
            
            public IColumn UTCOffset{
                get{
                    return this.GetColumn("UTCOffset");
                }
            }
				
   			public static string UTCOffsetColumn{
			      get{
        			return "UTCOffset";
      			}
		    }
            
            public IColumn TimeZone{
                get{
                    return this.GetColumn("TimeZone");
                }
            }
				
   			public static string TimeZoneColumn{
			      get{
        			return "TimeZone";
      			}
		    }
            
            public IColumn Verified{
                get{
                    return this.GetColumn("Verified");
                }
            }
				
   			public static string VerifiedColumn{
			      get{
        			return "Verified";
      			}
		    }
            
            public IColumn Language{
                get{
                    return this.GetColumn("Language");
                }
            }
				
   			public static string LanguageColumn{
			      get{
        			return "Language";
      			}
		    }
            
            public IColumn CreateDate{
                get{
                    return this.GetColumn("CreateDate");
                }
            }
				
   			public static string CreateDateColumn{
			      get{
        			return "CreateDate";
      			}
		    }
            
            public IColumn ModifyDate{
                get{
                    return this.GetColumn("ModifyDate");
                }
            }
				
   			public static string ModifyDateColumn{
			      get{
        			return "ModifyDate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: Venue
        /// Primary Key: VenueID
        /// </summary>

        public class VenueTable: DatabaseTable {
            
            public VenueTable(IDataProvider provider):base("Venue",provider){
                ClassName = "Venue";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("VenueID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("VenueName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("VenueTypeID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Address1", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("Address2", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("City", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("State", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("ZipCode", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 20
                });

                Columns.Add(new DatabaseColumn("VenueGPXWKT", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 200
                });

                Columns.Add(new DatabaseColumn("VenueGPXTypeID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Capacity", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Decimal,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("StatusID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreateDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifyDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Description", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 200
                });
                    
                
                
            }

            public IColumn VenueID{
                get{
                    return this.GetColumn("VenueID");
                }
            }
				
   			public static string VenueIDColumn{
			      get{
        			return "VenueID";
      			}
		    }
            
            public IColumn VenueName{
                get{
                    return this.GetColumn("VenueName");
                }
            }
				
   			public static string VenueNameColumn{
			      get{
        			return "VenueName";
      			}
		    }
            
            public IColumn VenueTypeID{
                get{
                    return this.GetColumn("VenueTypeID");
                }
            }
				
   			public static string VenueTypeIDColumn{
			      get{
        			return "VenueTypeID";
      			}
		    }
            
            public IColumn Address1{
                get{
                    return this.GetColumn("Address1");
                }
            }
				
   			public static string Address1Column{
			      get{
        			return "Address1";
      			}
		    }
            
            public IColumn Address2{
                get{
                    return this.GetColumn("Address2");
                }
            }
				
   			public static string Address2Column{
			      get{
        			return "Address2";
      			}
		    }
            
            public IColumn City{
                get{
                    return this.GetColumn("City");
                }
            }
				
   			public static string CityColumn{
			      get{
        			return "City";
      			}
		    }
            
            public IColumn State{
                get{
                    return this.GetColumn("State");
                }
            }
				
   			public static string StateColumn{
			      get{
        			return "State";
      			}
		    }
            
            public IColumn ZipCode{
                get{
                    return this.GetColumn("ZipCode");
                }
            }
				
   			public static string ZipCodeColumn{
			      get{
        			return "ZipCode";
      			}
		    }
            
            public IColumn VenueGPXWKT{
                get{
                    return this.GetColumn("VenueGPXWKT");
                }
            }
				
   			public static string VenueGPXWKTColumn{
			      get{
        			return "VenueGPXWKT";
      			}
		    }
            
            public IColumn VenueGPXTypeID{
                get{
                    return this.GetColumn("VenueGPXTypeID");
                }
            }
				
   			public static string VenueGPXTypeIDColumn{
			      get{
        			return "VenueGPXTypeID";
      			}
		    }
            
            public IColumn Capacity{
                get{
                    return this.GetColumn("Capacity");
                }
            }
				
   			public static string CapacityColumn{
			      get{
        			return "Capacity";
      			}
		    }
            
            public IColumn StatusID{
                get{
                    return this.GetColumn("StatusID");
                }
            }
				
   			public static string StatusIDColumn{
			      get{
        			return "StatusID";
      			}
		    }
            
            public IColumn CreateDate{
                get{
                    return this.GetColumn("CreateDate");
                }
            }
				
   			public static string CreateDateColumn{
			      get{
        			return "CreateDate";
      			}
		    }
            
            public IColumn ModifyDate{
                get{
                    return this.GetColumn("ModifyDate");
                }
            }
				
   			public static string ModifyDateColumn{
			      get{
        			return "ModifyDate";
      			}
		    }
            
            public IColumn Description{
                get{
                    return this.GetColumn("Description");
                }
            }
				
   			public static string DescriptionColumn{
			      get{
        			return "Description";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: Response
        /// Primary Key: ResponseID
        /// </summary>

        public class ResponseTable: DatabaseTable {
            
            public ResponseTable(IDataProvider provider):base("Response",provider){
                ClassName = "Response";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ResponseID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ResponseName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("StatusID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreateDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifyDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn ResponseID{
                get{
                    return this.GetColumn("ResponseID");
                }
            }
				
   			public static string ResponseIDColumn{
			      get{
        			return "ResponseID";
      			}
		    }
            
            public IColumn ResponseName{
                get{
                    return this.GetColumn("ResponseName");
                }
            }
				
   			public static string ResponseNameColumn{
			      get{
        			return "ResponseName";
      			}
		    }
            
            public IColumn StatusID{
                get{
                    return this.GetColumn("StatusID");
                }
            }
				
   			public static string StatusIDColumn{
			      get{
        			return "StatusID";
      			}
		    }
            
            public IColumn CreateDate{
                get{
                    return this.GetColumn("CreateDate");
                }
            }
				
   			public static string CreateDateColumn{
			      get{
        			return "CreateDate";
      			}
		    }
            
            public IColumn ModifyDate{
                get{
                    return this.GetColumn("ModifyDate");
                }
            }
				
   			public static string ModifyDateColumn{
			      get{
        			return "ModifyDate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: VenueLot
        /// Primary Key: VenueLotID
        /// </summary>

        public class VenueLotTable: DatabaseTable {
            
            public VenueLotTable(IDataProvider provider):base("VenueLot",provider){
                ClassName = "VenueLot";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("VenueLotID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("VenueID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("VenueLotName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("VenueLotGPXWKT", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 200
                });

                Columns.Add(new DatabaseColumn("VenueLotGPXTypeID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreateDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifyDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn VenueLotID{
                get{
                    return this.GetColumn("VenueLotID");
                }
            }
				
   			public static string VenueLotIDColumn{
			      get{
        			return "VenueLotID";
      			}
		    }
            
            public IColumn VenueID{
                get{
                    return this.GetColumn("VenueID");
                }
            }
				
   			public static string VenueIDColumn{
			      get{
        			return "VenueID";
      			}
		    }
            
            public IColumn VenueLotName{
                get{
                    return this.GetColumn("VenueLotName");
                }
            }
				
   			public static string VenueLotNameColumn{
			      get{
        			return "VenueLotName";
      			}
		    }
            
            public IColumn VenueLotGPXWKT{
                get{
                    return this.GetColumn("VenueLotGPXWKT");
                }
            }
				
   			public static string VenueLotGPXWKTColumn{
			      get{
        			return "VenueLotGPXWKT";
      			}
		    }
            
            public IColumn VenueLotGPXTypeID{
                get{
                    return this.GetColumn("VenueLotGPXTypeID");
                }
            }
				
   			public static string VenueLotGPXTypeIDColumn{
			      get{
        			return "VenueLotGPXTypeID";
      			}
		    }
            
            public IColumn CreateDate{
                get{
                    return this.GetColumn("CreateDate");
                }
            }
				
   			public static string CreateDateColumn{
			      get{
        			return "CreateDate";
      			}
		    }
            
            public IColumn ModifyDate{
                get{
                    return this.GetColumn("ModifyDate");
                }
            }
				
   			public static string ModifyDateColumn{
			      get{
        			return "ModifyDate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: AppUserDefault
        /// Primary Key: AppUserDefaultID
        /// </summary>

        public class AppUserDefaultTable: DatabaseTable {
            
            public AppUserDefaultTable(IDataProvider provider):base("AppUserDefault",provider){
                ClassName = "AppUserDefault";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("AppUserDefaultID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AppUserID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("MBPrivate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("MBSharingID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("MBRLocationSharingID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AppUserPushNotification", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AppUserEmailNotification", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AppUserTextNotification", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AppUserFBNotification", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AppUserTwitterNotification", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreateDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifyDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn AppUserDefaultID{
                get{
                    return this.GetColumn("AppUserDefaultID");
                }
            }
				
   			public static string AppUserDefaultIDColumn{
			      get{
        			return "AppUserDefaultID";
      			}
		    }
            
            public IColumn AppUserID{
                get{
                    return this.GetColumn("AppUserID");
                }
            }
				
   			public static string AppUserIDColumn{
			      get{
        			return "AppUserID";
      			}
		    }
            
            public IColumn MBPrivate{
                get{
                    return this.GetColumn("MBPrivate");
                }
            }
				
   			public static string MBPrivateColumn{
			      get{
        			return "MBPrivate";
      			}
		    }
            
            public IColumn MBSharingID{
                get{
                    return this.GetColumn("MBSharingID");
                }
            }
				
   			public static string MBSharingIDColumn{
			      get{
        			return "MBSharingID";
      			}
		    }
            
            public IColumn MBRLocationSharingID{
                get{
                    return this.GetColumn("MBRLocationSharingID");
                }
            }
				
   			public static string MBRLocationSharingIDColumn{
			      get{
        			return "MBRLocationSharingID";
      			}
		    }
            
            public IColumn AppUserPushNotification{
                get{
                    return this.GetColumn("AppUserPushNotification");
                }
            }
				
   			public static string AppUserPushNotificationColumn{
			      get{
        			return "AppUserPushNotification";
      			}
		    }
            
            public IColumn AppUserEmailNotification{
                get{
                    return this.GetColumn("AppUserEmailNotification");
                }
            }
				
   			public static string AppUserEmailNotificationColumn{
			      get{
        			return "AppUserEmailNotification";
      			}
		    }
            
            public IColumn AppUserTextNotification{
                get{
                    return this.GetColumn("AppUserTextNotification");
                }
            }
				
   			public static string AppUserTextNotificationColumn{
			      get{
        			return "AppUserTextNotification";
      			}
		    }
            
            public IColumn AppUserFBNotification{
                get{
                    return this.GetColumn("AppUserFBNotification");
                }
            }
				
   			public static string AppUserFBNotificationColumn{
			      get{
        			return "AppUserFBNotification";
      			}
		    }
            
            public IColumn AppUserTwitterNotification{
                get{
                    return this.GetColumn("AppUserTwitterNotification");
                }
            }
				
   			public static string AppUserTwitterNotificationColumn{
			      get{
        			return "AppUserTwitterNotification";
      			}
		    }
            
            public IColumn CreateDate{
                get{
                    return this.GetColumn("CreateDate");
                }
            }
				
   			public static string CreateDateColumn{
			      get{
        			return "CreateDate";
      			}
		    }
            
            public IColumn ModifyDate{
                get{
                    return this.GetColumn("ModifyDate");
                }
            }
				
   			public static string ModifyDateColumn{
			      get{
        			return "ModifyDate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: VenueXAppUserStatus
        /// Primary Key: VenueXAppUserStatusID
        /// </summary>

        public class VenueXAppUserStatusTable: DatabaseTable {
            
            public VenueXAppUserStatusTable(IDataProvider provider):base("VenueXAppUserStatus",provider){
                ClassName = "VenueXAppUserStatus";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("VenueXAppUserStatusID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("VenueXAppUserStatusName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("CreateDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifyDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn VenueXAppUserStatusID{
                get{
                    return this.GetColumn("VenueXAppUserStatusID");
                }
            }
				
   			public static string VenueXAppUserStatusIDColumn{
			      get{
        			return "VenueXAppUserStatusID";
      			}
		    }
            
            public IColumn VenueXAppUserStatusName{
                get{
                    return this.GetColumn("VenueXAppUserStatusName");
                }
            }
				
   			public static string VenueXAppUserStatusNameColumn{
			      get{
        			return "VenueXAppUserStatusName";
      			}
		    }
            
            public IColumn CreateDate{
                get{
                    return this.GetColumn("CreateDate");
                }
            }
				
   			public static string CreateDateColumn{
			      get{
        			return "CreateDate";
      			}
		    }
            
            public IColumn ModifyDate{
                get{
                    return this.GetColumn("ModifyDate");
                }
            }
				
   			public static string ModifyDateColumn{
			      get{
        			return "ModifyDate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: SportsEvent
        /// Primary Key: SportsEventID
        /// </summary>

        public class SportsEventTable: DatabaseTable {
            
            public SportsEventTable(IDataProvider provider):base("SportsEvent",provider){
                ClassName = "SportsEvent";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("SportsEventID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("EventID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("HomeTeamID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AwayTeamID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SportsTypeID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SportsEventTypeID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("StatusID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreateDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifyDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn SportsEventID{
                get{
                    return this.GetColumn("SportsEventID");
                }
            }
				
   			public static string SportsEventIDColumn{
			      get{
        			return "SportsEventID";
      			}
		    }
            
            public IColumn EventID{
                get{
                    return this.GetColumn("EventID");
                }
            }
				
   			public static string EventIDColumn{
			      get{
        			return "EventID";
      			}
		    }
            
            public IColumn HomeTeamID{
                get{
                    return this.GetColumn("HomeTeamID");
                }
            }
				
   			public static string HomeTeamIDColumn{
			      get{
        			return "HomeTeamID";
      			}
		    }
            
            public IColumn AwayTeamID{
                get{
                    return this.GetColumn("AwayTeamID");
                }
            }
				
   			public static string AwayTeamIDColumn{
			      get{
        			return "AwayTeamID";
      			}
		    }
            
            public IColumn SportsTypeID{
                get{
                    return this.GetColumn("SportsTypeID");
                }
            }
				
   			public static string SportsTypeIDColumn{
			      get{
        			return "SportsTypeID";
      			}
		    }
            
            public IColumn SportsEventTypeID{
                get{
                    return this.GetColumn("SportsEventTypeID");
                }
            }
				
   			public static string SportsEventTypeIDColumn{
			      get{
        			return "SportsEventTypeID";
      			}
		    }
            
            public IColumn StatusID{
                get{
                    return this.GetColumn("StatusID");
                }
            }
				
   			public static string StatusIDColumn{
			      get{
        			return "StatusID";
      			}
		    }
            
            public IColumn CreateDate{
                get{
                    return this.GetColumn("CreateDate");
                }
            }
				
   			public static string CreateDateColumn{
			      get{
        			return "CreateDate";
      			}
		    }
            
            public IColumn ModifyDate{
                get{
                    return this.GetColumn("ModifyDate");
                }
            }
				
   			public static string ModifyDateColumn{
			      get{
        			return "ModifyDate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: VenueXAppUser
        /// Primary Key: AppUserID
        /// </summary>

        public class VenueXAppUserTable: DatabaseTable {
            
            public VenueXAppUserTable(IDataProvider provider):base("VenueXAppUser",provider){
                ClassName = "VenueXAppUser";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("VenueID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AppUserID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("StatusID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn VenueID{
                get{
                    return this.GetColumn("VenueID");
                }
            }
				
   			public static string VenueIDColumn{
			      get{
        			return "VenueID";
      			}
		    }
            
            public IColumn AppUserID{
                get{
                    return this.GetColumn("AppUserID");
                }
            }
				
   			public static string AppUserIDColumn{
			      get{
        			return "AppUserID";
      			}
		    }
            
            public IColumn StatusID{
                get{
                    return this.GetColumn("StatusID");
                }
            }
				
   			public static string StatusIDColumn{
			      get{
        			return "StatusID";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: SportsTeamXVenue
        /// Primary Key: SportsTeamID
        /// </summary>

        public class SportsTeamXVenueTable: DatabaseTable {
            
            public SportsTeamXVenueTable(IDataProvider provider):base("SportsTeamXVenue",provider){
                ClassName = "SportsTeamXVenue";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("SportsTeamID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("VenueID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SportsTypeID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn SportsTeamID{
                get{
                    return this.GetColumn("SportsTeamID");
                }
            }
				
   			public static string SportsTeamIDColumn{
			      get{
        			return "SportsTeamID";
      			}
		    }
            
            public IColumn VenueID{
                get{
                    return this.GetColumn("VenueID");
                }
            }
				
   			public static string VenueIDColumn{
			      get{
        			return "VenueID";
      			}
		    }
            
            public IColumn SportsTypeID{
                get{
                    return this.GetColumn("SportsTypeID");
                }
            }
				
   			public static string SportsTypeIDColumn{
			      get{
        			return "SportsTypeID";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: WebAssetCategory
        /// Primary Key: WebAssetCategoryId
        /// </summary>

        public class WebAssetCategoryTable: DatabaseTable {
            
            public WebAssetCategoryTable(IDataProvider provider):base("WebAssetCategory",provider){
                ClassName = "WebAssetCategory";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("WebAssetCategoryId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("WebAssetCategoryName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });

                Columns.Add(new DatabaseColumn("DisplayOrder", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int16,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("StatusID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreateDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifyDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn WebAssetCategoryId{
                get{
                    return this.GetColumn("WebAssetCategoryId");
                }
            }
				
   			public static string WebAssetCategoryIdColumn{
			      get{
        			return "WebAssetCategoryId";
      			}
		    }
            
            public IColumn WebAssetCategoryName{
                get{
                    return this.GetColumn("WebAssetCategoryName");
                }
            }
				
   			public static string WebAssetCategoryNameColumn{
			      get{
        			return "WebAssetCategoryName";
      			}
		    }
            
            public IColumn DisplayOrder{
                get{
                    return this.GetColumn("DisplayOrder");
                }
            }
				
   			public static string DisplayOrderColumn{
			      get{
        			return "DisplayOrder";
      			}
		    }
            
            public IColumn StatusID{
                get{
                    return this.GetColumn("StatusID");
                }
            }
				
   			public static string StatusIDColumn{
			      get{
        			return "StatusID";
      			}
		    }
            
            public IColumn CreateDate{
                get{
                    return this.GetColumn("CreateDate");
                }
            }
				
   			public static string CreateDateColumn{
			      get{
        			return "CreateDate";
      			}
		    }
            
            public IColumn ModifyDate{
                get{
                    return this.GetColumn("ModifyDate");
                }
            }
				
   			public static string ModifyDateColumn{
			      get{
        			return "ModifyDate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: url_base
        /// Primary Key: BaseUrlID
        /// </summary>

        public class url_baseTable: DatabaseTable {
            
            public url_baseTable(IDataProvider provider):base("url_base",provider){
                ClassName = "url_base";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("BaseUrlID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("url", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 200
                });

                Columns.Add(new DatabaseColumn("CreateDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn BaseUrlID{
                get{
                    return this.GetColumn("BaseUrlID");
                }
            }
				
   			public static string BaseUrlIDColumn{
			      get{
        			return "BaseUrlID";
      			}
		    }
            
            public IColumn url{
                get{
                    return this.GetColumn("url");
                }
            }
				
   			public static string urlColumn{
			      get{
        			return "url";
      			}
		    }
            
            public IColumn CreateDate{
                get{
                    return this.GetColumn("CreateDate");
                }
            }
				
   			public static string CreateDateColumn{
			      get{
        			return "CreateDate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: AppUserXSportsTeam
        /// Primary Key: AppUserID
        /// </summary>

        public class AppUserXSportsTeamTable: DatabaseTable {
            
            public AppUserXSportsTeamTable(IDataProvider provider):base("AppUserXSportsTeam",provider){
                ClassName = "AppUserXSportsTeam";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("AppUserID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SportsTeamID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn AppUserID{
                get{
                    return this.GetColumn("AppUserID");
                }
            }
				
   			public static string AppUserIDColumn{
			      get{
        			return "AppUserID";
      			}
		    }
            
            public IColumn SportsTeamID{
                get{
                    return this.GetColumn("SportsTeamID");
                }
            }
				
   			public static string SportsTeamIDColumn{
			      get{
        			return "SportsTeamID";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: Meetball
        /// Primary Key: MeetballID
        /// </summary>

        public class MeetballTable: DatabaseTable {
            
            public MeetballTable(IDataProvider provider):base("Meetball",provider){
                ClassName = "Meetball";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("MeetballID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("MeetballName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("MeetballDescription", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });

                Columns.Add(new DatabaseColumn("Private", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SharingID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("StartDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("EndDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("FacebookEventID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("LocationName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });

                Columns.Add(new DatabaseColumn("GeneralLocationAddress1", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 200
                });

                Columns.Add(new DatabaseColumn("GeneralLocationAddress2", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 200
                });

                Columns.Add(new DatabaseColumn("GeneralLocationCity", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("GeneralLocationState", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("GeneralLocationZip", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 10
                });

                Columns.Add(new DatabaseColumn("GeneralLocationPhone", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("GeneralLocationGPXWKT", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 200
                });

                Columns.Add(new DatabaseColumn("GeneralLocationGPXTypeID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SpecificLocationGPXWKT", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 200
                });

                Columns.Add(new DatabaseColumn("SpecificLocationGPXTypeID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("LocationNotes", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });

                Columns.Add(new DatabaseColumn("StatusID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreateDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifyDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("UsageId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("GeneralLocationAccuracy", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SpecificLocationAccuracy", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("MBIDHash", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 15
                });

                Columns.Add(new DatabaseColumn("short_url_ID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ConvoID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Meetcode", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 15
                });

                Columns.Add(new DatabaseColumn("HasPic", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("VenueID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ChatDisabled", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsFeatured", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ParentMeetballID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn MeetballID{
                get{
                    return this.GetColumn("MeetballID");
                }
            }
				
   			public static string MeetballIDColumn{
			      get{
        			return "MeetballID";
      			}
		    }
            
            public IColumn MeetballName{
                get{
                    return this.GetColumn("MeetballName");
                }
            }
				
   			public static string MeetballNameColumn{
			      get{
        			return "MeetballName";
      			}
		    }
            
            public IColumn MeetballDescription{
                get{
                    return this.GetColumn("MeetballDescription");
                }
            }
				
   			public static string MeetballDescriptionColumn{
			      get{
        			return "MeetballDescription";
      			}
		    }
            
            public IColumn Private{
                get{
                    return this.GetColumn("Private");
                }
            }
				
   			public static string PrivateColumn{
			      get{
        			return "Private";
      			}
		    }
            
            public IColumn SharingID{
                get{
                    return this.GetColumn("SharingID");
                }
            }
				
   			public static string SharingIDColumn{
			      get{
        			return "SharingID";
      			}
		    }
            
            public IColumn StartDate{
                get{
                    return this.GetColumn("StartDate");
                }
            }
				
   			public static string StartDateColumn{
			      get{
        			return "StartDate";
      			}
		    }
            
            public IColumn EndDate{
                get{
                    return this.GetColumn("EndDate");
                }
            }
				
   			public static string EndDateColumn{
			      get{
        			return "EndDate";
      			}
		    }
            
            public IColumn FacebookEventID{
                get{
                    return this.GetColumn("FacebookEventID");
                }
            }
				
   			public static string FacebookEventIDColumn{
			      get{
        			return "FacebookEventID";
      			}
		    }
            
            public IColumn LocationName{
                get{
                    return this.GetColumn("LocationName");
                }
            }
				
   			public static string LocationNameColumn{
			      get{
        			return "LocationName";
      			}
		    }
            
            public IColumn GeneralLocationAddress1{
                get{
                    return this.GetColumn("GeneralLocationAddress1");
                }
            }
				
   			public static string GeneralLocationAddress1Column{
			      get{
        			return "GeneralLocationAddress1";
      			}
		    }
            
            public IColumn GeneralLocationAddress2{
                get{
                    return this.GetColumn("GeneralLocationAddress2");
                }
            }
				
   			public static string GeneralLocationAddress2Column{
			      get{
        			return "GeneralLocationAddress2";
      			}
		    }
            
            public IColumn GeneralLocationCity{
                get{
                    return this.GetColumn("GeneralLocationCity");
                }
            }
				
   			public static string GeneralLocationCityColumn{
			      get{
        			return "GeneralLocationCity";
      			}
		    }
            
            public IColumn GeneralLocationState{
                get{
                    return this.GetColumn("GeneralLocationState");
                }
            }
				
   			public static string GeneralLocationStateColumn{
			      get{
        			return "GeneralLocationState";
      			}
		    }
            
            public IColumn GeneralLocationZip{
                get{
                    return this.GetColumn("GeneralLocationZip");
                }
            }
				
   			public static string GeneralLocationZipColumn{
			      get{
        			return "GeneralLocationZip";
      			}
		    }
            
            public IColumn GeneralLocationPhone{
                get{
                    return this.GetColumn("GeneralLocationPhone");
                }
            }
				
   			public static string GeneralLocationPhoneColumn{
			      get{
        			return "GeneralLocationPhone";
      			}
		    }
            
            public IColumn GeneralLocationGPXWKT{
                get{
                    return this.GetColumn("GeneralLocationGPXWKT");
                }
            }
				
   			public static string GeneralLocationGPXWKTColumn{
			      get{
        			return "GeneralLocationGPXWKT";
      			}
		    }
            
            public IColumn GeneralLocationGPXTypeID{
                get{
                    return this.GetColumn("GeneralLocationGPXTypeID");
                }
            }
				
   			public static string GeneralLocationGPXTypeIDColumn{
			      get{
        			return "GeneralLocationGPXTypeID";
      			}
		    }
            
            public IColumn SpecificLocationGPXWKT{
                get{
                    return this.GetColumn("SpecificLocationGPXWKT");
                }
            }
				
   			public static string SpecificLocationGPXWKTColumn{
			      get{
        			return "SpecificLocationGPXWKT";
      			}
		    }
            
            public IColumn SpecificLocationGPXTypeID{
                get{
                    return this.GetColumn("SpecificLocationGPXTypeID");
                }
            }
				
   			public static string SpecificLocationGPXTypeIDColumn{
			      get{
        			return "SpecificLocationGPXTypeID";
      			}
		    }
            
            public IColumn LocationNotes{
                get{
                    return this.GetColumn("LocationNotes");
                }
            }
				
   			public static string LocationNotesColumn{
			      get{
        			return "LocationNotes";
      			}
		    }
            
            public IColumn StatusID{
                get{
                    return this.GetColumn("StatusID");
                }
            }
				
   			public static string StatusIDColumn{
			      get{
        			return "StatusID";
      			}
		    }
            
            public IColumn CreateDate{
                get{
                    return this.GetColumn("CreateDate");
                }
            }
				
   			public static string CreateDateColumn{
			      get{
        			return "CreateDate";
      			}
		    }
            
            public IColumn ModifyDate{
                get{
                    return this.GetColumn("ModifyDate");
                }
            }
				
   			public static string ModifyDateColumn{
			      get{
        			return "ModifyDate";
      			}
		    }
            
            public IColumn UsageId{
                get{
                    return this.GetColumn("UsageId");
                }
            }
				
   			public static string UsageIdColumn{
			      get{
        			return "UsageId";
      			}
		    }
            
            public IColumn GeneralLocationAccuracy{
                get{
                    return this.GetColumn("GeneralLocationAccuracy");
                }
            }
				
   			public static string GeneralLocationAccuracyColumn{
			      get{
        			return "GeneralLocationAccuracy";
      			}
		    }
            
            public IColumn SpecificLocationAccuracy{
                get{
                    return this.GetColumn("SpecificLocationAccuracy");
                }
            }
				
   			public static string SpecificLocationAccuracyColumn{
			      get{
        			return "SpecificLocationAccuracy";
      			}
		    }
            
            public IColumn MBIDHash{
                get{
                    return this.GetColumn("MBIDHash");
                }
            }
				
   			public static string MBIDHashColumn{
			      get{
        			return "MBIDHash";
      			}
		    }
            
            public IColumn short_url_ID{
                get{
                    return this.GetColumn("short_url_ID");
                }
            }
				
   			public static string short_url_IDColumn{
			      get{
        			return "short_url_ID";
      			}
		    }
            
            public IColumn ConvoID{
                get{
                    return this.GetColumn("ConvoID");
                }
            }
				
   			public static string ConvoIDColumn{
			      get{
        			return "ConvoID";
      			}
		    }
            
            public IColumn Meetcode{
                get{
                    return this.GetColumn("Meetcode");
                }
            }
				
   			public static string MeetcodeColumn{
			      get{
        			return "Meetcode";
      			}
		    }
            
            public IColumn HasPic{
                get{
                    return this.GetColumn("HasPic");
                }
            }
				
   			public static string HasPicColumn{
			      get{
        			return "HasPic";
      			}
		    }
            
            public IColumn VenueID{
                get{
                    return this.GetColumn("VenueID");
                }
            }
				
   			public static string VenueIDColumn{
			      get{
        			return "VenueID";
      			}
		    }
            
            public IColumn ChatDisabled{
                get{
                    return this.GetColumn("ChatDisabled");
                }
            }
				
   			public static string ChatDisabledColumn{
			      get{
        			return "ChatDisabled";
      			}
		    }
            
            public IColumn IsFeatured{
                get{
                    return this.GetColumn("IsFeatured");
                }
            }
				
   			public static string IsFeaturedColumn{
			      get{
        			return "IsFeatured";
      			}
		    }
            
            public IColumn ParentMeetballID{
                get{
                    return this.GetColumn("ParentMeetballID");
                }
            }
				
   			public static string ParentMeetballIDColumn{
			      get{
        			return "ParentMeetballID";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: AppUserXFriendAppUser
        /// Primary Key: AppUserID
        /// </summary>

        public class AppUserXFriendAppUserTable: DatabaseTable {
            
            public AppUserXFriendAppUserTable(IDataProvider provider):base("AppUserXFriendAppUser",provider){
                ClassName = "AppUserXFriendAppUser";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("AppUserID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("FriendAppUserID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("FriendStatusID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Favorite", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("MeetballTrackingID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ConvoID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("MBCount", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn AppUserID{
                get{
                    return this.GetColumn("AppUserID");
                }
            }
				
   			public static string AppUserIDColumn{
			      get{
        			return "AppUserID";
      			}
		    }
            
            public IColumn FriendAppUserID{
                get{
                    return this.GetColumn("FriendAppUserID");
                }
            }
				
   			public static string FriendAppUserIDColumn{
			      get{
        			return "FriendAppUserID";
      			}
		    }
            
            public IColumn FriendStatusID{
                get{
                    return this.GetColumn("FriendStatusID");
                }
            }
				
   			public static string FriendStatusIDColumn{
			      get{
        			return "FriendStatusID";
      			}
		    }
            
            public IColumn Favorite{
                get{
                    return this.GetColumn("Favorite");
                }
            }
				
   			public static string FavoriteColumn{
			      get{
        			return "Favorite";
      			}
		    }
            
            public IColumn MeetballTrackingID{
                get{
                    return this.GetColumn("MeetballTrackingID");
                }
            }
				
   			public static string MeetballTrackingIDColumn{
			      get{
        			return "MeetballTrackingID";
      			}
		    }
            
            public IColumn ConvoID{
                get{
                    return this.GetColumn("ConvoID");
                }
            }
				
   			public static string ConvoIDColumn{
			      get{
        			return "ConvoID";
      			}
		    }
            
            public IColumn MBCount{
                get{
                    return this.GetColumn("MBCount");
                }
            }
				
   			public static string MBCountColumn{
			      get{
        			return "MBCount";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: EventXHashtag
        /// Primary Key: EventID
        /// </summary>

        public class EventXHashtagTable: DatabaseTable {
            
            public EventXHashtagTable(IDataProvider provider):base("EventXHashtag",provider){
                ClassName = "EventXHashtag";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("EventID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Hashtag", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 140
                });
                    
                
                
            }

            public IColumn EventID{
                get{
                    return this.GetColumn("EventID");
                }
            }
				
   			public static string EventIDColumn{
			      get{
        			return "EventID";
      			}
		    }
            
            public IColumn Hashtag{
                get{
                    return this.GetColumn("Hashtag");
                }
            }
				
   			public static string HashtagColumn{
			      get{
        			return "Hashtag";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: AppUserOffPlatform
        /// Primary Key: AppUserOffPlatformID
        /// </summary>

        public class AppUserOffPlatformTable: DatabaseTable {
            
            public AppUserOffPlatformTable(IDataProvider provider):base("AppUserOffPlatform",provider){
                ClassName = "AppUserOffPlatform";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("AppUserOffPlatformID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("MeetballID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("OwnerAppUserID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("DisplayName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("Phone", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("StatusID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreateDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ReferralAppUserID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn AppUserOffPlatformID{
                get{
                    return this.GetColumn("AppUserOffPlatformID");
                }
            }
				
   			public static string AppUserOffPlatformIDColumn{
			      get{
        			return "AppUserOffPlatformID";
      			}
		    }
            
            public IColumn MeetballID{
                get{
                    return this.GetColumn("MeetballID");
                }
            }
				
   			public static string MeetballIDColumn{
			      get{
        			return "MeetballID";
      			}
		    }
            
            public IColumn OwnerAppUserID{
                get{
                    return this.GetColumn("OwnerAppUserID");
                }
            }
				
   			public static string OwnerAppUserIDColumn{
			      get{
        			return "OwnerAppUserID";
      			}
		    }
            
            public IColumn DisplayName{
                get{
                    return this.GetColumn("DisplayName");
                }
            }
				
   			public static string DisplayNameColumn{
			      get{
        			return "DisplayName";
      			}
		    }
            
            public IColumn Phone{
                get{
                    return this.GetColumn("Phone");
                }
            }
				
   			public static string PhoneColumn{
			      get{
        			return "Phone";
      			}
		    }
            
            public IColumn StatusID{
                get{
                    return this.GetColumn("StatusID");
                }
            }
				
   			public static string StatusIDColumn{
			      get{
        			return "StatusID";
      			}
		    }
            
            public IColumn CreateDate{
                get{
                    return this.GetColumn("CreateDate");
                }
            }
				
   			public static string CreateDateColumn{
			      get{
        			return "CreateDate";
      			}
		    }
            
            public IColumn ReferralAppUserID{
                get{
                    return this.GetColumn("ReferralAppUserID");
                }
            }
				
   			public static string ReferralAppUserIDColumn{
			      get{
        			return "ReferralAppUserID";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: AppUserActivityLog
        /// Primary Key: AppUserActivityLogID
        /// </summary>

        public class AppUserActivityLogTable: DatabaseTable {
            
            public AppUserActivityLogTable(IDataProvider provider):base("AppUserActivityLog",provider){
                ClassName = "AppUserActivityLog";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("AppUserActivityLogID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AppUserID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("RelatedAppUserID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("MeetballID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AppUserActivityID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AppUserActivityDescription", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });

                Columns.Add(new DatabaseColumn("Notes", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("LogDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsRead", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn AppUserActivityLogID{
                get{
                    return this.GetColumn("AppUserActivityLogID");
                }
            }
				
   			public static string AppUserActivityLogIDColumn{
			      get{
        			return "AppUserActivityLogID";
      			}
		    }
            
            public IColumn AppUserID{
                get{
                    return this.GetColumn("AppUserID");
                }
            }
				
   			public static string AppUserIDColumn{
			      get{
        			return "AppUserID";
      			}
		    }
            
            public IColumn RelatedAppUserID{
                get{
                    return this.GetColumn("RelatedAppUserID");
                }
            }
				
   			public static string RelatedAppUserIDColumn{
			      get{
        			return "RelatedAppUserID";
      			}
		    }
            
            public IColumn MeetballID{
                get{
                    return this.GetColumn("MeetballID");
                }
            }
				
   			public static string MeetballIDColumn{
			      get{
        			return "MeetballID";
      			}
		    }
            
            public IColumn AppUserActivityID{
                get{
                    return this.GetColumn("AppUserActivityID");
                }
            }
				
   			public static string AppUserActivityIDColumn{
			      get{
        			return "AppUserActivityID";
      			}
		    }
            
            public IColumn AppUserActivityDescription{
                get{
                    return this.GetColumn("AppUserActivityDescription");
                }
            }
				
   			public static string AppUserActivityDescriptionColumn{
			      get{
        			return "AppUserActivityDescription";
      			}
		    }
            
            public IColumn Notes{
                get{
                    return this.GetColumn("Notes");
                }
            }
				
   			public static string NotesColumn{
			      get{
        			return "Notes";
      			}
		    }
            
            public IColumn LogDate{
                get{
                    return this.GetColumn("LogDate");
                }
            }
				
   			public static string LogDateColumn{
			      get{
        			return "LogDate";
      			}
		    }
            
            public IColumn IsRead{
                get{
                    return this.GetColumn("IsRead");
                }
            }
				
   			public static string IsReadColumn{
			      get{
        			return "IsRead";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: WebAssetSetting
        /// Primary Key: WebAssetSettingId
        /// </summary>

        public class WebAssetSettingTable: DatabaseTable {
            
            public WebAssetSettingTable(IDataProvider provider):base("WebAssetSetting",provider){
                ClassName = "WebAssetSetting";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("WebAssetSettingId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("WebAssetCategoryId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Description", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 1000
                });

                Columns.Add(new DatabaseColumn("Link", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 1000
                });

                Columns.Add(new DatabaseColumn("RequiresSession", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("DisplayOrder", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int16,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("StatusId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreateDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifyDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn WebAssetSettingId{
                get{
                    return this.GetColumn("WebAssetSettingId");
                }
            }
				
   			public static string WebAssetSettingIdColumn{
			      get{
        			return "WebAssetSettingId";
      			}
		    }
            
            public IColumn WebAssetCategoryId{
                get{
                    return this.GetColumn("WebAssetCategoryId");
                }
            }
				
   			public static string WebAssetCategoryIdColumn{
			      get{
        			return "WebAssetCategoryId";
      			}
		    }
            
            public IColumn Name{
                get{
                    return this.GetColumn("Name");
                }
            }
				
   			public static string NameColumn{
			      get{
        			return "Name";
      			}
		    }
            
            public IColumn Description{
                get{
                    return this.GetColumn("Description");
                }
            }
				
   			public static string DescriptionColumn{
			      get{
        			return "Description";
      			}
		    }
            
            public IColumn Link{
                get{
                    return this.GetColumn("Link");
                }
            }
				
   			public static string LinkColumn{
			      get{
        			return "Link";
      			}
		    }
            
            public IColumn RequiresSession{
                get{
                    return this.GetColumn("RequiresSession");
                }
            }
				
   			public static string RequiresSessionColumn{
			      get{
        			return "RequiresSession";
      			}
		    }
            
            public IColumn DisplayOrder{
                get{
                    return this.GetColumn("DisplayOrder");
                }
            }
				
   			public static string DisplayOrderColumn{
			      get{
        			return "DisplayOrder";
      			}
		    }
            
            public IColumn StatusId{
                get{
                    return this.GetColumn("StatusId");
                }
            }
				
   			public static string StatusIdColumn{
			      get{
        			return "StatusId";
      			}
		    }
            
            public IColumn CreateDate{
                get{
                    return this.GetColumn("CreateDate");
                }
            }
				
   			public static string CreateDateColumn{
			      get{
        			return "CreateDate";
      			}
		    }
            
            public IColumn ModifyDate{
                get{
                    return this.GetColumn("ModifyDate");
                }
            }
				
   			public static string ModifyDateColumn{
			      get{
        			return "ModifyDate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: MeetballXHashtag
        /// Primary Key: Hashtag
        /// </summary>

        public class MeetballXHashtagTable: DatabaseTable {
            
            public MeetballXHashtagTable(IDataProvider provider):base("MeetballXHashtag",provider){
                ClassName = "MeetballXHashtag";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("MeetballID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Hashtag", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.AnsiString,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 140
                });
                    
                
                
            }

            public IColumn MeetballID{
                get{
                    return this.GetColumn("MeetballID");
                }
            }
				
   			public static string MeetballIDColumn{
			      get{
        			return "MeetballID";
      			}
		    }
            
            public IColumn Hashtag{
                get{
                    return this.GetColumn("Hashtag");
                }
            }
				
   			public static string HashtagColumn{
			      get{
        			return "Hashtag";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: MeetballOwner
        /// Primary Key: MeetballID
        /// </summary>

        public class MeetballOwnerTable: DatabaseTable {
            
            public MeetballOwnerTable(IDataProvider provider):base("MeetballOwner",provider){
                ClassName = "MeetballOwner";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("MeetballID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("OwnerAppUserID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn MeetballID{
                get{
                    return this.GetColumn("MeetballID");
                }
            }
				
   			public static string MeetballIDColumn{
			      get{
        			return "MeetballID";
      			}
		    }
            
            public IColumn OwnerAppUserID{
                get{
                    return this.GetColumn("OwnerAppUserID");
                }
            }
				
   			public static string OwnerAppUserIDColumn{
			      get{
        			return "OwnerAppUserID";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: AppUserXPhone
        /// Primary Key: 
        /// </summary>

        public class AppUserXPhoneTable: DatabaseTable {
            
            public AppUserXPhoneTable(IDataProvider provider):base("AppUserXPhone",provider){
                ClassName = "AppUserXPhone";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("AppUserID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Phone", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("CreateDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn AppUserID{
                get{
                    return this.GetColumn("AppUserID");
                }
            }
				
   			public static string AppUserIDColumn{
			      get{
        			return "AppUserID";
      			}
		    }
            
            public IColumn Phone{
                get{
                    return this.GetColumn("Phone");
                }
            }
				
   			public static string PhoneColumn{
			      get{
        			return "Phone";
      			}
		    }
            
            public IColumn CreateDate{
                get{
                    return this.GetColumn("CreateDate");
                }
            }
				
   			public static string CreateDateColumn{
			      get{
        			return "CreateDate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: MeetballComment
        /// Primary Key: MeetballCommentID
        /// </summary>

        public class MeetballCommentTable: DatabaseTable {
            
            public MeetballCommentTable(IDataProvider provider):base("MeetballComment",provider){
                ClassName = "MeetballComment";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("MeetballCommentID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("MeetballID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AppUserID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Comment", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("CommentDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Approved", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("StatusID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ToAppUserID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsRead", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn MeetballCommentID{
                get{
                    return this.GetColumn("MeetballCommentID");
                }
            }
				
   			public static string MeetballCommentIDColumn{
			      get{
        			return "MeetballCommentID";
      			}
		    }
            
            public IColumn MeetballID{
                get{
                    return this.GetColumn("MeetballID");
                }
            }
				
   			public static string MeetballIDColumn{
			      get{
        			return "MeetballID";
      			}
		    }
            
            public IColumn AppUserID{
                get{
                    return this.GetColumn("AppUserID");
                }
            }
				
   			public static string AppUserIDColumn{
			      get{
        			return "AppUserID";
      			}
		    }
            
            public IColumn Comment{
                get{
                    return this.GetColumn("Comment");
                }
            }
				
   			public static string CommentColumn{
			      get{
        			return "Comment";
      			}
		    }
            
            public IColumn CommentDate{
                get{
                    return this.GetColumn("CommentDate");
                }
            }
				
   			public static string CommentDateColumn{
			      get{
        			return "CommentDate";
      			}
		    }
            
            public IColumn Approved{
                get{
                    return this.GetColumn("Approved");
                }
            }
				
   			public static string ApprovedColumn{
			      get{
        			return "Approved";
      			}
		    }
            
            public IColumn StatusID{
                get{
                    return this.GetColumn("StatusID");
                }
            }
				
   			public static string StatusIDColumn{
			      get{
        			return "StatusID";
      			}
		    }
            
            public IColumn ToAppUserID{
                get{
                    return this.GetColumn("ToAppUserID");
                }
            }
				
   			public static string ToAppUserIDColumn{
			      get{
        			return "ToAppUserID";
      			}
		    }
            
            public IColumn IsRead{
                get{
                    return this.GetColumn("IsRead");
                }
            }
				
   			public static string IsReadColumn{
			      get{
        			return "IsRead";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: EmailTemplate
        /// Primary Key: EmailTemplateID
        /// </summary>

        public class EmailTemplateTable: DatabaseTable {
            
            public EmailTemplateTable(IDataProvider provider):base("EmailTemplate",provider){
                ClassName = "EmailTemplate";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("EmailTemplateID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("EmailTemplateName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Subject", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 200
                });

                Columns.Add(new DatabaseColumn("EmailBody", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("EmailSimpleBody", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("TextBody", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("PushBody", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("Version", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("StatusID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreateDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifyDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("TemplateNumber", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn EmailTemplateID{
                get{
                    return this.GetColumn("EmailTemplateID");
                }
            }
				
   			public static string EmailTemplateIDColumn{
			      get{
        			return "EmailTemplateID";
      			}
		    }
            
            public IColumn EmailTemplateName{
                get{
                    return this.GetColumn("EmailTemplateName");
                }
            }
				
   			public static string EmailTemplateNameColumn{
			      get{
        			return "EmailTemplateName";
      			}
		    }
            
            public IColumn Subject{
                get{
                    return this.GetColumn("Subject");
                }
            }
				
   			public static string SubjectColumn{
			      get{
        			return "Subject";
      			}
		    }
            
            public IColumn EmailBody{
                get{
                    return this.GetColumn("EmailBody");
                }
            }
				
   			public static string EmailBodyColumn{
			      get{
        			return "EmailBody";
      			}
		    }
            
            public IColumn EmailSimpleBody{
                get{
                    return this.GetColumn("EmailSimpleBody");
                }
            }
				
   			public static string EmailSimpleBodyColumn{
			      get{
        			return "EmailSimpleBody";
      			}
		    }
            
            public IColumn TextBody{
                get{
                    return this.GetColumn("TextBody");
                }
            }
				
   			public static string TextBodyColumn{
			      get{
        			return "TextBody";
      			}
		    }
            
            public IColumn PushBody{
                get{
                    return this.GetColumn("PushBody");
                }
            }
				
   			public static string PushBodyColumn{
			      get{
        			return "PushBody";
      			}
		    }
            
            public IColumn Version{
                get{
                    return this.GetColumn("Version");
                }
            }
				
   			public static string VersionColumn{
			      get{
        			return "Version";
      			}
		    }
            
            public IColumn StatusID{
                get{
                    return this.GetColumn("StatusID");
                }
            }
				
   			public static string StatusIDColumn{
			      get{
        			return "StatusID";
      			}
		    }
            
            public IColumn CreateDate{
                get{
                    return this.GetColumn("CreateDate");
                }
            }
				
   			public static string CreateDateColumn{
			      get{
        			return "CreateDate";
      			}
		    }
            
            public IColumn ModifyDate{
                get{
                    return this.GetColumn("ModifyDate");
                }
            }
				
   			public static string ModifyDateColumn{
			      get{
        			return "ModifyDate";
      			}
		    }
            
            public IColumn TemplateNumber{
                get{
                    return this.GetColumn("TemplateNumber");
                }
            }
				
   			public static string TemplateNumberColumn{
			      get{
        			return "TemplateNumber";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: AppUserPush
        /// Primary Key: AppUserPushID
        /// </summary>

        public class AppUserPushTable: DatabaseTable {
            
            public AppUserPushTable(IDataProvider provider):base("AppUserPush",provider){
                ClassName = "AppUserPush";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("AppUserPushID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AppUserID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("PushUsername", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("PushPassword", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("PushUserID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("StatusID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreateDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifyDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Badge", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn AppUserPushID{
                get{
                    return this.GetColumn("AppUserPushID");
                }
            }
				
   			public static string AppUserPushIDColumn{
			      get{
        			return "AppUserPushID";
      			}
		    }
            
            public IColumn AppUserID{
                get{
                    return this.GetColumn("AppUserID");
                }
            }
				
   			public static string AppUserIDColumn{
			      get{
        			return "AppUserID";
      			}
		    }
            
            public IColumn PushUsername{
                get{
                    return this.GetColumn("PushUsername");
                }
            }
				
   			public static string PushUsernameColumn{
			      get{
        			return "PushUsername";
      			}
		    }
            
            public IColumn PushPassword{
                get{
                    return this.GetColumn("PushPassword");
                }
            }
				
   			public static string PushPasswordColumn{
			      get{
        			return "PushPassword";
      			}
		    }
            
            public IColumn PushUserID{
                get{
                    return this.GetColumn("PushUserID");
                }
            }
				
   			public static string PushUserIDColumn{
			      get{
        			return "PushUserID";
      			}
		    }
            
            public IColumn StatusID{
                get{
                    return this.GetColumn("StatusID");
                }
            }
				
   			public static string StatusIDColumn{
			      get{
        			return "StatusID";
      			}
		    }
            
            public IColumn CreateDate{
                get{
                    return this.GetColumn("CreateDate");
                }
            }
				
   			public static string CreateDateColumn{
			      get{
        			return "CreateDate";
      			}
		    }
            
            public IColumn ModifyDate{
                get{
                    return this.GetColumn("ModifyDate");
                }
            }
				
   			public static string ModifyDateColumn{
			      get{
        			return "ModifyDate";
      			}
		    }
            
            public IColumn Badge{
                get{
                    return this.GetColumn("Badge");
                }
            }
				
   			public static string BadgeColumn{
			      get{
        			return "Badge";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: url_short
        /// Primary Key: short_url_ID
        /// </summary>

        public class url_shortTable: DatabaseTable {
            
            public url_shortTable(IDataProvider provider):base("url_short",provider){
                ClassName = "url_short";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("short_url_ID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("short_url", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 10
                });

                Columns.Add(new DatabaseColumn("create_date", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("created_by", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 15
                });

                Columns.Add(new DatabaseColumn("real_url", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 200
                });
                    
                
                
            }

            public IColumn short_url_ID{
                get{
                    return this.GetColumn("short_url_ID");
                }
            }
				
   			public static string short_url_IDColumn{
			      get{
        			return "short_url_ID";
      			}
		    }
            
            public IColumn short_url{
                get{
                    return this.GetColumn("short_url");
                }
            }
				
   			public static string short_urlColumn{
			      get{
        			return "short_url";
      			}
		    }
            
            public IColumn create_date{
                get{
                    return this.GetColumn("create_date");
                }
            }
				
   			public static string create_dateColumn{
			      get{
        			return "create_date";
      			}
		    }
            
            public IColumn created_by{
                get{
                    return this.GetColumn("created_by");
                }
            }
				
   			public static string created_byColumn{
			      get{
        			return "created_by";
      			}
		    }
            
            public IColumn real_url{
                get{
                    return this.GetColumn("real_url");
                }
            }
				
   			public static string real_urlColumn{
			      get{
        			return "real_url";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: AppUserPushSession
        /// Primary Key: AppUserPushSessionID
        /// </summary>

        public class AppUserPushSessionTable: DatabaseTable {
            
            public AppUserPushSessionTable(IDataProvider provider):base("AppUserPushSession",provider){
                ClassName = "AppUserPushSession";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("AppUserPushSessionID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AppUserPushID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SessionID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 300
                });

                Columns.Add(new DatabaseColumn("SessionStart", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn AppUserPushSessionID{
                get{
                    return this.GetColumn("AppUserPushSessionID");
                }
            }
				
   			public static string AppUserPushSessionIDColumn{
			      get{
        			return "AppUserPushSessionID";
      			}
		    }
            
            public IColumn AppUserPushID{
                get{
                    return this.GetColumn("AppUserPushID");
                }
            }
				
   			public static string AppUserPushIDColumn{
			      get{
        			return "AppUserPushID";
      			}
		    }
            
            public IColumn SessionID{
                get{
                    return this.GetColumn("SessionID");
                }
            }
				
   			public static string SessionIDColumn{
			      get{
        			return "SessionID";
      			}
		    }
            
            public IColumn SessionStart{
                get{
                    return this.GetColumn("SessionStart");
                }
            }
				
   			public static string SessionStartColumn{
			      get{
        			return "SessionStart";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: EmailLog
        /// Primary Key: EmailLogID
        /// </summary>

        public class EmailLogTable: DatabaseTable {
            
            public EmailLogTable(IDataProvider provider):base("EmailLog",provider){
                ClassName = "EmailLog";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("EmailLogID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("EmailTemplateID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ToEmail", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("ToAppUserID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("FromEmail", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("FromAppUserID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Subject", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 200
                });

                Columns.Add(new DatabaseColumn("EmailMessage", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("MessageTypeID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SentDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Successful", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("QueueDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("FailureReason", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });
                    
                
                
            }

            public IColumn EmailLogID{
                get{
                    return this.GetColumn("EmailLogID");
                }
            }
				
   			public static string EmailLogIDColumn{
			      get{
        			return "EmailLogID";
      			}
		    }
            
            public IColumn EmailTemplateID{
                get{
                    return this.GetColumn("EmailTemplateID");
                }
            }
				
   			public static string EmailTemplateIDColumn{
			      get{
        			return "EmailTemplateID";
      			}
		    }
            
            public IColumn ToEmail{
                get{
                    return this.GetColumn("ToEmail");
                }
            }
				
   			public static string ToEmailColumn{
			      get{
        			return "ToEmail";
      			}
		    }
            
            public IColumn ToAppUserID{
                get{
                    return this.GetColumn("ToAppUserID");
                }
            }
				
   			public static string ToAppUserIDColumn{
			      get{
        			return "ToAppUserID";
      			}
		    }
            
            public IColumn FromEmail{
                get{
                    return this.GetColumn("FromEmail");
                }
            }
				
   			public static string FromEmailColumn{
			      get{
        			return "FromEmail";
      			}
		    }
            
            public IColumn FromAppUserID{
                get{
                    return this.GetColumn("FromAppUserID");
                }
            }
				
   			public static string FromAppUserIDColumn{
			      get{
        			return "FromAppUserID";
      			}
		    }
            
            public IColumn Subject{
                get{
                    return this.GetColumn("Subject");
                }
            }
				
   			public static string SubjectColumn{
			      get{
        			return "Subject";
      			}
		    }
            
            public IColumn EmailMessage{
                get{
                    return this.GetColumn("EmailMessage");
                }
            }
				
   			public static string EmailMessageColumn{
			      get{
        			return "EmailMessage";
      			}
		    }
            
            public IColumn MessageTypeID{
                get{
                    return this.GetColumn("MessageTypeID");
                }
            }
				
   			public static string MessageTypeIDColumn{
			      get{
        			return "MessageTypeID";
      			}
		    }
            
            public IColumn SentDate{
                get{
                    return this.GetColumn("SentDate");
                }
            }
				
   			public static string SentDateColumn{
			      get{
        			return "SentDate";
      			}
		    }
            
            public IColumn Successful{
                get{
                    return this.GetColumn("Successful");
                }
            }
				
   			public static string SuccessfulColumn{
			      get{
        			return "Successful";
      			}
		    }
            
            public IColumn QueueDate{
                get{
                    return this.GetColumn("QueueDate");
                }
            }
				
   			public static string QueueDateColumn{
			      get{
        			return "QueueDate";
      			}
		    }
            
            public IColumn FailureReason{
                get{
                    return this.GetColumn("FailureReason");
                }
            }
				
   			public static string FailureReasonColumn{
			      get{
        			return "FailureReason";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: MeetballResponseLog
        /// Primary Key: MeetballResponseLogID
        /// </summary>

        public class MeetballResponseLogTable: DatabaseTable {
            
            public MeetballResponseLogTable(IDataProvider provider):base("MeetballResponseLog",provider){
                ClassName = "MeetballResponseLog";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("MeetballResponseLogID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("MeetballResponseID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ResponseID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ResponseDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn MeetballResponseLogID{
                get{
                    return this.GetColumn("MeetballResponseLogID");
                }
            }
				
   			public static string MeetballResponseLogIDColumn{
			      get{
        			return "MeetballResponseLogID";
      			}
		    }
            
            public IColumn MeetballResponseID{
                get{
                    return this.GetColumn("MeetballResponseID");
                }
            }
				
   			public static string MeetballResponseIDColumn{
			      get{
        			return "MeetballResponseID";
      			}
		    }
            
            public IColumn ResponseID{
                get{
                    return this.GetColumn("ResponseID");
                }
            }
				
   			public static string ResponseIDColumn{
			      get{
        			return "ResponseID";
      			}
		    }
            
            public IColumn ResponseDate{
                get{
                    return this.GetColumn("ResponseDate");
                }
            }
				
   			public static string ResponseDateColumn{
			      get{
        			return "ResponseDate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: MessageType
        /// Primary Key: MessageTypeID
        /// </summary>

        public class MessageTypeTable: DatabaseTable {
            
            public MessageTypeTable(IDataProvider provider):base("MessageType",provider){
                ClassName = "MessageType";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("MessageTypeID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("MessageTypeName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("StatusID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreateDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifyDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn MessageTypeID{
                get{
                    return this.GetColumn("MessageTypeID");
                }
            }
				
   			public static string MessageTypeIDColumn{
			      get{
        			return "MessageTypeID";
      			}
		    }
            
            public IColumn MessageTypeName{
                get{
                    return this.GetColumn("MessageTypeName");
                }
            }
				
   			public static string MessageTypeNameColumn{
			      get{
        			return "MessageTypeName";
      			}
		    }
            
            public IColumn StatusID{
                get{
                    return this.GetColumn("StatusID");
                }
            }
				
   			public static string StatusIDColumn{
			      get{
        			return "StatusID";
      			}
		    }
            
            public IColumn CreateDate{
                get{
                    return this.GetColumn("CreateDate");
                }
            }
				
   			public static string CreateDateColumn{
			      get{
        			return "CreateDate";
      			}
		    }
            
            public IColumn ModifyDate{
                get{
                    return this.GetColumn("ModifyDate");
                }
            }
				
   			public static string ModifyDateColumn{
			      get{
        			return "ModifyDate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: Platform
        /// Primary Key: PlatformID
        /// </summary>

        public class PlatformTable: DatabaseTable {
            
            public PlatformTable(IDataProvider provider):base("Platform",provider){
                ClassName = "Platform";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("PlatformID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("PlatformName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("Notes", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 1000
                });

                Columns.Add(new DatabaseColumn("StatusID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreateDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifyDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn PlatformID{
                get{
                    return this.GetColumn("PlatformID");
                }
            }
				
   			public static string PlatformIDColumn{
			      get{
        			return "PlatformID";
      			}
		    }
            
            public IColumn PlatformName{
                get{
                    return this.GetColumn("PlatformName");
                }
            }
				
   			public static string PlatformNameColumn{
			      get{
        			return "PlatformName";
      			}
		    }
            
            public IColumn Notes{
                get{
                    return this.GetColumn("Notes");
                }
            }
				
   			public static string NotesColumn{
			      get{
        			return "Notes";
      			}
		    }
            
            public IColumn StatusID{
                get{
                    return this.GetColumn("StatusID");
                }
            }
				
   			public static string StatusIDColumn{
			      get{
        			return "StatusID";
      			}
		    }
            
            public IColumn CreateDate{
                get{
                    return this.GetColumn("CreateDate");
                }
            }
				
   			public static string CreateDateColumn{
			      get{
        			return "CreateDate";
      			}
		    }
            
            public IColumn ModifyDate{
                get{
                    return this.GetColumn("ModifyDate");
                }
            }
				
   			public static string ModifyDateColumn{
			      get{
        			return "ModifyDate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: AppUserLog
        /// Primary Key: AppUserLogID
        /// </summary>

        public class AppUserLogTable: DatabaseTable {
            
            public AppUserLogTable(IDataProvider provider):base("AppUserLog",provider){
                ClassName = "AppUserLog";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("AppUserLogID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AppUserID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ActivatedLogDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn AppUserLogID{
                get{
                    return this.GetColumn("AppUserLogID");
                }
            }
				
   			public static string AppUserLogIDColumn{
			      get{
        			return "AppUserLogID";
      			}
		    }
            
            public IColumn AppUserID{
                get{
                    return this.GetColumn("AppUserID");
                }
            }
				
   			public static string AppUserIDColumn{
			      get{
        			return "AppUserID";
      			}
		    }
            
            public IColumn ActivatedLogDate{
                get{
                    return this.GetColumn("ActivatedLogDate");
                }
            }
				
   			public static string ActivatedLogDateColumn{
			      get{
        			return "ActivatedLogDate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: WebAsset
        /// Primary Key: WebAssetId
        /// </summary>

        public class WebAssetTable: DatabaseTable {
            
            public WebAssetTable(IDataProvider provider):base("WebAsset",provider){
                ClassName = "WebAsset";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("WebAssetId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });

                Columns.Add(new DatabaseColumn("Description", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("Url", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 2000
                });

                Columns.Add(new DatabaseColumn("WebAssetCollectionId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SortOrder", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("PlatformID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Version", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("StatusID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreateDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifyDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn WebAssetId{
                get{
                    return this.GetColumn("WebAssetId");
                }
            }
				
   			public static string WebAssetIdColumn{
			      get{
        			return "WebAssetId";
      			}
		    }
            
            public IColumn Name{
                get{
                    return this.GetColumn("Name");
                }
            }
				
   			public static string NameColumn{
			      get{
        			return "Name";
      			}
		    }
            
            public IColumn Description{
                get{
                    return this.GetColumn("Description");
                }
            }
				
   			public static string DescriptionColumn{
			      get{
        			return "Description";
      			}
		    }
            
            public IColumn Url{
                get{
                    return this.GetColumn("Url");
                }
            }
				
   			public static string UrlColumn{
			      get{
        			return "Url";
      			}
		    }
            
            public IColumn WebAssetCollectionId{
                get{
                    return this.GetColumn("WebAssetCollectionId");
                }
            }
				
   			public static string WebAssetCollectionIdColumn{
			      get{
        			return "WebAssetCollectionId";
      			}
		    }
            
            public IColumn SortOrder{
                get{
                    return this.GetColumn("SortOrder");
                }
            }
				
   			public static string SortOrderColumn{
			      get{
        			return "SortOrder";
      			}
		    }
            
            public IColumn PlatformID{
                get{
                    return this.GetColumn("PlatformID");
                }
            }
				
   			public static string PlatformIDColumn{
			      get{
        			return "PlatformID";
      			}
		    }
            
            public IColumn Version{
                get{
                    return this.GetColumn("Version");
                }
            }
				
   			public static string VersionColumn{
			      get{
        			return "Version";
      			}
		    }
            
            public IColumn StatusID{
                get{
                    return this.GetColumn("StatusID");
                }
            }
				
   			public static string StatusIDColumn{
			      get{
        			return "StatusID";
      			}
		    }
            
            public IColumn CreateDate{
                get{
                    return this.GetColumn("CreateDate");
                }
            }
				
   			public static string CreateDateColumn{
			      get{
        			return "CreateDate";
      			}
		    }
            
            public IColumn ModifyDate{
                get{
                    return this.GetColumn("ModifyDate");
                }
            }
				
   			public static string ModifyDateColumn{
			      get{
        			return "ModifyDate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: LoginType
        /// Primary Key: LoginTypeID
        /// </summary>

        public class LoginTypeTable: DatabaseTable {
            
            public LoginTypeTable(IDataProvider provider):base("LoginType",provider){
                ClassName = "LoginType";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("LoginTypeID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("LoginTypeName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("StatusID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreateDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifyDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn LoginTypeID{
                get{
                    return this.GetColumn("LoginTypeID");
                }
            }
				
   			public static string LoginTypeIDColumn{
			      get{
        			return "LoginTypeID";
      			}
		    }
            
            public IColumn LoginTypeName{
                get{
                    return this.GetColumn("LoginTypeName");
                }
            }
				
   			public static string LoginTypeNameColumn{
			      get{
        			return "LoginTypeName";
      			}
		    }
            
            public IColumn StatusID{
                get{
                    return this.GetColumn("StatusID");
                }
            }
				
   			public static string StatusIDColumn{
			      get{
        			return "StatusID";
      			}
		    }
            
            public IColumn CreateDate{
                get{
                    return this.GetColumn("CreateDate");
                }
            }
				
   			public static string CreateDateColumn{
			      get{
        			return "CreateDate";
      			}
		    }
            
            public IColumn ModifyDate{
                get{
                    return this.GetColumn("ModifyDate");
                }
            }
				
   			public static string ModifyDateColumn{
			      get{
        			return "ModifyDate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: MeetballLog
        /// Primary Key: MeetballLogID
        /// </summary>

        public class MeetballLogTable: DatabaseTable {
            
            public MeetballLogTable(IDataProvider provider):base("MeetballLog",provider){
                ClassName = "MeetballLog";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("MeetballLogID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("MeetballID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("GeneralLocationGPXWKT", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 200
                });

                Columns.Add(new DatabaseColumn("GeneralLocationGPXTypeID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("GeneralLocationLogDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SpecificLocationGPXWKT", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 200
                });

                Columns.Add(new DatabaseColumn("SpecificLocationGPXTypeID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SpecificLocationLogDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn MeetballLogID{
                get{
                    return this.GetColumn("MeetballLogID");
                }
            }
				
   			public static string MeetballLogIDColumn{
			      get{
        			return "MeetballLogID";
      			}
		    }
            
            public IColumn MeetballID{
                get{
                    return this.GetColumn("MeetballID");
                }
            }
				
   			public static string MeetballIDColumn{
			      get{
        			return "MeetballID";
      			}
		    }
            
            public IColumn GeneralLocationGPXWKT{
                get{
                    return this.GetColumn("GeneralLocationGPXWKT");
                }
            }
				
   			public static string GeneralLocationGPXWKTColumn{
			      get{
        			return "GeneralLocationGPXWKT";
      			}
		    }
            
            public IColumn GeneralLocationGPXTypeID{
                get{
                    return this.GetColumn("GeneralLocationGPXTypeID");
                }
            }
				
   			public static string GeneralLocationGPXTypeIDColumn{
			      get{
        			return "GeneralLocationGPXTypeID";
      			}
		    }
            
            public IColumn GeneralLocationLogDate{
                get{
                    return this.GetColumn("GeneralLocationLogDate");
                }
            }
				
   			public static string GeneralLocationLogDateColumn{
			      get{
        			return "GeneralLocationLogDate";
      			}
		    }
            
            public IColumn SpecificLocationGPXWKT{
                get{
                    return this.GetColumn("SpecificLocationGPXWKT");
                }
            }
				
   			public static string SpecificLocationGPXWKTColumn{
			      get{
        			return "SpecificLocationGPXWKT";
      			}
		    }
            
            public IColumn SpecificLocationGPXTypeID{
                get{
                    return this.GetColumn("SpecificLocationGPXTypeID");
                }
            }
				
   			public static string SpecificLocationGPXTypeIDColumn{
			      get{
        			return "SpecificLocationGPXTypeID";
      			}
		    }
            
            public IColumn SpecificLocationLogDate{
                get{
                    return this.GetColumn("SpecificLocationLogDate");
                }
            }
				
   			public static string SpecificLocationLogDateColumn{
			      get{
        			return "SpecificLocationLogDate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: MeetballTracking
        /// Primary Key: MeetballTrackingID
        /// </summary>

        public class MeetballTrackingTable: DatabaseTable {
            
            public MeetballTrackingTable(IDataProvider provider):base("MeetballTracking",provider){
                ClassName = "MeetballTracking";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("MeetballTrackingID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("MeetballID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AppUserID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("TrackingDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("TrackingGPXWKT", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 200
                });

                Columns.Add(new DatabaseColumn("TrackingGPXTypeID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("MeetballTrackingSessionId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Guid,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Accuracy", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("GPSTracking", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Complete", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn MeetballTrackingID{
                get{
                    return this.GetColumn("MeetballTrackingID");
                }
            }
				
   			public static string MeetballTrackingIDColumn{
			      get{
        			return "MeetballTrackingID";
      			}
		    }
            
            public IColumn MeetballID{
                get{
                    return this.GetColumn("MeetballID");
                }
            }
				
   			public static string MeetballIDColumn{
			      get{
        			return "MeetballID";
      			}
		    }
            
            public IColumn AppUserID{
                get{
                    return this.GetColumn("AppUserID");
                }
            }
				
   			public static string AppUserIDColumn{
			      get{
        			return "AppUserID";
      			}
		    }
            
            public IColumn TrackingDate{
                get{
                    return this.GetColumn("TrackingDate");
                }
            }
				
   			public static string TrackingDateColumn{
			      get{
        			return "TrackingDate";
      			}
		    }
            
            public IColumn TrackingGPXWKT{
                get{
                    return this.GetColumn("TrackingGPXWKT");
                }
            }
				
   			public static string TrackingGPXWKTColumn{
			      get{
        			return "TrackingGPXWKT";
      			}
		    }
            
            public IColumn TrackingGPXTypeID{
                get{
                    return this.GetColumn("TrackingGPXTypeID");
                }
            }
				
   			public static string TrackingGPXTypeIDColumn{
			      get{
        			return "TrackingGPXTypeID";
      			}
		    }
            
            public IColumn MeetballTrackingSessionId{
                get{
                    return this.GetColumn("MeetballTrackingSessionId");
                }
            }
				
   			public static string MeetballTrackingSessionIdColumn{
			      get{
        			return "MeetballTrackingSessionId";
      			}
		    }
            
            public IColumn Accuracy{
                get{
                    return this.GetColumn("Accuracy");
                }
            }
				
   			public static string AccuracyColumn{
			      get{
        			return "Accuracy";
      			}
		    }
            
            public IColumn GPSTracking{
                get{
                    return this.GetColumn("GPSTracking");
                }
            }
				
   			public static string GPSTrackingColumn{
			      get{
        			return "GPSTracking";
      			}
		    }
            
            public IColumn Complete{
                get{
                    return this.GetColumn("Complete");
                }
            }
				
   			public static string CompleteColumn{
			      get{
        			return "Complete";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: MeetballResponse
        /// Primary Key: MeetballResponseID
        /// </summary>

        public class MeetballResponseTable: DatabaseTable {
            
            public MeetballResponseTable(IDataProvider provider):base("MeetballResponse",provider){
                ClassName = "MeetballResponse";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("MeetballResponseID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("MeetballID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AppUserID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("InvitedByAppUserID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SentDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("StatusID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ResponseID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ResponseDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("LocationSharingID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ExpirationDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("BroadcastID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("NewUpdates", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ToRead", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifyDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn MeetballResponseID{
                get{
                    return this.GetColumn("MeetballResponseID");
                }
            }
				
   			public static string MeetballResponseIDColumn{
			      get{
        			return "MeetballResponseID";
      			}
		    }
            
            public IColumn MeetballID{
                get{
                    return this.GetColumn("MeetballID");
                }
            }
				
   			public static string MeetballIDColumn{
			      get{
        			return "MeetballID";
      			}
		    }
            
            public IColumn AppUserID{
                get{
                    return this.GetColumn("AppUserID");
                }
            }
				
   			public static string AppUserIDColumn{
			      get{
        			return "AppUserID";
      			}
		    }
            
            public IColumn InvitedByAppUserID{
                get{
                    return this.GetColumn("InvitedByAppUserID");
                }
            }
				
   			public static string InvitedByAppUserIDColumn{
			      get{
        			return "InvitedByAppUserID";
      			}
		    }
            
            public IColumn SentDate{
                get{
                    return this.GetColumn("SentDate");
                }
            }
				
   			public static string SentDateColumn{
			      get{
        			return "SentDate";
      			}
		    }
            
            public IColumn StatusID{
                get{
                    return this.GetColumn("StatusID");
                }
            }
				
   			public static string StatusIDColumn{
			      get{
        			return "StatusID";
      			}
		    }
            
            public IColumn ResponseID{
                get{
                    return this.GetColumn("ResponseID");
                }
            }
				
   			public static string ResponseIDColumn{
			      get{
        			return "ResponseID";
      			}
		    }
            
            public IColumn ResponseDate{
                get{
                    return this.GetColumn("ResponseDate");
                }
            }
				
   			public static string ResponseDateColumn{
			      get{
        			return "ResponseDate";
      			}
		    }
            
            public IColumn LocationSharingID{
                get{
                    return this.GetColumn("LocationSharingID");
                }
            }
				
   			public static string LocationSharingIDColumn{
			      get{
        			return "LocationSharingID";
      			}
		    }
            
            public IColumn ExpirationDate{
                get{
                    return this.GetColumn("ExpirationDate");
                }
            }
				
   			public static string ExpirationDateColumn{
			      get{
        			return "ExpirationDate";
      			}
		    }
            
            public IColumn BroadcastID{
                get{
                    return this.GetColumn("BroadcastID");
                }
            }
				
   			public static string BroadcastIDColumn{
			      get{
        			return "BroadcastID";
      			}
		    }
            
            public IColumn NewUpdates{
                get{
                    return this.GetColumn("NewUpdates");
                }
            }
				
   			public static string NewUpdatesColumn{
			      get{
        			return "NewUpdates";
      			}
		    }
            
            public IColumn ToRead{
                get{
                    return this.GetColumn("ToRead");
                }
            }
				
   			public static string ToReadColumn{
			      get{
        			return "ToRead";
      			}
		    }
            
            public IColumn ModifyDate{
                get{
                    return this.GetColumn("ModifyDate");
                }
            }
				
   			public static string ModifyDateColumn{
			      get{
        			return "ModifyDate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: ncaa_import
        /// Primary Key: 
        /// </summary>

        public class ncaa_importTable: DatabaseTable {
            
            public ncaa_importTable(IDataProvider provider):base("ncaa_import",provider){
                ClassName = "ncaa_import";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("Team", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("ConferenceID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Mascot", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Column 3", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Column 4", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Column 5", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Column 6", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Column 7", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });
                    
                
                
            }

            public IColumn Team{
                get{
                    return this.GetColumn("Team");
                }
            }
				
   			public static string TeamColumn{
			      get{
        			return "Team";
      			}
		    }
            
            public IColumn ConferenceID{
                get{
                    return this.GetColumn("ConferenceID");
                }
            }
				
   			public static string ConferenceIDColumn{
			      get{
        			return "ConferenceID";
      			}
		    }
            
            public IColumn Mascot{
                get{
                    return this.GetColumn("Mascot");
                }
            }
				
   			public static string MascotColumn{
			      get{
        			return "Mascot";
      			}
		    }
            
            public IColumn Column3{
                get{
                    return this.GetColumn("Column 3");
                }
            }
				
   			public static string Column3Column{
			      get{
        			return "Column 3";
      			}
		    }
            
            public IColumn Column4{
                get{
                    return this.GetColumn("Column 4");
                }
            }
				
   			public static string Column4Column{
			      get{
        			return "Column 4";
      			}
		    }
            
            public IColumn Column5{
                get{
                    return this.GetColumn("Column 5");
                }
            }
				
   			public static string Column5Column{
			      get{
        			return "Column 5";
      			}
		    }
            
            public IColumn Column6{
                get{
                    return this.GetColumn("Column 6");
                }
            }
				
   			public static string Column6Column{
			      get{
        			return "Column 6";
      			}
		    }
            
            public IColumn Column7{
                get{
                    return this.GetColumn("Column 7");
                }
            }
				
   			public static string Column7Column{
			      get{
        			return "Column 7";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: FBAppUser
        /// Primary Key: FBAppUserID
        /// </summary>

        public class FBAppUserTable: DatabaseTable {
            
            public FBAppUserTable(IDataProvider provider):base("FBAppUser",provider){
                ClassName = "FBAppUser";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("FBAppUserID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AppUserID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("FirstName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("LastName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("MiddleName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("Gender", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("Locale", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("UserName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("ProfilePictureURL", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("Email", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("Link", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsPictureSilhouette", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn FBAppUserID{
                get{
                    return this.GetColumn("FBAppUserID");
                }
            }
				
   			public static string FBAppUserIDColumn{
			      get{
        			return "FBAppUserID";
      			}
		    }
            
            public IColumn AppUserID{
                get{
                    return this.GetColumn("AppUserID");
                }
            }
				
   			public static string AppUserIDColumn{
			      get{
        			return "AppUserID";
      			}
		    }
            
            public IColumn FirstName{
                get{
                    return this.GetColumn("FirstName");
                }
            }
				
   			public static string FirstNameColumn{
			      get{
        			return "FirstName";
      			}
		    }
            
            public IColumn LastName{
                get{
                    return this.GetColumn("LastName");
                }
            }
				
   			public static string LastNameColumn{
			      get{
        			return "LastName";
      			}
		    }
            
            public IColumn MiddleName{
                get{
                    return this.GetColumn("MiddleName");
                }
            }
				
   			public static string MiddleNameColumn{
			      get{
        			return "MiddleName";
      			}
		    }
            
            public IColumn Gender{
                get{
                    return this.GetColumn("Gender");
                }
            }
				
   			public static string GenderColumn{
			      get{
        			return "Gender";
      			}
		    }
            
            public IColumn Locale{
                get{
                    return this.GetColumn("Locale");
                }
            }
				
   			public static string LocaleColumn{
			      get{
        			return "Locale";
      			}
		    }
            
            public IColumn UserName{
                get{
                    return this.GetColumn("UserName");
                }
            }
				
   			public static string UserNameColumn{
			      get{
        			return "UserName";
      			}
		    }
            
            public IColumn ProfilePictureURL{
                get{
                    return this.GetColumn("ProfilePictureURL");
                }
            }
				
   			public static string ProfilePictureURLColumn{
			      get{
        			return "ProfilePictureURL";
      			}
		    }
            
            public IColumn Email{
                get{
                    return this.GetColumn("Email");
                }
            }
				
   			public static string EmailColumn{
			      get{
        			return "Email";
      			}
		    }
            
            public IColumn Link{
                get{
                    return this.GetColumn("Link");
                }
            }
				
   			public static string LinkColumn{
			      get{
        			return "Link";
      			}
		    }
            
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
            
            public IColumn IsPictureSilhouette{
                get{
                    return this.GetColumn("IsPictureSilhouette");
                }
            }
				
   			public static string IsPictureSilhouetteColumn{
			      get{
        			return "IsPictureSilhouette";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: AppSession
        /// Primary Key: SessionGuid
        /// </summary>

        public class AppSessionTable: DatabaseTable {
            
            public AppSessionTable(IDataProvider provider):base("AppSession",provider){
                ClassName = "AppSession";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("SessionGuid", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Guid,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AppUserId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SessionStart", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SessionEnd", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ApiKeyGuid", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Guid,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("LoginTypeID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("FacebookAuthToken", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });
                    
                
                
            }

            public IColumn SessionGuid{
                get{
                    return this.GetColumn("SessionGuid");
                }
            }
				
   			public static string SessionGuidColumn{
			      get{
        			return "SessionGuid";
      			}
		    }
            
            public IColumn AppUserId{
                get{
                    return this.GetColumn("AppUserId");
                }
            }
				
   			public static string AppUserIdColumn{
			      get{
        			return "AppUserId";
      			}
		    }
            
            public IColumn SessionStart{
                get{
                    return this.GetColumn("SessionStart");
                }
            }
				
   			public static string SessionStartColumn{
			      get{
        			return "SessionStart";
      			}
		    }
            
            public IColumn SessionEnd{
                get{
                    return this.GetColumn("SessionEnd");
                }
            }
				
   			public static string SessionEndColumn{
			      get{
        			return "SessionEnd";
      			}
		    }
            
            public IColumn ApiKeyGuid{
                get{
                    return this.GetColumn("ApiKeyGuid");
                }
            }
				
   			public static string ApiKeyGuidColumn{
			      get{
        			return "ApiKeyGuid";
      			}
		    }
            
            public IColumn LoginTypeID{
                get{
                    return this.GetColumn("LoginTypeID");
                }
            }
				
   			public static string LoginTypeIDColumn{
			      get{
        			return "LoginTypeID";
      			}
		    }
            
            public IColumn FacebookAuthToken{
                get{
                    return this.GetColumn("FacebookAuthToken");
                }
            }
				
   			public static string FacebookAuthTokenColumn{
			      get{
        			return "FacebookAuthToken";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: MethodLog
        /// Primary Key: MethodLogID
        /// </summary>

        public class MethodLogTable: DatabaseTable {
            
            public MethodLogTable(IDataProvider provider):base("MethodLog",provider){
                ClassName = "MethodLog";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("MethodLogID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("MethodLogName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("MethodParameters", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("CallDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Successful", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AppSessionGuid", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Guid,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ExceptionGuid", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Guid,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("MBExceptionGuid", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Guid,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Duration", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Double,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("TestBool", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("API", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 10
                });

                Columns.Add(new DatabaseColumn("RetVal", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 1000
                });
                    
                
                
            }

            public IColumn MethodLogID{
                get{
                    return this.GetColumn("MethodLogID");
                }
            }
				
   			public static string MethodLogIDColumn{
			      get{
        			return "MethodLogID";
      			}
		    }
            
            public IColumn MethodLogName{
                get{
                    return this.GetColumn("MethodLogName");
                }
            }
				
   			public static string MethodLogNameColumn{
			      get{
        			return "MethodLogName";
      			}
		    }
            
            public IColumn MethodParameters{
                get{
                    return this.GetColumn("MethodParameters");
                }
            }
				
   			public static string MethodParametersColumn{
			      get{
        			return "MethodParameters";
      			}
		    }
            
            public IColumn CallDate{
                get{
                    return this.GetColumn("CallDate");
                }
            }
				
   			public static string CallDateColumn{
			      get{
        			return "CallDate";
      			}
		    }
            
            public IColumn Successful{
                get{
                    return this.GetColumn("Successful");
                }
            }
				
   			public static string SuccessfulColumn{
			      get{
        			return "Successful";
      			}
		    }
            
            public IColumn AppSessionGuid{
                get{
                    return this.GetColumn("AppSessionGuid");
                }
            }
				
   			public static string AppSessionGuidColumn{
			      get{
        			return "AppSessionGuid";
      			}
		    }
            
            public IColumn ExceptionGuid{
                get{
                    return this.GetColumn("ExceptionGuid");
                }
            }
				
   			public static string ExceptionGuidColumn{
			      get{
        			return "ExceptionGuid";
      			}
		    }
            
            public IColumn MBExceptionGuid{
                get{
                    return this.GetColumn("MBExceptionGuid");
                }
            }
				
   			public static string MBExceptionGuidColumn{
			      get{
        			return "MBExceptionGuid";
      			}
		    }
            
            public IColumn Duration{
                get{
                    return this.GetColumn("Duration");
                }
            }
				
   			public static string DurationColumn{
			      get{
        			return "Duration";
      			}
		    }
            
            public IColumn TestBool{
                get{
                    return this.GetColumn("TestBool");
                }
            }
				
   			public static string TestBoolColumn{
			      get{
        			return "TestBool";
      			}
		    }
            
            public IColumn API{
                get{
                    return this.GetColumn("API");
                }
            }
				
   			public static string APIColumn{
			      get{
        			return "API";
      			}
		    }
            
            public IColumn RetVal{
                get{
                    return this.GetColumn("RetVal");
                }
            }
				
   			public static string RetValColumn{
			      get{
        			return "RetVal";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: Broadcast
        /// Primary Key: BroadcastID
        /// </summary>

        public class BroadcastTable: DatabaseTable {
            
            public BroadcastTable(IDataProvider provider):base("Broadcast",provider){
                ClassName = "Broadcast";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("BroadcastID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AppUserID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("BroadcastDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("BroadcastGPXWKT", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 200
                });
                    
                
                
            }

            public IColumn BroadcastID{
                get{
                    return this.GetColumn("BroadcastID");
                }
            }
				
   			public static string BroadcastIDColumn{
			      get{
        			return "BroadcastID";
      			}
		    }
            
            public IColumn AppUserID{
                get{
                    return this.GetColumn("AppUserID");
                }
            }
				
   			public static string AppUserIDColumn{
			      get{
        			return "AppUserID";
      			}
		    }
            
            public IColumn BroadcastDate{
                get{
                    return this.GetColumn("BroadcastDate");
                }
            }
				
   			public static string BroadcastDateColumn{
			      get{
        			return "BroadcastDate";
      			}
		    }
            
            public IColumn BroadcastGPXWKT{
                get{
                    return this.GetColumn("BroadcastGPXWKT");
                }
            }
				
   			public static string BroadcastGPXWKTColumn{
			      get{
        			return "BroadcastGPXWKT";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: MeetBallXBroadcast
        /// Primary Key: BroadcastID
        /// </summary>

        public class MeetBallXBroadcastTable: DatabaseTable {
            
            public MeetBallXBroadcastTable(IDataProvider provider):base("MeetBallXBroadcast",provider){
                ClassName = "MeetBallXBroadcast";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("MeetballID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("BroadcastID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn MeetballID{
                get{
                    return this.GetColumn("MeetballID");
                }
            }
				
   			public static string MeetballIDColumn{
			      get{
        			return "MeetballID";
      			}
		    }
            
            public IColumn BroadcastID{
                get{
                    return this.GetColumn("BroadcastID");
                }
            }
				
   			public static string BroadcastIDColumn{
			      get{
        			return "BroadcastID";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: MBXBroadcastTemp
        /// Primary Key: BroadcastID
        /// </summary>

        public class MBXBroadcastTempTable: DatabaseTable {
            
            public MBXBroadcastTempTable(IDataProvider provider):base("MBXBroadcastTemp",provider){
                ClassName = "MBXBroadcastTemp";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("BroadcastID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("MeetballID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn BroadcastID{
                get{
                    return this.GetColumn("BroadcastID");
                }
            }
				
   			public static string BroadcastIDColumn{
			      get{
        			return "BroadcastID";
      			}
		    }
            
            public IColumn MeetballID{
                get{
                    return this.GetColumn("MeetballID");
                }
            }
				
   			public static string MeetballIDColumn{
			      get{
        			return "MeetballID";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: AppUserXNotPossibleFriendAppUser
        /// Primary Key: AppUserID
        /// </summary>

        public class AppUserXNotPossibleFriendAppUserTable: DatabaseTable {
            
            public AppUserXNotPossibleFriendAppUserTable(IDataProvider provider):base("AppUserXNotPossibleFriendAppUser",provider){
                ClassName = "AppUserXNotPossibleFriendAppUser";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("AppUserID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("NotPossibleAppUserID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn AppUserID{
                get{
                    return this.GetColumn("AppUserID");
                }
            }
				
   			public static string AppUserIDColumn{
			      get{
        			return "AppUserID";
      			}
		    }
            
            public IColumn NotPossibleAppUserID{
                get{
                    return this.GetColumn("NotPossibleAppUserID");
                }
            }
				
   			public static string NotPossibleAppUserIDColumn{
			      get{
        			return "NotPossibleAppUserID";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: AppUserMerge
        /// Primary Key: AppUserMergeID
        /// </summary>

        public class AppUserMergeTable: DatabaseTable {
            
            public AppUserMergeTable(IDataProvider provider):base("AppUserMerge",provider){
                ClassName = "AppUserMerge";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("AppUserMergeID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("MergedAppUserID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ActiveAppUserID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("MergeDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn AppUserMergeID{
                get{
                    return this.GetColumn("AppUserMergeID");
                }
            }
				
   			public static string AppUserMergeIDColumn{
			      get{
        			return "AppUserMergeID";
      			}
		    }
            
            public IColumn MergedAppUserID{
                get{
                    return this.GetColumn("MergedAppUserID");
                }
            }
				
   			public static string MergedAppUserIDColumn{
			      get{
        			return "MergedAppUserID";
      			}
		    }
            
            public IColumn ActiveAppUserID{
                get{
                    return this.GetColumn("ActiveAppUserID");
                }
            }
				
   			public static string ActiveAppUserIDColumn{
			      get{
        			return "ActiveAppUserID";
      			}
		    }
            
            public IColumn MergeDate{
                get{
                    return this.GetColumn("MergeDate");
                }
            }
				
   			public static string MergeDateColumn{
			      get{
        			return "MergeDate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: EmailAppUser
        /// Primary Key: EmailAppUserID
        /// </summary>

        public class EmailAppUserTable: DatabaseTable {
            
            public EmailAppUserTable(IDataProvider provider):base("EmailAppUser",provider){
                ClassName = "EmailAppUser";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("EmailAppUserID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AppUserID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Email", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("Active", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsEmailRegistered", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("FriendsImported", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("MeetBallsImported", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("PrimaryEmail", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("CreateDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifyDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn EmailAppUserID{
                get{
                    return this.GetColumn("EmailAppUserID");
                }
            }
				
   			public static string EmailAppUserIDColumn{
			      get{
        			return "EmailAppUserID";
      			}
		    }
            
            public IColumn AppUserID{
                get{
                    return this.GetColumn("AppUserID");
                }
            }
				
   			public static string AppUserIDColumn{
			      get{
        			return "AppUserID";
      			}
		    }
            
            public IColumn Email{
                get{
                    return this.GetColumn("Email");
                }
            }
				
   			public static string EmailColumn{
			      get{
        			return "Email";
      			}
		    }
            
            public IColumn Active{
                get{
                    return this.GetColumn("Active");
                }
            }
				
   			public static string ActiveColumn{
			      get{
        			return "Active";
      			}
		    }
            
            public IColumn IsEmailRegistered{
                get{
                    return this.GetColumn("IsEmailRegistered");
                }
            }
				
   			public static string IsEmailRegisteredColumn{
			      get{
        			return "IsEmailRegistered";
      			}
		    }
            
            public IColumn FriendsImported{
                get{
                    return this.GetColumn("FriendsImported");
                }
            }
				
   			public static string FriendsImportedColumn{
			      get{
        			return "FriendsImported";
      			}
		    }
            
            public IColumn MeetBallsImported{
                get{
                    return this.GetColumn("MeetBallsImported");
                }
            }
				
   			public static string MeetBallsImportedColumn{
			      get{
        			return "MeetBallsImported";
      			}
		    }
            
            public IColumn PrimaryEmail{
                get{
                    return this.GetColumn("PrimaryEmail");
                }
            }
				
   			public static string PrimaryEmailColumn{
			      get{
        			return "PrimaryEmail";
      			}
		    }
            
            public IColumn CreateDate{
                get{
                    return this.GetColumn("CreateDate");
                }
            }
				
   			public static string CreateDateColumn{
			      get{
        			return "CreateDate";
      			}
		    }
            
            public IColumn ModifyDate{
                get{
                    return this.GetColumn("ModifyDate");
                }
            }
				
   			public static string ModifyDateColumn{
			      get{
        			return "ModifyDate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: MethodLogException
        /// Primary Key: MethodLogExceptionId
        /// </summary>

        public class MethodLogExceptionTable: DatabaseTable {
            
            public MethodLogExceptionTable(IDataProvider provider):base("MethodLogException",provider){
                ClassName = "MethodLogException";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("MethodLogExceptionId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ExceptionGuid", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Guid,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ExceptionCode", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("ExceptionSource", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("ExceptionMessage", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("ExceptionStackTrace", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("ExceptionTargetSite", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });

                Columns.Add(new DatabaseColumn("ExceptionDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn MethodLogExceptionId{
                get{
                    return this.GetColumn("MethodLogExceptionId");
                }
            }
				
   			public static string MethodLogExceptionIdColumn{
			      get{
        			return "MethodLogExceptionId";
      			}
		    }
            
            public IColumn ExceptionGuid{
                get{
                    return this.GetColumn("ExceptionGuid");
                }
            }
				
   			public static string ExceptionGuidColumn{
			      get{
        			return "ExceptionGuid";
      			}
		    }
            
            public IColumn ExceptionCode{
                get{
                    return this.GetColumn("ExceptionCode");
                }
            }
				
   			public static string ExceptionCodeColumn{
			      get{
        			return "ExceptionCode";
      			}
		    }
            
            public IColumn ExceptionSource{
                get{
                    return this.GetColumn("ExceptionSource");
                }
            }
				
   			public static string ExceptionSourceColumn{
			      get{
        			return "ExceptionSource";
      			}
		    }
            
            public IColumn ExceptionMessage{
                get{
                    return this.GetColumn("ExceptionMessage");
                }
            }
				
   			public static string ExceptionMessageColumn{
			      get{
        			return "ExceptionMessage";
      			}
		    }
            
            public IColumn ExceptionStackTrace{
                get{
                    return this.GetColumn("ExceptionStackTrace");
                }
            }
				
   			public static string ExceptionStackTraceColumn{
			      get{
        			return "ExceptionStackTrace";
      			}
		    }
            
            public IColumn ExceptionTargetSite{
                get{
                    return this.GetColumn("ExceptionTargetSite");
                }
            }
				
   			public static string ExceptionTargetSiteColumn{
			      get{
        			return "ExceptionTargetSite";
      			}
		    }
            
            public IColumn ExceptionDate{
                get{
                    return this.GetColumn("ExceptionDate");
                }
            }
				
   			public static string ExceptionDateColumn{
			      get{
        			return "ExceptionDate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: AppUserPlatform
        /// Primary Key: AppUserPlatformId
        /// </summary>

        public class AppUserPlatformTable: DatabaseTable {
            
            public AppUserPlatformTable(IDataProvider provider):base("AppUserPlatform",provider){
                ClassName = "AppUserPlatform";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("AppUserPlatformId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AppUserId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Locale", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiStringFixedLength,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 5
                });

                Columns.Add(new DatabaseColumn("Manufacturer", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Model", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 200
                });

                Columns.Add(new DatabaseColumn("PlatformName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("NetMask", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 15
                });

                Columns.Add(new DatabaseColumn("OsName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("OsType", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 20
                });

                Columns.Add(new DatabaseColumn("ProcessorCount", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int16,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Version", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("CreateDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn AppUserPlatformId{
                get{
                    return this.GetColumn("AppUserPlatformId");
                }
            }
				
   			public static string AppUserPlatformIdColumn{
			      get{
        			return "AppUserPlatformId";
      			}
		    }
            
            public IColumn AppUserId{
                get{
                    return this.GetColumn("AppUserId");
                }
            }
				
   			public static string AppUserIdColumn{
			      get{
        			return "AppUserId";
      			}
		    }
            
            public IColumn Locale{
                get{
                    return this.GetColumn("Locale");
                }
            }
				
   			public static string LocaleColumn{
			      get{
        			return "Locale";
      			}
		    }
            
            public IColumn Manufacturer{
                get{
                    return this.GetColumn("Manufacturer");
                }
            }
				
   			public static string ManufacturerColumn{
			      get{
        			return "Manufacturer";
      			}
		    }
            
            public IColumn Model{
                get{
                    return this.GetColumn("Model");
                }
            }
				
   			public static string ModelColumn{
			      get{
        			return "Model";
      			}
		    }
            
            public IColumn PlatformName{
                get{
                    return this.GetColumn("PlatformName");
                }
            }
				
   			public static string PlatformNameColumn{
			      get{
        			return "PlatformName";
      			}
		    }
            
            public IColumn NetMask{
                get{
                    return this.GetColumn("NetMask");
                }
            }
				
   			public static string NetMaskColumn{
			      get{
        			return "NetMask";
      			}
		    }
            
            public IColumn OsName{
                get{
                    return this.GetColumn("OsName");
                }
            }
				
   			public static string OsNameColumn{
			      get{
        			return "OsName";
      			}
		    }
            
            public IColumn OsType{
                get{
                    return this.GetColumn("OsType");
                }
            }
				
   			public static string OsTypeColumn{
			      get{
        			return "OsType";
      			}
		    }
            
            public IColumn ProcessorCount{
                get{
                    return this.GetColumn("ProcessorCount");
                }
            }
				
   			public static string ProcessorCountColumn{
			      get{
        			return "ProcessorCount";
      			}
		    }
            
            public IColumn Version{
                get{
                    return this.GetColumn("Version");
                }
            }
				
   			public static string VersionColumn{
			      get{
        			return "Version";
      			}
		    }
            
            public IColumn CreateDate{
                get{
                    return this.GetColumn("CreateDate");
                }
            }
				
   			public static string CreateDateColumn{
			      get{
        			return "CreateDate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: MethodLogMBException
        /// Primary Key: MethodLogMBExceptionId
        /// </summary>

        public class MethodLogMBExceptionTable: DatabaseTable {
            
            public MethodLogMBExceptionTable(IDataProvider provider):base("MethodLogMBException",provider){
                ClassName = "MethodLogMBException";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("MethodLogMBExceptionId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("MBExceptionGuid", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Guid,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("MBExceptionCode", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("FriendlyMessage", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 1000
                });

                Columns.Add(new DatabaseColumn("DeveloperMessage", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 1000
                });

                Columns.Add(new DatabaseColumn("MBExceptionDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn MethodLogMBExceptionId{
                get{
                    return this.GetColumn("MethodLogMBExceptionId");
                }
            }
				
   			public static string MethodLogMBExceptionIdColumn{
			      get{
        			return "MethodLogMBExceptionId";
      			}
		    }
            
            public IColumn MBExceptionGuid{
                get{
                    return this.GetColumn("MBExceptionGuid");
                }
            }
				
   			public static string MBExceptionGuidColumn{
			      get{
        			return "MBExceptionGuid";
      			}
		    }
            
            public IColumn MBExceptionCode{
                get{
                    return this.GetColumn("MBExceptionCode");
                }
            }
				
   			public static string MBExceptionCodeColumn{
			      get{
        			return "MBExceptionCode";
      			}
		    }
            
            public IColumn FriendlyMessage{
                get{
                    return this.GetColumn("FriendlyMessage");
                }
            }
				
   			public static string FriendlyMessageColumn{
			      get{
        			return "FriendlyMessage";
      			}
		    }
            
            public IColumn DeveloperMessage{
                get{
                    return this.GetColumn("DeveloperMessage");
                }
            }
				
   			public static string DeveloperMessageColumn{
			      get{
        			return "DeveloperMessage";
      			}
		    }
            
            public IColumn MBExceptionDate{
                get{
                    return this.GetColumn("MBExceptionDate");
                }
            }
				
   			public static string MBExceptionDateColumn{
			      get{
        			return "MBExceptionDate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: MeetballTrackingSession
        /// Primary Key: MeetballTrackingSessionId
        /// </summary>

        public class MeetballTrackingSessionTable: DatabaseTable {
            
            public MeetballTrackingSessionTable(IDataProvider provider):base("MeetballTrackingSession",provider){
                ClassName = "MeetballTrackingSession";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("MeetballTrackingSessionId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Guid,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("StartTime", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("EndTime", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("BatteryStart", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Double,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("BatteryEnd", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Double,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("MemoryStart", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Double,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("MemoryEnd", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Double,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn MeetballTrackingSessionId{
                get{
                    return this.GetColumn("MeetballTrackingSessionId");
                }
            }
				
   			public static string MeetballTrackingSessionIdColumn{
			      get{
        			return "MeetballTrackingSessionId";
      			}
		    }
            
            public IColumn StartTime{
                get{
                    return this.GetColumn("StartTime");
                }
            }
				
   			public static string StartTimeColumn{
			      get{
        			return "StartTime";
      			}
		    }
            
            public IColumn EndTime{
                get{
                    return this.GetColumn("EndTime");
                }
            }
				
   			public static string EndTimeColumn{
			      get{
        			return "EndTime";
      			}
		    }
            
            public IColumn BatteryStart{
                get{
                    return this.GetColumn("BatteryStart");
                }
            }
				
   			public static string BatteryStartColumn{
			      get{
        			return "BatteryStart";
      			}
		    }
            
            public IColumn BatteryEnd{
                get{
                    return this.GetColumn("BatteryEnd");
                }
            }
				
   			public static string BatteryEndColumn{
			      get{
        			return "BatteryEnd";
      			}
		    }
            
            public IColumn MemoryStart{
                get{
                    return this.GetColumn("MemoryStart");
                }
            }
				
   			public static string MemoryStartColumn{
			      get{
        			return "MemoryStart";
      			}
		    }
            
            public IColumn MemoryEnd{
                get{
                    return this.GetColumn("MemoryEnd");
                }
            }
				
   			public static string MemoryEndColumn{
			      get{
        			return "MemoryEnd";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: ApiKey
        /// Primary Key: ApiKeyGuid
        /// </summary>

        public class ApiKeyTable: DatabaseTable {
            
            public ApiKeyTable(IDataProvider provider):base("ApiKey",provider){
                ClassName = "ApiKey";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ApiKeyGuid", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Guid,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Status", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AppDeveloperId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Platform", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });
                    
                
                
            }

            public IColumn ApiKeyGuid{
                get{
                    return this.GetColumn("ApiKeyGuid");
                }
            }
				
   			public static string ApiKeyGuidColumn{
			      get{
        			return "ApiKeyGuid";
      			}
		    }
            
            public IColumn Status{
                get{
                    return this.GetColumn("Status");
                }
            }
				
   			public static string StatusColumn{
			      get{
        			return "Status";
      			}
		    }
            
            public IColumn AppDeveloperId{
                get{
                    return this.GetColumn("AppDeveloperId");
                }
            }
				
   			public static string AppDeveloperIdColumn{
			      get{
        			return "AppDeveloperId";
      			}
		    }
            
            public IColumn Platform{
                get{
                    return this.GetColumn("Platform");
                }
            }
				
   			public static string PlatformColumn{
			      get{
        			return "Platform";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: MBException
        /// Primary Key: MBExceptionId
        /// </summary>

        public class MBExceptionTable: DatabaseTable {
            
            public MBExceptionTable(IDataProvider provider):base("MBException",provider){
                ClassName = "MBException";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("MBExceptionId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("MBExceptionCode", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("FriendlyMessage", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 1000
                });

                Columns.Add(new DatabaseColumn("DeveloperMessage", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 1000
                });

                Columns.Add(new DatabaseColumn("StatusId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreateDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifyDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn MBExceptionId{
                get{
                    return this.GetColumn("MBExceptionId");
                }
            }
				
   			public static string MBExceptionIdColumn{
			      get{
        			return "MBExceptionId";
      			}
		    }
            
            public IColumn MBExceptionCode{
                get{
                    return this.GetColumn("MBExceptionCode");
                }
            }
				
   			public static string MBExceptionCodeColumn{
			      get{
        			return "MBExceptionCode";
      			}
		    }
            
            public IColumn FriendlyMessage{
                get{
                    return this.GetColumn("FriendlyMessage");
                }
            }
				
   			public static string FriendlyMessageColumn{
			      get{
        			return "FriendlyMessage";
      			}
		    }
            
            public IColumn DeveloperMessage{
                get{
                    return this.GetColumn("DeveloperMessage");
                }
            }
				
   			public static string DeveloperMessageColumn{
			      get{
        			return "DeveloperMessage";
      			}
		    }
            
            public IColumn StatusId{
                get{
                    return this.GetColumn("StatusId");
                }
            }
				
   			public static string StatusIdColumn{
			      get{
        			return "StatusId";
      			}
		    }
            
            public IColumn CreateDate{
                get{
                    return this.GetColumn("CreateDate");
                }
            }
				
   			public static string CreateDateColumn{
			      get{
        			return "CreateDate";
      			}
		    }
            
            public IColumn ModifyDate{
                get{
                    return this.GetColumn("ModifyDate");
                }
            }
				
   			public static string ModifyDateColumn{
			      get{
        			return "ModifyDate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: AppDeveloper
        /// Primary Key: AppDeveloperId
        /// </summary>

        public class AppDeveloperTable: DatabaseTable {
            
            public AppDeveloperTable(IDataProvider provider):base("AppDeveloper",provider){
                ClassName = "AppDeveloper";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("AppDeveloperId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 200
                });
                    
                
                
            }

            public IColumn AppDeveloperId{
                get{
                    return this.GetColumn("AppDeveloperId");
                }
            }
				
   			public static string AppDeveloperIdColumn{
			      get{
        			return "AppDeveloperId";
      			}
		    }
            
            public IColumn Name{
                get{
                    return this.GetColumn("Name");
                }
            }
				
   			public static string NameColumn{
			      get{
        			return "Name";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: MeetballAction
        /// Primary Key: MeetballActionID
        /// </summary>

        public class MeetballActionTable: DatabaseTable {
            
            public MeetballActionTable(IDataProvider provider):base("MeetballAction",provider){
                ClassName = "MeetballAction";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("MeetballActionID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("MeetballID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Message", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });

                Columns.Add(new DatabaseColumn("OwnerOnly", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreateDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn MeetballActionID{
                get{
                    return this.GetColumn("MeetballActionID");
                }
            }
				
   			public static string MeetballActionIDColumn{
			      get{
        			return "MeetballActionID";
      			}
		    }
            
            public IColumn MeetballID{
                get{
                    return this.GetColumn("MeetballID");
                }
            }
				
   			public static string MeetballIDColumn{
			      get{
        			return "MeetballID";
      			}
		    }
            
            public IColumn Message{
                get{
                    return this.GetColumn("Message");
                }
            }
				
   			public static string MessageColumn{
			      get{
        			return "Message";
      			}
		    }
            
            public IColumn OwnerOnly{
                get{
                    return this.GetColumn("OwnerOnly");
                }
            }
				
   			public static string OwnerOnlyColumn{
			      get{
        			return "OwnerOnly";
      			}
		    }
            
            public IColumn CreateDate{
                get{
                    return this.GetColumn("CreateDate");
                }
            }
				
   			public static string CreateDateColumn{
			      get{
        			return "CreateDate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: Convo
        /// Primary Key: ConvoID
        /// </summary>

        public class ConvoTable: DatabaseTable {
            
            public ConvoTable(IDataProvider provider):base("Convo",provider){
                ClassName = "Convo";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ConvoID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ConvoName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("CreateDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn ConvoID{
                get{
                    return this.GetColumn("ConvoID");
                }
            }
				
   			public static string ConvoIDColumn{
			      get{
        			return "ConvoID";
      			}
		    }
            
            public IColumn ConvoName{
                get{
                    return this.GetColumn("ConvoName");
                }
            }
				
   			public static string ConvoNameColumn{
			      get{
        			return "ConvoName";
      			}
		    }
            
            public IColumn CreateDate{
                get{
                    return this.GetColumn("CreateDate");
                }
            }
				
   			public static string CreateDateColumn{
			      get{
        			return "CreateDate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: SubvenueType
        /// Primary Key: SubvenueTypeID
        /// </summary>

        public class SubvenueTypeTable: DatabaseTable {
            
            public SubvenueTypeTable(IDataProvider provider):base("SubvenueType",provider){
                ClassName = "SubvenueType";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("SubvenueTypeID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SubvenueTypeName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("IsActive", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreateDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifyDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Weight", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Double,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn SubvenueTypeID{
                get{
                    return this.GetColumn("SubvenueTypeID");
                }
            }
				
   			public static string SubvenueTypeIDColumn{
			      get{
        			return "SubvenueTypeID";
      			}
		    }
            
            public IColumn SubvenueTypeName{
                get{
                    return this.GetColumn("SubvenueTypeName");
                }
            }
				
   			public static string SubvenueTypeNameColumn{
			      get{
        			return "SubvenueTypeName";
      			}
		    }
            
            public IColumn IsActive{
                get{
                    return this.GetColumn("IsActive");
                }
            }
				
   			public static string IsActiveColumn{
			      get{
        			return "IsActive";
      			}
		    }
            
            public IColumn CreateDate{
                get{
                    return this.GetColumn("CreateDate");
                }
            }
				
   			public static string CreateDateColumn{
			      get{
        			return "CreateDate";
      			}
		    }
            
            public IColumn ModifyDate{
                get{
                    return this.GetColumn("ModifyDate");
                }
            }
				
   			public static string ModifyDateColumn{
			      get{
        			return "ModifyDate";
      			}
		    }
            
            public IColumn Weight{
                get{
                    return this.GetColumn("Weight");
                }
            }
				
   			public static string WeightColumn{
			      get{
        			return "Weight";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: Message
        /// Primary Key: MessageID
        /// </summary>

        public class MessageTable: DatabaseTable {
            
            public MessageTable(IDataProvider provider):base("Message",provider){
                ClassName = "Message";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("MessageID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ConvoID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AppUserID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Message", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });

                Columns.Add(new DatabaseColumn("CreateDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn MessageID{
                get{
                    return this.GetColumn("MessageID");
                }
            }
				
   			public static string MessageIDColumn{
			      get{
        			return "MessageID";
      			}
		    }
            
            public IColumn ConvoID{
                get{
                    return this.GetColumn("ConvoID");
                }
            }
				
   			public static string ConvoIDColumn{
			      get{
        			return "ConvoID";
      			}
		    }
            
            public IColumn AppUserID{
                get{
                    return this.GetColumn("AppUserID");
                }
            }
				
   			public static string AppUserIDColumn{
			      get{
        			return "AppUserID";
      			}
		    }
            
            public IColumn Message{
                get{
                    return this.GetColumn("Message");
                }
            }
				
   			public static string MessageColumn{
			      get{
        			return "Message";
      			}
		    }
            
            public IColumn CreateDate{
                get{
                    return this.GetColumn("CreateDate");
                }
            }
				
   			public static string CreateDateColumn{
			      get{
        			return "CreateDate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: Subvenue
        /// Primary Key: SubvenueID
        /// </summary>

        public class SubvenueTable: DatabaseTable {
            
            public SubvenueTable(IDataProvider provider):base("Subvenue",provider){
                ClassName = "Subvenue";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("SubvenueID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("VenueID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SubvenueTypeID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SubvenueName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("SubvenueGPXWKT", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 200
                });

                Columns.Add(new DatabaseColumn("CreateDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifyDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn SubvenueID{
                get{
                    return this.GetColumn("SubvenueID");
                }
            }
				
   			public static string SubvenueIDColumn{
			      get{
        			return "SubvenueID";
      			}
		    }
            
            public IColumn VenueID{
                get{
                    return this.GetColumn("VenueID");
                }
            }
				
   			public static string VenueIDColumn{
			      get{
        			return "VenueID";
      			}
		    }
            
            public IColumn SubvenueTypeID{
                get{
                    return this.GetColumn("SubvenueTypeID");
                }
            }
				
   			public static string SubvenueTypeIDColumn{
			      get{
        			return "SubvenueTypeID";
      			}
		    }
            
            public IColumn SubvenueName{
                get{
                    return this.GetColumn("SubvenueName");
                }
            }
				
   			public static string SubvenueNameColumn{
			      get{
        			return "SubvenueName";
      			}
		    }
            
            public IColumn SubvenueGPXWKT{
                get{
                    return this.GetColumn("SubvenueGPXWKT");
                }
            }
				
   			public static string SubvenueGPXWKTColumn{
			      get{
        			return "SubvenueGPXWKT";
      			}
		    }
            
            public IColumn CreateDate{
                get{
                    return this.GetColumn("CreateDate");
                }
            }
				
   			public static string CreateDateColumn{
			      get{
        			return "CreateDate";
      			}
		    }
            
            public IColumn ModifyDate{
                get{
                    return this.GetColumn("ModifyDate");
                }
            }
				
   			public static string ModifyDateColumn{
			      get{
        			return "ModifyDate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: AppUserLoginLog
        /// Primary Key: AppUserLoginLogID
        /// </summary>

        public class AppUserLoginLogTable: DatabaseTable {
            
            public AppUserLoginLogTable(IDataProvider provider):base("AppUserLoginLog",provider){
                ClassName = "AppUserLoginLog";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("AppUserLoginLogID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AppUserID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AppUserLoginDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn AppUserLoginLogID{
                get{
                    return this.GetColumn("AppUserLoginLogID");
                }
            }
				
   			public static string AppUserLoginLogIDColumn{
			      get{
        			return "AppUserLoginLogID";
      			}
		    }
            
            public IColumn AppUserID{
                get{
                    return this.GetColumn("AppUserID");
                }
            }
				
   			public static string AppUserIDColumn{
			      get{
        			return "AppUserID";
      			}
		    }
            
            public IColumn AppUserLoginDate{
                get{
                    return this.GetColumn("AppUserLoginDate");
                }
            }
				
   			public static string AppUserLoginDateColumn{
			      get{
        			return "AppUserLoginDate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: VenueType
        /// Primary Key: VenueTypeID
        /// </summary>

        public class VenueTypeTable: DatabaseTable {
            
            public VenueTypeTable(IDataProvider provider):base("VenueType",provider){
                ClassName = "VenueType";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("VenueTypeID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("VenueTypeName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("StatusID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreateDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifyDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn VenueTypeID{
                get{
                    return this.GetColumn("VenueTypeID");
                }
            }
				
   			public static string VenueTypeIDColumn{
			      get{
        			return "VenueTypeID";
      			}
		    }
            
            public IColumn VenueTypeName{
                get{
                    return this.GetColumn("VenueTypeName");
                }
            }
				
   			public static string VenueTypeNameColumn{
			      get{
        			return "VenueTypeName";
      			}
		    }
            
            public IColumn StatusID{
                get{
                    return this.GetColumn("StatusID");
                }
            }
				
   			public static string StatusIDColumn{
			      get{
        			return "StatusID";
      			}
		    }
            
            public IColumn CreateDate{
                get{
                    return this.GetColumn("CreateDate");
                }
            }
				
   			public static string CreateDateColumn{
			      get{
        			return "CreateDate";
      			}
		    }
            
            public IColumn ModifyDate{
                get{
                    return this.GetColumn("ModifyDate");
                }
            }
				
   			public static string ModifyDateColumn{
			      get{
        			return "ModifyDate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: MessageMB
        /// Primary Key: MessageMBID
        /// </summary>

        public class MessageMBTable: DatabaseTable {
            
            public MessageMBTable(IDataProvider provider):base("MessageMB",provider){
                ClassName = "MessageMB";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("MessageMBID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ConvoID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AppUserID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Message", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });

                Columns.Add(new DatabaseColumn("MeetballID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreateDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn MessageMBID{
                get{
                    return this.GetColumn("MessageMBID");
                }
            }
				
   			public static string MessageMBIDColumn{
			      get{
        			return "MessageMBID";
      			}
		    }
            
            public IColumn ConvoID{
                get{
                    return this.GetColumn("ConvoID");
                }
            }
				
   			public static string ConvoIDColumn{
			      get{
        			return "ConvoID";
      			}
		    }
            
            public IColumn AppUserID{
                get{
                    return this.GetColumn("AppUserID");
                }
            }
				
   			public static string AppUserIDColumn{
			      get{
        			return "AppUserID";
      			}
		    }
            
            public IColumn Message{
                get{
                    return this.GetColumn("Message");
                }
            }
				
   			public static string MessageColumn{
			      get{
        			return "Message";
      			}
		    }
            
            public IColumn MeetballID{
                get{
                    return this.GetColumn("MeetballID");
                }
            }
				
   			public static string MeetballIDColumn{
			      get{
        			return "MeetballID";
      			}
		    }
            
            public IColumn CreateDate{
                get{
                    return this.GetColumn("CreateDate");
                }
            }
				
   			public static string CreateDateColumn{
			      get{
        			return "CreateDate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: TVNetwork
        /// Primary Key: TVNetworkID
        /// </summary>

        public class TVNetworkTable: DatabaseTable {
            
            public TVNetworkTable(IDataProvider provider):base("TVNetwork",provider){
                ClassName = "TVNetwork";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("TVNetworkID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("TVNetworkName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("StatusID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreateDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifyDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn TVNetworkID{
                get{
                    return this.GetColumn("TVNetworkID");
                }
            }
				
   			public static string TVNetworkIDColumn{
			      get{
        			return "TVNetworkID";
      			}
		    }
            
            public IColumn TVNetworkName{
                get{
                    return this.GetColumn("TVNetworkName");
                }
            }
				
   			public static string TVNetworkNameColumn{
			      get{
        			return "TVNetworkName";
      			}
		    }
            
            public IColumn StatusID{
                get{
                    return this.GetColumn("StatusID");
                }
            }
				
   			public static string StatusIDColumn{
			      get{
        			return "StatusID";
      			}
		    }
            
            public IColumn CreateDate{
                get{
                    return this.GetColumn("CreateDate");
                }
            }
				
   			public static string CreateDateColumn{
			      get{
        			return "CreateDate";
      			}
		    }
            
            public IColumn ModifyDate{
                get{
                    return this.GetColumn("ModifyDate");
                }
            }
				
   			public static string ModifyDateColumn{
			      get{
        			return "ModifyDate";
      			}
		    }
            
                    
        }
        
}
#pragma warning restore 1591 