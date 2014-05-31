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
	public abstract partial class LocationLogicBase : LogicBase<LocationLogicBase>
	{
		//Put your code in a separate file.  This is auto generated.
    
		[XmlArray] public List<LocationContract> Results;

		public LocationLogicBase()
		{
			Results =  new List<LocationContract>();
		}

		/// <summary>
		/// Run Location_Insert.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldLocationName">Value for LocationName</param>
		/// <returns>The new ID</returns>
		public virtual int? Insert(int fldContentInspectionId
, string fldLocationName
)
		{
			int? result = null;
			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[Location_Insert]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ContentInspectionId", fldContentInspectionId)
,
						new SqlParameter("@LocationName", fldLocationName)

					});

					result = (int?)cmd.ExecuteScalar();
				}
			});
			return result;
		}

		/// <summary>
		/// Run Location_Insert.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldLocationName">Value for LocationName</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The new ID</returns>
		public virtual int? Insert(int fldContentInspectionId
, string fldLocationName
, SqlConnection connection, SqlTransaction transaction)
		{
			using (
				var cmd = new SqlCommand("[Data].[Location_Insert]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ContentInspectionId", fldContentInspectionId)
,
						new SqlParameter("@LocationName", fldLocationName)

					});

				return (int?)cmd.ExecuteScalar();
			}
		}

		/// <summary>
		/// Insert by providing a populated data row container
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <returns>1, if insert was successful</returns>
		public int Insert(LocationContract row)
		{
			int? result = null;
			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[Location_Insert]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ContentInspectionId", row.ContentInspectionId)
,
						new SqlParameter("@LocationName", row.LocationName)

					});
            
					result = (int?)cmd.ExecuteScalar();
					row.LocationId = result;
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
		public int Insert(LocationContract row, SqlConnection connection, SqlTransaction transaction)
		{
			int? result = null;
			using (
				var cmd = new SqlCommand("[Data].[Location_Insert]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ContentInspectionId", row.ContentInspectionId)
,
						new SqlParameter("@LocationName", row.LocationName)

					});
            
				result = (int?)cmd.ExecuteScalar();
				row.LocationId = result;
			}
			return result != null ? 1 : 0;
		}
		/// <summary>
		/// Insert the rows in bulk, uses the same connection (faster).
		/// </summary>
		/// <param name="rows">The table rows to Insert</param>
		/// <returns>The number of rows affected.</returns>
		public virtual int InsertAll(List<LocationContract> rows)
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
		public virtual int InsertAll(List<LocationContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			var rowCount = 0;
			foreach(var row in rows) rowCount += Insert(row, connection, transaction);
			return rowCount;
		}

		/// <summary>
		/// Run Location_Update.
		/// </summary>
		/// <returns>The number of rows affected.</returns>
		/// <param name="fldLocationId">Value for LocationId</param>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldLocationName">Value for LocationName</param>
		public virtual int Update(int fldLocationId
, int fldContentInspectionId
, string fldLocationName
)
		{
			var rowCount = 0;
			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[Location_Update]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@LocationId", fldLocationId)
,
						new SqlParameter("@ContentInspectionId", fldContentInspectionId)
,
						new SqlParameter("@LocationName", fldLocationName)

					});

					rowCount = cmd.ExecuteNonQuery();
				}
			});
			
			
			return rowCount;
		}

		/// <summary>
		/// Run Location_Update.
		/// </summary>
		/// <param name="fldLocationId">Value for LocationId</param>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldLocationName">Value for LocationName</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public virtual int Update(int fldLocationId
, int fldContentInspectionId
, string fldLocationName
, SqlConnection connection, SqlTransaction transaction)
		{
			var rowCount = 0;
			using (
				var cmd = new SqlCommand("[Data].[Location_Update]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@LocationId", fldLocationId)
,
						new SqlParameter("@ContentInspectionId", fldContentInspectionId)
,
						new SqlParameter("@LocationName", fldLocationName)

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
		public virtual int Update(LocationContract row)
		{
			var rowCount = 0;
			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[Location_Update]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@LocationId", row.LocationId)
,
						new SqlParameter("@ContentInspectionId", row.ContentInspectionId)
,
						new SqlParameter("@LocationName", row.LocationName)

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
		public virtual int Update(LocationContract row, SqlConnection connection, SqlTransaction transaction)
		{
			var rowCount = 0;
			using (
				var cmd = new SqlCommand("[Data].[Location_Update]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@LocationId", row.LocationId)
,
						new SqlParameter("@ContentInspectionId", row.ContentInspectionId)
,
						new SqlParameter("@LocationName", row.LocationName)

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
		public virtual int UpdateAll(List<LocationContract> rows)
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
		public virtual int UpdateAll(List<LocationContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			var rowCount = 0;
			foreach(var row in rows) rowCount += Update(row, connection, transaction);
			return rowCount;
		}

		/// <summary>
		/// Run Location_Delete.
		/// </summary>
		/// <returns>The number of rows affected.</returns>
		/// <param name="fldLocationId">Value for LocationId</param>
		public virtual int Delete(int fldLocationId
)
		{
			var rowCount = 0;
			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[Location_Delete]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@LocationId", fldLocationId)

					});

					rowCount = cmd.ExecuteNonQuery();
				}
			});
			
			
			return rowCount;
		}

		/// <summary>
		/// Run Location_Delete.
		/// </summary>
		/// <param name="fldLocationId">Value for LocationId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public virtual int Delete(int fldLocationId
, SqlConnection connection, SqlTransaction transaction)
		{
			var rowCount = 0;
			using (
				var cmd = new SqlCommand("[Data].[Location_Delete]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@LocationId", fldLocationId)

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
		public virtual int Delete(LocationContract row)
		{
			var rowCount = 0;
			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[Location_Delete]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@LocationId", row.LocationId)

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
		public virtual int Delete(LocationContract row, SqlConnection connection, SqlTransaction transaction)
		{
			var rowCount = 0;
			using (
				var cmd = new SqlCommand("[Data].[Location_Delete]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@LocationId", row.LocationId)

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
		public virtual int DeleteAll(List<LocationContract> rows)
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
		public virtual int DeleteAll(List<LocationContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			var rowCount = 0;
			foreach(var row in rows) rowCount += Delete(row, connection, transaction);
			return rowCount;
		}

		/// <summary>
		/// Determine if the table contains a row with the existing values
		/// </summary>
		/// <param name="fldLocationId">Value for LocationId</param>
		/// <returns>True, if the values exist, or false.</returns>
		public virtual bool Exists(int fldLocationId
)
		{
			bool result = false;

			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[Location_Exists]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@LocationId", fldLocationId)

					});

					result = (bool)cmd.ExecuteScalar();
				}
			});

			return result;
		}

		/// <summary>
		/// Determine if the table contains a row with the existing values
		/// </summary>
		/// <param name="fldLocationId">Value for LocationId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>True, if the values exist, or false.</returns>
		public virtual bool Exists(int fldLocationId
, SqlConnection connection, SqlTransaction transaction)
		{					
			using (
				var cmd = new SqlCommand("[Data].[Location_Exists]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@LocationId", fldLocationId)

					});

					return (bool)cmd.ExecuteScalar();
			}
		}

		/// <summary>
		/// Run Location_Search, and return results as a list of LocationRow.
		/// </summary>
		/// <param name="fldLocationName">Value for LocationName</param>
		/// <returns>A collection of LocationRow.</returns>
		public virtual bool Search(string fldLocationName
)
		{
			var result = false;

			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[Location_Search]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@LocationName", fldLocationName)

					});

					using(var r = cmd.ExecuteReader()) result = ReadAll(r);
				}
			});

			return result;
		}

		/// <summary>
		/// Run Location_Search, and return results as a list of LocationRow.
		/// </summary>
		/// <param name="fldLocationName">Value for LocationName</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of LocationRow.</returns>
		public virtual bool Search(string fldLocationName
, SqlConnection connection, SqlTransaction transaction)
		{
			using (
				var cmd = new SqlCommand("[Data].[Location_Search]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@LocationName", fldLocationName)

					});

				using(var r = cmd.ExecuteReader()) return ReadAll(r);
			}
		}

		/// <summary>
		/// Run Location_SelectAll, and return results as a list of LocationRow.
		/// </summary>

		/// <returns>A collection of LocationRow.</returns>
		public virtual bool SelectAll()
		{
			var result = false;

			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[Location_SelectAll]", x)
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
		/// Run Location_SelectAll, and return results as a list of LocationRow.
		/// </summary>

		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of LocationRow.</returns>
		public virtual bool SelectAll(SqlConnection connection, SqlTransaction transaction)
		{
			using (
				var cmd = new SqlCommand("[Data].[Location_SelectAll]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
				using(var r = cmd.ExecuteReader()) return ReadAll(r);
			}
		}

		/// <summary>
		/// Run Location_List, and return results as a list.
		/// </summary>
		/// <param name="fldLocationName">Value for LocationName</param>
		/// <returns>A collection of __ListItemRow.</returns>
		public virtual List<ListItemContract> List(string fldLocationName
)
		{
			List<ListItemContract> result = null;

			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[Location_List]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@LocationName", fldLocationName)

					});

					using(var r = cmd.ExecuteReader()) result = ListItemLogic.ReadAllNow(r);
				}
			});

			return result;
		}

		/// <summary>
		/// Run Location_List, and return results as a list.
		/// </summary>
		/// <param name="fldLocationName">Value for LocationName</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of __ListItemRow.</returns>
		public virtual List<ListItemContract> List(string fldLocationName
, SqlConnection connection, SqlTransaction transaction)
		{
			using (
				var cmd = new SqlCommand("[Data].[Location_List]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@LocationName", fldLocationName)

					});

				using(var r = cmd.ExecuteReader()) return ListItemLogic.ReadAllNow(r);				
			}
		}

		/// <summary>
		/// Run Location_SelectBy_LocationId, and return results as a list of LocationRow.
		/// </summary>
		/// <param name="fldLocationId">Value for LocationId</param>
		/// <returns>A collection of LocationRow.</returns>
		public virtual bool SelectBy_LocationId(int fldLocationId
)
		{
			var result = false;

			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[Location_SelectBy_LocationId]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@LocationId", fldLocationId)

					});

					using(var r = cmd.ExecuteReader()) result = ReadAll(r);
				}
			});

			return result;
		}

		/// <summary>
		/// Run Location_SelectBy_LocationId, and return results as a list of LocationRow.
		/// </summary>
		/// <param name="fldLocationId">Value for LocationId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of LocationRow.</returns>
		public virtual bool SelectBy_LocationId(int fldLocationId
, SqlConnection connection, SqlTransaction transaction)
		{
			using (
				var cmd = new SqlCommand("[Data].[Location_SelectBy_LocationId]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@LocationId", fldLocationId)

					});

				using(var r = cmd.ExecuteReader()) return ReadAll(r);
			}
		}

		/// <summary>
		/// Run Location_SelectBy_ContentInspectionId, and return results as a list of LocationRow.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <returns>A collection of LocationRow.</returns>
		public virtual bool SelectBy_ContentInspectionId(int fldContentInspectionId
)
		{
			var result = false;

			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Data].[Location_SelectBy_ContentInspectionId]", x)
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
		/// Run Location_SelectBy_ContentInspectionId, and return results as a list of LocationRow.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of LocationRow.</returns>
		public virtual bool SelectBy_ContentInspectionId(int fldContentInspectionId
, SqlConnection connection, SqlTransaction transaction)
		{
			using (
				var cmd = new SqlCommand("[Data].[Location_SelectBy_ContentInspectionId]", connection)
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
					new LocationContract
					{
					LocationId = reader.GetInt32(0),
					ContentInspectionId = reader.GetInt32(1),
					LocationName = reader.GetString(2),

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
		public virtual int Save(LocationContract row)
		{
			if(row == null) return 0;
			if(row.LocationId != null) return Update(row);
			
			return Insert(row);
		}

		/// <summary>
		/// Saves the row, either by inserting (when the identity key is null) or by updating (identity key has value).
		/// </summary>
		/// <param name="row">The data to save</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public virtual int Save(LocationContract row, SqlConnection connection, SqlTransaction transaction)
		{
			if(row == null) return 0;
			if(row.LocationId != null) return Update(row, connection, transaction);
			
			return Insert(row, connection, transaction);
		}		

		/// <summary>
		/// Save the rows in bulk, uses the same connection (faster).
		/// </summary>
		/// <param name="rows">The table rows to Save</param>
		/// <returns>The number of rows affected.</returns>
		public virtual int SaveAll(List<LocationContract> rows)
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
		public virtual int SaveAll(List<LocationContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			var rowCount = 0;
			foreach(var row in rows) rowCount += Save(row, connection, transaction);
			return rowCount;
		}
	}
}