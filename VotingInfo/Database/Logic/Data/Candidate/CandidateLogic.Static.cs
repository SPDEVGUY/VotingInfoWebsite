using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using VotingInfo.Database.Contracts;
using VotingInfo.Database.Contracts.Data;

///////////////////////////////////////////////////////////
//Do not modify this file. Use a partial class to extend.//
///////////////////////////////////////////////////////////
// This file contains static implementations of the CandidateLogic
// Add your own static methods by making a new partial class.
// You cannot override static methods, instead override the methods
// located in CandidateLogicBase by making a partial class of CandidateLogic
// and overriding the base methods.

namespace VotingInfo.Database.Logic.Data
{
	public partial class CandidateLogic
	{
		//Put your code in a separate file.  This is auto generated.
		/// <summary>
		/// Run Candidate_Insert.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldCandidateName">Value for CandidateName</param>
		/// <param name="fldOrganizationId">Value for OrganizationId</param>
		public static int? InsertNow(int fldContentInspectionId
, string fldCandidateName
, int fldOrganizationId
)
		{
			return (new CandidateLogic()).Insert(fldContentInspectionId
, fldCandidateName
, fldOrganizationId
);
		}
		/// <summary>
		/// Run Candidate_Insert.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldCandidateName">Value for CandidateName</param>
		/// <param name="fldOrganizationId">Value for OrganizationId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		public static int? InsertNow(int fldContentInspectionId
, string fldCandidateName
, int fldOrganizationId
, SqlConnection connection, SqlTransaction transaction)
		{
			return (new CandidateLogic()).Insert(fldContentInspectionId
, fldCandidateName
, fldOrganizationId
, connection, transaction);
		}

		/// <summary>
		/// Insert by providing a populated data row container
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int InsertNow(CandidateContract row)
		{
			return (new CandidateLogic()).Insert(row);
		}

		/// <summary>
		/// Insert by providing a populated data contract
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int InsertNow(CandidateContract row, SqlConnection connection, SqlTransaction transaction)
		{
			return (new CandidateLogic()).Insert(row, connection, transaction);
		}

		/// <summary>
		/// Insert the rows in bulk, uses the same connection (faster).
		/// </summary>
		/// <param name="rows">The table rows to Insert</param>
		/// <returns>The number of rows affected.</returns>
		public static int InsertAllNow(List<CandidateContract> rows)
		{
			return (new CandidateLogic()).InsertAll(rows);
		}

		/// <summary>
		/// Insert the rows in bulk, uses the same connection (faster), in a provided transaction scrope.
		/// </summary>
		/// <param name="rows">The table rows to Insert</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int InsertAllNow(List<CandidateContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			return (new CandidateLogic()).InsertAll(rows, connection, transaction);
		}
		/// <summary>
		/// Run Candidate_Update.
		/// </summary>
		/// <param name="fldCandidateId">Value for CandidateId</param>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldCandidateName">Value for CandidateName</param>
		/// <param name="fldOrganizationId">Value for OrganizationId</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateNow(int fldCandidateId
, int fldContentInspectionId
, string fldCandidateName
, int fldOrganizationId
)
		{
			return (new CandidateLogic()).Update(fldCandidateId
, fldContentInspectionId
, fldCandidateName
, fldOrganizationId
);
		}

		/// <summary>
		/// Run Candidate_Update.
		/// </summary>
		/// <param name="fldCandidateId">Value for CandidateId</param>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldCandidateName">Value for CandidateName</param>
		/// <param name="fldOrganizationId">Value for OrganizationId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateNow(int fldCandidateId
, int fldContentInspectionId
, string fldCandidateName
, int fldOrganizationId
, SqlConnection connection, SqlTransaction transaction)
		{
			return (new CandidateLogic()).Update(fldCandidateId
, fldContentInspectionId
, fldCandidateName
, fldOrganizationId
, connection, transaction);
		}
		/// <summary>
		/// Update by providing a populated data row container
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateNow(CandidateContract row)
		{
			return (new CandidateLogic()).Update(row);
		}

		/// <summary>
		/// Update by providing a populated data contract
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateNow(CandidateContract row, SqlConnection connection, SqlTransaction transaction)
		{
			return (new CandidateLogic()).Update(row, connection, transaction);
		}

		/// <summary>
		/// Update the rows in bulk, uses the same connection (faster).
		/// </summary>
		/// <param name="rows">The table rows to Update</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateAllNow(List<CandidateContract> rows)
		{
			return (new CandidateLogic()).UpdateAll(rows);
		}

		/// <summary>
		/// Update the rows in bulk, uses the same connection (faster), in a provided transaction scrope.
		/// </summary>
		/// <param name="rows">The table rows to Update</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateAllNow(List<CandidateContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			return (new CandidateLogic()).UpdateAll(rows, connection, transaction);
		}
		/// <summary>
		/// Run Candidate_Delete.
		/// </summary>
		/// <param name="fldCandidateId">Value for CandidateId</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteNow(int fldCandidateId
)
		{
			return (new CandidateLogic()).Delete(fldCandidateId
);
		}

		/// <summary>
		/// Run Candidate_Delete.
		/// </summary>
		/// <param name="fldCandidateId">Value for CandidateId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteNow(int fldCandidateId
, SqlConnection connection, SqlTransaction transaction)
		{
			return (new CandidateLogic()).Delete(fldCandidateId
, connection, transaction);
		}
		/// <summary>
		/// Delete by providing a populated data row container
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteNow(CandidateContract row)
		{
			return (new CandidateLogic()).Delete(row);
		}

		/// <summary>
		/// Delete by providing a populated data contract
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteNow(CandidateContract row, SqlConnection connection, SqlTransaction transaction)
		{
			return (new CandidateLogic()).Delete(row, connection, transaction);
		}

		/// <summary>
		/// Delete the rows in bulk, uses the same connection (faster).
		/// </summary>
		/// <param name="rows">The table rows to Delete</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteAllNow(List<CandidateContract> rows)
		{
			return (new CandidateLogic()).DeleteAll(rows);
		}

		/// <summary>
		/// Delete the rows in bulk, uses the same connection (faster), in a provided transaction scrope.
		/// </summary>
		/// <param name="rows">The table rows to Delete</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteAllNow(List<CandidateContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			return (new CandidateLogic()).DeleteAll(rows, connection, transaction);
		}
		/// <summary>
		/// Determine if the table contains a row with the existing values
		/// </summary>
		/// <param name="fldCandidateId">Value for CandidateId</param>
		/// <returns>True, if the values exist, or false.</returns>
		public static bool ExistsNow(int fldCandidateId
)
		{
			return (new CandidateLogic()).Exists(fldCandidateId
);
		}

		/// <summary>
		/// Determine if the table contains a row with the existing values
		/// </summary>
		/// <param name="fldCandidateId">Value for CandidateId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>True, if the values exist, or false.</returns>
		public static bool ExistsNow(int fldCandidateId
, SqlConnection connection, SqlTransaction transaction)
		{					
			return (new CandidateLogic()).Exists(fldCandidateId
, connection, transaction);
		}

		/// <summary>
		/// Run Candidate_Search, and return results as a list of CandidateRow.
		/// </summary>
		/// <param name="fldCandidateName">Value for CandidateName</param>
		/// <returns>A collection of CandidateRow.</returns>
		public static List<CandidateContract> SearchNow(string fldCandidateName
)
		{
			var driver = new CandidateLogic();
			driver.Search(fldCandidateName
);
			return driver.Results;
		}

		/// <summary>
		/// Run Candidate_Search, and return results as a list of CandidateRow.
		/// </summary>
		/// <param name="fldCandidateName">Value for CandidateName</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of CandidateRow.</returns>
		public static List<CandidateContract> SearchNow(string fldCandidateName
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new CandidateLogic();
			driver.Search(fldCandidateName
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run Candidate_SelectAll, and return results as a list of CandidateRow.
		/// </summary>

		/// <returns>A collection of CandidateRow.</returns>
		public static List<CandidateContract> SelectAllNow()
		{			
			var driver = new CandidateLogic();
			driver.SelectAll();
			return driver.Results;
		}

		/// <summary>
		/// Run Candidate_SelectAll, and return results as a list of CandidateRow.
		/// </summary>

		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of CandidateRow.</returns>
		public static List<CandidateContract> SelectAllNow(SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new CandidateLogic();
			driver.SelectAll(connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run Candidate_List, and return results as a list.
		/// </summary>
		/// <param name="fldCandidateName">Value for CandidateName</param>
		/// <returns>A collection of __ListItemRow.</returns>
		public static List<ListItemContract> ListNow(string fldCandidateName
)
		{
			return (new CandidateLogic()).List(fldCandidateName
);
		}

		/// <summary>
		/// Run Candidate_List, and return results as a list.
		/// </summary>
		/// <param name="fldCandidateName">Value for CandidateName</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of __ListItemRow.</returns>
		public static List<ListItemContract> ListNow(string fldCandidateName
, SqlConnection connection, SqlTransaction transaction)
		{
			return (new CandidateLogic()).List(fldCandidateName
, connection, transaction);
		}

		/// <summary>
		/// Run Candidate_SelectBy_CandidateId, and return results as a list of CandidateRow.
		/// </summary>
		/// <param name="fldCandidateId">Value for CandidateId</param>
		/// <returns>A collection of CandidateRow.</returns>
		public static List<CandidateContract> SelectBy_CandidateIdNow(int fldCandidateId
)
		{
			var driver = new CandidateLogic();
			driver.SelectBy_CandidateId(fldCandidateId
);
			return driver.Results;
		}

		/// <summary>
		/// Run Candidate_SelectBy_CandidateId, and return results as a list of CandidateRow.
		/// </summary>
		/// <param name="fldCandidateId">Value for CandidateId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of CandidateRow.</returns>
		public static List<CandidateContract> SelectBy_CandidateIdNow(int fldCandidateId
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new CandidateLogic();
			driver.SelectBy_CandidateId(fldCandidateId
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run Candidate_SelectBy_ContentInspectionId, and return results as a list of CandidateRow.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <returns>A collection of CandidateRow.</returns>
		public static List<CandidateContract> SelectBy_ContentInspectionIdNow(int fldContentInspectionId
)
		{
			var driver = new CandidateLogic();
			driver.SelectBy_ContentInspectionId(fldContentInspectionId
);
			return driver.Results;
		}

		/// <summary>
		/// Run Candidate_SelectBy_ContentInspectionId, and return results as a list of CandidateRow.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of CandidateRow.</returns>
		public static List<CandidateContract> SelectBy_ContentInspectionIdNow(int fldContentInspectionId
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new CandidateLogic();
			driver.SelectBy_ContentInspectionId(fldContentInspectionId
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run Candidate_SelectBy_OrganizationId, and return results as a list of CandidateRow.
		/// </summary>
		/// <param name="fldOrganizationId">Value for OrganizationId</param>
		/// <returns>A collection of CandidateRow.</returns>
		public static List<CandidateContract> SelectBy_OrganizationIdNow(int fldOrganizationId
)
		{
			var driver = new CandidateLogic();
			driver.SelectBy_OrganizationId(fldOrganizationId
);
			return driver.Results;
		}

		/// <summary>
		/// Run Candidate_SelectBy_OrganizationId, and return results as a list of CandidateRow.
		/// </summary>
		/// <param name="fldOrganizationId">Value for OrganizationId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of CandidateRow.</returns>
		public static List<CandidateContract> SelectBy_OrganizationIdNow(int fldOrganizationId
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new CandidateLogic();
			driver.SelectBy_OrganizationId(fldOrganizationId
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Read all Candidate rows from the provided reader into the list structure of CandidateRows
		/// </summary>
		/// <param name="reader">The result of running a sql command.</param>
		/// <returns>A populated CandidateRows or an empty CandidateRows if there are no results.</returns>
		public static List<CandidateContract> ReadAllNow(SqlDataReader reader)
		{
			var driver = new CandidateLogic();

			driver.ReadAll(reader);
			
			return driver.Results;
		}
		/// <summary>");
		/// Advance one, and read values into a Candidate
		/// </summary>
		/// <param name="reader">The result of running a sql command.</param>");
		/// <returns>A Candidate or null if there are no results.</returns>
		public static CandidateContract ReadOneNow(SqlDataReader reader)
		{
			var driver = new CandidateLogic();			
		    return driver.ReadOne(reader) ? driver.Results[0] : null;
		}
		/// <summary>
		/// Saves the row, either by inserting (when the identity key is null) or by updating (identity key has value).
		/// </summary>
		/// <param name="row">The data to save</param>
		/// <returns>The number of rows affected.</returns>
		public static int SaveNow(CandidateContract row)
		{
			if(row.CandidateId == null)
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
		public static int SaveNow(CandidateContract row, SqlConnection connection, SqlTransaction transaction)
		{
			if(row.CandidateId == null)
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
		public static int SaveAllNow(List<CandidateContract> rows)
		{
			return (new CandidateLogic()).SaveAll(rows);
		}

		/// <summary>
		/// Save the rows in bulk, uses the same connection (faster), in a provided transaction scrope.
		/// </summary>
		/// <param name="rows">The table rows to Save</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int SaveAllNow(List<CandidateContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			return (new CandidateLogic()).SaveAll(rows, connection, transaction);
		}        
	}
}