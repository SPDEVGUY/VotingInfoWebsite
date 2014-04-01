using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using VotingInfo.Database.Contracts;
using VotingInfo.Database.Contracts.Client;


namespace VotingInfo.WebSite.Services.Client
{
    // http://<machine_name>:<port>/Candidates/help to view the service's generated help page
    [ServiceContract]
    public partial interface CandidatesServiceInterface
    {        
        [OperationContract] [WebGet(UriTemplate = "{authId}/Exists({fldCandidateId})")]
        bool Exists(string authId, string fldCandidateId);


        [OperationContract] [WebInvoke(Method = "POST", UriTemplate = "{authId}/Search()")]
        List<CandidatesContract> Search(string authId, CandidatesServiceBase.SearchPx px);


        [OperationContract] [WebGet(UriTemplate = "{authId}/")]
        List<CandidatesContract> SelectAll(string authId);


        [OperationContract] [WebInvoke(Method = "POST", UriTemplate = "{authId}/SelectBy_CandidateId()")]
        List<CandidatesContract> SelectBy_CandidateId(string authId, CandidatesServiceBase.SelectBy_CandidateIdPx px);


        [OperationContract] [WebInvoke(Method = "POST", UriTemplate = "{authId}/SelectBy_ContentInspectionId()")]
        List<CandidatesContract> SelectBy_ContentInspectionId(string authId, CandidatesServiceBase.SelectBy_ContentInspectionIdPx px);


        [OperationContract] [WebInvoke(Method = "POST", UriTemplate = "{authId}/SelectBy_OrganizationId()")]
        List<CandidatesContract> SelectBy_OrganizationId(string authId, CandidatesServiceBase.SelectBy_OrganizationIdPx px);


        [OperationContract] [WebInvoke(Method = "POST", UriTemplate = "{authId}/SelectBy_ProposedByUserId()")]
        List<CandidatesContract> SelectBy_ProposedByUserId(string authId, CandidatesServiceBase.SelectBy_ProposedByUserIdPx px);


        [OperationContract] [WebInvoke(Method = "POST", UriTemplate = "{authId}/SelectBy_ConfirmedByUserId()")]
        List<CandidatesContract> SelectBy_ConfirmedByUserId(string authId, CandidatesServiceBase.SelectBy_ConfirmedByUserIdPx px);


        [OperationContract] [WebGet(UriTemplate = "{authId}/{fldCandidateId}")]
        CandidatesContract Get(string authId, string fldCandidateId);

    }
}
