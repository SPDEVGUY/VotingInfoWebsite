using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using VotingInfo.Database.Contracts;
using VotingInfo.Database.Contracts.Data;

///////////////////////////////////////////////////////////
//Do not modify this file. Use a partial class to extend.//
///////////////////////////////////////////////////////////
// This file contains static implementations of the ElectionLevelMetaDataXrefLogic
// Add your own static methods by making a new partial class.
// You cannot override static methods, instead override the methods
// located in ElectionLevelMetaDataXrefLogicBase by making a partial class of ElectionLevelMetaDataXrefLogic
// and overriding the base methods.

namespace VotingInfo.Database.Logic.Data
{
	public partial class ElectionLevelMetaDataXrefLogic
	{
		//Put your code in a separate file.  This is auto generated.
		/// <summary>
		/// Run ElectionLevelMetaDataXref_Insert.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldElectionLevelId">Value for ElectionLevelId</param>
		/// <param name="fldMetaDataId">Value for MetaDataId</param>
		public static int? InsertNow(int fldContentInspectionId
, int fldElectionLevelId
, string fldMetaDataId
)
		{
			return (new ElectionLevelMetaDataXrefLogic()).Insert(fldContentInspectionId
, fldElectionLevelId
, fldMetaDataId
);
		}
		/// <summary>
		/// Run ElectionLevelMetaDataXref_Insert.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldElectionLevelId">Value for ElectionLevelId</param>
		/// <param name="fldMetaDataId">Value for MetaDataId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		public static int? InsertNow(int fldContentInspectionId
, int fldElectionLevelId
, string fldMetaDataId
, SqlConnection connection, SqlTransaction transaction)
		{
			return (new ElectionLevelMetaDataXrefLogic()).Insert(fldContentInspectionId
, fldElectionLevelId
, fldMetaDataId
, connection, transaction);
		}

		/// <summary>
		/// Insert by providing a populated data row container
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int InsertNow(ElectionLevelMetaDataXrefContract row)
		{
			return (new ElectionLevelMetaDataXrefLogic()).Insert(row);
		}

		/// <summary>
		/// Insert by providing a populated data contract
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int InsertNow(ElectionLevelMetaDataXrefContract row, SqlConnection connection, SqlTransaction transaction)
		{
			return (new ElectionLevelMetaDataXrefLogic()).Insert(row, connection, transaction);
		}

		/// <summary>
		/// Insert the rows in bulk, uses the same connection (faster).
		/// </summary>
		/// <param name="rows">The table rows to Insert</param>
		/// <returns>The number of rows affected.</returns>
		public static int InsertAllNow(List<ElectionLevelMetaDataXrefContract> rows)
		{
			return (new ElectionLevelMetaDataXrefLogic()).InsertAll(rows);
		}

		/// <summary>
		/// Insert the rows in bulk, uses the same connection (faster), in a provided transaction scrope.
		/// </summary>
		/// <param name="rows">The table rows to Insert</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int InsertAllNow(List<ElectionLevelMetaDataXrefContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			return (new ElectionLevelMetaDataXrefLogic()).InsertAll(rows, connection, transaction);
		}
		/// <summary>
		/// Run ElectionLevelMetaDataXref_Update.
		/// </summary>
		/// <param name="fldElectionLevelMetaDataXrefId">Value for ElectionLevelMetaDataXrefId</param>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldElectionLevelId">Value for ElectionLevelId</param>
		/// <param name="fldMetaDataId">Value for MetaDataId</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateNow(int fldElectionLevelMetaDataXrefId
, int fldContentInspectionId
, int fldElectionLevelId
, string fldMetaDataId
)
		{
			return (new ElectionLevelMetaDataXrefLogic()).Update(fldElectionLevelMetaDataXrefId
, fldContentInspectionId
, fldElectionLevelId
, fldMetaDataId
);
		}

		/// <summary>
		/// Run ElectionLevelMetaDataXref_Update.
		/// </summary>
		/// <param name="fldElectionLevelMetaDataXrefId">Value for ElectionLevelMetaDataXrefId</param>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldElectionLevelId">Value for ElectionLevelId</param>
		/// <param name="fldMetaDataId">Value for MetaDataId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateNow(int fldElectionLevelMetaDataXrefId
, int fldContentInspectionId
, int fldElectionLevelId
, string fldMetaDataId
, SqlConnection connection, SqlTransaction transaction)
		{
			return (new ElectionLevelMetaDataXrefLogic()).Update(fldElectionLevelMetaDataXrefId
, fldContentInspectionId
, fldElectionLevelId
, fldMetaDataId
, connection, transaction);
		}
		/// <summary>
		/// Update by providing a populated data row container
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateNow(ElectionLevelMetaDataXrefContract row)
		{
			return (new ElectionLevelMetaDataXrefLogic()).Update(row);
		}

		/// <summary>
		/// Update by providing a populated data contract
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateNow(ElectionLevelMetaDataXrefContract row, SqlConnection connection, SqlTransaction transaction)
		{
			return (new ElectionLevelMetaDataXrefLogic()).Update(row, connection, transaction);
		}

		/// <summary>
		/// Update the rows in bulk, uses the same connection (faster).
		/// </summary>
		/// <param name="rows">The table rows to Update</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateAllNow(List<ElectionLevelMetaDataXrefContract> rows)
		{
			return (new ElectionLevelMetaDataXrefLogic()).UpdateAll(rows);
		}

		/// <summary>
		/// Update the rows in bulk, uses the same connection (faster), in a provided transaction scrope.
		/// </summary>
		/// <param name="rows">The table rows to Update</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateAllNow(List<ElectionLevelMetaDataXrefContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			return (new ElectionLevelMetaDataXrefLogic()).UpdateAll(rows, connection, transaction);
		}
		/// <summary>
		/// Run ElectionLevelMetaDataXref_Delete.
		/// </summary>
		/// <param name="fldElectionLevelMetaDataXrefId">Value for ElectionLevelMetaDataXrefId</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteNow(int fldElectionLevelMetaDataXrefId
)
		{
			return (new ElectionLevelMetaDataXrefLogic()).Delete(fldElectionLevelMetaDataXrefId
);
		}

		/// <summary>
		/// Run ElectionLevelMetaDataXref_Delete.
		/// </summary>
		/// <param name="fldElectionLevelMetaDataXrefId">Value for ElectionLevelMetaDataXrefId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteNow(int fldElectionLevelMetaDataXrefId
, SqlConnection connection, SqlTransaction transaction)
		{
			return (new ElectionLevelMetaDataXrefLogic()).Delete(fldElectionLevelMetaDataXrefId
, connection, transaction);
		}
		/// <summary>
		/// Delete by providing a populated data row container
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteNow(ElectionLevelMetaDataXrefContract row)
		{
			return (new ElectionLevelMetaDataXrefLogic()).Delete(row);
		}

		/// <summary>
		/// Delete by providing a populated data contract
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteNow(ElectionLevelMetaDataXrefContract row, SqlConnection connection, SqlTransaction transaction)
		{
			return (new ElectionLevelMetaDataXrefLogic()).Delete(row, connection, transaction);
		}

		/// <summary>
		/// Delete the rows in bulk, uses the same connection (faster).
		/// </summary>
		/// <param name="rows">The table rows to Delete</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteAllNow(List<ElectionLevelMetaDataXrefContract> rows)
		{
			return (new ElectionLevelMetaDataXrefLogic()).DeleteAll(rows);
		}

		/// <summary>
		/// Delete the rows in bulk, uses the same connection (faster), in a provided transaction scrope.
		/// </summary>
		/// <param name="rows">The table rows to Delete</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteAllNow(List<ElectionLevelMetaDataXrefContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			return (new ElectionLevelMetaDataXrefLogic()).DeleteAll(rows, connection, transaction);
		}
		/// <summary>
		/// Determine if the table contains a row with the existing values
		/// </summary>
		/// <param name="fldElectionLevelMetaDataXrefId">Value for ElectionLevelMetaDataXrefId</param>
		/// <returns>True, if the values exist, or false.</returns>
		public static bool ExistsNow(int fldElectionLevelMetaDataXrefId
)
		{
			return (new ElectionLevelMetaDataXrefLogic()).Exists(fldElectionLevelMetaDataXrefId
);
		}

		/// <summary>
		/// Determine if the table contains a row with the existing values
		/// </summary>
		/// <param name="fldElectionLevelMetaDataXrefId">Value for ElectionLevelMetaDataXrefId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>True, if the values exist, or false.</returns>
		public static bool ExistsNow(int fldElectionLevelMetaDataXrefId
, SqlConnection connection, SqlTransaction transaction)
		{					
			return (new ElectionLevelMetaDataXrefLogic()).Exists(fldElectionLevelMetaDataXrefId
, connection, transaction);
		}

		/// <summary>
		/// Run ElectionLevelMetaDataXref_Search, and return results as a list of ElectionLevelMetaDataXrefRow.
		/// </summary>
		/// <param name="fldMetaDataId">Value for MetaDataId</param>
		/// <returns>A collection of ElectionLevelMetaDataXrefRow.</returns>
		public static List<ElectionLevelMetaDataXrefContract> SearchNow(string fldMetaDataId
)
		{
			var driver = new ElectionLevelMetaDataXrefLogic();
			driver.Search(fldMetaDataId
);
			return driver.Results;
		}

		/// <summary>
		/// Run ElectionLevelMetaDataXref_Search, and return results as a list of ElectionLevelMetaDataXrefRow.
		/// </summary>
		/// <param name="fldMetaDataId">Value for MetaDataId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of ElectionLevelMetaDataXrefRow.</returns>
		public static List<ElectionLevelMetaDataXrefContract> SearchNow(string fldMetaDataId
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new ElectionLevelMetaDataXrefLogic();
			driver.Search(fldMetaDataId
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run ElectionLevelMetaDataXref_SelectAll, and return results as a list of ElectionLevelMetaDataXrefRow.
		/// </summary>

		/// <returns>A collection of ElectionLevelMetaDataXrefRow.</returns>
		public static List<ElectionLevelMetaDataXrefContract> SelectAllNow()
		{			
			var driver = new ElectionLevelMetaDataXrefLogic();
			driver.SelectAll();
			return driver.Results;
		}

		/// <summary>
		/// Run ElectionLevelMetaDataXref_SelectAll, and return results as a list of ElectionLevelMetaDataXrefRow.
		/// </summary>

		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of ElectionLevelMetaDataXrefRow.</returns>
		public static List<ElectionLevelMetaDataXrefContract> SelectAllNow(SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new ElectionLevelMetaDataXrefLogic();
			driver.SelectAll(connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run ElectionLevelMetaDataXref_SelectBy_ElectionLevelMetaDataXrefId, and return results as a list of ElectionLevelMetaDataXrefRow.
		/// </summary>
		/// <param name="fldElectionLevelMetaDataXrefId">Value for ElectionLevelMetaDataXrefId</param>
		/// <returns>A collection of ElectionLevelMetaDataXrefRow.</returns>
		public static List<ElectionLevelMetaDataXrefContract> SelectBy_ElectionLevelMetaDataXrefIdNow(int fldElectionLevelMetaDataXrefId
)
		{
			var driver = new ElectionLevelMetaDataXrefLogic();
			driver.SelectBy_ElectionLevelMetaDataXrefId(fldElectionLevelMetaDataXrefId
);
			return driver.Results;
		}

		/// <summary>
		/// Run ElectionLevelMetaDataXref_SelectBy_ElectionLevelMetaDataXrefId, and return results as a list of ElectionLevelMetaDataXrefRow.
		/// </summary>
		/// <param name="fldElectionLevelMetaDataXrefId">Value for ElectionLevelMetaDataXrefId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of ElectionLevelMetaDataXrefRow.</returns>
		public static List<ElectionLevelMetaDataXrefContract> SelectBy_ElectionLevelMetaDataXrefIdNow(int fldElectionLevelMetaDataXrefId
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new ElectionLevelMetaDataXrefLogic();
			driver.SelectBy_ElectionLevelMetaDataXrefId(fldElectionLevelMetaDataXrefId
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run ElectionLevelMetaDataXref_SelectBy_MetaDataId, and return results as a list of ElectionLevelMetaDataXrefRow.
		/// </summary>
		/// <param name="fldMetaDataId">Value for MetaDataId</param>
		/// <returns>A collection of ElectionLevelMetaDataXrefRow.</returns>
		public static List<ElectionLevelMetaDataXrefContract> SelectBy_MetaDataIdNow(string fldMetaDataId
)
		{
			var driver = new ElectionLevelMetaDataXrefLogic();
			driver.SelectBy_MetaDataId(fldMetaDataId
);
			return driver.Results;
		}

		/// <summary>
		/// Run ElectionLevelMetaDataXref_SelectBy_MetaDataId, and return results as a list of ElectionLevelMetaDataXrefRow.
		/// </summary>
		/// <param name="fldMetaDataId">Value for MetaDataId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of ElectionLevelMetaDataXrefRow.</returns>
		public static List<ElectionLevelMetaDataXrefContract> SelectBy_MetaDataIdNow(string fldMetaDataId
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new ElectionLevelMetaDataXrefLogic();
			driver.SelectBy_MetaDataId(fldMetaDataId
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run ElectionLevelMetaDataXref_SelectBy_ContentInspectionId, and return results as a list of ElectionLevelMetaDataXrefRow.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <returns>A collection of ElectionLevelMetaDataXrefRow.</returns>
		public static List<ElectionLevelMetaDataXrefContract> SelectBy_ContentInspectionIdNow(int fldContentInspectionId
)
		{
			var driver = new ElectionLevelMetaDataXrefLogic();
			driver.SelectBy_ContentInspectionId(fldContentInspectionId
);
			return driver.Results;
		}

		/// <summary>
		/// Run ElectionLevelMetaDataXref_SelectBy_ContentInspectionId, and return results as a list of ElectionLevelMetaDataXrefRow.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of ElectionLevelMetaDataXrefRow.</returns>
		public static List<ElectionLevelMetaDataXrefContract> SelectBy_ContentInspectionIdNow(int fldContentInspectionId
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new ElectionLevelMetaDataXrefLogic();
			driver.SelectBy_ContentInspectionId(fldContentInspectionId
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run ElectionLevelMetaDataXref_SelectBy_ElectionLevelId, and return results as a list of ElectionLevelMetaDataXrefRow.
		/// </summary>
		/// <param name="fldElectionLevelId">Value for ElectionLevelId</param>
		/// <returns>A collection of ElectionLevelMetaDataXrefRow.</returns>
		public static List<ElectionLevelMetaDataXrefContract> SelectBy_ElectionLevelIdNow(int fldElectionLevelId
)
		{
			var driver = new ElectionLevelMetaDataXrefLogic();
			driver.SelectBy_ElectionLevelId(fldElectionLevelId
);
			return driver.Results;
		}

		/// <summary>
		/// Run ElectionLevelMetaDataXref_SelectBy_ElectionLevelId, and return results as a list of ElectionLevelMetaDataXrefRow.
		/// </summary>
		/// <param name="fldElectionLevelId">Value for ElectionLevelId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of ElectionLevelMetaDataXrefRow.</returns>
		public static List<ElectionLevelMetaDataXrefContract> SelectBy_ElectionLevelIdNow(int fldElectionLevelId
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new ElectionLevelMetaDataXrefLogic();
			driver.SelectBy_ElectionLevelId(fldElectionLevelId
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Read all ElectionLevelMetaDataXref rows from the provided reader into the list structure of ElectionLevelMetaDataXrefRows
		/// </summary>
		/// <param name="reader">The result of running a sql command.</param>
		/// <returns>A populated ElectionLevelMetaDataXrefRows or an empty ElectionLevelMetaDataXrefRows if there are no results.</returns>
		public static List<ElectionLevelMetaDataXrefContract> ReadAllNow(SqlDataReader reader)
		{
			var driver = new ElectionLevelMetaDataXrefLogic();

			driver.ReadAll(reader);
			
			return driver.Results;
		}
		/// <summary>");
		/// Advance one, and read values into a ElectionLevelMetaDataXref
		/// </summary>
		/// <param name="reader">The result of running a sql command.</param>");
		/// <returns>A ElectionLevelMetaDataXref or null if there are no results.</returns>
		public static ElectionLevelMetaDataXrefContract ReadOneNow(SqlDataReader reader)
		{
			var driver = new ElectionLevelMetaDataXrefLogic();			
		    return driver.ReadOne(reader) ? driver.Results[0] : null;
		}
		/// <summary>
		/// Saves the row, either by inserting (when the identity key is null) or by updating (identity key has value).
		/// </summary>
		/// <param name="row">The data to save</param>
		/// <returns>The number of rows affected.</returns>
		public static int SaveNow(ElectionLevelMetaDataXrefContract row)
		{
			if(row.ElectionLevelMetaDataXrefId == null)
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
		public static int SaveNow(ElectionLevelMetaDataXrefContract row, SqlConnection connection, SqlTransaction transaction)
		{
			if(row.ElectionLevelMetaDataXrefId == null)
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
		public static int SaveAllNow(List<ElectionLevelMetaDataXrefContract> rows)
		{
			return (new ElectionLevelMetaDataXrefLogic()).SaveAll(rows);
		}

		/// <summary>
		/// Save the rows in bulk, uses the same connection (faster), in a provided transaction scrope.
		/// </summary>
		/// <param name="rows">The table rows to Save</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int SaveAllNow(List<ElectionLevelMetaDataXrefContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			return (new ElectionLevelMetaDataXrefLogic()).SaveAll(rows, connection, transaction);
		}        
	}
}