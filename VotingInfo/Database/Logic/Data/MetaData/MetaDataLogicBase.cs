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
	public abstract partial class MetaDataLogicBase : LogicBase<MetaDataLogicBase>
	{
		//Put your code in a separate file.  This is auto generated.
    
		[XmlArray] public List<MetaDataContract> Results;

		public MetaDataLogicBase()
		{
			Results =  new List<MetaDataContract>();
		}

		/// <summary>
		/// Run MetaData_Insert.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldMetaDataName">Value for MetaDataName</param>
		/// <param name="fldIsRequired">Value for IsRequired</param>
		/// <param name="fldAppliesAtAllLevels">Value for AppliesAtAllLevels</param>
		/// <param name="fldAppliesToCandidates">Value for AppliesToCandidates</param>
		/// <param name="fldAppliesToOrganizations">Value for AppliesToOrganizations</param>
		/// <returns>The new ID</returns>
		public virtual int? Insert(int fldContentInspectionId
, string fldMetaDataName
, bool fldIsRequired
, bool fldAppliesAtAllLevels
, bool fldAppliesToCandidates
, bool fldAppliesToOrganizations
)
		{
			int? result = null;
			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[MetaData_Insert]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ContentInspectionId", fldContentInspectionId)
,
						new SqlParameter("@MetaDataName", fldMetaDataName)
,
						new SqlParameter("@IsRequired", fldIsRequired)
,
						new SqlParameter("@AppliesAtAllLevels", fldAppliesAtAllLevels)
,
						new SqlParameter("@AppliesToCandidates", fldAppliesToCandidates)
,
						new SqlParameter("@AppliesToOrganizations", fldAppliesToOrganizations)

					});

					result = (int?)cmd.ExecuteScalar();
				}
			});
			return result;
		}

		/// <summary>
		/// Run MetaData_Insert.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldMetaDataName">Value for MetaDataName</param>
		/// <param name="fldIsRequired">Value for IsRequired</param>
		/// <param name="fldAppliesAtAllLevels">Value for AppliesAtAllLevels</param>
		/// <param name="fldAppliesToCandidates">Value for AppliesToCandidates</param>
		/// <param name="fldAppliesToOrganizations">Value for AppliesToOrganizations</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The new ID</returns>
		public virtual int? Insert(int fldContentInspectionId
, string fldMetaDataName
, bool fldIsRequired
, bool fldAppliesAtAllLevels
, bool fldAppliesToCandidates
, bool fldAppliesToOrganizations
, SqlConnection connection, SqlTransaction transaction)
		{
			using (
				var cmd = new SqlCommand("[Data].[MetaData_Insert]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ContentInspectionId", fldContentInspectionId)
,
						new SqlParameter("@MetaDataName", fldMetaDataName)
,
						new SqlParameter("@IsRequired", fldIsRequired)
,
						new SqlParameter("@AppliesAtAllLevels", fldAppliesAtAllLevels)
,
						new SqlParameter("@AppliesToCandidates", fldAppliesToCandidates)
,
						new SqlParameter("@AppliesToOrganizations", fldAppliesToOrganizations)

					});

				return (int?)cmd.ExecuteScalar();
			}
		}

		/// <summary>
		/// Insert by providing a populated data row container
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <returns>1, if insert was successful</returns>
		public int Insert(MetaDataContract row)
		{
			int? result = null;
			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[MetaData_Insert]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ContentInspectionId", row.ContentInspectionId)
,
						new SqlParameter("@MetaDataName", row.MetaDataName)
,
						new SqlParameter("@IsRequired", row.IsRequired)
,
						new SqlParameter("@AppliesAtAllLevels", row.AppliesAtAllLevels)
,
						new SqlParameter("@AppliesToCandidates", row.AppliesToCandidates)
,
						new SqlParameter("@AppliesToOrganizations", row.AppliesToOrganizations)

					});
            
					result = (int?)cmd.ExecuteScalar();
					row.MetaDataId = result;
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
		public int Insert(MetaDataContract row, SqlConnection connection, SqlTransaction transaction)
		{
			int? result = null;
			using (
				var cmd = new SqlCommand("[Data].[MetaData_Insert]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ContentInspectionId", row.ContentInspectionId)
,
						new SqlParameter("@MetaDataName", row.MetaDataName)
,
						new SqlParameter("@IsRequired", row.IsRequired)
,
						new SqlParameter("@AppliesAtAllLevels", row.AppliesAtAllLevels)
,
						new SqlParameter("@AppliesToCandidates", row.AppliesToCandidates)
,
						new SqlParameter("@AppliesToOrganizations", row.AppliesToOrganizations)

					});
            
				result = (int?)cmd.ExecuteScalar();
				row.MetaDataId = result;
			}
			return result != null ? 1 : 0;
		}
		/// <summary>
		/// Insert the rows in bulk, uses the same connection (faster).
		/// </summary>
		/// <param name="rows">The table rows to Insert</param>
		/// <returns>The number of rows affected.</returns>
		public virtual int InsertAll(List<MetaDataContract> rows)
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
		public virtual int InsertAll(List<MetaDataContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			var rowCount = 0;
			foreach(var row in rows) rowCount += Insert(row, connection, transaction);
			return rowCount;
		}

		/// <summary>
		/// Run MetaData_Update.
		/// </summary>
		/// <returns>The number of rows affected.</returns>
		/// <param name="fldMetaDataId">Value for MetaDataId</param>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldMetaDataName">Value for MetaDataName</param>
		/// <param name="fldIsRequired">Value for IsRequired</param>
		/// <param name="fldAppliesAtAllLevels">Value for AppliesAtAllLevels</param>
		/// <param name="fldAppliesToCandidates">Value for AppliesToCandidates</param>
		/// <param name="fldAppliesToOrganizations">Value for AppliesToOrganizations</param>
		public virtual int Update(int fldMetaDataId
, int fldContentInspectionId
, string fldMetaDataName
, bool fldIsRequired
, bool fldAppliesAtAllLevels
, bool fldAppliesToCandidates
, bool fldAppliesToOrganizations
)
		{
			var rowCount = 0;
			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[MetaData_Update]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@MetaDataId", fldMetaDataId)
,
						new SqlParameter("@ContentInspectionId", fldContentInspectionId)
,
						new SqlParameter("@MetaDataName", fldMetaDataName)
,
						new SqlParameter("@IsRequired", fldIsRequired)
,
						new SqlParameter("@AppliesAtAllLevels", fldAppliesAtAllLevels)
,
						new SqlParameter("@AppliesToCandidates", fldAppliesToCandidates)
,
						new SqlParameter("@AppliesToOrganizations", fldAppliesToOrganizations)

					});

					rowCount = cmd.ExecuteNonQuery();
				}
			});
			
			
			return rowCount;
		}

		/// <summary>
		/// Run MetaData_Update.
		/// </summary>
		/// <param name="fldMetaDataId">Value for MetaDataId</param>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldMetaDataName">Value for MetaDataName</param>
		/// <param name="fldIsRequired">Value for IsRequired</param>
		/// <param name="fldAppliesAtAllLevels">Value for AppliesAtAllLevels</param>
		/// <param name="fldAppliesToCandidates">Value for AppliesToCandidates</param>
		/// <param name="fldAppliesToOrganizations">Value for AppliesToOrganizations</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public virtual int Update(int fldMetaDataId
, int fldContentInspectionId
, string fldMetaDataName
, bool fldIsRequired
, bool fldAppliesAtAllLevels
, bool fldAppliesToCandidates
, bool fldAppliesToOrganizations
, SqlConnection connection, SqlTransaction transaction)
		{
			var rowCount = 0;
			using (
				var cmd = new SqlCommand("[Data].[MetaData_Update]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@MetaDataId", fldMetaDataId)
,
						new SqlParameter("@ContentInspectionId", fldContentInspectionId)
,
						new SqlParameter("@MetaDataName", fldMetaDataName)
,
						new SqlParameter("@IsRequired", fldIsRequired)
,
						new SqlParameter("@AppliesAtAllLevels", fldAppliesAtAllLevels)
,
						new SqlParameter("@AppliesToCandidates", fldAppliesToCandidates)
,
						new SqlParameter("@AppliesToOrganizations", fldAppliesToOrganizations)

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
		public virtual int Update(MetaDataContract row)
		{
			var rowCount = 0;
			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[MetaData_Update]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@MetaDataId", row.MetaDataId)
,
						new SqlParameter("@ContentInspectionId", row.ContentInspectionId)
,
						new SqlParameter("@MetaDataName", row.MetaDataName)
,
						new SqlParameter("@IsRequired", row.IsRequired)
,
						new SqlParameter("@AppliesAtAllLevels", row.AppliesAtAllLevels)
,
						new SqlParameter("@AppliesToCandidates", row.AppliesToCandidates)
,
						new SqlParameter("@AppliesToOrganizations", row.AppliesToOrganizations)

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
		public virtual int Update(MetaDataContract row, SqlConnection connection, SqlTransaction transaction)
		{
			var rowCount = 0;
			using (
				var cmd = new SqlCommand("[Data].[MetaData_Update]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@MetaDataId", row.MetaDataId)
,
						new SqlParameter("@ContentInspectionId", row.ContentInspectionId)
,
						new SqlParameter("@MetaDataName", row.MetaDataName)
,
						new SqlParameter("@IsRequired", row.IsRequired)
,
						new SqlParameter("@AppliesAtAllLevels", row.AppliesAtAllLevels)
,
						new SqlParameter("@AppliesToCandidates", row.AppliesToCandidates)
,
						new SqlParameter("@AppliesToOrganizations", row.AppliesToOrganizations)

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
		public virtual int UpdateAll(List<MetaDataContract> rows)
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
		public virtual int UpdateAll(List<MetaDataContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			var rowCount = 0;
			foreach(var row in rows) rowCount += Update(row, connection, transaction);
			return rowCount;
		}

		/// <summary>
		/// Run MetaData_Delete.
		/// </summary>
		/// <returns>The number of rows affected.</returns>
		/// <param name="fldMetaDataId">Value for MetaDataId</param>
		public virtual int Delete(int fldMetaDataId
)
		{
			var rowCount = 0;
			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[MetaData_Delete]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@MetaDataId", fldMetaDataId)

					});

					rowCount = cmd.ExecuteNonQuery();
				}
			});
			
			
			return rowCount;
		}

		/// <summary>
		/// Run MetaData_Delete.
		/// </summary>
		/// <param name="fldMetaDataId">Value for MetaDataId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public virtual int Delete(int fldMetaDataId
, SqlConnection connection, SqlTransaction transaction)
		{
			var rowCount = 0;
			using (
				var cmd = new SqlCommand("[Data].[MetaData_Delete]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@MetaDataId", fldMetaDataId)

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
		public virtual int Delete(MetaDataContract row)
		{
			var rowCount = 0;
			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[MetaData_Delete]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@MetaDataId", row.MetaDataId)

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
		public virtual int Delete(MetaDataContract row, SqlConnection connection, SqlTransaction transaction)
		{
			var rowCount = 0;
			using (
				var cmd = new SqlCommand("[Data].[MetaData_Delete]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@MetaDataId", row.MetaDataId)

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
		public virtual int DeleteAll(List<MetaDataContract> rows)
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
		public virtual int DeleteAll(List<MetaDataContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			var rowCount = 0;
			foreach(var row in rows) rowCount += Delete(row, connection, transaction);
			return rowCount;
		}

		/// <summary>
		/// Determine if the table contains a row with the existing values
		/// </summary>
		/// <param name="fldMetaDataId">Value for MetaDataId</param>
		/// <returns>True, if the values exist, or false.</returns>
		public virtual bool Exists(int fldMetaDataId
)
		{
			bool result = false;

			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[MetaData_Exists]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@MetaDataId", fldMetaDataId)

					});

					result = (bool)cmd.ExecuteScalar();
				}
			});

			return result;
		}

		/// <summary>
		/// Determine if the table contains a row with the existing values
		/// </summary>
		/// <param name="fldMetaDataId">Value for MetaDataId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>True, if the values exist, or false.</returns>
		public virtual bool Exists(int fldMetaDataId
, SqlConnection connection, SqlTransaction transaction)
		{					
			using (
				var cmd = new SqlCommand("[Data].[MetaData_Exists]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@MetaDataId", fldMetaDataId)

					});

					return (bool)cmd.ExecuteScalar();
			}
		}

		/// <summary>
		/// Run MetaData_Search, and return results as a list of MetaDataRow.
		/// </summary>
		/// <param name="fldMetaDataName">Value for MetaDataName</param>
		/// <returns>A collection of MetaDataRow.</returns>
		public virtual bool Search(string fldMetaDataName
)
		{
			var result = false;

			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[MetaData_Search]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@MetaDataName", fldMetaDataName)

					});

					using(var r = cmd.ExecuteReader()) result = ReadAll(r);
				}
			});

			return result;
		}

		/// <summary>
		/// Run MetaData_Search, and return results as a list of MetaDataRow.
		/// </summary>
		/// <param name="fldMetaDataName">Value for MetaDataName</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of MetaDataRow.</returns>
		public virtual bool Search(string fldMetaDataName
, SqlConnection connection, SqlTransaction transaction)
		{
			using (
				var cmd = new SqlCommand("[Data].[MetaData_Search]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@MetaDataName", fldMetaDataName)

					});

				using(var r = cmd.ExecuteReader()) return ReadAll(r);
			}
		}

		/// <summary>
		/// Run MetaData_SelectAll, and return results as a list of MetaDataRow.
		/// </summary>

		/// <returns>A collection of MetaDataRow.</returns>
		public virtual bool SelectAll()
		{
			var result = false;

			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[MetaData_SelectAll]", x)
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
		/// Run MetaData_SelectAll, and return results as a list of MetaDataRow.
		/// </summary>

		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of MetaDataRow.</returns>
		public virtual bool SelectAll(SqlConnection connection, SqlTransaction transaction)
		{
			using (
				var cmd = new SqlCommand("[Data].[MetaData_SelectAll]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
				using(var r = cmd.ExecuteReader()) return ReadAll(r);
			}
		}

		/// <summary>
		/// Run MetaData_List, and return results as a list.
		/// </summary>
		/// <param name="fldMetaDataName">Value for MetaDataName</param>
		/// <returns>A collection of __ListItemRow.</returns>
		public virtual List<ListItemContract> List(string fldMetaDataName
)
		{
			List<ListItemContract> result = null;

			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[MetaData_List]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@MetaDataName", fldMetaDataName)

					});

					using(var r = cmd.ExecuteReader()) result = ListItemLogic.ReadAllNow(r);
				}
			});

			return result;
		}

		/// <summary>
		/// Run MetaData_List, and return results as a list.
		/// </summary>
		/// <param name="fldMetaDataName">Value for MetaDataName</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of __ListItemRow.</returns>
		public virtual List<ListItemContract> List(string fldMetaDataName
, SqlConnection connection, SqlTransaction transaction)
		{
			using (
				var cmd = new SqlCommand("[Data].[MetaData_List]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@MetaDataName", fldMetaDataName)

					});

				using(var r = cmd.ExecuteReader()) return ListItemLogic.ReadAllNow(r);				
			}
		}

		/// <summary>
		/// Run MetaData_SelectBy_MetaDataId, and return results as a list of MetaDataRow.
		/// </summary>
		/// <param name="fldMetaDataId">Value for MetaDataId</param>
		/// <returns>A collection of MetaDataRow.</returns>
		public virtual bool SelectBy_MetaDataId(int fldMetaDataId
)
		{
			var result = false;

			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[MetaData_SelectBy_MetaDataId]", x)
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
		/// Run MetaData_SelectBy_MetaDataId, and return results as a list of MetaDataRow.
		/// </summary>
		/// <param name="fldMetaDataId">Value for MetaDataId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of MetaDataRow.</returns>
		public virtual bool SelectBy_MetaDataId(int fldMetaDataId
, SqlConnection connection, SqlTransaction transaction)
		{
			using (
				var cmd = new SqlCommand("[Data].[MetaData_SelectBy_MetaDataId]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@MetaDataId", fldMetaDataId)

					});

				using(var r = cmd.ExecuteReader()) return ReadAll(r);
			}
		}

		/// <summary>
		/// Run MetaData_SelectBy_ContentInspectionId, and return results as a list of MetaDataRow.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <returns>A collection of MetaDataRow.</returns>
		public virtual bool SelectBy_ContentInspectionId(int fldContentInspectionId
)
		{
			var result = false;

			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[MetaData_SelectBy_ContentInspectionId]", x)
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
		/// Run MetaData_SelectBy_ContentInspectionId, and return results as a list of MetaDataRow.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of MetaDataRow.</returns>
		public virtual bool SelectBy_ContentInspectionId(int fldContentInspectionId
, SqlConnection connection, SqlTransaction transaction)
		{
			using (
				var cmd = new SqlCommand("[Data].[MetaData_SelectBy_ContentInspectionId]", connection)
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
					new MetaDataContract
					{
					MetaDataId = reader.GetInt32(0),
					ContentInspectionId = reader.GetInt32(1),
					MetaDataName = reader.GetString(2),
					IsRequired = reader.GetBoolean(3),
					AppliesAtAllLevels = reader.GetBoolean(4),
					AppliesToCandidates = reader.GetBoolean(5),
					AppliesToOrganizations = reader.GetBoolean(6),

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
		public virtual int Save(MetaDataContract row)
		{
			if(row == null) return 0;
			if(row.MetaDataId != null) return Update(row);
			
			return Insert(row);
		}

		/// <summary>
		/// Saves the row, either by inserting (when the identity key is null) or by updating (identity key has value).
		/// </summary>
		/// <param name="row">The data to save</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public virtual int Save(MetaDataContract row, SqlConnection connection, SqlTransaction transaction)
		{
			if(row == null) return 0;
			if(row.MetaDataId != null) return Update(row, connection, transaction);
			
			return Insert(row, connection, transaction);
		}		

		/// <summary>
		/// Save the rows in bulk, uses the same connection (faster).
		/// </summary>
		/// <param name="rows">The table rows to Save</param>
		/// <returns>The number of rows affected.</returns>
		public virtual int SaveAll(List<MetaDataContract> rows)
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
		public virtual int SaveAll(List<MetaDataContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			var rowCount = 0;
			foreach(var row in rows) rowCount += Save(row, connection, transaction);
			return rowCount;
		}
	}
}