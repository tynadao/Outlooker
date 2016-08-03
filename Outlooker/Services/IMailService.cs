using System;
namespace Outlooker.Services
{
    public interface IMailService
    {
        bool SendMail(string from, string to, string subject, string message);
    }
}
