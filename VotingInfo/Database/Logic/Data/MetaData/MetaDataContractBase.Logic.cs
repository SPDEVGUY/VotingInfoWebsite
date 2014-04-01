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
	public abstract partial class MetaDataContractBase : logic.ICacheContainerEnabled<int>
	{
		//Put your code in a separate file.  This is auto generated.

             [IgnoreDataMember] public virtual int Cache_Identity { get { return MetaDataId??0; } }
        [IgnoreDataMember] public virtual int Cache_ExpireInMiliseconds { get { return 300; } }


#region ContentInspection Extension (Parent)
		[IgnoreDataMember] public virtual Data.ContentInspectionContract ContentInspection
		{ get { return ContentInspectionList == null || ContentInspectionList.Count == 0 ? null : ContentInspectionList[0]; } }

		[IgnoreDataMember] public virtual List<Data.ContentInspectionContract> ContentInspectionList
		{ get { return _ContentInspection ?? (_ContentInspection = logic.Data.ContentInspectionLogic.SelectBy_ContentInspectionIdNow(ContentInspectionId)); } }

		[IgnoreDataMember] protected List<Data.ContentInspectionContract> _ContentInspection;
#endregion ContentInspection Extension

#region CandidateMetaData Extension (Child)
		[IgnoreDataMember] public virtual Data.CandidateMetaDataContract CandidateMetaData
		{ get { return CandidateMetaDataList == null || CandidateMetaDataList.Count == 0 ? null : CandidateMetaDataList[0]; } }

		[IgnoreDataMember] public virtual List<Data.CandidateMetaDataContract> CandidateMetaDataList
		{ get { return _CandidateMetaData ?? (_CandidateMetaData = logic.Data.CandidateMetaDataLogic.SelectBy_MetaDataIdNow((int)MetaDataId)); } }

		[IgnoreDataMember] protected List<Data.CandidateMetaDataContract> _CandidateMetaData;
#endregion CandidateMetaData Extension

#region OrganizationMetaData Extension (Child)
		[IgnoreDataMember] public virtual Data.OrganizationMetaDataContract OrganizationMetaData
		{ get { return OrganizationMetaDataList == null || OrganizationMetaDataList.Count == 0 ? null : OrganizationMetaDataList[0]; } }

		[IgnoreDataMember] public virtual List<Data.OrganizationMetaDataContract> OrganizationMetaDataList
		{ get { return _OrganizationMetaData ?? (_OrganizationMetaData = logic.Data.OrganizationMetaDataLogic.SelectBy_MetaDataIdNow((int)MetaDataId)); } }

		[IgnoreDataMember] protected List<Data.OrganizationMetaDataContract> _OrganizationMetaData;
#endregion OrganizationMetaData Extension

	}
}