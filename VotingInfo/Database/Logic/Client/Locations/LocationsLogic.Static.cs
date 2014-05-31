using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using VotingInfo.Database.Contracts;
using VotingInfo.Database.Contracts.Client;

///////////////////////////////////////////////////////////
//Do not modify this file. Use a partial class to extend.//
///////////////////////////////////////////////////////////
// This file contains static implementations of the LocationsLogic
// Add your own static methods by making a new partial class.
// You cannot override static methods, instead override the methods
// located in LocationsLogicBase by making a partial class of LocationsLogic
// and overriding the base methods.

namespace VotingInfo.Database.Logic.Client
{
	public partial class LocationsLogic
	{
		//Put your code in a separate file.  This is auto generated.
		/// <summary>
		/// Determine if the table contains a row with the existing values
		/// </summary>
		/// <param name="fldLocationId">Value for LocationId</param>
		/// <returns>True, if the values exist, or false.</returns>
		public static bool ExistsNow(int fldLocationId
)
		{
			return (new LocationsLogic()).Exists(fldLocationId
);
		}

		/// <summary>
		/// Determine if the table contains a row with the existing values
		/// </summary>
		/// <param name="fldLocationId">Value for LocationId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>True, if the values exist, or false.</returns>
		public static bool ExistsNow(int fldLocationId
, SqlConnection connection, SqlTransaction transaction)
		{					
			return (new LocationsLogic()).Exists(fldLocationId
, connection, transaction);
		}

		/// <summary>
		/// Run Locations_Search, and return results as a list of LocationsRow.
		/// </summary>
		/// <param name="fldLocationName">Value for LocationName</param>
		/// <param name="fldSourceUrl">Value for SourceUrl</param>
		/// <returns>A collection of LocationsRow.</returns>
		public static List<LocationsContract> SearchNow(string fldLocationName
, string fldSourceUrl
)
		{
			var driver = new LocationsLogic();
			driver.Search(fldLocationName
, fldSourceUrl
);
			return driver.Results;
		}

		/// <summary>
		/// Run Locations_Search, and return results as a list of LocationsRow.
		/// </summary>
		/// <param name="fldLocationName">Value for LocationName</param>
		/// <param name="fldSourceUrl">Value for SourceUrl</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of LocationsRow.</returns>
		public static List<LocationsContract> SearchNow(string fldLocationName
, string fldSourceUrl
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new LocationsLogic();
			driver.Search(fldLocationName
, fldSourceUrl
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run Locations_SelectAll, and return results as a list of LocationsRow.
		/// </summary>

		/// <returns>A collection of LocationsRow.</returns>
		public static List<LocationsContract> SelectAllNow()
		{			
			var driver = new LocationsLogic();
			driver.SelectAll();
			return driver.Results;
		}

		/// <summary>
		/// Run Locations_SelectAll, and return results as a list of LocationsRow.
		/// </summary>

		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of LocationsRow.</returns>
		public static List<LocationsContract> SelectAllNow(SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new LocationsLogic();
			driver.SelectAll(connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run Locations_SelectBy_LocationId, and return results as a list of LocationsRow.
		/// </summary>
		/// <param name="fldLocationId">Value for LocationId</param>
		/// <returns>A collection of LocationsRow.</returns>
		public static List<LocationsContract> SelectBy_LocationIdNow(int fldLocationId
)
		{
			var driver = new LocationsLogic();
			driver.SelectBy_LocationId(fldLocationId
);
			return driver.Results;
		}

		/// <summary>
		/// Run Locations_SelectBy_LocationId, and return results as a list of LocationsRow.
		/// </summary>
		/// <param name="fldLocationId">Value for LocationId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of LocationsRow.</returns>
		public static List<LocationsContract> SelectBy_LocationIdNow(int fldLocationId
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new LocationsLogic();
			driver.SelectBy_LocationId(fldLocationId
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run Locations_SelectBy_ContentInspectionId, and return results as a list of LocationsRow.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <returns>A collection of LocationsRow.</returns>
		public static List<LocationsContract> SelectBy_ContentInspectionIdNow(int fldContentInspectionId
)
		{
			var driver = new LocationsLogic();
			driver.SelectBy_ContentInspectionId(fldContentInspectionId
);
			return driver.Results;
		}

		/// <summary>
		/// Run Locations_SelectBy_ContentInspectionId, and return results as a list of LocationsRow.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of LocationsRow.</returns>
		public static List<LocationsContract> SelectBy_ContentInspectionIdNow(int fldContentInspectionId
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new LocationsLogic();
			driver.SelectBy_ContentInspectionId(fldContentInspectionId
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run Locations_SelectBy_ProposedByUserId, and return results as a list of LocationsRow.
		/// </summary>
		/// <param name="fldProposedByUserId">Value for ProposedByUserId</param>
		/// <returns>A collection of LocationsRow.</returns>
		public static List<LocationsContract> SelectBy_ProposedByUserIdNow(int fldProposedByUserId
)
		{
			var driver = new LocationsLogic();
			driver.SelectBy_ProposedByUserId(fldProposedByUserId
);
			return driver.Results;
		}

		/// <summary>
		/// Run Locations_SelectBy_ProposedByUserId, and return results as a list of LocationsRow.
		/// </summary>
		/// <param name="fldProposedByUserId">Value for ProposedByUserId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of LocationsRow.</returns>
		public static List<LocationsContract> SelectBy_ProposedByUserIdNow(int fldProposedByUserId
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new LocationsLogic();
			driver.SelectBy_ProposedByUserId(fldProposedByUserId
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Run Locations_SelectBy_ConfirmedByUserId, and return results as a list of LocationsRow.
		/// </summary>
		/// <param name="fldConfirmedByUserId">Value for ConfirmedByUserId</param>
		/// <returns>A collection of LocationsRow.</returns>
		public static List<LocationsContract> SelectBy_ConfirmedByUserIdNow(int fldConfirmedByUserId
)
		{
			var driver = new LocationsLogic();
			driver.SelectBy_ConfirmedByUserId(fldConfirmedByUserId
);
			return driver.Results;
		}

		/// <summary>
		/// Run Locations_SelectBy_ConfirmedByUserId, and return results as a list of LocationsRow.
		/// </summary>
		/// <param name="fldConfirmedByUserId">Value for ConfirmedByUserId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of LocationsRow.</returns>
		public static List<LocationsContract> SelectBy_ConfirmedByUserIdNow(int fldConfirmedByUserId
, SqlConnection connection, SqlTransaction transaction)
		{
			var driver = new LocationsLogic();
			driver.SelectBy_ConfirmedByUserId(fldConfirmedByUserId
, connection, transaction);

			return driver.Results;
		}

		/// <summary>
		/// Read all Locations rows from the provided reader into the list structure of LocationsRows
		/// </summary>
		/// <param name="reader">The result of running a sql command.</param>
		/// <returns>A populated LocationsRows or an empty LocationsRows if there are no results.</returns>
		public static List<LocationsContract> ReadAllNow(SqlDataReader reader)
		{
			var driver = new LocationsLogic();

			driver.ReadAll(reader);
			
			return driver.Results;
		}
		/// <summary>");
		/// Advance one, and read values into a Locations
		/// </summary>
		/// <param name="reader">The result of running a sql command.</param>");
		/// <returns>A Locations or null if there are no results.</returns>
		public static LocationsContract ReadOneNow(SqlDataReader reader)
		{
			var driver = new LocationsLogic();			
		    return driver.ReadOne(reader) ? driver.Results[0] : null;
		}        
	}
}