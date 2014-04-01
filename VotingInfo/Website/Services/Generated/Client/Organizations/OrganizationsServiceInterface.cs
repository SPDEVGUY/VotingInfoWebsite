using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using VotingInfo.Database.Contracts;
using VotingInfo.Database.Contracts.Client;


namespace VotingInfo.WebSite.Services.Client
{
    // http://<machine_name>:<port>/Organizations/help to view the service's generated help page
    [ServiceContract]
    public partial interface OrganizationsServiceInterface
    {        
        [OperationContract] [WebGet(UriTemplate = "{authId}/Exists({fldOrganizationId})")]
        bool Exists(string authId, string fldOrganizationId);


        [OperationContract] [WebInvoke(Method = "POST", UriTemplate = "{authId}/Search()")]
        List<OrganizationsContract> Search(string authId, OrganizationsServiceBase.SearchPx px);


        [OperationContract] [WebGet(UriTemplate = "{authId}/")]
        List<OrganizationsContract> SelectAll(string authId);


        [OperationContract] [WebInvoke(Method = "POST", UriTemplate = "{authId}/SelectBy_OrganizationId()")]
        List<OrganizationsContract> SelectBy_OrganizationId(string authId, OrganizationsServiceBase.SelectBy_OrganizationIdPx px);


        [OperationContract] [WebInvoke(Method = "POST", UriTemplate = "{authId}/SelectBy_ContentInspectionId()")]
        List<OrganizationsContract> SelectBy_ContentInspectionId(string authId, OrganizationsServiceBase.SelectBy_ContentInspectionIdPx px);


        [OperationContract] [WebInvoke(Method = "POST", UriTemplate = "{authId}/SelectBy_ProposedByUserId()")]
        List<OrganizationsContract> SelectBy_ProposedByUserId(string authId, OrganizationsServiceBase.SelectBy_ProposedByUserIdPx px);


        [OperationContract] [WebInvoke(Method = "POST", UriTemplate = "{authId}/SelectBy_ConfirmedByUserId()")]
        List<OrganizationsContract> SelectBy_ConfirmedByUserId(string authId, OrganizationsServiceBase.SelectBy_ConfirmedByUserIdPx px);


        [OperationContract] [WebGet(UriTemplate = "{authId}/{fldOrganizationId}")]
        OrganizationsContract Get(string authId, string fldOrganizationId);

    }
}
