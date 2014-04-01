using System.Collections.Generic;
using logic = VotingInfo.Database.Logic;
using System.Runtime.Serialization;

//////////////////////////////////////////////////////////////
//Do not modify this file. Use a partial class to extend.	//
//Override methods in the logic front class.				//
//Use of this class will require you to have your contracts //
//in the same module (Dll/exe) as the logic.                //
//////////////////////////////////////////////////////////////

namespace VotingInfo.Database.Contracts.Auth
{
	public abstract partial class UserContractBase : logic.ICacheContainerEnabled<int>
	{
		//Put your code in a separate file.  This is auto generated.

             [IgnoreDataMember] public virtual int Cache_Identity { get { return UserId??0; } }
        [IgnoreDataMember] public virtual int Cache_ExpireInMiliseconds { get { return 300; } }


#region ContentInspectionConfirmedByUser Extension (Child)
		[IgnoreDataMember] public virtual Data.ContentInspectionContract ContentInspectionConfirmedByUser
		{ get { return ContentInspectionConfirmedByUserList == null || ContentInspectionConfirmedByUserList.Count == 0 ? null : ContentInspectionConfirmedByUserList[0]; } }

		[IgnoreDataMember] public virtual List<Data.ContentInspectionContract> ContentInspectionConfirmedByUserList
		{ get { return _ContentInspectionConfirmedByUser ?? (_ContentInspectionConfirmedByUser = logic.Data.ContentInspectionLogic.SelectBy_ConfirmedByUserIdNow((int)UserId)); } }

		[IgnoreDataMember] protected List<Data.ContentInspectionContract> _ContentInspectionConfirmedByUser;
#endregion ContentInspectionConfirmedByUser Extension

#region ContentInspectionProposedByUser Extension (Child)
		[IgnoreDataMember] public virtual Data.ContentInspectionContract ContentInspectionProposedByUser
		{ get { return ContentInspectionProposedByUserList == null || ContentInspectionProposedByUserList.Count == 0 ? null : ContentInspectionProposedByUserList[0]; } }

		[IgnoreDataMember] public virtual List<Data.ContentInspectionContract> ContentInspectionProposedByUserList
		{ get { return _ContentInspectionProposedByUser ?? (_ContentInspectionProposedByUser = logic.Data.ContentInspectionLogic.SelectBy_ProposedByUserIdNow((int)UserId)); } }

		[IgnoreDataMember] protected List<Data.ContentInspectionContract> _ContentInspectionProposedByUser;
#endregion ContentInspectionProposedByUser Extension

#region UserRole Extension (Child)
		[IgnoreDataMember] public virtual Auth.UserRoleContract UserRole
		{ get { return UserRoleList == null || UserRoleList.Count == 0 ? null : UserRoleList[0]; } }

		[IgnoreDataMember] public virtual List<Auth.UserRoleContract> UserRoleList
		{ get { return _UserRole ?? (_UserRole = logic.Auth.UserRoleLogic.SelectBy_UserIdNow((int)UserId)); } }

		[IgnoreDataMember] protected List<Auth.UserRoleContract> _UserRole;
#endregion UserRole Extension

	}
}