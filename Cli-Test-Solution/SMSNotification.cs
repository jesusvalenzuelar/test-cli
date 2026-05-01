using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cli_Test_Solution
{
    public class SMSNotification: INotification 
    {
        public SMSNotification() { }

        public async Task Notify(string sender, string message, string recipient)
        {
            if (string.IsNullOrWhiteSpace(sender))
                throw new ArgumentException("Sender cannot be null or empty.", nameof(sender));

            if (string.IsNullOrWhiteSpace(message))
                throw new ArgumentException("Message cannot be null or empty.", nameof(message));

            if (string.IsNullOrWhiteSpace(recipient))
                throw new ArgumentException("Recipient cannot be null or empty.", nameof(recipient));

            await Task.Run(() =>
            {
                Console.WriteLine("=== SMS NOTIFICATION ===");
                Console.WriteLine($"From: {sender}");
                Console.WriteLine($"To: {recipient}");
                Console.WriteLine($"Message: {message}");
                Console.WriteLine($"Sent at: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
                Console.WriteLine("========================");
            });
        }
    }
}
