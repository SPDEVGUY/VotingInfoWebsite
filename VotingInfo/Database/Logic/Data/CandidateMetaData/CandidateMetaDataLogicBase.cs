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
	public abstract partial class CandidateMetaDataLogicBase : LogicBase<CandidateMetaDataLogicBase>
	{
		//Put your code in a separate file.  This is auto generated.
    
		[XmlArray] public List<CandidateMetaDataContract> Results;

		public CandidateMetaDataLogicBase()
		{
			Results =  new List<CandidateMetaDataContract>();
		}

		/// <summary>
		/// Run CandidateMetaData_Insert.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldCandidateId">Value for CandidateId</param>
		/// <param name="fldMetaDataId">Value for MetaDataId</param>
		/// <param name="fldMetaDataValue">Value for MetaDataValue</param>
		/// <returns>The new ID</returns>
		public virtual int? Insert(int fldContentInspectionId
, int fldCandidateId
, int fldMetaDataId
, string fldMetaDataValue
)
		{
			int? result = null;
			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[CandidateMetaData_Insert]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ContentInspectionId", fldContentInspectionId)
,
						new SqlParameter("@CandidateId", fldCandidateId)
,
						new SqlParameter("@MetaDataId", fldMetaDataId)
,
						new SqlParameter("@MetaDataValue", fldMetaDataValue)

					});

					result = (int?)cmd.ExecuteScalar();
				}
			});
			return result;
		}

		/// <summary>
		/// Run CandidateMetaData_Insert.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldCandidateId">Value for CandidateId</param>
		/// <param name="fldMetaDataId">Value for MetaDataId</param>
		/// <param name="fldMetaDataValue">Value for MetaDataValue</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The new ID</returns>
		public virtual int? Insert(int fldContentInspectionId
, int fldCandidateId
, int fldMetaDataId
, string fldMetaDataValue
, SqlConnection connection, SqlTransaction transaction)
		{
			using (
				var cmd = new SqlCommand("[Data].[CandidateMetaData_Insert]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ContentInspectionId", fldContentInspectionId)
,
						new SqlParameter("@CandidateId", fldCandidateId)
,
						new SqlParameter("@MetaDataId", fldMetaDataId)
,
						new SqlParameter("@MetaDataValue", fldMetaDataValue)

					});

				return (int?)cmd.ExecuteScalar();
			}
		}

		/// <summary>
		/// Insert by providing a populated data row container
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <returns>1, if insert was successful</returns>
		public int Insert(CandidateMetaDataContract row)
		{
			int? result = null;
			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[CandidateMetaData_Insert]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ContentInspectionId", row.ContentInspectionId)
,
						new SqlParameter("@CandidateId", row.CandidateId)
,
						new SqlParameter("@MetaDataId", row.MetaDataId)
,
						new SqlParameter("@MetaDataValue", row.MetaDataValue)

					});
            
					result = (int?)cmd.ExecuteScalar();
					row.CandidateMetaDataId = result;
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
		public int Insert(CandidateMetaDataContract row, SqlConnection connection, SqlTransaction transaction)
		{
			int? result = null;
			using (
				var cmd = new SqlCommand("[Data].[CandidateMetaData_Insert]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ContentInspectionId", row.ContentInspectionId)
,
						new SqlParameter("@CandidateId", row.CandidateId)
,
						new SqlParameter("@MetaDataId", row.MetaDataId)
,
						new SqlParameter("@MetaDataValue", row.MetaDataValue)

					});
            
				result = (int?)cmd.ExecuteScalar();
				row.CandidateMetaDataId = result;
			}
			return result != null ? 1 : 0;
		}
		/// <summary>
		/// Insert the rows in bulk, uses the same connection (faster).
		/// </summary>
		/// <param name="rows">The table rows to Insert</param>
		/// <returns>The number of rows affected.</returns>
		public virtual int InsertAll(List<CandidateMetaDataContract> rows)
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
		public virtual int InsertAll(List<CandidateMetaDataContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			var rowCount = 0;
			foreach(var row in rows) rowCount += Insert(row, connection, transaction);
			return rowCount;
		}

		/// <summary>
		/// Run CandidateMetaData_Update.
		/// </summary>
		/// <returns>The number of rows affected.</returns>
		/// <param name="fldCandidateMetaDataId">Value for CandidateMetaDataId</param>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldCandidateId">Value for CandidateId</param>
		/// <param name="fldMetaDataId">Value for MetaDataId</param>
		/// <param name="fldMetaDataValue">Value for MetaDataValue</param>
		public virtual int Update(int fldCandidateMetaDataId
, int fldContentInspectionId
, int fldCandidateId
, int fldMetaDataId
, string fldMetaDataValue
)
		{
			var rowCount = 0;
			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[CandidateMetaData_Update]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@CandidateMetaDataId", fldCandidateMetaDataId)
,
						new SqlParameter("@ContentInspectionId", fldContentInspectionId)
,
						new SqlParameter("@CandidateId", fldCandidateId)
,
						new SqlParameter("@MetaDataId", fldMetaDataId)
,
						new SqlParameter("@MetaDataValue", fldMetaDataValue)

					});

					rowCount = cmd.ExecuteNonQuery();
				}
			});
			
			
			return rowCount;
		}

		/// <summary>
		/// Run CandidateMetaData_Update.
		/// </summary>
		/// <param name="fldCandidateMetaDataId">Value for CandidateMetaDataId</param>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldCandidateId">Value for CandidateId</param>
		/// <param name="fldMetaDataId">Value for MetaDataId</param>
		/// <param name="fldMetaDataValue">Value for MetaDataValue</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public virtual int Update(int fldCandidateMetaDataId
, int fldContentInspectionId
, int fldCandidateId
, int fldMetaDataId
, string fldMetaDataValue
, SqlConnection connection, SqlTransaction transaction)
		{
			var rowCount = 0;
			using (
				var cmd = new SqlCommand("[Data].[CandidateMetaData_Update]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@CandidateMetaDataId", fldCandidateMetaDataId)
,
						new SqlParameter("@ContentInspectionId", fldContentInspectionId)
,
						new SqlParameter("@CandidateId", fldCandidateId)
,
						new SqlParameter("@MetaDataId", fldMetaDataId)
,
						new SqlParameter("@MetaDataValue", fldMetaDataValue)

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
		public virtual int Update(CandidateMetaDataContract row)
		{
			var rowCount = 0;
			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[CandidateMetaData_Update]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@CandidateMetaDataId", row.CandidateMetaDataId)
,
						new SqlParameter("@ContentInspectionId", row.ContentInspectionId)
,
						new SqlParameter("@CandidateId", row.CandidateId)
,
						new SqlParameter("@MetaDataId", row.MetaDataId)
,
						new SqlParameter("@MetaDataValue", row.MetaDataValue)

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
		public virtual int Update(CandidateMetaDataContract row, SqlConnection connection, SqlTransaction transaction)
		{
			var rowCount = 0;
			using (
				var cmd = new SqlCommand("[Data].[CandidateMetaData_Update]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@CandidateMetaDataId", row.CandidateMetaDataId)
,
						new SqlParameter("@ContentInspectionId", row.ContentInspectionId)
,
						new SqlParameter("@CandidateId", row.CandidateId)
,
						new SqlParameter("@MetaDataId", row.MetaDataId)
,
						new SqlParameter("@MetaDataValue", row.MetaDataValue)

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
		public virtual int UpdateAll(List<CandidateMetaDataContract> rows)
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
		public virtual int UpdateAll(List<CandidateMetaDataContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			var rowCount = 0;
			foreach(var row in rows) rowCount += Update(row, connection, transaction);
			return rowCount;
		}

		/// <summary>
		/// Run CandidateMetaData_Delete.
		/// </summary>
		/// <returns>The number of rows affected.</returns>
		/// <param name="fldCandidateMetaDataId">Value for CandidateMetaDataId</param>
		public virtual int Delete(int fldCandidateMetaDataId
)
		{
			var rowCount = 0;
			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[CandidateMetaData_Delete]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@CandidateMetaDataId", fldCandidateMetaDataId)

					});

					rowCount = cmd.ExecuteNonQuery();
				}
			});
			
			
			return rowCount;
		}

		/// <summary>
		/// Run CandidateMetaData_Delete.
		/// </summary>
		/// <param name="fldCandidateMetaDataId">Value for CandidateMetaDataId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public virtual int Delete(int fldCandidateMetaDataId
, SqlConnection connection, SqlTransaction transaction)
		{
			var rowCount = 0;
			using (
				var cmd = new SqlCommand("[Data].[CandidateMetaData_Delete]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@CandidateMetaDataId", fldCandidateMetaDataId)

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
		public virtual int Delete(CandidateMetaDataContract row)
		{
			var rowCount = 0;
			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[CandidateMetaData_Delete]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@CandidateMetaDataId", row.CandidateMetaDataId)

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
		public virtual int Delete(CandidateMetaDataContract row, SqlConnection connection, SqlTransaction transaction)
		{
			var rowCount = 0;
			using (
				var cmd = new SqlCommand("[Data].[CandidateMetaData_Delete]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@CandidateMetaDataId", row.CandidateMetaDataId)

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
		public virtual int DeleteAll(List<CandidateMetaDataContract> rows)
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
		public virtual int DeleteAll(List<CandidateMetaDataContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			var rowCount = 0;
			foreach(var row in rows) rowCount += Delete(row, connection, transaction);
			return rowCount;
		}

		/// <summary>
		/// Determine if the table contains a row with the existing values
		/// </summary>
		/// <param name="fldCandidateMetaDataId">Value for CandidateMetaDataId</param>
		/// <returns>True, if the values exist, or false.</returns>
		public virtual bool Exists(int fldCandidateMetaDataId
)
		{
			bool result = false;

			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[CandidateMetaData_Exists]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@CandidateMetaDataId", fldCandidateMetaDataId)

					});

					result = (bool)cmd.ExecuteScalar();
				}
			});

			return result;
		}

		/// <summary>
		/// Determine if the table contains a row with the existing values
		/// </summary>
		/// <param name="fldCandidateMetaDataId">Value for CandidateMetaDataId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>True, if the values exist, or false.</returns>
		public virtual bool Exists(int fldCandidateMetaDataId
, SqlConnection connection, SqlTransaction transaction)
		{					
			using (
				var cmd = new SqlCommand("[Data].[CandidateMetaData_Exists]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@CandidateMetaDataId", fldCandidateMetaDataId)

					});

					return (bool)cmd.ExecuteScalar();
			}
		}

		/// <summary>
		/// Run CandidateMetaData_Search, and return results as a list of CandidateMetaDataRow.
		/// </summary>
		/// <param name="fldMetaDataValue">Value for MetaDataValue</param>
		/// <returns>A collection of CandidateMetaDataRow.</returns>
		public virtual bool Search(string fldMetaDataValue
)
		{
			var result = false;

			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[CandidateMetaData_Search]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@MetaDataValue", fldMetaDataValue)

					});

					using(var r = cmd.ExecuteReader()) result = ReadAll(r);
				}
			});

			return result;
		}

		/// <summary>
		/// Run CandidateMetaData_Search, and return results as a list of CandidateMetaDataRow.
		/// </summary>
		/// <param name="fldMetaDataValue">Value for MetaDataValue</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of CandidateMetaDataRow.</returns>
		public virtual bool Search(string fldMetaDataValue
, SqlConnection connection, SqlTransaction transaction)
		{
			using (
				var cmd = new SqlCommand("[Data].[CandidateMetaData_Search]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@MetaDataValue", fldMetaDataValue)

					});

				using(var r = cmd.ExecuteReader()) return ReadAll(r);
			}
		}

		/// <summary>
		/// Run CandidateMetaData_SelectAll, and return results as a list of CandidateMetaDataRow.
		/// </summary>

		/// <returns>A collection of CandidateMetaDataRow.</returns>
		public virtual bool SelectAll()
		{
			var result = false;

			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[CandidateMetaData_SelectAll]", x)
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
		/// Run CandidateMetaData_SelectAll, and return results as a list of CandidateMetaDataRow.
		/// </summary>

		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of CandidateMetaDataRow.</returns>
		public virtual bool SelectAll(SqlConnection connection, SqlTransaction transaction)
		{
			using (
				var cmd = new SqlCommand("[Data].[CandidateMetaData_SelectAll]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
				using(var r = cmd.ExecuteReader()) return ReadAll(r);
			}
		}

		/// <summary>
		/// Run CandidateMetaData_SelectBy_CandidateMetaDataId, and return results as a list of CandidateMetaDataRow.
		/// </summary>
		/// <param name="fldCandidateMetaDataId">Value for CandidateMetaDataId</param>
		/// <returns>A collection of CandidateMetaDataRow.</returns>
		public virtual bool SelectBy_CandidateMetaDataId(int fldCandidateMetaDataId
)
		{
			var result = false;

			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[CandidateMetaData_SelectBy_CandidateMetaDataId]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@CandidateMetaDataId", fldCandidateMetaDataId)

					});

					using(var r = cmd.ExecuteReader()) result = ReadAll(r);
				}
			});

			return result;
		}

		/// <summary>
		/// Run CandidateMetaData_SelectBy_CandidateMetaDataId, and return results as a list of CandidateMetaDataRow.
		/// </summary>
		/// <param name="fldCandidateMetaDataId">Value for CandidateMetaDataId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of CandidateMetaDataRow.</returns>
		public virtual bool SelectBy_CandidateMetaDataId(int fldCandidateMetaDataId
, SqlConnection connection, SqlTransaction transaction)
		{
			using (
				var cmd = new SqlCommand("[Data].[CandidateMetaData_SelectBy_CandidateMetaDataId]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@CandidateMetaDataId", fldCandidateMetaDataId)

					});

				using(var r = cmd.ExecuteReader()) return ReadAll(r);
			}
		}

		/// <summary>
		/// Run CandidateMetaData_SelectBy_CandidateId, and return results as a list of CandidateMetaDataRow.
		/// </summary>
		/// <param name="fldCandidateId">Value for CandidateId</param>
		/// <returns>A collection of CandidateMetaDataRow.</returns>
		public virtual bool SelectBy_CandidateId(int fldCandidateId
)
		{
			var result = false;

			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[CandidateMetaData_SelectBy_CandidateId]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@CandidateId", fldCandidateId)

					});

					using(var r = cmd.ExecuteReader()) result = ReadAll(r);
				}
			});

			return result;
		}

		/// <summary>
		/// Run CandidateMetaData_SelectBy_CandidateId, and return results as a list of CandidateMetaDataRow.
		/// </summary>
		/// <param name="fldCandidateId">Value for CandidateId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of CandidateMetaDataRow.</returns>
		public virtual bool SelectBy_CandidateId(int fldCandidateId
, SqlConnection connection, SqlTransaction transaction)
		{
			using (
				var cmd = new SqlCommand("[Data].[CandidateMetaData_SelectBy_CandidateId]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@CandidateId", fldCandidateId)

					});

				using(var r = cmd.ExecuteReader()) return ReadAll(r);
			}
		}

		/// <summary>
		/// Run CandidateMetaData_SelectBy_ContentInspectionId, and return results as a list of CandidateMetaDataRow.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <returns>A collection of CandidateMetaDataRow.</returns>
		public virtual bool SelectBy_ContentInspectionId(int fldContentInspectionId
)
		{
			var result = false;

			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[CandidateMetaData_SelectBy_ContentInspectionId]", x)
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
		/// Run CandidateMetaData_SelectBy_ContentInspectionId, and return results as a list of CandidateMetaDataRow.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of CandidateMetaDataRow.</returns>
		public virtual bool SelectBy_ContentInspectionId(int fldContentInspectionId
, SqlConnection connection, SqlTransaction transaction)
		{
			using (
				var cmd = new SqlCommand("[Data].[CandidateMetaData_SelectBy_ContentInspectionId]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ContentInspectionId", fldContentInspectionId)

					});

				using(var r = cmd.ExecuteReader()) return ReadAll(r);
			}
		}

		/// <summary>
		/// Run CandidateMetaData_SelectBy_MetaDataId, and return results as a list of CandidateMetaDataRow.
		/// </summary>
		/// <param name="fldMetaDataId">Value for MetaDataId</param>
		/// <returns>A collection of CandidateMetaDataRow.</returns>
		public virtual bool SelectBy_MetaDataId(int fldMetaDataId
)
		{
			var result = false;

			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[CandidateMetaData_SelectBy_MetaDataId]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@MetaDataId", fldMetaDataId)

					});

					using(var r = cmd.ExecuteReader()) result = ReadAll(r);
				}
			});

			return result;
		}

		/// <summary>
		/// Run CandidateMetaData_SelectBy_MetaDataId, and return results as a list of CandidateMetaDataRow.
		/// </summary>
		/// <param name="fldMetaDataId">Value for MetaDataId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of CandidateMetaDataRow.</returns>
		public virtual bool SelectBy_MetaDataId(int fldMetaDataId
, SqlConnection connection, SqlTransaction transaction)
		{
			using (
				var cmd = new SqlCommand("[Data].[CandidateMetaData_SelectBy_MetaDataId]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@MetaDataId", fldMetaDataId)

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
					new CandidateMetaDataContract
					{
					CandidateMetaDataId = reader.GetInt32(0),
					ContentInspectionId = reader.GetInt32(1),
					CandidateId = reader.GetInt32(2),
					MetaDataId = reader.GetInt32(3),
					MetaDataValue = reader.GetString(4),

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
		public virtual int Save(CandidateMetaDataContract row)
		{
			if(row == null) return 0;
			if(row.CandidateMetaDataId != null) return Update(row);
			
			return Insert(row);
		}

		/// <summary>
		/// Saves the row, either by inserting (when the identity key is null) or by updating (identity key has value).
		/// </summary>
		/// <param name="row">The data to save</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public virtual int Save(CandidateMetaDataContract row, SqlConnection connection, SqlTransaction transaction)
		{
			if(row == null) return 0;
			if(row.CandidateMetaDataId != null) return Update(row, connection, transaction);
			
			return Insert(row, connection, transaction);
		}		

		/// <summary>
		/// Save the rows in bulk, uses the same connection (faster).
		/// </summary>
		/// <param name="rows">The table rows to Save</param>
		/// <returns>The number of rows affected.</returns>
		public virtual int SaveAll(List<CandidateMetaDataContract> rows)
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
		public virtual int SaveAll(List<CandidateMetaDataContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			var rowCount = 0;
			foreach(var row in rows) rowCount += Save(row, connection, transaction);
			return rowCount;
		}
	}
}