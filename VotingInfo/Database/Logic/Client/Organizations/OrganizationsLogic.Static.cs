using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using VotingInfo.Database.Contracts;
using VotingInfo.Database.Contracts.Client;

///////////////////////////////////////////////////////////
//Do not modify this file. Use a partial class to extend.//
///////////////////////////////////////////////////////////
// This file contains static implementations of the OrganizationsLogic
// Add your own static methods by making a new partial class.
// You cannot override static methods, instead override the methods
// located in OrganizationsLogicBase by making a partial class of OrganizationsLogic
// and overriding the base methods.

namespace VotingInfo.Database.Logic.Client
{
	public partial class OrganizationsLogic
	{
		//Put your code in a separate file.  This is auto generated.
		/// <summary>
		/// Determine if the table contains a row with the existing values
		/// </summary>
		/// <param name="fldOrganizationId">Value for OrganizationId</param>
		/// <returns>True, if the values exist, or false.</returns>
		public static bool ExistsNow(int fldOrganizationId
)
		{
			return (new OrganizationsLogic()).Exists(fldOrganizationId
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
			return (new OrganizationsLogic()).Exists(fldOrganizationId
, connection, transaction);
		}

		/// <summary>
		/// Run Organizations_Search, and return results as a list of OrganizationsRow.
		/// </summary>
		/// <param name="fldOrganizationName">Value for OrganizationName</param>
		/// <param name="fldSourceUrl">Value for SourceUrl</param>
		/// <returns>A collection of OrganizationsRow.</returns>
		public static List<OrganizationsContract> SearchNow(string fldOrganizationName
, string fldSourceUrl
)
		{
			var driver = new OrganizationsLogic();
			driver.Search(fldOrganizationName
, fldSourceUrl
);
			return driver.Results;
		}

		/// <summary>
		/// Run Organizations_Search, and return results as a list of OrganizationsRow.
		/// </summary>
		/// <param name="fldOrganizationName">Value for OrganizationName</param>
		/// <param name="fldSourceUrl">Value for SourceUrl</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of OrganizationsRow.</returns>
		public static List<OrganizationsContract> SearchNow(string fldOrganizationName
, string fldSourceUrl
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new OrganizationsLogic();
			driver.Search(fldOrganizationName
, fldSourceUrl
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run Organizations_SelectAll, and return results as a list of OrganizationsRow.
		/// </summary>

		/// <returns>A collection of OrganizationsRow.</returns>
		public static List<OrganizationsContract> SelectAllNow()
		{			
			var driver = new OrganizationsLogic();
			driver.SelectAll();
			return driver.Results;
		}

		/// <summary>
		/// Run Organizations_SelectAll, and return results as a list of OrganizationsRow.
		/// </summary>

		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of OrganizationsRow.</returns>
		public static List<OrganizationsContract> SelectAllNow(SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new OrganizationsLogic();
			driver.SelectAll(connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run Organizations_SelectBy_OrganizationId, and return results as a list of OrganizationsRow.
		/// </summary>
		/// <param name="fldOrganizationId">Value for OrganizationId</param>
		/// <returns>A collection of OrganizationsRow.</returns>
		public static List<OrganizationsContract> SelectBy_OrganizationIdNow(int fldOrganizationId
)
		{
			var driver = new OrganizationsLogic();
			driver.SelectBy_OrganizationId(fldOrganizationId
);
			return driver.Results;
		}

		/// <summary>
		/// Run Organizations_SelectBy_OrganizationId, and return results as a list of OrganizationsRow.
		/// </summary>
		/// <param name="fldOrganizationId">Value for OrganizationId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of OrganizationsRow.</returns>
		public static List<OrganizationsContract> SelectBy_OrganizationIdNow(int fldOrganizationId
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new OrganizationsLogic();
			driver.SelectBy_OrganizationId(fldOrganizationId
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run Organizations_SelectBy_ContentInspectionId, and return results as a list of OrganizationsRow.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <returns>A collection of OrganizationsRow.</returns>
		public static List<OrganizationsContract> SelectBy_ContentInspectionIdNow(int fldContentInspectionId
)
		{
			var driver = new OrganizationsLogic();
			driver.SelectBy_ContentInspectionId(fldContentInspectionId
);
			return driver.Results;
		}

		/// <summary>
		/// Run Organizations_SelectBy_ContentInspectionId, and return results as a list of OrganizationsRow.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of OrganizationsRow.</returns>
		public static List<OrganizationsContract> SelectBy_ContentInspectionIdNow(int fldContentInspectionId
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new OrganizationsLogic();
			driver.SelectBy_ContentInspectionId(fldContentInspectionId
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run Organizations_SelectBy_ProposedByUserId, and return results as a list of OrganizationsRow.
		/// </summary>
		/// <param name="fldProposedByUserId">Value for ProposedByUserId</param>
		/// <returns>A collection of OrganizationsRow.</returns>
		public static List<OrganizationsContract> SelectBy_ProposedByUserIdNow(int fldProposedByUserId
)
		{
			var driver = new OrganizationsLogic();
			driver.SelectBy_ProposedByUserId(fldProposedByUserId
);
			return driver.Results;
		}

		/// <summary>
		/// Run Organizations_SelectBy_ProposedByUserId, and return results as a list of OrganizationsRow.
		/// </summary>
		/// <param name="fldProposedByUserId">Value for ProposedByUserId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of OrganizationsRow.</returns>
		public static List<OrganizationsContract> SelectBy_ProposedByUserIdNow(int fldProposedByUserId
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new OrganizationsLogic();
			driver.SelectBy_ProposedByUserId(fldProposedByUserId
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run Organizations_SelectBy_ConfirmedByUserId, and return results as a list of OrganizationsRow.
		/// </summary>
		/// <param name="fldConfirmedByUserId">Value for ConfirmedByUserId</param>
		/// <returns>A collection of OrganizationsRow.</returns>
		public static List<OrganizationsContract> SelectBy_ConfirmedByUserIdNow(int fldConfirmedByUserId
)
		{
			var driver = new OrganizationsLogic();
			driver.SelectBy_ConfirmedByUserId(fldConfirmedByUserId
);
			return driver.Results;
		}

		/// <summary>
		/// Run Organizations_SelectBy_ConfirmedByUserId, and return results as a list of OrganizationsRow.
		/// </summary>
		/// <param name="fldConfirmedByUserId">Value for ConfirmedByUserId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of OrganizationsRow.</returns>
		public static List<OrganizationsContract> SelectBy_ConfirmedByUserIdNow(int fldConfirmedByUserId
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new OrganizationsLogic();
			driver.SelectBy_ConfirmedByUserId(fldConfirmedByUserId
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Read all Organizations rows from the provided reader into the list structure of OrganizationsRows
		/// </summary>
		/// <param name="reader">The result of running a sql command.</param>
		/// <returns>A populated OrganizationsRows or an empty OrganizationsRows if there are no results.</returns>
		public static List<OrganizationsContract> ReadAllNow(SqlDataReader reader)
		{
			var driver = new OrganizationsLogic();

			driver.ReadAll(reader);
			
			return driver.Results;
		}
		/// <summary>");
		/// Advance one, and read values into a Organizations
		/// </summary>
		/// <param name="reader">The result of running a sql command.</param>");
		/// <returns>A Organizations or null if there are no results.</returns>
		public static OrganizationsContract ReadOneNow(SqlDataReader reader)
		{
			var driver = new OrganizationsLogic();			
		    return driver.ReadOne(reader) ? driver.Results[0] : null;
		}        
	}
}