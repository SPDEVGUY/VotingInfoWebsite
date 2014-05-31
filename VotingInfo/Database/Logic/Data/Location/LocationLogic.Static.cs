using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using VotingInfo.Database.Contracts;
using VotingInfo.Database.Contracts.Data;

///////////////////////////////////////////////////////////
//Do not modify this file. Use a partial class to extend.//
///////////////////////////////////////////////////////////
// This file contains static implementations of the LocationLogic
// Add your own static methods by making a new partial class.
// You cannot override static methods, instead override the methods
// located in LocationLogicBase by making a partial class of LocationLogic
// and overriding the base methods.

namespace VotingInfo.Database.Logic.Data
{
	public partial class LocationLogic
	{
		//Put your code in a separate file.  This is auto generated.
		/// <summary>
		/// Run Location_Insert.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldLocationName">Value for LocationName</param>
		public static int? InsertNow(int fldContentInspectionId
, string fldLocationName
)
		{
			return (new LocationLogic()).Insert(fldContentInspectionId
, fldLocationName
);
		}
		/// <summary>
		/// Run Location_Insert.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldLocationName">Value for LocationName</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		public static int? InsertNow(int fldContentInspectionId
, string fldLocationName
, SqlConnection connection, SqlTransaction transaction)
		{
			return (new LocationLogic()).Insert(fldContentInspectionId
, fldLocationName
, connection, transaction);
		}

		/// <summary>
		/// Insert by providing a populated data row container
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int InsertNow(LocationContract row)
		{
			return (new LocationLogic()).Insert(row);
		}

		/// <summary>
		/// Insert by providing a populated data contract
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int InsertNow(LocationContract row, SqlConnection connection, SqlTransaction transaction)
		{
			return (new LocationLogic()).Insert(row, connection, transaction);
		}

		/// <summary>
		/// Insert the rows in bulk, uses the same connection (faster).
		/// </summary>
		/// <param name="rows">The table rows to Insert</param>
		/// <returns>The number of rows affected.</returns>
		public static int InsertAllNow(List<LocationContract> rows)
		{
			return (new LocationLogic()).InsertAll(rows);
		}

		/// <summary>
		/// Insert the rows in bulk, uses the same connection (faster), in a provided transaction scrope.
		/// </summary>
		/// <param name="rows">The table rows to Insert</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int InsertAllNow(List<LocationContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			return (new LocationLogic()).InsertAll(rows, connection, transaction);
		}
		/// <summary>
		/// Run Location_Update.
		/// </summary>
		/// <param name="fldLocationId">Value for LocationId</param>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldLocationName">Value for LocationName</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateNow(int fldLocationId
, int fldContentInspectionId
, string fldLocationName
)
		{
			return (new LocationLogic()).Update(fldLocationId
, fldContentInspectionId
, fldLocationName
);
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
		public static int UpdateNow(int fldLocationId
, int fldContentInspectionId
, string fldLocationName
, SqlConnection connection, SqlTransaction transaction)
		{
			return (new LocationLogic()).Update(fldLocationId
, fldContentInspectionId
, fldLocationName
, connection, transaction);
		}
		/// <summary>
		/// Update by providing a populated data row container
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateNow(LocationContract row)
		{
			return (new LocationLogic()).Update(row);
		}

		/// <summary>
		/// Update by providing a populated data contract
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateNow(LocationContract row, SqlConnection connection, SqlTransaction transaction)
		{
			return (new LocationLogic()).Update(row, connection, transaction);
		}

		/// <summary>
		/// Update the rows in bulk, uses the same connection (faster).
		/// </summary>
		/// <param name="rows">The table rows to Update</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateAllNow(List<LocationContract> rows)
		{
			return (new LocationLogic()).UpdateAll(rows);
		}

		/// <summary>
		/// Update the rows in bulk, uses the same connection (faster), in a provided transaction scrope.
		/// </summary>
		/// <param name="rows">The table rows to Update</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateAllNow(List<LocationContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			return (new LocationLogic()).UpdateAll(rows, connection, transaction);
		}
		/// <summary>
		/// Run Location_Delete.
		/// </summary>
		/// <param name="fldLocationId">Value for LocationId</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteNow(int fldLocationId
)
		{
			return (new LocationLogic()).Delete(fldLocationId
);
		}

		/// <summary>
		/// Run Location_Delete.
		/// </summary>
		/// <param name="fldLocationId">Value for LocationId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteNow(int fldLocationId
, SqlConnection connection, SqlTransaction transaction)
		{
			return (new LocationLogic()).Delete(fldLocationId
, connection, transaction);
		}
		/// <summary>
		/// Delete by providing a populated data row container
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteNow(LocationContract row)
		{
			return (new LocationLogic()).Delete(row);
		}

		/// <summary>
		/// Delete by providing a populated data contract
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteNow(LocationContract row, SqlConnection connection, SqlTransaction transaction)
		{
			return (new LocationLogic()).Delete(row, connection, transaction);
		}

		/// <summary>
		/// Delete the rows in bulk, uses the same connection (faster).
		/// </summary>
		/// <param name="rows">The table rows to Delete</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteAllNow(List<LocationContract> rows)
		{
			return (new LocationLogic()).DeleteAll(rows);
		}

		/// <summary>
		/// Delete the rows in bulk, uses the same connection (faster), in a provided transaction scrope.
		/// </summary>
		/// <param name="rows">The table rows to Delete</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteAllNow(List<LocationContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			return (new LocationLogic()).DeleteAll(rows, connection, transaction);
		}
		/// <summary>
		/// Determine if the table contains a row with the existing values
		/// </summary>
		/// <param name="fldLocationId">Value for LocationId</param>
		/// <returns>True, if the values exist, or false.</returns>
		public static bool ExistsNow(int fldLocationId
)
		{
			return (new LocationLogic()).Exists(fldLocationId
);
		}

		/// <summary>
		/// Determine if the table contains a row with the existing values
		/// </summary>
		/// <param name="fldLocationId">Value for LocationId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>True, if the values exist, or false.</returns>
		public static bool ExistsNow(int fldLocationId
, SqlConnection connection, SqlTransaction transaction)
		{					
			return (new LocationLogic()).Exists(fldLocationId
, connection, transaction);
		}

		/// <summary>
		/// Run Location_Search, and return results as a list of LocationRow.
		/// </summary>
		/// <param name="fldLocationName">Value for LocationName</param>
		/// <returns>A collection of LocationRow.</returns>
		public static List<LocationContract> SearchNow(string fldLocationName
)
		{
			var driver = new LocationLogic();
			driver.Search(fldLocationName
);
			return driver.Results;
		}

		/// <summary>
		/// Run Location_Search, and return results as a list of LocationRow.
		/// </summary>
		/// <param name="fldLocationName">Value for LocationName</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of LocationRow.</returns>
		public static List<LocationContract> SearchNow(string fldLocationName
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new LocationLogic();
			driver.Search(fldLocationName
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run Location_SelectAll, and return results as a list of LocationRow.
		/// </summary>

		/// <returns>A collection of LocationRow.</returns>
		public static List<LocationContract> SelectAllNow()
		{			
			var driver = new LocationLogic();
			driver.SelectAll();
			return driver.Results;
		}

		/// <summary>
		/// Run Location_SelectAll, and return results as a list of LocationRow.
		/// </summary>

		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of LocationRow.</returns>
		public static List<LocationContract> SelectAllNow(SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new LocationLogic();
			driver.SelectAll(connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run Location_List, and return results as a list.
		/// </summary>
		/// <param name="fldLocationName">Value for LocationName</param>
		/// <returns>A collection of __ListItemRow.</returns>
		public static List<ListItemContract> ListNow(string fldLocationName
)
		{
			return (new LocationLogic()).List(fldLocationName
);
		}

		/// <summary>
		/// Run Location_List, and return results as a list.
		/// </summary>
		/// <param name="fldLocationName">Value for LocationName</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of __ListItemRow.</returns>
		public static List<ListItemContract> ListNow(string fldLocationName
, SqlConnection connection, SqlTransaction transaction)
		{
			return (new LocationLogic()).List(fldLocationName
, connection, transaction);
		}

		/// <summary>
		/// Run Location_SelectBy_LocationId, and return results as a list of LocationRow.
		/// </summary>
		/// <param name="fldLocationId">Value for LocationId</param>
		/// <returns>A collection of LocationRow.</returns>
		public static List<LocationContract> SelectBy_LocationIdNow(int fldLocationId
)
		{
			var driver = new LocationLogic();
			driver.SelectBy_LocationId(fldLocationId
);
			return driver.Results;
		}

		/// <summary>
		/// Run Location_SelectBy_LocationId, and return results as a list of LocationRow.
		/// </summary>
		/// <param name="fldLocationId">Value for LocationId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of LocationRow.</returns>
		public static List<LocationContract> SelectBy_LocationIdNow(int fldLocationId
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new LocationLogic();
			driver.SelectBy_LocationId(fldLocationId
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run Location_SelectBy_ContentInspectionId, and return results as a list of LocationRow.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <returns>A collection of LocationRow.</returns>
		public static List<LocationContract> SelectBy_ContentInspectionIdNow(int fldContentInspectionId
)
		{
			var driver = new LocationLogic();
			driver.SelectBy_ContentInspectionId(fldContentInspectionId
);
			return driver.Results;
		}

		/// <summary>
		/// Run Location_SelectBy_ContentInspectionId, and return results as a list of LocationRow.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of LocationRow.</returns>
		public static List<LocationContract> SelectBy_ContentInspectionIdNow(int fldContentInspectionId
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new LocationLogic();
			driver.SelectBy_ContentInspectionId(fldContentInspectionId
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Read all Location rows from the provided reader into the list structure of LocationRows
		/// </summary>
		/// <param name="reader">The result of running a sql command.</param>
		/// <returns>A populated LocationRows or an empty LocationRows if there are no results.</returns>
		public static List<LocationContract> ReadAllNow(SqlDataReader reader)
		{
			var driver = new LocationLogic();

			driver.ReadAll(reader);
			
			return driver.Results;
		}
		/// <summary>");
		/// Advance one, and read values into a Location
		/// </summary>
		/// <param name="reader">The result of running a sql command.</param>");
		/// <returns>A Location or null if there are no results.</returns>
		public static LocationContract ReadOneNow(SqlDataReader reader)
		{
			var driver = new LocationLogic();			
		    return driver.ReadOne(reader) ? driver.Results[0] : null;
		}
		/// <summary>
		/// Saves the row, either by inserting (when the identity key is null) or by updating (identity key has value).
		/// </summary>
		/// <param name="row">The data to save</param>
		/// <returns>The number of rows affected.</returns>
		public static int SaveNow(LocationContract row)
		{
			if(row.LocationId == null)
			{
				return InsertNow(row);
			}
			else
			{
				return UpdateNow(row);
			}
		}
		
		/// <summary>
		/// Saves the row, either by inserting (when the identity key is null) or by updating (identity key has value).
		/// </summary>
		/// <param name="row">The data to save</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int SaveNow(LocationContract row, SqlConnection connection, SqlTransaction transaction)
		{
			if(row.LocationId == null)
			{
				return InsertNow(row, connection, transaction);
			}
			else
			{
				return UpdateNow(row, connection, transaction);
			}
		}
		
		/// <summary>
		/// Save the rows in bulk, uses the same connection (faster).
		/// </summary>
		/// <param name="rows">The table rows to Save</param>
		/// <returns>The number of rows affected.</returns>
		public static int SaveAllNow(List<LocationContract> rows)
		{
			return (new LocationLogic()).SaveAll(rows);
		}

		/// <summary>
		/// Save the rows in bulk, uses the same connection (faster), in a provided transaction scrope.
		/// </summary>
		/// <param name="rows">The table rows to Save</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int SaveAllNow(List<LocationContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			return (new LocationLogic()).SaveAll(rows, connection, transaction);
		}        
	}
}