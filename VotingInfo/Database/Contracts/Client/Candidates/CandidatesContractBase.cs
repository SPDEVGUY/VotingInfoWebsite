using System;
using System.Runtime.Serialization; //NOTE:Reference Required for DataContract and DataMember

///////////////////////////////////////////////////////////
//Do not modify this file. Use a partial class to extend.//
///////////////////////////////////////////////////////////
// This is the container part of the contract class.
// Fields are exposed as properties, override them by
// making a partial class of the front class (CandidatesContract).

namespace VotingInfo.Database.Contracts.Client
{
	[DataContract(Namespace = "CandidatesContractBase")]
	public abstract partial class CandidatesContractBase : ContractBase<CandidatesContractBase>
	{
        //Put your code in a separate file.  This is auto generated.
		//int
		[DataMember]
		public virtual int CandidateId { get; set; }

		//int
		[DataMember]
		public virtual int ContentInspectionId { get; set; }

		//varchar(150)
		[DataMember]
		public virtual string CandidateName { get; set; }

		//int
		[DataMember]
		public virtual int OrganizationId { get; set; }

		//bit
		[DataMember]
		public virtual bool IsArchived { get; set; }

		//bit
		[DataMember]
		public virtual bool IsBeingProposed { get; set; }

		//int
		[DataMember]
		public virtual int ProposedByUserId { get; set; }

		//int
		[DataMember]
		public virtual int ConfirmedByUserId { get; set; }

		//int
		[DataMember]
		public virtual int FalseInfoCount { get; set; }

		//int
		[DataMember]
		public virtual int TrueInfoCount { get; set; }

		//bit
		[DataMember]
		public virtual bool AdminInpsected { get; set; }

		//datetime
		[DataMember]
		public virtual DateTime DateLastChecked { get; set; }

		//varchar(250)
		[DataMember]
		public virtual string SourceUrl { get; set; }

	}
}