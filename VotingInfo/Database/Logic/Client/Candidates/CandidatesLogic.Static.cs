using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using VotingInfo.Database.Contracts;
using VotingInfo.Database.Contracts.Client;

///////////////////////////////////////////////////////////
//Do not modify this file. Use a partial class to extend.//
///////////////////////////////////////////////////////////
// This file contains static implementations of the CandidatesLogic
// Add your own static methods by making a new partial class.
// You cannot override static methods, instead override the methods
// located in CandidatesLogicBase by making a partial class of CandidatesLogic
// and overriding the base methods.

namespace VotingInfo.Database.Logic.Client
{
	public partial class CandidatesLogic
	{
		//Put your code in a separate file.  This is auto generated.
		/// <summary>
		/// Determine if the table contains a row with the existing values
		/// </summary>
		/// <param name="fldCandidateId">Value for CandidateId</param>
		/// <returns>True, if the values exist, or false.</returns>
		public static bool ExistsNow(int fldCandidateId
)
		{
			return (new CandidatesLogic()).Exists(fldCandidateId
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
			return (new CandidatesLogic()).Exists(fldCandidateId
, connection, transaction);
		}

		/// <summary>
		/// Run Candidates_Search, and return results as a list of CandidatesRow.
		/// </summary>
		/// <param name="fldCandidateName">Value for CandidateName</param>
		/// <param name="fldSourceUrl">Value for SourceUrl</param>
		/// <returns>A collection of CandidatesRow.</returns>
		public static List<CandidatesContract> SearchNow(string fldCandidateName
, string fldSourceUrl
)
		{
			var driver = new CandidatesLogic();
			driver.Search(fldCandidateName
, fldSourceUrl
);
			return driver.Results;
		}

		/// <summary>
		/// Run Candidates_Search, and return results as a list of CandidatesRow.
		/// </summary>
		/// <param name="fldCandidateName">Value for CandidateName</param>
		/// <param name="fldSourceUrl">Value for SourceUrl</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of CandidatesRow.</returns>
		public static List<CandidatesContract> SearchNow(string fldCandidateName
, string fldSourceUrl
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new CandidatesLogic();
			driver.Search(fldCandidateName
, fldSourceUrl
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run Candidates_SelectAll, and return results as a list of CandidatesRow.
		/// </summary>

		/// <returns>A collection of CandidatesRow.</returns>
		public static List<CandidatesContract> SelectAllNow()
		{			
			var driver = new CandidatesLogic();
			driver.SelectAll();
			return driver.Results;
		}

		/// <summary>
		/// Run Candidates_SelectAll, and return results as a list of CandidatesRow.
		/// </summary>

		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of CandidatesRow.</returns>
		public static List<CandidatesContract> SelectAllNow(SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new CandidatesLogic();
			driver.SelectAll(connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run Candidates_SelectBy_CandidateId, and return results as a list of CandidatesRow.
		/// </summary>
		/// <param name="fldCandidateId">Value for CandidateId</param>
		/// <returns>A collection of CandidatesRow.</returns>
		public static List<CandidatesContract> SelectBy_CandidateIdNow(int fldCandidateId
)
		{
			var driver = new CandidatesLogic();
			driver.SelectBy_CandidateId(fldCandidateId
);
			return driver.Results;
		}

		/// <summary>
		/// Run Candidates_SelectBy_CandidateId, and return results as a list of CandidatesRow.
		/// </summary>
		/// <param name="fldCandidateId">Value for CandidateId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of CandidatesRow.</returns>
		public static List<CandidatesContract> SelectBy_CandidateIdNow(int fldCandidateId
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new CandidatesLogic();
			driver.SelectBy_CandidateId(fldCandidateId
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run Candidates_SelectBy_ContentInspectionId, and return results as a list of CandidatesRow.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <returns>A collection of CandidatesRow.</returns>
		public static List<CandidatesContract> SelectBy_ContentInspectionIdNow(int fldContentInspectionId
)
		{
			var driver = new CandidatesLogic();
			driver.SelectBy_ContentInspectionId(fldContentInspectionId
);
			return driver.Results;
		}

		/// <summary>
		/// Run Candidates_SelectBy_ContentInspectionId, and return results as a list of CandidatesRow.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of CandidatesRow.</returns>
		public static List<CandidatesContract> SelectBy_ContentInspectionIdNow(int fldContentInspectionId
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new CandidatesLogic();
			driver.SelectBy_ContentInspectionId(fldContentInspectionId
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run Candidates_SelectBy_OrganizationId, and return results as a list of CandidatesRow.
		/// </summary>
		/// <param name="fldOrganizationId">Value for OrganizationId</param>
		/// <returns>A collection of CandidatesRow.</returns>
		public static List<CandidatesContract> SelectBy_OrganizationIdNow(int fldOrganizationId
)
		{
			var driver = new CandidatesLogic();
			driver.SelectBy_OrganizationId(fldOrganizationId
);
			return driver.Results;
		}

		/// <summary>
		/// Run Candidates_SelectBy_OrganizationId, and return results as a list of CandidatesRow.
		/// </summary>
		/// <param name="fldOrganizationId">Value for OrganizationId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of CandidatesRow.</returns>
		public static List<CandidatesContract> SelectBy_OrganizationIdNow(int fldOrganizationId
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new CandidatesLogic();
			driver.SelectBy_OrganizationId(fldOrganizationId
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run Candidates_SelectBy_ProposedByUserId, and return results as a list of CandidatesRow.
		/// </summary>
		/// <param name="fldProposedByUserId">Value for ProposedByUserId</param>
		/// <returns>A collection of CandidatesRow.</returns>
		public static List<CandidatesContract> SelectBy_ProposedByUserIdNow(int fldProposedByUserId
)
		{
			var driver = new CandidatesLogic();
			driver.SelectBy_ProposedByUserId(fldProposedByUserId
);
			return driver.Results;
		}

		/// <summary>
		/// Run Candidates_SelectBy_ProposedByUserId, and return results as a list of CandidatesRow.
		/// </summary>
		/// <param name="fldProposedByUserId">Value for ProposedByUserId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of CandidatesRow.</returns>
		public static List<CandidatesContract> SelectBy_ProposedByUserIdNow(int fldProposedByUserId
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new CandidatesLogic();
			driver.SelectBy_ProposedByUserId(fldProposedByUserId
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run Candidates_SelectBy_ConfirmedByUserId, and return results as a list of CandidatesRow.
		/// </summary>
		/// <param name="fldConfirmedByUserId">Value for ConfirmedByUserId</param>
		/// <returns>A collection of CandidatesRow.</returns>
		public static List<CandidatesContract> SelectBy_ConfirmedByUserIdNow(int fldConfirmedByUserId
)
		{
			var driver = new CandidatesLogic();
			driver.SelectBy_ConfirmedByUserId(fldConfirmedByUserId
);
			return driver.Results;
		}

		/// <summary>
		/// Run Candidates_SelectBy_ConfirmedByUserId, and return results as a list of CandidatesRow.
		/// </summary>
		/// <param name="fldConfirmedByUserId">Value for ConfirmedByUserId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of CandidatesRow.</returns>
		public static List<CandidatesContract> SelectBy_ConfirmedByUserIdNow(int fldConfirmedByUserId
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new CandidatesLogic();
			driver.SelectBy_ConfirmedByUserId(fldConfirmedByUserId
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Read all Candidates rows from the provided reader into the list structure of CandidatesRows
		/// </summary>
		/// <param name="reader">The result of running a sql command.</param>
		/// <returns>A populated CandidatesRows or an empty CandidatesRows if there are no results.</returns>
		public static List<CandidatesContract> ReadAllNow(SqlDataReader reader)
		{
			var driver = new CandidatesLogic();

			driver.ReadAll(reader);
			
			return driver.Results;
		}
		/// <summary>");
		/// Advance one, and read values into a Candidates
		/// </summary>
		/// <param name="reader">The result of running a sql command.</param>");
		/// <returns>A Candidates or null if there are no results.</returns>
		public static CandidatesContract ReadOneNow(SqlDataReader reader)
		{
			var driver = new CandidatesLogic();			
		    return driver.ReadOne(reader) ? driver.Results[0] : null;
		}        
	}
}