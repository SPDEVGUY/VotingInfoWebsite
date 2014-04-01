using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using VotingInfo.Database.Contracts;
using VotingInfo.Database.Contracts.Data;

///////////////////////////////////////////////////////////
//Do not modify this file. Use a partial class to extend.//
///////////////////////////////////////////////////////////
// This file contains static implementations of the ContentInspectionLogic
// Add your own static methods by making a new partial class.
// You cannot override static methods, instead override the methods
// located in ContentInspectionLogicBase by making a partial class of ContentInspectionLogic
// and overriding the base methods.

namespace VotingInfo.Database.Logic.Data
{
	public partial class ContentInspectionLogic
	{
		//Put your code in a separate file.  This is auto generated.
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
		public static int? InsertNow(bool fldIsArchived
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
			return (new ContentInspectionLogic()).Insert(fldIsArchived
, fldIsBeingProposed
, fldProposedByUserId
, fldConfirmedByUserId
, fldFalseInfoCount
, fldTrueInfoCount
, fldAdminInpsected
, fldDateLastChecked
, fldSourceUrl
);
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
		public static int? InsertNow(bool fldIsArchived
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
			return (new ContentInspectionLogic()).Insert(fldIsArchived
, fldIsBeingProposed
, fldProposedByUserId
, fldConfirmedByUserId
, fldFalseInfoCount
, fldTrueInfoCount
, fldAdminInpsected
, fldDateLastChecked
, fldSourceUrl
, connection, transaction);
		}

		/// <summary>
		/// Insert by providing a populated data row container
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int InsertNow(ContentInspectionContract row)
		{
			return (new ContentInspectionLogic()).Insert(row);
		}

		/// <summary>
		/// Insert by providing a populated data contract
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int InsertNow(ContentInspectionContract row, SqlConnection connection, SqlTransaction transaction)
		{
			return (new ContentInspectionLogic()).Insert(row, connection, transaction);
		}

		/// <summary>
		/// Insert the rows in bulk, uses the same connection (faster).
		/// </summary>
		/// <param name="rows">The table rows to Insert</param>
		/// <returns>The number of rows affected.</returns>
		public static int InsertAllNow(List<ContentInspectionContract> rows)
		{
			return (new ContentInspectionLogic()).InsertAll(rows);
		}

		/// <summary>
		/// Insert the rows in bulk, uses the same connection (faster), in a provided transaction scrope.
		/// </summary>
		/// <param name="rows">The table rows to Insert</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int InsertAllNow(List<ContentInspectionContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			return (new ContentInspectionLogic()).InsertAll(rows, connection, transaction);
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
		/// <returns>The number of rows affected.</returns>
		public static int UpdateNow(int fldContentInspectionId
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
			return (new ContentInspectionLogic()).Update(fldContentInspectionId
, fldIsArchived
, fldIsBeingProposed
, fldProposedByUserId
, fldConfirmedByUserId
, fldFalseInfoCount
, fldTrueInfoCount
, fldAdminInpsected
, fldDateLastChecked
, fldSourceUrl
);
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
		public static int UpdateNow(int fldContentInspectionId
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
			return (new ContentInspectionLogic()).Update(fldContentInspectionId
, fldIsArchived
, fldIsBeingProposed
, fldProposedByUserId
, fldConfirmedByUserId
, fldFalseInfoCount
, fldTrueInfoCount
, fldAdminInpsected
, fldDateLastChecked
, fldSourceUrl
, connection, transaction);
		}
		/// <summary>
		/// Update by providing a populated data row container
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateNow(ContentInspectionContract row)
		{
			return (new ContentInspectionLogic()).Update(row);
		}

		/// <summary>
		/// Update by providing a populated data contract
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateNow(ContentInspectionContract row, SqlConnection connection, SqlTransaction transaction)
		{
			return (new ContentInspectionLogic()).Update(row, connection, transaction);
		}

		/// <summary>
		/// Update the rows in bulk, uses the same connection (faster).
		/// </summary>
		/// <param name="rows">The table rows to Update</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateAllNow(List<ContentInspectionContract> rows)
		{
			return (new ContentInspectionLogic()).UpdateAll(rows);
		}

		/// <summary>
		/// Update the rows in bulk, uses the same connection (faster), in a provided transaction scrope.
		/// </summary>
		/// <param name="rows">The table rows to Update</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateAllNow(List<ContentInspectionContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			return (new ContentInspectionLogic()).UpdateAll(rows, connection, transaction);
		}
		/// <summary>
		/// Run ContentInspection_Delete.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteNow(int fldContentInspectionId
)
		{
			return (new ContentInspectionLogic()).Delete(fldContentInspectionId
);
		}

		/// <summary>
		/// Run ContentInspection_Delete.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteNow(int fldContentInspectionId
, SqlConnection connection, SqlTransaction transaction)
		{
			return (new ContentInspectionLogic()).Delete(fldContentInspectionId
, connection, transaction);
		}
		/// <summary>
		/// Delete by providing a populated data row container
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteNow(ContentInspectionContract row)
		{
			return (new ContentInspectionLogic()).Delete(row);
		}

		/// <summary>
		/// Delete by providing a populated data contract
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteNow(ContentInspectionContract row, SqlConnection connection, SqlTransaction transaction)
		{
			return (new ContentInspectionLogic()).Delete(row, connection, transaction);
		}

		/// <summary>
		/// Delete the rows in bulk, uses the same connection (faster).
		/// </summary>
		/// <param name="rows">The table rows to Delete</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteAllNow(List<ContentInspectionContract> rows)
		{
			return (new ContentInspectionLogic()).DeleteAll(rows);
		}

		/// <summary>
		/// Delete the rows in bulk, uses the same connection (faster), in a provided transaction scrope.
		/// </summary>
		/// <param name="rows">The table rows to Delete</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteAllNow(List<ContentInspectionContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			return (new ContentInspectionLogic()).DeleteAll(rows, connection, transaction);
		}
		/// <summary>
		/// Determine if the table contains a row with the existing values
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <returns>True, if the values exist, or false.</returns>
		public static bool ExistsNow(int fldContentInspectionId
)
		{
			return (new ContentInspectionLogic()).Exists(fldContentInspectionId
);
		}

		/// <summary>
		/// Determine if the table contains a row with the existing values
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>True, if the values exist, or false.</returns>
		public static bool ExistsNow(int fldContentInspectionId
, SqlConnection connection, SqlTransaction transaction)
		{					
			return (new ContentInspectionLogic()).Exists(fldContentInspectionId
, connection, transaction);
		}

		/// <summary>
		/// Run ContentInspection_Search, and return results as a list of ContentInspectionRow.
		/// </summary>
		/// <param name="fldSourceUrl">Value for SourceUrl</param>
		/// <returns>A collection of ContentInspectionRow.</returns>
		public static List<ContentInspectionContract> SearchNow(string fldSourceUrl
)
		{
			var driver = new ContentInspectionLogic();
			driver.Search(fldSourceUrl
);
			return driver.Results;
		}

		/// <summary>
		/// Run ContentInspection_Search, and return results as a list of ContentInspectionRow.
		/// </summary>
		/// <param name="fldSourceUrl">Value for SourceUrl</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of ContentInspectionRow.</returns>
		public static List<ContentInspectionContract> SearchNow(string fldSourceUrl
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new ContentInspectionLogic();
			driver.Search(fldSourceUrl
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run ContentInspection_SelectAll, and return results as a list of ContentInspectionRow.
		/// </summary>

		/// <returns>A collection of ContentInspectionRow.</returns>
		public static List<ContentInspectionContract> SelectAllNow()
		{			
			var driver = new ContentInspectionLogic();
			driver.SelectAll();
			return driver.Results;
		}

		/// <summary>
		/// Run ContentInspection_SelectAll, and return results as a list of ContentInspectionRow.
		/// </summary>

		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of ContentInspectionRow.</returns>
		public static List<ContentInspectionContract> SelectAllNow(SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new ContentInspectionLogic();
			driver.SelectAll(connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run ContentInspection_SelectBy_ContentInspectionId, and return results as a list of ContentInspectionRow.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <returns>A collection of ContentInspectionRow.</returns>
		public static List<ContentInspectionContract> SelectBy_ContentInspectionIdNow(int fldContentInspectionId
)
		{
			var driver = new ContentInspectionLogic();
			driver.SelectBy_ContentInspectionId(fldContentInspectionId
);
			return driver.Results;
		}

		/// <summary>
		/// Run ContentInspection_SelectBy_ContentInspectionId, and return results as a list of ContentInspectionRow.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of ContentInspectionRow.</returns>
		public static List<ContentInspectionContract> SelectBy_ContentInspectionIdNow(int fldContentInspectionId
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new ContentInspectionLogic();
			driver.SelectBy_ContentInspectionId(fldContentInspectionId
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run ContentInspection_SelectBy_ConfirmedByUserId, and return results as a list of ContentInspectionRow.
		/// </summary>
		/// <param name="fldConfirmedByUserId">Value for ConfirmedByUserId</param>
		/// <returns>A collection of ContentInspectionRow.</returns>
		public static List<ContentInspectionContract> SelectBy_ConfirmedByUserIdNow(int fldConfirmedByUserId
)
		{
			var driver = new ContentInspectionLogic();
			driver.SelectBy_ConfirmedByUserId(fldConfirmedByUserId
);
			return driver.Results;
		}

		/// <summary>
		/// Run ContentInspection_SelectBy_ConfirmedByUserId, and return results as a list of ContentInspectionRow.
		/// </summary>
		/// <param name="fldConfirmedByUserId">Value for ConfirmedByUserId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of ContentInspectionRow.</returns>
		public static List<ContentInspectionContract> SelectBy_ConfirmedByUserIdNow(int fldConfirmedByUserId
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new ContentInspectionLogic();
			driver.SelectBy_ConfirmedByUserId(fldConfirmedByUserId
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run ContentInspection_SelectBy_ProposedByUserId, and return results as a list of ContentInspectionRow.
		/// </summary>
		/// <param name="fldProposedByUserId">Value for ProposedByUserId</param>
		/// <returns>A collection of ContentInspectionRow.</returns>
		public static List<ContentInspectionContract> SelectBy_ProposedByUserIdNow(int fldProposedByUserId
)
		{
			var driver = new ContentInspectionLogic();
			driver.SelectBy_ProposedByUserId(fldProposedByUserId
);
			return driver.Results;
		}

		/// <summary>
		/// Run ContentInspection_SelectBy_ProposedByUserId, and return results as a list of ContentInspectionRow.
		/// </summary>
		/// <param name="fldProposedByUserId">Value for ProposedByUserId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of ContentInspectionRow.</returns>
		public static List<ContentInspectionContract> SelectBy_ProposedByUserIdNow(int fldProposedByUserId
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new ContentInspectionLogic();
			driver.SelectBy_ProposedByUserId(fldProposedByUserId
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Read all ContentInspection rows from the provided reader into the list structure of ContentInspectionRows
		/// </summary>
		/// <param name="reader">The result of running a sql command.</param>
		/// <returns>A populated ContentInspectionRows or an empty ContentInspectionRows if there are no results.</returns>
		public static List<ContentInspectionContract> ReadAllNow(SqlDataReader reader)
		{
			var driver = new ContentInspectionLogic();

			driver.ReadAll(reader);
			
			return driver.Results;
		}
		/// <summary>");
		/// Advance one, and read values into a ContentInspection
		/// </summary>
		/// <param name="reader">The result of running a sql command.</param>");
		/// <returns>A ContentInspection or null if there are no results.</returns>
		public static ContentInspectionContract ReadOneNow(SqlDataReader reader)
		{
			var driver = new ContentInspectionLogic();			
		    return driver.ReadOne(reader) ? driver.Results[0] : null;
		}
		/// <summary>
		/// Saves the row, either by inserting (when the identity key is null) or by updating (identity key has value).
		/// </summary>
		/// <param name="row">The data to save</param>
		/// <returns>The number of rows affected.</returns>
		public static int SaveNow(ContentInspectionContract row)
		{
			if(row.ContentInspectionId == null)
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
		public static int SaveNow(ContentInspectionContract row, SqlConnection connection, SqlTransaction transaction)
		{
			if(row.ContentInspectionId == null)
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
		public static int SaveAllNow(List<ContentInspectionContract> rows)
		{
			return (new ContentInspectionLogic()).SaveAll(rows);
		}

		/// <summary>
		/// Save the rows in bulk, uses the same connection (faster), in a provided transaction scrope.
		/// </summary>
		/// <param name="rows">The table rows to Save</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int SaveAllNow(List<ContentInspectionContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			return (new ContentInspectionLogic()).SaveAll(rows, connection, transaction);
		}        
	}
}