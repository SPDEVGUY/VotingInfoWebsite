using System;
using System.Runtime.Serialization; //NOTE:Reference Required for DataContract and DataMember

///////////////////////////////////////////////////////////
//Do not modify this file. Use a partial class to extend.//
///////////////////////////////////////////////////////////
// This is the container part of the contract class.
// Fields are exposed as properties, override them by
// making a partial class of the front class (CandidateContract).

namespace VotingInfo.Database.Contracts.Data
{
	[DataContract(Namespace = "CandidateContractBase")]
	public abstract partial class CandidateContractBase : ContractBase<CandidateContractBase>
	{
        //Put your code in a separate file.  This is auto generated.
		//int
		[DataMember]
		public virtual int? CandidateId { get; set; }

		//int
		[DataMember]
		public virtual int ContentInspectionId { get; set; }

		//varchar(150)
		[DataMember]
		public virtual string CandidateName { get; set; }

		//int
		[DataMember]
		public virtual int OrganizationId { get; set; }

	}
}