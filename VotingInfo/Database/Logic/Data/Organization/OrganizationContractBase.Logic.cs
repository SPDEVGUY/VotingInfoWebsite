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
	public abstract partial class OrganizationContractBase : logic.ICacheContainerEnabled<int>
	{
		//Put your code in a separate file.  This is auto generated.

             [IgnoreDataMember] public virtual int Cache_Identity { get { return OrganizationId??0; } }
        [IgnoreDataMember] public virtual int Cache_ExpireInMiliseconds { get { return 300; } }


#region ContentInspection Extension (Parent)
		[IgnoreDataMember] public virtual Data.ContentInspectionContract ContentInspection
		{ get { return ContentInspectionList == null || ContentInspectionList.Count == 0 ? null : ContentInspectionList[0]; } }

		[IgnoreDataMember] public virtual List<Data.ContentInspectionContract> ContentInspectionList
		{ get { return _ContentInspection ?? (_ContentInspection = logic.Data.ContentInspectionLogic.SelectBy_ContentInspectionIdNow(ContentInspectionId)); } }

		[IgnoreDataMember] protected List<Data.ContentInspectionContract> _ContentInspection;
#endregion ContentInspection Extension

#region Candidate Extension (Child)
		[IgnoreDataMember] public virtual Data.CandidateContract Candidate
		{ get { return CandidateList == null || CandidateList.Count == 0 ? null : CandidateList[0]; } }

		[IgnoreDataMember] public virtual List<Data.CandidateContract> CandidateList
		{ get { return _Candidate ?? (_Candidate = logic.Data.CandidateLogic.SelectBy_OrganizationIdNow((int)OrganizationId)); } }

		[IgnoreDataMember] protected List<Data.CandidateContract> _Candidate;
#endregion Candidate Extension

#region OrganizationMetaData Extension (Child)
		[IgnoreDataMember] public virtual Data.OrganizationMetaDataContract OrganizationMetaData
		{ get { return OrganizationMetaDataList == null || OrganizationMetaDataList.Count == 0 ? null : OrganizationMetaDataList[0]; } }

		[IgnoreDataMember] public virtual List<Data.OrganizationMetaDataContract> OrganizationMetaDataList
		{ get { return _OrganizationMetaData ?? (_OrganizationMetaData = logic.Data.OrganizationMetaDataLogic.SelectBy_OrganizationIdNow((int)OrganizationId)); } }

		[IgnoreDataMember] protected List<Data.OrganizationMetaDataContract> _OrganizationMetaData;
#endregion OrganizationMetaData Extension

#region VoterFavoriteOrganization Extension (Child)
		[IgnoreDataMember] public virtual Data.VoterContract VoterFavoriteOrganization
		{ get { return VoterFavoriteOrganizationList == null || VoterFavoriteOrganizationList.Count == 0 ? null : VoterFavoriteOrganizationList[0]; } }

		[IgnoreDataMember] public virtual List<Data.VoterContract> VoterFavoriteOrganizationList
		{ get { return _VoterFavoriteOrganization ?? (_VoterFavoriteOrganization = logic.Data.VoterLogic.SelectBy_FavoriteOrganizationIdNow((int)OrganizationId)); } }

		[IgnoreDataMember] protected List<Data.VoterContract> _VoterFavoriteOrganization;
#endregion VoterFavoriteOrganization Extension

	}
}