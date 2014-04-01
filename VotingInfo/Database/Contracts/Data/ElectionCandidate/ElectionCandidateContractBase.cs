using System;
using System.Runtime.Serialization; //NOTE:Reference Required for DataContract and DataMember

///////////////////////////////////////////////////////////
//Do not modify this file. Use a partial class to extend.//
///////////////////////////////////////////////////////////
// This is the container part of the contract class.
// Fields are exposed as properties, override them by
// making a partial class of the front class (ElectionCandidateContract).

namespace VotingInfo.Database.Contracts.Data
{
	[DataContract(Namespace = "ElectionCandidateContractBase")]
	public abstract partial class ElectionCandidateContractBase : ContractBase<ElectionCandidateContractBase>
	{
        //Put your code in a separate file.  This is auto generated.
		//int
		[DataMember]
		public virtual int? ElectionCandidateId { get; set; }

		//int
		[DataMember]
		public virtual int ContentInspectionId { get; set; }

		//int
		[DataMember]
		public virtual int CandidateId { get; set; }

		//int
		[DataMember]
		public virtual int ElectionId { get; set; }

		//bit
		[DataMember]
		public virtual bool IsWinner { get; set; }

		//bit
		[DataMember]
		public virtual bool ReportedVoteCount { get; set; }

	}
}