using System;
using System.Runtime.Serialization; //NOTE:Reference Required for DataContract and DataMember

///////////////////////////////////////////////////////////
//Do not modify this file. Use a partial class to extend.//
///////////////////////////////////////////////////////////
// This is the container part of the contract class.
// Fields are exposed as properties, override them by
// making a partial class of the front class (OrganizationContract).

namespace VotingInfo.Database.Contracts.Data
{
	[DataContract(Namespace = "OrganizationContractBase")]
	public abstract partial class OrganizationContractBase : ContractBase<OrganizationContractBase>
	{
        //Put your code in a separate file.  This is auto generated.
		//int
		[DataMember]
		public virtual int? OrganizationId { get; set; }

		//int
		[DataMember]
		public virtual int ContentInspectionId { get; set; }

		//varchar(250)
		[DataMember]
		public virtual string OrganizationName { get; set; }

	}
}