using System;
using System.Collections.Generic;
using System.Diagnostics;
using VotingInfo.Database.Contracts;
using System.Runtime.Serialization;
using VotingInfo.Database.Contracts.Client;
using VotingInfo.Database.Logic.Client;


namespace VotingInfo.WebSite.Services.Client
{    
    ///////////////////////////////////////////////////////////
    //Do not modify this file. Use a partial class to extend.//
    ///////////////////////////////////////////////////////////

    public abstract partial class CandidatesServiceBase : ServiceBase
    {
        public virtual bool Exists(string authId, string fldCandidateId)
        {
			try {
				return 
					Can(authId, (int)PermissionEnum.Client_Candidates_Exists)
					? CandidatesLogic.ExistsNow((int)Convert.ChangeType(fldCandidateId,typeof(int)))
					: false; //cant
			} catch(Exception ex) {
			#if DEBUG
				Debug.WriteLine("------------------------------");
                Debug.WriteLine("------ CandidatesServiceBase.Exists ERROR ------");
                Debug.WriteLine("------------------------------");
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.ToString());
                Debug.WriteLine("------------------------------");
			#endif
				throw;
			}
        }
		
		[DataContract(Name = "SearchPx", Namespace = "SearchPx")]
		public class SearchPx
		{
			[DataMember] public string CandidateName;
			[DataMember] public string SourceUrl;
		}
		public virtual List<CandidatesContract> Search(string authId, SearchPx px)
		{
			try {
				return
					Can(authId, (int)PermissionEnum.Client_Candidates_Search)
					? CandidatesLogic.SearchNow(px.CandidateName, px.SourceUrl)
					: null;//cant
			} catch(Exception ex) {
			#if DEBUG
				Debug.WriteLine("------------------------------");
                Debug.WriteLine("------ CandidatesServiceBase.Search ERROR ------");
                Debug.WriteLine("------------------------------");
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.ToString());
                Debug.WriteLine("------------------------------");
			#endif
				throw;
			}
		}
		
		public virtual List<CandidatesContract> SelectAll(string authId)
		{
			try {
				return
					Can(authId, (int)PermissionEnum.Client_Candidates_SelectAll)
					? CandidatesLogic.SelectAllNow()
					: null;//cant
			} catch(Exception ex) {
			#if DEBUG
				Debug.WriteLine("------------------------------");
                Debug.WriteLine("------ CandidatesServiceBase.SelectAll ERROR ------");
                Debug.WriteLine("------------------------------");
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.ToString());
                Debug.WriteLine("------------------------------");
			#endif
				throw;
			}
		}
		
		[DataContract(Name = "SelectBy_CandidateIdPx", Namespace = "SelectBy_CandidateIdPx")]
		public class SelectBy_CandidateIdPx
		{
			[DataMember] public int CandidateId;
		}
		public virtual List<CandidatesContract> SelectBy_CandidateId(string authId, SelectBy_CandidateIdPx px)
		{
			try {
				return
					Can(authId, (int)PermissionEnum.Client_Candidates_SelectBy_CandidateId)
					? CandidatesLogic.SelectBy_CandidateIdNow(px.CandidateId)
					: null;//cant
			} catch(Exception ex) {
			#if DEBUG
				Debug.WriteLine("------------------------------");
                Debug.WriteLine("------ CandidatesServiceBase.SelectBy_CandidateId ERROR ------");
                Debug.WriteLine("------------------------------");
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.ToString());
                Debug.WriteLine("------------------------------");
			#endif
				throw;
			}
		}
		
		[DataContract(Name = "SelectBy_ContentInspectionIdPx", Namespace = "SelectBy_ContentInspectionIdPx")]
		public class SelectBy_ContentInspectionIdPx
		{
			[DataMember] public int ContentInspectionId;
		}
		public virtual List<CandidatesContract> SelectBy_ContentInspectionId(string authId, SelectBy_ContentInspectionIdPx px)
		{
			try {
				return
					Can(authId, (int)PermissionEnum.Client_Candidates_SelectBy_ContentInspectionId)
					? CandidatesLogic.SelectBy_ContentInspectionIdNow(px.ContentInspectionId)
					: null;//cant
			} catch(Exception ex) {
			#if DEBUG
				Debug.WriteLine("------------------------------");
                Debug.WriteLine("------ CandidatesServiceBase.SelectBy_ContentInspectionId ERROR ------");
                Debug.WriteLine("------------------------------");
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.ToString());
                Debug.WriteLine("------------------------------");
			#endif
				throw;
			}
		}
		
		[DataContract(Name = "SelectBy_OrganizationIdPx", Namespace = "SelectBy_OrganizationIdPx")]
		public class SelectBy_OrganizationIdPx
		{
			[DataMember] public int OrganizationId;
		}
		public virtual List<CandidatesContract> SelectBy_OrganizationId(string authId, SelectBy_OrganizationIdPx px)
		{
			try {
				return
					Can(authId, (int)PermissionEnum.Client_Candidates_SelectBy_OrganizationId)
					? CandidatesLogic.SelectBy_OrganizationIdNow(px.OrganizationId)
					: null;//cant
			} catch(Exception ex) {
			#if DEBUG
				Debug.WriteLine("------------------------------");
                Debug.WriteLine("------ CandidatesServiceBase.SelectBy_OrganizationId ERROR ------");
                Debug.WriteLine("------------------------------");
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.ToString());
                Debug.WriteLine("------------------------------");
			#endif
				throw;
			}
		}
		
		[DataContract(Name = "SelectBy_ProposedByUserIdPx", Namespace = "SelectBy_ProposedByUserIdPx")]
		public class SelectBy_ProposedByUserIdPx
		{
			[DataMember] public int ProposedByUserId;
		}
		public virtual List<CandidatesContract> SelectBy_ProposedByUserId(string authId, SelectBy_ProposedByUserIdPx px)
		{
			try {
				return
					Can(authId, (int)PermissionEnum.Client_Candidates_SelectBy_ProposedByUserId)
					? CandidatesLogic.SelectBy_ProposedByUserIdNow(px.ProposedByUserId)
					: null;//cant
			} catch(Exception ex) {
			#if DEBUG
				Debug.WriteLine("------------------------------");
                Debug.WriteLine("------ CandidatesServiceBase.SelectBy_ProposedByUserId ERROR ------");
                Debug.WriteLine("------------------------------");
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.ToString());
                Debug.WriteLine("------------------------------");
			#endif
				throw;
			}
		}
		
		[DataContract(Name = "SelectBy_ConfirmedByUserIdPx", Namespace = "SelectBy_ConfirmedByUserIdPx")]
		public class SelectBy_ConfirmedByUserIdPx
		{
			[DataMember] public int ConfirmedByUserId;
		}
		public virtual List<CandidatesContract> SelectBy_ConfirmedByUserId(string authId, SelectBy_ConfirmedByUserIdPx px)
		{
			try {
				return
					Can(authId, (int)PermissionEnum.Client_Candidates_SelectBy_ConfirmedByUserId)
					? CandidatesLogic.SelectBy_ConfirmedByUserIdNow(px.ConfirmedByUserId)
					: null;//cant
			} catch(Exception ex) {
			#if DEBUG
				Debug.WriteLine("------------------------------");
                Debug.WriteLine("------ CandidatesServiceBase.SelectBy_ConfirmedByUserId ERROR ------");
                Debug.WriteLine("------------------------------");
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.ToString());
                Debug.WriteLine("------------------------------");
			#endif
				throw;
			}
		}
        public virtual CandidatesContract Get(string authId, string fldCandidateId)
        {
			try {
				if(Can(authId, (int)PermissionEnum.Client_Candidates_SelectBy_CandidateId)) 
				{
					var results = CandidatesLogic.SelectBy_CandidateIdNow((int)Convert.ChangeType(fldCandidateId,typeof(int)));
					return results.Count == 0 ? null : results[0];
				}
				return null; //cant
			} catch(Exception ex) {
			#if DEBUG
				Debug.WriteLine("------------------------------");
                Debug.WriteLine("------ CandidatesServiceBase.SelectBy_CandidateId ERROR ------");
                Debug.WriteLine("------------------------------");
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.ToString());
                Debug.WriteLine("------------------------------");
			#endif 
				throw;
			}
        }
    }
}
