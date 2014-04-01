using System;
using System.Runtime.Serialization; //NOTE:Reference Required for DataContract and DataMember

///////////////////////////////////////////////////////////
//Do not modify this file. Use a partial class to extend.//
///////////////////////////////////////////////////////////
// This is the container part of the contract class.
// Fields are exposed as properties, override them by
// making a partial class of the front class (ElectionLevelMetaDataXrefContract).

namespace VotingInfo.Database.Contracts.Data
{
	[DataContract(Namespace = "ElectionLevelMetaDataXrefContractBase")]
	public abstract partial class ElectionLevelMetaDataXrefContractBase : ContractBase<ElectionLevelMetaDataXrefContractBase>
	{
        //Put your code in a separate file.  This is auto generated.
		//int
		[DataMember]
		public virtual int? ElectionLevelMetaDataXrefId { get; set; }

		//int
		[DataMember]
		public virtual int ContentInspectionId { get; set; }

		//int
		[DataMember]
		public virtual int ElectionLevelId { get; set; }

		//(Nullable) nchar(10)
		[DataMember]
		public virtual string MetaDataId { get; set; }

	}
}