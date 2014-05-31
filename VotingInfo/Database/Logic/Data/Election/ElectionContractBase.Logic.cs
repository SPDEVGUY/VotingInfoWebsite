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
	public abstract partial class ElectionContractBase : logic.ICacheContainerEnabled<int>
	{
		//Put your code in a separate file.  This is auto generated.

             [IgnoreDataMember] public virtual int Cache_Identity { get { return ElectionId??0; } }
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

#region Location Extension (Parent)
		[IgnoreDataMember] public virtual Data.LocationContract Location
		{ get { return LocationList == null || LocationList.Count == 0 ? null : LocationList[0]; } }

		[IgnoreDataMember] public virtual List<Data.LocationContract> LocationList
		{ get { return _Location ?? (_Location = logic.Data.LocationLogic.SelectBy_LocationIdNow(LocationId)); } }

		[IgnoreDataMember] protected List<Data.LocationContract> _Location;
#endregion Location Extension

#region ElectionCandidate Extension (Child)
		[IgnoreDataMember] public virtual Data.ElectionCandidateContract ElectionCandidate
		{ get { return ElectionCandidateList == null || ElectionCandidateList.Count == 0 ? null : ElectionCandidateList[0]; } }

		[IgnoreDataMember] public virtual List<Data.ElectionCandidateContract> ElectionCandidateList
		{ get { return _ElectionCandidate ?? (_ElectionCandidate = logic.Data.ElectionCandidateLogic.SelectBy_ElectionIdNow((int)ElectionId)); } }

		[IgnoreDataMember] protected List<Data.ElectionCandidateContract> _ElectionCandidate;
#endregion ElectionCandidate Extension

	}
}