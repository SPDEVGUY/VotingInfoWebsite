using System;
using System.Runtime.Serialization; //NOTE:Reference Required for DataContract and DataMember

///////////////////////////////////////////////////////////
//Do not modify this file. Use a partial class to extend.//
///////////////////////////////////////////////////////////
// This is the container part of the contract class.
// Fields are exposed as properties, override them by
// making a partial class of the front class (CandidateMetaDataContract).

namespace VotingInfo.Database.Contracts.Data
{
	[DataContract(Namespace = "CandidateMetaDataContractBase")]
	public abstract partial class CandidateMetaDataContractBase : ContractBase<CandidateMetaDataContractBase>
	{
        //Put your code in a separate file.  This is auto generated.
		//int
		[DataMember]
		public virtual int? CandidateMetaDataId { get; set; }

		//int
		[DataMember]
		public virtual int ContentInspectionId { get; set; }

		//int
		[DataMember]
		public virtual int CandidateId { get; set; }

		//int
		[DataMember]
		public virtual int MetaDataId { get; set; }

		//varchar(max)
		[DataMember]
		public virtual string MetaDataValue { get; set; }

	}
}