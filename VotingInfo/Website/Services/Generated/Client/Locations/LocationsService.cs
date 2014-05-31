using System.ServiceModel;
using System.ServiceModel.Activation;

namespace VotingInfo.WebSite.Services.Client
{
    // http://<machine_name>:<port>/Client/Locations/help to view the service's generated help page
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
        [ServiceBehavior(
        InstanceContextMode = InstanceContextMode.PerCall
#if DEBUG
        ,IncludeExceptionDetailInFaults = true
#endif
    )]
    public partial class LocationsService : LocationsServiceBase, LocationsServiceInterface { }
}
