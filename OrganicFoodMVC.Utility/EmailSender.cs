using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using PostmarkDotNet;
using PostmarkDotNet.Legacy;
using PostmarkDotNet.Model;
using System;
using System.Collections.Specialized;
using System.IO;
using System.IO.Pipelines;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace OrganicFoodMVC.Utility
{
	public class EmailSender : IEmailSender
	{

		private readonly EmailOptions emailOptions;

		public EmailSender(IOptions<EmailOptions> options)
		{
			emailOptions = options.Value;
		}

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            throw new NotImplementedException();
        }
    }
}
