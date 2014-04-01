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
	public abstract partial class ElectionLevelContractBase : logic.ICacheContainerEnabled<int>
	{
		//Put your code in a separate file.  This is auto generated.

             [IgnoreDataMember] public virtual int Cache_Identity { get { return ElectionLevelId??0; } }
        [IgnoreDataMember] public virtual int Cache_ExpireInMiliseconds { get { return 300; } }


#region ContentInspection Extension (Parent)
		[IgnoreDataMember] public virtual Data.ContentInspectionContract ContentInspection
		{ get { return ContentInspectionList == null || ContentInspectionList.Count == 0 ? null : ContentInspectionList[0]; } }

		[IgnoreDataMember] public virtual List<Data.ContentInspectionContract> ContentInspectionList
		{ get { return _ContentInspection ?? (_ContentInspection = logic.Data.ContentInspectionLogic.SelectBy_ContentInspectionIdNow(ContentInspectionId)); } }

		[IgnoreDataMember] protected List<Data.ContentInspectionContract> _ContentInspection;
#endregion ContentInspection Extension

#region Election Extension (Child)
		[IgnoreDataMember] public virtual Data.ElectionContract Election
		{ get { return ElectionList == null || ElectionList.Count == 0 ? null : ElectionList[0]; } }

		[IgnoreDataMember] public virtual List<Data.ElectionContract> ElectionList
		{ get { return _Election ?? (_Election = logic.Data.ElectionLogic.SelectBy_ElectionLevelIdNow((int)ElectionLevelId)); } }

		[IgnoreDataMember] protected List<Data.ElectionContract> _Election;
#endregion Election Extension

#region ElectionLevelMetaDataXref Extension (Child)
		[IgnoreDataMember] public virtual Data.ElectionLevelMetaDataXrefContract ElectionLevelMetaDataXref
		{ get { return ElectionLevelMetaDataXrefList == null || ElectionLevelMetaDataXrefList.Count == 0 ? null : ElectionLevelMetaDataXrefList[0]; } }

		[IgnoreDataMember] public virtual List<Data.ElectionLevelMetaDataXrefContract> ElectionLevelMetaDataXrefList
		{ get { return _ElectionLevelMetaDataXref ?? (_ElectionLevelMetaDataXref = logic.Data.ElectionLevelMetaDataXrefLogic.SelectBy_ElectionLevelIdNow((int)ElectionLevelId)); } }

		[IgnoreDataMember] protected List<Data.ElectionLevelMetaDataXrefContract> _ElectionLevelMetaDataXref;
#endregion ElectionLevelMetaDataXref Extension

	}
}