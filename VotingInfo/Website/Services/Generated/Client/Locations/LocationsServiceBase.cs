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

    public abstract partial class LocationsServiceBase : ServiceBase
    {
        public virtual bool Exists(string authId, string fldLocationId)
        {
			try {
				return 
					Can(authId, (int)PermissionEnum.Client_Locations_Exists)
					? LocationsLogic.ExistsNow((int)Convert.ChangeType(fldLocationId,typeof(int)))
					: false; //cant
			} catch(Exception ex) {
			#if DEBUG
				Debug.WriteLine("------------------------------");
                Debug.WriteLine("------ LocationsServiceBase.Exists ERROR ------");
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
			[DataMember] public string LocationName;
			[DataMember] public string SourceUrl;
		}
		public virtual List<LocationsContract> Search(string authId, SearchPx px)
		{
			try {
				return
					Can(authId, (int)PermissionEnum.Client_Locations_Search)
					? LocationsLogic.SearchNow(px.LocationName, px.SourceUrl)
					: null;//cant
			} catch(Exception ex) {
			#if DEBUG
				Debug.WriteLine("------------------------------");
                Debug.WriteLine("------ LocationsServiceBase.Search ERROR ------");
                Debug.WriteLine("------------------------------");
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.ToString());
                Debug.WriteLine("------------------------------");
			#endif
				throw;
			}
		}
		
		public virtual List<LocationsContract> SelectAll(string authId)
		{
			try {
				return
					Can(authId, (int)PermissionEnum.Client_Locations_SelectAll)
					? LocationsLogic.SelectAllNow()
					: null;//cant
			} catch(Exception ex) {
			#if DEBUG
				Debug.WriteLine("------------------------------");
                Debug.WriteLine("------ LocationsServiceBase.SelectAll ERROR ------");
                Debug.WriteLine("------------------------------");
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.ToString());
                Debug.WriteLine("------------------------------");
			#endif
				throw;
			}
		}
		
		[DataContract(Name = "SelectBy_LocationIdPx", Namespace = "SelectBy_LocationIdPx")]
		public class SelectBy_LocationIdPx
		{
			[DataMember] public int LocationId;
		}
		public virtual List<LocationsContract> SelectBy_LocationId(string authId, SelectBy_LocationIdPx px)
		{
			try {
				return
					Can(authId, (int)PermissionEnum.Client_Locations_SelectBy_LocationId)
					? LocationsLogic.SelectBy_LocationIdNow(px.LocationId)
					: null;//cant
			} catch(Exception ex) {
			#if DEBUG
				Debug.WriteLine("------------------------------");
                Debug.WriteLine("------ LocationsServiceBase.SelectBy_LocationId ERROR ------");
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
		public virtual List<LocationsContract> SelectBy_ContentInspectionId(string authId, SelectBy_ContentInspectionIdPx px)
		{
			try {
				return
					Can(authId, (int)PermissionEnum.Client_Locations_SelectBy_ContentInspectionId)
					? LocationsLogic.SelectBy_ContentInspectionIdNow(px.ContentInspectionId)
					: null;//cant
			} catch(Exception ex) {
			#if DEBUG
				Debug.WriteLine("------------------------------");
                Debug.WriteLine("------ LocationsServiceBase.SelectBy_ContentInspectionId ERROR ------");
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
		public virtual List<LocationsContract> SelectBy_ProposedByUserId(string authId, SelectBy_ProposedByUserIdPx px)
		{
			try {
				return
					Can(authId, (int)PermissionEnum.Client_Locations_SelectBy_ProposedByUserId)
					? LocationsLogic.SelectBy_ProposedByUserIdNow(px.ProposedByUserId)
					: null;//cant
			} catch(Exception ex) {
			#if DEBUG
				Debug.WriteLine("------------------------------");
                Debug.WriteLine("------ LocationsServiceBase.SelectBy_ProposedByUserId ERROR ------");
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
		public virtual List<LocationsContract> SelectBy_ConfirmedByUserId(string authId, SelectBy_ConfirmedByUserIdPx px)
		{
			try {
				return
					Can(authId, (int)PermissionEnum.Client_Locations_SelectBy_ConfirmedByUserId)
					? LocationsLogic.SelectBy_ConfirmedByUserIdNow(px.ConfirmedByUserId)
					: null;//cant
			} catch(Exception ex) {
			#if DEBUG
				Debug.WriteLine("------------------------------");
                Debug.WriteLine("------ LocationsServiceBase.SelectBy_ConfirmedByUserId ERROR ------");
                Debug.WriteLine("------------------------------");
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.ToString());
                Debug.WriteLine("------------------------------");
			#endif
				throw;
			}
		}
        public virtual LocationsContract Get(string authId, string fldLocationId)
        {
			try {
				if(Can(authId, (int)PermissionEnum.Client_Locations_SelectBy_LocationId)) 
				{
					var results = LocationsLogic.SelectBy_LocationIdNow((int)Convert.ChangeType(fldLocationId,typeof(int)));
					return results.Count == 0 ? null : results[0];
				}
				return null; //cant
			} catch(Exception ex) {
			#if DEBUG
				Debug.WriteLine("------------------------------");
                Debug.WriteLine("------ LocationsServiceBase.SelectBy_LocationId ERROR ------");
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
