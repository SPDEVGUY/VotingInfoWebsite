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
	public abstract partial class CandidatesLogicBase : LogicBase<CandidatesLogicBase>
	{
		//Put your code in a separate file.  This is auto generated.
    
		[XmlArray] public List<CandidatesContract> Results;

		public CandidatesLogicBase()
		{
			Results =  new List<CandidatesContract>();
		}

		/// <summary>
		/// Determine if the table contains a row with the existing values
		/// </summary>
		/// <param name="fldCandidateId">Value for CandidateId</param>
		/// <returns>True, if the values exist, or false.</returns>
		public virtual bool Exists(int fldCandidateId
)
		{
			bool result = false;

			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Client].[Candidates_Exists]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@CandidateId", fldCandidateId)

					});

					result = (bool)cmd.ExecuteScalar();
				}
			});

			return result;
		}

		/// <summary>
		/// Determine if the table contains a row with the existing values
		/// </summary>
		/// <param name="fldCandidateId">Value for CandidateId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>True, if the values exist, or false.</returns>
		public virtual bool Exists(int fldCandidateId
, SqlConnection connection, SqlTransaction transaction)
		{					
			using (
				var cmd = new SqlCommand("[Client].[Candidates_Exists]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@CandidateId", fldCandidateId)

					});

					return (bool)cmd.ExecuteScalar();
			}
		}

		/// <summary>
		/// Run Candidates_Search, and return results as a list of CandidatesRow.
		/// </summary>
		/// <param name="fldCandidateName">Value for CandidateName</param>
		/// <param name="fldSourceUrl">Value for SourceUrl</param>
		/// <returns>A collection of CandidatesRow.</returns>
		public virtual bool Search(string fldCandidateName
, string fldSourceUrl
)
		{
			var result = false;

			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Client].[Candidates_Search]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@CandidateName", fldCandidateName)
,
						new SqlParameter("@SourceUrl", fldSourceUrl)

					});

					using(var r = cmd.ExecuteReader()) result = ReadAll(r);
				}
			});

			return result;
		}

		/// <summary>
		/// Run Candidates_Search, and return results as a list of CandidatesRow.
		/// </summary>
		/// <param name="fldCandidateName">Value for CandidateName</param>
		/// <param name="fldSourceUrl">Value for SourceUrl</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of CandidatesRow.</returns>
		public virtual bool Search(string fldCandidateName
, string fldSourceUrl
, SqlConnection connection, SqlTransaction transaction)
		{
			using (
				var cmd = new SqlCommand("[Client].[Candidates_Search]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@CandidateName", fldCandidateName)
,
						new SqlParameter("@SourceUrl", fldSourceUrl)

					});

				using(var r = cmd.ExecuteReader()) return ReadAll(r);
			}
		}

		/// <summary>
		/// Run Candidates_SelectAll, and return results as a list of CandidatesRow.
		/// </summary>

		/// <returns>A collection of CandidatesRow.</returns>
		public virtual bool SelectAll()
		{
			var result = false;

			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Client].[Candidates_SelectAll]", x)
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
		/// Run Candidates_SelectAll, and return results as a list of CandidatesRow.
		/// </summary>

		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of CandidatesRow.</returns>
		public virtual bool SelectAll(SqlConnection connection, SqlTransaction transaction)
		{
			using (
				var cmd = new SqlCommand("[Client].[Candidates_SelectAll]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
				using(var r = cmd.ExecuteReader()) return ReadAll(r);
			}
		}

		/// <summary>
		/// Run Candidates_SelectBy_CandidateId, and return results as a list of CandidatesRow.
		/// </summary>
		/// <param name="fldCandidateId">Value for CandidateId</param>
		/// <returns>A collection of CandidatesRow.</returns>
		public virtual bool SelectBy_CandidateId(int fldCandidateId
)
		{
			var result = false;

			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Client].[Candidates_SelectBy_CandidateId]", x)
					{
						CommandType = CommandType.StoredProcedure,
						CommandTimeout = DefaultCommandTimeout
					})
				{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@CandidateId", fldCandidateId)

					});

					using(var r = cmd.ExecuteReader()) result = ReadAll(r);
				}
			});

			return result;
		}

		/// <summary>
		/// Run Candidates_SelectBy_CandidateId, and return results as a list of CandidatesRow.
		/// </summary>
		/// <param name="fldCandidateId">Value for CandidateId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of CandidatesRow.</returns>
		public virtual bool SelectBy_CandidateId(int fldCandidateId
, SqlConnection connection, SqlTransaction transaction)
		{
			using (
				var cmd = new SqlCommand("[Client].[Candidates_SelectBy_CandidateId]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@CandidateId", fldCandidateId)

					});

				using(var r = cmd.ExecuteReader()) return ReadAll(r);
			}
		}

		/// <summary>
		/// Run Candidates_SelectBy_ContentInspectionId, and return results as a list of CandidatesRow.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <returns>A collection of CandidatesRow.</returns>
		public virtual bool SelectBy_ContentInspectionId(int fldContentInspectionId
)
		{
			var result = false;

			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Client].[Candidates_SelectBy_ContentInspectionId]", x)
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
		/// Run Candidates_SelectBy_ContentInspectionId, and return results as a list of CandidatesRow.
		/// </summary>
		/// <param name="fldContentInspectionId">Value for ContentInspectionId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of CandidatesRow.</returns>
		public virtual bool SelectBy_ContentInspectionId(int fldContentInspectionId
, SqlConnection connection, SqlTransaction transaction)
		{
			using (
				var cmd = new SqlCommand("[Client].[Candidates_SelectBy_ContentInspectionId]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ContentInspectionId", fldContentInspectionId)

					});

				using(var r = cmd.ExecuteReader()) return ReadAll(r);
			}
		}

		/// <summary>
		/// Run Candidates_SelectBy_OrganizationId, and return results as a list of CandidatesRow.
		/// </summary>
		/// <param name="fldOrganizationId">Value for OrganizationId</param>
		/// <returns>A collection of CandidatesRow.</returns>
		public virtual bool SelectBy_OrganizationId(int fldOrganizationId
)
		{
			var result = false;

			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Client].[Candidates_SelectBy_OrganizationId]", x)
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
		/// Run Candidates_SelectBy_OrganizationId, and return results as a list of CandidatesRow.
		/// </summary>
		/// <param name="fldOrganizationId">Value for OrganizationId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of CandidatesRow.</returns>
		public virtual bool SelectBy_OrganizationId(int fldOrganizationId
, SqlConnection connection, SqlTransaction transaction)
		{
			using (
				var cmd = new SqlCommand("[Client].[Candidates_SelectBy_OrganizationId]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@OrganizationId", fldOrganizationId)

					});

				using(var r = cmd.ExecuteReader()) return ReadAll(r);
			}
		}

		/// <summary>
		/// Run Candidates_SelectBy_ProposedByUserId, and return results as a list of CandidatesRow.
		/// </summary>
		/// <param name="fldProposedByUserId">Value for ProposedByUserId</param>
		/// <returns>A collection of CandidatesRow.</returns>
		public virtual bool SelectBy_ProposedByUserId(int fldProposedByUserId
)
		{
			var result = false;

			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Client].[Candidates_SelectBy_ProposedByUserId]", x)
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
		/// Run Candidates_SelectBy_ProposedByUserId, and return results as a list of CandidatesRow.
		/// </summary>
		/// <param name="fldProposedByUserId">Value for ProposedByUserId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of CandidatesRow.</returns>
		public virtual bool SelectBy_ProposedByUserId(int fldProposedByUserId
, SqlConnection connection, SqlTransaction transaction)
		{
			using (
				var cmd = new SqlCommand("[Client].[Candidates_SelectBy_ProposedByUserId]", connection)
				{CommandType = CommandType.StoredProcedure,Transaction = transaction})
			{
					cmd.Parameters.AddRange(new[] {
						new SqlParameter("@ProposedByUserId", fldProposedByUserId)

					});

				using(var r = cmd.ExecuteReader()) return ReadAll(r);
			}
		}

		/// <summary>
		/// Run Candidates_SelectBy_ConfirmedByUserId, and return results as a list of CandidatesRow.
		/// </summary>
		/// <param name="fldConfirmedByUserId">Value for ConfirmedByUserId</param>
		/// <returns>A collection of CandidatesRow.</returns>
		public virtual bool SelectBy_ConfirmedByUserId(int fldConfirmedByUserId
)
		{
			var result = false;

			VotingInfoDb.ConnectThen(x =>
			{
				using (
					var cmd = new SqlCommand("[Client].[Candidates_SelectBy_ConfirmedByUserId]", x)
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
		/// Run Candidates_SelectBy_ConfirmedByUserId, and return results as a list of CandidatesRow.
		/// </summary>
		/// <param name="fldConfirmedByUserId">Value for ConfirmedByUserId</param>
		/// <param name="connection">The SqlConnection to use</param>
		/// <param name="transaction">The SqlTransaction to use</param>
		/// <returns>A collection of CandidatesRow.</returns>
		public virtual bool SelectBy_ConfirmedByUserId(int fldConfirmedByUserId
, SqlConnection connection, SqlTransaction transaction)
		{
			using (
				var cmd = new SqlCommand("[Client].[Candidates_SelectBy_ConfirmedByUserId]", connection)
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
					new CandidatesContract
					{
					CandidateId = reader.GetInt32(0),
					ContentInspectionId = reader.GetInt32(1),
					CandidateName = reader.GetString(2),
					OrganizationId = reader.GetInt32(3),
					IsArchived = reader.GetBoolean(4),
					IsBeingProposed = reader.GetBoolean(5),
					ProposedByUserId = reader.GetInt32(6),
					ConfirmedByUserId = reader.GetInt32(7),
					FalseInfoCount = reader.GetInt32(8),
					TrueInfoCount = reader.GetInt32(9),
					AdminInpsected = reader.GetBoolean(10),
					DateLastChecked = reader.GetDateTime(11),
					SourceUrl = reader.GetString(12),

					});
				return true;
			}
			return false;
		}
	}
}