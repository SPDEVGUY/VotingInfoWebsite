using System.Collections.Generic;
using logic = VotingInfo.Database.Logic;
using System.Runtime.Serialization;

//////////////////////////////////////////////////////////////
//Do not modify this file. Use a partial class to extend.	//
//Override methods in the logic front class.				//
//Use of this class will require you to have your contracts //
//in the same module (Dll/exe) as the logic.                //
//////////////////////////////////////////////////////////////

namespace VotingInfo.Database.Contracts.Data
{
	public abstract partial class CandidateContractBase : logic.ICacheContainerEnabled<int>
	{
		//Put your code in a separate file.  This is auto generated.

             [IgnoreDataMember] public virtual int Cache_Identity { get { return CandidateId??0; } }
        [IgnoreDataMember] public virtual int Cache_ExpireInMiliseconds { get { return 300; } }


#region User Extension (Parent)
		[IgnoreDataMember] public virtual Auth.UserContract User
		{ get { return UserList == null || UserList.Count == 0 ? null : UserList[0]; } }

		[IgnoreDataMember] public virtual List<Auth.UserContract> UserList
		{ get { return _User ?? (_User = logic.Auth.UserLogic.SelectBy_UserIdNow(UserId)); } }

		[IgnoreDataMember] protected List<Auth.UserContract> _User;
#endregion User Extension

#region ContentInspection Extension (Parent)
		[IgnoreDataMember] public virtual Data.ContentInspectionContract ContentInspection
		{ get { return ContentInspectionList == null || ContentInspectionList.Count == 0 ? null : ContentInspectionList[0]; } }

		[IgnoreDataMember] public virtual List<Data.ContentInspectionContract> ContentInspectionList
		{ get { return _ContentInspection ?? (_ContentInspection = logic.Data.ContentInspectionLogic.SelectBy_ContentInspectionIdNow(ContentInspectionId)); } }

		[IgnoreDataMember] protected List<Data.ContentInspectionContract> _ContentInspection;
#endregion ContentInspection Extension

#region Location Extension (Parent)
		[IgnoreDataMember] public virtual Data.LocationContract Location
		{ get { return LocationList == null || LocationList.Count == 0 ? null : LocationList[0]; } }

		[IgnoreDataMember] public virtual List<Data.LocationContract> LocationList
		{ get { return _Location ?? (_Location = logic.Data.LocationLogic.SelectBy_LocationIdNow(LocationId)); } }

		[IgnoreDataMember] protected List<Data.LocationContract> _Location;
#endregion Location Extension

#region Organization Extension (Parent)
		[IgnoreDataMember] public virtual Data.OrganizationContract Organization
		{ get { return OrganizationList == null || OrganizationList.Count == 0 ? null : OrganizationList[0]; } }

		[IgnoreDataMember] public virtual List<Data.OrganizationContract> OrganizationList
		{ get { return _Organization ?? (_Organization = logic.Data.OrganizationLogic.SelectBy_OrganizationIdNow(OrganizationId)); } }

		[IgnoreDataMember] protected List<Data.OrganizationContract> _Organization;
#endregion Organization Extension

#region CandidateMetaData Extension (Child)
		[IgnoreDataMember] public virtual Data.CandidateMetaDataContract CandidateMetaData
		{ get { return CandidateMetaDataList == null || CandidateMetaDataList.Count == 0 ? null : CandidateMetaDataList[0]; } }

		[IgnoreDataMember] public virtual List<Data.CandidateMetaDataContract> CandidateMetaDataList
		{ get { return _CandidateMetaData ?? (_CandidateMetaData = logic.Data.CandidateMetaDataLogic.SelectBy_CandidateIdNow((int)CandidateId)); } }

		[IgnoreDataMember] protected List<Data.CandidateMetaDataContract> _CandidateMetaData;
#endregion CandidateMetaData Extension

#region ElectionCandidate Extension (Child)
		[IgnoreDataMember] public virtual Data.ElectionCandidateContract ElectionCandidate
		{ get { return ElectionCandidateList == null || ElectionCandidateList.Count == 0 ? null : ElectionCandidateList[0]; } }

		[IgnoreDataMember] public virtual List<Data.ElectionCandidateContract> ElectionCandidateList
		{ get { return _ElectionCandidate ?? (_ElectionCandidate = logic.Data.ElectionCandidateLogic.SelectBy_CandidateIdNow((int)CandidateId)); } }

		[IgnoreDataMember] protected List<Data.ElectionCandidateContract> _ElectionCandidate;
#endregion ElectionCandidate Extension

	}
}