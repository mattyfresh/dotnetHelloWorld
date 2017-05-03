using System.Diagnostics;

namespace TheWorld.Services
{
    public class DebugMailService : IMailService
    {
        public void SendMail(string to, string from, string subject, string body)
        {
            Debug.WriteLine($"Email to: {to}, from: {from}, with subject: {subject}");
        }
    }
}
