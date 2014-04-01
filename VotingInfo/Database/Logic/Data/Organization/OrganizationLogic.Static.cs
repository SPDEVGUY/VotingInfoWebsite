using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using VotingInfo.Database.Contracts;
using VotingInfo.Database.Contracts.Data;

///////////////////////////////////////////////////////////
//Do not modify this file. Use a partial class to extend.//
///////////////////////////////////////////////////////////
// This file contains static implementations of the OrganizationLogic
// Add your own static methods by making a new partial class.
// You cannot override static methods, instead override the methods
// located in OrganizationLogicBase by making a partial class of OrganizationLogic
// and overriding the base methods.

namespace VotingInfo.Database.Logic.Data
{
	public partial class OrganizationLogic
	{
		//Put your code in a separate file.  This is auto generated.
		/// <summary>
		/// Run Organization_Insert.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldOrganizationName">Value for OrganizationName</param>
		public static int? InsertNow(int fldContentInspectionId
, string fldOrganizationName
)
		{
			return (new OrganizationLogic()).Insert(fldContentInspectionId
, fldOrganizationName
);
		}
		/// <summary>
		/// Run Organization_Insert.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldOrganizationName">Value for OrganizationName</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		public static int? InsertNow(int fldContentInspectionId
, string fldOrganizationName
, SqlConnection connection, SqlTransaction transaction)
		{
			return (new OrganizationLogic()).Insert(fldContentInspectionId
, fldOrganizationName
, connection, transaction);
		}

		/// <summary>
		/// Insert by providing a populated data row container
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int InsertNow(OrganizationContract row)
		{
			return (new OrganizationLogic()).Insert(row);
		}

		/// <summary>
		/// Insert by providing a populated data contract
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int InsertNow(OrganizationContract row, SqlConnection connection, SqlTransaction transaction)
		{
			return (new OrganizationLogic()).Insert(row, connection, transaction);
		}

		/// <summary>
		/// Insert the rows in bulk, uses the same connection (faster).
		/// </summary>
		/// <param name="rows">The table rows to Insert</param>
		/// <returns>The number of rows affected.</returns>
		public static int InsertAllNow(List<OrganizationContract> rows)
		{
			return (new OrganizationLogic()).InsertAll(rows);
		}

		/// <summary>
		/// Insert the rows in bulk, uses the same connection (faster), in a provided transaction scrope.
		/// </summary>
		/// <param name="rows">The table rows to Insert</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int InsertAllNow(List<OrganizationContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			return (new OrganizationLogic()).InsertAll(rows, connection, transaction);
		}
		/// <summary>
		/// Run Organization_Update.
		/// </summary>
		/// <param name="fldOrganizationId">Value for OrganizationId</param>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldOrganizationName">Value for OrganizationName</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateNow(int fldOrganizationId
, int fldContentInspectionId
, string fldOrganizationName
)
		{
			return (new OrganizationLogic()).Update(fldOrganizationId
, fldContentInspectionId
, fldOrganizationName
);
		}

		/// <summary>
		/// Run Organization_Update.
		/// </summary>
		/// <param name="fldOrganizationId">Value for OrganizationId</param>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldOrganizationName">Value for OrganizationName</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateNow(int fldOrganizationId
, int fldContentInspectionId
, string fldOrganizationName
, SqlConnection connection, SqlTransaction transaction)
		{
			return (new OrganizationLogic()).Update(fldOrganizationId
, fldContentInspectionId
, fldOrganizationName
, connection, transaction);
		}
		/// <summary>
		/// Update by providing a populated data row container
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateNow(OrganizationContract row)
		{
			return (new OrganizationLogic()).Update(row);
		}

		/// <summary>
		/// Update by providing a populated data contract
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateNow(OrganizationContract row, SqlConnection connection, SqlTransaction transaction)
		{
			return (new OrganizationLogic()).Update(row, connection, transaction);
		}

		/// <summary>
		/// Update the rows in bulk, uses the same connection (faster).
		/// </summary>
		/// <param name="rows">The table rows to Update</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateAllNow(List<OrganizationContract> rows)
		{
			return (new OrganizationLogic()).UpdateAll(rows);
		}

		/// <summary>
		/// Update the rows in bulk, uses the same connection (faster), in a provided transaction scrope.
		/// </summary>
		/// <param name="rows">The table rows to Update</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateAllNow(List<OrganizationContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			return (new OrganizationLogic()).UpdateAll(rows, connection, transaction);
		}
		/// <summary>
		/// Run Organization_Delete.
		/// </summary>
		/// <param name="fldOrganizationId">Value for OrganizationId</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteNow(int fldOrganizationId
)
		{
			return (new OrganizationLogic()).Delete(fldOrganizationId
);
		}

		/// <summary>
		/// Run Organization_Delete.
		/// </summary>
		/// <param name="fldOrganizationId">Value for OrganizationId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteNow(int fldOrganizationId
, SqlConnection connection, SqlTransaction transaction)
		{
			return (new OrganizationLogic()).Delete(fldOrganizationId
, connection, transaction);
		}
		/// <summary>
		/// Delete by providing a populated data row container
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteNow(OrganizationContract row)
		{
			return (new OrganizationLogic()).Delete(row);
		}

		/// <summary>
		/// Delete by providing a populated data contract
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteNow(OrganizationContract row, SqlConnection connection, SqlTransaction transaction)
		{
			return (new OrganizationLogic()).Delete(row, connection, transaction);
		}

		/// <summary>
		/// Delete the rows in bulk, uses the same connection (faster).
		/// </summary>
		/// <param name="rows">The table rows to Delete</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteAllNow(List<OrganizationContract> rows)
		{
			return (new OrganizationLogic()).DeleteAll(rows);
		}

		/// <summary>
		/// Delete the rows in bulk, uses the same connection (faster), in a provided transaction scrope.
		/// </summary>
		/// <param name="rows">The table rows to Delete</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteAllNow(List<OrganizationContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			return (new OrganizationLogic()).DeleteAll(rows, connection, transaction);
		}
		/// <summary>
		/// Determine if the table contains a row with the existing values
		/// </summary>
		/// <param name="fldOrganizationId">Value for OrganizationId</param>
		/// <returns>True, if the values exist, or false.</returns>
		public static bool ExistsNow(int fldOrganizationId
)
		{
			return (new OrganizationLogic()).Exists(fldOrganizationId
);
		}

		/// <summary>
		/// Determine if the table contains a row with the existing values
		/// </summary>
		/// <param name="fldOrganizationId">Value for OrganizationId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>True, if the values exist, or false.</returns>
		public static bool ExistsNow(int fldOrganizationId
, SqlConnection connection, SqlTransaction transaction)
		{					
			return (new OrganizationLogic()).Exists(fldOrganizationId
, connection, transaction);
		}

		/// <summary>
		/// Run Organization_Search, and return results as a list of OrganizationRow.
		/// </summary>
		/// <param name="fldOrganizationName">Value for OrganizationName</param>
		/// <returns>A collection of OrganizationRow.</returns>
		public static List<OrganizationContract> SearchNow(string fldOrganizationName
)
		{
			var driver = new OrganizationLogic();
			driver.Search(fldOrganizationName
);
			return driver.Results;
		}

		/// <summary>
		/// Run Organization_Search, and return results as a list of OrganizationRow.
		/// </summary>
		/// <param name="fldOrganizationName">Value for OrganizationName</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of OrganizationRow.</returns>
		public static List<OrganizationContract> SearchNow(string fldOrganizationName
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new OrganizationLogic();
			driver.Search(fldOrganizationName
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run Organization_SelectAll, and return results as a list of OrganizationRow.
		/// </summary>

		/// <returns>A collection of OrganizationRow.</returns>
		public static List<OrganizationContract> SelectAllNow()
		{			
			var driver = new OrganizationLogic();
			driver.SelectAll();
			return driver.Results;
		}

		/// <summary>
		/// Run Organization_SelectAll, and return results as a list of OrganizationRow.
		/// </summary>

		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of OrganizationRow.</returns>
		public static List<OrganizationContract> SelectAllNow(SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new OrganizationLogic();
			driver.SelectAll(connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run Organization_List, and return results as a list.
		/// </summary>
		/// <param name="fldOrganizationName">Value for OrganizationName</param>
		/// <returns>A collection of __ListItemRow.</returns>
		public static List<ListItemContract> ListNow(string fldOrganizationName
)
		{
			return (new OrganizationLogic()).List(fldOrganizationName
);
		}

		/// <summary>
		/// Run Organization_List, and return results as a list.
		/// </summary>
		/// <param name="fldOrganizationName">Value for OrganizationName</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of __ListItemRow.</returns>
		public static List<ListItemContract> ListNow(string fldOrganizationName
, SqlConnection connection, SqlTransaction transaction)
		{
			return (new OrganizationLogic()).List(fldOrganizationName
, connection, transaction);
		}

		/// <summary>
		/// Run Organization_SelectBy_OrganizationId, and return results as a list of OrganizationRow.
		/// </summary>
		/// <param name="fldOrganizationId">Value for OrganizationId</param>
		/// <returns>A collection of OrganizationRow.</returns>
		public static List<OrganizationContract> SelectBy_OrganizationIdNow(int fldOrganizationId
)
		{
			var driver = new OrganizationLogic();
			driver.SelectBy_OrganizationId(fldOrganizationId
);
			return driver.Results;
		}

		/// <summary>
		/// Run Organization_SelectBy_OrganizationId, and return results as a list of OrganizationRow.
		/// </summary>
		/// <param name="fldOrganizationId">Value for OrganizationId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of OrganizationRow.</returns>
		public static List<OrganizationContract> SelectBy_OrganizationIdNow(int fldOrganizationId
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new OrganizationLogic();
			driver.SelectBy_OrganizationId(fldOrganizationId
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run Organization_SelectBy_ContentInspectionId, and return results as a list of OrganizationRow.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <returns>A collection of OrganizationRow.</returns>
		public static List<OrganizationContract> SelectBy_ContentInspectionIdNow(int fldContentInspectionId
)
		{
			var driver = new OrganizationLogic();
			driver.SelectBy_ContentInspectionId(fldContentInspectionId
);
			return driver.Results;
		}

		/// <summary>
		/// Run Organization_SelectBy_ContentInspectionId, and return results as a list of OrganizationRow.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of OrganizationRow.</returns>
		public static List<OrganizationContract> SelectBy_ContentInspectionIdNow(int fldContentInspectionId
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new OrganizationLogic();
			driver.SelectBy_ContentInspectionId(fldContentInspectionId
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Read all Organization rows from the provided reader into the list structure of OrganizationRows
		/// </summary>
		/// <param name="reader">The result of running a sql command.</param>
		/// <returns>A populated OrganizationRows or an empty OrganizationRows if there are no results.</returns>
		public static List<OrganizationContract> ReadAllNow(SqlDataReader reader)
		{
			var driver = new OrganizationLogic();

			driver.ReadAll(reader);
			
			return driver.Results;
		}
		/// <summary>");
		/// Advance one, and read values into a Organization
		/// </summary>
		/// <param name="reader">The result of running a sql command.</param>");
		/// <returns>A Organization or null if there are no results.</returns>
		public static OrganizationContract ReadOneNow(SqlDataReader reader)
		{
			var driver = new OrganizationLogic();			
		    return driver.ReadOne(reader) ? driver.Results[0] : null;
		}
		/// <summary>
		/// Saves the row, either by inserting (when the identity key is null) or by updating (identity key has value).
		/// </summary>
		/// <param name="row">The data to save</param>
		/// <returns>The number of rows affected.</returns>
		public static int SaveNow(OrganizationContract row)
		{
			if(row.OrganizationId == null)
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
		public static int SaveNow(OrganizationContract row, SqlConnection connection, SqlTransaction transaction)
		{
			if(row.OrganizationId == null)
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
		public static int SaveAllNow(List<OrganizationContract> rows)
		{
			return (new OrganizationLogic()).SaveAll(rows);
		}

		/// <summary>
		/// Save the rows in bulk, uses the same connection (faster), in a provided transaction scrope.
		/// </summary>
		/// <param name="rows">The table rows to Save</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int SaveAllNow(List<OrganizationContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			return (new OrganizationLogic()).SaveAll(rows, connection, transaction);
		}        
	}
}