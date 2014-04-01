using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using VotingInfo.Database.Contracts;
using VotingInfo.Database.Contracts.Data;

///////////////////////////////////////////////////////////
//Do not modify this file. Use a partial class to extend.//
///////////////////////////////////////////////////////////
// This file contains static implementations of the ElectionLevelLogic
// Add your own static methods by making a new partial class.
// You cannot override static methods, instead override the methods
// located in ElectionLevelLogicBase by making a partial class of ElectionLevelLogic
// and overriding the base methods.

namespace VotingInfo.Database.Logic.Data
{
	public partial class ElectionLevelLogic
	{
		//Put your code in a separate file.  This is auto generated.
		/// <summary>
		/// Run ElectionLevel_Insert.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldElectionLevelTitle">Value for ElectionLevelTitle</param>
		public static int? InsertNow(int fldContentInspectionId
, string fldElectionLevelTitle
)
		{
			return (new ElectionLevelLogic()).Insert(fldContentInspectionId
, fldElectionLevelTitle
);
		}
		/// <summary>
		/// Run ElectionLevel_Insert.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldElectionLevelTitle">Value for ElectionLevelTitle</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		public static int? InsertNow(int fldContentInspectionId
, string fldElectionLevelTitle
, SqlConnection connection, SqlTransaction transaction)
		{
			return (new ElectionLevelLogic()).Insert(fldContentInspectionId
, fldElectionLevelTitle
, connection, transaction);
		}

		/// <summary>
		/// Insert by providing a populated data row container
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int InsertNow(ElectionLevelContract row)
		{
			return (new ElectionLevelLogic()).Insert(row);
		}

		/// <summary>
		/// Insert by providing a populated data contract
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int InsertNow(ElectionLevelContract row, SqlConnection connection, SqlTransaction transaction)
		{
			return (new ElectionLevelLogic()).Insert(row, connection, transaction);
		}

		/// <summary>
		/// Insert the rows in bulk, uses the same connection (faster).
		/// </summary>
		/// <param name="rows">The table rows to Insert</param>
		/// <returns>The number of rows affected.</returns>
		public static int InsertAllNow(List<ElectionLevelContract> rows)
		{
			return (new ElectionLevelLogic()).InsertAll(rows);
		}

		/// <summary>
		/// Insert the rows in bulk, uses the same connection (faster), in a provided transaction scrope.
		/// </summary>
		/// <param name="rows">The table rows to Insert</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int InsertAllNow(List<ElectionLevelContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			return (new ElectionLevelLogic()).InsertAll(rows, connection, transaction);
		}
		/// <summary>
		/// Run ElectionLevel_Update.
		/// </summary>
		/// <param name="fldElectionLevelId">Value for ElectionLevelId</param>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldElectionLevelTitle">Value for ElectionLevelTitle</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateNow(int fldElectionLevelId
, int fldContentInspectionId
, string fldElectionLevelTitle
)
		{
			return (new ElectionLevelLogic()).Update(fldElectionLevelId
, fldContentInspectionId
, fldElectionLevelTitle
);
		}

		/// <summary>
		/// Run ElectionLevel_Update.
		/// </summary>
		/// <param name="fldElectionLevelId">Value for ElectionLevelId</param>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldElectionLevelTitle">Value for ElectionLevelTitle</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateNow(int fldElectionLevelId
, int fldContentInspectionId
, string fldElectionLevelTitle
, SqlConnection connection, SqlTransaction transaction)
		{
			return (new ElectionLevelLogic()).Update(fldElectionLevelId
, fldContentInspectionId
, fldElectionLevelTitle
, connection, transaction);
		}
		/// <summary>
		/// Update by providing a populated data row container
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateNow(ElectionLevelContract row)
		{
			return (new ElectionLevelLogic()).Update(row);
		}

		/// <summary>
		/// Update by providing a populated data contract
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateNow(ElectionLevelContract row, SqlConnection connection, SqlTransaction transaction)
		{
			return (new ElectionLevelLogic()).Update(row, connection, transaction);
		}

		/// <summary>
		/// Update the rows in bulk, uses the same connection (faster).
		/// </summary>
		/// <param name="rows">The table rows to Update</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateAllNow(List<ElectionLevelContract> rows)
		{
			return (new ElectionLevelLogic()).UpdateAll(rows);
		}

		/// <summary>
		/// Update the rows in bulk, uses the same connection (faster), in a provided transaction scrope.
		/// </summary>
		/// <param name="rows">The table rows to Update</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateAllNow(List<ElectionLevelContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			return (new ElectionLevelLogic()).UpdateAll(rows, connection, transaction);
		}
		/// <summary>
		/// Run ElectionLevel_Delete.
		/// </summary>
		/// <param name="fldElectionLevelId">Value for ElectionLevelId</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteNow(int fldElectionLevelId
)
		{
			return (new ElectionLevelLogic()).Delete(fldElectionLevelId
);
		}

		/// <summary>
		/// Run ElectionLevel_Delete.
		/// </summary>
		/// <param name="fldElectionLevelId">Value for ElectionLevelId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteNow(int fldElectionLevelId
, SqlConnection connection, SqlTransaction transaction)
		{
			return (new ElectionLevelLogic()).Delete(fldElectionLevelId
, connection, transaction);
		}
		/// <summary>
		/// Delete by providing a populated data row container
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteNow(ElectionLevelContract row)
		{
			return (new ElectionLevelLogic()).Delete(row);
		}

		/// <summary>
		/// Delete by providing a populated data contract
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteNow(ElectionLevelContract row, SqlConnection connection, SqlTransaction transaction)
		{
			return (new ElectionLevelLogic()).Delete(row, connection, transaction);
		}

		/// <summary>
		/// Delete the rows in bulk, uses the same connection (faster).
		/// </summary>
		/// <param name="rows">The table rows to Delete</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteAllNow(List<ElectionLevelContract> rows)
		{
			return (new ElectionLevelLogic()).DeleteAll(rows);
		}

		/// <summary>
		/// Delete the rows in bulk, uses the same connection (faster), in a provided transaction scrope.
		/// </summary>
		/// <param name="rows">The table rows to Delete</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteAllNow(List<ElectionLevelContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			return (new ElectionLevelLogic()).DeleteAll(rows, connection, transaction);
		}
		/// <summary>
		/// Determine if the table contains a row with the existing values
		/// </summary>
		/// <param name="fldElectionLevelId">Value for ElectionLevelId</param>
		/// <returns>True, if the values exist, or false.</returns>
		public static bool ExistsNow(int fldElectionLevelId
)
		{
			return (new ElectionLevelLogic()).Exists(fldElectionLevelId
);
		}

		/// <summary>
		/// Determine if the table contains a row with the existing values
		/// </summary>
		/// <param name="fldElectionLevelId">Value for ElectionLevelId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>True, if the values exist, or false.</returns>
		public static bool ExistsNow(int fldElectionLevelId
, SqlConnection connection, SqlTransaction transaction)
		{					
			return (new ElectionLevelLogic()).Exists(fldElectionLevelId
, connection, transaction);
		}

		/// <summary>
		/// Run ElectionLevel_Search, and return results as a list of ElectionLevelRow.
		/// </summary>
		/// <param name="fldElectionLevelTitle">Value for ElectionLevelTitle</param>
		/// <returns>A collection of ElectionLevelRow.</returns>
		public static List<ElectionLevelContract> SearchNow(string fldElectionLevelTitle
)
		{
			var driver = new ElectionLevelLogic();
			driver.Search(fldElectionLevelTitle
);
			return driver.Results;
		}

		/// <summary>
		/// Run ElectionLevel_Search, and return results as a list of ElectionLevelRow.
		/// </summary>
		/// <param name="fldElectionLevelTitle">Value for ElectionLevelTitle</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of ElectionLevelRow.</returns>
		public static List<ElectionLevelContract> SearchNow(string fldElectionLevelTitle
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new ElectionLevelLogic();
			driver.Search(fldElectionLevelTitle
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run ElectionLevel_SelectAll, and return results as a list of ElectionLevelRow.
		/// </summary>

		/// <returns>A collection of ElectionLevelRow.</returns>
		public static List<ElectionLevelContract> SelectAllNow()
		{			
			var driver = new ElectionLevelLogic();
			driver.SelectAll();
			return driver.Results;
		}

		/// <summary>
		/// Run ElectionLevel_SelectAll, and return results as a list of ElectionLevelRow.
		/// </summary>

		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of ElectionLevelRow.</returns>
		public static List<ElectionLevelContract> SelectAllNow(SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new ElectionLevelLogic();
			driver.SelectAll(connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run ElectionLevel_List, and return results as a list.
		/// </summary>
		/// <param name="fldElectionLevelTitle">Value for ElectionLevelTitle</param>
		/// <returns>A collection of __ListItemRow.</returns>
		public static List<ListItemContract> ListNow(string fldElectionLevelTitle
)
		{
			return (new ElectionLevelLogic()).List(fldElectionLevelTitle
);
		}

		/// <summary>
		/// Run ElectionLevel_List, and return results as a list.
		/// </summary>
		/// <param name="fldElectionLevelTitle">Value for ElectionLevelTitle</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of __ListItemRow.</returns>
		public static List<ListItemContract> ListNow(string fldElectionLevelTitle
, SqlConnection connection, SqlTransaction transaction)
		{
			return (new ElectionLevelLogic()).List(fldElectionLevelTitle
, connection, transaction);
		}

		/// <summary>
		/// Run ElectionLevel_SelectBy_ElectionLevelId, and return results as a list of ElectionLevelRow.
		/// </summary>
		/// <param name="fldElectionLevelId">Value for ElectionLevelId</param>
		/// <returns>A collection of ElectionLevelRow.</returns>
		public static List<ElectionLevelContract> SelectBy_ElectionLevelIdNow(int fldElectionLevelId
)
		{
			var driver = new ElectionLevelLogic();
			driver.SelectBy_ElectionLevelId(fldElectionLevelId
);
			return driver.Results;
		}

		/// <summary>
		/// Run ElectionLevel_SelectBy_ElectionLevelId, and return results as a list of ElectionLevelRow.
		/// </summary>
		/// <param name="fldElectionLevelId">Value for ElectionLevelId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of ElectionLevelRow.</returns>
		public static List<ElectionLevelContract> SelectBy_ElectionLevelIdNow(int fldElectionLevelId
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new ElectionLevelLogic();
			driver.SelectBy_ElectionLevelId(fldElectionLevelId
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run ElectionLevel_SelectBy_ContentInspectionId, and return results as a list of ElectionLevelRow.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <returns>A collection of ElectionLevelRow.</returns>
		public static List<ElectionLevelContract> SelectBy_ContentInspectionIdNow(int fldContentInspectionId
)
		{
			var driver = new ElectionLevelLogic();
			driver.SelectBy_ContentInspectionId(fldContentInspectionId
);
			return driver.Results;
		}

		/// <summary>
		/// Run ElectionLevel_SelectBy_ContentInspectionId, and return results as a list of ElectionLevelRow.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of ElectionLevelRow.</returns>
		public static List<ElectionLevelContract> SelectBy_ContentInspectionIdNow(int fldContentInspectionId
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new ElectionLevelLogic();
			driver.SelectBy_ContentInspectionId(fldContentInspectionId
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Read all ElectionLevel rows from the provided reader into the list structure of ElectionLevelRows
		/// </summary>
		/// <param name="reader">The result of running a sql command.</param>
		/// <returns>A populated ElectionLevelRows or an empty ElectionLevelRows if there are no results.</returns>
		public static List<ElectionLevelContract> ReadAllNow(SqlDataReader reader)
		{
			var driver = new ElectionLevelLogic();

			driver.ReadAll(reader);
			
			return driver.Results;
		}
		/// <summary>");
		/// Advance one, and read values into a ElectionLevel
		/// </summary>
		/// <param name="reader">The result of running a sql command.</param>");
		/// <returns>A ElectionLevel or null if there are no results.</returns>
		public static ElectionLevelContract ReadOneNow(SqlDataReader reader)
		{
			var driver = new ElectionLevelLogic();			
		    return driver.ReadOne(reader) ? driver.Results[0] : null;
		}
		/// <summary>
		/// Saves the row, either by inserting (when the identity key is null) or by updating (identity key has value).
		/// </summary>
		/// <param name="row">The data to save</param>
		/// <returns>The number of rows affected.</returns>
		public static int SaveNow(ElectionLevelContract row)
		{
			if(row.ElectionLevelId == null)
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
		public static int SaveNow(ElectionLevelContract row, SqlConnection connection, SqlTransaction transaction)
		{
			if(row.ElectionLevelId == null)
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
		public static int SaveAllNow(List<ElectionLevelContract> rows)
		{
			return (new ElectionLevelLogic()).SaveAll(rows);
		}

		/// <summary>
		/// Save the rows in bulk, uses the same connection (faster), in a provided transaction scrope.
		/// </summary>
		/// <param name="rows">The table rows to Save</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int SaveAllNow(List<ElectionLevelContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			return (new ElectionLevelLogic()).SaveAll(rows, connection, transaction);
		}        
	}
}