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
	public abstract partial class OrganizationMetaDataContractBase : logic.ICacheContainerEnabled<int>
	{
		//Put your code in a separate file.  This is auto generated.

             [IgnoreDataMember] public virtual int Cache_Identity { get { return OrganizationMetaDataId??0; } }
        [IgnoreDataMember] public virtual int Cache_ExpireInMiliseconds { get { return 300; } }


#region ContentInspection Extension (Parent)
		[IgnoreDataMember] public virtual Data.ContentInspectionContract ContentInspection
		{ get { return ContentInspectionList == null || ContentInspectionList.Count == 0 ? null : ContentInspectionList[0]; } }

		[IgnoreDataMember] public virtual List<Data.ContentInspectionContract> ContentInspectionList
		{ get { return _ContentInspection ?? (_ContentInspection = logic.Data.ContentInspectionLogic.SelectBy_ContentInspectionIdNow(ContentInspectionId)); } }

		[IgnoreDataMember] protected List<Data.ContentInspectionContract> _ContentInspection;
#endregion ContentInspection Extension

#region MetaData Extension (Parent)
		[IgnoreDataMember] public virtual Data.MetaDataContract MetaData
		{ get { return MetaDataList == null || MetaDataList.Count == 0 ? null : MetaDataList[0]; } }

		[IgnoreDataMember] public virtual List<Data.MetaDataContract> MetaDataList
		{ get { return _MetaData ?? (_MetaData = logic.Data.MetaDataLogic.SelectBy_MetaDataIdNow(MetaDataId)); } }

		[IgnoreDataMember] protected List<Data.MetaDataContract> _MetaData;
#endregion MetaData Extension

#region Organization Extension (Parent)
		[IgnoreDataMember] public virtual Data.OrganizationContract Organization
		{ get { return OrganizationList == null || OrganizationList.Count == 0 ? null : OrganizationList[0]; } }

		[IgnoreDataMember] public virtual List<Data.OrganizationContract> OrganizationList
		{ get { return _Organization ?? (_Organization = logic.Data.OrganizationLogic.SelectBy_OrganizationIdNow(OrganizationId)); } }

		[IgnoreDataMember] protected List<Data.OrganizationContract> _Organization;
#endregion Organization Extension

	}
}