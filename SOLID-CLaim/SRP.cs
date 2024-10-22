using System.Net.NetworkInformation;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SOLID_CLaim
{

    //**Single Responsibility Principle(SRP)**

    //PolicyValidator: Solely responsible for validating the policy number.
    public class PolicyValidator
    {
        public bool IsValid(string policyNo)
        {
            return !string.IsNullOrEmpty(policyNo) && policyNo.Length == 12;
        }
    }

    //PolicyVerifier: Solely responsible for verifying the policy through an API.
    public class PolicyVerifier
    {
        public bool Verify(string policyNo)
        {
            // Simulate an API call here.
            Console.WriteLine("Verifying policy number via API...");
            return true;
        }
    }

    //PolicyHandler: Solely responsible for coordinating the flow without being directly responsible for the underlying logic
    public class PolicyHandler
    {
        private readonly PolicyValidator _validator;
        private readonly PolicyVerifier _verifier;

        public PolicyHandler(PolicyValidator validator, PolicyVerifier verifier)
        {
            _validator = validator;
            _verifier = verifier;
        }

        public void Handle(string policyNo)
        {
            if (!_validator.IsValid(policyNo))
            {
                Console.WriteLine("Invalid policy number.");
                return;
            }

            bool isVerified = _verifier.Verify(policyNo);
            Console.WriteLine(isVerified ? "Policy verified successfully." : "Policy verification failed.");
        }
    }


}
