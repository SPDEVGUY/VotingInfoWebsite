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
	public abstract partial class ContentInspectionContractBase : logic.ICacheContainerEnabled<int>
	{
		//Put your code in a separate file.  This is auto generated.

             [IgnoreDataMember] public virtual int Cache_Identity { get { return ContentInspectionId??0; } }
        [IgnoreDataMember] public virtual int Cache_ExpireInMiliseconds { get { return 300; } }


#region ProposedByUser Extension (Parent)
		[IgnoreDataMember] public virtual Auth.UserContract ProposedByUser
		{ get { return ProposedByUserList == null || ProposedByUserList.Count == 0 ? null : ProposedByUserList[0]; } }

		[IgnoreDataMember] public virtual List<Auth.UserContract> ProposedByUserList
		{ get { return _ProposedByUser ?? (_ProposedByUser = logic.Auth.UserLogic.SelectBy_UserIdNow(ProposedByUserId)); } }

		[IgnoreDataMember] protected List<Auth.UserContract> _ProposedByUser;
#endregion ProposedByUser Extension

#region ConfirmedByUser Extension (Parent)
		[IgnoreDataMember] public virtual Auth.UserContract ConfirmedByUser
		{ get { return ConfirmedByUserList == null || ConfirmedByUserList.Count == 0 ? null : ConfirmedByUserList[0]; } }

		[IgnoreDataMember] public virtual List<Auth.UserContract> ConfirmedByUserList
		{ get { return _ConfirmedByUser ?? (_ConfirmedByUser = logic.Auth.UserLogic.SelectBy_UserIdNow(ConfirmedByUserId)); } }

		[IgnoreDataMember] protected List<Auth.UserContract> _ConfirmedByUser;
#endregion ConfirmedByUser Extension

#region Candidate Extension (Child)
		[IgnoreDataMember] public virtual Data.CandidateContract Candidate
		{ get { return CandidateList == null || CandidateList.Count == 0 ? null : CandidateList[0]; } }

		[IgnoreDataMember] public virtual List<Data.CandidateContract> CandidateList
		{ get { return _Candidate ?? (_Candidate = logic.Data.CandidateLogic.SelectBy_ContentInspectionIdNow((int)ContentInspectionId)); } }

		[IgnoreDataMember] protected List<Data.CandidateContract> _Candidate;
#endregion Candidate Extension

#region CandidateMetaData Extension (Child)
		[IgnoreDataMember] public virtual Data.CandidateMetaDataContract CandidateMetaData
		{ get { return CandidateMetaDataList == null || CandidateMetaDataList.Count == 0 ? null : CandidateMetaDataList[0]; } }

		[IgnoreDataMember] public virtual List<Data.CandidateMetaDataContract> CandidateMetaDataList
		{ get { return _CandidateMetaData ?? (_CandidateMetaData = logic.Data.CandidateMetaDataLogic.SelectBy_ContentInspectionIdNow((int)ContentInspectionId)); } }

		[IgnoreDataMember] protected List<Data.CandidateMetaDataContract> _CandidateMetaData;
#endregion CandidateMetaData Extension

#region Election Extension (Child)
		[IgnoreDataMember] public virtual Data.ElectionContract Election
		{ get { return ElectionList == null || ElectionList.Count == 0 ? null : ElectionList[0]; } }

		[IgnoreDataMember] public virtual List<Data.ElectionContract> ElectionList
		{ get { return _Election ?? (_Election = logic.Data.ElectionLogic.SelectBy_ContentInspectionIdNow((int)ContentInspectionId)); } }

		[IgnoreDataMember] protected List<Data.ElectionContract> _Election;
#endregion Election Extension

#region ElectionCandidate Extension (Child)
		[IgnoreDataMember] public virtual Data.ElectionCandidateContract ElectionCandidate
		{ get { return ElectionCandidateList == null || ElectionCandidateList.Count == 0 ? null : ElectionCandidateList[0]; } }

		[IgnoreDataMember] public virtual List<Data.ElectionCandidateContract> ElectionCandidateList
		{ get { return _ElectionCandidate ?? (_ElectionCandidate = logic.Data.ElectionCandidateLogic.SelectBy_ContentInspectionIdNow((int)ContentInspectionId)); } }

		[IgnoreDataMember] protected List<Data.ElectionCandidateContract> _ElectionCandidate;
#endregion ElectionCandidate Extension

#region ElectionLevel Extension (Child)
		[IgnoreDataMember] public virtual Data.ElectionLevelContract ElectionLevel
		{ get { return ElectionLevelList == null || ElectionLevelList.Count == 0 ? null : ElectionLevelList[0]; } }

		[IgnoreDataMember] public virtual List<Data.ElectionLevelContract> ElectionLevelList
		{ get { return _ElectionLevel ?? (_ElectionLevel = logic.Data.ElectionLevelLogic.SelectBy_ContentInspectionIdNow((int)ContentInspectionId)); } }

		[IgnoreDataMember] protected List<Data.ElectionLevelContract> _ElectionLevel;
#endregion ElectionLevel Extension

#region ElectionLevelMetaDataXref Extension (Child)
		[IgnoreDataMember] public virtual Data.ElectionLevelMetaDataXrefContract ElectionLevelMetaDataXref
		{ get { return ElectionLevelMetaDataXrefList == null || ElectionLevelMetaDataXrefList.Count == 0 ? null : ElectionLevelMetaDataXrefList[0]; } }

		[IgnoreDataMember] public virtual List<Data.ElectionLevelMetaDataXrefContract> ElectionLevelMetaDataXrefList
		{ get { return _ElectionLevelMetaDataXref ?? (_ElectionLevelMetaDataXref = logic.Data.ElectionLevelMetaDataXrefLogic.SelectBy_ContentInspectionIdNow((int)ContentInspectionId)); } }

		[IgnoreDataMember] protected List<Data.ElectionLevelMetaDataXrefContract> _ElectionLevelMetaDataXref;
#endregion ElectionLevelMetaDataXref Extension

#region Location Extension (Child)
		[IgnoreDataMember] public virtual Data.LocationContract Location
		{ get { return LocationList == null || LocationList.Count == 0 ? null : LocationList[0]; } }

		[IgnoreDataMember] public virtual List<Data.LocationContract> LocationList
		{ get { return _Location ?? (_Location = logic.Data.LocationLogic.SelectBy_ContentInspectionIdNow((int)ContentInspectionId)); } }

		[IgnoreDataMember] protected List<Data.LocationContract> _Location;
#endregion Location Extension

#region MetaData Extension (Child)
		[IgnoreDataMember] public virtual Data.MetaDataContract MetaData
		{ get { return MetaDataList == null || MetaDataList.Count == 0 ? null : MetaDataList[0]; } }

		[IgnoreDataMember] public virtual List<Data.MetaDataContract> MetaDataList
		{ get { return _MetaData ?? (_MetaData = logic.Data.MetaDataLogic.SelectBy_ContentInspectionIdNow((int)ContentInspectionId)); } }

		[IgnoreDataMember] protected List<Data.MetaDataContract> _MetaData;
#endregion MetaData Extension

#region Organization Extension (Child)
		[IgnoreDataMember] public virtual Data.OrganizationContract Organization
		{ get { return OrganizationList == null || OrganizationList.Count == 0 ? null : OrganizationList[0]; } }

		[IgnoreDataMember] public virtual List<Data.OrganizationContract> OrganizationList
		{ get { return _Organization ?? (_Organization = logic.Data.OrganizationLogic.SelectBy_ContentInspectionIdNow((int)ContentInspectionId)); } }

		[IgnoreDataMember] protected List<Data.OrganizationContract> _Organization;
#endregion Organization Extension

#region OrganizationMetaData Extension (Child)
		[IgnoreDataMember] public virtual Data.OrganizationMetaDataContract OrganizationMetaData
		{ get { return OrganizationMetaDataList == null || OrganizationMetaDataList.Count == 0 ? null : OrganizationMetaDataList[0]; } }

		[IgnoreDataMember] public virtual List<Data.OrganizationMetaDataContract> OrganizationMetaDataList
		{ get { return _OrganizationMetaData ?? (_OrganizationMetaData = logic.Data.OrganizationMetaDataLogic.SelectBy_ContentInspectionIdNow((int)ContentInspectionId)); } }

		[IgnoreDataMember] protected List<Data.OrganizationMetaDataContract> _OrganizationMetaData;
#endregion OrganizationMetaData Extension

#region Voter Extension (Child)
		[IgnoreDataMember] public virtual Data.VoterContract Voter
		{ get { return VoterList == null || VoterList.Count == 0 ? null : VoterList[0]; } }

		[IgnoreDataMember] public virtual List<Data.VoterContract> VoterList
		{ get { return _Voter ?? (_Voter = logic.Data.VoterLogic.SelectBy_ContentInspectionIdNow((int)ContentInspectionId)); } }

		[IgnoreDataMember] protected List<Data.VoterContract> _Voter;
#endregion Voter Extension

	}
}