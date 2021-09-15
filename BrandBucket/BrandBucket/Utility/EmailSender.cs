using Mailjet.Client;
using Mailjet.Client.Resources;
using Microsoft.AspNetCore.Identity.UI.Services;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrandBucket.Utility
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            return Execute(email, subject, htmlMessage);
        }

        public async Task Execute(string email, string subject, string body)
        {

            MailjetClient client = new MailjetClient("13fdc843fb3497e09ecaf3327d104905","60323939cd1f16cafef2aa2c5671560b")
            {
                Version = ApiVersion.V3_1,
            };
            MailjetRequest request = new MailjetRequest
            {
                Resource = Send.Resource,
            }
             .Property(Send.Messages, new JArray {
     new JObject {
      {
       "From",
       new JObject {
        {"Email", "jithinraj.devops@gmail.com"},
        {"Name", "Jithinraj"}
       }
      }, {
       "To",
       new JArray {
        new JObject {
         {
          "Email",
          email
         }, {
          "Name",
          "BrandBucket"
         }
        }
       }
      }, {
       "Subject",
       subject
      }, {
       "HTMLPart",
       body
      }
     }
             });
            await client.PostAsync(request);

        }
    }
}
