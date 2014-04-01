using System;
using System.Runtime.Serialization; //NOTE:Reference Required for DataContract and DataMember

///////////////////////////////////////////////////////////
//Do not modify this file. Use a partial class to extend.//
///////////////////////////////////////////////////////////
// This is the container part of the contract class.
// Fields are exposed as properties, override them by
// making a partial class of the front class (MetaDataContract).

namespace VotingInfo.Database.Contracts.Data
{
	[DataContract(Namespace = "MetaDataContractBase")]
	public abstract partial class MetaDataContractBase : ContractBase<MetaDataContractBase>
	{
        //Put your code in a separate file.  This is auto generated.
		//int
		[DataMember]
		public virtual int? MetaDataId { get; set; }

		//int
		[DataMember]
		public virtual int ContentInspectionId { get; set; }

		//varchar(150)
		[DataMember]
		public virtual string MetaDataName { get; set; }

		//bit
		[DataMember]
		public virtual bool IsRequired { get; set; }

		//bit
		[DataMember]
		public virtual bool AppliesAtAllLevels { get; set; }

		//bit
		[DataMember]
		public virtual bool AppliesToCandidates { get; set; }

		//bit
		[DataMember]
		public virtual bool AppliesToOrganizations { get; set; }

	}
}