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
	public abstract partial class ElectionLevelMetaDataXrefContractBase : logic.ICacheContainerEnabled<int>
	{
		//Put your code in a separate file.  This is auto generated.

             [IgnoreDataMember] public virtual int Cache_Identity { get { return ElectionLevelMetaDataXrefId??0; } }
        [IgnoreDataMember] public virtual int Cache_ExpireInMiliseconds { get { return 300; } }


#region ContentInspection Extension (Parent)
		[IgnoreDataMember] public virtual Data.ContentInspectionContract ContentInspection
		{ get { return ContentInspectionList == null || ContentInspectionList.Count == 0 ? null : ContentInspectionList[0]; } }

		[IgnoreDataMember] public virtual List<Data.ContentInspectionContract> ContentInspectionList
		{ get { return _ContentInspection ?? (_ContentInspection = logic.Data.ContentInspectionLogic.SelectBy_ContentInspectionIdNow(ContentInspectionId)); } }

		[IgnoreDataMember] protected List<Data.ContentInspectionContract> _ContentInspection;
#endregion ContentInspection Extension

#region ElectionLevel Extension (Parent)
		[IgnoreDataMember] public virtual Data.ElectionLevelContract ElectionLevel
		{ get { return ElectionLevelList == null || ElectionLevelList.Count == 0 ? null : ElectionLevelList[0]; } }

		[IgnoreDataMember] public virtual List<Data.ElectionLevelContract> ElectionLevelList
		{ get { return _ElectionLevel ?? (_ElectionLevel = logic.Data.ElectionLevelLogic.SelectBy_ElectionLevelIdNow(ElectionLevelId)); } }

		[IgnoreDataMember] protected List<Data.ElectionLevelContract> _ElectionLevel;
#endregion ElectionLevel Extension

	}
}