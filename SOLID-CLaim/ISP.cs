namespace SOLID_Claim
{
    // **Interface Segregation Principle (ISP)**

    //MicrosoftClaimProcessor only implements IClaimSubmission and INotifyInsurer,
    //indicating that it only needs to submit claims and notify the insurer, without any user notification logic
    public interface IClaimSubmission
    {
        bool SubmitClaim();
    }

    // Interface for sending notifications to the insurer
    public interface INotifyInsurer
    {
        void SendInsurerNotification();
    }

    // Interface for sending notifications to the user
    public interface INotifyUser
    {
        bool SendUserNotification();
    }

    // This interface represents a high-level module that processes claims
    public interface IClaimProcessor
    {
        void ProcessClaim(string policyNo);
    }

    // Microsoft client that only submits claims and notifies the insurer
    public class MicrosoftClaimProcessor : IClaimSubmission, INotifyInsurer
    {
        public bool SubmitClaim()
        {
            // Logic to submit the claim for Microsoft
            return true; // Assuming success
        }

        public void SendInsurerNotification()
        {
            // Logic to send notification to insurer for Microsoft
        }
    }

    // Dell client that submits claims and also sends user notifications
    public class DellClaimProcessor : IClaimSubmission, INotifyInsurer, INotifyUser
    {
        public bool SubmitClaim()
        {
            // Logic to submit the claim for Dell
            return true; // Assuming success
        }

        public void SendInsurerNotification()
        {
            // Logic to send notification to insurer for Dell
        }

        public bool SendUserNotification()
        {
            // Logic to send notification to the user for Dell
            return true; // Assuming success
        }
    }

    // Google client that only submits claims and notifies the insurer
    public class GoogleClaimProcessor : IClaimSubmission, INotifyInsurer
    {
        public bool SubmitClaim()
        {
            // Logic to submit the claim for Google
            return true; // Assuming success
        }

        public void SendInsurerNotification()
        {
            // Logic to send notification to insurer for Google
        }
    }
}
