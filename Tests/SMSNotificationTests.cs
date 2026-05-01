using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cli_Test_Solution;

namespace Cli_Test_Solution.Tests
{
    [TestClass]
    public class SMSNotificationTests
    {

        [DataTestMethod]
        [DataRow(null)]
        [DataRow("")]
        [DataRow("   ")]
        public async Task Notify_InvalidSender_ThrowsArgumentException(string sender)
        {
            // Arrange
            var smsNotification = new SMSNotification();
            var message = "Test message";
            var recipient = "TestRecipient";

            // Act & Assert
            var exception = await Assert.ThrowsExceptionAsync<ArgumentException>(
                () => smsNotification.Notify(sender, message, recipient));
            Assert.AreEqual("sender", exception.ParamName);
        }

        [DataTestMethod]
        [DataRow(null)]
        [DataRow("")]
        [DataRow("   ")]
        public async Task Notify_InvalidMessage_ThrowsArgumentException(string message)
        {
            // Arrange
            var smsNotification = new SMSNotification();
            var sender = "TestSender";
            var recipient = "TestRecipient";

            // Act & Assert
            var exception = await Assert.ThrowsExceptionAsync<ArgumentException>(
                () => smsNotification.Notify(sender, message, recipient));
            Assert.AreEqual("message", exception.ParamName);
        }

        [DataTestMethod]
        [DataRow(null)]
        [DataRow("")]
        [DataRow("   ")]
        public async Task Notify_InvalidRecipient_ThrowsArgumentException(string recipient)
        {
            // Arrange
            var smsNotification = new SMSNotification();
            var sender = "TestSender";
            var message = "Test message";

            // Act & Assert
            var exception = await Assert.ThrowsExceptionAsync<ArgumentException>(
                () => smsNotification.Notify(sender, message, recipient));
            Assert.AreEqual("recipient", exception.ParamName);
        }
    }
}