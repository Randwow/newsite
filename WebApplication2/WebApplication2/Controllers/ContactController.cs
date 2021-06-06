

using Microsoft.Extensions.Logging;
using WebApplication2.Models;
using System;
using System.Net;
using System.Net.Mail;

using System.Diagnostics;
using System.Web.Mvc;
using eUseControl.BusinessLogic1;
using eUseControl.BusinessLogic1.Interfaces;
using eUseControl.Domain.Entities.Contact;

namespace WebApplication2.Controllers
{
    public class ContactController : Controller
    {
        internal readonly IContact _contact;

        public ContactController()
        {
            BusinessLogic bl = new BusinessLogic();
            _contact = bl.GetContactBL();
        }

        public ActionResult Index()
        {

            SendMailDto mm = new SendMailDto();

            return View(mm);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(SendMailDto sendMailDto)
        {
            if (ModelState.IsValid)
            {
                EmailContact econact = new EmailContact
                {
                    Name = sendMailDto.Name,
                    Message = sendMailDto.Message,
                    Subject = sendMailDto.Subject
                };

                bool status = _contact.SendEmail(econact);

                string email = "";
                //bool s = _contact.EmailValidation(email);
                return View();
            }

            return View();
        }
    }
}