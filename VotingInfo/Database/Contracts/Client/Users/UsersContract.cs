using System;
using System.Runtime.Serialization; //Reference Required for DataContract and DataMember

///////////////////////////////////////////////////////////
//Do not modify this file. Use a partial class to extend.//
///////////////////////////////////////////////////////////
// This class is the front facing contract.
// Extend functionality by making a partial class, and overriding.

namespace VotingInfo.Database.Contracts.Client
{
	[DataContract(Namespace = "UsersContract")]
	public partial class UsersContract : UsersContractBase
	{
		//Put your code in a separate file.  This is auto generated.
	}
}