using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Xml.Serialization;
using VotingInfo.Database.Contracts;
using VotingInfo.Database.Contracts.Data;

//////////////////////////////////////////////////////////////
//Do not modify this file. Use a partial class to extend.	//
//Override methods in the logic front class.				//
//////////////////////////////////////////////////////////////

namespace VotingInfo.Database.Logic.Data
{
	[Serializable]
	public abstract partial class ElectionLogicBase : LogicBase<ElectionLogicBase>
	{
		//Put your code in a separate file.  This is auto generated.
    
		[XmlArray] public List<ElectionContract> Results;

		public ElectionLogicBase()
		{
			Results =  new List<ElectionContract>();
		}

		/// <summary>
		/// Run Election_Insert.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldElectionLevelId">Value for ElectionLevelId</param>
		/// <param name="fldElectionRegion">Value for ElectionRegion</param>
		/// <param name="fldVotingDate">Value for VotingDate</param>
		/// <returns>The new ID</returns>
		public virtual int? Insert(int fldContentInspectionId
, int fldElectionLevelId
, string fldElectionRegion
, DateTime fldVotingDate
)
		{
			int? result = null;
			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[Election_Insert]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ContentInspectionId", fldContentInspectionId)
,
						new SqlParameter("@ElectionLevelId", fldElectionLevelId)
,
						new SqlParameter("@ElectionRegion", fldElectionRegion)
,
						new SqlParameter("@VotingDate", fldVotingDate)

					});

					result = (int?)cmd.ExecuteScalar();
				}
			});
			return result;
		}

		/// <summary>
		/// Run Election_Insert.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldElectionLevelId">Value for ElectionLevelId</param>
		/// <param name="fldElectionRegion">Value for ElectionRegion</param>
		/// <param name="fldVotingDate">Value for VotingDate</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The new ID</returns>
		public virtual int? Insert(int fldContentInspectionId
, int fldElectionLevelId
, string fldElectionRegion
, DateTime fldVotingDate
, SqlConnection connection, SqlTransaction transaction)
		{
			using (
				var cmd = new SqlCommand("[Data].[Election_Insert]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ContentInspectionId", fldContentInspectionId)
,
						new SqlParameter("@ElectionLevelId", fldElectionLevelId)
,
						new SqlParameter("@ElectionRegion", fldElectionRegion)
,
						new SqlParameter("@VotingDate", fldVotingDate)

					});

				return (int?)cmd.ExecuteScalar();
			}
		}

		/// <summary>
		/// Insert by providing a populated data row container
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <returns>1, if insert was successful</returns>
		public int Insert(ElectionContract row)
		{
			int? result = null;
			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[Election_Insert]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ContentInspectionId", row.ContentInspectionId)
,
						new SqlParameter("@ElectionLevelId", row.ElectionLevelId)
,
						new SqlParameter("@ElectionRegion", row.ElectionRegion)
,
						new SqlParameter("@VotingDate", row.VotingDate)

					});
            
					result = (int?)cmd.ExecuteScalar();
					row.ElectionId = result;
				}
			});
			return result != null ? 1 : 0;
		}

		/// <summary>
		/// Insert by providing a populated data contract
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>1, if insert was successful</returns>
		public int Insert(ElectionContract row, SqlConnection connection, SqlTransaction transaction)
		{
			int? result = null;
			using (
				var cmd = new SqlCommand("[Data].[Election_Insert]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ContentInspectionId", row.ContentInspectionId)
,
						new SqlParameter("@ElectionLevelId", row.ElectionLevelId)
,
						new SqlParameter("@ElectionRegion", row.ElectionRegion)
,
						new SqlParameter("@VotingDate", row.VotingDate)

					});
            
				result = (int?)cmd.ExecuteScalar();
				row.ElectionId = result;
			}
			return result != null ? 1 : 0;
		}
		/// <summary>
		/// Insert the rows in bulk, uses the same connection (faster).
		/// </summary>
		/// <param name="rows">The table rows to Insert</param>
		/// <returns>The number of rows affected.</returns>
		public virtual int InsertAll(List<ElectionContract> rows)
		{		
			var rowCount = 0;
			VotingInfoDb.ConnectThen(x => 
			{
				rowCount = InsertAll(rows, x, null);
			});
			return rowCount;
		}

		/// <summary>
		/// Insert the rows in bulk, uses the same connection (faster), in a provided transaction scrope.
		/// </summary>
		/// <param name="rows">The table rows to Insert</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public virtual int InsertAll(List<ElectionContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			var rowCount = 0;
			foreach(var row in rows) rowCount += Insert(row, connection, transaction);
			return rowCount;
		}

		/// <summary>
		/// Run Election_Update.
		/// </summary>
		/// <returns>The number of rows affected.</returns>
		/// <param name="fldElectionId">Value for ElectionId</param>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldElectionLevelId">Value for ElectionLevelId</param>
		/// <param name="fldElectionRegion">Value for ElectionRegion</param>
		/// <param name="fldVotingDate">Value for VotingDate</param>
		public virtual int Update(int fldElectionId
, int fldContentInspectionId
, int fldElectionLevelId
, string fldElectionRegion
, DateTime fldVotingDate
)
		{
			var rowCount = 0;
			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[Election_Update]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ElectionId", fldElectionId)
,
						new SqlParameter("@ContentInspectionId", fldContentInspectionId)
,
						new SqlParameter("@ElectionLevelId", fldElectionLevelId)
,
						new SqlParameter("@ElectionRegion", fldElectionRegion)
,
						new SqlParameter("@VotingDate", fldVotingDate)

					});

					rowCount = cmd.ExecuteNonQuery();
				}
			});
			
			
			return rowCount;
		}

		/// <summary>
		/// Run Election_Update.
		/// </summary>
		/// <param name="fldElectionId">Value for ElectionId</param>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldElectionLevelId">Value for ElectionLevelId</param>
		/// <param name="fldElectionRegion">Value for ElectionRegion</param>
		/// <param name="fldVotingDate">Value for VotingDate</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public virtual int Update(int fldElectionId
, int fldContentInspectionId
, int fldElectionLevelId
, string fldElectionRegion
, DateTime fldVotingDate
, SqlConnection connection, SqlTransaction transaction)
		{
			var rowCount = 0;
			using (
				var cmd = new SqlCommand("[Data].[Election_Update]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ElectionId", fldElectionId)
,
						new SqlParameter("@ContentInspectionId", fldContentInspectionId)
,
						new SqlParameter("@ElectionLevelId", fldElectionLevelId)
,
						new SqlParameter("@ElectionRegion", fldElectionRegion)
,
						new SqlParameter("@VotingDate", fldVotingDate)

					});

				rowCount = cmd.ExecuteNonQuery();
			}
			
			
			return rowCount;
		}
		
		/// <summary>
		/// Update by providing a populated data row container
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <returns>The number of rows affected.</returns>
		public virtual int Update(ElectionContract row)
		{
			var rowCount = 0;
			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[Election_Update]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ElectionId", row.ElectionId)
,
						new SqlParameter("@ContentInspectionId", row.ContentInspectionId)
,
						new SqlParameter("@ElectionLevelId", row.ElectionLevelId)
,
						new SqlParameter("@ElectionRegion", row.ElectionRegion)
,
						new SqlParameter("@VotingDate", row.VotingDate)

					});
            
					rowCount = cmd.ExecuteNonQuery();
				}
			});
			
			
			return rowCount;
		}

		/// <summary>
		/// Update by providing a populated data contract
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public virtual int Update(ElectionContract row, SqlConnection connection, SqlTransaction transaction)
		{
			var rowCount = 0;
			using (
				var cmd = new SqlCommand("[Data].[Election_Update]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ElectionId", row.ElectionId)
,
						new SqlParameter("@ContentInspectionId", row.ContentInspectionId)
,
						new SqlParameter("@ElectionLevelId", row.ElectionLevelId)
,
						new SqlParameter("@ElectionRegion", row.ElectionRegion)
,
						new SqlParameter("@VotingDate", row.VotingDate)

					});
            
				rowCount = cmd.ExecuteNonQuery();
			}
			
			
			return rowCount;
		}

		/// <summary>
		/// Update the rows in bulk, uses the same connection (faster).
		/// </summary>
		/// <param name="rows">The table rows to Update</param>
		/// <returns>The number of rows affected.</returns>
		public virtual int UpdateAll(List<ElectionContract> rows)
		{		
			var rowCount = 0;
			VotingInfoDb.ConnectThen(x => 
			{
				rowCount = UpdateAll(rows, x, null);
			});
			return rowCount;
		}

		/// <summary>
		/// Update the rows in bulk, uses the same connection (faster), in a provided transaction scrope.
		/// </summary>
		/// <param name="rows">The table rows to Update</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public virtual int UpdateAll(List<ElectionContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			var rowCount = 0;
			foreach(var row in rows) rowCount += Update(row, connection, transaction);
			return rowCount;
		}

		/// <summary>
		/// Run Election_Delete.
		/// </summary>
		/// <returns>The number of rows affected.</returns>
		/// <param name="fldElectionId">Value for ElectionId</param>
		public virtual int Delete(int fldElectionId
)
		{
			var rowCount = 0;
			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[Election_Delete]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ElectionId", fldElectionId)

					});

					rowCount = cmd.ExecuteNonQuery();
				}
			});
			
			
			return rowCount;
		}

		/// <summary>
		/// Run Election_Delete.
		/// </summary>
		/// <param name="fldElectionId">Value for ElectionId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public virtual int Delete(int fldElectionId
, SqlConnection connection, SqlTransaction transaction)
		{
			var rowCount = 0;
			using (
				var cmd = new SqlCommand("[Data].[Election_Delete]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ElectionId", fldElectionId)

					});

				rowCount = cmd.ExecuteNonQuery();
			}
			
			
			return rowCount;
		}
		
		/// <summary>
		/// Delete by providing a populated data row container
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <returns>The number of rows affected.</returns>
		public virtual int Delete(ElectionContract row)
		{
			var rowCount = 0;
			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[Election_Delete]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ElectionId", row.ElectionId)

					});
            
					rowCount = cmd.ExecuteNonQuery();
				}
			});
			
			
			return rowCount;
		}

		/// <summary>
		/// Delete by providing a populated data contract
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public virtual int Delete(ElectionContract row, SqlConnection connection, SqlTransaction transaction)
		{
			var rowCount = 0;
			using (
				var cmd = new SqlCommand("[Data].[Election_Delete]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ElectionId", row.ElectionId)

					});
            
				rowCount = cmd.ExecuteNonQuery();
			}
			
			
			return rowCount;
		}

		/// <summary>
		/// Delete the rows in bulk, uses the same connection (faster).
		/// </summary>
		/// <param name="rows">The table rows to Delete</param>
		/// <returns>The number of rows affected.</returns>
		public virtual int DeleteAll(List<ElectionContract> rows)
		{		
			var rowCount = 0;
			VotingInfoDb.ConnectThen(x => 
			{
				rowCount = DeleteAll(rows, x, null);
			});
			return rowCount;
		}

		/// <summary>
		/// Delete the rows in bulk, uses the same connection (faster), in a provided transaction scrope.
		/// </summary>
		/// <param name="rows">The table rows to Delete</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public virtual int DeleteAll(List<ElectionContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			var rowCount = 0;
			foreach(var row in rows) rowCount += Delete(row, connection, transaction);
			return rowCount;
		}

		/// <summary>
		/// Determine if the table contains a row with the existing values
		/// </summary>
		/// <param name="fldElectionId">Value for ElectionId</param>
		/// <returns>True, if the values exist, or false.</returns>
		public virtual bool Exists(int fldElectionId
)
		{
			bool result = false;

			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[Election_Exists]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ElectionId", fldElectionId)

					});

					result = (bool)cmd.ExecuteScalar();
				}
			});

			return result;
		}

		/// <summary>
		/// Determine if the table contains a row with the existing values
		/// </summary>
		/// <param name="fldElectionId">Value for ElectionId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>True, if the values exist, or false.</returns>
		public virtual bool Exists(int fldElectionId
, SqlConnection connection, SqlTransaction transaction)
		{					
			using (
				var cmd = new SqlCommand("[Data].[Election_Exists]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ElectionId", fldElectionId)

					});

					return (bool)cmd.ExecuteScalar();
			}
		}

		/// <summary>
		/// Run Election_Search, and return results as a list of ElectionRow.
		/// </summary>
		/// <param name="fldElectionRegion">Value for ElectionRegion</param>
		/// <returns>A collection of ElectionRow.</returns>
		public virtual bool Search(string fldElectionRegion
)
		{
			var result = false;

			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[Election_Search]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ElectionRegion", fldElectionRegion)

					});

					using(var r = cmd.ExecuteReader()) result = ReadAll(r);
				}
			});

			return result;
		}

		/// <summary>
		/// Run Election_Search, and return results as a list of ElectionRow.
		/// </summary>
		/// <param name="fldElectionRegion">Value for ElectionRegion</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of ElectionRow.</returns>
		public virtual bool Search(string fldElectionRegion
, SqlConnection connection, SqlTransaction transaction)
		{
			using (
				var cmd = new SqlCommand("[Data].[Election_Search]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ElectionRegion", fldElectionRegion)

					});

				using(var r = cmd.ExecuteReader()) return ReadAll(r);
			}
		}

		/// <summary>
		/// Run Election_SelectAll, and return results as a list of ElectionRow.
		/// </summary>

		/// <returns>A collection of ElectionRow.</returns>
		public virtual bool SelectAll()
		{
			var result = false;

			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[Election_SelectAll]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					using(var r = cmd.ExecuteReader()) result = ReadAll(r);
				}
			});

			return result;
		}

		/// <summary>
		/// Run Election_SelectAll, and return results as a list of ElectionRow.
		/// </summary>

		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of ElectionRow.</returns>
		public virtual bool SelectAll(SqlConnection connection, SqlTransaction transaction)
		{
			using (
				var cmd = new SqlCommand("[Data].[Election_SelectAll]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
				using(var r = cmd.ExecuteReader()) return ReadAll(r);
			}
		}

		/// <summary>
		/// Run Election_SelectBy_ElectionId, and return results as a list of ElectionRow.
		/// </summary>
		/// <param name="fldElectionId">Value for ElectionId</param>
		/// <returns>A collection of ElectionRow.</returns>
		public virtual bool SelectBy_ElectionId(int fldElectionId
)
		{
			var result = false;

			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[Election_SelectBy_ElectionId]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ElectionId", fldElectionId)

					});

					using(var r = cmd.ExecuteReader()) result = ReadAll(r);
				}
			});

			return result;
		}

		/// <summary>
		/// Run Election_SelectBy_ElectionId, and return results as a list of ElectionRow.
		/// </summary>
		/// <param name="fldElectionId">Value for ElectionId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of ElectionRow.</returns>
		public virtual bool SelectBy_ElectionId(int fldElectionId
, SqlConnection connection, SqlTransaction transaction)
		{
			using (
				var cmd = new SqlCommand("[Data].[Election_SelectBy_ElectionId]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ElectionId", fldElectionId)

					});

				using(var r = cmd.ExecuteReader()) return ReadAll(r);
			}
		}

		/// <summary>
		/// Run Election_SelectBy_ElectionLevelId, and return results as a list of ElectionRow.
		/// </summary>
		/// <param name="fldElectionLevelId">Value for ElectionLevelId</param>
		/// <returns>A collection of ElectionRow.</returns>
		public virtual bool SelectBy_ElectionLevelId(int fldElectionLevelId
)
		{
			var result = false;

			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[Election_SelectBy_ElectionLevelId]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ElectionLevelId", fldElectionLevelId)

					});

					using(var r = cmd.ExecuteReader()) result = ReadAll(r);
				}
			});

			return result;
		}

		/// <summary>
		/// Run Election_SelectBy_ElectionLevelId, and return results as a list of ElectionRow.
		/// </summary>
		/// <param name="fldElectionLevelId">Value for ElectionLevelId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of ElectionRow.</returns>
		public virtual bool SelectBy_ElectionLevelId(int fldElectionLevelId
, SqlConnection connection, SqlTransaction transaction)
		{
			using (
				var cmd = new SqlCommand("[Data].[Election_SelectBy_ElectionLevelId]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ElectionLevelId", fldElectionLevelId)

					});

				using(var r = cmd.ExecuteReader()) return ReadAll(r);
			}
		}

		/// <summary>
		/// Run Election_SelectBy_ContentInspectionId, and return results as a list of ElectionRow.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <returns>A collection of ElectionRow.</returns>
		public virtual bool SelectBy_ContentInspectionId(int fldContentInspectionId
)
		{
			var result = false;

			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[Election_SelectBy_ContentInspectionId]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ContentInspectionId", fldContentInspectionId)

					});

					using(var r = cmd.ExecuteReader()) result = ReadAll(r);
				}
			});

			return result;
		}

		/// <summary>
		/// Run Election_SelectBy_ContentInspectionId, and return results as a list of ElectionRow.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of ElectionRow.</returns>
		public virtual bool SelectBy_ContentInspectionId(int fldContentInspectionId
, SqlConnection connection, SqlTransaction transaction)
		{
			using (
				var cmd = new SqlCommand("[Data].[Election_SelectBy_ContentInspectionId]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ContentInspectionId", fldContentInspectionId)

					});

				using(var r = cmd.ExecuteReader()) return ReadAll(r);
			}
		}

		/// <summary>
		/// Read all items into this collection
		/// </summary>
		/// <param name="reader">The result of running a sql command.</param>
		public virtual bool ReadAll(SqlDataReader reader)
		{
			var canRead = ReadOne(reader);
			var result = canRead;

			while (canRead) canRead = ReadOne(reader);

			return result;
		}
		/// <summary>
		/// Read one item into Results
		/// </summary>
		/// <param name="reader">The result of running a sql command.</param>
		public virtual bool ReadOne(SqlDataReader reader)
		{
			if (reader.Read())
			{
				Results.Add(
					new ElectionContract
					{
					ElectionId = reader.GetInt32(0),
					ContentInspectionId = reader.GetInt32(1),
					ElectionLevelId = reader.GetInt32(2),
					ElectionRegion = reader.GetString(3),
					VotingDate = reader.GetDateTime(4),

					});
				return true;
			}
			return false;
		}
		/// <summary>
		/// Saves the row, either by inserting (when the identity key is null) or by updating (identity key has value).
		/// </summary>
		/// <param name="row">The data to save</param>
		/// <returns>The number of rows affected.</returns>
		public virtual int Save(ElectionContract row)
		{
			if(row == null) return 0;
			if(row.ElectionId != null) return Update(row);
			
			return Insert(row);
		}

		/// <summary>
		/// Saves the row, either by inserting (when the identity key is null) or by updating (identity key has value).
		/// </summary>
		/// <param name="row">The data to save</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public virtual int Save(ElectionContract row, SqlConnection connection, SqlTransaction transaction)
		{
			if(row == null) return 0;
			if(row.ElectionId != null) return Update(row, connection, transaction);
			
			return Insert(row, connection, transaction);
		}		

		/// <summary>
		/// Save the rows in bulk, uses the same connection (faster).
		/// </summary>
		/// <param name="rows">The table rows to Save</param>
		/// <returns>The number of rows affected.</returns>
		public virtual int SaveAll(List<ElectionContract> rows)
		{		
			var rowCount = 0;
			VotingInfoDb.ConnectThen(x => 
			{
				foreach(var row in rows) rowCount += Save(row, x, null);
			});
			return rowCount;
		}

		/// <summary>
		/// Save the rows in bulk, uses the same connection (faster), in a provided transaction scrope.
		/// </summary>
		/// <param name="rows">The table rows to Save</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public virtual int SaveAll(List<ElectionContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			var rowCount = 0;
			foreach(var row in rows) rowCount += Save(row, connection, transaction);
			return rowCount;
		}
	}
}