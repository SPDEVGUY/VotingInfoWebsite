using System;
using System.Runtime.Serialization; //NOTE:Reference Required for DataContract and DataMember

///////////////////////////////////////////////////////////
//Do not modify this file. Use a partial class to extend.//
///////////////////////////////////////////////////////////
// This is the container part of the contract class.
// Fields are exposed as properties, override them by
// making a partial class of the front class (LocationContract).

namespace VotingInfo.Database.Contracts.Data
{
	[DataContract(Namespace = "LocationContractBase")]
	public abstract partial class LocationContractBase : ContractBase<LocationContractBase>
	{
        //Put your code in a separate file.  This is auto generated.
		//int
		[DataMember]
		public virtual int? LocationId { get; set; }

		//int
		[DataMember]
		public virtual int ContentInspectionId { get; set; }

		//varchar(150)
		[DataMember]
		public virtual string LocationName { get; set; }

	}
}