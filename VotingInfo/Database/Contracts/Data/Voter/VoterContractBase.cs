using System;
using System.Runtime.Serialization; //NOTE:Reference Required for DataContract and DataMember

///////////////////////////////////////////////////////////
//Do not modify this file. Use a partial class to extend.//
///////////////////////////////////////////////////////////
// This is the container part of the contract class.
// Fields are exposed as properties, override them by
// making a partial class of the front class (VoterContract).

namespace VotingInfo.Database.Contracts.Data
{
	[DataContract(Namespace = "VoterContractBase")]
	public abstract partial class VoterContractBase : ContractBase<VoterContractBase>
	{
        //Put your code in a separate file.  This is auto generated.
		//int
		[DataMember]
		public virtual int? VoterId { get; set; }

		//int
		[DataMember]
		public virtual int UserId { get; set; }

		//int
		[DataMember]
		public virtual int ContentInspectionId { get; set; }

		//int
		[DataMember]
		public virtual int LocationId { get; set; }

		//varchar(150)
		[DataMember]
		public virtual string VoterName { get; set; }

		//char(6)
		[DataMember]
		public virtual string PostalCode { get; set; }

		//int
		[DataMember]
		public virtual int FavoriteOrganizationId { get; set; }

	}
}