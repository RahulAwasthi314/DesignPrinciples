using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility._1_Design
{
    internal interface IAuthProcess
    {
        bool Login(string username, string password);
        bool Register(string username, string password);
        bool LogError(string message);
        bool SendVerificationEmail(string email);
    }
}

// Here the whole authentication process is described as an interface
// This code is tightly coupled.
