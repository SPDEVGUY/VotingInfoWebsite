using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using VotingInfo.Database.Contracts;
using VotingInfo.Database.Contracts.Data;

///////////////////////////////////////////////////////////
//Do not modify this file. Use a partial class to extend.//
///////////////////////////////////////////////////////////
// This file contains static implementations of the CandidateMetaDataLogic
// Add your own static methods by making a new partial class.
// You cannot override static methods, instead override the methods
// located in CandidateMetaDataLogicBase by making a partial class of CandidateMetaDataLogic
// and overriding the base methods.

namespace VotingInfo.Database.Logic.Data
{
	public partial class CandidateMetaDataLogic
	{
		//Put your code in a separate file.  This is auto generated.
		/// <summary>
		/// Run CandidateMetaData_Insert.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldCandidateId">Value for CandidateId</param>
		/// <param name="fldMetaDataId">Value for MetaDataId</param>
		/// <param name="fldMetaDataValue">Value for MetaDataValue</param>
		public static int? InsertNow(int fldContentInspectionId
, int fldCandidateId
, int fldMetaDataId
, string fldMetaDataValue
)
		{
			return (new CandidateMetaDataLogic()).Insert(fldContentInspectionId
, fldCandidateId
, fldMetaDataId
, fldMetaDataValue
);
		}
		/// <summary>
		/// Run CandidateMetaData_Insert.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldCandidateId">Value for CandidateId</param>
		/// <param name="fldMetaDataId">Value for MetaDataId</param>
		/// <param name="fldMetaDataValue">Value for MetaDataValue</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		public static int? InsertNow(int fldContentInspectionId
, int fldCandidateId
, int fldMetaDataId
, string fldMetaDataValue
, SqlConnection connection, SqlTransaction transaction)
		{
			return (new CandidateMetaDataLogic()).Insert(fldContentInspectionId
, fldCandidateId
, fldMetaDataId
, fldMetaDataValue
, connection, transaction);
		}

		/// <summary>
		/// Insert by providing a populated data row container
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int InsertNow(CandidateMetaDataContract row)
		{
			return (new CandidateMetaDataLogic()).Insert(row);
		}

		/// <summary>
		/// Insert by providing a populated data contract
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int InsertNow(CandidateMetaDataContract row, SqlConnection connection, SqlTransaction transaction)
		{
			return (new CandidateMetaDataLogic()).Insert(row, connection, transaction);
		}

		/// <summary>
		/// Insert the rows in bulk, uses the same connection (faster).
		/// </summary>
		/// <param name="rows">The table rows to Insert</param>
		/// <returns>The number of rows affected.</returns>
		public static int InsertAllNow(List<CandidateMetaDataContract> rows)
		{
			return (new CandidateMetaDataLogic()).InsertAll(rows);
		}

		/// <summary>
		/// Insert the rows in bulk, uses the same connection (faster), in a provided transaction scrope.
		/// </summary>
		/// <param name="rows">The table rows to Insert</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int InsertAllNow(List<CandidateMetaDataContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			return (new CandidateMetaDataLogic()).InsertAll(rows, connection, transaction);
		}
		/// <summary>
		/// Run CandidateMetaData_Update.
		/// </summary>
		/// <param name="fldCandidateMetaDataId">Value for CandidateMetaDataId</param>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldCandidateId">Value for CandidateId</param>
		/// <param name="fldMetaDataId">Value for MetaDataId</param>
		/// <param name="fldMetaDataValue">Value for MetaDataValue</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateNow(int fldCandidateMetaDataId
, int fldContentInspectionId
, int fldCandidateId
, int fldMetaDataId
, string fldMetaDataValue
)
		{
			return (new CandidateMetaDataLogic()).Update(fldCandidateMetaDataId
, fldContentInspectionId
, fldCandidateId
, fldMetaDataId
, fldMetaDataValue
);
		}

		/// <summary>
		/// Run CandidateMetaData_Update.
		/// </summary>
		/// <param name="fldCandidateMetaDataId">Value for CandidateMetaDataId</param>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="fldCandidateId">Value for CandidateId</param>
		/// <param name="fldMetaDataId">Value for MetaDataId</param>
		/// <param name="fldMetaDataValue">Value for MetaDataValue</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateNow(int fldCandidateMetaDataId
, int fldContentInspectionId
, int fldCandidateId
, int fldMetaDataId
, string fldMetaDataValue
, SqlConnection connection, SqlTransaction transaction)
		{
			return (new CandidateMetaDataLogic()).Update(fldCandidateMetaDataId
, fldContentInspectionId
, fldCandidateId
, fldMetaDataId
, fldMetaDataValue
, connection, transaction);
		}
		/// <summary>
		/// Update by providing a populated data row container
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateNow(CandidateMetaDataContract row)
		{
			return (new CandidateMetaDataLogic()).Update(row);
		}

		/// <summary>
		/// Update by providing a populated data contract
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateNow(CandidateMetaDataContract row, SqlConnection connection, SqlTransaction transaction)
		{
			return (new CandidateMetaDataLogic()).Update(row, connection, transaction);
		}

		/// <summary>
		/// Update the rows in bulk, uses the same connection (faster).
		/// </summary>
		/// <param name="rows">The table rows to Update</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateAllNow(List<CandidateMetaDataContract> rows)
		{
			return (new CandidateMetaDataLogic()).UpdateAll(rows);
		}

		/// <summary>
		/// Update the rows in bulk, uses the same connection (faster), in a provided transaction scrope.
		/// </summary>
		/// <param name="rows">The table rows to Update</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int UpdateAllNow(List<CandidateMetaDataContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			return (new CandidateMetaDataLogic()).UpdateAll(rows, connection, transaction);
		}
		/// <summary>
		/// Run CandidateMetaData_Delete.
		/// </summary>
		/// <param name="fldCandidateMetaDataId">Value for CandidateMetaDataId</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteNow(int fldCandidateMetaDataId
)
		{
			return (new CandidateMetaDataLogic()).Delete(fldCandidateMetaDataId
);
		}

		/// <summary>
		/// Run CandidateMetaData_Delete.
		/// </summary>
		/// <param name="fldCandidateMetaDataId">Value for CandidateMetaDataId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteNow(int fldCandidateMetaDataId
, SqlConnection connection, SqlTransaction transaction)
		{
			return (new CandidateMetaDataLogic()).Delete(fldCandidateMetaDataId
, connection, transaction);
		}
		/// <summary>
		/// Delete by providing a populated data row container
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteNow(CandidateMetaDataContract row)
		{
			return (new CandidateMetaDataLogic()).Delete(row);
		}

		/// <summary>
		/// Delete by providing a populated data contract
		/// </summary>
		/// <param name="row">The table row data to use</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteNow(CandidateMetaDataContract row, SqlConnection connection, SqlTransaction transaction)
		{
			return (new CandidateMetaDataLogic()).Delete(row, connection, transaction);
		}

		/// <summary>
		/// Delete the rows in bulk, uses the same connection (faster).
		/// </summary>
		/// <param name="rows">The table rows to Delete</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteAllNow(List<CandidateMetaDataContract> rows)
		{
			return (new CandidateMetaDataLogic()).DeleteAll(rows);
		}

		/// <summary>
		/// Delete the rows in bulk, uses the same connection (faster), in a provided transaction scrope.
		/// </summary>
		/// <param name="rows">The table rows to Delete</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int DeleteAllNow(List<CandidateMetaDataContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			return (new CandidateMetaDataLogic()).DeleteAll(rows, connection, transaction);
		}
		/// <summary>
		/// Determine if the table contains a row with the existing values
		/// </summary>
		/// <param name="fldCandidateMetaDataId">Value for CandidateMetaDataId</param>
		/// <returns>True, if the values exist, or false.</returns>
		public static bool ExistsNow(int fldCandidateMetaDataId
)
		{
			return (new CandidateMetaDataLogic()).Exists(fldCandidateMetaDataId
);
		}

		/// <summary>
		/// Determine if the table contains a row with the existing values
		/// </summary>
		/// <param name="fldCandidateMetaDataId">Value for CandidateMetaDataId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>True, if the values exist, or false.</returns>
		public static bool ExistsNow(int fldCandidateMetaDataId
, SqlConnection connection, SqlTransaction transaction)
		{					
			return (new CandidateMetaDataLogic()).Exists(fldCandidateMetaDataId
, connection, transaction);
		}

		/// <summary>
		/// Run CandidateMetaData_Search, and return results as a list of CandidateMetaDataRow.
		/// </summary>
		/// <param name="fldMetaDataValue">Value for MetaDataValue</param>
		/// <returns>A collection of CandidateMetaDataRow.</returns>
		public static List<CandidateMetaDataContract> SearchNow(string fldMetaDataValue
)
		{
			var driver = new CandidateMetaDataLogic();
			driver.Search(fldMetaDataValue
);
			return driver.Results;
		}

		/// <summary>
		/// Run CandidateMetaData_Search, and return results as a list of CandidateMetaDataRow.
		/// </summary>
		/// <param name="fldMetaDataValue">Value for MetaDataValue</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of CandidateMetaDataRow.</returns>
		public static List<CandidateMetaDataContract> SearchNow(string fldMetaDataValue
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new CandidateMetaDataLogic();
			driver.Search(fldMetaDataValue
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run CandidateMetaData_SelectAll, and return results as a list of CandidateMetaDataRow.
		/// </summary>

		/// <returns>A collection of CandidateMetaDataRow.</returns>
		public static List<CandidateMetaDataContract> SelectAllNow()
		{			
			var driver = new CandidateMetaDataLogic();
			driver.SelectAll();
			return driver.Results;
		}

		/// <summary>
		/// Run CandidateMetaData_SelectAll, and return results as a list of CandidateMetaDataRow.
		/// </summary>

		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of CandidateMetaDataRow.</returns>
		public static List<CandidateMetaDataContract> SelectAllNow(SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new CandidateMetaDataLogic();
			driver.SelectAll(connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run CandidateMetaData_SelectBy_CandidateMetaDataId, and return results as a list of CandidateMetaDataRow.
		/// </summary>
		/// <param name="fldCandidateMetaDataId">Value for CandidateMetaDataId</param>
		/// <returns>A collection of CandidateMetaDataRow.</returns>
		public static List<CandidateMetaDataContract> SelectBy_CandidateMetaDataIdNow(int fldCandidateMetaDataId
)
		{
			var driver = new CandidateMetaDataLogic();
			driver.SelectBy_CandidateMetaDataId(fldCandidateMetaDataId
);
			return driver.Results;
		}

		/// <summary>
		/// Run CandidateMetaData_SelectBy_CandidateMetaDataId, and return results as a list of CandidateMetaDataRow.
		/// </summary>
		/// <param name="fldCandidateMetaDataId">Value for CandidateMetaDataId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of CandidateMetaDataRow.</returns>
		public static List<CandidateMetaDataContract> SelectBy_CandidateMetaDataIdNow(int fldCandidateMetaDataId
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new CandidateMetaDataLogic();
			driver.SelectBy_CandidateMetaDataId(fldCandidateMetaDataId
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run CandidateMetaData_SelectBy_CandidateId, and return results as a list of CandidateMetaDataRow.
		/// </summary>
		/// <param name="fldCandidateId">Value for CandidateId</param>
		/// <returns>A collection of CandidateMetaDataRow.</returns>
		public static List<CandidateMetaDataContract> SelectBy_CandidateIdNow(int fldCandidateId
)
		{
			var driver = new CandidateMetaDataLogic();
			driver.SelectBy_CandidateId(fldCandidateId
);
			return driver.Results;
		}

		/// <summary>
		/// Run CandidateMetaData_SelectBy_CandidateId, and return results as a list of CandidateMetaDataRow.
		/// </summary>
		/// <param name="fldCandidateId">Value for CandidateId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of CandidateMetaDataRow.</returns>
		public static List<CandidateMetaDataContract> SelectBy_CandidateIdNow(int fldCandidateId
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new CandidateMetaDataLogic();
			driver.SelectBy_CandidateId(fldCandidateId
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run CandidateMetaData_SelectBy_ContentInspectionId, and return results as a list of CandidateMetaDataRow.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <returns>A collection of CandidateMetaDataRow.</returns>
		public static List<CandidateMetaDataContract> SelectBy_ContentInspectionIdNow(int fldContentInspectionId
)
		{
			var driver = new CandidateMetaDataLogic();
			driver.SelectBy_ContentInspectionId(fldContentInspectionId
);
			return driver.Results;
		}

		/// <summary>
		/// Run CandidateMetaData_SelectBy_ContentInspectionId, and return results as a list of CandidateMetaDataRow.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of CandidateMetaDataRow.</returns>
		public static List<CandidateMetaDataContract> SelectBy_ContentInspectionIdNow(int fldContentInspectionId
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new CandidateMetaDataLogic();
			driver.SelectBy_ContentInspectionId(fldContentInspectionId
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run CandidateMetaData_SelectBy_MetaDataId, and return results as a list of CandidateMetaDataRow.
		/// </summary>
		/// <param name="fldMetaDataId">Value for MetaDataId</param>
		/// <returns>A collection of CandidateMetaDataRow.</returns>
		public static List<CandidateMetaDataContract> SelectBy_MetaDataIdNow(int fldMetaDataId
)
		{
			var driver = new CandidateMetaDataLogic();
			driver.SelectBy_MetaDataId(fldMetaDataId
);
			return driver.Results;
		}

		/// <summary>
		/// Run CandidateMetaData_SelectBy_MetaDataId, and return results as a list of CandidateMetaDataRow.
		/// </summary>
		/// <param name="fldMetaDataId">Value for MetaDataId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of CandidateMetaDataRow.</returns>
		public static List<CandidateMetaDataContract> SelectBy_MetaDataIdNow(int fldMetaDataId
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new CandidateMetaDataLogic();
			driver.SelectBy_MetaDataId(fldMetaDataId
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Read all CandidateMetaData rows from the provided reader into the list structure of CandidateMetaDataRows
		/// </summary>
		/// <param name="reader">The result of running a sql command.</param>
		/// <returns>A populated CandidateMetaDataRows or an empty CandidateMetaDataRows if there are no results.</returns>
		public static List<CandidateMetaDataContract> ReadAllNow(SqlDataReader reader)
		{
			var driver = new CandidateMetaDataLogic();

			driver.ReadAll(reader);
			
			return driver.Results;
		}
		/// <summary>");
		/// Advance one, and read values into a CandidateMetaData
		/// </summary>
		/// <param name="reader">The result of running a sql command.</param>");
		/// <returns>A CandidateMetaData or null if there are no results.</returns>
		public static CandidateMetaDataContract ReadOneNow(SqlDataReader reader)
		{
			var driver = new CandidateMetaDataLogic();			
		    return driver.ReadOne(reader) ? driver.Results[0] : null;
		}
		/// <summary>
		/// Saves the row, either by inserting (when the identity key is null) or by updating (identity key has value).
		/// </summary>
		/// <param name="row">The data to save</param>
		/// <returns>The number of rows affected.</returns>
		public static int SaveNow(CandidateMetaDataContract row)
		{
			if(row.CandidateMetaDataId == null)
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
		public static int SaveNow(CandidateMetaDataContract row, SqlConnection connection, SqlTransaction transaction)
		{
			if(row.CandidateMetaDataId == null)
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
		public static int SaveAllNow(List<CandidateMetaDataContract> rows)
		{
			return (new CandidateMetaDataLogic()).SaveAll(rows);
		}

		/// <summary>
		/// Save the rows in bulk, uses the same connection (faster), in a provided transaction scrope.
		/// </summary>
		/// <param name="rows">The table rows to Save</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>The number of rows affected.</returns>
		public static int SaveAllNow(List<CandidateMetaDataContract> rows, SqlConnection connection, SqlTransaction transaction)
		{
			return (new CandidateMetaDataLogic()).SaveAll(rows, connection, transaction);
		}        
	}
}