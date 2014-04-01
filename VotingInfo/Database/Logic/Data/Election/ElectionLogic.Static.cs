using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using VotingInfo.Database.Contracts;
using VotingInfo.Database.Contracts.Data;

///////////////////////////////////////////////////////////
//Do not modify this file. Use a partial class to extend.//
///////////////////////////////////////////////////////////
// This file contains static implementations of the ElectionLogic
// Add your own static methods by making a new partial class.
// You cannot override static methods, instead override the methods
// located in ElectionLogicBase by making a partial class of ElectionLogic
// and overriding the base methods.

namespace VotingInfo.Database.Logic.Data
{
	public partial class ElectionLogic
	{
		//Put your code in a separate file.  This is auto generated.
		/// <summary>
		/// Run Election_Insert.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldElectionLevelId">Value for ElectionLevelId</param>
		/// <param name="fldElectionRegion">Value for ElectionRegion</param>
		/// <param name="fldVotingDate">Value for VotingDate</param>
		public static int? InsertNow(int fldContentInspectionId
, int fldElectionLevelId
, string fldElectionRegion
, DateTime fldVotingDate
)
		{
			return (new ElectionLogic()).Insert(fldContentInspectionId
, fldElectionLevelId
, fldElectionRegion
, fldVotingDate
);
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
		public static int? InsertNow(int fldContentInspectionId
, int fldElectionLevelId
, string fldElectionRegion
, DateTime fldVotingDate
, SqlConnection connection, SqlTransaction transaction)
		{
			return (new ElectionLogic()).Insert(fldContentInspectionId
, fldElectionLevelId
, fldElectionRegion
, fldVotingDate
, connection, transaction);
		}

		/// <summary>
		/// Insert by providing a populated data row container
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int InsertNow(ElectionContract row)
		{
			return (new ElectionLogic()).Insert(row);
		}

		/// <summary>
		/// Insert by providing a populated data contract
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int InsertNow(ElectionContract row, SqlConnection connection, SqlTransaction transaction)
		{
			return (new ElectionLogic()).Insert(row, connection, transaction);
		}

		/// <summary>
		/// Insert the rows in bulk, uses the same connection (faster).
		/// </summary>
		/// <param name="rows">The table rows to Insert</param>
		/// <returns>The number of rows affected.</returns>
		public static int InsertAllNow(List<ElectionContract> rows)
		{
			return (new ElectionLogic()).InsertAll(rows);
		}

		/// <summary>
		/// Insert the rows in bulk, uses the same connection (faster), in a provided transaction scrope.
		/// </summary>
		/// <param name="rows">The table rows to Insert</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int InsertAllNow(List<ElectionContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			return (new ElectionLogic()).InsertAll(rows, connection, transaction);
		}
		/// <summary>
		/// Run Election_Update.
		/// </summary>
		/// <param name="fldElectionId">Value for ElectionId</param>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldElectionLevelId">Value for ElectionLevelId</param>
		/// <param name="fldElectionRegion">Value for ElectionRegion</param>
		/// <param name="fldVotingDate">Value for VotingDate</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateNow(int fldElectionId
, int fldContentInspectionId
, int fldElectionLevelId
, string fldElectionRegion
, DateTime fldVotingDate
)
		{
			return (new ElectionLogic()).Update(fldElectionId
, fldContentInspectionId
, fldElectionLevelId
, fldElectionRegion
, fldVotingDate
);
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
		public static int UpdateNow(int fldElectionId
, int fldContentInspectionId
, int fldElectionLevelId
, string fldElectionRegion
, DateTime fldVotingDate
, SqlConnection connection, SqlTransaction transaction)
		{
			return (new ElectionLogic()).Update(fldElectionId
, fldContentInspectionId
, fldElectionLevelId
, fldElectionRegion
, fldVotingDate
, connection, transaction);
		}
		/// <summary>
		/// Update by providing a populated data row container
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateNow(ElectionContract row)
		{
			return (new ElectionLogic()).Update(row);
		}

		/// <summary>
		/// Update by providing a populated data contract
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateNow(ElectionContract row, SqlConnection connection, SqlTransaction transaction)
		{
			return (new ElectionLogic()).Update(row, connection, transaction);
		}

		/// <summary>
		/// Update the rows in bulk, uses the same connection (faster).
		/// </summary>
		/// <param name="rows">The table rows to Update</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateAllNow(List<ElectionContract> rows)
		{
			return (new ElectionLogic()).UpdateAll(rows);
		}

		/// <summary>
		/// Update the rows in bulk, uses the same connection (faster), in a provided transaction scrope.
		/// </summary>
		/// <param name="rows">The table rows to Update</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateAllNow(List<ElectionContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			return (new ElectionLogic()).UpdateAll(rows, connection, transaction);
		}
		/// <summary>
		/// Run Election_Delete.
		/// </summary>
		/// <param name="fldElectionId">Value for ElectionId</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteNow(int fldElectionId
)
		{
			return (new ElectionLogic()).Delete(fldElectionId
);
		}

		/// <summary>
		/// Run Election_Delete.
		/// </summary>
		/// <param name="fldElectionId">Value for ElectionId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteNow(int fldElectionId
, SqlConnection connection, SqlTransaction transaction)
		{
			return (new ElectionLogic()).Delete(fldElectionId
, connection, transaction);
		}
		/// <summary>
		/// Delete by providing a populated data row container
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteNow(ElectionContract row)
		{
			return (new ElectionLogic()).Delete(row);
		}

		/// <summary>
		/// Delete by providing a populated data contract
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteNow(ElectionContract row, SqlConnection connection, SqlTransaction transaction)
		{
			return (new ElectionLogic()).Delete(row, connection, transaction);
		}

		/// <summary>
		/// Delete the rows in bulk, uses the same connection (faster).
		/// </summary>
		/// <param name="rows">The table rows to Delete</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteAllNow(List<ElectionContract> rows)
		{
			return (new ElectionLogic()).DeleteAll(rows);
		}

		/// <summary>
		/// Delete the rows in bulk, uses the same connection (faster), in a provided transaction scrope.
		/// </summary>
		/// <param name="rows">The table rows to Delete</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteAllNow(List<ElectionContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			return (new ElectionLogic()).DeleteAll(rows, connection, transaction);
		}
		/// <summary>
		/// Determine if the table contains a row with the existing values
		/// </summary>
		/// <param name="fldElectionId">Value for ElectionId</param>
		/// <returns>True, if the values exist, or false.</returns>
		public static bool ExistsNow(int fldElectionId
)
		{
			return (new ElectionLogic()).Exists(fldElectionId
);
		}

		/// <summary>
		/// Determine if the table contains a row with the existing values
		/// </summary>
		/// <param name="fldElectionId">Value for ElectionId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>True, if the values exist, or false.</returns>
		public static bool ExistsNow(int fldElectionId
, SqlConnection connection, SqlTransaction transaction)
		{					
			return (new ElectionLogic()).Exists(fldElectionId
, connection, transaction);
		}

		/// <summary>
		/// Run Election_Search, and return results as a list of ElectionRow.
		/// </summary>
		/// <param name="fldElectionRegion">Value for ElectionRegion</param>
		/// <returns>A collection of ElectionRow.</returns>
		public static List<ElectionContract> SearchNow(string fldElectionRegion
)
		{
			var driver = new ElectionLogic();
			driver.Search(fldElectionRegion
);
			return driver.Results;
		}

		/// <summary>
		/// Run Election_Search, and return results as a list of ElectionRow.
		/// </summary>
		/// <param name="fldElectionRegion">Value for ElectionRegion</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of ElectionRow.</returns>
		public static List<ElectionContract> SearchNow(string fldElectionRegion
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new ElectionLogic();
			driver.Search(fldElectionRegion
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run Election_SelectAll, and return results as a list of ElectionRow.
		/// </summary>

		/// <returns>A collection of ElectionRow.</returns>
		public static List<ElectionContract> SelectAllNow()
		{			
			var driver = new ElectionLogic();
			driver.SelectAll();
			return driver.Results;
		}

		/// <summary>
		/// Run Election_SelectAll, and return results as a list of ElectionRow.
		/// </summary>

		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of ElectionRow.</returns>
		public static List<ElectionContract> SelectAllNow(SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new ElectionLogic();
			driver.SelectAll(connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run Election_SelectBy_ElectionId, and return results as a list of ElectionRow.
		/// </summary>
		/// <param name="fldElectionId">Value for ElectionId</param>
		/// <returns>A collection of ElectionRow.</returns>
		public static List<ElectionContract> SelectBy_ElectionIdNow(int fldElectionId
)
		{
			var driver = new ElectionLogic();
			driver.SelectBy_ElectionId(fldElectionId
);
			return driver.Results;
		}

		/// <summary>
		/// Run Election_SelectBy_ElectionId, and return results as a list of ElectionRow.
		/// </summary>
		/// <param name="fldElectionId">Value for ElectionId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of ElectionRow.</returns>
		public static List<ElectionContract> SelectBy_ElectionIdNow(int fldElectionId
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new ElectionLogic();
			driver.SelectBy_ElectionId(fldElectionId
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run Election_SelectBy_ElectionLevelId, and return results as a list of ElectionRow.
		/// </summary>
		/// <param name="fldElectionLevelId">Value for ElectionLevelId</param>
		/// <returns>A collection of ElectionRow.</returns>
		public static List<ElectionContract> SelectBy_ElectionLevelIdNow(int fldElectionLevelId
)
		{
			var driver = new ElectionLogic();
			driver.SelectBy_ElectionLevelId(fldElectionLevelId
);
			return driver.Results;
		}

		/// <summary>
		/// Run Election_SelectBy_ElectionLevelId, and return results as a list of ElectionRow.
		/// </summary>
		/// <param name="fldElectionLevelId">Value for ElectionLevelId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of ElectionRow.</returns>
		public static List<ElectionContract> SelectBy_ElectionLevelIdNow(int fldElectionLevelId
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new ElectionLogic();
			driver.SelectBy_ElectionLevelId(fldElectionLevelId
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run Election_SelectBy_ContentInspectionId, and return results as a list of ElectionRow.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <returns>A collection of ElectionRow.</returns>
		public static List<ElectionContract> SelectBy_ContentInspectionIdNow(int fldContentInspectionId
)
		{
			var driver = new ElectionLogic();
			driver.SelectBy_ContentInspectionId(fldContentInspectionId
);
			return driver.Results;
		}

		/// <summary>
		/// Run Election_SelectBy_ContentInspectionId, and return results as a list of ElectionRow.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of ElectionRow.</returns>
		public static List<ElectionContract> SelectBy_ContentInspectionIdNow(int fldContentInspectionId
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new ElectionLogic();
			driver.SelectBy_ContentInspectionId(fldContentInspectionId
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Read all Election rows from the provided reader into the list structure of ElectionRows
		/// </summary>
		/// <param name="reader">The result of running a sql command.</param>
		/// <returns>A populated ElectionRows or an empty ElectionRows if there are no results.</returns>
		public static List<ElectionContract> ReadAllNow(SqlDataReader reader)
		{
			var driver = new ElectionLogic();

			driver.ReadAll(reader);
			
			return driver.Results;
		}
		/// <summary>");
		/// Advance one, and read values into a Election
		/// </summary>
		/// <param name="reader">The result of running a sql command.</param>");
		/// <returns>A Election or null if there are no results.</returns>
		public static ElectionContract ReadOneNow(SqlDataReader reader)
		{
			var driver = new ElectionLogic();			
		    return driver.ReadOne(reader) ? driver.Results[0] : null;
		}
		/// <summary>
		/// Saves the row, either by inserting (when the identity key is null) or by updating (identity key has value).
		/// </summary>
		/// <param name="row">The data to save</param>
		/// <returns>The number of rows affected.</returns>
		public static int SaveNow(ElectionContract row)
		{
			if(row.ElectionId == null)
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
		public static int SaveNow(ElectionContract row, SqlConnection connection, SqlTransaction transaction)
		{
			if(row.ElectionId == null)
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
		public static int SaveAllNow(List<ElectionContract> rows)
		{
			return (new ElectionLogic()).SaveAll(rows);
		}

		/// <summary>
		/// Save the rows in bulk, uses the same connection (faster), in a provided transaction scrope.
		/// </summary>
		/// <param name="rows">The table rows to Save</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int SaveAllNow(List<ElectionContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			return (new ElectionLogic()).SaveAll(rows, connection, transaction);
		}        
	}
}