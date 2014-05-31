using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using VotingInfo.Database.Contracts;
using VotingInfo.Database.Contracts.Data;

///////////////////////////////////////////////////////////
//Do not modify this file. Use a partial class to extend.//
///////////////////////////////////////////////////////////
// This file contains static implementations of the OrganizationMetaDataLogic
// Add your own static methods by making a new partial class.
// You cannot override static methods, instead override the methods
// located in OrganizationMetaDataLogicBase by making a partial class of OrganizationMetaDataLogic
// and overriding the base methods.

namespace VotingInfo.Database.Logic.Data
{
	public partial class OrganizationMetaDataLogic
	{
		//Put your code in a separate file.  This is auto generated.
		/// <summary>
		/// Run OrganizationMetaData_Insert.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldOrganizationId">Value for OrganizationId</param>
		/// <param name="fldMetaDataId">Value for MetaDataId</param>
		/// <param name="fldMetaDataValue">Value for MetaDataValue</param>
		public static int? InsertNow(int fldContentInspectionId
, int fldOrganizationId
, int fldMetaDataId
, string fldMetaDataValue
)
		{
			return (new OrganizationMetaDataLogic()).Insert(fldContentInspectionId
, fldOrganizationId
, fldMetaDataId
, fldMetaDataValue
);
		}
		/// <summary>
		/// Run OrganizationMetaData_Insert.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldOrganizationId">Value for OrganizationId</param>
		/// <param name="fldMetaDataId">Value for MetaDataId</param>
		/// <param name="fldMetaDataValue">Value for MetaDataValue</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		public static int? InsertNow(int fldContentInspectionId
, int fldOrganizationId
, int fldMetaDataId
, string fldMetaDataValue
, SqlConnection connection, SqlTransaction transaction)
		{
			return (new OrganizationMetaDataLogic()).Insert(fldContentInspectionId
, fldOrganizationId
, fldMetaDataId
, fldMetaDataValue
, connection, transaction);
		}

		/// <summary>
		/// Insert by providing a populated data row container
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int InsertNow(OrganizationMetaDataContract row)
		{
			return (new OrganizationMetaDataLogic()).Insert(row);
		}

		/// <summary>
		/// Insert by providing a populated data contract
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int InsertNow(OrganizationMetaDataContract row, SqlConnection connection, SqlTransaction transaction)
		{
			return (new OrganizationMetaDataLogic()).Insert(row, connection, transaction);
		}

		/// <summary>
		/// Insert the rows in bulk, uses the same connection (faster).
		/// </summary>
		/// <param name="rows">The table rows to Insert</param>
		/// <returns>The number of rows affected.</returns>
		public static int InsertAllNow(List<OrganizationMetaDataContract> rows)
		{
			return (new OrganizationMetaDataLogic()).InsertAll(rows);
		}

		/// <summary>
		/// Insert the rows in bulk, uses the same connection (faster), in a provided transaction scrope.
		/// </summary>
		/// <param name="rows">The table rows to Insert</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int InsertAllNow(List<OrganizationMetaDataContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			return (new OrganizationMetaDataLogic()).InsertAll(rows, connection, transaction);
		}
		/// <summary>
		/// Run OrganizationMetaData_Update.
		/// </summary>
		/// <param name="fldOrganizationMetaDataId">Value for OrganizationMetaDataId</param>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldOrganizationId">Value for OrganizationId</param>
		/// <param name="fldMetaDataId">Value for MetaDataId</param>
		/// <param name="fldMetaDataValue">Value for MetaDataValue</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateNow(int fldOrganizationMetaDataId
, int fldContentInspectionId
, int fldOrganizationId
, int fldMetaDataId
, string fldMetaDataValue
)
		{
			return (new OrganizationMetaDataLogic()).Update(fldOrganizationMetaDataId
, fldContentInspectionId
, fldOrganizationId
, fldMetaDataId
, fldMetaDataValue
);
		}

		/// <summary>
		/// Run OrganizationMetaData_Update.
		/// </summary>
		/// <param name="fldOrganizationMetaDataId">Value for OrganizationMetaDataId</param>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldOrganizationId">Value for OrganizationId</param>
		/// <param name="fldMetaDataId">Value for MetaDataId</param>
		/// <param name="fldMetaDataValue">Value for MetaDataValue</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateNow(int fldOrganizationMetaDataId
, int fldContentInspectionId
, int fldOrganizationId
, int fldMetaDataId
, string fldMetaDataValue
, SqlConnection connection, SqlTransaction transaction)
		{
			return (new OrganizationMetaDataLogic()).Update(fldOrganizationMetaDataId
, fldContentInspectionId
, fldOrganizationId
, fldMetaDataId
, fldMetaDataValue
, connection, transaction);
		}
		/// <summary>
		/// Update by providing a populated data row container
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateNow(OrganizationMetaDataContract row)
		{
			return (new OrganizationMetaDataLogic()).Update(row);
		}

		/// <summary>
		/// Update by providing a populated data contract
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateNow(OrganizationMetaDataContract row, SqlConnection connection, SqlTransaction transaction)
		{
			return (new OrganizationMetaDataLogic()).Update(row, connection, transaction);
		}

		/// <summary>
		/// Update the rows in bulk, uses the same connection (faster).
		/// </summary>
		/// <param name="rows">The table rows to Update</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateAllNow(List<OrganizationMetaDataContract> rows)
		{
			return (new OrganizationMetaDataLogic()).UpdateAll(rows);
		}

		/// <summary>
		/// Update the rows in bulk, uses the same connection (faster), in a provided transaction scrope.
		/// </summary>
		/// <param name="rows">The table rows to Update</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateAllNow(List<OrganizationMetaDataContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			return (new OrganizationMetaDataLogic()).UpdateAll(rows, connection, transaction);
		}
		/// <summary>
		/// Run OrganizationMetaData_Delete.
		/// </summary>
		/// <param name="fldOrganizationMetaDataId">Value for OrganizationMetaDataId</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteNow(int fldOrganizationMetaDataId
)
		{
			return (new OrganizationMetaDataLogic()).Delete(fldOrganizationMetaDataId
);
		}

		/// <summary>
		/// Run OrganizationMetaData_Delete.
		/// </summary>
		/// <param name="fldOrganizationMetaDataId">Value for OrganizationMetaDataId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteNow(int fldOrganizationMetaDataId
, SqlConnection connection, SqlTransaction transaction)
		{
			return (new OrganizationMetaDataLogic()).Delete(fldOrganizationMetaDataId
, connection, transaction);
		}
		/// <summary>
		/// Delete by providing a populated data row container
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteNow(OrganizationMetaDataContract row)
		{
			return (new OrganizationMetaDataLogic()).Delete(row);
		}

		/// <summary>
		/// Delete by providing a populated data contract
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteNow(OrganizationMetaDataContract row, SqlConnection connection, SqlTransaction transaction)
		{
			return (new OrganizationMetaDataLogic()).Delete(row, connection, transaction);
		}

		/// <summary>
		/// Delete the rows in bulk, uses the same connection (faster).
		/// </summary>
		/// <param name="rows">The table rows to Delete</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteAllNow(List<OrganizationMetaDataContract> rows)
		{
			return (new OrganizationMetaDataLogic()).DeleteAll(rows);
		}

		/// <summary>
		/// Delete the rows in bulk, uses the same connection (faster), in a provided transaction scrope.
		/// </summary>
		/// <param name="rows">The table rows to Delete</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteAllNow(List<OrganizationMetaDataContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			return (new OrganizationMetaDataLogic()).DeleteAll(rows, connection, transaction);
		}
		/// <summary>
		/// Determine if the table contains a row with the existing values
		/// </summary>
		/// <param name="fldOrganizationMetaDataId">Value for OrganizationMetaDataId</param>
		/// <returns>True, if the values exist, or false.</returns>
		public static bool ExistsNow(int fldOrganizationMetaDataId
)
		{
			return (new OrganizationMetaDataLogic()).Exists(fldOrganizationMetaDataId
);
		}

		/// <summary>
		/// Determine if the table contains a row with the existing values
		/// </summary>
		/// <param name="fldOrganizationMetaDataId">Value for OrganizationMetaDataId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>True, if the values exist, or false.</returns>
		public static bool ExistsNow(int fldOrganizationMetaDataId
, SqlConnection connection, SqlTransaction transaction)
		{					
			return (new OrganizationMetaDataLogic()).Exists(fldOrganizationMetaDataId
, connection, transaction);
		}

		/// <summary>
		/// Run OrganizationMetaData_Search, and return results as a list of OrganizationMetaDataRow.
		/// </summary>
		/// <param name="fldMetaDataValue">Value for MetaDataValue</param>
		/// <returns>A collection of OrganizationMetaDataRow.</returns>
		public static List<OrganizationMetaDataContract> SearchNow(string fldMetaDataValue
)
		{
			var driver = new OrganizationMetaDataLogic();
			driver.Search(fldMetaDataValue
);
			return driver.Results;
		}

		/// <summary>
		/// Run OrganizationMetaData_Search, and return results as a list of OrganizationMetaDataRow.
		/// </summary>
		/// <param name="fldMetaDataValue">Value for MetaDataValue</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of OrganizationMetaDataRow.</returns>
		public static List<OrganizationMetaDataContract> SearchNow(string fldMetaDataValue
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new OrganizationMetaDataLogic();
			driver.Search(fldMetaDataValue
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run OrganizationMetaData_SelectAll, and return results as a list of OrganizationMetaDataRow.
		/// </summary>

		/// <returns>A collection of OrganizationMetaDataRow.</returns>
		public static List<OrganizationMetaDataContract> SelectAllNow()
		{			
			var driver = new OrganizationMetaDataLogic();
			driver.SelectAll();
			return driver.Results;
		}

		/// <summary>
		/// Run OrganizationMetaData_SelectAll, and return results as a list of OrganizationMetaDataRow.
		/// </summary>

		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of OrganizationMetaDataRow.</returns>
		public static List<OrganizationMetaDataContract> SelectAllNow(SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new OrganizationMetaDataLogic();
			driver.SelectAll(connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run OrganizationMetaData_SelectBy_OrganizationMetaDataId, and return results as a list of OrganizationMetaDataRow.
		/// </summary>
		/// <param name="fldOrganizationMetaDataId">Value for OrganizationMetaDataId</param>
		/// <returns>A collection of OrganizationMetaDataRow.</returns>
		public static List<OrganizationMetaDataContract> SelectBy_OrganizationMetaDataIdNow(int fldOrganizationMetaDataId
)
		{
			var driver = new OrganizationMetaDataLogic();
			driver.SelectBy_OrganizationMetaDataId(fldOrganizationMetaDataId
);
			return driver.Results;
		}

		/// <summary>
		/// Run OrganizationMetaData_SelectBy_OrganizationMetaDataId, and return results as a list of OrganizationMetaDataRow.
		/// </summary>
		/// <param name="fldOrganizationMetaDataId">Value for OrganizationMetaDataId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of OrganizationMetaDataRow.</returns>
		public static List<OrganizationMetaDataContract> SelectBy_OrganizationMetaDataIdNow(int fldOrganizationMetaDataId
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new OrganizationMetaDataLogic();
			driver.SelectBy_OrganizationMetaDataId(fldOrganizationMetaDataId
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run OrganizationMetaData_SelectBy_ContentInspectionId, and return results as a list of OrganizationMetaDataRow.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <returns>A collection of OrganizationMetaDataRow.</returns>
		public static List<OrganizationMetaDataContract> SelectBy_ContentInspectionIdNow(int fldContentInspectionId
)
		{
			var driver = new OrganizationMetaDataLogic();
			driver.SelectBy_ContentInspectionId(fldContentInspectionId
);
			return driver.Results;
		}

		/// <summary>
		/// Run OrganizationMetaData_SelectBy_ContentInspectionId, and return results as a list of OrganizationMetaDataRow.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of OrganizationMetaDataRow.</returns>
		public static List<OrganizationMetaDataContract> SelectBy_ContentInspectionIdNow(int fldContentInspectionId
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new OrganizationMetaDataLogic();
			driver.SelectBy_ContentInspectionId(fldContentInspectionId
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run OrganizationMetaData_SelectBy_OrganizationId, and return results as a list of OrganizationMetaDataRow.
		/// </summary>
		/// <param name="fldOrganizationId">Value for OrganizationId</param>
		/// <returns>A collection of OrganizationMetaDataRow.</returns>
		public static List<OrganizationMetaDataContract> SelectBy_OrganizationIdNow(int fldOrganizationId
)
		{
			var driver = new OrganizationMetaDataLogic();
			driver.SelectBy_OrganizationId(fldOrganizationId
);
			return driver.Results;
		}

		/// <summary>
		/// Run OrganizationMetaData_SelectBy_OrganizationId, and return results as a list of OrganizationMetaDataRow.
		/// </summary>
		/// <param name="fldOrganizationId">Value for OrganizationId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of OrganizationMetaDataRow.</returns>
		public static List<OrganizationMetaDataContract> SelectBy_OrganizationIdNow(int fldOrganizationId
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new OrganizationMetaDataLogic();
			driver.SelectBy_OrganizationId(fldOrganizationId
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run OrganizationMetaData_SelectBy_MetaDataId, and return results as a list of OrganizationMetaDataRow.
		/// </summary>
		/// <param name="fldMetaDataId">Value for MetaDataId</param>
		/// <returns>A collection of OrganizationMetaDataRow.</returns>
		public static List<OrganizationMetaDataContract> SelectBy_MetaDataIdNow(int fldMetaDataId
)
		{
			var driver = new OrganizationMetaDataLogic();
			driver.SelectBy_MetaDataId(fldMetaDataId
);
			return driver.Results;
		}

		/// <summary>
		/// Run OrganizationMetaData_SelectBy_MetaDataId, and return results as a list of OrganizationMetaDataRow.
		/// </summary>
		/// <param name="fldMetaDataId">Value for MetaDataId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of OrganizationMetaDataRow.</returns>
		public static List<OrganizationMetaDataContract> SelectBy_MetaDataIdNow(int fldMetaDataId
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new OrganizationMetaDataLogic();
			driver.SelectBy_MetaDataId(fldMetaDataId
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Read all OrganizationMetaData rows from the provided reader into the list structure of OrganizationMetaDataRows
		/// </summary>
		/// <param name="reader">The result of running a sql command.</param>
		/// <returns>A populated OrganizationMetaDataRows or an empty OrganizationMetaDataRows if there are no results.</returns>
		public static List<OrganizationMetaDataContract> ReadAllNow(SqlDataReader reader)
		{
			var driver = new OrganizationMetaDataLogic();

			driver.ReadAll(reader);
			
			return driver.Results;
		}
		/// <summary>");
		/// Advance one, and read values into a OrganizationMetaData
		/// </summary>
		/// <param name="reader">The result of running a sql command.</param>");
		/// <returns>A OrganizationMetaData or null if there are no results.</returns>
		public static OrganizationMetaDataContract ReadOneNow(SqlDataReader reader)
		{
			var driver = new OrganizationMetaDataLogic();			
		    return driver.ReadOne(reader) ? driver.Results[0] : null;
		}
		/// <summary>
		/// Saves the row, either by inserting (when the identity key is null) or by updating (identity key has value).
		/// </summary>
		/// <param name="row">The data to save</param>
		/// <returns>The number of rows affected.</returns>
		public static int SaveNow(OrganizationMetaDataContract row)
		{
			if(row.OrganizationMetaDataId == null)
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
		public static int SaveNow(OrganizationMetaDataContract row, SqlConnection connection, SqlTransaction transaction)
		{
			if(row.OrganizationMetaDataId == null)
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
		public static int SaveAllNow(List<OrganizationMetaDataContract> rows)
		{
			return (new OrganizationMetaDataLogic()).SaveAll(rows);
		}

		/// <summary>
		/// Save the rows in bulk, uses the same connection (faster), in a provided transaction scrope.
		/// </summary>
		/// <param name="rows">The table rows to Save</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int SaveAllNow(List<OrganizationMetaDataContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			return (new OrganizationMetaDataLogic()).SaveAll(rows, connection, transaction);
		}        
	}
}