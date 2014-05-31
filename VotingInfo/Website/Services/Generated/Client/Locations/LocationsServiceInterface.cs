using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using VotingInfo.Database.Contracts;
using VotingInfo.Database.Contracts.Client;


namespace VotingInfo.WebSite.Services.Client
{
    // http://<machine_name>:<port>/Locations/help to view the service's generated help page
    [ServiceContract]
    public partial interface LocationsServiceInterface
    {        
        [OperationContract] [WebGet(UriTemplate = "{authId}/Exists({fldLocationId})")]
        bool Exists(string authId, string fldLocationId);


        [OperationContract] [WebInvoke(Method = "POST", UriTemplate = "{authId}/Search()")]
        List<LocationsContract> Search(string authId, LocationsServiceBase.SearchPx px);


        [OperationContract] [WebGet(UriTemplate = "{authId}/")]
        List<LocationsContract> SelectAll(string authId);


        [OperationContract] [WebInvoke(Method = "POST", UriTemplate = "{authId}/SelectBy_LocationId()")]
        List<LocationsContract> SelectBy_LocationId(string authId, LocationsServiceBase.SelectBy_LocationIdPx px);


        [OperationContract] [WebInvoke(Method = "POST", UriTemplate = "{authId}/SelectBy_ContentInspectionId()")]
        List<LocationsContract> SelectBy_ContentInspectionId(string authId, LocationsServiceBase.SelectBy_ContentInspectionIdPx px);


        [OperationContract] [WebInvoke(Method = "POST", UriTemplate = "{authId}/SelectBy_ProposedByUserId()")]
        List<LocationsContract> SelectBy_ProposedByUserId(string authId, LocationsServiceBase.SelectBy_ProposedByUserIdPx px);


        [OperationContract] [WebInvoke(Method = "POST", UriTemplate = "{authId}/SelectBy_ConfirmedByUserId()")]
        List<LocationsContract> SelectBy_ConfirmedByUserId(string authId, LocationsServiceBase.SelectBy_ConfirmedByUserIdPx px);


        [OperationContract] [WebGet(UriTemplate = "{authId}/{fldLocationId}")]
        LocationsContract Get(string authId, string fldLocationId);

    }
}
