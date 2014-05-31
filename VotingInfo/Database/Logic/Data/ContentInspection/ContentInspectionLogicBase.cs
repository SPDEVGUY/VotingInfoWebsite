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
	public abstract partial class ContentInspectionLogicBase : LogicBase<ContentInspectionLogicBase>
	{
		//Put your code in a separate file.  This is auto generated.
    
		[XmlArray] public List<ContentInspectionContract> Results;

		public ContentInspectionLogicBase()
		{
			Results =  new List<ContentInspectionContract>();
		}

		/// <summary>
		/// Run ContentInspection_Insert.
		/// </summary>
		/// <param name="fldIsArchived">Value for IsArchived</param>
		/// <param name="fldIsBeingProposed">Value for IsBeingProposed</param>
		/// <param name="fldProposedByUserId">Value for ProposedByUserId</param>
		/// <param name="fldConfirmedByUserId">Value for ConfirmedByUserId</param>
		/// <param name="fldFalseInfoCount">Value for FalseInfoCount</param>
		/// <param name="fldTrueInfoCount">Value for TrueInfoCount</param>
		/// <param name="fldAdminInpsected">Value for AdminInpsected</param>
		/// <param name="fldDateLastChecked">Value for DateLastChecked</param>
		/// <param name="fldSourceUrl">Value for SourceUrl</param>
		/// <returns>The new ID</returns>
		public virtual int? Insert(bool fldIsArchived
, bool fldIsBeingProposed
, int fldProposedByUserId
, int fldConfirmedByUserId
, int fldFalseInfoCount
, int fldTrueInfoCount
, bool fldAdminInpsected
, DateTime fldDateLastChecked
, string fldSourceUrl
)
		{
			int? result = null;
			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[ContentInspection_Insert]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@IsArchived", fldIsArchived)
,
						new SqlParameter("@IsBeingProposed", fldIsBeingProposed)
,
						new SqlParameter("@ProposedByUserId", fldProposedByUserId)
,
						new SqlParameter("@ConfirmedByUserId", fldConfirmedByUserId)
,
						new SqlParameter("@FalseInfoCount", fldFalseInfoCount)
,
						new SqlParameter("@TrueInfoCount", fldTrueInfoCount)
,
						new SqlParameter("@AdminInpsected", fldAdminInpsected)
,
						new SqlParameter("@DateLastChecked", fldDateLastChecked)
,
						new SqlParameter("@SourceUrl", fldSourceUrl)

					});

					result = (int?)cmd.ExecuteScalar();
				}
			});
			return result;
		}

		/// <summary>
		/// Run ContentInspection_Insert.
		/// </summary>
		/// <param name="fldIsArchived">Value for IsArchived</param>
		/// <param name="fldIsBeingProposed">Value for IsBeingProposed</param>
		/// <param name="fldProposedByUserId">Value for ProposedByUserId</param>
		/// <param name="fldConfirmedByUserId">Value for ConfirmedByUserId</param>
		/// <param name="fldFalseInfoCount">Value for FalseInfoCount</param>
		/// <param name="fldTrueInfoCount">Value for TrueInfoCount</param>
		/// <param name="fldAdminInpsected">Value for AdminInpsected</param>
		/// <param name="fldDateLastChecked">Value for DateLastChecked</param>
		/// <param name="fldSourceUrl">Value for SourceUrl</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The new ID</returns>
		public virtual int? Insert(bool fldIsArchived
, bool fldIsBeingProposed
, int fldProposedByUserId
, int fldConfirmedByUserId
, int fldFalseInfoCount
, int fldTrueInfoCount
, bool fldAdminInpsected
, DateTime fldDateLastChecked
, string fldSourceUrl
, SqlConnection connection, SqlTransaction transaction)
		{
			using (
				var cmd = new SqlCommand("[Data].[ContentInspection_Insert]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@IsArchived", fldIsArchived)
,
						new SqlParameter("@IsBeingProposed", fldIsBeingProposed)
,
						new SqlParameter("@ProposedByUserId", fldProposedByUserId)
,
						new SqlParameter("@ConfirmedByUserId", fldConfirmedByUserId)
,
						new SqlParameter("@FalseInfoCount", fldFalseInfoCount)
,
						new SqlParameter("@TrueInfoCount", fldTrueInfoCount)
,
						new SqlParameter("@AdminInpsected", fldAdminInpsected)
,
						new SqlParameter("@DateLastChecked", fldDateLastChecked)
,
						new SqlParameter("@SourceUrl", fldSourceUrl)

					});

				return (int?)cmd.ExecuteScalar();
			}
		}

		/// <summary>
		/// Insert by providing a populated data row container
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <returns>1, if insert was successful</returns>
		public int Insert(ContentInspectionContract row)
		{
			int? result = null;
			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[ContentInspection_Insert]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@IsArchived", row.IsArchived)
,
						new SqlParameter("@IsBeingProposed", row.IsBeingProposed)
,
						new SqlParameter("@ProposedByUserId", row.ProposedByUserId)
,
						new SqlParameter("@ConfirmedByUserId", row.ConfirmedByUserId)
,
						new SqlParameter("@FalseInfoCount", row.FalseInfoCount)
,
						new SqlParameter("@TrueInfoCount", row.TrueInfoCount)
,
						new SqlParameter("@AdminInpsected", row.AdminInpsected)
,
						new SqlParameter("@DateLastChecked", row.DateLastChecked)
,
						new SqlParameter("@SourceUrl", row.SourceUrl)

					});
            
					result = (int?)cmd.ExecuteScalar();
					row.ContentInspectionId = result;
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
		public int Insert(ContentInspectionContract row, SqlConnection connection, SqlTransaction transaction)
		{
			int? result = null;
			using (
				var cmd = new SqlCommand("[Data].[ContentInspection_Insert]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@IsArchived", row.IsArchived)
,
						new SqlParameter("@IsBeingProposed", row.IsBeingProposed)
,
						new SqlParameter("@ProposedByUserId", row.ProposedByUserId)
,
						new SqlParameter("@ConfirmedByUserId", row.ConfirmedByUserId)
,
						new SqlParameter("@FalseInfoCount", row.FalseInfoCount)
,
						new SqlParameter("@TrueInfoCount", row.TrueInfoCount)
,
						new SqlParameter("@AdminInpsected", row.AdminInpsected)
,
						new SqlParameter("@DateLastChecked", row.DateLastChecked)
,
						new SqlParameter("@SourceUrl", row.SourceUrl)

					});
            
				result = (int?)cmd.ExecuteScalar();
				row.ContentInspectionId = result;
			}
			return result != null ? 1 : 0;
		}
		/// <summary>
		/// Insert the rows in bulk, uses the same connection (faster).
		/// </summary>
		/// <param name="rows">The table rows to Insert</param>
		/// <returns>The number of rows affected.</returns>
		public virtual int InsertAll(List<ContentInspectionContract> rows)
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
		public virtual int InsertAll(List<ContentInspectionContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			var rowCount = 0;
			foreach(var row in rows) rowCount += Insert(row, connection, transaction);
			return rowCount;
		}

		/// <summary>
		/// Run ContentInspection_Update.
		/// </summary>
		/// <returns>The number of rows affected.</returns>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldIsArchived">Value for IsArchived</param>
		/// <param name="fldIsBeingProposed">Value for IsBeingProposed</param>
		/// <param name="fldProposedByUserId">Value for ProposedByUserId</param>
		/// <param name="fldConfirmedByUserId">Value for ConfirmedByUserId</param>
		/// <param name="fldFalseInfoCount">Value for FalseInfoCount</param>
		/// <param name="fldTrueInfoCount">Value for TrueInfoCount</param>
		/// <param name="fldAdminInpsected">Value for AdminInpsected</param>
		/// <param name="fldDateLastChecked">Value for DateLastChecked</param>
		/// <param name="fldSourceUrl">Value for SourceUrl</param>
		public virtual int Update(int fldContentInspectionId
, bool fldIsArchived
, bool fldIsBeingProposed
, int fldProposedByUserId
, int fldConfirmedByUserId
, int fldFalseInfoCount
, int fldTrueInfoCount
, bool fldAdminInpsected
, DateTime fldDateLastChecked
, string fldSourceUrl
)
		{
			var rowCount = 0;
			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[ContentInspection_Update]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ContentInspectionId", fldContentInspectionId)
,
						new SqlParameter("@IsArchived", fldIsArchived)
,
						new SqlParameter("@IsBeingProposed", fldIsBeingProposed)
,
						new SqlParameter("@ProposedByUserId", fldProposedByUserId)
,
						new SqlParameter("@ConfirmedByUserId", fldConfirmedByUserId)
,
						new SqlParameter("@FalseInfoCount", fldFalseInfoCount)
,
						new SqlParameter("@TrueInfoCount", fldTrueInfoCount)
,
						new SqlParameter("@AdminInpsected", fldAdminInpsected)
,
						new SqlParameter("@DateLastChecked", fldDateLastChecked)
,
						new SqlParameter("@SourceUrl", fldSourceUrl)

					});

					rowCount = cmd.ExecuteNonQuery();
				}
			});
			
			
			return rowCount;
		}

		/// <summary>
		/// Run ContentInspection_Update.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldIsArchived">Value for IsArchived</param>
		/// <param name="fldIsBeingProposed">Value for IsBeingProposed</param>
		/// <param name="fldProposedByUserId">Value for ProposedByUserId</param>
		/// <param name="fldConfirmedByUserId">Value for ConfirmedByUserId</param>
		/// <param name="fldFalseInfoCount">Value for FalseInfoCount</param>
		/// <param name="fldTrueInfoCount">Value for TrueInfoCount</param>
		/// <param name="fldAdminInpsected">Value for AdminInpsected</param>
		/// <param name="fldDateLastChecked">Value for DateLastChecked</param>
		/// <param name="fldSourceUrl">Value for SourceUrl</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public virtual int Update(int fldContentInspectionId
, bool fldIsArchived
, bool fldIsBeingProposed
, int fldProposedByUserId
, int fldConfirmedByUserId
, int fldFalseInfoCount
, int fldTrueInfoCount
, bool fldAdminInpsected
, DateTime fldDateLastChecked
, string fldSourceUrl
, SqlConnection connection, SqlTransaction transaction)
		{
			var rowCount = 0;
			using (
				var cmd = new SqlCommand("[Data].[ContentInspection_Update]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ContentInspectionId", fldContentInspectionId)
,
						new SqlParameter("@IsArchived", fldIsArchived)
,
						new SqlParameter("@IsBeingProposed", fldIsBeingProposed)
,
						new SqlParameter("@ProposedByUserId", fldProposedByUserId)
,
						new SqlParameter("@ConfirmedByUserId", fldConfirmedByUserId)
,
						new SqlParameter("@FalseInfoCount", fldFalseInfoCount)
,
						new SqlParameter("@TrueInfoCount", fldTrueInfoCount)
,
						new SqlParameter("@AdminInpsected", fldAdminInpsected)
,
						new SqlParameter("@DateLastChecked", fldDateLastChecked)
,
						new SqlParameter("@SourceUrl", fldSourceUrl)

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
		public virtual int Update(ContentInspectionContract row)
		{
			var rowCount = 0;
			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[ContentInspection_Update]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ContentInspectionId", row.ContentInspectionId)
,
						new SqlParameter("@IsArchived", row.IsArchived)
,
						new SqlParameter("@IsBeingProposed", row.IsBeingProposed)
,
						new SqlParameter("@ProposedByUserId", row.ProposedByUserId)
,
						new SqlParameter("@ConfirmedByUserId", row.ConfirmedByUserId)
,
						new SqlParameter("@FalseInfoCount", row.FalseInfoCount)
,
						new SqlParameter("@TrueInfoCount", row.TrueInfoCount)
,
						new SqlParameter("@AdminInpsected", row.AdminInpsected)
,
						new SqlParameter("@DateLastChecked", row.DateLastChecked)
,
						new SqlParameter("@SourceUrl", row.SourceUrl)

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
		public virtual int Update(ContentInspectionContract row, SqlConnection connection, SqlTransaction transaction)
		{
			var rowCount = 0;
			using (
				var cmd = new SqlCommand("[Data].[ContentInspection_Update]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ContentInspectionId", row.ContentInspectionId)
,
						new SqlParameter("@IsArchived", row.IsArchived)
,
						new SqlParameter("@IsBeingProposed", row.IsBeingProposed)
,
						new SqlParameter("@ProposedByUserId", row.ProposedByUserId)
,
						new SqlParameter("@ConfirmedByUserId", row.ConfirmedByUserId)
,
						new SqlParameter("@FalseInfoCount", row.FalseInfoCount)
,
						new SqlParameter("@TrueInfoCount", row.TrueInfoCount)
,
						new SqlParameter("@AdminInpsected", row.AdminInpsected)
,
						new SqlParameter("@DateLastChecked", row.DateLastChecked)
,
						new SqlParameter("@SourceUrl", row.SourceUrl)

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
		public virtual int UpdateAll(List<ContentInspectionContract> rows)
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
		public virtual int UpdateAll(List<ContentInspectionContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			var rowCount = 0;
			foreach(var row in rows) rowCount += Update(row, connection, transaction);
			return rowCount;
		}

		/// <summary>
		/// Run ContentInspection_Delete.
		/// </summary>
		/// <returns>The number of rows affected.</returns>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		public virtual int Delete(int fldContentInspectionId
)
		{
			var rowCount = 0;
			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[ContentInspection_Delete]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ContentInspectionId", fldContentInspectionId)

					});

					rowCount = cmd.ExecuteNonQuery();
				}
			});
			
			
			return rowCount;
		}

		/// <summary>
		/// Run ContentInspection_Delete.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public virtual int Delete(int fldContentInspectionId
, SqlConnection connection, SqlTransaction transaction)
		{
			var rowCount = 0;
			using (
				var cmd = new SqlCommand("[Data].[ContentInspection_Delete]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ContentInspectionId", fldContentInspectionId)

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
		public virtual int Delete(ContentInspectionContract row)
		{
			var rowCount = 0;
			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[ContentInspection_Delete]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ContentInspectionId", row.ContentInspectionId)

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
		public virtual int Delete(ContentInspectionContract row, SqlConnection connection, SqlTransaction transaction)
		{
			var rowCount = 0;
			using (
				var cmd = new SqlCommand("[Data].[ContentInspection_Delete]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ContentInspectionId", row.ContentInspectionId)

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
		public virtual int DeleteAll(List<ContentInspectionContract> rows)
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
		public virtual int DeleteAll(List<ContentInspectionContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			var rowCount = 0;
			foreach(var row in rows) rowCount += Delete(row, connection, transaction);
			return rowCount;
		}

		/// <summary>
		/// Determine if the table contains a row with the existing values
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <returns>True, if the values exist, or false.</returns>
		public virtual bool Exists(int fldContentInspectionId
)
		{
			bool result = false;

			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[ContentInspection_Exists]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ContentInspectionId", fldContentInspectionId)

					});

					result = (bool)cmd.ExecuteScalar();
				}
			});

			return result;
		}

		/// <summary>
		/// Determine if the table contains a row with the existing values
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>True, if the values exist, or false.</returns>
		public virtual bool Exists(int fldContentInspectionId
, SqlConnection connection, SqlTransaction transaction)
		{					
			using (
				var cmd = new SqlCommand("[Data].[ContentInspection_Exists]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ContentInspectionId", fldContentInspectionId)

					});

					return (bool)cmd.ExecuteScalar();
			}
		}

		/// <summary>
		/// Run ContentInspection_Search, and return results as a list of ContentInspectionRow.
		/// </summary>
		/// <param name="fldSourceUrl">Value for SourceUrl</param>
		/// <returns>A collection of ContentInspectionRow.</returns>
		public virtual bool Search(string fldSourceUrl
)
		{
			var result = false;

			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[ContentInspection_Search]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@SourceUrl", fldSourceUrl)

					});

					using(var r = cmd.ExecuteReader()) result = ReadAll(r);
				}
			});

			return result;
		}

		/// <summary>
		/// Run ContentInspection_Search, and return results as a list of ContentInspectionRow.
		/// </summary>
		/// <param name="fldSourceUrl">Value for SourceUrl</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of ContentInspectionRow.</returns>
		public virtual bool Search(string fldSourceUrl
, SqlConnection connection, SqlTransaction transaction)
		{
			using (
				var cmd = new SqlCommand("[Data].[ContentInspection_Search]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@SourceUrl", fldSourceUrl)

					});

				using(var r = cmd.ExecuteReader()) return ReadAll(r);
			}
		}

		/// <summary>
		/// Run ContentInspection_SelectAll, and return results as a list of ContentInspectionRow.
		/// </summary>

		/// <returns>A collection of ContentInspectionRow.</returns>
		public virtual bool SelectAll()
		{
			var result = false;

			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[ContentInspection_SelectAll]", x)
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
		/// Run ContentInspection_SelectAll, and return results as a list of ContentInspectionRow.
		/// </summary>

		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of ContentInspectionRow.</returns>
		public virtual bool SelectAll(SqlConnection connection, SqlTransaction transaction)
		{
			using (
				var cmd = new SqlCommand("[Data].[ContentInspection_SelectAll]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
				using(var r = cmd.ExecuteReader()) return ReadAll(r);
			}
		}

		/// <summary>
		/// Run ContentInspection_SelectBy_ContentInspectionId, and return results as a list of ContentInspectionRow.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <returns>A collection of ContentInspectionRow.</returns>
		public virtual bool SelectBy_ContentInspectionId(int fldContentInspectionId
)
		{
			var result = false;

			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[ContentInspection_SelectBy_ContentInspectionId]", x)
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
		/// Run ContentInspection_SelectBy_ContentInspectionId, and return results as a list of ContentInspectionRow.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of ContentInspectionRow.</returns>
		public virtual bool SelectBy_ContentInspectionId(int fldContentInspectionId
, SqlConnection connection, SqlTransaction transaction)
		{
			using (
				var cmd = new SqlCommand("[Data].[ContentInspection_SelectBy_ContentInspectionId]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ContentInspectionId", fldContentInspectionId)

					});

				using(var r = cmd.ExecuteReader()) return ReadAll(r);
			}
		}

		/// <summary>
		/// Run ContentInspection_SelectBy_ProposedByUserId, and return results as a list of ContentInspectionRow.
		/// </summary>
		/// <param name="fldProposedByUserId">Value for ProposedByUserId</param>
		/// <returns>A collection of ContentInspectionRow.</returns>
		public virtual bool SelectBy_ProposedByUserId(int fldProposedByUserId
)
		{
			var result = false;

			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[ContentInspection_SelectBy_ProposedByUserId]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ProposedByUserId", fldProposedByUserId)

					});

					using(var r = cmd.ExecuteReader()) result = ReadAll(r);
				}
			});

			return result;
		}

		/// <summary>
		/// Run ContentInspection_SelectBy_ProposedByUserId, and return results as a list of ContentInspectionRow.
		/// </summary>
		/// <param name="fldProposedByUserId">Value for ProposedByUserId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of ContentInspectionRow.</returns>
		public virtual bool SelectBy_ProposedByUserId(int fldProposedByUserId
, SqlConnection connection, SqlTransaction transaction)
		{
			using (
				var cmd = new SqlCommand("[Data].[ContentInspection_SelectBy_ProposedByUserId]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ProposedByUserId", fldProposedByUserId)

					});

				using(var r = cmd.ExecuteReader()) return ReadAll(r);
			}
		}

		/// <summary>
		/// Run ContentInspection_SelectBy_ConfirmedByUserId, and return results as a list of ContentInspectionRow.
		/// </summary>
		/// <param name="fldConfirmedByUserId">Value for ConfirmedByUserId</param>
		/// <returns>A collection of ContentInspectionRow.</returns>
		public virtual bool SelectBy_ConfirmedByUserId(int fldConfirmedByUserId
)
		{
			var result = false;

			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[ContentInspection_SelectBy_ConfirmedByUserId]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ConfirmedByUserId", fldConfirmedByUserId)

					});

					using(var r = cmd.ExecuteReader()) result = ReadAll(r);
				}
			});

			return result;
		}

		/// <summary>
		/// Run ContentInspection_SelectBy_ConfirmedByUserId, and return results as a list of ContentInspectionRow.
		/// </summary>
		/// <param name="fldConfirmedByUserId">Value for ConfirmedByUserId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of ContentInspectionRow.</returns>
		public virtual bool SelectBy_ConfirmedByUserId(int fldConfirmedByUserId
, SqlConnection connection, SqlTransaction transaction)
		{
			using (
				var cmd = new SqlCommand("[Data].[ContentInspection_SelectBy_ConfirmedByUserId]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ConfirmedByUserId", fldConfirmedByUserId)

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
					new ContentInspectionContract
					{
					ContentInspectionId = reader.GetInt32(0),
					IsArchived = reader.GetBoolean(1),
					IsBeingProposed = reader.GetBoolean(2),
					ProposedByUserId = reader.GetInt32(3),
					ConfirmedByUserId = reader.GetInt32(4),
					FalseInfoCount = reader.GetInt32(5),
					TrueInfoCount = reader.GetInt32(6),
					AdminInpsected = reader.GetBoolean(7),
					DateLastChecked = reader.GetDateTime(8),
					SourceUrl = reader.GetString(9),

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
		public virtual int Save(ContentInspectionContract row)
		{
			if(row == null) return 0;
			if(row.ContentInspectionId != null) return Update(row);
			
			return Insert(row);
		}

		/// <summary>
		/// Saves the row, either by inserting (when the identity key is null) or by updating (identity key has value).
		/// </summary>
		/// <param name="row">The data to save</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public virtual int Save(ContentInspectionContract row, SqlConnection connection, SqlTransaction transaction)
		{
			if(row == null) return 0;
			if(row.ContentInspectionId != null) return Update(row, connection, transaction);
			
			return Insert(row, connection, transaction);
		}		

		/// <summary>
		/// Save the rows in bulk, uses the same connection (faster).
		/// </summary>
		/// <param name="rows">The table rows to Save</param>
		/// <returns>The number of rows affected.</returns>
		public virtual int SaveAll(List<ContentInspectionContract> rows)
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
		public virtual int SaveAll(List<ContentInspectionContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			var rowCount = 0;
			foreach(var row in rows) rowCount += Save(row, connection, transaction);
			return rowCount;
		}
	}
}