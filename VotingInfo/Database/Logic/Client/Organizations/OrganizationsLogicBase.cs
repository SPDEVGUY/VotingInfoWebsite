using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Xml.Serialization;
using VotingInfo.Database.Contracts;
using VotingInfo.Database.Contracts.Client;

//////////////////////////////////////////////////////////////
//Do not modify this file. Use a partial class to extend.	//
//Override methods in the logic front class.				//
//////////////////////////////////////////////////////////////

namespace VotingInfo.Database.Logic.Client
{
	[Serializable]
	public abstract partial class OrganizationsLogicBase : LogicBase<OrganizationsLogicBase>
	{
		//Put your code in a separate file.  This is auto generated.
    
		[XmlArray] public List<OrganizationsContract> Results;

		public OrganizationsLogicBase()
		{
			Results =  new List<OrganizationsContract>();
		}

		/// <summary>
		/// Determine if the table contains a row with the existing values
		/// </summary>
		/// <param name="fldOrganizationId">Value for OrganizationId</param>
		/// <returns>True, if the values exist, or false.</returns>
		public virtual bool Exists(int fldOrganizationId
)
		{
			bool result = false;

			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Client].[Organizations_Exists]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@OrganizationId", fldOrganizationId)

					});

					result = (bool)cmd.ExecuteScalar();
				}
			});

			return result;
		}

		/// <summary>
		/// Determine if the table contains a row with the existing values
		/// </summary>
		/// <param name="fldOrganizationId">Value for OrganizationId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>True, if the values exist, or false.</returns>
		public virtual bool Exists(int fldOrganizationId
, SqlConnection connection, SqlTransaction transaction)
		{					
			using (
				var cmd = new SqlCommand("[Client].[Organizations_Exists]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@OrganizationId", fldOrganizationId)

					});

					return (bool)cmd.ExecuteScalar();
			}
		}

		/// <summary>
		/// Run Organizations_Search, and return results as a list of OrganizationsRow.
		/// </summary>
		/// <param name="fldOrganizationName">Value for OrganizationName</param>
		/// <param name="fldSourceUrl">Value for SourceUrl</param>
		/// <returns>A collection of OrganizationsRow.</returns>
		public virtual bool Search(string fldOrganizationName
, string fldSourceUrl
)
		{
			var result = false;

			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Client].[Organizations_Search]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@OrganizationName", fldOrganizationName)
,
						new SqlParameter("@SourceUrl", fldSourceUrl)

					});

					using(var r = cmd.ExecuteReader()) result = ReadAll(r);
				}
			});

			return result;
		}

		/// <summary>
		/// Run Organizations_Search, and return results as a list of OrganizationsRow.
		/// </summary>
		/// <param name="fldOrganizationName">Value for OrganizationName</param>
		/// <param name="fldSourceUrl">Value for SourceUrl</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of OrganizationsRow.</returns>
		public virtual bool Search(string fldOrganizationName
, string fldSourceUrl
, SqlConnection connection, SqlTransaction transaction)
		{
			using (
				var cmd = new SqlCommand("[Client].[Organizations_Search]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@OrganizationName", fldOrganizationName)
,
						new SqlParameter("@SourceUrl", fldSourceUrl)

					});

				using(var r = cmd.ExecuteReader()) return ReadAll(r);
			}
		}

		/// <summary>
		/// Run Organizations_SelectAll, and return results as a list of OrganizationsRow.
		/// </summary>

		/// <returns>A collection of OrganizationsRow.</returns>
		public virtual bool SelectAll()
		{
			var result = false;

			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Client].[Organizations_SelectAll]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					using(var r = cmd.ExecuteReader()) result = ReadAll(r);
				}
			});

			return result;
		}

		/// <summary>
		/// Run Organizations_SelectAll, and return results as a list of OrganizationsRow.
		/// </summary>

		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of OrganizationsRow.</returns>
		public virtual bool SelectAll(SqlConnection connection, SqlTransaction transaction)
		{
			using (
				var cmd = new SqlCommand("[Client].[Organizations_SelectAll]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
				using(var r = cmd.ExecuteReader()) return ReadAll(r);
			}
		}

		/// <summary>
		/// Run Organizations_SelectBy_OrganizationId, and return results as a list of OrganizationsRow.
		/// </summary>
		/// <param name="fldOrganizationId">Value for OrganizationId</param>
		/// <returns>A collection of OrganizationsRow.</returns>
		public virtual bool SelectBy_OrganizationId(int fldOrganizationId
)
		{
			var result = false;

			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Client].[Organizations_SelectBy_OrganizationId]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@OrganizationId", fldOrganizationId)

					});

					using(var r = cmd.ExecuteReader()) result = ReadAll(r);
				}
			});

			return result;
		}

		/// <summary>
		/// Run Organizations_SelectBy_OrganizationId, and return results as a list of OrganizationsRow.
		/// </summary>
		/// <param name="fldOrganizationId">Value for OrganizationId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of OrganizationsRow.</returns>
		public virtual bool SelectBy_OrganizationId(int fldOrganizationId
, SqlConnection connection, SqlTransaction transaction)
		{
			using (
				var cmd = new SqlCommand("[Client].[Organizations_SelectBy_OrganizationId]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@OrganizationId", fldOrganizationId)

					});

				using(var r = cmd.ExecuteReader()) return ReadAll(r);
			}
		}

		/// <summary>
		/// Run Organizations_SelectBy_ContentInspectionId, and return results as a list of OrganizationsRow.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <returns>A collection of OrganizationsRow.</returns>
		public virtual bool SelectBy_ContentInspectionId(int fldContentInspectionId
)
		{
			var result = false;

			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Client].[Organizations_SelectBy_ContentInspectionId]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ContentInspectionId", fldContentInspectionId)

					});

					using(var r = cmd.ExecuteReader()) result = ReadAll(r);
				}
			});

			return result;
		}

		/// <summary>
		/// Run Organizations_SelectBy_ContentInspectionId, and return results as a list of OrganizationsRow.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of OrganizationsRow.</returns>
		public virtual bool SelectBy_ContentInspectionId(int fldContentInspectionId
, SqlConnection connection, SqlTransaction transaction)
		{
			using (
				var cmd = new SqlCommand("[Client].[Organizations_SelectBy_ContentInspectionId]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ContentInspectionId", fldContentInspectionId)

					});

				using(var r = cmd.ExecuteReader()) return ReadAll(r);
			}
		}

		/// <summary>
		/// Run Organizations_SelectBy_ProposedByUserId, and return results as a list of OrganizationsRow.
		/// </summary>
		/// <param name="fldProposedByUserId">Value for ProposedByUserId</param>
		/// <returns>A collection of OrganizationsRow.</returns>
		public virtual bool SelectBy_ProposedByUserId(int fldProposedByUserId
)
		{
			var result = false;

			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Client].[Organizations_SelectBy_ProposedByUserId]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ProposedByUserId", fldProposedByUserId)

					});

					using(var r = cmd.ExecuteReader()) result = ReadAll(r);
				}
			});

			return result;
		}

		/// <summary>
		/// Run Organizations_SelectBy_ProposedByUserId, and return results as a list of OrganizationsRow.
		/// </summary>
		/// <param name="fldProposedByUserId">Value for ProposedByUserId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of OrganizationsRow.</returns>
		public virtual bool SelectBy_ProposedByUserId(int fldProposedByUserId
, SqlConnection connection, SqlTransaction transaction)
		{
			using (
				var cmd = new SqlCommand("[Client].[Organizations_SelectBy_ProposedByUserId]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ProposedByUserId", fldProposedByUserId)

					});

				using(var r = cmd.ExecuteReader()) return ReadAll(r);
			}
		}

		/// <summary>
		/// Run Organizations_SelectBy_ConfirmedByUserId, and return results as a list of OrganizationsRow.
		/// </summary>
		/// <param name="fldConfirmedByUserId">Value for ConfirmedByUserId</param>
		/// <returns>A collection of OrganizationsRow.</returns>
		public virtual bool SelectBy_ConfirmedByUserId(int fldConfirmedByUserId
)
		{
			var result = false;

			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Client].[Organizations_SelectBy_ConfirmedByUserId]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ConfirmedByUserId", fldConfirmedByUserId)

					});

					using(var r = cmd.ExecuteReader()) result = ReadAll(r);
				}
			});

			return result;
		}

		/// <summary>
		/// Run Organizations_SelectBy_ConfirmedByUserId, and return results as a list of OrganizationsRow.
		/// </summary>
		/// <param name="fldConfirmedByUserId">Value for ConfirmedByUserId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of OrganizationsRow.</returns>
		public virtual bool SelectBy_ConfirmedByUserId(int fldConfirmedByUserId
, SqlConnection connection, SqlTransaction transaction)
		{
			using (
				var cmd = new SqlCommand("[Client].[Organizations_SelectBy_ConfirmedByUserId]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ConfirmedByUserId", fldConfirmedByUserId)

					});

				using(var r = cmd.ExecuteReader()) return ReadAll(r);
			}
		}

		/// <summary>
		/// Read all items into this collection
		/// </summary>
		/// <param name="reader">The result of running a sql command.</param>
		public virtual bool ReadAll(SqlDataReader reader)
		{
			var canRead = ReadOne(reader);
			var result = canRead;

			while (canRead) canRead = ReadOne(reader);

			return result;
		}
		/// <summary>
		/// Read one item into Results
		/// </summary>
		/// <param name="reader">The result of running a sql command.</param>
		public virtual bool ReadOne(SqlDataReader reader)
		{
			if (reader.Read())
			{
				Results.Add(
					new OrganizationsContract
					{
					OrganizationId = reader.GetInt32(0),
					ContentInspectionId = reader.GetInt32(1),
					OrganizationName = reader.GetString(2),
					IsArchived = reader.GetBoolean(3),
					IsBeingProposed = reader.GetBoolean(4),
					ProposedByUserId = reader.GetInt32(5),
					ConfirmedByUserId = reader.GetInt32(6),
					FalseInfoCount = reader.GetInt32(7),
					TrueInfoCount = reader.GetInt32(8),
					AdminInpsected = reader.GetBoolean(9),
					DateLastChecked = reader.GetDateTime(10),
					SourceUrl = reader.GetString(11),

					});
				return true;
			}
			return false;
		}
	}
}