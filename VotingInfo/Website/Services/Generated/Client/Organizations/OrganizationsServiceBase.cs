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

    public abstract partial class OrganizationsServiceBase : ServiceBase
    {
		
		public virtual List<OrganizationsContract> SelectAll(string authId)
		{
			try {
				return
					Can(authId, (int)PermissionEnum.Client_Organizations_SelectAll)
					? OrganizationsLogic.SelectAllNow()
					: null;//cant
			} catch(Exception ex) {
			#if DEBUG
				Debug.WriteLine("------------------------------");
                Debug.WriteLine("------ OrganizationsServiceBase.SelectAll ERROR ------");
                Debug.WriteLine("------------------------------");
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.ToString());
                Debug.WriteLine("------------------------------");
			#endif
				throw;
			}
		}
        public virtual bool Exists(string authId, string fldOrganizationId)
        {
			try {
				return 
					Can(authId, (int)PermissionEnum.Client_Organizations_Exists)
					? OrganizationsLogic.ExistsNow((int)Convert.ChangeType(fldOrganizationId,typeof(int)))
					: false; //cant
			} catch(Exception ex) {
			#if DEBUG
				Debug.WriteLine("------------------------------");
                Debug.WriteLine("------ OrganizationsServiceBase.Exists ERROR ------");
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
			[DataMember] public string OrganizationName;
			[DataMember] public string SourceUrl;
		}
		public virtual List<OrganizationsContract> Search(string authId, SearchPx px)
		{
			try {
				return
					Can(authId, (int)PermissionEnum.Client_Organizations_Search)
					? OrganizationsLogic.SearchNow(px.OrganizationName, px.SourceUrl)
					: null;//cant
			} catch(Exception ex) {
			#if DEBUG
				Debug.WriteLine("------------------------------");
                Debug.WriteLine("------ OrganizationsServiceBase.Search ERROR ------");
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
		public virtual List<OrganizationsContract> SelectBy_OrganizationId(string authId, SelectBy_OrganizationIdPx px)
		{
			try {
				return
					Can(authId, (int)PermissionEnum.Client_Organizations_SelectBy_OrganizationId)
					? OrganizationsLogic.SelectBy_OrganizationIdNow(px.OrganizationId)
					: null;//cant
			} catch(Exception ex) {
			#if DEBUG
				Debug.WriteLine("------------------------------");
                Debug.WriteLine("------ OrganizationsServiceBase.SelectBy_OrganizationId ERROR ------");
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
		public virtual List<OrganizationsContract> SelectBy_ContentInspectionId(string authId, SelectBy_ContentInspectionIdPx px)
		{
			try {
				return
					Can(authId, (int)PermissionEnum.Client_Organizations_SelectBy_ContentInspectionId)
					? OrganizationsLogic.SelectBy_ContentInspectionIdNow(px.ContentInspectionId)
					: null;//cant
			} catch(Exception ex) {
			#if DEBUG
				Debug.WriteLine("------------------------------");
                Debug.WriteLine("------ OrganizationsServiceBase.SelectBy_ContentInspectionId ERROR ------");
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
		public virtual List<OrganizationsContract> SelectBy_ProposedByUserId(string authId, SelectBy_ProposedByUserIdPx px)
		{
			try {
				return
					Can(authId, (int)PermissionEnum.Client_Organizations_SelectBy_ProposedByUserId)
					? OrganizationsLogic.SelectBy_ProposedByUserIdNow(px.ProposedByUserId)
					: null;//cant
			} catch(Exception ex) {
			#if DEBUG
				Debug.WriteLine("------------------------------");
                Debug.WriteLine("------ OrganizationsServiceBase.SelectBy_ProposedByUserId ERROR ------");
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
		public virtual List<OrganizationsContract> SelectBy_ConfirmedByUserId(string authId, SelectBy_ConfirmedByUserIdPx px)
		{
			try {
				return
					Can(authId, (int)PermissionEnum.Client_Organizations_SelectBy_ConfirmedByUserId)
					? OrganizationsLogic.SelectBy_ConfirmedByUserIdNow(px.ConfirmedByUserId)
					: null;//cant
			} catch(Exception ex) {
			#if DEBUG
				Debug.WriteLine("------------------------------");
                Debug.WriteLine("------ OrganizationsServiceBase.SelectBy_ConfirmedByUserId ERROR ------");
                Debug.WriteLine("------------------------------");
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.ToString());
                Debug.WriteLine("------------------------------");
			#endif
				throw;
			}
		}
        public virtual OrganizationsContract Get(string authId, string fldOrganizationId)
        {
			try {
				if(Can(authId, (int)PermissionEnum.Client_Organizations_SelectBy_OrganizationId)) 
				{
					var results = OrganizationsLogic.SelectBy_OrganizationIdNow((int)Convert.ChangeType(fldOrganizationId,typeof(int)));
					return results.Count == 0 ? null : results[0];
				}
				return null; //cant
			} catch(Exception ex) {
			#if DEBUG
				Debug.WriteLine("------------------------------");
                Debug.WriteLine("------ OrganizationsServiceBase.SelectBy_OrganizationId ERROR ------");
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
