using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.Extensions.FileSystemGlobbing;
using SOLID_Claim;

namespace SOLID_CLaim
{
    //**Dependency Inversion Principle**

      public class ClaimProcessor : IClaimProcessor
    {

        //The high-level class ClaimProcessor depends on the abstractions(interfaces)
        //rather than specific implementations.

        private readonly IClaimSubmission _claimSubmission;
        private readonly INotifyInsurer _notifyInsurer;
        private readonly INotifyUser _notifyUser;

        // Dependency Injection via Constructor
        public ClaimProcessor(IClaimSubmission claimSubmission, INotifyInsurer notifyInsurer, INotifyUser notifyUser = null)
        {
            _claimSubmission = claimSubmission;
            _notifyInsurer = notifyInsurer;
            _notifyUser = notifyUser;
        }

        public void ProcessClaim(string policyNo)
        {
            // // Calls the appropriate SubmitClaim implementation
            if (_claimSubmission.SubmitClaim())
            {
                _notifyInsurer.SendInsurerNotification();
                _notifyUser?.SendUserNotification(); // Optional notification
            }
        }
    }


// //Here’s how you would create instances and utilize the ClaimProcessor

    //    Creating an instance for Microsoft
    //    var microsoftProcessor = new MicrosoftClaimProcessor();
    //    var claimProcessorForMicrosoft = new ClaimProcessor(microsoftProcessor, microsoftProcessor);

    //    Processing a claim for Microsoft
    //    claimProcessorForMicrosoft.ProcessClaim("policyMicrosoft123");

    //    Creating an instance for Dell
    //    var dellProcessor = new DellClaimProcessor();
    //    var claimProcessorForDell = new ClaimProcessor(dellProcessor, dellProcessor, dellProcessor);

    //    Processing a claim for Dell
    //    claimProcessorForDell.ProcessClaim("policyDell456");

}
