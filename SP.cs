using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Diagnostics;
using ResultWrappers;

namespace DBDataAccess
{
	/// <summary>
	/// Stored Procedure - immutable 
	/// SPs are created by calling our static factory methods
	/// </summary>
	public class SP
	{
		#region readonly private members
		private readonly string procedureName;

		private readonly Parameter[] parameters;
		#endregion

		/// <summary>
		/// having this private keeps all the proper construction of
		/// SP parameters, Datasets, and SP naming away from other classes
		/// </summary>
		private SP(string procedureName, Parameter[] parameters)
		{
			this.procedureName = procedureName;
			this.parameters = parameters;
		}

		/// <summary>
		/// get the SP able to call this SP
		/// </summary>
		public static SP InsertToTVPTest(int[] values)
		{
			var ps = new Parameter[1];

			var dt = new DataTable();
			dt.Columns.Add("n", typeof(int));

			for (int i = 0; i < values.Length; i++)
			{
				dt.Rows.Add(values[i]);
			}

			ps[0] = new Parameter("@Values", dt, true);

			return new SP("InsertToTVPTest", ps);
		}

		/// <summary>
		/// get the SP able to call this SP
		/// </summary>
		public static SP CreateMeetballOffPlatformTVP(int meetballID, int mbOwnerID, 
			int sender,string[] displayNames, string[] phones)
		{
			var ps = new Parameter[4];

			var dt = new DataTable();
			dt.Columns.Add("DisplayName", typeof(string));
			dt.Columns.Add("Phone", typeof(string));

			for (int i = 0; i < phones.Length; i++)
			{
				dt.Rows.Add(displayNames[i], phones[i]);
			}
			ps[0] = new Parameter("@MeetballID", meetballID, false);
			ps[1] = new Parameter("@MBOwnerID", mbOwnerID, false);
			ps[2] = new Parameter("@ReferralAppUserID", sender, false);
			ps[3] = new Parameter("@TVP", dt, true);

			return new SP("CreateMeetballOffPlatformTVP", ps);
		}

		public static SP XReferencePhoneAutoFriendTVP(string[] phones, int userID)
		{
			var ps = new Parameter[2];

			var dt = new DataTable();
			dt.Columns.Add("s", typeof(string));

			for (int i = 0; i < phones.Length; i++)
			{
				dt.Rows.Add(phones[i]);
			}
			ps[0] = new Parameter("@AppUserID", userID, false);
			ps[1] = new Parameter("@TVP", dt, true);

			return new SP("XReferencePhoneAutoFriendTVP", ps);
		}

		public static SP CreateMeetballResponseTVP(int[] invitees, 
			int meetballID, int userID)
		{
			var ps = new Parameter[3];

			var dt = new DataTable();
			dt.Columns.Add("n", typeof(int));

			for (int i = 0; i < invitees.Length; i++)
			{
				dt.Rows.Add(invitees[i]);
			}
			ps[0] = new Parameter("@MeetballID", meetballID, false);
			ps[1] = new Parameter("@MBOwnerID", userID, false);
			ps[2] = new Parameter("@TVP", dt, true);

			return new SP("CreateMeetballResponseTVP", ps);
		}

		public static SP GetEventsByOwnerAndTimespanTVP(int[] OwnerIDs,
			DateTime BeginningOfDateRangeUTC, DateTime EndOfDateRangeUTC)
		{
			var ps = new Parameter[3];

			var dt = new DataTable();
			dt.Columns.Add("n", typeof(int));

			for (int i = 0; i < OwnerIDs.Length; i++)
			{
				dt.Rows.Add(OwnerIDs[i]);
			}
			ps[0] = new Parameter("@BeginningOfDateRangeUTC", BeginningOfDateRangeUTC, false);
			ps[1] = new Parameter("@EndOfDateRangeUTC", EndOfDateRangeUTC, false);
			ps[2] = new Parameter("@OwnerIDs", dt, true);

			return new SP("GetEventsByOwnerAndTimespanTVP", ps);
		}

		public static SP GetUserDetailsTVP(int[] userIDs)
		{
			var ps = new Parameter[1];

			var dt = new DataTable();
			dt.Columns.Add("n", typeof(int));

			for (int i = 0; i < userIDs.Length; i++)
			{
				dt.Rows.Add(userIDs[i]);
			}
			ps[0] = new Parameter("@AppUserIDs", dt, true);

			return new SP("GetUserDetailsTVP", ps);
		}

		/// <summary>
		/// Executes our Stored Procedure and gets our return values
		/// </summary>
		/// <returns>generic dataset designed after Subsonic's dataset</returns>
		public BLResult<DataSet> call()
		{
			var connectionString = System.Configuration.ConfigurationManager.
				ConnectionStrings["meetball"].ConnectionString;

			DataSet ds = new DataSet(procedureName);

			try
			{
				using (var conn = new SqlConnection(connectionString))
				using (var command = new SqlCommand(procedureName, conn) 
					{ CommandType = CommandType.StoredProcedure })
				{
					conn.Open();

					for (int i = 0; i < parameters.Length; i++)
					{
						if (parameters[i].tvp)
						{
							SqlParameter tvpParam = command.Parameters.AddWithValue(
								parameters[i].name, 
								parameters[i].parameter);
							tvpParam.SqlDbType = SqlDbType.Structured;
						}
						else
						{
							command.Parameters.AddWithValue(
								parameters[i].name, 
								parameters[i].parameter);
						}
					}

					//call and read
					using (var reader = command.ExecuteReader())
					{
						//call has returned
						var tableCounter = 0;

						while (reader.HasRows)
						{
							ds.Tables.Add();
							var fieldCount = reader.FieldCount;
							for (int i = 0; i < fieldCount; i++)
							{
								reader.GetDataTypeName(i);
								ds.Tables[tableCounter].Columns.Add(reader.GetName(i), reader.GetFieldType(i));
							}

							while (reader.Read())
							{
								DataRow row = ds.Tables[tableCounter].NewRow();
								var c2 = reader.FieldCount;

								for (int i = 0; i < fieldCount; i++)
								{
									Type t = reader.GetFieldType(i);
									row[i] = reader.GetValue(i);
								}

								ds.Tables[tableCounter].Rows.Add(row);
							}

							tableCounter++;
							reader.NextResult(); //this can be done async
						}

						if (tableCounter == 0)
						{
							ds.Tables.Add();
							var fieldCount = reader.FieldCount;
							for (int i = 0; i < fieldCount; i++)
							{
								reader.GetDataTypeName(i);
								ds.Tables[tableCounter].Columns.Add(reader.GetName(i), reader.GetFieldType(i));
							}
							tableCounter++;
						}
					}
				}
			}
			catch (Exception e)
			{
				return new BLResult<DataSet>(e);
			}

			return new BLResult<DataSet>(ds);
		}

		/// <summary>
		/// Opens up a txt file with generated code to get the values from the dataset
		/// </summary>
		/// <param name="set"></param>
		public static void viewContentsOfSP(DataSet set)
		{
			var sb = new StringBuilder();
			for (int i = 0; i < set.Tables.Count; i++)
			{
				sb.Append("for(int i = 0; i < ds.Tables[");
				sb.Append(i);
				sb.Append("].Rows.Count; i++)");
				sb.Append(Environment.NewLine);
				sb.Append("{");
				sb.Append(Environment.NewLine);
				sb.Append("\tvar dr = ds.Tables[");
				sb.Append(i);
				sb.Append("].Rows[i];");
				sb.Append(Environment.NewLine);
				sb.Append("\tvar cn = \"\";");
				sb.Append(Environment.NewLine);

				for (int j = 0; j < set.Tables[i].Columns.Count; j++)
				{
					sb.Append("\tcn = \"");
					sb.Append(set.Tables[i].Columns[j].ColumnName);
					sb.Append("\";");
					sb.Append(Environment.NewLine);
					sb.Append("\tstring ");
					sb.Append(set.Tables[i].Columns[j].ColumnName);
					sb.Append(" = dr[cn] != dbNull ? (string)dr[cn] : null;");
					sb.Append(Environment.NewLine);
					sb.Append(Environment.NewLine);
				}
				sb.Append("}");
				sb.Append(Environment.NewLine);
			}

			var file = "C:/Users/Devin/Desktop/stuff/dataset_tmp.txt";

			File.WriteAllText(file, sb.ToString());
			Process.Start(file);
		}
	}

	/// <summary>
	/// parameter for SP - immutable
	/// </summary>
	class Parameter
	{
		public readonly string name;
		public readonly object parameter;
		public readonly bool tvp;

		public Parameter(string name, object parameter, bool tvp = false)
		{
			this.name = name;
			this.parameter = parameter;
			this.tvp = tvp;
		}
	}
}
