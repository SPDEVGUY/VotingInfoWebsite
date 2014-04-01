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
	public abstract partial class ElectionCandidateContractBase : logic.ICacheContainerEnabled<int>
	{
		//Put your code in a separate file.  This is auto generated.

             [IgnoreDataMember] public virtual int Cache_Identity { get { return ElectionCandidateId??0; } }
        [IgnoreDataMember] public virtual int Cache_ExpireInMiliseconds { get { return 300; } }


#region Candidate Extension (Parent)
		[IgnoreDataMember] public virtual Data.CandidateContract Candidate
		{ get { return CandidateList == null || CandidateList.Count == 0 ? null : CandidateList[0]; } }

		[IgnoreDataMember] public virtual List<Data.CandidateContract> CandidateList
		{ get { return _Candidate ?? (_Candidate = logic.Data.CandidateLogic.SelectBy_CandidateIdNow(CandidateId)); } }

		[IgnoreDataMember] protected List<Data.CandidateContract> _Candidate;
#endregion Candidate Extension

#region ContentInspection Extension (Parent)
		[IgnoreDataMember] public virtual Data.ContentInspectionContract ContentInspection
		{ get { return ContentInspectionList == null || ContentInspectionList.Count == 0 ? null : ContentInspectionList[0]; } }

		[IgnoreDataMember] public virtual List<Data.ContentInspectionContract> ContentInspectionList
		{ get { return _ContentInspection ?? (_ContentInspection = logic.Data.ContentInspectionLogic.SelectBy_ContentInspectionIdNow(ContentInspectionId)); } }

		[IgnoreDataMember] protected List<Data.ContentInspectionContract> _ContentInspection;
#endregion ContentInspection Extension

#region Election Extension (Parent)
		[IgnoreDataMember] public virtual Data.ElectionContract Election
		{ get { return ElectionList == null || ElectionList.Count == 0 ? null : ElectionList[0]; } }

		[IgnoreDataMember] public virtual List<Data.ElectionContract> ElectionList
		{ get { return _Election ?? (_Election = logic.Data.ElectionLogic.SelectBy_ElectionIdNow(ElectionId)); } }

		[IgnoreDataMember] protected List<Data.ElectionContract> _Election;
#endregion Election Extension

	}
}