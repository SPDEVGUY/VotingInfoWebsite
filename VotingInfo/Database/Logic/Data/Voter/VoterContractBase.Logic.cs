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
	public abstract partial class VoterContractBase : logic.ICacheContainerEnabled<int>
	{
		//Put your code in a separate file.  This is auto generated.

             [IgnoreDataMember] public virtual int Cache_Identity { get { return VoterId??0; } }
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

#region FavoriteOrganization Extension (Parent)
		[IgnoreDataMember] public virtual Data.OrganizationContract FavoriteOrganization
		{ get { return FavoriteOrganizationList == null || FavoriteOrganizationList.Count == 0 ? null : FavoriteOrganizationList[0]; } }

		[IgnoreDataMember] public virtual List<Data.OrganizationContract> FavoriteOrganizationList
		{ get { return _FavoriteOrganization ?? (_FavoriteOrganization = logic.Data.OrganizationLogic.SelectBy_OrganizationIdNow(FavoriteOrganizationId)); } }

		[IgnoreDataMember] protected List<Data.OrganizationContract> _FavoriteOrganization;
#endregion FavoriteOrganization Extension

	}
}