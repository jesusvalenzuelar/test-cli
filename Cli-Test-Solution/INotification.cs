using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cli_Test_Solution
{
    public interface INotification
    {
        Task Notify(string sender, string message, string recipient);
    }
}
