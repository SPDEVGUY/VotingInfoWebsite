using System;
using System.Runtime.Serialization; //NOTE:Reference Required for DataContract and DataMember

///////////////////////////////////////////////////////////
//Do not modify this file. Use a partial class to extend.//
///////////////////////////////////////////////////////////
// This is the container part of the contract class.
// Fields are exposed as properties, override them by
// making a partial class of the front class (OrganizationMetaDataContract).

namespace VotingInfo.Database.Contracts.Data
{
	[DataContract(Namespace = "OrganizationMetaDataContractBase")]
	public abstract partial class OrganizationMetaDataContractBase : ContractBase<OrganizationMetaDataContractBase>
	{
        //Put your code in a separate file.  This is auto generated.
		//int
		[DataMember]
		public virtual int? OrganizationMetaDataId { get; set; }

		//int
		[DataMember]
		public virtual int ContentInspectionId { get; set; }

		//int
		[DataMember]
		public virtual int OrganizationId { get; set; }

		//int
		[DataMember]
		public virtual int MetaDataId { get; set; }

		//varchar(max)
		[DataMember]
		public virtual string MetaDataValue { get; set; }

	}
}