using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using VotingInfo.Database.Contracts;
using VotingInfo.Database.Contracts.Data;

///////////////////////////////////////////////////////////
//Do not modify this file. Use a partial class to extend.//
///////////////////////////////////////////////////////////
// This file contains static implementations of the ElectionCandidateLogic
// Add your own static methods by making a new partial class.
// You cannot override static methods, instead override the methods
// located in ElectionCandidateLogicBase by making a partial class of ElectionCandidateLogic
// and overriding the base methods.

namespace VotingInfo.Database.Logic.Data
{
	public partial class ElectionCandidateLogic
	{
		//Put your code in a separate file.  This is auto generated.
		/// <summary>
		/// Run ElectionCandidate_Insert.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldCandidateId">Value for CandidateId</param>
		/// <param name="fldElectionId">Value for ElectionId</param>
		/// <param name="fldIsWinner">Value for IsWinner</param>
		/// <param name="fldReportedVoteCount">Value for ReportedVoteCount</param>
		public static int? InsertNow(int fldContentInspectionId
, int fldCandidateId
, int fldElectionId
, bool fldIsWinner
, bool fldReportedVoteCount
)
		{
			return (new ElectionCandidateLogic()).Insert(fldContentInspectionId
, fldCandidateId
, fldElectionId
, fldIsWinner
, fldReportedVoteCount
);
		}
		/// <summary>
		/// Run ElectionCandidate_Insert.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldCandidateId">Value for CandidateId</param>
		/// <param name="fldElectionId">Value for ElectionId</param>
		/// <param name="fldIsWinner">Value for IsWinner</param>
		/// <param name="fldReportedVoteCount">Value for ReportedVoteCount</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		public static int? InsertNow(int fldContentInspectionId
, int fldCandidateId
, int fldElectionId
, bool fldIsWinner
, bool fldReportedVoteCount
, SqlConnection connection, SqlTransaction transaction)
		{
			return (new ElectionCandidateLogic()).Insert(fldContentInspectionId
, fldCandidateId
, fldElectionId
, fldIsWinner
, fldReportedVoteCount
, connection, transaction);
		}

		/// <summary>
		/// Insert by providing a populated data row container
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int InsertNow(ElectionCandidateContract row)
		{
			return (new ElectionCandidateLogic()).Insert(row);
		}

		/// <summary>
		/// Insert by providing a populated data contract
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int InsertNow(ElectionCandidateContract row, SqlConnection connection, SqlTransaction transaction)
		{
			return (new ElectionCandidateLogic()).Insert(row, connection, transaction);
		}

		/// <summary>
		/// Insert the rows in bulk, uses the same connection (faster).
		/// </summary>
		/// <param name="rows">The table rows to Insert</param>
		/// <returns>The number of rows affected.</returns>
		public static int InsertAllNow(List<ElectionCandidateContract> rows)
		{
			return (new ElectionCandidateLogic()).InsertAll(rows);
		}

		/// <summary>
		/// Insert the rows in bulk, uses the same connection (faster), in a provided transaction scrope.
		/// </summary>
		/// <param name="rows">The table rows to Insert</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int InsertAllNow(List<ElectionCandidateContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			return (new ElectionCandidateLogic()).InsertAll(rows, connection, transaction);
		}
		/// <summary>
		/// Run ElectionCandidate_Update.
		/// </summary>
		/// <param name="fldElectionCandidateId">Value for ElectionCandidateId</param>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldCandidateId">Value for CandidateId</param>
		/// <param name="fldElectionId">Value for ElectionId</param>
		/// <param name="fldIsWinner">Value for IsWinner</param>
		/// <param name="fldReportedVoteCount">Value for ReportedVoteCount</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateNow(int fldElectionCandidateId
, int fldContentInspectionId
, int fldCandidateId
, int fldElectionId
, bool fldIsWinner
, bool fldReportedVoteCount
)
		{
			return (new ElectionCandidateLogic()).Update(fldElectionCandidateId
, fldContentInspectionId
, fldCandidateId
, fldElectionId
, fldIsWinner
, fldReportedVoteCount
);
		}

		/// <summary>
		/// Run ElectionCandidate_Update.
		/// </summary>
		/// <param name="fldElectionCandidateId">Value for ElectionCandidateId</param>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldCandidateId">Value for CandidateId</param>
		/// <param name="fldElectionId">Value for ElectionId</param>
		/// <param name="fldIsWinner">Value for IsWinner</param>
		/// <param name="fldReportedVoteCount">Value for ReportedVoteCount</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateNow(int fldElectionCandidateId
, int fldContentInspectionId
, int fldCandidateId
, int fldElectionId
, bool fldIsWinner
, bool fldReportedVoteCount
, SqlConnection connection, SqlTransaction transaction)
		{
			return (new ElectionCandidateLogic()).Update(fldElectionCandidateId
, fldContentInspectionId
, fldCandidateId
, fldElectionId
, fldIsWinner
, fldReportedVoteCount
, connection, transaction);
		}
		/// <summary>
		/// Update by providing a populated data row container
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateNow(ElectionCandidateContract row)
		{
			return (new ElectionCandidateLogic()).Update(row);
		}

		/// <summary>
		/// Update by providing a populated data contract
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateNow(ElectionCandidateContract row, SqlConnection connection, SqlTransaction transaction)
		{
			return (new ElectionCandidateLogic()).Update(row, connection, transaction);
		}

		/// <summary>
		/// Update the rows in bulk, uses the same connection (faster).
		/// </summary>
		/// <param name="rows">The table rows to Update</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateAllNow(List<ElectionCandidateContract> rows)
		{
			return (new ElectionCandidateLogic()).UpdateAll(rows);
		}

		/// <summary>
		/// Update the rows in bulk, uses the same connection (faster), in a provided transaction scrope.
		/// </summary>
		/// <param name="rows">The table rows to Update</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateAllNow(List<ElectionCandidateContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			return (new ElectionCandidateLogic()).UpdateAll(rows, connection, transaction);
		}
		/// <summary>
		/// Run ElectionCandidate_Delete.
		/// </summary>
		/// <param name="fldElectionCandidateId">Value for ElectionCandidateId</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteNow(int fldElectionCandidateId
)
		{
			return (new ElectionCandidateLogic()).Delete(fldElectionCandidateId
);
		}

		/// <summary>
		/// Run ElectionCandidate_Delete.
		/// </summary>
		/// <param name="fldElectionCandidateId">Value for ElectionCandidateId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteNow(int fldElectionCandidateId
, SqlConnection connection, SqlTransaction transaction)
		{
			return (new ElectionCandidateLogic()).Delete(fldElectionCandidateId
, connection, transaction);
		}
		/// <summary>
		/// Delete by providing a populated data row container
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteNow(ElectionCandidateContract row)
		{
			return (new ElectionCandidateLogic()).Delete(row);
		}

		/// <summary>
		/// Delete by providing a populated data contract
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteNow(ElectionCandidateContract row, SqlConnection connection, SqlTransaction transaction)
		{
			return (new ElectionCandidateLogic()).Delete(row, connection, transaction);
		}

		/// <summary>
		/// Delete the rows in bulk, uses the same connection (faster).
		/// </summary>
		/// <param name="rows">The table rows to Delete</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteAllNow(List<ElectionCandidateContract> rows)
		{
			return (new ElectionCandidateLogic()).DeleteAll(rows);
		}

		/// <summary>
		/// Delete the rows in bulk, uses the same connection (faster), in a provided transaction scrope.
		/// </summary>
		/// <param name="rows">The table rows to Delete</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteAllNow(List<ElectionCandidateContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			return (new ElectionCandidateLogic()).DeleteAll(rows, connection, transaction);
		}
		/// <summary>
		/// Determine if the table contains a row with the existing values
		/// </summary>
		/// <param name="fldElectionCandidateId">Value for ElectionCandidateId</param>
		/// <returns>True, if the values exist, or false.</returns>
		public static bool ExistsNow(int fldElectionCandidateId
)
		{
			return (new ElectionCandidateLogic()).Exists(fldElectionCandidateId
);
		}

		/// <summary>
		/// Determine if the table contains a row with the existing values
		/// </summary>
		/// <param name="fldElectionCandidateId">Value for ElectionCandidateId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>True, if the values exist, or false.</returns>
		public static bool ExistsNow(int fldElectionCandidateId
, SqlConnection connection, SqlTransaction transaction)
		{					
			return (new ElectionCandidateLogic()).Exists(fldElectionCandidateId
, connection, transaction);
		}

		/// <summary>
		/// Run ElectionCandidate_SelectAll, and return results as a list of ElectionCandidateRow.
		/// </summary>

		/// <returns>A collection of ElectionCandidateRow.</returns>
		public static List<ElectionCandidateContract> SelectAllNow()
		{			
			var driver = new ElectionCandidateLogic();
			driver.SelectAll();
			return driver.Results;
		}

		/// <summary>
		/// Run ElectionCandidate_SelectAll, and return results as a list of ElectionCandidateRow.
		/// </summary>

		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of ElectionCandidateRow.</returns>
		public static List<ElectionCandidateContract> SelectAllNow(SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new ElectionCandidateLogic();
			driver.SelectAll(connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run ElectionCandidate_SelectBy_ElectionCandidateId, and return results as a list of ElectionCandidateRow.
		/// </summary>
		/// <param name="fldElectionCandidateId">Value for ElectionCandidateId</param>
		/// <returns>A collection of ElectionCandidateRow.</returns>
		public static List<ElectionCandidateContract> SelectBy_ElectionCandidateIdNow(int fldElectionCandidateId
)
		{
			var driver = new ElectionCandidateLogic();
			driver.SelectBy_ElectionCandidateId(fldElectionCandidateId
);
			return driver.Results;
		}

		/// <summary>
		/// Run ElectionCandidate_SelectBy_ElectionCandidateId, and return results as a list of ElectionCandidateRow.
		/// </summary>
		/// <param name="fldElectionCandidateId">Value for ElectionCandidateId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of ElectionCandidateRow.</returns>
		public static List<ElectionCandidateContract> SelectBy_ElectionCandidateIdNow(int fldElectionCandidateId
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new ElectionCandidateLogic();
			driver.SelectBy_ElectionCandidateId(fldElectionCandidateId
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run ElectionCandidate_SelectBy_ContentInspectionId, and return results as a list of ElectionCandidateRow.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <returns>A collection of ElectionCandidateRow.</returns>
		public static List<ElectionCandidateContract> SelectBy_ContentInspectionIdNow(int fldContentInspectionId
)
		{
			var driver = new ElectionCandidateLogic();
			driver.SelectBy_ContentInspectionId(fldContentInspectionId
);
			return driver.Results;
		}

		/// <summary>
		/// Run ElectionCandidate_SelectBy_ContentInspectionId, and return results as a list of ElectionCandidateRow.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of ElectionCandidateRow.</returns>
		public static List<ElectionCandidateContract> SelectBy_ContentInspectionIdNow(int fldContentInspectionId
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new ElectionCandidateLogic();
			driver.SelectBy_ContentInspectionId(fldContentInspectionId
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run ElectionCandidate_SelectBy_CandidateId, and return results as a list of ElectionCandidateRow.
		/// </summary>
		/// <param name="fldCandidateId">Value for CandidateId</param>
		/// <returns>A collection of ElectionCandidateRow.</returns>
		public static List<ElectionCandidateContract> SelectBy_CandidateIdNow(int fldCandidateId
)
		{
			var driver = new ElectionCandidateLogic();
			driver.SelectBy_CandidateId(fldCandidateId
);
			return driver.Results;
		}

		/// <summary>
		/// Run ElectionCandidate_SelectBy_CandidateId, and return results as a list of ElectionCandidateRow.
		/// </summary>
		/// <param name="fldCandidateId">Value for CandidateId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of ElectionCandidateRow.</returns>
		public static List<ElectionCandidateContract> SelectBy_CandidateIdNow(int fldCandidateId
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new ElectionCandidateLogic();
			driver.SelectBy_CandidateId(fldCandidateId
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run ElectionCandidate_SelectBy_ElectionId, and return results as a list of ElectionCandidateRow.
		/// </summary>
		/// <param name="fldElectionId">Value for ElectionId</param>
		/// <returns>A collection of ElectionCandidateRow.</returns>
		public static List<ElectionCandidateContract> SelectBy_ElectionIdNow(int fldElectionId
)
		{
			var driver = new ElectionCandidateLogic();
			driver.SelectBy_ElectionId(fldElectionId
);
			return driver.Results;
		}

		/// <summary>
		/// Run ElectionCandidate_SelectBy_ElectionId, and return results as a list of ElectionCandidateRow.
		/// </summary>
		/// <param name="fldElectionId">Value for ElectionId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of ElectionCandidateRow.</returns>
		public static List<ElectionCandidateContract> SelectBy_ElectionIdNow(int fldElectionId
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new ElectionCandidateLogic();
			driver.SelectBy_ElectionId(fldElectionId
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Read all ElectionCandidate rows from the provided reader into the list structure of ElectionCandidateRows
		/// </summary>
		/// <param name="reader">The result of running a sql command.</param>
		/// <returns>A populated ElectionCandidateRows or an empty ElectionCandidateRows if there are no results.</returns>
		public static List<ElectionCandidateContract> ReadAllNow(SqlDataReader reader)
		{
			var driver = new ElectionCandidateLogic();

			driver.ReadAll(reader);
			
			return driver.Results;
		}
		/// <summary>");
		/// Advance one, and read values into a ElectionCandidate
		/// </summary>
		/// <param name="reader">The result of running a sql command.</param>");
		/// <returns>A ElectionCandidate or null if there are no results.</returns>
		public static ElectionCandidateContract ReadOneNow(SqlDataReader reader)
		{
			var driver = new ElectionCandidateLogic();			
		    return driver.ReadOne(reader) ? driver.Results[0] : null;
		}
		/// <summary>
		/// Saves the row, either by inserting (when the identity key is null) or by updating (identity key has value).
		/// </summary>
		/// <param name="row">The data to save</param>
		/// <returns>The number of rows affected.</returns>
		public static int SaveNow(ElectionCandidateContract row)
		{
			if(row.ElectionCandidateId == null)
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
		public static int SaveNow(ElectionCandidateContract row, SqlConnection connection, SqlTransaction transaction)
		{
			if(row.ElectionCandidateId == null)
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
		public static int SaveAllNow(List<ElectionCandidateContract> rows)
		{
			return (new ElectionCandidateLogic()).SaveAll(rows);
		}

		/// <summary>
		/// Save the rows in bulk, uses the same connection (faster), in a provided transaction scrope.
		/// </summary>
		/// <param name="rows">The table rows to Save</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int SaveAllNow(List<ElectionCandidateContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			return (new ElectionCandidateLogic()).SaveAll(rows, connection, transaction);
		}        
	}
}