using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using VotingInfo.Database.Contracts;
using VotingInfo.Database.Contracts.Data;

///////////////////////////////////////////////////////////
//Do not modify this file. Use a partial class to extend.//
///////////////////////////////////////////////////////////
// This file contains static implementations of the MetaDataLogic
// Add your own static methods by making a new partial class.
// You cannot override static methods, instead override the methods
// located in MetaDataLogicBase by making a partial class of MetaDataLogic
// and overriding the base methods.

namespace VotingInfo.Database.Logic.Data
{
	public partial class MetaDataLogic
	{
		//Put your code in a separate file.  This is auto generated.
		/// <summary>
		/// Run MetaData_Insert.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldMetaDataName">Value for MetaDataName</param>
		/// <param name="fldIsRequired">Value for IsRequired</param>
		/// <param name="fldAppliesAtAllLevels">Value for AppliesAtAllLevels</param>
		/// <param name="fldAppliesToCandidates">Value for AppliesToCandidates</param>
		/// <param name="fldAppliesToOrganizations">Value for AppliesToOrganizations</param>
		public static int? InsertNow(int fldContentInspectionId
, string fldMetaDataName
, bool fldIsRequired
, bool fldAppliesAtAllLevels
, bool fldAppliesToCandidates
, bool fldAppliesToOrganizations
)
		{
			return (new MetaDataLogic()).Insert(fldContentInspectionId
, fldMetaDataName
, fldIsRequired
, fldAppliesAtAllLevels
, fldAppliesToCandidates
, fldAppliesToOrganizations
);
		}
		/// <summary>
		/// Run MetaData_Insert.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldMetaDataName">Value for MetaDataName</param>
		/// <param name="fldIsRequired">Value for IsRequired</param>
		/// <param name="fldAppliesAtAllLevels">Value for AppliesAtAllLevels</param>
		/// <param name="fldAppliesToCandidates">Value for AppliesToCandidates</param>
		/// <param name="fldAppliesToOrganizations">Value for AppliesToOrganizations</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		public static int? InsertNow(int fldContentInspectionId
, string fldMetaDataName
, bool fldIsRequired
, bool fldAppliesAtAllLevels
, bool fldAppliesToCandidates
, bool fldAppliesToOrganizations
, SqlConnection connection, SqlTransaction transaction)
		{
			return (new MetaDataLogic()).Insert(fldContentInspectionId
, fldMetaDataName
, fldIsRequired
, fldAppliesAtAllLevels
, fldAppliesToCandidates
, fldAppliesToOrganizations
, connection, transaction);
		}

		/// <summary>
		/// Insert by providing a populated data row container
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int InsertNow(MetaDataContract row)
		{
			return (new MetaDataLogic()).Insert(row);
		}

		/// <summary>
		/// Insert by providing a populated data contract
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int InsertNow(MetaDataContract row, SqlConnection connection, SqlTransaction transaction)
		{
			return (new MetaDataLogic()).Insert(row, connection, transaction);
		}

		/// <summary>
		/// Insert the rows in bulk, uses the same connection (faster).
		/// </summary>
		/// <param name="rows">The table rows to Insert</param>
		/// <returns>The number of rows affected.</returns>
		public static int InsertAllNow(List<MetaDataContract> rows)
		{
			return (new MetaDataLogic()).InsertAll(rows);
		}

		/// <summary>
		/// Insert the rows in bulk, uses the same connection (faster), in a provided transaction scrope.
		/// </summary>
		/// <param name="rows">The table rows to Insert</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int InsertAllNow(List<MetaDataContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			return (new MetaDataLogic()).InsertAll(rows, connection, transaction);
		}
		/// <summary>
		/// Run MetaData_Update.
		/// </summary>
		/// <param name="fldMetaDataId">Value for MetaDataId</param>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldMetaDataName">Value for MetaDataName</param>
		/// <param name="fldIsRequired">Value for IsRequired</param>
		/// <param name="fldAppliesAtAllLevels">Value for AppliesAtAllLevels</param>
		/// <param name="fldAppliesToCandidates">Value for AppliesToCandidates</param>
		/// <param name="fldAppliesToOrganizations">Value for AppliesToOrganizations</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateNow(int fldMetaDataId
, int fldContentInspectionId
, string fldMetaDataName
, bool fldIsRequired
, bool fldAppliesAtAllLevels
, bool fldAppliesToCandidates
, bool fldAppliesToOrganizations
)
		{
			return (new MetaDataLogic()).Update(fldMetaDataId
, fldContentInspectionId
, fldMetaDataName
, fldIsRequired
, fldAppliesAtAllLevels
, fldAppliesToCandidates
, fldAppliesToOrganizations
);
		}

		/// <summary>
		/// Run MetaData_Update.
		/// </summary>
		/// <param name="fldMetaDataId">Value for MetaDataId</param>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldMetaDataName">Value for MetaDataName</param>
		/// <param name="fldIsRequired">Value for IsRequired</param>
		/// <param name="fldAppliesAtAllLevels">Value for AppliesAtAllLevels</param>
		/// <param name="fldAppliesToCandidates">Value for AppliesToCandidates</param>
		/// <param name="fldAppliesToOrganizations">Value for AppliesToOrganizations</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateNow(int fldMetaDataId
, int fldContentInspectionId
, string fldMetaDataName
, bool fldIsRequired
, bool fldAppliesAtAllLevels
, bool fldAppliesToCandidates
, bool fldAppliesToOrganizations
, SqlConnection connection, SqlTransaction transaction)
		{
			return (new MetaDataLogic()).Update(fldMetaDataId
, fldContentInspectionId
, fldMetaDataName
, fldIsRequired
, fldAppliesAtAllLevels
, fldAppliesToCandidates
, fldAppliesToOrganizations
, connection, transaction);
		}
		/// <summary>
		/// Update by providing a populated data row container
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateNow(MetaDataContract row)
		{
			return (new MetaDataLogic()).Update(row);
		}

		/// <summary>
		/// Update by providing a populated data contract
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateNow(MetaDataContract row, SqlConnection connection, SqlTransaction transaction)
		{
			return (new MetaDataLogic()).Update(row, connection, transaction);
		}

		/// <summary>
		/// Update the rows in bulk, uses the same connection (faster).
		/// </summary>
		/// <param name="rows">The table rows to Update</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateAllNow(List<MetaDataContract> rows)
		{
			return (new MetaDataLogic()).UpdateAll(rows);
		}

		/// <summary>
		/// Update the rows in bulk, uses the same connection (faster), in a provided transaction scrope.
		/// </summary>
		/// <param name="rows">The table rows to Update</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateAllNow(List<MetaDataContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			return (new MetaDataLogic()).UpdateAll(rows, connection, transaction);
		}
		/// <summary>
		/// Run MetaData_Delete.
		/// </summary>
		/// <param name="fldMetaDataId">Value for MetaDataId</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteNow(int fldMetaDataId
)
		{
			return (new MetaDataLogic()).Delete(fldMetaDataId
);
		}

		/// <summary>
		/// Run MetaData_Delete.
		/// </summary>
		/// <param name="fldMetaDataId">Value for MetaDataId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteNow(int fldMetaDataId
, SqlConnection connection, SqlTransaction transaction)
		{
			return (new MetaDataLogic()).Delete(fldMetaDataId
, connection, transaction);
		}
		/// <summary>
		/// Delete by providing a populated data row container
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteNow(MetaDataContract row)
		{
			return (new MetaDataLogic()).Delete(row);
		}

		/// <summary>
		/// Delete by providing a populated data contract
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteNow(MetaDataContract row, SqlConnection connection, SqlTransaction transaction)
		{
			return (new MetaDataLogic()).Delete(row, connection, transaction);
		}

		/// <summary>
		/// Delete the rows in bulk, uses the same connection (faster).
		/// </summary>
		/// <param name="rows">The table rows to Delete</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteAllNow(List<MetaDataContract> rows)
		{
			return (new MetaDataLogic()).DeleteAll(rows);
		}

		/// <summary>
		/// Delete the rows in bulk, uses the same connection (faster), in a provided transaction scrope.
		/// </summary>
		/// <param name="rows">The table rows to Delete</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteAllNow(List<MetaDataContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			return (new MetaDataLogic()).DeleteAll(rows, connection, transaction);
		}
		/// <summary>
		/// Determine if the table contains a row with the existing values
		/// </summary>
		/// <param name="fldMetaDataId">Value for MetaDataId</param>
		/// <returns>True, if the values exist, or false.</returns>
		public static bool ExistsNow(int fldMetaDataId
)
		{
			return (new MetaDataLogic()).Exists(fldMetaDataId
);
		}

		/// <summary>
		/// Determine if the table contains a row with the existing values
		/// </summary>
		/// <param name="fldMetaDataId">Value for MetaDataId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>True, if the values exist, or false.</returns>
		public static bool ExistsNow(int fldMetaDataId
, SqlConnection connection, SqlTransaction transaction)
		{					
			return (new MetaDataLogic()).Exists(fldMetaDataId
, connection, transaction);
		}

		/// <summary>
		/// Run MetaData_Search, and return results as a list of MetaDataRow.
		/// </summary>
		/// <param name="fldMetaDataName">Value for MetaDataName</param>
		/// <returns>A collection of MetaDataRow.</returns>
		public static List<MetaDataContract> SearchNow(string fldMetaDataName
)
		{
			var driver = new MetaDataLogic();
			driver.Search(fldMetaDataName
);
			return driver.Results;
		}

		/// <summary>
		/// Run MetaData_Search, and return results as a list of MetaDataRow.
		/// </summary>
		/// <param name="fldMetaDataName">Value for MetaDataName</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of MetaDataRow.</returns>
		public static List<MetaDataContract> SearchNow(string fldMetaDataName
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new MetaDataLogic();
			driver.Search(fldMetaDataName
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run MetaData_SelectAll, and return results as a list of MetaDataRow.
		/// </summary>

		/// <returns>A collection of MetaDataRow.</returns>
		public static List<MetaDataContract> SelectAllNow()
		{			
			var driver = new MetaDataLogic();
			driver.SelectAll();
			return driver.Results;
		}

		/// <summary>
		/// Run MetaData_SelectAll, and return results as a list of MetaDataRow.
		/// </summary>

		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of MetaDataRow.</returns>
		public static List<MetaDataContract> SelectAllNow(SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new MetaDataLogic();
			driver.SelectAll(connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run MetaData_List, and return results as a list.
		/// </summary>
		/// <param name="fldMetaDataName">Value for MetaDataName</param>
		/// <returns>A collection of __ListItemRow.</returns>
		public static List<ListItemContract> ListNow(string fldMetaDataName
)
		{
			return (new MetaDataLogic()).List(fldMetaDataName
);
		}

		/// <summary>
		/// Run MetaData_List, and return results as a list.
		/// </summary>
		/// <param name="fldMetaDataName">Value for MetaDataName</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of __ListItemRow.</returns>
		public static List<ListItemContract> ListNow(string fldMetaDataName
, SqlConnection connection, SqlTransaction transaction)
		{
			return (new MetaDataLogic()).List(fldMetaDataName
, connection, transaction);
		}

		/// <summary>
		/// Run MetaData_SelectBy_MetaDataId, and return results as a list of MetaDataRow.
		/// </summary>
		/// <param name="fldMetaDataId">Value for MetaDataId</param>
		/// <returns>A collection of MetaDataRow.</returns>
		public static List<MetaDataContract> SelectBy_MetaDataIdNow(int fldMetaDataId
)
		{
			var driver = new MetaDataLogic();
			driver.SelectBy_MetaDataId(fldMetaDataId
);
			return driver.Results;
		}

		/// <summary>
		/// Run MetaData_SelectBy_MetaDataId, and return results as a list of MetaDataRow.
		/// </summary>
		/// <param name="fldMetaDataId">Value for MetaDataId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of MetaDataRow.</returns>
		public static List<MetaDataContract> SelectBy_MetaDataIdNow(int fldMetaDataId
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new MetaDataLogic();
			driver.SelectBy_MetaDataId(fldMetaDataId
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run MetaData_SelectBy_ContentInspectionId, and return results as a list of MetaDataRow.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <returns>A collection of MetaDataRow.</returns>
		public static List<MetaDataContract> SelectBy_ContentInspectionIdNow(int fldContentInspectionId
)
		{
			var driver = new MetaDataLogic();
			driver.SelectBy_ContentInspectionId(fldContentInspectionId
);
			return driver.Results;
		}

		/// <summary>
		/// Run MetaData_SelectBy_ContentInspectionId, and return results as a list of MetaDataRow.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of MetaDataRow.</returns>
		public static List<MetaDataContract> SelectBy_ContentInspectionIdNow(int fldContentInspectionId
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new MetaDataLogic();
			driver.SelectBy_ContentInspectionId(fldContentInspectionId
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Read all MetaData rows from the provided reader into the list structure of MetaDataRows
		/// </summary>
		/// <param name="reader">The result of running a sql command.</param>
		/// <returns>A populated MetaDataRows or an empty MetaDataRows if there are no results.</returns>
		public static List<MetaDataContract> ReadAllNow(SqlDataReader reader)
		{
			var driver = new MetaDataLogic();

			driver.ReadAll(reader);
			
			return driver.Results;
		}
		/// <summary>");
		/// Advance one, and read values into a MetaData
		/// </summary>
		/// <param name="reader">The result of running a sql command.</param>");
		/// <returns>A MetaData or null if there are no results.</returns>
		public static MetaDataContract ReadOneNow(SqlDataReader reader)
		{
			var driver = new MetaDataLogic();			
		    return driver.ReadOne(reader) ? driver.Results[0] : null;
		}
		/// <summary>
		/// Saves the row, either by inserting (when the identity key is null) or by updating (identity key has value).
		/// </summary>
		/// <param name="row">The data to save</param>
		/// <returns>The number of rows affected.</returns>
		public static int SaveNow(MetaDataContract row)
		{
			if(row.MetaDataId == null)
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
		public static int SaveNow(MetaDataContract row, SqlConnection connection, SqlTransaction transaction)
		{
			if(row.MetaDataId == null)
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
		public static int SaveAllNow(List<MetaDataContract> rows)
		{
			return (new MetaDataLogic()).SaveAll(rows);
		}

		/// <summary>
		/// Save the rows in bulk, uses the same connection (faster), in a provided transaction scrope.
		/// </summary>
		/// <param name="rows">The table rows to Save</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int SaveAllNow(List<MetaDataContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			return (new MetaDataLogic()).SaveAll(rows, connection, transaction);
		}        
	}
}