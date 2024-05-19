using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4
{
    public class SMTP
    {
        IMailConstructor mailConstructor;

        public SMTP(IMailConstructor mailConstructor)
        {
            this.mailConstructor = mailConstructor;
        }

        public void SendNoReplyMail()
        {
            Mail mail = mailConstructor
                            .AddRecipient("elon.musk@tesla.com")
                            .AddSubject("Hello")
                            .AddContent("One Tesla pls")
                            .AddAttachments("Cookie")
                            .Construct();
            SendMail(mail);
        }

        public void SendMail(Mail mail)
        {
            Console.WriteLine($"Sending mail to {mail.Recipient}");
            Console.WriteLine($"Subject: {mail.Subject}");
            Console.WriteLine($"Content: {mail.Content}");
            Console.WriteLine($"Attachments: {mail.Attachments}");
        }
    }

}
