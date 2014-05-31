using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using VotingInfo.Database.Contracts;
using VotingInfo.Database.Contracts.Data;

///////////////////////////////////////////////////////////
//Do not modify this file. Use a partial class to extend.//
///////////////////////////////////////////////////////////
// This file contains static implementations of the VoterLogic
// Add your own static methods by making a new partial class.
// You cannot override static methods, instead override the methods
// located in VoterLogicBase by making a partial class of VoterLogic
// and overriding the base methods.

namespace VotingInfo.Database.Logic.Data
{
	public partial class VoterLogic
	{
		//Put your code in a separate file.  This is auto generated.
		/// <summary>
		/// Run Voter_Insert.
		/// </summary>
		/// <param name="fldUserId">Value for UserId</param>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldLocationId">Value for LocationId</param>
		/// <param name="fldVoterName">Value for VoterName</param>
		/// <param name="fldPostalCode">Value for PostalCode</param>
		/// <param name="fldFavoriteOrganizationId">Value for FavoriteOrganizationId</param>
		public static int? InsertNow(int fldUserId
, int fldContentInspectionId
, int fldLocationId
, string fldVoterName
, string fldPostalCode
, int fldFavoriteOrganizationId
)
		{
			return (new VoterLogic()).Insert(fldUserId
, fldContentInspectionId
, fldLocationId
, fldVoterName
, fldPostalCode
, fldFavoriteOrganizationId
);
		}
		/// <summary>
		/// Run Voter_Insert.
		/// </summary>
		/// <param name="fldUserId">Value for UserId</param>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldLocationId">Value for LocationId</param>
		/// <param name="fldVoterName">Value for VoterName</param>
		/// <param name="fldPostalCode">Value for PostalCode</param>
		/// <param name="fldFavoriteOrganizationId">Value for FavoriteOrganizationId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		public static int? InsertNow(int fldUserId
, int fldContentInspectionId
, int fldLocationId
, string fldVoterName
, string fldPostalCode
, int fldFavoriteOrganizationId
, SqlConnection connection, SqlTransaction transaction)
		{
			return (new VoterLogic()).Insert(fldUserId
, fldContentInspectionId
, fldLocationId
, fldVoterName
, fldPostalCode
, fldFavoriteOrganizationId
, connection, transaction);
		}

		/// <summary>
		/// Insert by providing a populated data row container
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int InsertNow(VoterContract row)
		{
			return (new VoterLogic()).Insert(row);
		}

		/// <summary>
		/// Insert by providing a populated data contract
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int InsertNow(VoterContract row, SqlConnection connection, SqlTransaction transaction)
		{
			return (new VoterLogic()).Insert(row, connection, transaction);
		}

		/// <summary>
		/// Insert the rows in bulk, uses the same connection (faster).
		/// </summary>
		/// <param name="rows">The table rows to Insert</param>
		/// <returns>The number of rows affected.</returns>
		public static int InsertAllNow(List<VoterContract> rows)
		{
			return (new VoterLogic()).InsertAll(rows);
		}

		/// <summary>
		/// Insert the rows in bulk, uses the same connection (faster), in a provided transaction scrope.
		/// </summary>
		/// <param name="rows">The table rows to Insert</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int InsertAllNow(List<VoterContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			return (new VoterLogic()).InsertAll(rows, connection, transaction);
		}
		/// <summary>
		/// Run Voter_Update.
		/// </summary>
		/// <param name="fldVoterId">Value for VoterId</param>
		/// <param name="fldUserId">Value for UserId</param>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldLocationId">Value for LocationId</param>
		/// <param name="fldVoterName">Value for VoterName</param>
		/// <param name="fldPostalCode">Value for PostalCode</param>
		/// <param name="fldFavoriteOrganizationId">Value for FavoriteOrganizationId</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateNow(int fldVoterId
, int fldUserId
, int fldContentInspectionId
, int fldLocationId
, string fldVoterName
, string fldPostalCode
, int fldFavoriteOrganizationId
)
		{
			return (new VoterLogic()).Update(fldVoterId
, fldUserId
, fldContentInspectionId
, fldLocationId
, fldVoterName
, fldPostalCode
, fldFavoriteOrganizationId
);
		}

		/// <summary>
		/// Run Voter_Update.
		/// </summary>
		/// <param name="fldVoterId">Value for VoterId</param>
		/// <param name="fldUserId">Value for UserId</param>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldLocationId">Value for LocationId</param>
		/// <param name="fldVoterName">Value for VoterName</param>
		/// <param name="fldPostalCode">Value for PostalCode</param>
		/// <param name="fldFavoriteOrganizationId">Value for FavoriteOrganizationId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateNow(int fldVoterId
, int fldUserId
, int fldContentInspectionId
, int fldLocationId
, string fldVoterName
, string fldPostalCode
, int fldFavoriteOrganizationId
, SqlConnection connection, SqlTransaction transaction)
		{
			return (new VoterLogic()).Update(fldVoterId
, fldUserId
, fldContentInspectionId
, fldLocationId
, fldVoterName
, fldPostalCode
, fldFavoriteOrganizationId
, connection, transaction);
		}
		/// <summary>
		/// Update by providing a populated data row container
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateNow(VoterContract row)
		{
			return (new VoterLogic()).Update(row);
		}

		/// <summary>
		/// Update by providing a populated data contract
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateNow(VoterContract row, SqlConnection connection, SqlTransaction transaction)
		{
			return (new VoterLogic()).Update(row, connection, transaction);
		}

		/// <summary>
		/// Update the rows in bulk, uses the same connection (faster).
		/// </summary>
		/// <param name="rows">The table rows to Update</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateAllNow(List<VoterContract> rows)
		{
			return (new VoterLogic()).UpdateAll(rows);
		}

		/// <summary>
		/// Update the rows in bulk, uses the same connection (faster), in a provided transaction scrope.
		/// </summary>
		/// <param name="rows">The table rows to Update</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateAllNow(List<VoterContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			return (new VoterLogic()).UpdateAll(rows, connection, transaction);
		}
		/// <summary>
		/// Run Voter_Delete.
		/// </summary>
		/// <param name="fldVoterId">Value for VoterId</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteNow(int fldVoterId
)
		{
			return (new VoterLogic()).Delete(fldVoterId
);
		}

		/// <summary>
		/// Run Voter_Delete.
		/// </summary>
		/// <param name="fldVoterId">Value for VoterId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteNow(int fldVoterId
, SqlConnection connection, SqlTransaction transaction)
		{
			return (new VoterLogic()).Delete(fldVoterId
, connection, transaction);
		}
		/// <summary>
		/// Delete by providing a populated data row container
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteNow(VoterContract row)
		{
			return (new VoterLogic()).Delete(row);
		}

		/// <summary>
		/// Delete by providing a populated data contract
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteNow(VoterContract row, SqlConnection connection, SqlTransaction transaction)
		{
			return (new VoterLogic()).Delete(row, connection, transaction);
		}

		/// <summary>
		/// Delete the rows in bulk, uses the same connection (faster).
		/// </summary>
		/// <param name="rows">The table rows to Delete</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteAllNow(List<VoterContract> rows)
		{
			return (new VoterLogic()).DeleteAll(rows);
		}

		/// <summary>
		/// Delete the rows in bulk, uses the same connection (faster), in a provided transaction scrope.
		/// </summary>
		/// <param name="rows">The table rows to Delete</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteAllNow(List<VoterContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			return (new VoterLogic()).DeleteAll(rows, connection, transaction);
		}
		/// <summary>
		/// Determine if the table contains a row with the existing values
		/// </summary>
		/// <param name="fldVoterId">Value for VoterId</param>
		/// <returns>True, if the values exist, or false.</returns>
		public static bool ExistsNow(int fldVoterId
)
		{
			return (new VoterLogic()).Exists(fldVoterId
);
		}

		/// <summary>
		/// Determine if the table contains a row with the existing values
		/// </summary>
		/// <param name="fldVoterId">Value for VoterId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>True, if the values exist, or false.</returns>
		public static bool ExistsNow(int fldVoterId
, SqlConnection connection, SqlTransaction transaction)
		{					
			return (new VoterLogic()).Exists(fldVoterId
, connection, transaction);
		}

		/// <summary>
		/// Run Voter_Search, and return results as a list of VoterRow.
		/// </summary>
		/// <param name="fldVoterName">Value for VoterName</param>
		/// <param name="fldPostalCode">Value for PostalCode</param>
		/// <returns>A collection of VoterRow.</returns>
		public static List<VoterContract> SearchNow(string fldVoterName
, string fldPostalCode
)
		{
			var driver = new VoterLogic();
			driver.Search(fldVoterName
, fldPostalCode
);
			return driver.Results;
		}

		/// <summary>
		/// Run Voter_Search, and return results as a list of VoterRow.
		/// </summary>
		/// <param name="fldVoterName">Value for VoterName</param>
		/// <param name="fldPostalCode">Value for PostalCode</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of VoterRow.</returns>
		public static List<VoterContract> SearchNow(string fldVoterName
, string fldPostalCode
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new VoterLogic();
			driver.Search(fldVoterName
, fldPostalCode
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run Voter_SelectAll, and return results as a list of VoterRow.
		/// </summary>

		/// <returns>A collection of VoterRow.</returns>
		public static List<VoterContract> SelectAllNow()
		{			
			var driver = new VoterLogic();
			driver.SelectAll();
			return driver.Results;
		}

		/// <summary>
		/// Run Voter_SelectAll, and return results as a list of VoterRow.
		/// </summary>

		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of VoterRow.</returns>
		public static List<VoterContract> SelectAllNow(SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new VoterLogic();
			driver.SelectAll(connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run Voter_List, and return results as a list.
		/// </summary>
		/// <param name="fldVoterName">Value for VoterName</param>
		/// <returns>A collection of __ListItemRow.</returns>
		public static List<ListItemContract> ListNow(string fldVoterName
)
		{
			return (new VoterLogic()).List(fldVoterName
);
		}

		/// <summary>
		/// Run Voter_List, and return results as a list.
		/// </summary>
		/// <param name="fldVoterName">Value for VoterName</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of __ListItemRow.</returns>
		public static List<ListItemContract> ListNow(string fldVoterName
, SqlConnection connection, SqlTransaction transaction)
		{
			return (new VoterLogic()).List(fldVoterName
, connection, transaction);
		}

		/// <summary>
		/// Run Voter_SelectBy_VoterId, and return results as a list of VoterRow.
		/// </summary>
		/// <param name="fldVoterId">Value for VoterId</param>
		/// <returns>A collection of VoterRow.</returns>
		public static List<VoterContract> SelectBy_VoterIdNow(int fldVoterId
)
		{
			var driver = new VoterLogic();
			driver.SelectBy_VoterId(fldVoterId
);
			return driver.Results;
		}

		/// <summary>
		/// Run Voter_SelectBy_VoterId, and return results as a list of VoterRow.
		/// </summary>
		/// <param name="fldVoterId">Value for VoterId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of VoterRow.</returns>
		public static List<VoterContract> SelectBy_VoterIdNow(int fldVoterId
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new VoterLogic();
			driver.SelectBy_VoterId(fldVoterId
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run Voter_SelectBy_UserId, and return results as a list of VoterRow.
		/// </summary>
		/// <param name="fldUserId">Value for UserId</param>
		/// <returns>A collection of VoterRow.</returns>
		public static List<VoterContract> SelectBy_UserIdNow(int fldUserId
)
		{
			var driver = new VoterLogic();
			driver.SelectBy_UserId(fldUserId
);
			return driver.Results;
		}

		/// <summary>
		/// Run Voter_SelectBy_UserId, and return results as a list of VoterRow.
		/// </summary>
		/// <param name="fldUserId">Value for UserId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of VoterRow.</returns>
		public static List<VoterContract> SelectBy_UserIdNow(int fldUserId
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new VoterLogic();
			driver.SelectBy_UserId(fldUserId
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run Voter_SelectBy_ContentInspectionId, and return results as a list of VoterRow.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <returns>A collection of VoterRow.</returns>
		public static List<VoterContract> SelectBy_ContentInspectionIdNow(int fldContentInspectionId
)
		{
			var driver = new VoterLogic();
			driver.SelectBy_ContentInspectionId(fldContentInspectionId
);
			return driver.Results;
		}

		/// <summary>
		/// Run Voter_SelectBy_ContentInspectionId, and return results as a list of VoterRow.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of VoterRow.</returns>
		public static List<VoterContract> SelectBy_ContentInspectionIdNow(int fldContentInspectionId
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new VoterLogic();
			driver.SelectBy_ContentInspectionId(fldContentInspectionId
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run Voter_SelectBy_LocationId, and return results as a list of VoterRow.
		/// </summary>
		/// <param name="fldLocationId">Value for LocationId</param>
		/// <returns>A collection of VoterRow.</returns>
		public static List<VoterContract> SelectBy_LocationIdNow(int fldLocationId
)
		{
			var driver = new VoterLogic();
			driver.SelectBy_LocationId(fldLocationId
);
			return driver.Results;
		}

		/// <summary>
		/// Run Voter_SelectBy_LocationId, and return results as a list of VoterRow.
		/// </summary>
		/// <param name="fldLocationId">Value for LocationId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of VoterRow.</returns>
		public static List<VoterContract> SelectBy_LocationIdNow(int fldLocationId
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new VoterLogic();
			driver.SelectBy_LocationId(fldLocationId
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run Voter_SelectBy_FavoriteOrganizationId, and return results as a list of VoterRow.
		/// </summary>
		/// <param name="fldFavoriteOrganizationId">Value for FavoriteOrganizationId</param>
		/// <returns>A collection of VoterRow.</returns>
		public static List<VoterContract> SelectBy_FavoriteOrganizationIdNow(int fldFavoriteOrganizationId
)
		{
			var driver = new VoterLogic();
			driver.SelectBy_FavoriteOrganizationId(fldFavoriteOrganizationId
);
			return driver.Results;
		}

		/// <summary>
		/// Run Voter_SelectBy_FavoriteOrganizationId, and return results as a list of VoterRow.
		/// </summary>
		/// <param name="fldFavoriteOrganizationId">Value for FavoriteOrganizationId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of VoterRow.</returns>
		public static List<VoterContract> SelectBy_FavoriteOrganizationIdNow(int fldFavoriteOrganizationId
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new VoterLogic();
			driver.SelectBy_FavoriteOrganizationId(fldFavoriteOrganizationId
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Read all Voter rows from the provided reader into the list structure of VoterRows
		/// </summary>
		/// <param name="reader">The result of running a sql command.</param>
		/// <returns>A populated VoterRows or an empty VoterRows if there are no results.</returns>
		public static List<VoterContract> ReadAllNow(SqlDataReader reader)
		{
			var driver = new VoterLogic();

			driver.ReadAll(reader);
			
			return driver.Results;
		}
		/// <summary>");
		/// Advance one, and read values into a Voter
		/// </summary>
		/// <param name="reader">The result of running a sql command.</param>");
		/// <returns>A Voter or null if there are no results.</returns>
		public static VoterContract ReadOneNow(SqlDataReader reader)
		{
			var driver = new VoterLogic();			
		    return driver.ReadOne(reader) ? driver.Results[0] : null;
		}
		/// <summary>
		/// Saves the row, either by inserting (when the identity key is null) or by updating (identity key has value).
		/// </summary>
		/// <param name="row">The data to save</param>
		/// <returns>The number of rows affected.</returns>
		public static int SaveNow(VoterContract row)
		{
			if(row.VoterId == null)
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
		public static int SaveNow(VoterContract row, SqlConnection connection, SqlTransaction transaction)
		{
			if(row.VoterId == null)
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
		public static int SaveAllNow(List<VoterContract> rows)
		{
			return (new VoterLogic()).SaveAll(rows);
		}

		/// <summary>
		/// Save the rows in bulk, uses the same connection (faster), in a provided transaction scrope.
		/// </summary>
		/// <param name="rows">The table rows to Save</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int SaveAllNow(List<VoterContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			return (new VoterLogic()).SaveAll(rows, connection, transaction);
		}        
	}
}