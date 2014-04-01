using System;
using System.Runtime.Serialization; //NOTE:Reference Required for DataContract and DataMember

///////////////////////////////////////////////////////////
//Do not modify this file. Use a partial class to extend.//
///////////////////////////////////////////////////////////
// This is the container part of the contract class.
// Fields are exposed as properties, override them by
// making a partial class of the front class (ElectionLevelContract).

namespace VotingInfo.Database.Contracts.Data
{
	[DataContract(Namespace = "ElectionLevelContractBase")]
	public abstract partial class ElectionLevelContractBase : ContractBase<ElectionLevelContractBase>
	{
        //Put your code in a separate file.  This is auto generated.
		//int
		[DataMember]
		public virtual int? ElectionLevelId { get; set; }

		//int
		[DataMember]
		public virtual int ContentInspectionId { get; set; }

		//varchar(150)
		[DataMember]
		public virtual string ElectionLevelTitle { get; set; }

	}
}