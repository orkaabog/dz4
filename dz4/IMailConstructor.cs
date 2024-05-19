using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4
{
    public interface IMailConstructor
    {
        IMailConstructor AddRecipient(string recipient);
        IMailConstructor AddSubject(string subject);
        IMailConstructor AddContent(string content);
        IMailConstructor AddAttachments(string attachments);
        Mail Construct();
    }

}
